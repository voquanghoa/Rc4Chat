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
			this.sendMessageControl = new CommonShare.View.SendControl();
			this.conversationBrower = new CommonShare.View.MessageBrower();
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
			this.senderList1.UpdateList += new CommonShare.View.SenderListUpdate(this.senderList1_UpdateList);
			// 
			// sendMessageControl
			// 
			this.sendMessageControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sendMessageControl.BackColor = System.Drawing.Color.SpringGreen;
			this.sendMessageControl.Location = new System.Drawing.Point(3, 375);
			this.sendMessageControl.Name = "sendMessageControl";
			this.sendMessageControl.Size = new System.Drawing.Size(377, 40);
			this.sendMessageControl.TabIndex = 7;
			this.sendMessageControl.SendFile += new CommonShare.View.SendFile(this.sendMessageControl_SendFile);
			this.sendMessageControl.SendMessage += new CommonShare.View.SendMessage(this.sendMessageControl_SendMessage);
			// 
			// conversationBrower
			// 
			this.conversationBrower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.conversationBrower.IsWebBrowserContextMenuEnabled = false;
			this.conversationBrower.Location = new System.Drawing.Point(3, 52);
			this.conversationBrower.MinimumSize = new System.Drawing.Size(20, 20);
			this.conversationBrower.Name = "conversationBrower";
			this.conversationBrower.Size = new System.Drawing.Size(377, 319);
			this.conversationBrower.TabIndex = 8;
			this.conversationBrower.WebBrowserShortcutsEnabled = false;
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
			this.progressDialog1.Visible = false;
			// 
			// ServerMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 419);
			this.Controls.Add(this.progressDialog1);
			this.Controls.Add(this.conversationBrower);
			this.Controls.Add(this.sendMessageControl);
			this.Controls.Add(this.senderList1);
			this.Name = "ServerMainForm";
			this.Text = "Chat RC4-Server";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerMainForm_FormClosed);
			this.Load += new System.EventHandler(this.ServerMainForm_Load);
			this.Controls.SetChildIndex(this.senderList1, 0);
			this.Controls.SetChildIndex(this.sendMessageControl, 0);
			this.Controls.SetChildIndex(this.conversationBrower, 0);
			this.Controls.SetChildIndex(this.progressDialog1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private CommonShare.View.SenderList senderList1;
		private CommonShare.View.SendControl sendMessageControl;
		private CommonShare.View.MessageBrower conversationBrower;
		private CommonShare.View.ProgressDialog progressDialog1;
	}
}

