using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ANACONDA.Kern.Klassen;


namespace ANACONDA.Anwendungen.Simulation
{
    public partial class Simulations_Form : Form
    {
        #region "Simulations Variablen"
        public List<LED_Button> LED_Button_Simulation_List = new List<LED_Button>();
        #endregion

        public Simulations_Form()
        {
            InitializeComponent();
        }

        private void Simulations_Form_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    LED_Button nLED_Button = new LED_Button(j, i);
                    nLED_Button.Parent = panel_test;
                    nLED_Button.Location = new Point(20 * j, 20 * i);
                    nLED_Button.Size = new Size(20, 20);

                    LED_Button_Simulation_List.Add(nLED_Button);
                }
            }
        }




        public void set_simulation_led(List<LED> toset_led_list)
        {
            foreach (LED toset_led in toset_led_list)
            {
                int i = 0;
                i = 30 * toset_led.y;
                i = i + toset_led.x;
                LED_Button_Simulation_List[i].setbackcolor(toset_led.RGB);
            }
        }

        public static void event_set_simulation_led(EventArgs_WithLedList e)
        {
          // new set_simulation_led((List<LED>)e.logical_LedList);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            ANACONDA.Tests_Paul.Formtest testform = new ANACONDA.Tests_Paul.Formtest();

            testform.Show();

        }
    }
}
