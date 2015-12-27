using System.Collections.Generic;
using PrimeraAplicacaoNHibernate.Dominio;

namespace PrimeraAplicacaoNHibernate.Telas
{
    public interface IFormularioDeCategoria : IFormularioBasico
    {
        void LimpeListagemDeCategorias();
        void PreenchaListaComCategorias(ICollection<Categoria> listaDeCategorias);
        void DesabiliteCampos();
        void HabiliteCampos();
        Categoria ObtenhaItemSelecionado();
        void LimpeCampos();
        void RemovaItemDaListagem(Categoria categoria);

        void ConfigureEstadoDeListagem();
        void ConfigureEstadoDeNovoOuEditando();
        void ConfigureEstadoDeItemSelecionado();

        string Descricao { get; set; }
    }
}