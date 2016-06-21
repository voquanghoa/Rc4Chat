using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonShare.View
{
	public delegate void ShowLink(string url);
	public partial class MessageBrower : WebBrowser
	{
		public event ShowLink ShowLink;

		public MessageBrower()
		{
			InitializeComponent();
			Navigating += MessageBrower_Navigating;
		}

		private void MessageBrower_Navigating(object sender, WebBrowserNavigatingEventArgs e)
		{
			e.Cancel = true;
			if (e.Url.ToString() != "about:blank")
			{
				string url = e.Url.PathAndQuery;
				ShowLink?.Invoke(url);
			}
		}
	}
}
