
using System.Collections.Generic;
using PROJETOMODELODDD.DOMINIO.Entidades;
using PROJETOMODELODDD.DOMINIO.Interfaces.Repositorios;
using PROJETOMODELODDD.DOMINIO.Interfaces.Servicos;

namespace PROJETOMODELODDD.DOMINIO.Servicos
{
    public class ProdutoServico : ServicoBase<Produto>, IProdutoServico

    {

        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
             : base(produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        // busca por injecao de dependencia
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepositorio.BuscarPorNome(nome);
        }
    }
}
