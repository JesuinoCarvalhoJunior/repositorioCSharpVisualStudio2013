using PrimeraAplicacaoNHibernate.Telas;

namespace PrimeraAplicacaoNHibernate.Controladores
{
    public class ControladorDaTelaFormularioPrincipal : IControladorDaTelaFormularioPrincipal
    {
        private readonly IFormularioPrincipal _tela;

        public ControladorDaTelaFormularioPrincipal(IFormularioPrincipal tela)
        {
            _tela = tela;
        }

        public void UsuarioClicouNoBotaoDeCategoria()
        {
            _tela.MostreTelaDeCategoria();
        }

        public void UsuarioClicouNoBotaoDePessoa()
        {
            _tela.MostreTelaDePessoa();
        }
    }
}