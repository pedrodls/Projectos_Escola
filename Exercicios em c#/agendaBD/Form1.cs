using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace agendaBD
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();


        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //ClassePrincipal cl = new ClassePrincipal();

            //cl.iniciar();

        }

        private void Visualizar_Click(object sender, EventArgs e)
        {
            stuus status = new stuus();
            status.Show();
                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddContacto().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Pesquisar().Show();
        }
    }
}
