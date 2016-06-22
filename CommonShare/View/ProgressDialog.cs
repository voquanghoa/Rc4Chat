using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonShare.Util;

namespace CommonShare.View
{
	public partial class ProgressDialog : UserControl
	{
		private long done;
		private long total;
		private string fileName;
		private string action;

		public ProgressDialog()
		{
			InitializeComponent();
		}

		public void UpdateValues()
		{
			var strDone = FileSizeConverter.ConvertToString(done);
			var strTotal = FileSizeConverter.ConvertToString(total);
			lblFile.Text = string.Format("{0} {1} {2}/{3}", action, fileName, strDone, strTotal);
			progressBar.Value =(int) (100 * done / total);
		}

		public string FileName
		{
			set
			{
				fileName = value;
			}
		}

		public long ValueTotal
		{
			set
			{
				total = value;
			}
		}

		public long ValueDone
		{
			set
			{
				done = value;
			}
		}

		public string Action
		{
			set
			{
				action = value;
			}
		}
	}
}
