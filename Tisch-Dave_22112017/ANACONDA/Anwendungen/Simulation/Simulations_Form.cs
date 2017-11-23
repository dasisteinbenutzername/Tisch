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
        public Point panel_position;
        #endregion

        public Simulations_Form()
        {
            InitializeComponent();
            
        }

        private void Simulations_Form_Load(object sender, EventArgs e)
        {
            panel_position.X = panel1.Location.X + panel_test.Location.X;
            panel_position.Y = panel1.Location.Y + panel_test.Location.Y;
            feld_aufbau();
            //objekte_laden();

            btn_p1_1.Click += new System.EventHandler(this.btn_p1_1_Click);
            btn_p1_2.Click += new System.EventHandler(this.btn_p1_2_Click);
            btn_p1_3.Click += new System.EventHandler(this.btn_p1_3_Click);
            btn_p1_4.Click += new System.EventHandler(this.btn_p1_4_Click);
            btn_p1_h.Click += new System.EventHandler(this.btn_p1_h_Click);
            btn_p1_L.Click += new System.EventHandler(this.btn_p1_L_Click);
            btn_p1_r.Click += new System.EventHandler(this.btn_p1_r_Click);
            btn_p1_v.Click += new System.EventHandler(this.btn_p1_v_Click);
            btn_p2_1.Click += new System.EventHandler(this.btn_p2_1_Click);
            btn_p2_2.Click += new System.EventHandler(this.btn_p2_2_Click);
            btn_p2_3.Click += new System.EventHandler(this.btn_p2_3_Click);
            btn_p2_4.Click += new System.EventHandler(this.btn_p2_4_Click);
            btn_p2_h.Click += new System.EventHandler(this.btn_p2_h_Click);
            btn_p2_L.Click += new System.EventHandler(this.btn_p2_L_Click);
            btn_p2_r.Click += new System.EventHandler(this.btn_p2_r_Click);
            btn_p2_v.Click += new System.EventHandler(this.btn_p2_v_Click);


        }

        /// <summary>
        /// baut das Testfeld an LEDs auf.
        /// </summary>
        private void feld_aufbau()
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



        /// <summary>
        /// Nimmt eine LED liste und sezt die Informationen in der Simulation um.
        /// </summary>
        /// <param name="toset_led_list"></param>
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


        //private void btn_LED_Click(object sender, EventArgs e)
        //{
        //    Color_RGB ccolor = new Color_RGB(255,255,255);
        //    LED_Button current_btn;
        //    current_btn = (LED_Button)sender;
        //    current_btn.setbackcolor(ccolor);
        //}

        #region "override functions"

        public virtual void btn_p1_1_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p1_2_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p1_3_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p1_4_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p1_h_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p1_L_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p1_r_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p1_v_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p2_1_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p2_2_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p2_3_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p2_4_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p2_h_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p2_L_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p2_r_Click(object sender, EventArgs e)
        {

        }
        public virtual void btn_p2_v_Click(object sender, EventArgs e)
        {

        }

        #endregion


    }

}
