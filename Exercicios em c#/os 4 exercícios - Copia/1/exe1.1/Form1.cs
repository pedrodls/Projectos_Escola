using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe1._1
{
    public partial class Form1 : Form
    {
       
        int cont = -1;
        int[] vetN = new int[6];
        string aux = "";
        public Form1()
        {
            InitializeComponent();
        }


        

        private int separarDigitos(int digito, int index)
        {
            

            vetN[index] = (digito);


            return vetN[index];
            



        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 6)
                lbl1.Text = "tem de ter 6 digitos no máximo!";
            else
                lbl1.Text = "";
           

            for (int i=0; i<6; i++)
               aux += separarDigitos(int.Parse(textBox1.Text[i].ToString()), i).ToString();

            for (int i = 0; i < 6; i++)
                lbl2.Text += aux[i] + "\n";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!((char.IsDigit(e.KeyChar) || (char.IsControl(e.KeyChar)))))
                e.Handled = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
