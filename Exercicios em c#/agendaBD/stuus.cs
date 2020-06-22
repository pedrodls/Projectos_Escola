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
    public partial class stuus : Form
    {
        bool logico = false;

        ObjDados objDados;

        string aNo = "", aNu = "";

        public stuus()
        {
            InitializeComponent();


        }

        private void stuus_Load(object sender, EventArgs e)
        {

            ClassePrincipal.iniciar();

            ClassePrincipal.exibirValores(listaContacto, totalbl);

        }

        private void listaContacto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaContacto.Items.Count > 0)
            {
                objDados = new ObjDados();

                string slcItm = listaContacto.SelectedItem + "";

                int index = slcItm.IndexOf('\t');

                aNo= slcItm.Substring(0, index);

                aNu= slcItm.Substring(index + 1);

                objDados.Nome = slcItm.Substring(0, index); objDados.Numero = slcItm.Substring(index + 1);

                txtNome.Text = objDados.Nome;

                txtNumero.Text = objDados.Numero;

                logico = true;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            objDados = new ObjDados();

            if (logico == true)
            {
                objDados.Nome = txtNome.Text; objDados.Numero = txtNumero.Text;

                ClassePrincipal.iniciar();

                ClassePrincipal.eliminar(objDados, listaContacto, totalbl);

                ClassePrincipal.iniciar();

                ClassePrincipal.exibirValores(listaContacto, totalbl);

                txtNome.Text = "";
                txtNumero.Text = "";

                logico = false;
            }
        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            if (listaContacto.Items.Count > 0)
            {

                ClassePrincipal.iniciar();

                ClassePrincipal.eliminarTudo(listaContacto, totalbl);

                txtNome.Text = "";
                txtNumero.Text = "";
            }
        }

        private void EditarContacto_Click(object sender, EventArgs e)
        {
            objDados = new ObjDados();

            if (txtNome.Text != "" && txtNumero.Text != ""&& logico == true)
            {
                objDados.Nome = txtNome.Text; objDados.Numero = txtNumero.Text;

                ClassePrincipal.iniciar();

                ClassePrincipal.editar(objDados, aNo, aNu, listaContacto, totalbl);

                ClassePrincipal.iniciar();

                ClassePrincipal.exibirValores(listaContacto, totalbl);

                txtNome.Text = "";

                txtNumero.Text = "";

                logico = false;
            }
            else
                MessageBox.Show("Dados Incompletos ou Nenhum item Seleccionado", "ERRO");
                
        }
    }
}
