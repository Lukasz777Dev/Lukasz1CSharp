using System;
using System.Windows.Forms;


namespace SymulatorHamowania
{
    internal partial class Form1 : Form
    {
        Droga droga;
        internal double droga_hamowania;
        double tarcie;
        // double hamulec1;
        // double hamulec2;
        // double hamulec3;

        public Form1()
        {
            InitializeComponent();

        }



        private void btnWyliczDlugoscHamowania_Click(object sender, EventArgs e)
        {
            tbReakcjaMetryWDECYZJI.Text = string.Empty;

            droga = new Droga(this);
            tbDlugoscHamowania.Text = droga.DrogeHamowaniaLAB((Convert.ToDouble(numPredkosc.Value))).ToString();

            //  droga_hamowania = Math.Round(droga.DrogeHamowania((Convert.ToDouble(numPredkosc.Value)),// tarcie),3);

            //  chart1.Series["Prędkość"].Points.AddXY(numPredkosc.Value, tbDlugoscHamowania.Text);

        }


        private void comCzasyReakcji_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbReakcjaMetryWDECYZJI.Clear();

            droga = new Droga(this);

            int wyborSekund = comCzasyReakcji.SelectedIndex; //w switchu nie powinno byc decimal - ale sprobuje.

            if (numPredkosc.Value != 0)
            {
                switch (wyborSekund) //wyrazenie kontrolujace.       //(Prędkość w km / h: 10) * 3 = odległość reakcji w metrach
                {
                    case 0: //jedno z wyrazen stalych.
                        {
                            int czas1 = 1;
                            tbReakcjaMetryWDECYZJI.Text = string.Empty;

                            tbReakcjaMetryWDECYZJI.Text = droga.DrogeWReakcji(czas1, numPredkosc.Value).ToString();
                        }
                        break;
                    case 1:
                        {
                            int czas2 = 2;
                            tbReakcjaMetryWDECYZJI.Text = string.Empty;

                            tbReakcjaMetryWDECYZJI.Text = droga.DrogeWReakcji(czas2, numPredkosc.Value).ToString();
                        }
                        break;
                    case 2:
                        {
                            int czas3 = 3;
                            tbReakcjaMetryWDECYZJI.Text = string.Empty;

                            tbReakcjaMetryWDECYZJI.Text = droga.DrogeWReakcji(czas3, numPredkosc.Value).ToString();
                        }
                        break;
                    case 3:
                        {
                            int czas4 = 4;
                            tbReakcjaMetryWDECYZJI.Text = string.Empty;

                            tbReakcjaMetryWDECYZJI.Text = droga.DrogeWReakcji(czas4, numPredkosc.Value).ToString();
                        }
                        break;
                    case 4:
                        {
                            int czas5 = 5;
                            tbReakcjaMetryWDECYZJI.Text = string.Empty;

                            tbReakcjaMetryWDECYZJI.Text = droga.DrogeWReakcji(czas5, numPredkosc.Value).ToString();
                        }
                        break;

                    default:
                        tbReakcjaMetryWDECYZJI.Text = "domyslnie";
                        break;
                }
                tbRzeczDrogaHamowOSTATNIE.Text = droga.RzeczywDrogeHamow().ToString();
            }
            else if (numPredkosc.Value == 0)
            {
                MessageBox.Show("Wpisz prędkość wyjściową.");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comNawierzchnia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbDlugoscHamowania.Text!= "0,01" || tbDlugoscHamowania.Text != "0,00")
            {
                if (comNawierzchnia.SelectedIndex == 0) //sucha          
                {
                    tarcie = 1.0;
                }
                if (comNawierzchnia.SelectedIndex == 1) //mokra
                {
                    tarcie = 0.8;
                }
                if (comNawierzchnia.SelectedIndex == 2) //ośnieżona
                {
                    tarcie = 0.6;
                }
                if (comNawierzchnia.SelectedIndex == 3) // oblodzona
                {
                    tarcie = 0.4;
                }
                if (comNawierzchnia.SelectedIndex == 4) //glazura
                {
                    tarcie = 0.1;
                }
                
            }
            else
            {
                MessageBox.Show("Najpierw wpisz prędkość pojazdu.");
            }
            tbTarcie.Text = droga.DrogeHamowaniaTarcie(Convert.ToDouble(numPredkosc.Value), tarcie).ToString();

        }

        public void Form1_Load(object sender, EventArgs e)
        {



        }

        public void pnlRysowanie_Paint(object sender, PaintEventArgs e)
        {



            //Graphics graphics = new DrawItemEventArgs();
            //Rectangle clipRect;


            //PaintEventArgs e = new PaintEventArgs(Graphics graphics, Rectangle clipRect);


            //void ShowLineJoin(PaintEventArgs e)
            //{
            //    // Create a new pen.
            //    Pen penRED = new Pen(Brushes.Red);

            //    // Set the pen's width.
            //    penRED.Width = 8.0F;

            //    // Set the LineJoin property.
            //    penRED.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;

            //    // Draw a rectangle.
            //    e.Graphics.DrawRectangle(penRED,
            //        new Rectangle(40, 40, 150, 200));

            //    //Dispose of the pen.
            //    penRED.Dispose();
            //}
        }

        void Form1_Paint(object sender2, PaintEventArgs en)
        {
            //Graphics graphics = en.Graphics;
            //Pen myPen = new Pen(Color.Red);
            //Brush myBrush = new SolidBrush(Color.Green);

            //graphics.DrawLine(myPen, 2, 2, 4, 450);
            //graphics.DrawLine(myPen, 1000, 1003, 200, 300);

            //graphics.DrawRectangle(myPen, 300, 300, 200, 300);
            //graphics.FillRectangle(myBrush, 300, 300, 200, 300);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comHamulce_SelectedIndexChanged(object sender, EventArgs e)
        {
            //       droga = new Droga(this);
            

            int HamulecJakosc = comHamulce.SelectedIndex;


            switch (HamulecJakosc)
            {
                case 0: // hamulce sprawne !!!
                    {
                      //  tbHamulceStan.Text = string.Empty;

                        //int hamulec1 = 1; // błąd !
                        double hamulec1 = 1.00D;

                        double zamiennikStringa1 = Convert.ToDouble(tbRzeczDrogaHamowOSTATNIE.Text);
                       // tbHamulceStan.Text = zamiennikStringa1.ToString();
                        double przejsciowka1 = droga.RzeczywDrogeHamow2(hamulec1, Convert.ToDouble(numPredkosc.Value), zamiennikStringa1);

                        //    tbRzeczDrogaHamowOSTATNIE.Text = string.Empty;
                        //   tbRzeczDrogaHamowOSTATNIE.Text = string.Empty;
                     //   tbFINISH.Text = string.Empty;   /// 1 czyszczenie.
                        tbFINISH.Text = przejsciowka1.ToString();

                        chart1.Series["Prędkość"].Points.AddXY(numPredkosc.Value, tbFINISH.Text);
                        chart1.Series["Droga hamowania"].Points.AddXY(numPredkosc.Value, tbFINISH.Text);

                     

                                               break;
                    }

                case 1: //hamulce na granicy sprawności.
                    {
                       // tbHamulceStan.Text = string.Empty;

                        double hamulec2 = 0.40D;

                        double zamiennikStringa2 = Convert.ToDouble(tbRzeczDrogaHamowOSTATNIE.Text);
                        tbHamulceStan.Text = zamiennikStringa2.ToString();

                        double przejsciowka2 = droga.RzeczywDrogeHamow2(hamulec2, Convert.ToDouble(numPredkosc.Value), zamiennikStringa2);

                        //    tbRzeczDrogaHamowOSTATNIE.Text = string.Empty;
                        // tbRzeczDrogaHamowOSTATNIE.Text = string.Empty;
                     //   tbFINISH.Text = string.Empty;   /// 1 czyszczenie.
                        tbFINISH.Text = przejsciowka2.ToString();

                        chart1.Series["Prędkość"].Points.AddXY(numPredkosc.Value, tbFINISH.Text);
                        chart1.Series["Droga hamowania"].Points.AddXY(numPredkosc.Value, tbFINISH.Text);

                        break;
                    }

                case 2: //hamulce niesprawne.
                    {
                      //  tbHamulceStan.Text = string.Empty;


                        double hamulec3 = 0.10D;

                        double zamiennikStringa3 = Convert.ToDouble(tbRzeczDrogaHamowOSTATNIE.Text);
                        tbHamulceStan.Text = zamiennikStringa3.ToString();

                        double przejsciowka3 = droga.RzeczywDrogeHamow2(hamulec3, Convert.ToDouble(numPredkosc.Value), zamiennikStringa3);

                        //    tbRzeczDrogaHamowOSTATNIE.Text = string.Empty;
                        //  tbRzeczDrogaHamowOSTATNIE.Text = string.Empty;
                     //   tbFINISH.Text = string.Empty;   /// 1 czyszczenie.
                        tbFINISH.Text = przejsciowka3.ToString();

                        chart1.Series["Prędkość"].Points.AddXY(numPredkosc.Value, tbFINISH.Text);
                        chart1.Series["Droga hamowania"].Points.AddXY(numPredkosc.Value, tbFINISH.Text);

                        break;
                    }

                default:
                    MessageBox.Show("domyslnie");
                    break;


            }
        }

        private void tbRzeczDrogaHamowOSTATNIE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



