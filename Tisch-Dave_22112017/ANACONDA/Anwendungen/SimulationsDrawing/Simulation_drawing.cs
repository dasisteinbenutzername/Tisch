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


namespace ANACONDA.Anwendungen.SimulationsDrawing
{
    public partial class Simulation_drawing : Simulation.Simulations_Form
    {
        public Simulation_drawing()
        {
            InitializeComponent();
        }

        private void Simulation_drawing_Load(object sender, EventArgs e)
        {
            foreach (LED_Button nLED_Button in LED_Button_Simulation_List)
            {
                //nLED_Button.Click += new System.EventHandler(this.btn_LED_Click);
                nLED_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_LED_MouseDown);
                nLED_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_LED_Mouseup);

            }

        }


        public Point mousedownposition;

        private void btn_LED_MouseDown(object sender, EventArgs e)
        {
            LED_Button button = (LED_Button)sender;
            mousedownposition = button.Location;
        }
        private void btn_LED_Mouseup(object sender, EventArgs e)
        {
            int x1, x2, xn, y1, y2, yn;
            LED_Button button = (LED_Button)sender;
            //x2 = (MousePosition.X -panel_position.X)/20;
            //y2 = (MousePosition.Y- panel_position.Y)/20;
            Point mouse = this.PointToClient(Cursor.Position);
            x2 = (mouse.X - panel_position.X)/20;
            y2 = (mouse.Y - panel_position.Y)/20;
            x1 = mousedownposition.X/20;
            y1 = mousedownposition.Y/20;

            if (x2 > 29)
                x2 = 29;
            if (y2 > 29)
                y2 = 29;
            if (x2 < x1)
            {
                xn = x2; x2 = x1; x1 = xn;
            }
            if (y2 < y1)
            {
                yn = y2; y2 = y1; y1 = yn;
            }

            int c;

            for (yn = y1; yn <= y2; yn++)
            {
                for (xn=x1; xn <=x2; xn++)
                {
                    c = yn * 30 + xn;
                    LED_Button_Simulation_List[c].setbackcolor(255,255,255);
                }

            }




        }

        private void btn_Objekt_Schreiben_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LED_Button_Simulation_List.ToString());
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {

        }



    }
}
