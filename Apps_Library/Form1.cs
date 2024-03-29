using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;
using System.Diagnostics;


namespace Apps_Library
{
	public partial class Form1 : Form
	{
		ImageList img = new ImageList();
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();

			open.DefaultExt = ".exe";
			open.Multiselect = false;
			open.Filter = "Executable | *.exe";

			open.InitialDirectory = Environment.GetEnvironmentVariable("%SYSTEMDRIVE%");

			open.ShowDialog();
			//MessageBox.Show(open.FileName, "Initial path", MessageBoxButtons.OK);
			
			ListViewItem lvi = new ListViewItem(new string[] { open.SafeFileName});
			lvi.SubItems.Add(open.FileName);

			Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(open.FileName);
			listView1.SmallImageList = img;

			img.Images.Add(icon);
			lvi.ImageIndex = img.Images.Count - 1;
			listView1.Items.Add(lvi);

			//MessageBox.Show(i, "Initial path", MessageBoxButtons.OK);
		}
		private void btnDel_Click(object sender, EventArgs e)
		{
			listView1.FocusedItem.Remove();
			panelInfo.Visible = false;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Form1.ActiveForm.Close();
		}
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			panelInfo.Visible = true;
			DirectoryInfo dir = new DirectoryInfo(Path.GetDirectoryName(listView1.FocusedItem.SubItems[1].Text));
			FileInfo[] file = dir.GetFiles();

			long fileLength = file[0].Length;

			DateTime dt = file[0].CreationTime;
			DateTime lat = file[0].LastAccessTime;
			
			string filename = file[0].Name;
			string fullname = file[0].FullName;

			richTextBox1.Text = "FileName: " + filename + "\n\nPath: " + fullname + "\n\nCreationTime: " + dt.ToString() + "\n\nLastAccesTime: " + lat.ToString() + "\n\nWeight: " + fileLength;
		}

		private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Process.Start(listView1.FocusedItem.SubItems[1].Text);

			//MessageBox.Show(listView1.FocusedItem.SubItems[1].Text, "Initial path", MessageBoxButtons.OK);
		}

		private void btnLaunch_Click(object sender, EventArgs e)
		{
			if(listView1.Focused)
			{
			Process.Start(listView1.FocusedItem.SubItems[1].Text);
			}
		}
	}
}
