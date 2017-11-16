using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANACONDA.Kern.Klassen;

namespace ANACONDA.Kern.Klassen
{
    public class EventArgs_WithLedList: EventArgs
    {
        //Konstruktor
        EventArgs_WithLedList()
        {
            logical_LedList = new List<LED>();
        }
        EventArgs_WithLedList(List<LED> nlogical_LedList)
        {
            logical_LedList = nlogical_LedList;
        }

        //Atribute
        public List<LED> logical_LedList;


        //Event Stuff

        // die Eventhandler-Methode.
        public delegate void EventDelegate();
        // Das Event-Objekt ist vom Typ dieses Delegaten
        public event EventDelegate MyEvent;

        public void OnEvent()
        {
            // Prüft ob das Event überhaupt einen Abonnenten hat.
            if (MyEvent != null)
                MyEvent();
        }

        public void Observable()
        {
            // Das Event wird gefeuert wenn result ungleich 0 ist.
            if (logical_LedList.Count > 0)
                OnEvent();
        }

        // beispiel aufruf
        /*
        EventArgs_WithLedList v1 = new EventArgs_WithLedList(new List<LED>());
        v1.MyEvent += new EventArgs_WithLedList.EventDelegate(event_set_simulation_led);
        v1.Observable();
        */

    }




    public class EventArgs_WithComand: EventArgs
    {
        //Konstuktor
        public EventArgs_WithComand(Command_left x)
        {
            command = x;
        }
        public EventArgs_WithComand(Command_right x)
        {
            command = x;
        }
        public EventArgs_WithComand(Command_up x)
        {
            command = x;
        }
        public EventArgs_WithComand(Command_down x)
        {
            command = x;
        }
        //Atribute
        public object command;

    }

    public class Command_left
    { }
    public class Command_right
    { }
    public class Command_up
    { }
    public class Command_down
    { }

}
