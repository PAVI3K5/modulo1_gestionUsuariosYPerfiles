using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBugs.GUILayer.Princ
{
    public static class ColorTemas
    {
        public static Color ColorPrimario  { get; set; }
        public static Color ColorSecundario { get; set; }
        //Agregar en esta lista los colores que querramos usar para el menu
        public static List<string> ColorList = new List<string>
        {
            "#430058",
            "#6A1485",
            "#9124B4"
        };
        public static Color CambiarOpacidadColor(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            
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
