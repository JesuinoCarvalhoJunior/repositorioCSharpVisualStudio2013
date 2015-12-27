using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CursoCSharpModuloII.ADONET.Properties;

namespace CursoCSharpModuloII.ADONET
{
    public partial class FormExemplo : Form
    {
        private SqlConnection conn;
        public FormExemplo()
        {
            InitializeComponent();
        }

        private void abrirConexao(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(Settings.Default.StringConexao);
                conn.Open();

                MessageBox.Show("Conexão estabelecida com sucesso.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a conexão.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT NOME FROM TBCLIENTE WHERE ID = 1";
            MessageBox.Show(cmd.ExecuteScalar().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM TBCLIENTE";
            SqlDataReader reader = cmd.ExecuteReader();

            object obj = null;
            obj.ToString();

            while (reader.Read())
            {
                MessageBox.Show(Convert.ToString(reader["NOME"]));
                MessageBox.Show(reader["DATANASCIMENTO"].ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT NOME FROM TBCLIENTE WHERE ID = @ID");
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(numericUpDown1.Value));
            MessageBox.Show(Convert.ToString(cmd.ExecuteScalar()));

            //var parametroId = new SqlParameter("@ID", Convert.ToInt32(numericUpDown1.Value));
            //parametroId.SqlDbType = SqlDbType.Int;
            //parametroId.Direction = ParameterDirection.InputOutput;
            //cmd.Parameters.Add(parametroId);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBCLIENTE WHERE ID = @ID");
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(numericUpDown1.Value));

            using (var reader = cmd.ExecuteReader())
            {

                if (reader.Read())
                {
                    MessageBox.Show(string.Format("Nome: {0}\nNascimento: {1}", reader["NOME"], Convert.ToDateTime(reader["DATANASCIMENTO"]).ToString("dd-MM-yyyy")));
                }
                else
                {
                    MessageBox.Show("O código não existe!");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO TBCLIENTE(Nome, DataNascimento) 
                    VALUES (@Nome, @DataNascimento)";
                cmd.Parameters.AddWithValue("@Nome", textBox1.Text);
                cmd.Parameters.AddWithValue("@DataNascimento", dateTimePicker1.Value);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente inserido com sucesso.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro.");
            }
        }

        private void numericUpDown1_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("AA");
        }
    }
}
