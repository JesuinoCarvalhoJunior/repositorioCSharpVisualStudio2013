using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CursoCSharpModuloII.ADONET.Dados;
using CursoCSharpModuloII.ADONET.Dominio;
using CursoCSharpModuloII.ADONET.Helpers;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;

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

            //  idNumericUpDown.Value = RetornaProximoCodigoHelper.RetornaProximoCodigo().ToString();

            textEditID.Text = RetornaProximoCodigoHelper.RetornaProximoCodigo().ToString();
            //tbTeste.Text = RetornaProximoCodigoHelper.RetornaProximoCodigo().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (categoria == null)
            {
                categoria = new Categoria();
            }

            //  if (Validar())
            //  {
            categoria.Codigo = codigoTextBox.Text;
            categoria.Descricao = descricaoTextBox.Text;
            categoriaDao.Salvar(categoria);
            //   }
            textEditID.Text = RetornaProximoCodigoHelper.RetornaProximoCodigo().ToString();

            AtualizarDataGridViewHelper.DisplayData(dataGridView1);
            LimparTela();
        }
        private  void LimparTela()
        {
            codigoTextBox.Text = "";
            descricaoTextBox.Text = "";
            textEditID.Enabled = true; 
            textEditID.Focus();
        }
        public bool Validar()
        {
            foreach (Control verifica in this.groupBoxCadCategoria.Controls)
            {
                if (verifica.GetType().Equals(typeof(TextBox)) ||
                    verifica.GetType().Equals(typeof(TextEdit)) ||
                    verifica.GetType().Equals(typeof(MaskedTextBox)) ||
                    verifica.GetType().Equals(typeof(ComboBox)))
                {
                    if (verifica.Text == string.Empty)
                    {
                        verifica.BackColor = Color.Yellow;
                    }
                }
            }
            return false;
        }


        //private void idNumericUpDown_Validated(object sender, EventArgs e)
        //{
        //    categoria = categoriaDao.Obter(Convert.ToInt32(idNumericUpDown.Value));

        //    if (categoria != null)
        //    {

        //        codigoTextBox.Enabled = false;
        //        descricaoTextBox.Enabled = false;
        //        codigoTextBox.Text = categoria.Codigo;
        //        descricaoTextBox.Text = categoria.Descricao;

        //    }
        //    else
        //    {
        //        MessageBox.Show("Código não encontrado");
        //        codigoTextBox.Enabled = false;
        //        descricaoTextBox.Enabled = false;
        //        LimparTela();
        //    }
        //}

        private void FormCadCategoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.dB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSet.Categoria);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            codigoTextBox.Enabled = true;
            descricaoTextBox.Enabled = true;
            codigoTextBox.Focus();
            textEditID.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (categoria == null)
            {
                categoria = new Categoria();
            }

            categoriaDao.Excluir(categoria.Id);
            AtualizarDataGridViewHelper.DisplayData(dataGridView1);
            LimparTela();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textEditID_Validated(object sender, EventArgs e)
        {
            categoria = categoriaDao.Obter(Convert.ToInt32(textEditID.Text));

            if (categoria != null)
            {

                codigoTextBox.Enabled = false;
                descricaoTextBox.Enabled = false;
                codigoTextBox.Text = categoria.Codigo;
                descricaoTextBox.Text = categoria.Descricao;

            }
            else
            {
                MessageBox.Show("Código não encontrado");
                codigoTextBox.Enabled = false;
                descricaoTextBox.Enabled = false;
                textEditID.Focus(); LimparTela();
            }
        }

        private void textEditID_KeyPress(object sender, KeyPressEventArgs e)
        {
            SomenteNumerosHelper.SomenteNumeros(e);
        }


    }
}
