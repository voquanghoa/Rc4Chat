using CommonShare.Controller;
using CommonShare.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Controller
{
	public class TcpServer
	{
		public event RecevedMessage RecevedMessage;
		public event SentMessage SentMessage;


		private List<TcpClientController> tcpClientControllers = new List<TcpClientController>();
		private TcpListener tcpListener;
		private object locker = new object();
		private Thread mainThread;

		public TcpServer(string ip, int port)
		{
			tcpListener = new TcpListener(IPAddress.Parse(ip), port);
		}

		public void StartBind()
		{
			mainThread = new Thread(ServiceRunning);
			mainThread.Start();
		}

		private void ServiceRunning()
		{
			tcpListener.Start();
			Console.WriteLine("Server started");

			while (true)
			{
				var tcpClient = tcpListener.AcceptTcpClient();
				var tcpClientController = new TcpClientController(tcpClient);

				tcpClientController.ReceivedMessage += Waiter_ReceiveMessage;
				//tcpClientController. += Waiter_ClientDisconned;

				tcpClientController.StartListen();

				lock (locker)
				{
					tcpClientControllers.Add(tcpClientController);
				}
			}
		}

		private void Waiter_ClientDisconned(TcpClientController disconnecter)
		{
			lock (locker)
			{
				if (tcpClientControllers.Contains(disconnecter))
				{
					Console.WriteLine("Remove a client");
					tcpClientControllers.Remove(disconnecter);
				}
			}
		}

		private void Waiter_ReceiveMessage(TcpClientController sender, string origin, string encripted)
		{
			BroadcastMessage(sender, encripted);
			RecevedMessage?.Invoke(sender, origin, encripted);
		}

		public void BroadcastMessage(TcpClientController fromController, string message)
		{
			lock (locker)
			{
				var sentEncripted = string.Empty;
				foreach (var controller in tcpClientControllers)
				{
					if (controller != fromController)
					{
						sentEncripted = controller.Send(message);
					}
				}

				if (fromController == null && sentEncripted!=string.Empty)
				{
					SentMessage?.Invoke(null, message, sentEncripted);
				}
			}
		}
	}
}
