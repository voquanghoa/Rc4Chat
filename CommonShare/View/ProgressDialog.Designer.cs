namespace CommonShare.View
{
	partial class ProgressDialog
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
			this.lblFile = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// lblFile
			// 
			this.lblFile.AutoSize = true;
			this.lblFile.Location = new System.Drawing.Point(4, 10);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(94, 13);
			this.lblFile.TabIndex = 3;
			this.lblFile.Text = "Đang nhận dữ liệu";
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(7, 40);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(465, 15);
			this.progressBar.Step = 1;
			this.progressBar.TabIndex = 2;
			// 
			// ProgressDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblFile);
			this.Controls.Add(this.progressBar);
			this.Name = "ProgressDialog";
			this.Size = new System.Drawing.Size(479, 65);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFile;
		private System.Windows.Forms.ProgressBar progressBar;
	}
}
