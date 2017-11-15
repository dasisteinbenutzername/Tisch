using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANACONDA.Tests_Paul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_test_Click(object sender, EventArgs e)
        {
            List<LED_P> testlistofled = new List<LED_P>();
            testlistofled.Add(new LED_P(0, 0, new Color_RGB(255, 255, 255)));
            testlistofled.Add(new LED_P(5, 17, new Color_RGB(255, 255, 255)));
            testlistofled.Add(new LED_P(0, 10, new Color_RGB(255, 255, 255)));
            testlistofled.Add(new LED_P(22, 6, new Color_RGB(255, 255, 255)));
            testlistofled.Add(new LED_P(3, 3, new Color_RGB(255, 255, 255)));
            testlistofled.Add(new LED_P(7, 29, new Color_RGB(255, 255, 255)));
            testlistofled.Add(new LED_P(29, 12, new Color_RGB(255, 255, 255)));
            testlistofled.Add(new LED_P(23, 28, new Color_RGB(255, 255, 255)));
            testlistofled.Add(new LED_P(15, 15, new Color_RGB(255, 255, 255)));
            testlistofled.Add(new LED_P(15, 16, new Color_RGB(255, 255, 255)));
            testlistofled.Add(new LED_P(15, 17, new Color_RGB(255, 255, 255)));
            testlistofled.Add(new LED_P(15, 18, new Color_RGB(255, 255, 255)));

            led_update(testlistofled);
        }




        public List<LED_Button> led_simulationlist = new List<LED_Button>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {


                    Color_RGB nrgb = new Color_RGB(255, 255, 255);
                    LED_P nled = new LED_P(j, i, nrgb);



                    LED_Button dynamicButton = new LED_Button(nled);
                    dynamicButton.Parent = panel_test;
                    dynamicButton.Location = new Point(20 * nled.x, 20 * nled.y);
                    dynamicButton.Height = 20;
                    dynamicButton.Width = 20;
                    dynamicButton.LED = new LED_P(j, i, new Color_RGB(0, 0, 0));
                    dynamicButton.Name = j.ToString() + ":" + i.ToString();

                    led_simulationlist.Add(dynamicButton);
                }

            }
        }

        public void led_update(List<LED_P> nled_list)
        {
            foreach (LED_P nled in nled_list)
            {
                int i = 0;
                i = 30 * nled.y;
                i = i + nled.x;

                //led_simulationlist[i].LED.RGB = nled.RGB;
                led_simulationlist[i].setbackcolor(nled.RGB);

            }



        }


    }
}
