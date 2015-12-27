using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            tmRelogio_Tick(null, null);
        }

        // Data & Hora no StatusBar
        private void tmRelogio_Tick(object sender, EventArgs e)
        {
            StatusData.Text = DateTime.Now.ToShortDateString();
            StatusHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormCalculadora frmCalc = new FormCalculadora();
            frmCalc.ShowDialog(this);

        }
    }
}
