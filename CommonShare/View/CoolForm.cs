using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonShare.View
{
	public partial class CoolForm : Form
	{
		public bool Resizeable { get; set; }
		private const int cGrip = 16;    

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		public CoolForm()
		{
			InitializeComponent();
			DoubleBuffered = true;
			SetStyle(ControlStyles.ResizeRedraw, true);
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void CoolForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			if (Resizeable)
			{
				Rectangle rc = new Rectangle(ClientSize.Width - cGrip, ClientSize.Height - cGrip, cGrip, cGrip);
				ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
			}
		}

		public override string Text
		{
			get
			{
				return lblTitle==null?string.Empty:lblTitle.Text;
			}

			set
			{
				if(lblTitle != null)
				{
					lblTitle.Text = value;
				}
			}
		}

		protected override void WndProc(ref Message m)
		{
			if (Resizeable && m.Msg == 0x84)
			{  
				Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
				pos = PointToClient(pos);
				if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
				{
					m.Result = (IntPtr)17;
					return;
				}
			}
			base.WndProc(ref m);
		}
	}
}
