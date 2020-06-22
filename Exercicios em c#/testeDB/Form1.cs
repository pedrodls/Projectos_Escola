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

namespace testeDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c= "server = 127.0.0.1; database=mercado; uid=root; pwd = ''; port=3306";
            try 
            {
                MySqlConnection cnn = new MySqlConnection();

                cnn.ConnectionString = c;

                cnn.Open();

                

                lblcn.Text = "Conectado com sucesso";

               

                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
