using CommonShare.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonShare.Model
{
	public class Message
	{
		private static string allowChars = "!@#$%^&*() =+,./?;:|{}";
		private static string vietnameseChars = "aAeEoOuUiIdDyYáàạảãâấầậẩẫăắằặẳẵÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴéèẹẻẽêếềệểễÉÈẸẺẼÊẾỀỆỂỄóòọỏõôốồộổỗơớờợởỡÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠúùụủũưứừựửữÚÙỤỦŨƯỨỪỰỬỮíìịỉĩÍÌỊỈĨđĐýỳỵỷỹÝỲỴỶỸ";
		public static Message CreateLink(string filePath, long fileSize, Client sender)
		{
			var message = new Message();
			message.Content = TextResource.LinkFormat
				.Replace("{path}", filePath.Replace(":", "(~*)"))
				.Replace("{filename}", Path.GetFileName(filePath))
				.Replace("{size}", FileSizeConverter.ConvertToString(fileSize));
			message.Sender = sender;


			return message;
		}

		public Client Sender { get; set; }

		public string Content { set; get; }

		public string Origin { get; set; }

		public string ToString(bool useNickname)
		{
			var format = TextResource.SelfMessage;

			if (Sender != null)
			{
				var nickname = useNickname ? Sender.NickName : string.Empty;
				format = TextResource.RemoteMessageHtmlFormat.Replace("{nickname}", nickname);
			}

			Content = string.Join("", (from x in Content
					   let upper = char.ToUpper(x)
					   where (upper >= 'A' && upper <= 'Z') 
							|| char.IsDigit(upper) 
							|| allowChars.Contains(x)
							|| vietnameseChars.Contains(x)
						select x).ToArray());


			return format.Replace("{content}", Content).Replace("{title}", Origin);
		}
	}
}
