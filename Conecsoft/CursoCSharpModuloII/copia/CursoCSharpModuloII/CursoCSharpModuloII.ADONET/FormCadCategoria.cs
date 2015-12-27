using CursoCSharpModuloII.ADONET.Dados;
using CursoCSharpModuloII.ADONET.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharpModuloII.ADONET
{
    public partial class FormCadCategoria : Form
    {
        private CategoriaDao categoriaDao;
        private Categoria categoria;

        public FormCadCategoria()
        {
            InitializeComponent();
            categoriaDao = new CategoriaDao();
            categoria = new Categoria();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (categoria == null)
            {
                categoria = new Categoria();
            }

            categoria.Codigo = codigoTextBox.Text;
            categoria.Descricao = descricaoTextBox.Text;
            categoriaDao.Salvar(categoria);

            LimparTela();
        }

        private void LimparTela()
        {
            codigoTextBox.Text = "";
            descricaoTextBox.Text = "";
            idNumericUpDown.Focus();
        }

        private void idNumericUpDown_Validated(object sender, EventArgs e)
        {
            categoria = categoriaDao.Obter(Convert.ToInt32(idNumericUpDown.Value));

            if (categoria != null)
            {
                codigoTextBox.Text = categoria.Codigo;
                descricaoTextBox.Text = categoria.Descricao;
            }
            else
            {
                MessageBox.Show("Código não encontrado");
            }
        }
    }
}
