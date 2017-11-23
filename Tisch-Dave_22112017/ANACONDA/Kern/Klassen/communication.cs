using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ANACONDA.Kern.Klassen
{
    public class CommunicationEventArgs : EventArgs
    {
        public String NetStream { get; set; }
    }
    public class communication
    {
        //1 - Delegate definieren
        public delegate void CommunicationReceivedEventHandler(object obj, CommunicationEventArgs args);
        //2 - Define an event
        public event CommunicationReceivedEventHandler CommunicationReceived;
        
        
        
        //Verbindungsinfos 
        IPAddress localaddr = IPAddress.Parse("127.0.0.1");
        public Int32 port = 13000;





        public void start_tcp_listener()
        {

            TcpListener listener1 = new TcpListener(localaddr, port);
            listener1.Start();
            // Buffer for reading data
            Byte[] bytes = new Byte[256];
            String data = null;

            while (true)
            {
                data = null;
                TcpClient client = listener1.AcceptTcpClient();
                // Get a stream object for reading and writing
                NetworkStream stream = client.GetStream();

                int i;

                // Loop to receive all the data sent by the client.
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    // Translate data bytes to a ASCII string.
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);


                    //3 - Event auslösen
                    OnCommunicationReceived(data);

                }
            }
        }




        //3 - Raise the event
        protected virtual void OnCommunicationReceived(String Stream)
        {
            if (CommunicationReceived != null)
            {
                CommunicationReceived(this, new CommunicationEventArgs() {NetStream = Stream});
            }
        }
    }
}
