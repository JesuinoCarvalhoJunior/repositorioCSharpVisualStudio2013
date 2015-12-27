using System;
using System.Windows.Forms;
using CursoCSharpModuloII.ADONET.Dados;
using CursoCSharpModuloII.ADONET.Dominio;
using CursoCSharpModuloII.ADONET.Helpers;

namespace CursoCSharpModuloII.ADONET.View
{
    public partial class FormCadProduto : Form
    {

        private ProdutoDao produtoDao;
        private Produto produto;
        public FormCadProduto()
        {
            InitializeComponent();

            produtoDao = new ProdutoDao();
            produto = new Produto();

            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;

            PreencherComboBoxHelper.PreencherComboboxDescricao(comboBoxCategoria);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedValue = (comboBoxCategoria.SelectedValue);
            label6.Text = Convert.ToString(selectedValue);

            if (produto == null)
            {
                produto = new Produto();
            }

            //  if (Validar())
            //  {
            produto.CodigoFabricacao = textEditCodigoFabricacao.Text;
            produto.NomeProduto = textEditNomeProduto.Text;
            produto.Categoria = (string)selectedValue;

            produto.Peso = Convert.ToDouble(textEditPeso.Text);


            produtoDao.Salvar(produto);
            //   }
            //  textEditID.Text = RetornaProximoCodigoHelper.RetornaProximoCodigo().ToString();

            //     AtualizarDataGridViewHelper.DisplayData(dataGridView1);

            // FormCadCategoria.LimparTela();



        }

        private void textEditID_KeyPress(object sender, KeyPressEventArgs e)
        {
            SomenteNumerosHelper.SomenteNumeros(e);
        }
    }
}

