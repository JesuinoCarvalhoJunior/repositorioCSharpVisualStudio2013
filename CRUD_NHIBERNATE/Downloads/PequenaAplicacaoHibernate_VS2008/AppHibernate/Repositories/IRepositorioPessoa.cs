using System;
using System.Collections.Generic;
using PrimeraAplicacaoNHibernate.Dominio;

namespace PrimeraAplicacaoNHibernate.Repositories
{
    public interface IRepositorioPessoa
    {
        void Add(Pessoa pessoa);
        void Update(Pessoa pessoa);
        void Remove(Pessoa pessoa);
        Pessoa GetById(Guid pessoaId);
        Pessoa GetByNome(string nome);
        ICollection<Pessoa> GetByCategory(Categoria categoria);
        ICollection<Pessoa> GetList();
    }
}