using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoStop
{
    public partial class frmApresentacao : Form
    {
        public frmApresentacao()
        {
            InitializeComponent();
        }

        int cont = 180; int cont2 = 0;

        private void frmApresentacao_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
            timer1.Start();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            cont -= 5;

            label1.Location = new Point(33, cont);

            if (cont < 60)
            {
                timer1.Stop();
                timer1.Enabled = false;
                timer2.Start();

            }



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cont2 += 7;

            bunifuCircleProgressbar1.Value = cont2;

            if (cont2  > 97)
            {
                timer1.Stop();
                timer2.Stop();
                timer1.Enabled = false;
                timer2.Enabled = false;

                MessageBox.Show("Bom Jogo","Iniciando...",MessageBoxButtons.OK);

            }
        }
    }
}
