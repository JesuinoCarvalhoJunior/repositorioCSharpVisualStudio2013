using System;
using System.Windows.Forms;
using PrimeraAplicacaoNHibernate.Controladores;

namespace PrimeraAplicacaoNHibernate.Telas
{
    public partial class FormularioPrincipal : Form, IFormularioPrincipal
    {
        private readonly IControladorDaTelaFormularioPrincipal _controlador;

        public FormularioPrincipal()
        {
            InitializeComponent();

            _controlador = new ControladorDaTelaFormularioPrincipal(this);
        }

        private void btCategoria_Click(object sender, EventArgs e)
        {
            _controlador.UsuarioClicouNoBotaoDeCategoria();
            
        }

        private void btPessoa_Click(object sender, EventArgs e)
        {
            _controlador.UsuarioClicouNoBotaoDePessoa();
        }

        public void MostreTelaDeCategoria()
        {
            new FormularioDeCategoria().ShowDialog();
        }

        public void MostreTelaDePessoa()
        {
            new FormularioDePessoa().ShowDialog();
        }
    }
}