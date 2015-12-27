using System;
using System.Windows.Forms;
using CursoCSharpModuloII.ADONET.View;

namespace CursoCSharpModuloII.ADONET
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formCategoria = new FormCadCategoria();
            formCategoria.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCategoria = new FormCadCategoria();
            formCategoria.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formCadProduto = new FormCadProduto();
            formCadProduto.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCadProduto = new FormCadProduto();
            formCadProduto.ShowDialog();}
    }
}
