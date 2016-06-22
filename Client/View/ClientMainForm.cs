using CommonShare.Controller;
using CommonShare.Model;
using CommonShare.Util;
using CommonShare.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public partial class ClientMainForm : CoolForm
	{
		private TcpClientController tcpClientController;
		private ConversationController conversationController = new ConversationController();

		public ClientMainForm()
		{
			InitializeComponent();
		}

		private void ClientMainForm_Load(object sender, EventArgs e)
		{
			tcpClientController = new TcpClientController(Constants.DefaultAddress, Constants.DefaultPort);
			tcpClientController.ReceivedMessage += TcpClientController_ReceivedMessage;
			tcpClientController.SentMessage += TcpClientController_SentMessage;

			tcpClientController.OnError += TcpClientController_OnError;

			tcpClientController.ReceivedFile += TcpClientController_ReceivedFile;
			tcpClientController.SentFile += TcpClientController_SentFile;

			tcpClientController.StartListen();
		}

		private void TcpClientController_SentFile(TcpClientController sender, string fileName, long sentByte, long totalByte)
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
					conversationController.Add(null, "Đã gửi file "+ fileName, "");
					UpdateMessageList();
				}
			}));
		}

		private void TcpClientController_ReceivedFile(TcpClientController sender, string fileName, long sentByte, long totalByte)
		{
			Invoke(new Action(() =>
			{
				if (sentByte < totalByte)
				{
					progressDialog1.Visible = true;
					progressDialog1.Action = "Đã nhận ";
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

		private void TcpClientController_OnError(string message)
		{
			ViewUtils.ShowEror($"Không thể kết nối được tới server.\n{message}");
			tcpClientController = null;
			Application.Exit();
		}

		private void TcpClientController_SentMessage(TcpClientController sender, string originMessage, string encryptedMessage)
		{
			conversationController.Add(null, originMessage, encryptedMessage);
			UpdateMessageList();
		}

		private void TcpClientController_ReceivedMessage(TcpClientController sender, string originMessage, string decryptedMessage)
		{
			conversationController.Add(sender.Client, decryptedMessage, originMessage);
			UpdateMessageList();
		}

		private void UpdateMessageList()
		{
			Invoke(new Action(() =>
			{
				conversationBrower.Document.Write(conversationController.GetHtml(false));
				conversationBrower.Refresh();
			}));
		}

		private void sendControl1_SendMessage(string message)
		{
			tcpClientController.Send(message);
		}

		private void sendControl1_SendFile(string fileName)
		{
			tcpClientController.SendFile(fileName);
		}

		private void ClientMainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (tcpClientController != null)
			{
				tcpClientController.Stop();
				tcpClientController = null;
			}
			Application.Exit();
		}
	}
}
