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
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void frmPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void pacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorioDataSet.Paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.consultorioDataSet.Paciente);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
