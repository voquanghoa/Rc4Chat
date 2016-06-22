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
	public delegate void SenderListUpdate();

	public partial class SenderList : UserControl
	{
		public event SenderListUpdate UpdateList;

		public SenderList()
		{
			InitializeComponent();
		}

		public void AddButtons(SenderView[] senderViews)
		{
			SuspendLayout();
			this.Controls.Clear();
			this.Controls.AddRange(senderViews.ToArray());
			ResumeLayout();

			senderViews.ToList().ForEach(x => x.Updated = RequestUpdate);
		}

		public void RequestUpdate()
		{
			UpdateList?.Invoke();
		}
	}
}
