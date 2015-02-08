using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
		private Image m_outfile;
		private Color darkColor;
		private Color lightColor;
		private Color outlineColor;
        private Color m_baseColor;

		public ImageOutlinerForm()
		{
			InitializeComponent();
			m_outliner = new Outliner();

			tabPage1.Text = "Outline Method 1"; tabPage2.Text = "Outline Method 2";
		}

		private void ImageOutlinerForm_Load(object sender, EventArgs e)
        {
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

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                /*
				if (inputImage.Width > pictureBox1.Width && inputImage.Height > pictureBox1.Height)
					pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
				else
					pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                */

				pictureBox1.Image = inputImage;

				// This is so we can know the explicit type of image we are dealing with.
				Bitmap bmpImage = new Bitmap(inputImage); 
				m_outliner.InputImage = bmpImage;

                // Set the accompanying textbox's text to the file name.
                imageLocationTextbox.Text = openFileDialog.FileName;
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
            // Throw an error if there is no image to outline.
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No file chosen, please try again.", "Image Outliner - Error", MessageBoxButtons.OK);
                return;
            }

			m_outliner.MapColor(new ColorRange(lightColorTextBox.BackColor, darkColorTextBox.BackColor), outlineColorTextBox.BackColor);
			m_outliner.Outline();
			Image outputPicture = m_outliner.OutputImage;
			pictureBox1.Image = outputPicture;
		}

		#region Light/Dark/Outline Color
		/// <summary>
		/// Sets and displays the color the user picks for the low range. The low
		/// range is for detecting colors that will be accepted for the outline.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lightColorButton_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				lightColor = dialog.Color;
				setTextboxColors(lightColor, lightColorTextBox);
			}
		}

		/// <summary>
		/// Sets and displays the color the user picks for the high range. The high
		/// range is for detecting colors that will be accepted for the outline.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void darkColorButton_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				darkColor = dialog.Color;
				setTextboxColors(darkColor, darkColorTextBox);
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
				outlineColor = dialog.Color;
				setTextboxColors(outlineColor, outlineColorTextBox);
			}
		}

		/// <summary>
		/// Sets the textbox colors from a generic textbox passed in. Works PRETTY well.
		/// </summary>
		/// <param name="backgroundColor"></param>
		/// <param name="textBox"></param>
		void setTextboxColors(Color backgroundColor, TextBox textBox)
		{
			textBox.BackColor = backgroundColor;
			// Sets the font color to be visible on the text box's background
			if (backgroundColor.R + backgroundColor.G + backgroundColor.B > 500)
				textBox.ForeColor = Color.Black;
			else
				textBox.ForeColor = Color.White;

			textBox.Text = "R: " + backgroundColor.R + "  G: " + backgroundColor.G + "  B: " + backgroundColor.B;
		}
		#endregion

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            loadImageToolStripMenuItem_Click(sender, e);
        }
        private void outlineButton_Click(object sender, EventArgs e)
        {
            outlineImageToolStripMenuItem_Click(sender, e);
        }

        private void imageLocationTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                string filename = imageLocationTextbox.Text;

                // If empty filename, throw and error.
                if (filename == "")
                {
                    MessageBox.Show("No file chosen, please try again.", "Image Outliner - Error", MessageBoxButtons.OK);
                    return;
                }

                Image inputImage;

                // Once the image is chosen from the file, we put it in the OutlinerEngine 
                // and allow the image processing to begin.
                // Thrown an error if the file's not found.
                try
                {
                    inputImage = Image.FromFile(filename);
                }
                catch (FileNotFoundException)
                {
                    // This creates an error dialog box.
                    MessageBox.Show("File not found, please try again.", "Image Outliner - Error", MessageBoxButtons.OK);
                    return;
                }
                catch (OutOfMemoryException)
                {
                    // This creates an error dialog box.
                    MessageBox.Show("Not a valid image file, please try again.", "Image Outliner - Error", MessageBoxButtons.OK);
                    return;
                }

                pictureBox1.Image = inputImage;

                // This is so we can know the explicit type of image we are dealing with.
                Bitmap bmpImage = new Bitmap(inputImage);
                m_outliner.InputImage = bmpImage;
            }
        }

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// TODO: Write an "about" that explains the purpose of the program and what
			// certain... things do.
		}

		private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

        private void leftTrackBar_Scroll(object sender, EventArgs e)
        {
            setTextboxColors(Color.FromArgb(m_baseColor.R // things and stuff ColleftTrackBar.Value;
        }

        private void rightTrackBar_Scroll(object sender, EventArgs e)
        {

        }
	}
}