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
		private Image m_outfile;		// Used for the exported image
		private Color m_darkColor;
		private Color m_lightColor;
		private Color m_outlineColor = Color.Black;
		private Color m_baseColor;
		private Color m_backgroundColor = Color.White;
        private bool m_selectingColor = false;

		public ImageOutlinerForm()
		{
			InitializeComponent();
			m_outliner = new Outliner();

			setTextboxColors(m_outlineColor, outlineColorTextBox);
			setTextboxColors(m_outlineColor, outlineColorTextBox2);
			setTextboxColors(m_backgroundColor, backgroundTextBox);
			setTextboxColors(m_backgroundColor, backgroundTextBox2);

            //Start with droppers disabled.
            lightDropper.Enabled = false;
            darkDropper.Enabled = false;
            baseDropper.Enabled = false;
            lightDropper.Image = Image_Outliner.Properties.Resources.Dropper;
            darkDropper.Image = Image_Outliner.Properties.Resources.Dropper;
            baseDropper.Image = Image_Outliner.Properties.Resources.Dropper;
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

                //Droppers can now be used.
                lightDropper.Enabled = true;
                darkDropper.Enabled = true;
                baseDropper.Enabled = true;
			}
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
                m_lightColor = dialog.Color;
                setTextboxColors(m_lightColor, lightColorTextBox);
                setTextboxColors(m_lightColor, lightColorTextBox2);
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
                m_darkColor = dialog.Color;
                setTextboxColors(m_darkColor, darkColorTextBox);
                setTextboxColors(m_darkColor, darkColorTextBox2);
			}
		}

		private void outlineColorButton_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				m_outlineColor = dialog.Color;
				setTextboxColors(m_outlineColor, outlineColorTextBox);
				setTextboxColors(m_outlineColor, outlineColorTextBox2);	// sets the textbox in method 2
			}
		}
        
        private void outlineColorButton2_Click(object sender, EventArgs e)
        {
            outlineColorButton_Click(sender, e);
        }

		private void backgroundButton_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				m_backgroundColor = dialog.Color;
				setTextboxColors(m_backgroundColor, backgroundTextBox);
				setTextboxColors(m_backgroundColor, backgroundTextBox2);
			}
		}

		private void backgroundButton2_Click(object sender, EventArgs e)
		{
			backgroundButton_Click(sender, e);
		}

		/// <summary>
		/// The base color used for the trackbar color change implementation.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void baseColorButton_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				m_baseColor = dialog.Color;
                setTextboxColors(m_baseColor, baseColorTextBox);
                setTextboxColors(m_baseColor, lightColorTextBox);
                setTextboxColors(m_baseColor, lightColorTextBox2);
                setTextboxColors(m_baseColor, darkColorTextBox);
                setTextboxColors(m_baseColor, darkColorTextBox2);
                leftTrackBar.Enabled = true;
                rightTrackBar.Enabled = true;
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

        private void rightTrackBar_Scroll_1(object sender, EventArgs e)
        {
            // Get shift fromn trackbar.
            int rightShift = rightTrackBar.Value;

            // Shift but don't go over 255.
            int newRed = m_baseColor.R + rightShift;
            if (newRed > 255) newRed = 255;
            int newGreen = m_baseColor.G + rightShift;
            if (newGreen > 255) newGreen = 255;
            int newBlue = m_baseColor.B + rightShift;
            if (newBlue > 255) newBlue = 255;

            // Get our shifted color and set background color appropriately.
            Color newColor = Color.FromArgb(newRed, newGreen, newBlue);
            m_lightColor = newColor;
            setTextboxColors(newColor, lightColorTextBox);
            setTextboxColors(newColor, lightColorTextBox2);
        }

        private void leftTrackBar_Scroll_1(object sender, EventArgs e)
        {
            // Get shift fromn trackbar.
            int leftShift = leftTrackBar.Value;

            // Shift but don't go over 255.
            int newRed = m_baseColor.R - leftShift;
            if (newRed < 0) newRed = 0;
            int newGreen = m_baseColor.G - leftShift;
            if (newGreen < 0) newGreen = 0;
            int newBlue = m_baseColor.B - leftShift;
            if (newBlue < 0) newBlue = 0;

            // Get our shifted color and set background color appropriately.
            Color newColor = Color.FromArgb(newRed, newBlue, newGreen);
            m_darkColor = newColor;
            setTextboxColors(newColor, darkColorTextBox);
            setTextboxColors(newColor, darkColorTextBox2);
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

			m_outliner.MapColor(new ColorRange(m_lightColor, m_darkColor), outlineColorTextBox.BackColor);

			if (true == transparentCheckBox.Checked)
				m_outliner.BackgroundColor = Color.Transparent;
			else
				m_outliner.BackgroundColor = m_backgroundColor;

			m_outliner.Outline();
			m_outfile = m_outliner.OutputImage;
			pictureBox1.Image = m_outfile;

			saveImageToolStripMenuItem.Enabled = true;
		}

		private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			System.Drawing.Imaging.ImageFormat format;

			if (true == transparentCheckBox.Checked)
				saveFileDialog.Filter = "Png Image (.png)|*.png";
			else
				saveFileDialog.Filter = "Png Image (.png)|*.png|JPEG Image (.jpeg)|*.jpeg|Gif Image (.gif)|*.gif|Bitmap Image (.bmp)|*.bmp";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string extension = System.IO.Path.GetExtension(saveFileDialog.FileName);

				if (".jpg" == extension.ToLower() || ".jpeg" == extension.ToLower())
					format = System.Drawing.Imaging.ImageFormat.Jpeg;
				else if (".bmp" == extension.ToLower())
					format = System.Drawing.Imaging.ImageFormat.Bmp;
				else if (".gif" == extension.ToLower())
					format = System.Drawing.Imaging.ImageFormat.Gif;
				else if (".png" == extension.ToLower())
					format = System.Drawing.Imaging.ImageFormat.Png;
				else
					format = null;		// This shouldn't happen

				m_outfile.Save(saveFileDialog.FileName, format);
			}
		}

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!m_selectingColor) return;
            
            Color color;
            
            // Solution reused from http://bytes.com/topic/net/answers/645830-getting-x-y-coordinates-picturebox-image.
            int imgWidth = pictureBox1.Image.Width;
            int imgHeight = pictureBox1.Image.Height;
            int boxWidth = pictureBox1.Size.Width;
            int boxHeight = pictureBox1.Size.Height;

            //This variable will hold the result
            double X = e.X;
            double Y = e.Y;

            //Comparing the aspect ratio of both the control and the image itself.
            if (imgWidth / imgHeight > boxWidth / boxHeight)
            {
                //If true, that means that the image is stretched through the width of the control.
                //'In other words: the image is limited by the width.

                //The scale of the image in the Picture Box.
                double scale = (double)boxWidth / imgWidth;

                //Since the image is in the middle, this code is used to determinate the empty space in the height
                //'by getting the difference between the box height and the image actual displayed height and dividing it by 2.
                double blankPart = (boxHeight - scale * imgHeight) / 2;

                Y -= blankPart;

                //Scaling the results.
                X /= scale;
                Y /= scale;
            }
            else
            {
                //If true, that means that the image is stretched through the height of the control.
                //'In other words: the image is limited by the height.

                //The scale of the image in the Picture Box.
                double scale = (double)boxHeight / imgHeight;

                //Since the image is in the middle, this code is used to determinate the empty space in the width
                //'by getting the difference between the box width and the image actual displayed width and dividing it by 2.
                double blankPart = (boxWidth - scale * imgWidth) / 2;
                X -= blankPart;

                //Scaling the results.
                X /= scale;
                Y /= scale;
            }
            
            Bitmap bmpImage = pictureBox1.Image as Bitmap;
            try
            {
                color = bmpImage.GetPixel(Convert.ToInt32(X), Convert.ToInt32(Y));
            }
            catch(Exception)
            {
                // We can't do anything, it's out of range. Just return.
                return;
            }

            if (baseDropper.Enabled == true)
            {
                m_baseColor = color;
                m_lightColor = color;
                m_darkColor = color;
                setTextboxColors(color, baseColorTextBox);
                setTextboxColors(color, lightColorTextBox);
                setTextboxColors(color, lightColorTextBox2);
                setTextboxColors(color, darkColorTextBox);
                setTextboxColors(color, darkColorTextBox2);

				baseDropper.Image = Image_Outliner.Properties.Resources.Dropper;
            }
            else if (lightDropper.Enabled == true)
            {
                m_lightColor = color;
                setTextboxColors(color, lightColorTextBox);
                setTextboxColors(color, lightColorTextBox2);

				lightDropper.Image = Image_Outliner.Properties.Resources.Dropper;
            }
            else if (darkDropper.Enabled == true)
            {
                m_darkColor = color;
                setTextboxColors(color, darkColorTextBox);
                setTextboxColors(color, darkColorTextBox2);

				darkDropper.Image = Image_Outliner.Properties.Resources.Dropper;
            }

            m_selectingColor = false;

            //Re-enable other buttons, toolbars, and other things.
            backgroundButton.Enabled = true;
            backgroundButton2.Enabled = true;
            outlineColorButton.Enabled = true;
            outlineColorButton2.Enabled = true;
            lightColorButton.Enabled = true;
            darkColorButton.Enabled = true;
            baseColorButton.Enabled = true;
            loadImageButton.Enabled = true;
            outlineButton.Enabled = true;
            lightDropper.Enabled = true;
            darkDropper.Enabled = true;
            baseDropper.Enabled = true;
            transparentCheckBox.Enabled = true;
            imageLocationTextbox.Enabled = true;
            fileToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = true;
            helpToolStripMenuItem.Enabled = true;
            leftTrackBar.Enabled = true;
            rightTrackBar.Enabled = true;
        }


        private void baseDropper_Click(object sender, EventArgs e)
        {
            if (m_selectingColor)
            {
                //Re-enable everything, stop selecting color, and reset image.
                backgroundButton.Enabled = true;
                backgroundButton2.Enabled = true;
                outlineColorButton.Enabled = true;
                outlineColorButton2.Enabled = true;
                lightColorButton.Enabled = true;
                darkColorButton.Enabled = true;
                baseColorButton.Enabled = true;
                loadImageButton.Enabled = true;
                outlineButton.Enabled = true;
                darkDropper.Enabled = true;
                lightDropper.Enabled = true;
                transparentCheckBox.Enabled = true;
                imageLocationTextbox.Enabled = true;
                fileToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                helpToolStripMenuItem.Enabled = true;
                leftTrackBar.Enabled = true;
                rightTrackBar.Enabled = true;

                m_selectingColor = false;

                baseDropper.Image = Image_Outliner.Properties.Resources.Dropper;

                return;
            }
            
            //Disable other buttons, toolbars, and other things.
            backgroundButton.Enabled = false;
            backgroundButton2.Enabled = false;
            outlineColorButton.Enabled = false;
            outlineColorButton2.Enabled = false;
            lightColorButton.Enabled = false;
            darkColorButton.Enabled = false;
            baseColorButton.Enabled = false;
            loadImageButton.Enabled = false;
            outlineButton.Enabled = false;
            darkDropper.Enabled = false;
            lightDropper.Enabled = false;
            transparentCheckBox.Enabled = false;
            imageLocationTextbox.Enabled = false;
            fileToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = false;
            helpToolStripMenuItem.Enabled = false;
            leftTrackBar.Enabled = false;
            rightTrackBar.Enabled = false;

            m_selectingColor = true;

            baseDropper.Image = Image_Outliner.Properties.Resources.Cancel;
        }

        private void darkDropper_Click(object sender, EventArgs e)
        {
            if (m_selectingColor)
            {
                //Re-enable everything, stop selecting color, and reset image.
                backgroundButton.Enabled = true;
                backgroundButton2.Enabled = true;
                outlineColorButton.Enabled = true;
                outlineColorButton2.Enabled = true;
                lightColorButton.Enabled = true;
                darkColorButton.Enabled = true;
                baseColorButton.Enabled = true;
                loadImageButton.Enabled = true;
                outlineButton.Enabled = true;
                lightDropper.Enabled = true;
                baseDropper.Enabled = true;
                transparentCheckBox.Enabled = true;
                imageLocationTextbox.Enabled = true;
                fileToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                helpToolStripMenuItem.Enabled = true;
                leftTrackBar.Enabled = true;
                rightTrackBar.Enabled = true;

                m_selectingColor = false;

                darkDropper.Image = Image_Outliner.Properties.Resources.Dropper;

                return;
            }

            //Disable other buttons, toolbars, and other things.
            backgroundButton.Enabled = false;
            backgroundButton2.Enabled = false;
            outlineColorButton.Enabled = false;
            outlineColorButton2.Enabled = false;
            lightColorButton.Enabled = false;
            darkColorButton.Enabled = false;
            baseColorButton.Enabled = false;
            loadImageButton.Enabled = false;
            outlineButton.Enabled = false;
            lightDropper.Enabled = false;
            baseDropper.Enabled = false;
            transparentCheckBox.Enabled = false;
            imageLocationTextbox.Enabled = false;
            fileToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = false;
            helpToolStripMenuItem.Enabled = false;
            leftTrackBar.Enabled = false;
            rightTrackBar.Enabled = false;

            m_selectingColor = true;

            darkDropper.Image = Image_Outliner.Properties.Resources.Cancel;
        }

        private void lightDropper_Click(object sender, EventArgs e)
        {
            if (m_selectingColor)
            {
                //Re-enable everything, stop selecting color, and reset image.
                backgroundButton.Enabled = true;
                backgroundButton2.Enabled = true;
                outlineColorButton.Enabled = true;
                outlineColorButton2.Enabled = true;
                lightColorButton.Enabled = true;
                darkColorButton.Enabled = true;
                baseColorButton.Enabled = true;
                loadImageButton.Enabled = true;
                outlineButton.Enabled = true;
                darkDropper.Enabled = true;
                baseDropper.Enabled = true;
                transparentCheckBox.Enabled = true;
                imageLocationTextbox.Enabled = true;
                fileToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                helpToolStripMenuItem.Enabled = true;
                leftTrackBar.Enabled = true;
                rightTrackBar.Enabled = true;

                m_selectingColor = false;

                lightDropper.Image = Image_Outliner.Properties.Resources.Dropper;

                return;
            }

            //Disable other buttons, toolbars, and other things.
            backgroundButton.Enabled = false;
            backgroundButton2.Enabled = false;
            outlineColorButton.Enabled = false;
            outlineColorButton2.Enabled = false;
            lightColorButton.Enabled = false;
            darkColorButton.Enabled = false;
            baseColorButton.Enabled = false;
            loadImageButton.Enabled = false;
            outlineButton.Enabled = false;
            darkDropper.Enabled = false;
            baseDropper.Enabled = false;
            transparentCheckBox.Enabled = false;
            imageLocationTextbox.Enabled = false;
            fileToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = false;
            helpToolStripMenuItem.Enabled = false;
            leftTrackBar.Enabled = false;
            rightTrackBar.Enabled = false;

            m_selectingColor = true;

			lightDropper.Image = Image_Outliner.Properties.Resources.Cancel;
        }
	}
}