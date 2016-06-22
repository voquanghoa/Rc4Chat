using CommonShare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonShare.Controller
{
	public class ConversationController
	{
		private List<Message> Messages = new List<Message>();

		public void Add(Client client, string content, string origin)
		{
			var message = new Message()
			{
				Content = content,
				Sender = client,
				Origin = origin
			};

			Messages.Add(message);
		}

		public void Add(Client client, string filePath, long size)
		{
			Messages.Add(Message.CreateLink(filePath, size, client));
		}

		public string GetHtml(bool useNickname)
		{
			var content = string.Join("\n", Messages.Select(x => x.ToString(useNickname)).ToArray());
			return TextResource.MessageHtmlFormat.Replace("{content}", content);
		}
	}
}
