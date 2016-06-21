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
	public delegate void Updated(SenderView sender);

	public partial class SenderView : Button
	{ 
		public event Updated Updated;

		public string NickName { get; set; }
		public Color Color { get; set; }

		public SenderView(string text)
		{
			InitializeComponent();
			Random ran = new Random();
			Color = Color.FromArgb(ran.Next(100, 240), ran.Next(100, 240), ran.Next(100, 240));
			this.Click += SenderView_Click;
			this.Text = text;
		}

		private void SenderView_Click(object sender, EventArgs e)
		{
			var frm = new FormRename(NickName, Color);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				Color = frm.Color;
				NickName = frm.NickName;
				Text = NickName;
				BackColor = Color;
				Updated?.Invoke(this);
			}
		}
	}
}
