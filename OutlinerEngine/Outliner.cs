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
        public Color LowColor { get; set; }

        // The high end of our color range.
        public Color HighColor { get; set; }

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
        // Maps input colors to output colors for the Outline() method.
        private Dictionary<Color, Color> m_colorMap = new Dictionary<Color,Color>();
        
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
        /// Adds a new Color to Color relationship to the outliner.
        /// Example:
        ///     MapColor(Color.Black, Color.Blue) //Now, all pixels in the black range will be blue in the output image.
        /// </summary>
        /// <param name="inColor">The "from" color - the color in the original picture to be replaced.</param>
        /// <param name="outColor">The "to" color - the color in the new picture to replace the old color.</param>
        public void MapColor(Color inColor, Color outColor)
        {
            m_colorMap.Add(inColor, outColor);
        }

        /// <summary>
        /// Outline the picture.
        /// </summary>
        public void Outline()
        {

        }
    }
}