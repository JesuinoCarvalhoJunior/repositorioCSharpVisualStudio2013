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
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {


        public Usuario RetornaPorEmailSenha(string email, string senha)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IList<Usuario> usuarios = (from u in session.Query<Usuario>()
                                           where u.Email == email && u.Senha == senha
                                           select u).ToList();

                // se achou ususario, retorna o primeiro
                if (usuarios.Count > 0)
                    return usuarios.First();

                return null;
            }
        }
    }
}
