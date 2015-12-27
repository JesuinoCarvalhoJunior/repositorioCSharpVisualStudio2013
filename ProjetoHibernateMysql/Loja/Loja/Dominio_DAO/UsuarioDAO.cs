using Loja.Entidades;
using Loja.Infraestrutura;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.DAO
{
    public class UsuarioDAO
    {
        // cria session para clase

        private ISession session;

        // abre a session  no construtor da classe com a session recebida no parametro "session"
        public UsuarioDAO(ISession session)
        {
            this.session = session;
        }
        
        // add usuario na tabela Usuario
        public void Adiciona(Usuario usuario)
        {
            ITransaction transacao = session.BeginTransaction();
            session.Save(usuario);
            transacao.Commit();

        }        
        /// <summary>
        /// busca usuario no bd
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        public Usuario BuscarPorId(int id)
        {
            return session.Get<Usuario>(id);
        }


    }
}
