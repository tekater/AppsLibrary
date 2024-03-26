namespace Apps_Library
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
			this.panelInfo = new System.Windows.Forms.Panel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// panelInfo
			// 
			this.panelInfo.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panelInfo.Location = new System.Drawing.Point(178, 12);
			this.panelInfo.Name = "panelInfo";
			this.panelInfo.Size = new System.Drawing.Size(610, 394);
			this.panelInfo.TabIndex = 1;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 415);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(137, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add App";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(686, 415);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(101, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(581, 415);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(99, 23);
			this.btnDel.TabIndex = 0;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(136, 390);
			this.panel1.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.panelInfo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelInfo;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Panel panel1;
	}
}

