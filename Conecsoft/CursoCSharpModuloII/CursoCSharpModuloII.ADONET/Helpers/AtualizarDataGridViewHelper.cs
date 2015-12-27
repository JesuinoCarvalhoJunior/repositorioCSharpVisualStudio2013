using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CursoCSharpModuloII.ADONET.Helpers
{
    public static class AtualizarDataGridViewHelper
    {
        static SqlDataAdapter adapt;
        public static void DisplayData(DataGridView dadosDataGridView)
        {
            DbHelper.AbrirConexao();
            
            var cmd = DbHelper.CriarComando(@"SELECT * FROM Categoria order by ID desc");

            var dt = new DataTable();

            var adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            dadosDataGridView.DataSource = dt;
        }
    }
}
