using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe2
{
    public partial class Form1 : Form
    {
        int cont = 0, index = -1;
        string[] vet_digito ;
        string aux = "";

        public Form1()
        {
            InitializeComponent();
        }

        private string maior_elemento()
        {
            int maior = 0; 

            for(int i=0; i<4; i++)
            {
                if (i == 0)
                    maior = int.Parse(vet_digito[i]);

                if (int.Parse(vet_digito[i]) > maior)
                    maior = int.Parse(vet_digito[i]);
            }

            return maior.ToString();
        }

        private void separarDigitos(int digito)
        {
            index++;

            vet_digito[index] = digito.ToString();
                       
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!((char.IsDigit(e.KeyChar) || (char.IsControl(e.KeyChar)))))
                e.Handled = true;

            if (textBox1.TextLength-1 < 8)
            {
                lbl2.Text = "";
            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void btnSeguinte_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 8)
            {

                lbl1.Text = "";


                for (int i = 0; i < 8; i++)
                {
                    aux += textBox1.Text[i];

                    cont++;

                    if (cont == 2)
                    {
                        separarDigitos(int.Parse(aux));
                        aux = "";
                        cont = 0;
                    }
                }

                lbl2.Text= maior_elemento();

            }
            else
            {
              
                lbl1.Text = "tem de ter 8 digitos no máximo!";
                lbl2.Text = "";
            }
               

        }
    }
}
