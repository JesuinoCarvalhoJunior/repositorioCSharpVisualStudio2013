using PROJETOMODELODDD.DOMINIO.Interfaces;
using PROJETOMODELODDD.DOMINIO.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace PROJETOMODELODDD.DOMINIO.Servicos
{
    public class ServicoBase<TEntity> : IDisposable, IServicoBase<TEntity> where TEntity : class
    {

        private readonly IRepositorioBase<TEntity> _repositorio;
      

        // INJECAO DE DEPENDENCIA MAPEIA A CLASSE CONCRETA
        public ServicoBase(IRepositorioBase<TEntity> repositorio)
        {
            _repositorio = repositorio;
        }

        public void Add(TEntity objeto)
        {
            _repositorio.Add(objeto);
        }

        public TEntity GetById(int id)
        {
            return _repositorio.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositorio.GetAll();
        }

        public void Update(TEntity objeto)
        {
            _repositorio.Update(objeto);
        }

        public void Remove(TEntity objeto)
        {
            _repositorio.Remove(objeto);
        }

        public void Dispose()
        {
            _repositorio.Dispose();

        }
    }
}
