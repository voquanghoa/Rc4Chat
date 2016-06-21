using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonShare.Ui
{
	public delegate void SendFile(string fileName);
	public delegate void SendMessage(string message);

	public partial class SendControl : UserControl
	{
		public event SendFile SendFile;
		public event SendMessage SendMessage;

		public SendControl()
		{
			InitializeComponent();
		}

		private void btnImage_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				SendFile?.Invoke(openFileDialog.FileName);
			}
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			if(txtMessage.TextLength > 0)
			{
				SendMessage?.Invoke(txtMessage.Text);
				txtMessage.Text = string.Empty;
			}
		}

		private void panel4_Click(object sender, EventArgs e)
		{
			txtMessage.Focus();
		}

		private void txtMessage_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				btnSend.PerformClick();
		}
	}
}
