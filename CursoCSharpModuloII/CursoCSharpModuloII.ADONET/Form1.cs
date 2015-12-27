using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharpModuloII.ADONET
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=CONECSOFT-DES02\SQLEXPRESS;Initial Catalog=TREINAMENTO_MODULO_II; Integrated Security=True");
            try
            {
                conn.Open();
                MessageBox.Show("Conexão realizada com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a conexão!");
            } 
             
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("SELECT * FROM TBCLIENTE", conn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //cmd.CommandText = "SELECT * FROM TBCLIENTE";
            cmd.CommandText = "SELECT 1";
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show(Convert.ToString(i));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("SELECT * FROM TBCLIENTE", conn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT NOME FROM TBCLIENTE";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               var nome = reader["NOME"];
               MessageBox.Show(Convert.ToString(nome));
            }            
        }
    }
}
