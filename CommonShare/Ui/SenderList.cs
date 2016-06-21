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
	public partial class SenderList : UserControl
	{
		public SenderList()
		{
			InitializeComponent();
		}

		public Button Add(string name)
		{
			var button = new SenderView(name);
			button.Width = Width;
			SuspendLayout();
			Controls.Add(button);
			ResumeLayout();
			return button;
		}
	}
}
