using CommonShare.Event;
using CommonShare.Model;
using CommonShare.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommonShare.Controller
{
	public class TcpClientController
	{
		#region Properties
		public Client Client { private set; get; }
		#endregion

		#region Fields
		private TcpClient tcpClient;

		private RC4Stream stream;
		private Thread thread;
		private byte[] buffer = new byte[10 * 1024];
		#endregion

		#region Events
		public event RecevedMessage ReceivedMessage;
		public event SentMessage SentMessage;
		public event SentFile SentFile;
		public event SentFile ReceivedFile;
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
			var endPoint = (IPEndPoint)tcpClient.Client.RemoteEndPoint;
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
					
					var readTuple = stream.ReadString();
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

		private void ProcessReceivedData(string originData, string descriptedData)
		{
			var message = descriptedData;
			if (!message.Equals(Constants.MarkSendFile))
			{
				ReceivedMessage?.Invoke(this, originData, message);
			}
			else
			{
				ReceiveFile();
			}
		}

		private void ReceiveFile()
		{
			var fileName = stream.ReadString().Item2;

			using (var filestream = File.OpenWrite(fileName))
			{
				var fileSize = long.Parse(stream.ReadString().Item2);
				var receivedByteTotal = 0;
				while (receivedByteTotal < fileSize)
				{
					var receiveData = stream.ReadBytes().Item2;
					filestream.Write(receiveData, 0, receiveData.Length);
					receivedByteTotal += receiveData.Length;
					ReceivedFile?.Invoke(this, fileName, receivedByteTotal, fileSize);
				}
			}
		}
		#region Send data
		public string Send(string message)
		{
			var sentString = stream.Send(message); 
			SentMessage?.Invoke(this, message, sentString);
			return sentString;
		}

		public void SendFile(string fileName)
		{
			stream.Send(Constants.MarkSendFile);
			var nameOnly = Path.GetFileName(fileName);
			stream.Send(nameOnly);
			using (var fileStream = File.OpenRead(fileName))
			{
				stream.Send("" + fileStream.Length);
				int readSize = 0;
				int sentSize = 0;
				while ((readSize = fileStream.Read(buffer, 0, buffer.Length)) > 0)
				{
					stream.Send(new ArraySegment<byte>(buffer, 0, readSize).Array);
					sentSize += readSize;
					SentFile?.Invoke(this, nameOnly, sentSize, fileStream.Length);
				}
			}
		}
		#endregion

		private string ConvertByteArrayToString(byte[] data)
		{
			return string.Join(" ", data.Select(x => x.ToString("X2")).ToArray());
		}
	}
}
