using CursoCSharpModuloII.ADONET.Properties;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CursoCSharpModuloII.ADONET
{
    public partial class Form2 : Form
    {

        SqlConnection conn = new SqlConnection(Settings.Default.Setting);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet1 ds = new DataSet1();

        public Form2()
        {
            InitializeComponent();
            
            da.SelectCommand = new SqlCommand("select * from tbcliente", conn);
            //da.UpdateCommand = new SqlCommand(@"update tbcliente set nome = @nome,
            //    dataNascimento = @dataNascimento where Id = @Id",conn);
            //da.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int).SourceVersion = DataRowVersion.Current;
            //da.UpdateCommand.Parameters.Add("@nome", SqlDbType.VarChar).SourceVersion = DataRowVersion.Current;
            //da.UpdateCommand.Parameters.Add("@dataNascimento", SqlDbType.DateTime).SourceVersion = DataRowVersion.Current;

            da.Fill(dataSet1, "TBCLIENTE");
            dataGridView1.DataSource = bindingSource1;
            //DataAdapter dataAdapter
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            da.Update(dataSet1,"TBCLIENTE");
        }
    }
}
