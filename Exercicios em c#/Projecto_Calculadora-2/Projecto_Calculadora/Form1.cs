using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_Calculadora
{
    public partial class Form1 : Form
    {
        bool limpar=true, limpar2=true;
        bool desligar = false;
        float Ans = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "OFF")
                this.Close();
            
            if (txtVisor.Text!="0"&&txtVisor.Text!="")
            {

                if (((Button)sender).Text == "DEL")
                {
                    txtVisor.Text = txtVisor.Text.Substring(0, txtVisor.TextLength - 1);

                    if (txtVisor.Text == "")
                        txtVisor.Text = "0";
                }
                else
                {
                    txtVisor.Text = "";
                    txtVisor1.Text = "0";
                }
                limpar = true;
            }
           
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            txtVisor1.Text = "0";
            txtVisor.Text = "";

            foreach (object bt in Controls)
                    if(bt is Button)
                        (bt as Button).Enabled = true;


        }

        private void btnNumerador(object sender, EventArgs e)
        {
            txtVisor.Text+=((Button)sender).Text;
          
        }

        private void btnAlfa_Click(object sender, EventArgs e)
        {

        }

        private void btnX2_Click(object sender, EventArgs e)
        {
           

        }

        private void btnoperacao(object sender, EventArgs e)
        {
            if(txtVisor1.Text!=""&& txtVisor1.Text!="0")

            txtVisor.Text += ((Button)sender).Text;
        }



        private void button38_Click(object sender, EventArgs e)
        {

            if (desligar == false)
            {
                btnX3.Text = "∛";
                lblcubicrad.Text = "x³";

                btnPol.Text = "rec(";
                lblRec.Text = "pol(";

                btns1.Text = "OFF";
                label10.Text = "AC";

                btnfact.Text = "x!";
                lblfact.Text= "x¯¹";

                btnNcr.Text = "nPc";
                lblnPc.Text = "nCr";

                btnAb.Text = "d/c";
                lbldc.Text = "aᵇ/c";

                btnEsp.Text = "ˣ√";
                lblEsp.Text = "^";

                btnLog.Text ="10ˣ" ;
                lblelevado.Text = "Log";

                btnIn.Text = "eˣ";
                lblin.Text = "In";

                btnsin.Text = "sin⁻¹";
                lblsin.Text = "sin";

                btncos.Text = "cos⁻¹";
                lblcos.Text = "cos";

                btntan.Text = "tan⁻¹";
                lbltan.Text = "tan";

                btnm.Text = "M-";
                lblm.Text = "M+";

                btnrcl.Text = "STO";
                lblsto.Text = "RCL";

                btnset.Text = "<-";
                lblset.Text = ".,,,";

                btnset2.Text = "<-";
                lblset2.Text = "ENG";


                desligar = true;

            }else
                 {
                    btnset.Text = ".,,,";
                    lblset.Text ="<-";

                    btnset2.Text ="ENG";
                    lblset2.Text =  "<-";




                    btnrcl.Text = "RCL";        
                    lblsto.Text = "STO" ;

                    btnm.Text = "M+";
                    lblm.Text = "M-";

                    btnsin.Text = "sin";
                    lblsin.Text = "sin⁻¹";

                    btncos.Text = "cos";
                    lblcos.Text = "cos⁻¹";

                    btntan.Text ="tan" ;
                    lbltan.Text = "tan⁻¹";



                     btnIn.Text = "In";
                     lblin.Text = "eˣ";
                 
                     btnLog.Text =  "Log";
                     lblelevado.Text ="10ˣ";

                     btnEsp.Text ="^" ;
                     lblEsp.Text = "ˣ√";

                     btnX3.Text = "x³";
                     lblcubicrad.Text = "∛";

                     btnPol.Text = "pol(";
                     lblRec.Text = "rec("; 

                     btnNcr.Text = "nCr";
                     lblnPc.Text = "nPr";

                     btnfact.Text = "x¯¹";
                     lblfact.Text = "x!";

                     label10.Text = "OFF";
                     btns1.Text = "AC";

                     btnAb.Text ="aᵇ/c";
                     lbldc.Text =  "d/c";
                    
                desligar = false;
                }


        }

        private void btnAcumular_Click(object sender, EventArgs e)
        {
            if (txtVisor1.Text != "")
            {
                Ans = float.Parse(txtVisor1.Text);

                txtVisor.Text = Ans.ToString();

                txtVisor1.Text = "";

            }
           
        }

        private void btnfact_Click(object sender, EventArgs e)
        {
            double y = -1, fat=1; 

            if (btnfact.Text == "x¯¹" && txtVisor.Text != "")
                txtVisor1.Text = (Math.Pow(double.Parse(txtVisor.Text),y)).ToString();
            
            if(btnfact.Text == "x!" && txtVisor.Text != "")
            {
                for (int i = 1; i <= int.Parse(txtVisor.Text); i++)
                    fat *= i;

                txtVisor1.Text = fat.ToString();
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
           
        }

    }
}
