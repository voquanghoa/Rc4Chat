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
	public partial class ProgressDialog : UserControl
	{
		public ProgressDialog()
		{
			InitializeComponent();
		}

		public int Value
		{
			get
			{
				return progressBar.Value;
			}

			set
			{
				progressBar.Value = value;
			}
		}

		public override string Text
		{
			set
			{
				lblFile.Text = value;
			}
			get
			{
				return lblFile.Text;
			}
		}
	}
}
