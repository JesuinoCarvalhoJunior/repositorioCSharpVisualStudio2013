namespace PrimeraAplicacaoNHibernate.Controladores
{
    public interface IControladorDaTelaFormularioDeCategoria
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