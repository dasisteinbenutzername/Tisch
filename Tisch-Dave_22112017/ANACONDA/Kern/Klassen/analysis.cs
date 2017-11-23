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
        public void OnCommunicationReceived(object obj, CommunicationEventArgs e)
        {
            Anwendungen.FangDenAnderen.FangDenAnderen fangen = new Anwendungen.FangDenAnderen.FangDenAnderen();
            Application.Run(fangen);
        }

    }
}
