using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            Anwendungen.Simulation.Simulations_Form simulations_Form = new Anwendungen.Simulation.Simulations_Form();
            
            simulations_Form.Show();
        }
        #endregion



    }
}
