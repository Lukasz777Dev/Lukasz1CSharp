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
    public partial class Form_Dodaj_Wlasciciela : Form
    {
        List<string> znakiNiedozwoloneLista = new List<string>() { ".", "?", "/", ";", ":", "'", " ", "[", "]", "{", "}", "'\'", "|", "+", "=", "*", "/", ".", "!", "@", "#", "$", "%", "^", "&", "(", ")", "`", "~", "~~", "" };

        Form_Auta form_Auta;
        Własciciel własciciel = new Własciciel();
        object[] dane = new object[6];
        double[] cenaUbezpieczenia = new double [1];
        public Form_Dodaj_Wlasciciela(Form_Auta form_Auta)
        {
            InitializeComponent();

            this.form_Auta = form_Auta;
            textBox4.Text = form_Auta.pojazd.Marka;
            textBox4.ReadOnly = true;
            textBox5.Text = form_Auta.pojazd.Model;
            textBox5.ReadOnly = true;
            textBox6.Text = form_Auta.pojazd.NrRejestracyjny;
            textBox6.ReadOnly = true;
            List<int> listaSzkod = new List<int>() { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
            foreach (int iloscSzkod in listaSzkod)
            {
                comboBox1.Items.Add(iloscSzkod);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Wpisz imię właściciela pojazdu.","Brak danych",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //textBox1.Text = string.Empty;
                return;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Wpisz nazwisko.","Brak danych",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox2.Text = string.Empty;
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz z listy właściwą pozycję.","Nieprawidłowy wybór",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {

                dane = własciciel.ObliczCeneUbezpieczenia(dateTimePicker1.Value, form_Auta.pojazd, (int)comboBox1.SelectedItem);
                cenaUbezpieczenia[0] = (double)dane[0];
                własciciel = new Własciciel(textBox1.Text, textBox2.Text, form_Auta.pojazd, cenaUbezpieczenia[0]);
                form_Auta.form1.listaWłasiciela.Add(własciciel);
                form_Auta.form1.form_Auta.Close();
                własciciel.PokazSzczegoly(dane[1].ToString(), dane[2].ToString(), dane[3].ToString(), dane[4].ToString(), dane[5].ToString());
                form_Auta.form1.ModułUbezpieczenia();
                this.Close();
                form_Auta.form1.progressBar1.Minimum = 0;
                form_Auta.form1.progressBar1.Maximum = 10;
                form_Auta.form1.progressBar1.PerformStep();
                form_Auta.form1.label3.Text = "Zapisano";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Imię - nie dopuszcza wpisywania cyfr
            int jakasLitera = textBox1.Text.Length;
            bool czyToLitera = int.TryParse(textBox1.Text, out jakasLitera);
            if (czyToLitera)
            {
                
                MessageBox.Show("Nieprawidłowy format danych \n Wpisz imię składające się z liter","Nieprawidłowe dane",MessageBoxButtons.OK,MessageBoxIcon.Stop);

                return;
            }
           
            // Imię - W imieniu nie dopuszcza do używania znakow zabronionych.
            foreach (string znakNiepozadany in znakiNiedozwoloneLista)
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (znakNiepozadany == textBox1.Text[i].ToString())
                    {
                        MessageBox.Show("W imieniu nie mozna używac znaków, takich jak: .  ,  ?  /  ;  :  '    [  ]  { }   |  +  ,= , *  /  .  !  @  #  $ %  ^  & (  )  `  ~  ~~  ","Niedozwolone znaki", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        textBox1.Text = string.Empty;
                        return;
                    }
                }
            }

        }
    }
}
