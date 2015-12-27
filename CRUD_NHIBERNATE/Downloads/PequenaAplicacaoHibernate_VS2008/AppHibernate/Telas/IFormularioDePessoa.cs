using System.Collections.Generic;
using PrimeraAplicacaoNHibernate.Dominio;

namespace PrimeraAplicacaoNHibernate.Telas
{
    public interface IFormularioDePessoa : IFormularioBasico
    {
        void LimpeListagemDePessoas();
        void PreenchaListaComPessoas(ICollection<Pessoa> listaDePessoa);
        void DesabiliteCampos();
        void HabiliteCampos();
        Pessoa ObtenhaItemSelecionado();
        void LimpeCampos();
        void RemovaItemDaListagem(Pessoa pessoa);

        void ConfigureEstadoDeListagem();
        void ConfigureEstadoDeNovoOuEditando();
        void ConfigureEstadoDeItemSelecionado();

        string Nome { get; set; }
        string Sobrenome { get; set; }
        string DataNascimento { get; set; }
        bool Sexo { get; set; }
        Categoria Categoria { get; set; }
        void CarregueListaCategorias(ICollection<Categoria> listaDeCategorias);
    }
}