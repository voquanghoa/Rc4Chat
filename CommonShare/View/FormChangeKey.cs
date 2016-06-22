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
	public partial class FormChangeKey : Form
	{
		public string Key {
			get
			{
				return txtKey.Text;
			}
		}

		public FormChangeKey(string key)
		{
			InitializeComponent();
			txtKey.Text = key;
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
