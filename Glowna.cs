using System;
using System.Windows.Forms;

namespace AI_Fuzzy_P1
{
    public partial class Glowna : Form
    {
        Mechanizm mechanizm;

        WykresWybierz wykresT;
        WykresWybierz wykresWILGOT;


        /*  public Glowna(Mechanizm mechanizm)
          {
            this.  mechanizm = new Mechanizm(this);
                 this.mechanizm = mechanizm;
          }*/

        public Glowna(WykresWybierz wykresTemp, WykresWybierz wykresWILGOT)
        {
            this.wykresT = wykresTemp;
            this.wykresWILGOT = wykresWILGOT;
        }

        public Glowna(WykresWybierz wykresWILGOT)
        {
            this.wykresWILGOT = wykresWILGOT;
        }

        public Glowna()
        {
            InitializeComponent();
            //    WykresWybierz wybierz = new WykresWybierz(this);           
        }

        public Glowna(Mechanizm mechan)
        {
            this.mechanizm = mechan;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //  Mechanizm   mechanizm = new Mechanizm();

            trackBar1.Value = 0;

            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
            trackBar4.Value = 0;

            outTempTb.Text = trackBar1.Value.ToString() + " °C";
            outHumTb.Text = trackBar2.Value.ToString() + " %";
            inTempTb.Text = trackBar3.Value.ToString() + " °C";
            inHumTb.Text = trackBar4.Value.ToString() + " %";
        }



        private void button1_Click(object sender, EventArgs e)
        {


            // Mechanizm mechanizm = new Mechanizm(this);
            //   mechanizm.Wydruk();

            //mechanizm.RegulySystemu();
        }

        // Oprogramuje suwaki.
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            mechanizm = new Mechanizm(/*this*/);

            //  Database database = new Database();  !!!!!!!!!!!!!!!!!
            //  mechanizm.BazaRegul = database;   // tak ustawialbym wlasciwosc BazyRegul - z getera poprzez konstruktor.   !!!!!!!!!!!

            outTempTb.Text = trackBar1.Value.ToString();
            outTempTb.Text += "°C";
            tbTempPoziom.Text = mechanizm.PrzeliczeDoWynikow((float)trackBar3.Value, (float)trackBar1.Value, (float)trackBar4.Value, (float)trackBar2.Value, "HeatSystem");
            tbWiatrakPoziom.Text = mechanizm.PrzeliczeDoWynikow((float)trackBar3.Value, (float)trackBar1.Value, (float)trackBar4.Value, (float)trackBar2.Value, "FanSpeedSystem");
            tbTempPoziom.Text += "°C";
            tbWiatrakPoziom.Text += " obroty/min ";
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            mechanizm = new Mechanizm(/*this*/);

            outHumTb.Text = trackBar2.Value.ToString();
            outHumTb.Text += " %";
            tbTempPoziom.Text = mechanizm.PrzeliczeDoWynikow((float)trackBar3.Value, (float)trackBar1.Value, (float)trackBar4.Value, (float)trackBar2.Value, "HeatSystem");
            tbWiatrakPoziom.Text = mechanizm.PrzeliczeDoWynikow((float)trackBar3.Value, (float)trackBar1.Value, (float)trackBar4.Value, (float)trackBar2.Value, "FanSpeedSystem");
            tbTempPoziom.Text += "°C";
            tbWiatrakPoziom.Text += " obroty/min ";
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            mechanizm = new Mechanizm(/*this*/);

            inTempTb.Text = trackBar3.Value.ToString();
            inTempTb.Text += "°C";
            tbTempPoziom.Text = mechanizm.PrzeliczeDoWynikow((float)trackBar3.Value, (float)trackBar1.Value, (float)trackBar4.Value, (float)trackBar2.Value, "HeatSystem");
            tbWiatrakPoziom.Text = mechanizm.PrzeliczeDoWynikow((float)trackBar3.Value, (float)trackBar1.Value, (float)trackBar4.Value, (float)trackBar2.Value, "FanSpeedSystem");
            tbTempPoziom.Text += "°C";
            tbWiatrakPoziom.Text += " obroty/min ";
        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            mechanizm = new Mechanizm(/*this*/);

            inHumTb.Text = trackBar4.Value.ToString();
            inHumTb.Text += " %";
            tbTempPoziom.Text = mechanizm.PrzeliczeDoWynikow((float)trackBar3.Value, (float)trackBar1.Value, (float)trackBar4.Value, (float)trackBar2.Value, "HeatSystem");
            tbWiatrakPoziom.Text = mechanizm.PrzeliczeDoWynikow((float)trackBar3.Value, (float)trackBar1.Value, (float)trackBar4.Value, (float)trackBar2.Value, "FanSpeedSystem");
            tbTempPoziom.Text += "°C";
            tbWiatrakPoziom.Text += " obroty/min ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WykresWybierz wybierz = new WykresWybierz();
            wybierz.Show();
        }
    }
}

//////////////////////////////////////