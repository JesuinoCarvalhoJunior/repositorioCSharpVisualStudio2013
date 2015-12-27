using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_cliente
{
    public partial class Form_Consulta_Produtos : Form
    {


        public Form_Consulta_Produtos()
        {
            InitializeComponent();
        }





        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Produto.ClassProduto Class = new Produto.ClassProduto();
            dtgrdiviewConsulta.DataSource = Class.ObterProduto(txtboxDescricao.Text);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Form_Cadastro_Produto frmCadProd = new Form_Cadastro_Produto();

            frmCadProd.set_Opcao("I");
            frmCadProd.ShowDialog(this);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = new DataGridViewRow();
            Form_Cadastro_Produto frmCadProd = new Form_Cadastro_Produto();
 
            frmCadProd.set_Opcao("A");
            frmCadProd.Preencher
                (linha.Cells["Id"].Value.ToString(),
                 linha.Cells["Descricao"].Value.ToString(),
                 linha.Cells["Preco"].Value.ToString());
            frmCadProd.ShowDialog(this);
        }

    }
}
