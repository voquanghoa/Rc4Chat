using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonShare.View
{
	public partial class FormOpenFile : CoolForm
	{
		string Address = "";
		Uri url;
		public FormOpenFile(string address)
		{
			InitializeComponent();
			Address = address.Replace("(~*)", ":");
		}

		protected override CreateParams CreateParams
		{
			get
			{
				const int CS_DROPSHADOW = 0x20000;
				CreateParams cp = base.CreateParams;
				// Bóng đổ
				cp.ClassStyle |= CS_DROPSHADOW;
				// Load các control cùng lúc
				cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
				return cp;
			}
		}

		private void FormOpenFile_Load(object sender, EventArgs e)
		{
			url = new UriBuilder() { Scheme = Uri.UriSchemeFile, Host = "", Path = Address }.Uri;
			Text = Path.GetFileName(url.LocalPath);
			Address = url.LocalPath;
		}

		private void btnExplore_Click(object sender, EventArgs e)
		{
			if (File.Exists(Address))
				try
				{
					Process.Start("explorer.exe", " /select, " + Address);
					this.Close();
				}
				catch
				{
					MessageBox.Show("Không thể mở file");
				}
			else
				MessageBox.Show("Tập tin không tồn tại");
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			if (File.Exists(Address))
				try
				{
					Process.Start(Address);
					this.Close();
				}
				catch
				{
					MessageBox.Show("Không thể mở file");
				}
			else
				MessageBox.Show("Tập tin không tồn tại");
		}
	}
}
