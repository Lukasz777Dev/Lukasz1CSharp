using System;
using System.Drawing;
using System.Windows.Forms;


namespace AI_Fuzzy_P1
{
    public partial class Wykres_temperatury : Form
    {
        WykresWybierz wykresWybierz;

        public Wykres_temperatury()
        {
            InitializeComponent();
        }

        public Wykres_temperatury(WykresWybierz wykresWybierz)
        {
            this.wykresWybierz = wykresWybierz;
        }

        public void met()
        {
            //       PiecewiseLinearFunction pwlf = new PiecewiseLinearFunction();
        }

        public void Wykres_temperatury_Load(object sender, EventArgs e)
        {
            // RysujeWykresTemperatury();
        }


        public void RysujeWykresTemperatury()
        {
            Color kolor = Color.FromKnownColor(KnownColor.Control);
            Pen pen = new Pen(Color.Black, 2);
            Pen pen2 = new Pen(Color.Red, 5);

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

            grafika.DrawLine(pen2, 60, 295, 60, 305); // oznaczenie poziomu -25 na osi x
            grafika.DrawLine(pen2, 140, 295, 140, 305); // -1
            grafika.DrawLine(pen2, 220, 295, 220, 305); // 5
            grafika.DrawLine(pen2, 300, 295, 300, 305); // 18
            grafika.DrawLine(pen2, 380, 295, 380, 305); // 20
            grafika.DrawLine(pen2, 460, 295, 460, 305); // 25 
            grafika.DrawLine(pen2, 540, 295, 540, 305); // 40
            grafika.DrawLine(pen2, 620, 295, 620, 305); // 100

            grafika.DrawString("-25", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(49, 310)); // oznaczenie 1 na osi X
            grafika.DrawString("-1", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(134, 310)); // oznaczenie 2 na osi X
            grafika.DrawString("5", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(214, 310)); // oznaczenie 3 na osi X
            grafika.DrawString("18", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(294, 310)); // oznaczenie 4 na osi X
            grafika.DrawString("20", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(374, 310)); // oznaczenie 5 na osi X
            grafika.DrawString("25", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(454, 310)); // oznaczenie 6 na osi X
            grafika.DrawString("40", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(535, 310)); // oznaczenie 7 na osi X
            grafika.DrawString("100", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), new Point(614, 310)); // oznaczenie 8 na osi X


            //   grafika.DrawString("40", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Red), new Point(550, 310)); // oznaczenie 1 na osi X


            grafika.DrawString("u [temp]", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), new Point(6, 10)); // oznaczenie legendy osi y
            grafika.DrawString("temp [°C]", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), new Point(702, 310)); // oznaczenie legendy osi x
            Pen pen_zimno = new Pen(Color.Blue, 2);
            Pen pen_cieplo = new Pen(Color.DarkOrange, 2);
            Pen pen_goraco = new Pen(Color.Red, 2);

            grafika.DrawLines(pen_zimno, new Point[] { new Point(60, 100), new Point(205, 100), new Point(360, 300) }); //przynależność do "zimno"
            grafika.DrawLines(pen_cieplo, new Point[] { new Point(250, 300), new Point(320, 100), new Point(385, 100), new Point(520, 300) }); //przynależność do "cieplo"
            grafika.DrawLines(pen_goraco, new Point[] { new Point(430, 300), new Point(540, 100), new Point(680, 100) }); //przynależność do "gorąco"

            grafika.DrawString("zimno", new Font("Arial", 13, FontStyle.Bold), new SolidBrush(Color.Blue), new Point(120, 70)); // etykieta Zimno
            grafika.DrawString("ciepło", new Font("Arial", 13, FontStyle.Bold), new SolidBrush(Color.DarkOrange), new Point(325, 70)); // etykieta Ciepło
            grafika.DrawString("gorąco", new Font("Arial", 13, FontStyle.Bold), new SolidBrush(Color.Red), new Point(570, 70)); // etykieta Gorąco

            //  CreateGraphics create = new CreateGraphics();

            //    GraphQL.Builders.ConnectionBuilder.Create < new TrapezoidalFunction(-25, 12, TrapezoidalFunction.EdgeType.Right, 5.60f,6.54f,7.80f) >;


            //  mechanizm.
            //     Wykres_temperatury wt = new Wykres_temperatury();
            //  wt=    TrapezoidalFunction.ReferenceEquals(Temp_wew_Goraco,Temp_wew_Optymalnie);


            //    Inference<ModelToInfere> inferObjpi;

        }

    }

}
