using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANACONDA.Kern.Klassen;

namespace ANACONDA.Anwendungen.FangDenAnderen
{
    class FangDenAnderen : Anwendungen.Basisklasse_Anwendung.Bassisklasse_Anwendung
    {
        List<LED> player1 = new List<LED>();
        List<LED> player2 = new List<LED>();
        public FangDenAnderen()
        {
            player2.Add(new LED(15, 15, new Color_RGB(0, 0, 255)));
            player2.Add(new LED(16, 16, new Color_RGB(0, 255, 255)));
            player2.Add(new LED(15, 16, new Color_RGB(255, 0, 0)));
            player2.Add(new LED(16, 15, new Color_RGB(0, 255, 0)));
        }
        public override void btn_p1_1_Click(object sender, EventArgs e)
        {

        }
        public override void btn_p1_2_Click(object sender, EventArgs e)
        {

        }
        public override void btn_p1_3_Click(object sender, EventArgs e)
        {

        }
        public override void btn_p1_4_Click(object sender, EventArgs e)
        {

        }
        public override void btn_p1_h_Click(object sender, EventArgs e)
        {
            bewege(0, -1, player1);
            pos_aenderung_uebergeben(player1);
        }
        public override void btn_p1_L_Click(object sender, EventArgs e)
        {
            bewege(-1, 0, player1);
            pos_aenderung_uebergeben(player1);
        }
        public override void btn_p1_r_Click(object sender, EventArgs e)
        {
            bewege(1, 0, player1);
            pos_aenderung_uebergeben(player1);
        }
        public override void btn_p1_v_Click(object sender, EventArgs e)
        {
            bewege(0, 1, player1);
            pos_aenderung_uebergeben(player1);
        }
        public override void btn_p2_1_Click(object sender, EventArgs e)
        {
            pos_aenderung_uebergeben(player2);
        }
        public override void btn_p2_2_Click(object sender, EventArgs e)
        {

        }
        public override void btn_p2_3_Click(object sender, EventArgs e)
        {

        }
        public override void btn_p2_4_Click(object sender, EventArgs e)
        {

        }
        public override void btn_p2_h_Click(object sender, EventArgs e)
        {
            bewege(0, -1, player2);
            pos_aenderung_uebergeben(player2);
        }
        public override void btn_p2_L_Click(object sender, EventArgs e)
        {
            bewege(1, 0, player2);
            pos_aenderung_uebergeben(player2);
        }
        public override void btn_p2_r_Click(object sender, EventArgs e)
        {
            bewege(-1, 0, player2);
            pos_aenderung_uebergeben(player2);
        }
        public override void btn_p2_v_Click(object sender, EventArgs e)
        {
            bewege(0, 1, player2);
            pos_aenderung_uebergeben(player2);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FangDenAnderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(618, 741);
            this.Name = "FangDenAnderen";
            this.ResumeLayout(false);

        }
    }
}
