using Loja.Entidades;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.DAO
{
    public class ProdutoDAO
    {
        // cria session para clase

        private ISession session;

        // abre a session  no construtor da classe com a session recebida no parametro "session"
        public ProdutoDAO(ISession session)
        {
            this.session = session;
        }


        // add produto na tabela Produto
        public void Adiciona(Produto produto)
        {
            ITransaction transacao = session.BeginTransaction();
            session.Save(produto);
            transacao.Commit();

        }

        /// <summary>
        /// busca Produto no bd
        /// </summary>
        /// <param name="id"></param>
        public Produto BuscarPorId(int id)
        {
            return session.Get<Produto>(id);
        }


        /// <summary>
        /// Busca com restricoes dinamica usando ICriteria
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="precoMinimo"></param>
        /// <param name="nomeCategoria"></param>
        /// <returns></returns>
        public IList<Produto> BuscaPorNomePrecoMinimoECategoria(string nome, decimal precoMinimo, string nomeCategoria)
        {
            ICriteria criteria = session.CreateCriteria<Produto>();

            // se nao for nulo ou vazio
            // Eq = igual
            if (!String.IsNullOrEmpty(nome))
            {
                criteria.Add(Restrictions.Eq("Nome", nome));

            }

            // GE = faz comparacao se maior ou menor
            if (precoMinimo > 0)
            {
                criteria.Add(Restrictions.Ge("Preco", precoMinimo));
            }

            if (!String.IsNullOrEmpty(nomeCategoria))
            {
                // cria novo criteria devido ao relacionamento
                // Categoria = nome do relacionamento  ::: ver produto.hbm.xml
                ICriteria criteriaCategoria = criteria.CreateCriteria("Categoria");
                criteriaCategoria.Add(Restrictions.Eq("Nome", nomeCategoria));
            }

            return criteria.List<Produto>();
        }
    }
}
