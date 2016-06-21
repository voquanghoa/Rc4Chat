﻿using CommonShare.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonShare.Event
{
	public delegate void RecevedMessage(TcpClientController sender, string originMessage, string decryptedMessage);
	public delegate void SentMessage(TcpClientController sender, string originMessage, string encryptedMessage);
	public delegate void OnError(string message);
}
