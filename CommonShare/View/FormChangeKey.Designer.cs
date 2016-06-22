namespace CommonShare.View
{
	partial class FormChangeKey
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
			this.btnChonMau = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txtKey = new System.Windows.Forms.TextBox();
			this.btnChange = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnChonMau
			// 
			this.btnChonMau.BackColor = System.Drawing.Color.LimeGreen;
			this.btnChonMau.FlatAppearance.BorderSize = 0;
			this.btnChonMau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChonMau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnChonMau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnChonMau.Location = new System.Drawing.Point(9, 12);
			this.btnChonMau.Name = "btnChonMau";
			this.btnChonMau.Size = new System.Drawing.Size(380, 40);
			this.btnChonMau.TabIndex = 13;
			this.btnChonMau.Text = "ĐỔI KEY";
			this.btnChonMau.UseVisualStyleBackColor = false;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.Window;
			this.panel4.Controls.Add(this.txtKey);
			this.panel4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.panel4.Location = new System.Drawing.Point(9, 67);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(263, 40);
			this.panel4.TabIndex = 12;
			// 
			// txtKey
			// 
			this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKey.Location = new System.Drawing.Point(5, 10);
			this.txtKey.MaxLength = 500;
			this.txtKey.Name = "txtKey";
			this.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtKey.Size = new System.Drawing.Size(255, 22);
			this.txtKey.TabIndex = 0;
			// 
			// btnChange
			// 
			this.btnChange.BackColor = System.Drawing.Color.LimeGreen;
			this.btnChange.FlatAppearance.BorderSize = 0;
			this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnChange.Location = new System.Drawing.Point(278, 67);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(111, 40);
			this.btnChange.TabIndex = 11;
			this.btnChange.Text = "CHẤP NHẬN";
			this.btnChange.UseVisualStyleBackColor = false;
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// FormChangeKey
			// 
			this.AcceptButton = this.btnChange;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 119);
			this.Controls.Add(this.btnChonMau);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.btnChange);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormChangeKey";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormChangeKey";
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnChonMau;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox txtKey;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.ColorDialog colorDialog1;
	}
}