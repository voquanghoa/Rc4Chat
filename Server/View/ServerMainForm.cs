using CommonShare.Controller;
using CommonShare.Model;
using CommonShare.View;
using Server.Controller;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Server.View
{
	public partial class ServerMainForm : CoolForm
	{
		private TcpServer tcpServer;
		private ConversationController conversationController = new ConversationController();

		public ServerMainForm()
		{
			InitializeComponent();
		}

		private void ServerMainForm_Load(object sender, EventArgs e)
		{
			tcpServer = new TcpServer(Constants.DefaultAddress, Constants.DefaultPort);
			tcpServer.RecevedMessage += TcpServer_RecevedMessage;
			tcpServer.SentMessage += TcpServer_SentMessage;
			tcpServer.ClientListChange += TcpServer_ClientListChange;
			tcpServer.SentFile += TcpServer_SentFile;
			tcpServer.ReceivedFile += TcpServer_ReceivedFile;

			tcpServer.StartBind();
		}

		private void TcpServer_ReceivedFile(TcpClientController sender, string fileName, long sentByte, long totalByte)
		{
			Invoke(new Action(() =>
			{
				if (sentByte < totalByte)
				{
					progressDialog1.Visible = true;
					progressDialog1.Action = "Đã nhận: ";
					progressDialog1.ValueDone = sentByte;
					progressDialog1.ValueTotal = totalByte;
					progressDialog1.UpdateValues();
				}
				else
				{
					progressDialog1.Visible = false;
					conversationController.Add(sender.Client, Path.Combine(Application.StartupPath, fileName), totalByte);
					UpdateMessageList();
				}
			}));
		}

		private void TcpServer_SentFile(TcpClientController sender, string fileName, long sentByte, long totalByte)
		{
			Invoke(new Action(() =>
			{
				if (sentByte < totalByte)
				{
					progressDialog1.Visible = true;
					progressDialog1.Action = "Đã gửi ";
					progressDialog1.ValueDone = sentByte;
					progressDialog1.ValueTotal = totalByte;
					progressDialog1.UpdateValues();
				}
				else
				{
					progressDialog1.Visible = false;
					conversationController.Add(null, "Đã gửi file: " +fileName, "");
					UpdateMessageList();
				}
			}));
		}

		private void TcpServer_ClientListChange()
		{
			var buttons = tcpServer.GetButton();
			Invoke(new Action(() => senderList1.AddButtons(buttons)));
		}

		private void TcpServer_SentMessage(TcpClientController sender, string originMessage, string encryptedMessage)
		{
			conversationController.Add(null, originMessage, encryptedMessage);
			UpdateMessageList();
		}

		private void TcpServer_RecevedMessage(TcpClientController sender, string originMessage, string decryptedMessage)
		{
			conversationController.Add(sender.Client, decryptedMessage, originMessage);
			UpdateMessageList();
		}


		private void UpdateMessageList()
		{
			Invoke(new Action(() =>
			{
				conversationBrower.Document.Write(conversationController.GetHtml(true));
				conversationBrower.Refresh();
			}));
		}

		private void sendMessageControl_SendMessage(string message)
		{
			new Thread(() =>{tcpServer.BroadcastMessage(null, message);}).Start();
		}

		private void senderList1_UpdateList()
		{
			UpdateMessageList();
		}

		private void ServerMainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (tcpServer != null)
			{
				tcpServer.Stop();
				tcpServer = null;
			}
			Application.Exit();
		}

		private void sendMessageControl_SendFile(string fileName)
		{
			new Thread(() => { tcpServer.BroadcastFile(null, fileName); }).Start();
			
		}
	}
}
