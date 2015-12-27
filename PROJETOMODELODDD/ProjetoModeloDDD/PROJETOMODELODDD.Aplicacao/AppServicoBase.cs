
using System;
using System.Collections.Generic;
using PROJETOMODELODDD.Aplicacao.Interface;
using PROJETOMODELODDD.DOMINIO.Interfaces.Servicos;

namespace PROJETOMODELODDD.Aplicacao
{

    // implementa contrato generico de ServicoBase
    public class AppServicoBase<TEntity> : IDisposable, IAppServicoBase<TEntity> where TEntity : class
    {

        // classe aplicacao conversao com Dominio e chama a classe de servicos

        private readonly IServicoBase<TEntity> _servicoBase;


        public AppServicoBase(IServicoBase<TEntity> servicoBase)
        {
            _servicoBase = servicoBase;
        }


        public void Add(TEntity objeto)
        {
            _servicoBase.Add(objeto);
        }

        public TEntity GetById(int id)
        {
            return _servicoBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _servicoBase.GetAll();
        }

        public void Update(TEntity objeto)
        {
            _servicoBase.Update(objeto);
        }

        public void Remove(TEntity objeto)
        {
            _servicoBase.Remove(objeto);
        }

        public void Dispose()
        {
            _servicoBase.Dispose();
        }
    }
}
