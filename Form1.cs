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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Ubezpieczenia
{
    [Serializable]
    public partial class Form1 : Form
    {
        internal List<Pojazd> listaPojazdow = new List<Pojazd>();
        internal List<Własciciel> listaWłasiciela = new List<Własciciel>();
        internal Form_Auta form_Auta;
        internal Form_Ubezpieczenia form_Ubezpieczenia;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            ModułAuta();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            ModułAuta();
        }
        private void ModułAuta()
        {
      
            form_Auta = new Form_Auta(this);
            form_Auta.Size = new Size(this.Size.Width, this.Size.Height);
            form_Auta.WypelnijDataGrid1();
            if (listaPojazdow.Count > 0)
            {
                form_Auta.Visible = true;
                form_Auta.label1.Text = "Wprowadź kolejne auta lub przejdź do modułu: \n Wprowadź właściciciela";
            }
                form_Auta.Show();
        }

        //private void ModulWlasciciel()
        //{
        //    Form_Ubezpieczenia form_Ubezpieczenia = new Form_Ubezpieczenia();
        //    form_Ubezpieczenia.Size = new Size(this.Size.Width, this.Size.Height);
        // //    .WypelnijDataGrid1();
        //    form_Ubezpieczenia.Show();
        //}

        private void label2_Click(object sender, EventArgs e)
        {
            if (listaPojazdow.Count == 0)
            {
                MessageBox.Show("Brak pojazdów do przypisania właścicielowi\n Przypisz pojazd w module:\n Wprowadź auto", "Brak pojazdów w bazie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ModułAuta();
            form_Auta.button1.Text = "Dodaj właściciela";
            form_Auta.BackColor = Color.FromName("SandyBrown");
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (listaPojazdow.Count==0)
            {
                MessageBox.Show("Brak pojazdów do przypisania właścicielowi\n Przypisz pojazd w module:\n Wprowadź auto", "Brak pojazdów w bazie", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            ModułAuta();
            form_Auta.button1.Text = "Dodaj właściciela";
            form_Auta.BackColor = Color.FromName("SandyBrown");
        }
        public void ModułUbezpieczenia()
        {
            form_Ubezpieczenia = new Form_Ubezpieczenia(this);
            form_Ubezpieczenia.Size = new Size(this.Size.Width, this.Size.Height);
            form_Ubezpieczenia.BackColor = Color.FromName("IndianRed");
            WypełnijDataGridUbezpieczen();

            form_Ubezpieczenia.Show();
        }

       public void WypełnijDataGridUbezpieczen()
        {
            form_Ubezpieczenia.dataGridView1.Rows.Clear();
            foreach (Własciciel własciciel in listaWłasiciela)
            {
                form_Ubezpieczenia.dataGridView1.Rows.Add(własciciel.WyswietlDane());
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (listaWłasiciela.Count == 0)
            {
                MessageBox.Show("Brak kalkulacji ofert","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ModułUbezpieczenia();
            }
      
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (listaWłasiciela.Count==0)
            {
                MessageBox.Show("Wprowadź dane do modułów:\n Wprowadź auta \n Wprowdź właściciela", "Brak kalkulacji ofert",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            else
            {
                ModułUbezpieczenia();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "Baza/Ubezpieczenia.txt";
            using (FileStream s = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                if (s.Length>3)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    listaPojazdow = (List<Pojazd>)bf.Deserialize(s);
                    listaWłasiciela = (List<Własciciel>)bf.Deserialize(s);
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 10;
                    progressBar1.PerformStep();
                }
                else
                {
                    MessageBox.Show("Brak danych do wczytania","Baza danych jest pusta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }

            }
            label3.Text = "Wczytano dane";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream s = new FileStream("Baza/Ubezpieczenia.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, listaPojazdow);
                bf.Serialize(s, listaWłasiciela);
          
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.FromName("AliceBlue");
            panel1.BorderStyle = BorderStyle.FixedSingle;
            label1.BackColor = Color.FromName("AliceBlue");
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromName("Turquoise");
            panel1.BorderStyle = BorderStyle.Fixed3D;
            label1.BackColor = Color.FromName("Turquoise");
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.FromName("AliceBlue");
            panel3.BorderStyle = BorderStyle.FixedSingle;
            label2.BackColor = Color.FromName("AliceBlue");
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromName("SandyBrown");
            panel3.BorderStyle = BorderStyle.Fixed3D;
            label2.BackColor = Color.FromName("SandyBrown");
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.FromName("AliceBlue");
            panel4.BorderStyle = BorderStyle.FixedSingle;
            label4.BackColor = Color.FromName("AliceBlue");
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromName("IndianRed");
            panel4.BorderStyle = BorderStyle.Fixed3D;
            label4.BackColor = Color.FromName("IndianaRed");
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.FromName("AliceBlue");
            panel1.BorderStyle = BorderStyle.FixedSingle;
            label1.BackColor = Color.FromName("AliceBlue");
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromName("Turquoise");
            panel1.BorderStyle = BorderStyle.Fixed3D;
            label1.BackColor = Color.FromName("Turquoise");
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.FromName("AliceBlue");
            panel3.BorderStyle = BorderStyle.FixedSingle;
            label2.BackColor = Color.FromName("AliceBlue");
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromName("SandyBrown");
            panel3.BorderStyle = BorderStyle.Fixed3D;
            label2.BackColor = Color.FromName("SandyBrown");
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.FromName("AliceBlue");
            panel4.BorderStyle = BorderStyle.FixedSingle;
            label4.BackColor = Color.FromName("AliceBlue");
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromName("IndianRed");
            panel4.BorderStyle = BorderStyle.Fixed3D;
            label4.BackColor = Color.FromName("IndianaRed");
        }
    }
}
