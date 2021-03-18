using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ubezpieczenia
{
    public partial class Form_Ubezpieczenia : Form
    {
        Form1 form1;
        public Form_Ubezpieczenia(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.listaWłasiciela.Clear();
            form1.WypełnijDataGridUbezpieczen();
        }
    }
}
