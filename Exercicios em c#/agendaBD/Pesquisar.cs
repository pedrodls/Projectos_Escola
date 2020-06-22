using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendaBD
{
    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text != "")
            {
                ClassePrincipal.iniciar();
                ClassePrincipal.pesquisarContacto(listBox, textBox1.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
