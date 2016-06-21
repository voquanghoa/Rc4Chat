namespace CommonShare.Ui
{
	partial class SendControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnImage = new System.Windows.Forms.Button();
			this.btnSend = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnImage
			// 
			this.btnImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImage.BackColor = System.Drawing.Color.LimeGreen;
			this.btnImage.FlatAppearance.BorderSize = 0;
			this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnImage.Image = global::CommonShare.Properties.Resources._1459841495_Attach;
			this.btnImage.Location = new System.Drawing.Point(380, 0);
			this.btnImage.Name = "btnImage";
			this.btnImage.Size = new System.Drawing.Size(40, 40);
			this.btnImage.TabIndex = 8;
			this.btnImage.UseVisualStyleBackColor = false;
			this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
			// 
			// btnSend
			// 
			this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSend.BackColor = System.Drawing.Color.LimeGreen;
			this.btnSend.FlatAppearance.BorderSize = 0;
			this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnSend.Image = global::CommonShare.Properties.Resources._1459189602_send_01;
			this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSend.Location = new System.Drawing.Point(420, 0);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(80, 40);
			this.btnSend.TabIndex = 7;
			this.btnSend.Text = "     GỬI";
			this.btnSend.UseVisualStyleBackColor = false;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.RestoreDirectory = true;
			this.openFileDialog.Title = "Chọn tập tin đính kèm";
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BackColor = System.Drawing.SystemColors.Window;
			this.panel4.Controls.Add(this.txtMessage);
			this.panel4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(380, 40);
			this.panel4.TabIndex = 9;
			this.panel4.Click += new System.EventHandler(this.panel4_Click);
			// 
			// txtMessage
			// 
			this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMessage.Location = new System.Drawing.Point(5, 14);
			this.txtMessage.MaxLength = 500;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtMessage.Size = new System.Drawing.Size(369, 13);
			this.txtMessage.TabIndex = 0;
			this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
			// 
			// SendControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.btnImage);
			this.Controls.Add(this.btnSend);
			this.Name = "SendControl";
			this.Size = new System.Drawing.Size(500, 40);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnImage;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox txtMessage;
	}
}
