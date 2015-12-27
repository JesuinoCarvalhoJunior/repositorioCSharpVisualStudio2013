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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorioDataSet.Paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.consultorioDataSet.Paciente);
            // TODO: This line of code loads data into the 'consultorioDataSet.Medico' table. You can move, or remove it, as needed.
            this.medicoTableAdapter.Fill(this.consultorioDataSet.Medico);
            // TODO: This line of code loads data into the 'consultorioDataSet.Consulta' table. You can move, or remove it, as needed.
            this.consultaTableAdapter.Fill(this.consultorioDataSet.Consulta);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmConsulta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

        }
    }
}
