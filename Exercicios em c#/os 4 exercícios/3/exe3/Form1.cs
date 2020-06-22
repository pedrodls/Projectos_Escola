using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int maior(string[] vet)
        {
            int maior = int.Parse(vet[0]); 
                
            for(int i=0; i<vet.Length; i++)
                if (int.Parse(vet[i]) > maior)
                    maior = int.Parse(vet[i]);
            

            return maior;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_entrada_sequencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;

        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {

            if (txt_entrada_sequencia.TextLength != 10 && txt_entrada_N.TextLength != 0)
            {
                lbl_verfcar_seqcia.Text = "Sequencia tem de ter 10 digitos no máximo";
                lbl_verificar_N.Text = "";
            }
            else
            {
                if (txt_entrada_sequencia.TextLength != 10 && txt_entrada_N.TextLength == 0)
                {
                    lbl_verificar_N.Text = "número de digitos não pode ser igual a 0 ou vazio";
                    lbl_verfcar_seqcia.Text = "Sequencia tem de ter 10 digitos no máximo";
                }

                if (txt_entrada_sequencia.TextLength == 10 && txt_entrada_N.TextLength == 0)
                {
                    lbl_verfcar_seqcia.Text = "";
                    lbl_verificar_N.Text = "número de digitos não pode ser igual a 0 ou vazio";
                    
                }

                if (txt_entrada_sequencia.TextLength == 10 && txt_entrada_N.TextLength != 0)
                {
                    string[] vet = new string[10];
                    string aux = "";
                    int aux2 = 0;

                    lbl_verfcar_seqcia.Text = "";
                    lbl_verificar_N.Text = "";

                    for(int i=0; i< 10; i++)
                    {
                        aux2 = int.Parse(txt_entrada_sequencia.Text[i].ToString());

                        for (int j= 1; j<= int.Parse(txt_entrada_N.Text); j++)
                            aux += (aux2 + j).ToString();

                        vet[i] = aux;

                        aux = "";
                    }

                    lbxVetor.Items.Clear();

                    for (int i = 0; i < 10; i++)
                        lbxVetor.Items.Add($"{vet[i]} \n");

                    lblMaior.Text = maior(vet).ToString();

                }

            }

            
        }
    }
}
