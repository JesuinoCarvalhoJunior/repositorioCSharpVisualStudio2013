using System.Collections.Generic;


namespace PROJETOMODELODDD.DOMINIO.Interfaces.Servicos
{
    public interface IServicoBase<TEntity> where TEntity : class
    {
        //adicionar
        void Add(TEntity objeto);

        // buscar por ID
        TEntity GetById(int id);

        // listar todos
        IEnumerable<TEntity> GetAll();

        //atualizar
        void Update(TEntity objeto);

        //deletar
        void Remove(TEntity objeto);

        // liberar objtos da memoria
        void Dispose();

    }
}
