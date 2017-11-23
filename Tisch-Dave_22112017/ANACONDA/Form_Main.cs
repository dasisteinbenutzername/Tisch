using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANACONDA
{
    public partial class Form_MAIN : Form
    {
        public Form_MAIN()
        {
            InitializeComponent();
            
        }



        #region "Pauls Tests"

        private void btn_test_paul_Click(object sender, EventArgs e)
        {
            //Application.Run(new Tests_Paul.Form1());
            //Anwendungen.Simulation.Simulations_Form simulations_Form = new Anwendungen.Simulation.Simulations_Form();
            Anwendungen.Simulation.Simulations_Form simulations_Form = new Anwendungen.SimulationsDrawing.Simulation_drawing();
            simulations_Form.Show();
        }


        #endregion

        private void btn_klaus_test_Click(object sender, EventArgs e)
        {
            //Anwendungen.FangDenAnderen.FangDenAnderen fangen = new Anwendungen.FangDenAnderen.FangDenAnderen();
            //fangen.Show();
            var bla = new Kern.Klassen.analysis();
            bla.KommunikationInAuftragGeben();
            
        }

        private void Form_MAIN_Load(object sender, EventArgs e)
        {
            var kommunikation1 = new Kern.Klassen.communication();
            var analyse = new Kern.Klassen.analysis();
            var tcpclient1 = new Kern.Klassen.tcpclient();           
            tcpclient1.message = "TEST";
            kommunikation1.CommunicationReceived += analyse.OnCommunicationReceived;
            analyse.SendCommunication += tcpclient1.OnSendCommunication;
            

            //Port übergebbar Machen
            ThreadStart del = new ThreadStart(kommunikation1.start_tcp_listener);
            Thread thread = new Thread(del);
            ThreadStart del2 = new ThreadStart(tcpclient1.sendCommunication);
            Thread th2 = new Thread(del2);
            thread.Start();
            analyse.KommunikationInAuftragGeben();
            //th2.Start();
        }
    }
}
