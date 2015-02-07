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
        // The low end of our color range.
        public Color LowColor { get; }

        // The high end of our color range.
        public Color HighColor { get; }

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
        // Maps input color ranges to output colors for the Outline() method.
        private List<KeyValuePair<ColorRange, Color>> m_colorMap = new List<KeyValuePair<ColorRange, Color>>();
        
        // Our input picture - the picture we want to outline with Outline().
        public Image InputImage { get; set; }
        
        // Our output picture - the result of outlining with Outline().
        public Image OutputImage { get; }

        /// <summary>
        /// Constructs an Outliner object with InputImage initialized.
        /// </summary>
        /// <param name="inputImage">The image to be converted.</param>
        public Outliner(Image inputImage)
        {
            InputImage = inputImage;
        }

        /// <summary>
        /// Constructs an Outliner object.
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
            /* TODO:
             * Go through pixels in image
             * Check if pixels are in range for each key in the color map using m_colorMap.
             * 
             */
        }
    }
}