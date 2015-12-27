using PROJETOMODELODDD.DOMINIO.Entidades;
using System.Collections.Generic;
using PROJETOMODELODDD.DOMINIO.Interfaces;




namespace PROJETOMODELODDD.DOMINIO.Interfaces.Servicos
{

    public interface IProdutoServico : IServicoBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
