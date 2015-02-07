using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlinerEngine
{
    /// <summary>
    /// Simulates a range of colors.
    /// </summary>
    public struct ColorRange
    {
        private Color m_lowColor;
        private Color m_highColor;

        public ColorRange(Color lowColor, Color highColor)
        {
            m_lowColor = lowColor;
            m_highColor = highColor;
        }

        // The low end of our color range.
        public Color LowColor
        {
            get { return m_lowColor; }
        }

        // The high end of our color range.
        public Color HighColor
        {
            get { return m_highColor; }
        }

        /// <summary>
        /// Detects whether the input color is in the color range.
        /// </summary>
        /// <param name="inputColor">The color to be checked.</param>
        /// <returns>Whether the input color is in the color range.</returns>
        public bool IsInRange(Color inputColor)
        {
            // We will check each colors' hue.
            float inputHue = inputColor.GetHue();
            float lowHue = LowColor.GetHue();
            float highHue = HighColor.GetHue();

            // If the input hue is between the low hue and the high hue, return true.
            // Otherwise, return false.
            if(inputHue >= lowHue && inputHue <= highHue) return true;
            return false;
        }
    }

    /// <summary>
    /// Our main class for the engine - outlines images.
    /// </summary>
    public class Outliner
    {
        private Bitmap m_inputImage;
        private Bitmap m_outputImage;

        // Maps input color ranges to output colors for the Outline() method.
        private List<KeyValuePair<ColorRange, Color>> m_colorMap = new List<KeyValuePair<ColorRange, Color>>();
        
        // Our input picture - the picture we want to outline with Outline().
        public Bitmap InputImage
        {
            get { return m_inputImage; }
            set { m_inputImage = value; }
        }
        
        // Our output picture - the result of outlining with Outline().
        public Bitmap OutputImage
        {
            get { return m_outputImage; }
        }

        /// <summary>
        /// Constructs an Outliner object with InputImage initialized.
        /// </summary>
        /// <param name="inputImage">The image to be converted.</param>
		public Outliner(Bitmap inputImage)
        {
            InputImage = inputImage;
        }

        /// <summary>
        /// Constructs an empty Outliner object.
        /// </summary>
        public Outliner()
        {
        }

        /// <summary>
        /// Adds a new ColorRange to Color relationship to the outliner.
        /// Example:
        ///     MapColor(new ColorRange(Color.Black, Color.White), Color.Blue) //Now, all pixels in the black-white range will be blue in the output image.
        /// </summary>
        /// <param name="inRange">The "from" color - the color in the original picture to be replaced.</param>
        /// <param name="outColor">The "to" color - the color in the new picture to replace the old color.</param>
        public void MapColor(ColorRange inRange, Color outColor)
        {
            m_colorMap.Add(new KeyValuePair<ColorRange,Color>(inRange, outColor));
        }

        /// <summary>
        /// Outline the picture.
        /// </summary>
        public void Outline()
        {
            // Initializing our output image to the same size as our input image
			m_outputImage = new Bitmap(m_inputImage.Width, m_inputImage.Height);
			for (int y = 0; y < m_inputImage.Height; y++)
			{
				for (int x = 0 ; x < m_inputImage.Width; x++)
				{
					Color currentPixel = m_inputImage.GetPixel(x, y);
					foreach (KeyValuePair<ColorRange, Color> colorMap in m_colorMap)
					{
						if (colorMap.Key.IsInRange(currentPixel))
							m_outputImage.SetPixel(x, y, colorMap.Value);
						else
							m_outputImage.SetPixel(x, y, Color.White);
					}
				}
			}
        }
    }
}