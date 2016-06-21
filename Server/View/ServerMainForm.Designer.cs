namespace Server.View
{
	partial class ServerMainForm
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
			this.senderList1 = new CommonShare.View.SenderList();
			this.sendControl1 = new CommonShare.View.SendControl();
			this.messageBrower1 = new CommonShare.View.MessageBrower();
			this.progressDialog1 = new CommonShare.View.ProgressDialog();
			this.SuspendLayout();
			// 
			// senderList1
			// 
			this.senderList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.senderList1.BackColor = System.Drawing.Color.LightYellow;
			this.senderList1.Location = new System.Drawing.Point(383, 52);
			this.senderList1.Name = "senderList1";
			this.senderList1.Size = new System.Drawing.Size(130, 363);
			this.senderList1.TabIndex = 6;
			// 
			// sendControl1
			// 
			this.sendControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sendControl1.BackColor = System.Drawing.Color.SpringGreen;
			this.sendControl1.Location = new System.Drawing.Point(3, 375);
			this.sendControl1.Name = "sendControl1";
			this.sendControl1.Size = new System.Drawing.Size(377, 40);
			this.sendControl1.TabIndex = 7;
			// 
			// messageBrower1
			// 
			this.messageBrower1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.messageBrower1.IsWebBrowserContextMenuEnabled = false;
			this.messageBrower1.Location = new System.Drawing.Point(3, 52);
			this.messageBrower1.MinimumSize = new System.Drawing.Size(20, 20);
			this.messageBrower1.Name = "messageBrower1";
			this.messageBrower1.Size = new System.Drawing.Size(377, 319);
			this.messageBrower1.TabIndex = 8;
			this.messageBrower1.WebBrowserShortcutsEnabled = false;
			// 
			// progressDialog1
			// 
			this.progressDialog1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressDialog1.Location = new System.Drawing.Point(0, 306);
			this.progressDialog1.Name = "progressDialog1";
			this.progressDialog1.Size = new System.Drawing.Size(380, 65);
			this.progressDialog1.TabIndex = 9;
			this.progressDialog1.Value = 0;
			this.progressDialog1.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 419);
			this.Controls.Add(this.progressDialog1);
			this.Controls.Add(this.messageBrower1);
			this.Controls.Add(this.sendControl1);
			this.Controls.Add(this.senderList1);
			this.Name = "Form1";
			this.Text = "Chat RC4-Server";
			this.Controls.SetChildIndex(this.senderList1, 0);
			this.Controls.SetChildIndex(this.sendControl1, 0);
			this.Controls.SetChildIndex(this.messageBrower1, 0);
			this.Controls.SetChildIndex(this.progressDialog1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private CommonShare.View.SenderList senderList1;
		private CommonShare.View.SendControl sendControl1;
		private CommonShare.View.MessageBrower messageBrower1;
		private CommonShare.View.ProgressDialog progressDialog1;
	}
}

