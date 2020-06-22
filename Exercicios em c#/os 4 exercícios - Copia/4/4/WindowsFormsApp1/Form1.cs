using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

               

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool primo(int digito)
        {
            int cont = 0;

            for (int i = 1; i <= digito; i++)
                if (digito % i == 0)
                    cont++;

            if (cont == 2)
                return true;
            else
                return false;
        }

        private int somar_elementos(string[] vet)
        {
            int soma = 0;
        
            for (int i = 0; i <= vet.Length -1; i++)
                if(vet[i]!= "")
                    soma += int.Parse(vet[i].ToString());

            return soma;
        }

       private int maior_elemento(string[] vet)
        {
            int maior = int.Parse(vet[0]);

            for (int i = 1; i < vet.Length-1 ; i++)
                if (int.Parse(vet[i]) > maior && (vet[i] != ""))
                    maior = int.Parse(vet[i]);
            
            return maior;
        }

        private void txtTela_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)||e.KeyChar==(char)','))
                e.Handled = true;

            if (txtTela.Text == "" && e.KeyChar == (char)',')
                e.Handled = true;

            if (txtTela.Text.Contains(","))
            {
                int aux = txtTela.TextLength-1;

                if (txtTela.Text.Substring(aux) == "," && e.KeyChar == (char)',')
                    e.Handled = true;
              
            }

        }

   
       
        private void txtTela_TextChanged(object sender, EventArgs e)
        {

            if(txtTela.Text.Contains(","))
            {
                string[] vet = txtTela.Text.Split(',');

                string aux = vet[vet.Length-1];

                if (vet.Length > 2)
                {
                    if (aux == vet[vet.Length - 3] && aux == vet[vet.Length - 2])
                    {

                        lbxResultado.Items.Add("Quantidade de nsº lidos: " + (vet.Length - 1).ToString() + "\n");

                        lbxResultado.Items.Add("Leitura parada por causa de 3 nsº consecutivos iguais\n inseridos!");

                        lbxResultado.Items.Add("Soma de todos os valore: " + somar_elementos(vet).ToString());

                        lbxResultado.Items.Add("Maior nº lido: " + maior_elemento(vet));

                        this.Hide();

                        Form formRes = new FormResultado();

                        lbxResultado.Enabled = true;

                        formRes.Controls.Add(lbxResultado);

                        formRes.Show();

                    }


                    if ((primo(int.Parse(vet[vet.Length - 3])) == true) && (primo(int.Parse(vet[vet.Length - 2]))) == true)
                    {

                        lbxResultado.Items.Add("Quantidade de nsº lidos: " + (vet.Length - 1).ToString() + "\n");

                        lbxResultado.Items.Add("Leitura parada por causa de 2 nsº primos consecutivos\n inseridos!");

                        lbxResultado.Items.Add("Soma de todos os valore: " + (somar_elementos(vet)).ToString());

                        lbxResultado.Items.Add("Maior nº lido: " + maior_elemento(vet));

                        this.Hide();

                        Form formRes = new FormResultado();

                        lbxResultado.Enabled = true;

                        formRes.Controls.Add(lbxResultado);

                        formRes.Show();
                    }

                }

                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


    }
}
