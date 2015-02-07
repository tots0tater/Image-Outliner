using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OutlinerEngine;

namespace Image_Outliner
{
	public partial class ImageOutlinerForm : Form
	{
		public ImageOutlinerForm()
		{
			InitializeComponent();
		}

		private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Once the image is chosen from the file, we put it in the OutlinerEngine 
				// and allow the image processing to begin
				Image inputImage = Image.FromFile(openFileDialog.FileName);
			}
		}

		private void outlineImageToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
