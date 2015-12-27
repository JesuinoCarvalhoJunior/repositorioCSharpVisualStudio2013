using System.Collections.Generic;
using PROJETOMODELODDD.DOMINIO.Entidades;


namespace PROJETOMODELODDD.DOMINIO.Interfaces.Repositorios
{
    
    public interface IProdutoRepositorio : IRepositorioBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
