using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ubezpieczenia.Klasy;

namespace Ubezpieczenia
{
    public partial class Form_Dodaj_Auto : Form
    {
        List<string> lista_niedozwolonych_znakow = new List<string>() { ".", "?", "/", ";", ":", "'", " ", "[", "]", "{", "}", "'\'", "|", "+", "=", "*", "/", ",", "!", "@", "#", "$", "%", "^", "&", "(", ")", "`", "~", "~~", "", "0", "1", "2", "3", "4", "5", "6", "7", "8" };


        Form_Auta form_Auta;
        public Form_Dodaj_Auto(Form_Auta form_Auta)
        {
            InitializeComponent();
            this.form_Auta = form_Auta;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MARKA
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Wpisz markę.", "Brak marki pojazdu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            //MODEL
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Wpisz model.", "Brak modelu pojazdu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //NR REJESTRACYJNY
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Wpisz numer rejestracyjny.", "Brak numeru rejestracyjnego", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //POJEMNOŚĆ
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Wpisz pojemność pojazdu.", "Brak pojemności pojazdu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //ROCZNIK SAMOCHODU
            if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("Wpisz rocznik pojazdu", "Brak rocznika pojazdu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Rocznik pojazdu
            int liczbaJakas;
            bool czyLiczba;
            czyLiczba = int.TryParse(textBox5.Text, out liczbaJakas);
            if (!czyLiczba)
            {
                MessageBox.Show("Użyłeś nieodpowiedniego formatu danych.\n Podaj rocznik, posługując się liczbą.",
                    "Nieodpowiedni format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Text = string.Empty;

                return;
            }
            int liczbaJakas2;
            bool czyLiczba2 = int.TryParse(textBox5.Text, out liczbaJakas2);

            if (liczbaJakas2 < 1990)    // lub -   if (Convert.ToInt32( czyLiczba) < 1990)
            {
                MessageBox.Show("Pojazd nie podlega ubezpieczeniu ze wzgledu na rocznik", "Brak możliwości ubezpieczenia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Text = string.Empty;
                return;
            }

            if (liczbaJakas2 > 2020)
            {
                MessageBox.Show("Rocznik pojazdu musi być równy lub mniejszy od 2020 r.",
                    "Błędny rocznik pojazdu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Text = string.Empty;
                return;
            }


            foreach (Pojazd jakisSamoch in form_Auta.form1.listaPojazdow)
            {
                if (jakisSamoch.Marka == textBox1.Text && jakisSamoch.Model == textBox2.Text &&
                    jakisSamoch.NrRejestracyjny == textBox3.Text && jakisSamoch.Pojemność == Convert.ToDouble(textBox4.Text) &&
                    jakisSamoch.Rocznik == Convert.ToInt32(textBox5.Text))
                {
                    MessageBox.Show("Ten pojazd został wcześniej dodany. Wpisz inny.", "Zduplikowany pojazd",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            long id = DateTime.Now.Ticks;

            Pojazd pojazd = new Pojazd(id, textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDouble(textBox4.Text), Convert.ToInt32(textBox5.Text));

            form_Auta.form1.listaPojazdow.Add(pojazd);

            DialogResult = DialogResult.OK;

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Marka - Nie pozwole uzywac zakazanych znakow, w tym cyfr.
            foreach (string znakNiedozwolony in lista_niedozwolonych_znakow)
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (znakNiedozwolony == textBox1.Text[i].ToString())
                    {
                        MessageBox.Show("W marce pojazdu nie mozna używac znaków, takich jak: .  ,  ?  /  ;  :  '    [  ]  { }   |  +  ,= , *  /  .  !  @  #  $ %  ^  & (  )  `  ~  ~~  ");
                        textBox1.Text = string.Empty;
                        return;
                    }
                }
            }
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            int dlugosc = textBox4.Text.Length;
            if (dlugosc > 3)
            {
                MessageBox.Show("Użyto zbyt wiele znaków \n Możesz wpisać maksymalnie 3 znaki np: 2,0",
                    "Przekroczony limit znaków", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Text = String.Empty;
                return;
            }
            if (dlugosc == 1)
            {
                if (textBox4.Text[0].ToString() != 0.ToString() &&
                    textBox4.Text[0].ToString() != 1.ToString() &&
                    textBox4.Text[0].ToString() != 2.ToString() &&
                    textBox4.Text[0].ToString() != 3.ToString() &&
                    textBox4.Text[0].ToString() != 4.ToString() &&
                    textBox4.Text[0].ToString() != 5.ToString())
                {
                    MessageBox.Show("Nieprawidłowy format znaków\n Dozwolone znaki na pierwszej [1] pozycji to: 0,1,2,3,4,5",
                        "Nieodpowiedni format znaków", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Text = String.Empty;
                    return;
                }
            }
            if (dlugosc == 2)
            {
                if (textBox4.Text[1].ToString() != ",".ToString())
                {
                    MessageBox.Show("Nieprawidłowy format znaku\n Dozwolony znak na drugiej [2] pozycji to przecinek ','", "Nieodpowiedni format znaków",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    textBox4.Text = String.Empty;
                    return;
                }
            }
            if (dlugosc == 3)
            {

                if (textBox4.Text[2].ToString() != 0.ToString() &&
                        textBox4.Text[2].ToString() != 1.ToString() &&
                        textBox4.Text[2].ToString() != 2.ToString() &&
                        textBox4.Text[2].ToString() != 3.ToString() &&
                        textBox4.Text[2].ToString() != 4.ToString() &&
                        textBox4.Text[2].ToString() != 5.ToString() &&
                        textBox4.Text[2].ToString() != 6.ToString() &&
                        textBox4.Text[2].ToString() != 7.ToString() &&
                        textBox4.Text[2].ToString() != 8.ToString() &&
                        textBox4.Text[2].ToString() != 9.ToString())
                {
                    MessageBox.Show("Nieprawidłowy format znaków\n Dozwolone znaki na trzeciej [3] pozycji to: 0,1,2,3,4,5,6,7,8,9", "Nieodpowiedni format znaków", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Text = String.Empty;
                    return;
                }
            }
        }
    }
}
