using CommonShare.Controller;
using CommonShare.Model;
using CommonShare.Util;
using CommonShare.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
			tcpClientController.StartListen();
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
	}
}
