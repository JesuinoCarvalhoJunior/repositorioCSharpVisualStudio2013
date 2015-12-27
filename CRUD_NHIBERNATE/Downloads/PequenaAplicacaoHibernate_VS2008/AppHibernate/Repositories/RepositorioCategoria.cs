using System;
using System.Collections.Generic;
using System.Text;
using PrimeraAplicacaoNHibernate.Dominio;
using NHibernate;
using NHibernate.Criterion;

namespace PrimeraAplicacaoNHibernate.Repositories
{
    public class RepositorioCategoria : IRepositorioCategoria
    {
        public void Add(Categoria categoria)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(categoria);
                transaction.Commit();
            }
        }

        public void Update(Categoria categoria)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(categoria);
                transaction.Commit();
            }
        }

        public void Remove(Categoria categoria)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(categoria);
                transaction.Commit();
            }
        }

        public Categoria GetById(Guid productId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Categoria>(productId);
        }

        public ICollection<Categoria> GetList()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var categorias = session.CreateCriteria(typeof(Categoria)).List<Categoria>();
                return categorias;
            }
        }

        public Categoria GetByDescricao(string descricao)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Categoria product = session
                    .CreateCriteria(typeof(Categoria))
                    .Add(Restrictions.Eq("Descricao", descricao))
                    .UniqueResult<Categoria>();
                return product;
            }
        }

        public bool PodeSerRemovida(Categoria categoria)
        {
            var hql = new StringBuilder();
            long resultado;

            hql.AppendFormat("select count(p) FROM {0} p ", typeof(Pessoa))
                .AppendFormat("WHERE p.Categoria.Id = :categoriaId");
            
            using (var session = NHibernateHelper.OpenSession())
            {
                resultado = (long)session.CreateQuery(hql.ToString())
                    .SetString("categoriaId", categoria.Id.ToString())
                    .UniqueResult();
            }

            return resultado > 0 ? false : true;
        }
    }
}