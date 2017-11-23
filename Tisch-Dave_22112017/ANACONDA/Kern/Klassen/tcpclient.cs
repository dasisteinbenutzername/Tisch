using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANACONDA.Kern.Klassen
{
    class tcpclient
    {
        //public Int32 port = 13001;
        public string destinationip = "127.0.0.1";
        public string message = "Das ist ein Test, ob auch alles funktioniert";
        public Int32 port = 15000;

        public void sendCommunication()
        {
            try
            {
                
                TcpClient client = new TcpClient(destinationip, port);

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();

                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);

                MessageBox.Show("Sent: {0}", message);
                // Close everything.
                stream.Close();
                client.Close();
            }
            catch (SocketException e)
            {
                MessageBox.Show("Fahler" + e);
            }
            
        }


        public void OnSendCommunication(object obj, EventArgs e)
        {
            MessageBox.Show("Das Ereignis wurde korrekt ausgelöst");
            message = "Ein Test";
            destinationip = "127.0.0.1";
            port = 15000;
            sendCommunication();
        }
    }

}
