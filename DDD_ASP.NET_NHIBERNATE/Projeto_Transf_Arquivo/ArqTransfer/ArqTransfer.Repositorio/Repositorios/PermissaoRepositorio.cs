using ArqTransfer.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArqTransfer.Dominio.Repositorios.Interface;
using ArqTransfer.Repositorio.Helpers;
using NHibernate;
using NHibernate.Linq;

namespace ArqTransfer.Repositorio.Repositorios
{
    public class PermissaoRepositorio : RepositorioBase<Permissao>, IPermissaoRepositorio
    {
        public IList<Permissao> RetornaPermissaosDoUsuario(long userId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return (from p in session.Query<Permissao>()
                        where p.Usuario.Id == userId
                        select p).ToList();

            }
        }

        public Permissao RetornaPermissaoProUsuarioEPasta(long userId, long pastaId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return (from p in session.Query<Permissao>()
                        where p.Usuario.Id == userId && p.Pasta.Id == pastaId
                        select p).SingleOrDefault();
                
            }
        }

        public Permissao RetornaPermissaoPorUsuarioEPasta(long p1, long p2)
        {
            throw new NotImplementedException();
        }
    }
}
