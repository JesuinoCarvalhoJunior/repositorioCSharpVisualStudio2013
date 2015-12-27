
using System.Collections.Generic;
using System.Linq;
using PROJETOMODELODDD.DOMINIO.Entidades;
using PROJETOMODELODDD.DOMINIO.Interfaces.Repositorios;


namespace PROJETOMODELODDD.INFRA.DADDOS.Repositorio
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IProdutoRepositorio
    {
        // implementacao especilizada do IProdutoRepositorio
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);

        }
    }
}
