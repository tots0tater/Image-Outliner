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

		/// <summary>
		/// Constructs a color range from two colors.
		/// </summary>
		/// <param name="darkColor">A darker color.</param>
		/// <param name="lightColor">A lighter color.</param>
		public ColorRange(Color darkColor, Color lightColor)
		{
			m_darkColor = darkColor;
			m_lightColor = lightColor;
		}

		/// <summary>
		/// Constructs a color range from a base color, and a right or left brightness shift.
		/// </summary>
		/// <param name="baseColor">The color to start with.</param>
		/// <param name="lSensitivity">The integer number to decrease r, g, and b from the base color.</param>
		/// <param name="rSensitivity">The integer number to decrease r, g, and b from the base color.</param>
		public ColorRange(Color baseColor, int lSensitivity, int rSensitivity)
		{
			m_darkColor = Color.FromArgb(baseColor.R - lSensitivity, baseColor.G - lSensitivity, baseColor.B - lSensitivity);
			m_lightColor = Color.FromArgb(baseColor.R + rSensitivity, baseColor.G + rSensitivity, baseColor.B + rSensitivity);
		}

		// The low end of our color range.
		public Color DarkColor
		{
			get { return m_darkColor; }
		}

		// The high end of our color range.
		public Color LightColor
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
			byte maxR = Math.Max(DarkColor.R, LightColor.R);
			byte maxG = Math.Max(DarkColor.G, LightColor.G);
			byte maxB = Math.Max(DarkColor.B, LightColor.B);

			byte minR = Math.Min(DarkColor.R, LightColor.R);
			byte minG = Math.Min(DarkColor.G, LightColor.G);
			byte minB = Math.Min(DarkColor.B, LightColor.B);

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


			/*
			float maxH = Math.Max(LowColor.GetHue(), HighColor.GetHue());
			float maxS = Math.Max(LowColor.GetSaturation(), HighColor.GetSaturation());
			float maxB = Math.Max(LowColor.GetBrightness(), HighColor.GetBrightness());

			float minH = Math.Min(LowColor.GetHue(), HighColor.GetHue());
			float minS = Math.Min(LowColor.GetSaturation(), HighColor.GetSaturation());
			float minB = Math.Min(LowColor.GetBrightness(), HighColor.GetBrightness());

			// If the input red, green, and blue values are between the low color and the high color's red, green, and blue values, return true.
			// Otherwise, return false.
			if (inputColor.R >= minH && inputColor.R <= maxH)
			{
				if (inputColor.G >= minS && inputColor.G <= maxS)
				{
					if (inputColor.B >= minB && inputColor.B <= maxB)
					{
						return true;
					}
				}
			}
			 */

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
		private Color m_backgroundColor = Color.White;

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

		public Color BackgroundColor
		{
			get { return m_backgroundColor; }
			set { m_backgroundColor = value; }
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
		public bool MapColor(ColorRange inRange, Color outColor)
		{
			if (!IsOverlap(inRange))
			{
				m_colorMap.Add(new KeyValuePair<ColorRange, Color>(inRange, outColor));
				return true;
			}

			return false;
		}

		public bool IsOverlap(ColorRange range)
		{
			Color light = range.LightColor, dark = range.DarkColor;
			foreach (KeyValuePair<ColorRange, Color> kvp in m_colorMap)
			{
				if (kvp.Key.IsInRange(light) || kvp.Key.IsInRange(dark))
					return true;
			}

			return false;
		}

		/// <summary>
		/// Outline the picture.
		/// </summary>
		public void Outline()
		{
			// Initializing our output image to the same size as our input image
			m_outputImage = new Bitmap(m_inputImage.Width, m_inputImage.Height);
			using (Graphics g = Graphics.FromImage(m_outputImage))
			{
				Brush b = new SolidBrush(m_backgroundColor);
				g.FillRectangle(b, 0, 0, m_outputImage.Width, m_outputImage.Height);
			}

			/*
			Rectangle rectangle = new Rectangle(0, 0, m_outputImage.Width, m_outputImage.Height);
		
			// Referenced https://msdn.microsoft.com/en-us/library/5ey6h79d%28v=vs.80%29.aspx for this code.
			System.Drawing.Imaging.BitmapData bmpData =
				m_outputImage.LockBits(rectangle, System.Drawing.Imaging.ImageLockMode.ReadWrite,
				m_outputImage.PixelFormat);
			 */

			for (int y = 0; y < m_inputImage.Height; y++)
			{
				for (int x = 0; x < m_inputImage.Width; x++)
				{
					Color currentPixel = m_inputImage.GetPixel(x, y);
					foreach (KeyValuePair<ColorRange, Color> colorMap in m_colorMap)
					{
						if (colorMap.Key.IsInRange(currentPixel))
							m_outputImage.SetPixel(x, y, colorMap.Value);
					}
				}
			}
		}

		public void Reset()
		{
			m_outputImage = null;
			m_backgroundColor = Color.White;
			m_colorMap.Clear();
		}
	}
}