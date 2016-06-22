using CommonShare.Controller;
using CommonShare.Event;
using CommonShare.Model;
using CommonShare.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Controller
{
	public class TcpServer
	{
		public event RecevedMessage RecevedMessage;
		public event SentMessage SentMessage;
		public event SentFile SentFile;

		public event ClientListChange ClientListChange;
		private bool isStopService = false;
		

		private List<TcpClientController> tcpClientControllers = new List<TcpClientController>();
		private object listControllerLockObject = new object();

		private TcpListener tcpListener;
		
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

		public void Stop()
		{
			try
			{
				tcpListener.Stop();
				isStopService = true;
			}
			catch { }
		}

		private void ServiceRunning()
		{
			tcpListener.Start();
			Console.WriteLine("Server started");

			while (!isStopService)
			{
				try
				{
					if (!tcpListener.Pending())
					{
						Thread.Sleep(500); 
						continue; 
					}

					var tcpClient = tcpListener.AcceptTcpClient();
					var tcpClientController = new TcpClientController(tcpClient);

					tcpClientController.ReceivedMessage += Waiter_ReceiveMessage;
					tcpClientController.SentFile += TcpClientController_SentFile;
					//tcpClientController. += Waiter_ClientDisconned;

					tcpClientController.StartListen();

					lock (listControllerLockObject)
					{
						tcpClientControllers.Add(tcpClientController);
					}
					ClientListChange?.Invoke();
				}
				catch { }
				
			}
		}

		private void TcpClientController_SentFile(TcpClientController sender, string fileName, long sentByte, long totalByte)
		{
			SentFile?.Invoke(sender, fileName, sentByte, totalByte);
		}

		public SenderView[] GetButton()
		{
			lock (listControllerLockObject)
			{
				return tcpClientControllers.Select(x => x.Client.SenderView).ToArray();
			}
		}

		private void Waiter_ClientDisconned(TcpClientController disconnecter)
		{
			lock (listControllerLockObject)
			{
				if (tcpClientControllers.Contains(disconnecter))
				{
					Console.WriteLine("Remove a client");
					tcpClientControllers.Remove(disconnecter);
					ClientListChange?.Invoke();
				}
			}
		}

		private void Waiter_ReceiveMessage(TcpClientController sender, string origin, string encripted)
		{
			BroadcastMessage(sender, encripted);
			RecevedMessage?.Invoke(sender, origin, encripted);
		}

		public void BroadcastFile(TcpClientController fromController, string fileName)
		{
			lock (listControllerLockObject)
			{
				var sentEncripted = string.Empty;
				foreach (var controller in tcpClientControllers)
				{
					if (controller != fromController && !isStopService)
					{
						controller.SendFile(fileName);
					}
				}
			}
		}

		public void BroadcastMessage(TcpClientController fromController, string message)
		{
			lock (listControllerLockObject)
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
