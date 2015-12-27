using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArqTransfer.Dominio.Repositorios.Interface;
using ArqTransfer.Dominio.Entidades;
using ArqTransfer.Repositorio.Helpers;
using NHibernate;
using NHibernate.Linq;

namespace ArqTransfer.Repositorio.Repositorios
{
    public class PastaRepositorio : RepositorioBase<Pasta>, IPastaRepositorio
    {
   
        public Pasta RetornaPastaporCaminho(string caminho)
        {
            using (ISession session =
             NHibernateHelper.OpenSession())
            {
                IList<Pasta> pastas =
                (from p in session.Query<Pasta>()
                 where p.Caminho == caminho
                 select p).ToList();

                if (pastas.Count > 0)
                    return pastas.First();

                return null;
            }
        }
    }
}
