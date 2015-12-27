using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoFluentNHibernate.Entidades;

namespace ProjetoFluentNHibernate.Repositorio
{
    public class Pesquisar_PessoaFisica
    {
        public static void PesquisaPessoaFisica()
        {

            var sessionFactory = Conexao.ConexaoBD.CriarSessionFactory();
            using (var session = sessionFactory.OpenSession())
            {
                var ppf = session.Get<PessoaFisica>(1);

             //   Assert.IsNotNull(ppf);

            //    Assert.IsTrue(ppf.Telefones.Count > 0);


            }

        }
    }
}
