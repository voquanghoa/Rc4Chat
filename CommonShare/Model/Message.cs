﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonShare.Model
{
	public class Message
	{
		public Client Sender { get; set; }

		public string Content { set; get; }

		public override string ToString()
		{
			return base.ToString();
		}
	}
}