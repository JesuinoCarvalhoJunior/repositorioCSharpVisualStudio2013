using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repositorio.Repositorio
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Inserir(TEntity entity);
        void InserirTodos(List<TEntity> entity);
        void Editar(TEntity entity);

        void Deletar(TEntity entity);

        void DeletarTodos(Expression<Func<TEntity, bool>> filtro = null);

        List<TEntity> Get(Expression<Func<TEntity, bool>> filtro = null, Func<IQueryable<TEntity>,
            IOrderedQueryable<TEntity>> orderby = null);

    }
}
