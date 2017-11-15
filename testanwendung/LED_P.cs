using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testanwendung
{
    public class LED_P
    {
        public LED_P(int nx, int ny, Color_RGB nRGB)
        {
            x = nx;
            y = ny;
            RGB = nRGB;

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



}
