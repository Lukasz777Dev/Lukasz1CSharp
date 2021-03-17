using System;
using System.Drawing;
using System.Windows.Forms;

namespace AI_Fuzzy_P1
{
    public partial class Wykres_wilgotnosci : Form
    {
        WykresWybierz wykresWybierz;


        public Wykres_wilgotnosci()
        {
            InitializeComponent();
        }



        public Wykres_wilgotnosci(WykresWybierz wykresWybierz)
        {
            this.wykresWybierz = wykresWybierz;
        }


        public void RysujeWykresWILGOTNOSCI()    //  Dopasowac do wilgotnosci.  jeszcze -> przedzialy !!!!!!!!!!
        {
            Color kolor = Color.FromKnownColor(KnownColor.Control);
            Pen pen = new Pen(Color.Black, 3);
            Pen pen2 = new Pen(Color.DarkSlateBlue, 3);

            Graphics grafika = this.CreateGraphics();
            grafika.Clear(kolor);
            grafika.DrawLine(pen, 60, 30, 60, 300); // oś Y
            grafika.DrawLine(pen, 60, 300, 700, 300); // oś X
            grafika.DrawLines(pen, new Point[] { new Point(55, 40), new Point(60, 30), new Point(65, 40) }); // grot na osi y
            grafika.DrawLines(pen, new Point[] { new Point(690, 295), new Point(703, 300), new Point(690, 305) }); //grot na osi x
            grafika.DrawLine(pen, 55, 100, 65, 100); // oznaczenie poziomu 1 na osi y
            grafika.DrawLine(pen, 55, 200, 65, 200); // oznaczenie poziomu 0.5 na osi y

            grafika.DrawString("1", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), new Point(45, 90)); // oznaczenie 1 na osi y
            grafika.DrawString("0,5", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), new Point(30, 190)); // oznaczenie 1 na osi y

            grafika.DrawLine(pen2, 60, 295, 60, 305); // oznaczenie poziomu sucho na osi x
            grafika.DrawLine(pen2, 140, 295, 140, 305); // 
            grafika.DrawLine(pen2, 220, 295, 220, 305); // 
            grafika.DrawLine(pen2, 300, 295, 300, 305); // 
            grafika.DrawLine(pen2, 380, 295, 380, 305); // 
            grafika.DrawLine(pen2, 460, 295, 460, 305); //  
            grafika.DrawLine(pen2, 540, 295, 540, 305); // 
            grafika.DrawLine(pen2, 620, 295, 620, 305); // 

            grafika.DrawString("0", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(49, 310)); // oznaczenie 1 na osi X
            grafika.DrawString("1", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(134, 310)); // oznaczenie 2 na osi X
            grafika.DrawString("6", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(214, 310)); // oznaczenie 3 na osi X
            grafika.DrawString("17", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(294, 310)); // oznaczenie 4 na osi X
            grafika.DrawString("40", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(374, 310)); // oznaczenie 5 na osi X
            grafika.DrawString("60", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(454, 310)); // oznaczenie 6 na osi X
            grafika.DrawString("80", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(535, 310)); // oznaczenie 7 na osi X
            grafika.DrawString("100", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(614, 310)); // oznaczenie 8 na osi X


            grafika.DrawString("u [wilg.]", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.DarkBlue), new Point(7, 10)); // oznaczenie legendy osi y
            grafika.DrawString("[% wilgotności]", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.DarkBlue), new Point(702, 310)); // oznaczenie legendy osi x
            Pen pen_sucho = new Pen(Color.Brown, 2);
            Pen pen_wilgocOptymalna = new Pen(Color.DarkGreen, 2);
            Pen pen_bardzoMokro = new Pen(Color.DarkBlue, 2);

            grafika.DrawLines(pen_sucho, new Point[] { new Point(60, 100), new Point(205, 100), new Point(360, 300) }); //przynależność do "sucho"
            grafika.DrawLines(pen_wilgocOptymalna, new Point[] { new Point(250, 300), new Point(320, 100), new Point(385, 100), new Point(520, 300) }); //przynależność do "wilgotno optymalnie"
            grafika.DrawLines(pen_bardzoMokro, new Point[] { new Point(430, 300), new Point(540, 100), new Point(680, 100) }); //przynależność do "bardzo wilgotno"

            grafika.DrawString("sucho", new Font("Arial", 13, FontStyle.Bold), new SolidBrush(Color.Brown), new Point(120, 70)); /* etykieta sucho */          grafika.DrawString("optymalnie", new Font("Arial", 13, FontStyle.Bold), new SolidBrush(Color.DarkGreen), new Point(325, 70)); // etykieta optymalnie
            grafika.DrawString("duża wilgoć", new Font("Arial", 13, FontStyle.Bold), new SolidBrush(Color.DarkBlue), new Point(570, 70)); // etykieta duża wilgoć.
        }

        private void Wykres_wilgotnosci_Load(object sender, EventArgs e)
        {

        }
    }
}
