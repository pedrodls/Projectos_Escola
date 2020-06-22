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
        bool limpar, limpar2=true;
        bool desligar = false;
        float final=0, numero1, numero2;
        string op;

        List<operacao> operacoes= new List<operacao>();

        List<string> expPol = new List<string>();
        List<string> expNormal = new List<string>();
        Stack<string> pilha = new Stack<string>();

        public int prioridade(string s1, string s2)
        {
            string sinal = "*2/2+1-1";
            int p1, p2;

            p1 = int.Parse(sinal[sinal.IndexOf(s1) + 1].ToString());
            p2 = int.Parse(sinal[sinal.IndexOf(s2) + 1].ToString());

            if (p1 >= p2)
                return 0;
            return 1;

        }



        public Form1()
        {
            InitializeComponent();
        }


        


        private void btnLimpar(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "OFF")
                this.Close();
            
            if (txtVisor1.Text!="0"&&txtVisor1.Text!="")
            {

                if (((Button)sender).Text == "DEL")
                {
                    txtVisor1.Text = txtVisor1.Text.Substring(0, txtVisor1.TextLength - 1);

                    if (txtVisor1.Text == "")
                        txtVisor1.Text = "0";
                }
                else
                {
                    txtVisor1.Text = "0";
                    txtVisor.Text = "";
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
            operacao op = new operacao();

            if (txtVisor1.Text != "" && txtVisor1.Text == "0")
                txtVisor1.Text = "";

            op.numero = float.Parse(((Button)sender).Text);

            if (op.numero != 0)
                operacoes.Add(op);

            txtVisor1.Text += op.numero.ToString();



        }

        private void btnAlfa_Click(object sender, EventArgs e)
        {

        }

        private void btnX2_Click(object sender, EventArgs e)
        {
           

        }

        private void btnoperacao(object sender, EventArgs e)
        {
            operacao op = new operacao();

            op.operadores =((Button)sender).Text;

            operacoes.Add(op);

            txtVisor1.Text += op.operadores;


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

        private void btnIgual_Click(object sender, EventArgs e)
        {


            string sinais = "*/+-()", num = "";

            foreach (var exp in txtVisor.Text)
            {
                if (!sinais.Contains(exp))
                    num += exp;
                else
                {
                    expNormal.Add(num);
                    expNormal.Add(exp.ToString());
                    num = "";
                }
                expNormal.Remove("");
            }

            if (num.Length > 0)
                expNormal.Add(num);

            string sinalp = "";
            foreach (string item in expNormal)
            {
                if (!sinais.Contains(item))
                {
                    expPol.Add(item);
                }

                else
                {
                    if (pilha.Count == 0)
                    {
                        pilha.Push(item);
                    }
                    else
                    {
                        if ("(" == item)
                        {
                            pilha.Push(item);
                        }
                        else if (")" == item)
                        {
                            string a = pilha.Pop();
                            while (a != "(")
                            {
                                expPol.Add(a);
                                a = pilha.Pop();
                            }
                        }
                        else
                        {
                            sinalp = pilha.Pop();
                            if (sinalp == "(")
                            {
                                pilha.Push(sinalp);
                                pilha.Push(item);
                            }
                            else
                            {
                                if (prioridade(sinalp, item) == 0)
                                {
                                    expPol.Add(sinalp);
                                    if (pilha.Count() > 0)
                                    {
                                        string aux = pilha.Pop();
                                        if (prioridade(sinalp, item) == 0 && aux != "(")
                                        {
                                            expPol.Add(aux);
                                        }
                                        else
                                        {
                                            pilha.Push(aux);
                                        }

                                    }
                                    pilha.Push(item);
                                }
                                else
                                {
                                    pilha.Push(sinalp);
                                    pilha.Push(item);
                                }
                            }
                        }
                    }
                }
            }

            while (pilha.Count > 0)
            {
                expPol.Add(pilha.Pop());
            }

            txtVisor1.Text=(expPol.ToArray()).ToString();











        }

    }
}
