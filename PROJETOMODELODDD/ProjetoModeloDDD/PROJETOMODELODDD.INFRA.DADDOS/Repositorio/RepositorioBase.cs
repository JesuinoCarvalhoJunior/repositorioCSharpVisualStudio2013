using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJETOMODELODDD.DOMINIO.Interfaces;
using PROJETOMODELODDD.INFRA.DADDOS.Contexto;
using System.Data.Entity;

namespace PROJETOMODELODDD.INFRA.DADDOS.Repositorio
{
    // REPOSITORIO GENERICO
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        // instancia o contexto para poder usar nos metodos que o contrato implementou
        protected ProjetoModeloDDDContexto Db =  new ProjetoModeloDDDContexto();

        public void Add(TEntity objeto)
        {
            Db.Set<TEntity>().Add(objeto);
            Db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
          return Db.Set<TEntity>().Find(id);
           
        }

        public IEnumerable<TEntity>GetAll()
        {
             // dessa maneria otimiza a consulta pois desabilita Lazzy Load
            //return Db.Set<TEntity>.AsNoTracking().ToList();

            return Db.Set<TEntity>().ToList();
        }

        public void Update(TEntity objeto)
        {
            Db.Entry(objeto).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity objeto)
        {
            Db.Set<TEntity>().Remove(objeto);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
