using CommonShare.Model;
using CommonShare.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommonShare.Controller
{
	public delegate void RecevedMessage(TcpClientController sender, string originMessage, string decryptedMessage);
	public delegate void SentMessage(TcpClientController sender, string originMessage, string encryptedMessage);

	public delegate void OnError(string message);

	public class TcpClientController
	{
		#region Properties
		public Client Client { private set; get; }
		#endregion

		#region Fields
		private TcpClient tcpClient;

		private RC4Stream stream;
		private Thread thread;
		private Encoding encoding = Encoding.ASCII;
		#endregion

		#region Events
		public event RecevedMessage ReceivedMessage;
		public event SentMessage SentMessage;
		public event OnError OnError;
		#endregion

		#region Contructor
		/// <summary>
		/// Create a Controller for client
		/// </summary>
		/// <param name="ip"></param>
		/// <param name="port"></param>
		public TcpClientController(string ip, int port)
		{
			
			Client = new Client(ip, port);
			thread = new Thread(Listen);
		}

		/// <summary>
		/// Create a controller for server
		/// </summary>
		/// <param name="tcpClient"></param>
		public TcpClientController(TcpClient tcpClient)
		{
			this.tcpClient = tcpClient;
			var endPoint = (IPEndPoint)tcpClient.Client.LocalEndPoint;
			var port = endPoint.Port;
			var ip = endPoint.Address.ToString();
			Client = new Client(ip, port);
			thread = new Thread(Listen);
		}

		#endregion

		#region Runtime
		public void StartListen()
		{
			try
			{
				if (tcpClient == null)
				{
					tcpClient = new TcpClient(Client.Ip, Client.Port);
				}

				stream = new RC4Stream(tcpClient.GetStream());

				thread.Start();
			}
			catch (Exception ex)
			{
				OnError?.Invoke(ex.Message);
			}
		}

		private void Listen()
		{
			while (tcpClient.Connected)
			{
				try
				{
					var readTuple = stream.Read();
					ProcessReceivedData(readTuple.Item1, readTuple.Item2);
				}
				catch (ThreadAbortException) { }
				catch (Exception ex)
				{
					OnError?.Invoke(ex.Message);
				}

			}
		}

		public void Stop()
		{
			if (thread.IsAlive)
			{
				thread.Abort();
			}
		}
		#endregion

		private void ProcessReceivedData(byte[] originData, byte[] descriptedData)
		{
			var message = encoding.GetString(descriptedData);
			if (!message.Equals(Constants.MarkSendFile))
			{
				ReceivedMessage?.Invoke(this, ConvertByteArrayToString(originData), message);
			}
		}

		#region Send data
		public void Send(string message)
		{
			var byteData = encoding.GetBytes(message);
			var sendData = stream.Send(byteData);

			SentMessage?.Invoke(this, message, ConvertByteArrayToString(sendData));
		}
		#endregion

		private string ConvertByteArrayToString(byte[] data)
		{
			return string.Join(" ", data.Select(x => x.ToString("X2")).ToArray());
		}
	}
}
