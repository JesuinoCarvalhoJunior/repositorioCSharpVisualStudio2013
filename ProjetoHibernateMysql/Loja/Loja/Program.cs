using Loja.DAO;
using Loja.Dominio_DAO;
//using Loja.Dominio_DAO;
using Loja.Entidades;
using Loja.Infraestrutura;
//using Loja.Repositorio_Entidades;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Loja
{
    class Program
    {

        static void Main(string[] args)
        {   
            // cria tabelas no BD
            //  NhibernateHelper.GeraSchema();
             // Console.ReadKey();


            // InsereUsuario();

            // InsereCategoria();

            // InsereProduto();

            // ListadeProdutos();

            // SelectProduto();

            // ContarProduto();

            // ProblemaQueries();

            // BuscaDinamica();

            // OtimizandoConsultaUsandoCache();

            // VendaProduto();

        }




        public static void InsereUsuario()
        {
            /*
            // abre session
            ISession session = NhibernateHelper.AbreSession();

            // passa a session para o parametro no construtor da clase
            UsuarioDAO usuarioDAO = new UsuarioDAO(session);

            // Usuario = tabela
            Usuario novoUsuario = new Usuario();
            novoUsuario.Nome = "Jr";

            usuarioDAO.Adiciona(novoUsuario);

            session.Close();
            Console.Read();
            */
        }

        public static void InsereProduto()
        {
            ISession session = NhibernateHelper.AbreSession();

            // passa a session para o parametro no construtor da clase
            ProdutoDAO produtoDAO = new ProdutoDAO(session);

            ///
            Categoria umaCategoria = new Categoria();
            umaCategoria.Nome = "Pesca";


            // Usuario = tabela
            Produto novoProduto = new Produto();
            novoProduto.Nome = "Bola";
            novoProduto.Preco = 15;
            novoProduto.Categoria = umaCategoria;

            session.Save(umaCategoria);
            produtoDAO.Adiciona(novoProduto);


            session.Close();
            Console.Read();
        }

        public static void InsereCategoria()
        {
            ISession session = NhibernateHelper.AbreSession();

            // passa a session para o parametro no construtor da clase
            CategoriaDAO categoriaDAO = new CategoriaDAO(session);

            // Categoria = tabela
            Categoria novaCategoria = new Categoria();
            novaCategoria.Nome = "Esporte";

            categoriaDAO.Adiciona(novaCategoria);

            session.Close();
            Console.Read();
        }

        public static void ListadeProdutos()
        {

            ISession session = NhibernateHelper.AbreSession();
            ITransaction transacao = session.BeginTransaction();

            /// (1)  = id na tabela Produto
            Categoria categoria = session.Load<Categoria>(1);
            //IList<Produto> produtos = categoria.Produtos;

            Console.WriteLine(categoria.Produtos.Count);

            transacao.Commit();
            session.Close();
            Console.Read();

        }

        public static void SelectProduto()
        {

            ISession session = NhibernateHelper.AbreSession();

            String hql = "from Produto p where p.Preco > :preco and p.Categoria.Nome = :categoria";

            // cria a query
            IQuery query = session.CreateQuery(hql);

            query.SetParameter("preco", 10);
            query.SetParameter("categoria", "Esporte");

            // armazena produtos numa lista para exibicao

            IList<Produto> produtos = query.List<Produto>();

            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto.Nome);

            }
            session.Close();
            Console.Read();
        }

        /// <summary>
        /// utilizando Alias To Bean
        /// </summary>
        public static void ContarProduto()
        {
            ISession session = NhibernateHelper.AbreSession();

            String hql = "select p.Categoria as Categoria, count(p) as NumeroDePedidos from Produto p Group By p.Categoria";

            // cria a query
            IQuery query = session.CreateQuery(hql);

            query.SetResultTransformer(Transformers.AliasToBean<ProdutosPorCategoria>());

            IList<ProdutosPorCategoria> relatorio = query.List<ProdutosPorCategoria>();

            session.Close();
            Console.Read();
        }

        public class ProdutosPorCategoria
        {
            public Categoria Categoria { get; set; }
            public long NumeroDePedidos { get; set; }

        }

        /// <summary>
        /// select com solucao para o problema N + 1 Queries
        /// </summary>
        public static void ProblemaQueries()
        {
            ISession session = NhibernateHelper.AbreSession();

            IQuery query = session.CreateQuery("select distinct c from Categoria c join fetch c.Produtos");

            IList<Categoria> categorias = query.List<Categoria>();

            foreach (var categoria in categorias)
            {
                Console.WriteLine(categoria.Nome + " - " + categoria.Produtos.Count);
            }

            session.Close();
            Console.Read();
        }

        public static void BuscaDinamica()
        {

            ISession session = NhibernateHelper.AbreSession();

            ProdutoDAO produtoDAO = new ProdutoDAO(session);

            //    IList<Produto> produtos = produtoDAO.BuscaPorNomePrecoMinimoECategoria("", 0, "");
            // ou
            //     IList<Produto> produtos = produtoDAO.BuscaPorNomePrecoMinimoECategoria("", 0, "Laser");
            // ou
            IList<Produto> produtos = produtoDAO.BuscaPorNomePrecoMinimoECategoria("Bola", 0, "");

            foreach (var produto in produtos)
            {
                Console.WriteLine("Nome: " + produto.Nome + " Preco: " + produto.Preco.ToString() + " Categoria: " + produto.Categoria.Nome);
            }

            session.Close();
            Console.Read();

        }

        public static void OtimizandoConsultaUsandoCache()
        {

            //ISession session = NhibernateHelper.AbreSession();

            // get = cache de primeiro nivel.
            // cache de primeiro nivel não muito efetivo, desempenho ruim
            // Categoria c = session.Get<Categoria>(1);

            // uma requisicao
            ISession session = NhibernateHelper.AbreSession();
            //outra requisicao
            ISession session2 = NhibernateHelper.AbreSession();

            // atende a primeira requisicao
            session.CreateQuery("from Usuario").SetCacheable(true).List<Usuario>();

            // atende a segunda requisicao
            session.CreateQuery("from Usuario").SetCacheable(true).List<Usuario>();

            // resulta é que como havia cache da primeira requisicao, na segunda foi aproveitado o chache


            session.Close();
            Console.Read();

        }

        public static void VendaProduto()
        {

            ISession session = NhibernateHelper.AbreSession();
            ITransaction transacao = session.BeginTransaction();

            Venda venda = new Venda();
            // tabela Usuario , Id =  1
            Usuario cliente = session.Get<Usuario>(1);
            venda.Cliente = cliente;

            Produto p1 = session.Get<Produto>(1);
            Produto p2 = session.Get<Produto>(2);

            venda.Produtos.Add(p1);
            venda.Produtos.Add(p2);

            session.Save(venda);

            transacao.Commit();
            session.Close();

            Console.Read();
        }


    }


}
