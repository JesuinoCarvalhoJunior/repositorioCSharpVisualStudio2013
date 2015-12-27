
using System.Collections.Generic;
using PROJETOMODELODDD.Aplicacao.Interface;
using PROJETOMODELODDD.DOMINIO.Entidades;
using PROJETOMODELODDD.DOMINIO.Interfaces.Repositorios;
using PROJETOMODELODDD.DOMINIO.Interfaces.Servicos;

namespace PROJETOMODELODDD.Aplicacao
{
    public class ProdutoAppServicoBase : AppServicoBase<Produto>, IProdutoAppServicoBase
    {

        private readonly IProdutoServico _produtoServico;

        public ProdutoAppServicoBase(IProdutoServico produtoServico)
            : base(produtoServico)
        {
            _produtoServico = produtoServico;
        }


        // busca por injecao de dependencia
        public IEnumerable<Produto> BuscaProNome(string nome)
        {
            return _produtoServico.BuscarPorNome(nome);
        }
    }
}
