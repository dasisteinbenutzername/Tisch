
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANACONDA.Anwendungen.Simulation;
using ANACONDA.Kern.Klassen;

namespace ANACONDA.Anwendungen.Basisklasse_Anwendung
{
    class Bassisklasse_Anwendung : Simulations_Form
    {
        ///Übergeben der Liste an Simulation (---und an den Tisch---)
        public void pos_aenderung_uebergeben(List<LED> toset_led_list)
        {
            set_simulation_led(toset_led_list);
        }
        /// <summary>
        /// Klaus funktion ist müll
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="toset_led_list"></param>
        public void bewege(int x, int y, List<LED> toset_led_list)
        {
            foreach (LED toset_led in toset_led_list)
            {
                int ty = toset_led.y + y;
                int tx = toset_led.x + x;
                if (ty > 0 && ty < 30) toset_led.y = ty;
                if (tx > 0 && tx < 30) toset_led.x = tx;
            }
        }
    }
}
