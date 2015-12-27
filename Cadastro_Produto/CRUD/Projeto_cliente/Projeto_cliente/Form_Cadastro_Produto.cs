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
    public partial class Form_Cadastro_Produto : Form
    {

        private string stOpcao;
        private int _Old_Id;
        private string _Old_Descricao;
        private decimal _Old_Preco;

        public Form_Cadastro_Produto()
        {
            InitializeComponent();
        }


        public void set_Opcao(string prstOpcao)
        {
            this.stOpcao = prstOpcao;
        }

        public void Limpar()
        {
            // instancia um objeto controle que é da classe frmcadprod
            // foreach roa itens detro de array

            Control controles = this;
            foreach (Control ctr in controles.Controls)
            {
                if (ctr.GetType().ToString().Equals("System.Windows.Forms.TextBox"))
                {
                    ((TextBox)ctr).Text = "";
                }
            }

            if (MessageBox.Show("Deseja Sair?", "Interação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }

        }


        public void Preencher(string Id, String Descricao, string Preco)
        {
            textBoxCodigo.Text = Id;
            textBoxDescricao.Text = Descricao;
            textBoxPreco.Text = Preco;
            
            _Old_Id = int.Parse(Id);
            _Old_Descricao = Descricao;
            _Old_Preco = decimal.Parse(Preco);
        }



        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btConfirmar_Click_1(object sender, EventArgs e)
        {
            Produto.ClassProduto classeProduto = new Produto.ClassProduto();

            classeProduto.Original_Id = int.Parse(textBoxCodigo.Text);
            classeProduto.Origina_Descricao = _Old_Descricao;
            classeProduto.Original_Preco = _Old_Preco;
            classeProduto.Original_Id = _Old_Id;
            classeProduto.Descricao = textBoxDescricao.Text;
            classeProduto.Preco = decimal.Parse(textBoxPreco.Text);

            if (this.stOpcao.Equals("I"))
            {
                classeProduto.Incluir();
                this.Limpar();

            }
            else if (this.stOpcao.Equals("A"))
            {
                classeProduto.Alterar();
                this.Limpar();
            }
            else
            {
                MessageBox.Show("Implementar Exclusao!");
            }
        }

    }
}
