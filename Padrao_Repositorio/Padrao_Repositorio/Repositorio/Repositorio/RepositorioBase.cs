using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Repositorio.Repositorio
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        internal Contexto.Contexto _contexto;
        internal DbSet<TEntity> _dbSet;

        public RepositorioBase(Contexto.Contexto contexto)
        {
            this._contexto = contexto;
            this._dbSet = contexto.Set<TEntity>();
        }

        public void Inserir(TEntity entity)
        {
            _dbSet.Add(entity);
            _contexto.SaveChanges();
        }
        /// <summary> 
        /// Método que adiciona uma lista de novos objetos ao banco de dados da aplicação. 
        /// </summary> 
        public void InserirTodos(List<TEntity> entity)
        {
            foreach (var item in entity)
            {
                _dbSet.Add(item);
            }
            _contexto.SaveChanges();
        }

        public void Editar(TEntity entity)
        {
            var entrada = _contexto.Entry<TEntity>(entity);
            var pkey = _dbSet.Create().GetType().GetProperty("id").GetValue(entity);

            if (entrada.State == EntityState.Detached)
            {
                var set = _contexto.Set<TEntity>();
                TEntity attachedEntity = set.Find(pkey); // acesso a pk
                if (attachedEntity != null)
                {
                    var attachedEntry = _contexto.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(entity);
                }
                else
                {
                    entrada.State = EntityState.Modified; // entidade anexada
                }

            }

            _contexto.SaveChanges();
        }

        /// <summary> 
        /// Método que deleta um objeto no banco de dados da aplicação. 
        /// </summary> 
        public void Deletar(TEntity entity)
        {
            if (_contexto.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
            _contexto.SaveChanges();
        }

        /// <summary> 
        /// Método que deleta um ou varios objetos no banco de dados da aplicação, mediante uma expressão LINQ. 
        /// </summary> 
        public void DeletarTodos(Expression<Func<TEntity, bool>> filtro = null)
        {
            IQueryable<TEntity> query = _dbSet;

            List<TEntity> listaDeletar = query.Where(filtro).ToList();

            foreach (var item in listaDeletar)
            {
                _dbSet.Remove(item);
            }
            _contexto.SaveChanges();
        }

        /// <summary> 
        /// Método que busca uma lista de objetos no banco de dados da aplicação e retorna-a 
        /// no tipo IEnumerable<TEntity>. 
        /// </summary> 
        public virtual List<TEntity> Get(Expression<Func<TEntity, bool>> filtro = null, Func<IQueryable<TEntity>,
            IOrderedQueryable<TEntity>> orderby = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (filtro != null)
            {
                query = query.Where(filtro);
            }

            if (orderby != null)
            {
                return orderby(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }


        public void Dispose()
        {
            _dbSet = null;
            _contexto.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
