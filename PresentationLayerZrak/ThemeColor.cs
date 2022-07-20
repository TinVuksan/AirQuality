using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayerZrak
{
   public class ThemeColor
    {
      public static List<string> ColorList = new List<string>() {
                                                                    "#9494b8",
		                                                            "#8585ad",
		                                                            "#7575a3",
		                                                            "#666699",
		                                                            "#5c5c8a",
		                                                            "#52527a",
                                                                    "#47476b",
		                                                            "#3d3d5c",
		                                                            "#33334d",
                                                                    "#5c5c8a",
 		                                                            "#52527a",
                                                                    "#47476b",
 		                                                            "#3d3d5c",
		                                                            "#33334d",
		                                                            "#29293d"};

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

    }
}
