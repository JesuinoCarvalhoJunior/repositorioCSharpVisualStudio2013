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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmMedico medico = new frmMedico();
            medico.ShowDialog();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmPaciente paciente = new frmPaciente();
            paciente.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta();
            consulta.ShowDialog();
        }


    }
}
