using CommonShare.Controller;
using CommonShare.Model;
using CommonShare.View;
using Server.Controller;
using System;

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
			tcpServer.StartBind();
		}

		private void TcpServer_SentMessage(TcpClientController sender, string originMessage, string encryptedMessage)
		{
			conversationController.Add(null, originMessage, originMessage);
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
			tcpServer.BroadcastMessage(null, message);
		}
	}
}
