using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoFluentNHibernate.Entidades;

namespace ProjetoFluentNHibernate.Repositorio
{
   public class Deletar_PessoaFisica
    {
       public static void DeletarPessoaFisica()
       {
           var sessionFactory = Conexao.ConexaoBD.CriarSessionFactory();
           using (var session = sessionFactory.OpenSession())
           {
               using (var transacao = session.BeginTransaction())
               {
                   var delpf = session.Get<PessoaFisica>(4);

                   session.Delete(delpf);
                   transacao.Commit();
               }
           }

       }

    }
}
