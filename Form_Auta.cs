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
    public partial class Form_Auta : Form
    {
      
        internal Form1 form1;
        internal Pojazd pojazd;
        internal Form_Dodaj_Wlasciciela form_Dodaj_Wlasciciela;
        public Form_Auta(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button_Wroc(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Dodaj_Auto(object sender, EventArgs e)
        {
            if (button1.Text == "Dodaj auto")
            {
                Form_Dodaj_Auto form_Dodaj_Auto = new Form_Dodaj_Auto(this);
                if (form_Dodaj_Auto.ShowDialog() == DialogResult.OK)
                {
                    label1.Visible = true;
                    label1.Text = "Wprowadź kolejne auta lub przejdź do modułu: \n Wprowadź właściciciela";
                    WypelnijDataGrid1();
                }
            }
            if (button1.Text == "Dodaj właściciela")
            {
                pojazd =  (Pojazd)dataGridView1.SelectedRows[0].Tag;
                form_Dodaj_Wlasciciela = new Form_Dodaj_Wlasciciela(this);
                form_Dodaj_Wlasciciela.Show();
         
            }
        }

        public void WypelnijDataGrid1()
        {
            dataGridView1.Rows.Clear();
            foreach (Pojazd pojazd in form1.listaPojazdow)
            {
                int i = dataGridView1.Rows.Add(pojazd.PokazPojazd());
                dataGridView1.Rows[i].Tag = pojazd;
            }
        }

        private void button_Wyczysc_Dane(object sender, EventArgs e)
        {
            form1.listaPojazdow.Clear();
            WypelnijDataGrid1();
        }
    }
}
