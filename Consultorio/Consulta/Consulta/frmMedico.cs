using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta
{
    public partial class frmMedico : Form
    {
        public frmMedico()
        {
            InitializeComponent();
        }

        private void medicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // validacao de dados
            this.Validate();
            // finaliza edicao
            this.medicoBindingSource.EndEdit();
            // faz atualizacao dos dados
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorioDataSet.Medico' table. You can move, or remove it, as needed.
            // por meio do metod FILL do tableadapter é preenchido o dataset
            this.medicoTableAdapter.Fill(this.consultorioDataSet.Medico);

        }

        private void frmMedico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
