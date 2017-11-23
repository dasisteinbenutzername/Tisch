using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ANACONDA.Tests_Paul
{
    class Class1
    {
    }

    public class LED_P
    {
        public LED_P(int nx, int ny, Color_RGB nRGB)
        {
            x = nx;
            y = ny;
            RGB = nRGB;

        }
        public void set_ledcolor(Color_RGB rgb_color)
        {
            RGB = rgb_color;
        }


        public int x;
        public int y;
        public Color_RGB RGB;


    }

    public class Color_RGB
    {
        public Color_RGB(byte nr, byte ng, byte nb)
        {
            r = nr;
            g = ng;
            b = nb;

        }


        public byte r;
        public byte g;
        public byte b;
    }

    public class LED_Button : System.Windows.Forms.Button
    {

        public LED_P LED;

        public LED_Button(LED_P nLED)
        {
            LED = nLED;
        }

        public void setbackcolor(byte r, byte g, byte b)
        {
            BackColor = Color.FromArgb(255, r, g, b);
            LED.RGB.r = r;
            LED.RGB.g = g;
            LED.RGB.b = b;
            //
        }
        public void setbackcolor(Color_RGB rgb_color)
        {
            BackColor = Color.FromArgb(255, rgb_color.r, rgb_color.g, rgb_color.b);
            LED.set_ledcolor(rgb_color);
        }


        public override Color BackColor
        {
            get
            {
                //return base.BackColor;
                //return BackColor = Color.Green;
                return Color.FromArgb(LED.RGB.r, LED.RGB.g, LED.RGB.b);
            }

            set
            {
                base.BackColor = value;
                //BackColor = Color.Green;
                //base.BackColor = Color.Green;
            }
        }



    }








}
