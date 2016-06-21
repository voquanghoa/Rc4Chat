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

		public void Add(Client client, string content)
		{
			var message = new Message()
			{
				Content = content,
				Sender = client
			};

			Messages.Add(message);
		}

		public string GetHtml(bool useNickname)
		{
			var content = string.Join("\n", Messages.Select(x => x.ToString(useNickname)).ToArray());
			return TextResource.MessageHtmlFormat.Replace("{content}", content);
		}
	}
}
