using System.Data;
using System.Data.SqlClient;
using CursoCSharpModuloII.ADONET.Properties;

namespace CursoCSharpModuloII.ADONET
{
    public static class DbHelper
    {
        private static SqlConnection connection;

        public static void AbrirConexao()
        {
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                connection = new SqlConnection(Settings.Default.StringConexao);
                connection.Open();
            }
        }

        public static void FecharConexao()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static SqlCommand CriarComando(string sqlString = null)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sqlString;
            return cmd;
        }
    }
}