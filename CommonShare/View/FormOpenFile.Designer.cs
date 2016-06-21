namespace CommonShare.View
{
	partial class FormOpenFile
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnExplore = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Controls.Add(this.btnOpen);
			this.panel2.Controls.Add(this.btnExplore);
			this.panel2.Location = new System.Drawing.Point(0, 44);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(434, 70);
			this.panel2.TabIndex = 6;
			// 
			// btnOpen
			// 
			this.btnOpen.BackColor = System.Drawing.Color.DarkTurquoise;
			this.btnOpen.FlatAppearance.BorderSize = 0;
			this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnOpen.Location = new System.Drawing.Point(21, 12);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(135, 40);
			this.btnOpen.TabIndex = 8;
			this.btnOpen.Text = "MỞ FILE";
			this.btnOpen.UseVisualStyleBackColor = false;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnExplore
			// 
			this.btnExplore.BackColor = System.Drawing.Color.Gold;
			this.btnExplore.FlatAppearance.BorderSize = 0;
			this.btnExplore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExplore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnExplore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnExplore.Location = new System.Drawing.Point(174, 12);
			this.btnExplore.Name = "btnExplore";
			this.btnExplore.Size = new System.Drawing.Size(225, 40);
			this.btnExplore.TabIndex = 9;
			this.btnExplore.Text = "MỞ THƯ MỤC CHỨA FILE";
			this.btnExplore.UseVisualStyleBackColor = false;
			this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
			// 
			// FormOpenFile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Coral;
			this.ClientSize = new System.Drawing.Size(434, 113);
			this.Controls.Add(this.panel2);
			this.Name = "FormOpenFile";
			this.Text = "FormOpenFile";
			this.Load += new System.EventHandler(this.FormOpenFile_Load);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnExplore;
	}
}