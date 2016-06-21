using CommonShare.View;

namespace Client
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sendControl1 = new CommonShare.View.SendControl();
			this.messageBrower1 = new CommonShare.View.MessageBrower();
			this.SuspendLayout();
			// 
			// sendControl1
			// 
			this.sendControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sendControl1.BackColor = System.Drawing.Color.OrangeRed;
			this.sendControl1.Location = new System.Drawing.Point(3, 337);
			this.sendControl1.Name = "sendControl1";
			this.sendControl1.Size = new System.Drawing.Size(386, 40);
			this.sendControl1.TabIndex = 6;
			// 
			// messageBrower1
			// 
			this.messageBrower1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.messageBrower1.IsWebBrowserContextMenuEnabled = false;
			this.messageBrower1.Location = new System.Drawing.Point(3, 56);
			this.messageBrower1.MinimumSize = new System.Drawing.Size(20, 20);
			this.messageBrower1.Name = "messageBrower1";
			this.messageBrower1.Size = new System.Drawing.Size(386, 276);
			this.messageBrower1.TabIndex = 7;
			this.messageBrower1.WebBrowserShortcutsEnabled = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkOrange;
			this.ClientSize = new System.Drawing.Size(392, 380);
			this.Controls.Add(this.messageBrower1);
			this.Controls.Add(this.sendControl1);
			this.Name = "Form1";
			this.Text = "Chat RC4 Client";
			this.Controls.SetChildIndex(this.sendControl1, 0);
			this.Controls.SetChildIndex(this.messageBrower1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private SendControl sendControl1;
		private MessageBrower messageBrower1;
	}
}

