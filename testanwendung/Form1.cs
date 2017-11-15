using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testanwendung
{
    public partial class Form1 : Form
    {
        List<LED_P> All_LED = new List<LED_P>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            byte r = 255;
            byte g = 0;
            byte b = 0;

            Color_RGB nrgb = new Color_RGB(r,g,b);

            LED_P nLED = new LED_P(x, y, nrgb);

            All_LED.Add(nLED);

            LED_P n2LED = new LED_P(1, y, nrgb);
            All_LED.Add(n2LED);

            DrawRectangleRectangle(All_LED);
        }



        private void btn_test2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo Raphael");
        }
        public void DrawRectangleRectangle(List<LED_P> led_list)
        {
            Graphics e = panel1.CreateGraphics();
            Rectangle rect = new Rectangle( 0,  0, 10, 10);
            foreach (LED_P LED in led_list)
            {
                //MessageBox.Show(LED.x.ToString());
                byte red = LED.RGB.r;
                byte green = LED.RGB.g;
                byte blue = LED.RGB.b;
                rect.X = LED.x*10;
                rect.Y = LED.y*10;
                Brush nbrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(red, green, blue));
                e.FillRectangle(nbrush, rect);
                nbrush.Dispose();
            }



        }

    }
}
