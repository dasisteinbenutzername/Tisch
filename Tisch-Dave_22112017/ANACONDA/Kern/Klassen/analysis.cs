using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime;
using System.Windows.Forms;

namespace ANACONDA.Kern.Klassen
{
    class analysis
    {

        //Events
        public delegate void SendCommunicationEventHandler(object a, EventArgs args);
        public event SendCommunicationEventHandler SendCommunication;




        //Funktionen
        public void OnCommunicationReceived(object obj, CommunicationEventArgs e)
        {
            Anwendungen.FangDenAnderen.FangDenAnderen fangen = new Anwendungen.FangDenAnderen.FangDenAnderen();
            Application.Run(fangen);
        }

        public void KommunikationInAuftragGeben()
        {
            string nachricht = "123Test";
            OnSendCommunication(this,EventArgs.Empty);
        }


        protected virtual void OnSendCommunication(object obj, EventArgs e)
        {
            if(SendCommunication!=null)
            {
                SendCommunication(this, EventArgs.Empty);
            }
        }
    }
}
