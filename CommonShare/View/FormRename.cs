using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonShare.View
{
	public partial class FormRename : Form
	{
		public string NickName = "";
		public Color Color;

		public FormRename(string nickName, Color color)
		{
			InitializeComponent();
			NickName = nickName;
			Color = color;
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			if (txtMessage.Text != "")
			{
				NickName = txtMessage.Text;
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void panel4_Click(object sender, System.EventArgs e)
		{
			txtMessage.Focus();
		}

		private void frmRename_Load(object sender, System.EventArgs e)
		{
			txtMessage.Text = NickName;
			btnChonMau.BackColor = Color;
		}

		private void btnChonMau_Click(object sender, System.EventArgs e)
		{
			colorDialog1.Color = Color;
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				Color = colorDialog1.Color;
				btnChonMau.BackColor = Color;
			}
		}
	}
}
