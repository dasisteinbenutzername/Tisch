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

        //Event Spieler 1 Norden
        public delegate void Player1PressedNorthEventHandler(object obj, EventArgs args);
        public event Player1PressedNorthEventHandler Player1PressedNorth;

        //Event Spieler 1 Osten
        public delegate void Player1PressedEastEventHandler(object obj, EventArgs args);
        public event Player1PressedEastEventHandler Player1PressedEast;

        //Event Spieler 1 Süden
        public delegate void Player1PressedSouthEventHandler(object obj, EventArgs args);
        public event Player1PressedSouthEventHandler Player1PressedSouth;

        //Event Spieler 1 Westen
        public delegate void Player1PressedWestEventHandler(object obj, EventArgs args);
        public event Player1PressedWestEventHandler Player1PressedWest;

        //Event Spieler 2 Norden
        public delegate void Player2PressedNorthEventHandler(object obj, EventArgs args);
        public event Player2PressedNorthEventHandler Player2PressedNorth;

        //Event Spieler 2 Osten
        public delegate void Player2PressedEastEventHandler(object obj, EventArgs args);
        public event Player2PressedEastEventHandler Player2PressedEast;

        //Event Spieler 2 Süden
        public delegate void Player2PressedSouthEventHandler(object obj, EventArgs args);
        public event Player2PressedSouthEventHandler Player2PressedSouth;

        //Event Spieler 2 Westen
        public delegate void Player2PressedWestEventHandler(object obj, EventArgs args);
        public event Player2PressedWestEventHandler Player2PressedWest;



        //Funktionen
        public void OnCommunicationReceived(object obj, CommunicationEventArgs e)
        {
            MessageBox.Show(e.NetStream);
            switch(e.NetStream)
            {
                case "1N":
                    MessageBox.Show("Spieler1; Norden");
                    //Ereignis "Spieler 1 drückt norden
                    OnPlayer1PressedNorth(this,EventArgs.Empty);
                    break;
                case "1O":
                    MessageBox.Show("Spieler1; Osten");
                    //Ereignis "Spieler 1 drückt osten
                    OnPlayer1PressedEast(this, EventArgs.Empty);
                    break;
                case "1S":
                    MessageBox.Show("Spieler1; Süden");
                    //Ereignis "Spieler 1 drückt süden
                    OnPlayer1PressedSouth(this, EventArgs.Empty);
                    break;
                case "1W":
                    MessageBox.Show("Spieler1; Westen");
                    //Ereignis "Spieler 1 drückt westen
                    OnPlayer1PressedWest(this, EventArgs.Empty);
                    break;
                case "2N":
                    MessageBox.Show("Spieler2; Norden");
                    //Ereignis "Spieler 2 drückt Norden
                    OnPlayer2PressedNorth(this, EventArgs.Empty);
                    break;
                case "2O":
                    MessageBox.Show("Spieler2; Osten");
                    //Ereignis "Spieler 2 drückt osten
                    OnPlayer2PressedEast(this, EventArgs.Empty);
                    break;
                case "2S":
                    MessageBox.Show("Spieler2; Süden");
                    //Ereignis "Spieler 2 drückt süden
                    OnPlayer2PressedSouth(this, EventArgs.Empty);
                    break;
                case "2W":
                    MessageBox.Show("Spieler2; Westen");
                    //Ereignis "Spieler 2 drückt westen
                    OnPlayer2PressedWest(this, EventArgs.Empty);
                    break;
            }
            //Anwendungen.FangDenAnderen.FangDenAnderen fangen = new Anwendungen.FangDenAnderen.FangDenAnderen();
            //Application.Run(fangen);
        }
        //Funktion zu Ereignis Spieler 1 Nord
        protected virtual void OnPlayer1PressedNorth(object obj, EventArgs e)
        {
            MessageBox.Show("Ereignis erfolgreich ausgelöst");
            if (Player1PressedNorth!=null)
            {
                Player1PressedNorth(this, EventArgs.Empty);
            }
        }

        //Funktion zu Ereignis Spieler 1 Ost
        protected virtual void OnPlayer1PressedEast(object obj, EventArgs e)
        {
            MessageBox.Show("Ereignis erfolgreich ausgelöst");
            if (Player1PressedEast != null)
            {
                Player1PressedEast(this, EventArgs.Empty);
            }
        }
        //Funktion zu Ereignis Spieler 1 Süd
        protected virtual void OnPlayer1PressedSouth(object obj, EventArgs e)
        {
            MessageBox.Show("Ereignis erfolgreich ausgelöst");
            if (Player1PressedSouth != null)
            {
                Player1PressedSouth(this, EventArgs.Empty);
            }
        }
        //Funktion zu Ereignis Spieler 1 West
        protected virtual void OnPlayer1PressedWest(object obj, EventArgs e)
        {
            MessageBox.Show("Ereignis erfolgreich ausgelöst");
            if (Player1PressedWest != null)
            {
                Player1PressedWest(this, EventArgs.Empty);
            }
        }
        //Funktion zu Ereignis Spieler 2 Nord
        protected virtual void OnPlayer2PressedNorth(object obj, EventArgs e)
        {
            MessageBox.Show("Ereignis erfolgreich ausgelöst");
            if (Player2PressedNorth != null)
            {
                Player2PressedNorth(this, EventArgs.Empty);
            }
        }
        //Funktion zu Ereignis Spieler 2 Ost
        protected virtual void OnPlayer2PressedEast(object obj, EventArgs e)
        {
            MessageBox.Show("Ereignis erfolgreich ausgelöst");
            if (Player2PressedEast != null)
            {
                Player2PressedEast(this, EventArgs.Empty);
            }
        }
        //Funktion zu Ereignis Spieler 2 Süd
        protected virtual void OnPlayer2PressedSouth(object obj, EventArgs e)
        {
            MessageBox.Show("Ereignis erfolgreich ausgelöst");
            if (Player2PressedSouth != null)
            {
                Player2PressedSouth(this, EventArgs.Empty);
            }
        }
        //Funktion zu Ereignis Spieler 2 West
        protected virtual void OnPlayer2PressedWest(object obj, EventArgs e)
        {
            MessageBox.Show("Ereignis erfolgreich ausgelöst");
            if (Player2PressedWest != null)
            {
                Player2PressedNorth(this, EventArgs.Empty);
            }
        }



        protected virtual void OnSendCommunication(object obj, EventArgs e)
        {
            if(SendCommunication!=null)
            {
                SendCommunication(this, EventArgs.Empty);
            }
        }

        //Nur ein Test
        public void KommunikationInAuftragGeben()
        {
            string nachricht = "123Test";
            OnSendCommunication(this, EventArgs.Empty);
        }
    }
}
