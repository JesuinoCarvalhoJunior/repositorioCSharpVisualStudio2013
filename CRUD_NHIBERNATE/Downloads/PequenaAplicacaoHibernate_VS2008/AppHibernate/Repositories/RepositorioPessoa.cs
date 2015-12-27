using System;
using System.Collections.Generic;
using PrimeraAplicacaoNHibernate.Dominio;
using NHibernate.Criterion;
using System.Reflection;

namespace PrimeraAplicacaoNHibernate.Repositories
{
    public class RepositorioPessoa : IRepositorioPessoa
    {
        public void Add(Pessoa product)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Save(product);
                transaction.Commit();
            }
        }

        public void Update(Pessoa product)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Update(product);
                transaction.Commit();
            }
        }

        public void Remove(Pessoa product)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Delete(product);
                transaction.Commit();
            }
        }

        public Pessoa GetById(Guid productId)
        {
            using (var session = NHibernateHelper.OpenSession())
                return session.Get<Pessoa>(productId);
        }

        public Pessoa GetByNome(string nome)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var product = session
                    .CreateCriteria(typeof(Pessoa))
                    .Add(Restrictions.Eq("Nome", nome))
                    .UniqueResult<Pessoa>();

                return product;
            }
        }

        public ICollection<Pessoa> GetList()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var pessoas = session.CreateCriteria(typeof(Pessoa)).List<Pessoa>();
                return pessoas;
            }
        }

        public ICollection<Pessoa> GetByCategory(Categoria categoria)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(Pessoa))
                        .CreateCriteria("Categoria", "categoria")
                        .Add(Restrictions.Eq("categoria.Id", categoria.Id))
                    .List<Pessoa>();
                return products;
            }
        }
    }
}