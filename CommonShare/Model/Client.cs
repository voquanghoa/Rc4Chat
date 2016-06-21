using CommonShare.Controller;
using CommonShare.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CommonShare.Model
{
	public class Client
	{
		public string Ip { get; set; }
		public int Port { get; set; }
		private string customNickname = string.Empty;

		public string NickName
		{
			get
			{
				if (string.IsNullOrEmpty(customNickname))
				{
					return string.Format("{0}:{1}", Ip, Port);
				}
				return customNickname;
			}
			set
			{
				customNickname = value;
			}
		}

		public SenderView SenderView { set; get; }

		public Color Color
		{
			set
			{
				SenderView.BackColor = value;
			}
			get
			{
				return SenderView.BackColor;
			}
		}

		public Client(string ip, int port)
		{
			Ip = ip;
			Port = port;
		}
	}
}
