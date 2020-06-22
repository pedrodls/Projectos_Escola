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
    public partial class AddContacto : Form
    {
        public AddContacto()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ObjDados dados = new ObjDados();

            if (txtNome.Text!=""&&txtNumero.Text!="")
            {
                dados.Nome = txtNome.Text; dados.Numero = txtNumero.Text;

                ClassePrincipal.iniciar();
                ClassePrincipal.adionarContacto(dados);
            } else
                MessageBox.Show("Verifique se os campos estão todos Preenchidos!");
        }
    }
}
