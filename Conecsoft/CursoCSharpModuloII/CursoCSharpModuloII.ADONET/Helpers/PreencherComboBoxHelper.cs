using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CursoCSharpModuloII.ADONET.Helpers
{
    class PreencherComboBoxHelper
    {

        public static void PreencherComboboxDescricao(ComboBox cbBox)
        {
            try
            {
                DbHelper.AbrirConexao();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(@"Falha ao efetuar a conexão. Erro: " + sqlEx);
            }

            var cmd = DbHelper.CriarComando(@"SELECT ID, CODIGO, DESCRICAO FROM Categoria order by ID desc");
            var adapt = new SqlDataAdapter(cmd);
            var dtResultado = new DataTable();

            dtResultado.Clear();
            cbBox.DataSource = null;
            adapt.Fill(dtResultado);
            cbBox.DataSource = dtResultado;
            cbBox.ValueMember = "CODIGO";
            cbBox.DisplayMember = "Descricao";
            cbBox.SelectedItem = "";
            cbBox.Refresh();
        }
    }
}
