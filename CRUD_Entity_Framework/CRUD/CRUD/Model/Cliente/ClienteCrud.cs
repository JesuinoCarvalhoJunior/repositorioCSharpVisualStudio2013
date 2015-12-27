using System;
using CRUD.Model.ExemploDBContext;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Data;
using System.Text;

namespace CRUD.Model.Cliente
{
    public class ClienteCrud
    {

        DbContextExemplo db = new DbContextExemplo();

        public void InsertOrUpdate(ClienteModel cliente)
        {        {
            try
            {
                db.Entry(ClienteModel).State = cliente.id == 0 ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var clinte = db.Clientes.Find(id);
                db.Clientes.Remove(clinte);
                db.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}