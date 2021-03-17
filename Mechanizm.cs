using AForge.Fuzzy;

namespace AI_Fuzzy_P1
{
    public class Mechanizm
    {
        Database bazaRegul;
        WykresWybierz wykres;
        Glowna form1;
        InferenceSystem reguly;


        public Mechanizm(Glowna form1)
        {
            this.form1 = form1;
        }


        public Mechanizm(WykresWybierz wykre)
        {
            this.wykres = wykre;
        }

        public void kl()
        {
            WykresWybierz wyk = new WykresWybierz(this);
        }


        /// <summary>
        /// ///
        /// </summary>   ten konsturktor powinien zostac.
        public Mechanizm()
        {
            //Temperatura.
            // Utworze wiejcia i wyjscia dla temperatury, i zmienne lingwistyczne.
            /// 1. Temp zewnetrzna - wejscia [ InTemp ] vv tylko light jeszcze
            FuzzySet temp_Zewn_Zimno = new FuzzySet("InTempCold", new TrapezoidalFunction(-25, 12, TrapezoidalFunction.EdgeType.Right));
            FuzzySet temp_Zewn_Chlodno = new FuzzySet("InTempOptimal", new TrapezoidalFunction(5, 10, 15, 19));
            FuzzySet temp_Zewn_Goraco = new FuzzySet("InTempHigh", new TrapezoidalFunction(17, 40, TrapezoidalFunction.EdgeType.Left));

            LinguisticVariable tempZewnTlv = new LinguisticVariable("InTemp", -25, 40);
            tempZewnTlv.AddLabel(temp_Zewn_Zimno);
            tempZewnTlv.AddLabel(temp_Zewn_Chlodno);
            tempZewnTlv.AddLabel(temp_Zewn_Goraco);
            ///

            /// 2. Wewnętrzne temperatury - wyjcie  [ OutTemp ]:
            FuzzySet temp_wew_Zimno = new FuzzySet("OutTempCold", new TrapezoidalFunction(-1, 8, TrapezoidalFunction.EdgeType.Right));
            FuzzySet temp_wew_Optymalnie = new FuzzySet("OutTempCool", new TrapezoidalFunction(5, 15, 21, 25));
            FuzzySet temp_wew_Parno = new FuzzySet("OutTempWarm", new TrapezoidalFunction(24, 27, 29, 35, TrapezoidalFunction.EdgeType.Left));
            FuzzySet temp_wew_Goraco = new FuzzySet("OutTempHot", new TrapezoidalFunction(22, 40, TrapezoidalFunction.EdgeType.Left));

            LinguisticVariable temp_wewTlv = new LinguisticVariable("OutTemp", -1, 40);
            temp_wewTlv.AddLabel(temp_wew_Zimno);
            temp_wewTlv.AddLabel(temp_wew_Optymalnie);
            temp_wewTlv.AddLabel(temp_wew_Parno);
            temp_wewTlv.AddLabel(temp_wew_Goraco);
            ///

            //Wilgotnosc.
            //Utworze wejscia i wyjscia dla wilgotnosci, oraz zmiennne lingjuhi ui.

            /// 3. Zewnetrzna wilgotnosc. -wejscie InHumidity .
            FuzzySet WILGOTN_Zewn_sucho = new FuzzySet("InHumLow", new TrapezoidalFunction(1, 40, TrapezoidalFunction.EdgeType.Right));
            FuzzySet WILGOTN_Zewn_wilgotno = new FuzzySet("WILGOTN_Zewn_wilgotno", new TrapezoidalFunction(0, 6, 17, 60));
            FuzzySet WILGOTN_Zewn_mokro_OPTYMALNIE = new FuzzySet("InHumOptimal", new TrapezoidalFunction(50, 70, 80));
            FuzzySet WILGOTN_Zewn_bardzo_mokro = new FuzzySet("InHumHigh", new TrapezoidalFunction(40, 100, TrapezoidalFunction.EdgeType.Left));

            LinguisticVariable Wilgotnosc_ZewnLv = new LinguisticVariable("InHumidity", 0, 100);
            Wilgotnosc_ZewnLv.AddLabel(WILGOTN_Zewn_sucho);
            Wilgotnosc_ZewnLv.AddLabel(WILGOTN_Zewn_wilgotno);
            Wilgotnosc_ZewnLv.AddLabel(WILGOTN_Zewn_mokro_OPTYMALNIE);
            Wilgotnosc_ZewnLv.AddLabel(WILGOTN_Zewn_bardzo_mokro);
            ///

            /// 4. wew_wilgotnosc. - na wyjsciu - OutHumidity.
            FuzzySet WILGOTN_wew_sucho = new FuzzySet("OutHumLow", new TrapezoidalFunction(1, 40, TrapezoidalFunction.EdgeType.Right));
            FuzzySet WILGOTN_wew_wilgotno = new FuzzySet("WILGOTN_wew_wilgotno", new TrapezoidalFunction(0, 6, 17, 60));
            FuzzySet WILGOTN_wew_mokro_OPTYMALNIE = new FuzzySet("OutHumOptimal", new TrapezoidalFunction(50, 70, 80));
            FuzzySet WILGOTN_wew_bardzo_mokro = new FuzzySet("OutHumHigh", new TrapezoidalFunction(40, 100, TrapezoidalFunction.EdgeType.Left));

            LinguisticVariable WILGOTNOSC_wewLv = new LinguisticVariable("OutHumidity", 0, 100);
            WILGOTNOSC_wewLv.AddLabel(WILGOTN_wew_sucho);
            WILGOTNOSC_wewLv.AddLabel(WILGOTN_wew_wilgotno);
            WILGOTNOSC_wewLv.AddLabel(WILGOTN_wew_mokro_OPTYMALNIE);
            WILGOTNOSC_wewLv.AddLabel(WILGOTN_wew_bardzo_mokro);
            ///

            // Ustawie rozmycie i zmienne lingwistyczne - dla systemu sterownika.
            /// 5. Funkcje sterownika.
            FuzzySet Sterownik_wylaczony = new FuzzySet("DoNothing", new TrapezoidalFunction(0, 5, TrapezoidalFunction.EdgeType.Right));
            FuzzySet Sterownik_Grzanie = new FuzzySet("Heating", new TrapezoidalFunction(3, 40, TrapezoidalFunction.EdgeType.Right));
            FuzzySet Sterownik_Chlodzenie = new FuzzySet("Cooling", new TrapezoidalFunction(-2, 19, TrapezoidalFunction.EdgeType.Left));

            LinguisticVariable SterownikDzialanieLv = new LinguisticVariable("HeatSystem", -2, 40);
            SterownikDzialanieLv.AddLabel(Sterownik_wylaczony);
            SterownikDzialanieLv.AddLabel(Sterownik_Grzanie);
            SterownikDzialanieLv.AddLabel(Sterownik_Chlodzenie);
            ///

            // Ustawie rozmycie i zmienne lingwistyczne - dla Sterownika.
            /// 6. Wiatrak-predkosci nawiewu.
            FuzzySet Wiatrak_niskaPr = new FuzzySet("LowFanSpeed", new TrapezoidalFunction(3, 30, TrapezoidalFunction.EdgeType.Right));
            FuzzySet Wiatrak_średniaPr = new FuzzySet("Wiatrak_średniaPr", new TrapezoidalFunction(25, 50, 60));
            FuzzySet Wiatrak_NajwyższaPr = new FuzzySet("HighFanSpeed", new TrapezoidalFunction(45, 60, 80, 100, TrapezoidalFunction.EdgeType.Right));

            LinguisticVariable WiatrakLv = new LinguisticVariable("FanSpeedSystem", 3, 100);
            WiatrakLv.AddLabel(Wiatrak_niskaPr);
            WiatrakLv.AddLabel(Wiatrak_średniaPr);
            WiatrakLv.AddLabel(Wiatrak_NajwyższaPr);
            ////

            //Utworze Baze regul - uzyskam znaczenie jezykowe dla wejsc numerycznych.
            bazaRegul = new Database();

            bazaRegul.AddVariable(tempZewnTlv);
            bazaRegul.AddVariable(temp_wewTlv);

            bazaRegul.AddVariable(Wilgotnosc_ZewnLv);
            bazaRegul.AddVariable(WILGOTNOSC_wewLv);

            bazaRegul.AddVariable(SterownikDzialanieLv);
            bazaRegul.AddVariable(WiatrakLv);


            //  DEFUZYFIKACJA. - Wyostrzenie.Otrzymam na wyjściu wyniki liczbowe.

            reguly = new InferenceSystem(bazaRegul, new CentroidDefuzzifier(1000));

            RegulySystemu(reguly);
        }


        public void RegulySystemu(InferenceSystem regulyM)
        {
            // - temp na wejsciu - zewnetrzna.
            ///InTempCold 
            regulyM.NewRule("Role 1", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 2", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 3", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 4", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 5", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 6", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 7", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 8", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 9", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 10", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 11", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 12", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN HeatSystem IS Heating");

            regulyM.NewRule("Role 13", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 14", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 15", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 16", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 17", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 18", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 19", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 20", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 21", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 22", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 23", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 24", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Heating");

            regulyM.NewRule("Role 25", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 26", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 27", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 28", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 29", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 30", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 31", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 32", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 33", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 34", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 35", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN HeatSystem IS Heating");
            regulyM.NewRule("Role 36", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN HeatSystem IS Heating");

            // InTempOptimal
            regulyM.NewRule("Role 37", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 38", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 39", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 40", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 41", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 42", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 43", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 44", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 45", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 46", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 47", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 48", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN HeatSystem IS DoNothing");

            regulyM.NewRule("Role 49", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 50", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 51", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 52", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 53", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 54", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 55", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 56", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 57", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 58", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 59", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 60", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN HeatSystem IS DoNothing");

            regulyM.NewRule("Role 61", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 62", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 63", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 64", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 65", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 66", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 67", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 68", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 69", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 70", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 71", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN HeatSystem IS DoNothing");
            regulyM.NewRule("Role 72", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN HeatSystem IS DoNothing");

            // InTempHot
            regulyM.NewRule("Role 73", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 74", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 75", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 76", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 77", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 78", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 79", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 80", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 81", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 82", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 83", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 84", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN HeatSystem IS Cooling");

            regulyM.NewRule("Role 85", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 86", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 87", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 88", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 89", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 90", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 91", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 92", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 93", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 94", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 95", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 96", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN HeatSystem IS Cooling");

            regulyM.NewRule("Role 97", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 98", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 99", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 100", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 101", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 102", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 103", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 104", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 105", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 106", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 107", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN HeatSystem IS Cooling");
            regulyM.NewRule("Role 108", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN HeatSystem IS Cooling");
            //////
            /////
            // InTempCold FanSpeed
            regulyM.NewRule("Role 109", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 110", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 111", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 112", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS HighFanSpeed");

            regulyM.NewRule("Role 113", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 114", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 115", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 116", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");

            regulyM.NewRule("Role 117", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 118", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 119", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 120", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");

            regulyM.NewRule("Role 121", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 122", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 123", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 124", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS HighFanSpeed");

            regulyM.NewRule("Role 125", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 126", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 127", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 128", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");

            regulyM.NewRule("Role 129", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 130", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 131", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 132", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");

            regulyM.NewRule("Role 133", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 134", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 135", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 136", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS HighFanSpeed");

            regulyM.NewRule("Role 137", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 138", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 139", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 140", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");

            regulyM.NewRule("Role 141", "IF InTemp IS InTempCold AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 142", "IF InTemp IS InTempCold AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 143", "IF InTemp IS InTempCold AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 144", "IF InTemp IS InTempCold AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");

            //InTempOptimal
            regulyM.NewRule("Role 145", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 146", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 147", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 148", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS HighFanSpeed");

            regulyM.NewRule("Role 149", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 150", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 151", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 152", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");

            regulyM.NewRule("Role 153", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 154", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 155", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 156", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");

            regulyM.NewRule("Role 157", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 158", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 159", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 160", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS HighFanSpeed");

            regulyM.NewRule("Role 161", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 162", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 163", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 164", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");

            regulyM.NewRule("Role 165", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 167", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 168", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 169", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");

            regulyM.NewRule("Role 170", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 171", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 172", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 173", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS HighFanSpeed");

            regulyM.NewRule("Role 174", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 175", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 176", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 177", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");

            regulyM.NewRule("Role 178", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 179", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 180", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 181", "IF InTemp IS InTempOptimal AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");

            // InTempHigh
            regulyM.NewRule("Role 182", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 183", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 184", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 185", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS HighFanSpeed");

            regulyM.NewRule("Role 186", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 187", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 188", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 189", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS HighFanSpeed");

            regulyM.NewRule("Role 190", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 191", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 192", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 193", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumLow THEN FanSpeedSystem IS HighFanSpeed");

            regulyM.NewRule("Role 194", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 195", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 196", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 197", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS HighFanSpeed");

            regulyM.NewRule("Role 198", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 199", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 200", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 201", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS HighFanSpeed");

            regulyM.NewRule("Role 202", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 203", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 204", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 205", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumOptimal THEN FanSpeedSystem IS HighFanSpeed");

            regulyM.NewRule("Role 206", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 207", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 208", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 209", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumLow AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS HighFanSpeed");

            regulyM.NewRule("Role 210", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 211", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 212", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS HighFanSpeed");
            regulyM.NewRule("Role 213", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumOptimal AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS HighFanSpeed");

            regulyM.NewRule("Role 214", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCold AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 215", "IF InTemp IS InTempHigh AND OutTemp IS OutTempCool AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 216", "IF InTemp IS InTempHigh AND OutTemp IS OutTempWarm AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS LowFanSpeed");
            regulyM.NewRule("Role 217", "IF InTemp IS InTempHigh AND OutTemp IS OutTempHot AND InHumidity IS InHumHigh AND OutHumidity IS OutHumHigh THEN FanSpeedSystem IS HighFanSpeed");

        }


        public string PrzeliczeDoWynikow(float inTemp1, float outTemp2, float inHum3, float outHum4, string OUT)
        {
            float inTemp = inTemp1;
            float outTemp = outTemp2;
            float inHum = inHum3;
            float outHum = outHum4;

            reguly.SetInput("InTemp", inTemp);
            reguly.SetInput("OutTemp", outTemp);
            reguly.SetInput("InHumidity", inHum);
            reguly.SetInput("OutHumidity", outHum);


            if (OUT == "HeatSystem")
            {
                return reguly.Evaluate("HeatSystem").ToString("0.00");
            }
            else
            {
                return reguly.Evaluate("FanSpeedSystem").ToString("0.0");
            }
        }

    }
}

// }



////////////////////////// 

/*public int Wydruk()
{
    int wydruk = 10;
    form1.textBox1.Text = wydruk.ToString();
    return wydruk;
    //Mechanizm mechanizm = new Mechanizm();
    Form1 form = new Form1(this);
}
*/

//            Form1 forma = new Form1(this);

//  public FuzzySet Temp_Zewn_Zimno { get => temp_Zewn_Zimno; set => temp_Zewn_Zimno = value; }

/// Tu konczy sie teraz konstruktor.
