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
        private Color m_darkColor;
        private Color m_lightColor;
        
        public ColorRange(Color darkColor, Color lightColor)
        {
            m_darkColor = darkColor;
            m_lightColor = lightColor;
        }

        // The low end of our color range.
        public Color LowColor
        {
            get { return m_darkColor; }
        }

        // The high end of our color range.
        public Color HighColor
        {
            get { return m_lightColor; }
        }

        /// <summary>
        /// Detects whether the input color is in the color range.
        /// </summary>
        /// <param name="inputColor">The color to be checked.</param>
        /// <returns>Whether the input color is in the color range.</returns>
        public bool IsInRange(Color inputColor)
        {
            byte maxR = Math.Max(LowColor.R, HighColor.R);
            byte maxG = Math.Max(LowColor.G, HighColor.G);
            byte maxB = Math.Max(LowColor.B, HighColor.B);

            byte minR = Math.Min(LowColor.R, HighColor.R);
            byte minG = Math.Min(LowColor.G, HighColor.G);
            byte minB = Math.Min(LowColor.B, HighColor.B);

            // If the input red, green, and blue values are between the low color and the high color's red, green, and blue values, return true.
            // Otherwise, return false.
            if (inputColor.R >= minR && inputColor.R <= maxR)
            {
                if (inputColor.G >= minG && inputColor.G <= maxG)
                {
                    if (inputColor.B >= minB && inputColor.B <= maxB)
                    {
                        return true;
                    }
                }
            }

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
			
			/*
			Rectangle rectangle = new Rectangle(0, 0, m_outputImage.Width, m_outputImage.Height);
			// Referenced https://msdn.microsoft.com/en-us/library/5ey6h79d%28v=vs.80%29.aspx for this code.
			System.Drawing.Imaging.BitmapData bmpData =
				m_outputImage.LockBits(rectangle, System.Drawing.Imaging.ImageLockMode.ReadWrite,
				m_outputImage.PixelFormat);
			*/
			
			/*
			for (int y = 0; y < m_inputImage.Height; y++)
			{
				for (int x = 0 ; x < m_inputImage.Width; x++)
				{
					Color currentPixel = m_inputImage.GetPixel(x, y);
					foreach (KeyValuePair<ColorRange, Color> colorMap in m_colorMap)
					{
						if (colorMap.Key.IsInRange(currentPixel))
							m_outputImage.SetPixel(x, y, colorMap.Value);
					}
				}
			}
			*/
        }
    }
}