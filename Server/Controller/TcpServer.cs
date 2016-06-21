using CommonShare.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controller
{
	public delegate void ReciveMessage(TcpClientController receiver, byte[] data);
	public delegate void ClientDisconned(TcpClientController disconnecter);

	public class TcpServer
	{
		private List<TcpClientController> tcpClientControllers = new List<TcpClientController>();
		private TcpListener tcpListener;
		private object locker = new object();

		public TcpServer(string ip, int port)
		{
			tcpListener = new TcpListener(IPAddress.Parse(ip), port);
		}

		public void Bind()
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

		private void Waiter_ReceiveMessage(TcpClientController receiver, string origin, string encripted)
		{
			lock (locker)
			{
				foreach (var controller in tcpClientControllers)
				{
					if (controller != receiver)
					{
						controller.Send(encripted);
					}
				}
			}
		}
	}
}
