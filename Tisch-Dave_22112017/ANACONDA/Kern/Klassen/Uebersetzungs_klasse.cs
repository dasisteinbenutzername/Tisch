using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANACONDA.Kern.Klassen;

namespace ANACONDA.Kern.Klassen
{
    class Uebersetzungs_klasse
    {

/// <summary>
/// jo das ist eine funktion die aus der led liste dir den asci kommunikations string giebt
/// </summary>
/// <param name="led_List"></param>
/// <returns></returns>
        public string list_to_string(List<LED> led_List)
        {
            
            string ruckgabe = "";
            int i;
            if (led_List.Count >= 1)
            {
                for (i = 0; i < led_List.Count - 1; i++) { }
                {
                    ruckgabe = ruckgabe + Convert.ToByte(led_List[i].x).ToString() + Convert.ToByte(led_List[i].y).ToString() + led_List[i].RGB.r.ToString() + led_List[i].RGB.g.ToString() + led_List[i].RGB.b.ToString() + "n";
                }
                i = led_List.Count - 1;
                ruckgabe = ruckgabe + Convert.ToByte(led_List[i].x).ToString() + Convert.ToByte(led_List[i].y).ToString() + led_List[i].RGB.r.ToString() + led_List[i].RGB.g.ToString() + led_List[i].RGB.b.ToString() + "e";
            }
            return ruckgabe;
        }
        /// <summary>
        /// jo das ist eine funktion die aus der led liste dir den asci kommunikations string giebt
        /// </summary>
        /// <param name="led_List"></param>
        /// <returns></returns>
        public string list_to_string(List<LED_Button> led_button_List)
        {
            List<LED> led_list = new List<LED>();

            foreach(LED_Button led_Button in led_button_List)
            {
                led_list.Add(led_Button.LED);
            }

            return list_to_string(led_list);

        }




    }


}
