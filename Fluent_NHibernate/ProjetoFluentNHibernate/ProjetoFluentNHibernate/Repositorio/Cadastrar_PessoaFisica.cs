using ProjetoFluentNHibernate.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Repositorio
{
   public class Cadastrar_PessoaFisica
    {
       public static void CadastrarPessoaFisica()
       {
           var sessionFactory = Conexao.ConexaoBD.CriarSessionFactory();
           using (var session = sessionFactory.OpenSession())
           {

               using (var transacao = session.BeginTransaction())
               {
                   PessoaFisica pf = new PessoaFisica();

                   pf.Nome = "Yuri";
                   pf.Endereco = "Cba";
                   pf.Cep = "78";
                   pf.Email = "@";
                   pf.DataCadastro = DateTime.Now;
                   pf.Cpf = "0123";
                   pf.Nacionalidade = "Br";

                   pf.Departamento = session.Get<Departamento>(1);
                   pf.Status = Status.Ativo;

                   session.SaveOrUpdate(pf);
                   transacao.Commit();
               }

           }



       }


    }
}
