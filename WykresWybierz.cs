using AForge.Fuzzy;
using System;
using System.Windows.Forms;
//using Point = System.Drawing.Point;

namespace AI_Fuzzy_P1
{
    public partial class WykresWybierz : Form
    {
        Mechanizm mechanizm;


        public WykresWybierz(Wykres_temperatury wykTemp)
        {
            Wykres_temperatury wybierz = new Wykres_temperatury(this);
        }

        public WykresWybierz()
        {
            InitializeComponent();
        }


        public WykresWybierz(Mechanizm mechanizm)
        {
            this.mechanizm = mechanizm;
            //  mechanizm = new Mechanizm(this);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Wykres_temperatury wykresTemper = new Wykres_temperatury();
                wykresTemper.Show();
                wykresTemper.RysujeWykresTemperatury();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Wykres_wilgotnosci wykresWILG = new Wykres_wilgotnosci();
                wykresWILG.Show();
                wykresWILG.RysujeWykresWILGOTNOSCI();
            }
        }


        public void wyrysujeZTrapezu()  // Uzyje do metody wbudowanej.
        {
            FuzzySet temp_Zewn_Zimno = new FuzzySet("InTempCold", new TrapezoidalFunction(-25, 12, TrapezoidalFunction.EdgeType.Right));
            FuzzySet temp_Zewn_Chlodno = new FuzzySet("InTempOptimal", new TrapezoidalFunction(5, 10, 15, 19));
            FuzzySet temp_Zewn_Goraco = new FuzzySet("InTempHigh", new TrapezoidalFunction(17, 40, TrapezoidalFunction.EdgeType.Left));

            LinguisticVariable tempZewnTlv = new LinguisticVariable("InTemp", -25, 40);
            tempZewnTlv.AddLabel(temp_Zewn_Zimno);
            tempZewnTlv.AddLabel(temp_Zewn_Chlodno);
            tempZewnTlv.AddLabel(temp_Zewn_Goraco);


            /// 2. Wewnętrzne temperatury - wyjcie  [ OutTemp ]:
            FuzzySet temp_wew_Zimno = new FuzzySet("OutTempCold", new TrapezoidalFunction(-1, 8, TrapezoidalFunction.EdgeType.Right));
            FuzzySet temp_wew_Optymalnie = new FuzzySet("OutTempCool", new TrapezoidalFunction(5, 15, 21, 25));
            FuzzySet temp_wew_Parno = new FuzzySet("OutTempWarm", new TrapezoidalFunction(24, 27, 29, 35, TrapezoidalFunction.EdgeType.Left));
            FuzzySet temp_wew_Goraco = new FuzzySet("OutTempHot", new TrapezoidalFunction(22, 40, TrapezoidalFunction.EdgeType.Left));


            //Wilgotnosc.
            //Utworze wejscia i wyjscia dla wilgotnosci, oraz zmiennne lingjuhi ui.

            /// 3. Zewnetrzna wilgotnosc. -wejscie InHumidity .
            FuzzySet WILGOTN_Zewn_sucho = new FuzzySet("InHumLow", new TrapezoidalFunction(1, 40, TrapezoidalFunction.EdgeType.Right));
            FuzzySet WILGOTN_Zewn_wilgotno = new FuzzySet("WILGOTN_Zewn_wilgotno", new TrapezoidalFunction(0, 6, 17, 60));
            FuzzySet WILGOTN_Zewn_mokro_OPTYMALNIE = new FuzzySet("InHumOptimal", new TrapezoidalFunction(50, 70, 80));
            FuzzySet WILGOTN_Zewn_bardzo_mokro = new FuzzySet("InHumHigh", new TrapezoidalFunction(40, 100, TrapezoidalFunction.EdgeType.Left));


            /// 4. wew_wilgotnosc. - na wyjsciu - OutHumidity.
            FuzzySet WILGOTN_wew_sucho = new FuzzySet("OutHumLow", new TrapezoidalFunction(1, 40, TrapezoidalFunction.EdgeType.Right));
            FuzzySet WILGOTN_wew_wilgotno = new FuzzySet("WILGOTN_wew_wilgotno", new TrapezoidalFunction(0, 6, 17, 60));
            FuzzySet WILGOTN_wew_mokro_OPTYMALNIE = new FuzzySet("OutHumOptimal", new TrapezoidalFunction(50, 70, 80));
            FuzzySet WILGOTN_wew_bardzo_mokro = new FuzzySet("OutHumHigh", new TrapezoidalFunction(40, 100, TrapezoidalFunction.EdgeType.Left));
        }


    }
}




