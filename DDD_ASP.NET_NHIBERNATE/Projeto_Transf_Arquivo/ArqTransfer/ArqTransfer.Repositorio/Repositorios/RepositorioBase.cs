using System;
using System.Collections.Generic;
using System.Linq;
using ArqTransfer.Dominio.Entidades.Interface;
using ArqTransfer.Dominio.Repositorios.Interface;
using ArqTransfer.Repositorio.Helpers;
using NHibernate;
using NHibernate.Linq;

namespace ArqTransfer.Repositorio.Repositorios
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : IEntidade
    {

        public T Retorna(long id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<T>(id);
        }


        public IList<T> RetornaTodosList()
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return (from t in session.Query<T>() select t).ToList();
        }

        public T Salva(T entity)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(entity);
                    transaction.Commit();
                }
            }
            return entity;
        }

        public void Excluir(T entity)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(entity);
                    transaction.Commit();
                }
            }
        }
    }
}
