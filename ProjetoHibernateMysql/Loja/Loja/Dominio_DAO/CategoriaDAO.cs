using Loja.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.Dominio_DAO
{
    class CategoriaDAO
 {
      // cria session para clase

        private ISession session;

        // abre a session  no construtor da classe com a session recebida no parametro "session"
        public CategoriaDAO(ISession session)
        {
            this.session = session;
        }
        // add categoria na tabela Categoria
        public void Adiciona(Categoria categoria)
        {
            ITransaction transacao = session.BeginTransaction();
            session.Save(categoria);
            transacao.Commit();
        }
        /// <summary>
        /// busca Produto no bd
        /// </summary>
        /// <param name="id"></param>
        public Categoria BuscarPorId(int id)
        {
            return session.Get<Categoria>(id);
        }

    }

}
