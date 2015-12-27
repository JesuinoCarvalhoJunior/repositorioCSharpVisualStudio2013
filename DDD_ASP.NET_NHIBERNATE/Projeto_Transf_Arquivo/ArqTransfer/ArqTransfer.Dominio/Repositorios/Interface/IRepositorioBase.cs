using System.Collections.Generic;
using ArqTransfer.Dominio.Entidades.Interface;

namespace ArqTransfer.Dominio.Repositorios.Interface
{
    // REPOSITORIO GENERICO
    //T é um IEntidade, o que significa que esse repositório pode ser utilizado 
    //por qualquer entidade do nosso domínio.
    public interface IRepositorioBase<T> where T : IEntidade
    {
        //retorna Entidade atraves do ID informado
        T Retorna(long id);

        // retorno Todas as Entidades
        IList<T> RetornaTodosList();

        //Salva a Entidade (insert ou update)
        T Salva(T entity);

        // Exclui uma Entidade
        void Excluir(T entity);

     }
}
