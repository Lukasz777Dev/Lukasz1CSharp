using System;
using System.Collections.Generic;

namespace SymulatorHamowania
{
    class Droga
    {

        double droga_reakcji;
        Form1 form1;

        public List<decimal> listaObliczDrogeWczasieReakcji = new List<decimal>();

        public Droga(Form1 form1)
        {
            this.form1 = form1;
        }

        //teoria:  (Prędkość w km / h: 10) * (prędkość w km / h: 10) = droga hamowania w metrach
        public double DrogeHamowaniaLAB(double predkosc)
        {
            double wynik = (predkosc / 10) * (predkosc / 10);

            return wynik;
        }

        //(Prędkość hamowania = V*V/2*a - tarcie
        public double DrogeHamowaniaTarcie(double predkoscPoj, double tarcie)
        {
            double opoznienie = tarcie * 9.81;
            double zm = 10d / 36; //predkosc zamienię na  ->  m/s .
            double predkosc_ms = predkoscPoj * zm;

            form1.droga_hamowania = Math.Round((Math.Pow(predkosc_ms, 2) / (2 * opoznienie)), 2);

            double droga_hamowania1 = form1.droga_hamowania;

            return droga_hamowania1;
        }

        // //(Prędkość w km / h: 10) * 3 = odległość reakcji w metrach PODCZAS PODEJM. DECYZJI = OPÓŹNIENIE. (  decimal reakcjaMetry = Predkosc / 10 * 3;) - raczej nieodpowiedni wzor, bo tylko wg stalego czasu
        // + 

        //Dr = v * tr
        public double DrogeWReakcji(decimal WyborSekund, decimal Predkosc)
        {
            //konwersja z km/h na m/s

            double zm2_ms = Convert.ToDouble(Predkosc) * 10d / 36d;
            droga_reakcji = Math.Round(Convert.ToDouble(zm2_ms * (Convert.ToDouble(WyborSekund))), 2);

            //  listaObliczDrogeWczasieReakcji.Add(droga);

            return droga_reakcji;
        }

        //(Dz)czyli(droga zatrzymania)czyli(rzeczyw droga hamowania) = Dr + Dh,
        //gdzie: Dr=droga reakcji w m; Dh=droga hamowania w m   .
        public double RzeczywDrogeHamow()
        {
            double wynik = form1.droga_hamowania + droga_reakcji;
            // return wynik;


            return wynik; // jak zwrocic stringa w tej metodzie, z wynk z foreacha?
        }

        // droga (s)= predkosc do kwadratu (v) / -2[przyspieszenie(+)lub(opoznienie=reakcja(-)], czyli (a)
        public double RzeczywDrogeHamow2(double hamulceWybor, double predkosc2, double rzeczywDrogaHamow)
        {
            // double wynik = form1.droga_hamowania + droga_reakcji + hamulceWybor;   // ??????????
            // return wynik;
            double wynik2 = ((predkosc2 / 10) * (predkosc2 / 10)) / hamulceWybor;

            double wynik3 = wynik2 + rzeczywDrogaHamow;

            return wynik3;
        }




    }
}
