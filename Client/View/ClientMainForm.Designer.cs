using CommonShare.View;

namespace Client
{
	partial class ClientMainForm
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
			this.conversationBrower = new CommonShare.View.MessageBrower();
			this.progressDialog1 = new CommonShare.View.ProgressDialog();
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
			// conversationBrower
			// 
			this.conversationBrower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.conversationBrower.IsWebBrowserContextMenuEnabled = false;
			this.conversationBrower.Location = new System.Drawing.Point(3, 56);
			this.conversationBrower.MinimumSize = new System.Drawing.Size(20, 20);
			this.conversationBrower.Name = "conversationBrower";
			this.conversationBrower.Size = new System.Drawing.Size(386, 276);
			this.conversationBrower.TabIndex = 7;
			this.conversationBrower.WebBrowserShortcutsEnabled = false;
			// 
			// progressDialog1
			// 
			this.progressDialog1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressDialog1.Location = new System.Drawing.Point(3, 267);
			this.progressDialog1.Name = "progressDialog1";
			this.progressDialog1.Size = new System.Drawing.Size(386, 65);
			this.progressDialog1.TabIndex = 8;
			this.progressDialog1.Value = 0;
			this.progressDialog1.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkOrange;
			this.ClientSize = new System.Drawing.Size(392, 380);
			this.Controls.Add(this.progressDialog1);
			this.Controls.Add(this.conversationBrower);
			this.Controls.Add(this.sendControl1);
			this.Name = "MainForm";
			this.Text = "Chat RC4 Client";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Controls.SetChildIndex(this.sendControl1, 0);
			this.Controls.SetChildIndex(this.conversationBrower, 0);
			this.Controls.SetChildIndex(this.progressDialog1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private SendControl sendControl1;
		private MessageBrower conversationBrower;
		private ProgressDialog progressDialog1;
	}
}

