using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace agendaBD
{
    //=====================================================
    public static partial class ClassePrincipal
    {
        public static MySqlCommand comando;
        public static MySqlConnection cnn;
        public static string c= "server = localhost; database=AgendaBD; uid=root; pwd = ''";
        public static int cont = 0;

        public static void iniciar()
        {
            try
            {
                cnn = new MySqlConnection();

                cnn.ConnectionString = c;

                cnn.Open();

            }
            catch 
            {
                MessageBox.Show("Erro ao conectar a Base de dados!!!");
            }

        }

        public static void exibirValores(ListBox listaContactos, Label totalContactos)
        {
            cont = 0;

            totalContactos.Text = "";

            listaContactos.Items.Clear();

            try
            {
                comando = new MySqlCommand("select * from contactos order by Nome asc;", cnn);

                MySqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    listaContactos.Items.Add(dr["Nome"] + "\t" + dr["Numero"]);
                    cont++;
                }

                
                totalContactos.Text = cont + "";

                
            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }
        public static void eliminar(ObjDados Dados,  ListBox listaContactos, Label totalContactos)
        {
            
            try
            {
                comando = new MySqlCommand($"delete from contactos where Nome = '{Dados.Nome}' and Numero = {Dados.Numero};", cnn);

                MySqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    listaContactos.Items.Add(dr["Nome"] + "\t" + dr["Numero"]);
                    cont++;
                }


                totalContactos.Text = cont + "";


            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao eliminar: "+e.Message.ToString());
            }
        }
        public static void eliminarTudo(ListBox listaContactos, Label totalContactos)
        {

            try
            {
                comando = new MySqlCommand($"delete from contactos;", cnn);

                comando.ExecuteNonQuery();

                listaContactos.Items.Clear();

                totalContactos.Text = "0";
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao eliminar: " + e.Message.ToString());
            }
        }

        public static void editar(ObjDados Dados, string ANome, string ANumero, ListBox listaContactos, Label totalContactos)
        {

            try 
            {
                comando = new MySqlCommand($"update contactos set Nome = '{Dados.Nome}', Numero = {Dados.Numero} where Nome = '{ANome}' and Numero = {ANumero} ;", cnn);

                MySqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    listaContactos.Items.Add(dr["Nome"] + "\t" + dr["Numero"]);
                    cont++;
                }


                totalContactos.Text = cont + "";


            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao eliminar: " + e.Message.ToString());
            }
        }
        
        public static void adionarContacto(ObjDados Dados)
        {
            try
            {
                comando = new MySqlCommand($"insert into contactos values(default, '{Dados.Nome}', '{Dados.Numero}' );", cnn);
                comando.ExecuteNonQuery();

                if (MessageBox.Show("Contacto Adicionado com sucesso. \n Deseja  verificar?", "Adiciondo Contacto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    new stuus().Show();

            }catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        public static void pesquisarContacto(ListBox listaContactos, string item)
        {
            listaContactos.Items.Clear();

            comando = new MySqlCommand($"select * from contactos where Nome like '{item}%'", cnn);

            MySqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
                listaContactos.Items.Add(dr["Nome"] + "\t" + dr["Numero"]);
        }
    }
}
