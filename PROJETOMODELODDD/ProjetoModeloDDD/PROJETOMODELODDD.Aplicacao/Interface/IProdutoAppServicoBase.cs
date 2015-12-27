
using System.Collections.Generic;

using PROJETOMODELODDD.DOMINIO.Entidades;

namespace PROJETOMODELODDD.Aplicacao.Interface
{
    public interface IProdutoAppServicoBase : IAppServicoBase<Produto>
    {
        IEnumerable<Produto> BuscaProNome(string nome);
    }
}
