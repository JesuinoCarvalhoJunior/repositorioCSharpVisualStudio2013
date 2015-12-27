using System;
using System.Collections.Generic;
using PrimeraAplicacaoNHibernate.Dominio;

namespace PrimeraAplicacaoNHibernate.Repositories
{
    public interface IRepositorioCategoria
    {
        void Add(Categoria categoria);
        void Update(Categoria categoria);
        void Remove(Categoria categoria);
        Categoria GetById(Guid categoriaId);
        Categoria GetByDescricao(string descricao);
        ICollection<Categoria> GetList();
        bool PodeSerRemovida(Categoria categoria);
    }
}