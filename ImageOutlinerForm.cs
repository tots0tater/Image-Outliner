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
		private Outliner m_outliner;
		
		public ImageOutlinerForm()
		{
			InitializeComponent();
			m_outliner = new Outliner();
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
		}

		/// <summary>
		/// From an open file dialog, the user chooses an image. The image is then displayed
		/// on the screen while being put into the Outliner class. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
            OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Once the image is chosen from the file, we put it in the OutlinerEngine 
				// and allow the image processing to begin
				Image inputImage = Image.FromFile(openFileDialog.FileName);
				pictureBox1.Image = inputImage;
				
				// This is so we can know the explicit type of image we are dealing with.
				Bitmap bmpImage = new Bitmap(inputImage); 

				m_outliner.InputImage = bmpImage;


			}
		}

		/// <summary>
		/// When the user clicks the "Outline Image..." button, the image is shown in the
		/// winform. The user can then export the image if they choose.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void outlineImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_outliner.MapColor(new ColorRange(lowColorTextBox.BackColor, highColorTextBox.BackColor), outlineColorTextBox.BackColor);
			m_outliner.Outline();
			Image outputPicture = m_outliner.OutputImage;
			pictureBox1.Image = outputPicture;
		}

		#region Low/High/Outline Color

		/// <summary>
		/// Sets and displays the color the user picks for the low range. The low
		/// range is for detecting colors that will be accepted for the outline.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lowColorButton_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Color backgroundColor = dialog.Color;
				lowColorTextBox.BackColor = backgroundColor;
			}
		}

		/// <summary>
		/// Sets and displays the color the user picks for the high range. The high
		/// range is for detecting colors that will be accepted for the outline.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void highColorButton_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Color backgroundColor = dialog.Color;
				highColorTextBox.BackColor = backgroundColor;
			}
		}

		/// <summary>
		/// Sets and displays the color the user picks for the outline. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void outlineColorButton_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Color backgroundColor = dialog.Color;
				outlineColorTextBox.BackColor = backgroundColor;
			}
		}

		#endregion

		private void ImageOutlinerForm_Load(object sender, EventArgs e)
        {

        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            loadImageToolStripMenuItem_Click(sender, e);
        }
	}
}
