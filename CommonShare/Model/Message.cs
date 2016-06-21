using System;
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

		public string ToString(bool useNickname)
		{
			var format = TextResource.SelfMessage;

			if (Sender != null)
			{
				var nickname = useNickname ? Sender.NickName : string.Empty;
				format = TextResource.RemoteMessageHtmlFormat.Replace("{nickname}", nickname);
			}

			return format.Replace("{content}", Content);
		}
	}
}
