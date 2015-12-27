using CursoCSharpModuloII.ADONET.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloII.ADONET
{
    public static class DbHelper
    {
        private static SqlConnection connection;

        public static void AbrirConexao()
        {
            if (connection == null || connection.State == System.Data.ConnectionState.Closed)
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