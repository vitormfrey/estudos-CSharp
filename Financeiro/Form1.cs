using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta v = new Conta();

            Conta c = new Conta();

            v.Despositar(100);
            c.Despositar(0);

            v.Transfere(34, c);

            MessageBox.Show(c.saldo.ToString("C"));

        }
    }
}
