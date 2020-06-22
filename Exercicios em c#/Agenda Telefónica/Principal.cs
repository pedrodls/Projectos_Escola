using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Telefónica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            //apresenta a versao do programa
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            //sair da aplicacao

            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Contactos().ShowDialog();
        }
    }
}
