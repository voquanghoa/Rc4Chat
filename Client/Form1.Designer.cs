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
			this.SuspendLayout();
			// 
			// sendControl1
			// 
			this.sendControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sendControl1.Location = new System.Drawing.Point(2, 392);
			this.sendControl1.Name = "sendControl1";
			this.sendControl1.Size = new System.Drawing.Size(535, 40);
			this.sendControl1.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 434);
			this.Controls.Add(this.sendControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Controls.SetChildIndex(this.sendControl1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private SendControl sendControl1;
	}
}

