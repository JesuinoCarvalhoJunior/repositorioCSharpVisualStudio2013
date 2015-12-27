namespace PrimeraAplicacaoNHibernate.Controladores
{
    public interface IControladorDaTelaFormularioDePessoa
    {
        void UsuarioClicouEmNovo();
        void UsuarioClicouEmEditar();
        void UsuarioClicouEmRemover();
        void UsuarioClicouEmSalvar();
        void Inicialize();
        void LimpeECarregueLista();
        void UsuarioSelecionouItem();
    }
}