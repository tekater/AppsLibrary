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
			this.components = new System.ComponentModel.Container();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.panelInfo = new System.Windows.Forms.Panel();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnApp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnAppPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblInfo = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLaunch = new System.Windows.Forms.Button();
			this.panelInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 415);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(158, 23);
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
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(581, 415);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(99, 23);
			this.btnDel.TabIndex = 0;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// panelInfo
			// 
			this.panelInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panelInfo.Controls.Add(this.richTextBox1);
			this.panelInfo.Controls.Add(this.lblInfo);
			this.panelInfo.Location = new System.Drawing.Point(215, 12);
			this.panelInfo.Name = "panelInfo";
			this.panelInfo.Size = new System.Drawing.Size(572, 390);
			this.panelInfo.TabIndex = 4;
			this.panelInfo.Visible = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnApp,
            this.columnAppPath});
			this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(13, 12);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(157, 390);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.List;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblInfo.Location = new System.Drawing.Point(3, 15);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(178, 37);
			this.lblInfo.TabIndex = 0;
			this.lblInfo.Text = "Information";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox1.Location = new System.Drawing.Point(10, 55);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(556, 332);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Location = new System.Drawing.Point(188, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(13, 455);
			this.panel1.TabIndex = 6;
			// 
			// btnLaunch
			// 
			this.btnLaunch.Location = new System.Drawing.Point(215, 415);
			this.btnLaunch.Name = "btnLaunch";
			this.btnLaunch.Size = new System.Drawing.Size(99, 23);
			this.btnLaunch.TabIndex = 7;
			this.btnLaunch.Text = "Launch";
			this.btnLaunch.UseVisualStyleBackColor = true;
			this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(800, 448);
			this.Controls.Add(this.btnLaunch);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.panelInfo);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAdd);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panelInfo.ResumeLayout(false);
			this.panelInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Panel panelInfo;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnApp;
		private System.Windows.Forms.ColumnHeader columnAppPath;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnLaunch;
	}
}

