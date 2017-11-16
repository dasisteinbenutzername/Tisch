using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ANACONDA.Kern.Klassen
{
    public class Color_RGB
    {
        //Konstruktor
        public Color_RGB(byte nr, byte ng, byte nb)
        {
            r = nr; g = ng; b = nb;
        }

        //Atribute
        public byte r, g, b;
    }

    public class LED
    {
        //Konstruktor
        public LED(int nx, int ny, Color_RGB nRGB)
        {
            x = nx; y = ny; RGB = nRGB;
        }
        public LED(int nx, int ny, byte nr, byte ng, byte nb)
        {
            x = nx; y = ny; RGB.r = nr; RGB.g = ng; RGB.b = nb;
        }

        //Atribute
        public int x, y;
        public Color_RGB RGB;

        //Funktionen
        public void set_ledcolor(Color_RGB rgb_color)
        {
            RGB = rgb_color;
        }
    }




    public class LED_Button : System.Windows.Forms.Button
    {
        //Konstruktor
        public LED_Button(LED nLED)
        {
            LED = nLED;
        }
        public LED_Button(int x, int y)
        {
            LED = new LED(x, y, new Color_RGB(0, 0, 0));
        }
        public LED_Button(int x, int y, Color_RGB rgb)
        {
            LED = new LED(x, y, rgb);
        }

        //Atribute
        public LED LED;  
        public override Color BackColor
        {
            get
            {
                return Color.FromArgb(LED.RGB.r, LED.RGB.g, LED.RGB.b);
            }

            set
            {
                base.BackColor = value;
            }
        }
        //Funktionen
        public void setbackcolor(byte r, byte g, byte b)
        {
            BackColor = Color.FromArgb(255, r, g, b);
            LED.RGB.r = r;
            LED.RGB.g = g;
            LED.RGB.b = b;
        }
        public void setbackcolor(Color_RGB rgb_color)
        {
            BackColor = Color.FromArgb(255, rgb_color.r, rgb_color.g, rgb_color.b);
            LED.set_ledcolor(rgb_color);
        }
    }



}
