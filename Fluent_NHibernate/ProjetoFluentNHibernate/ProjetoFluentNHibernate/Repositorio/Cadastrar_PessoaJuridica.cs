using ProjetoFluentNHibernate.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Repositorio
{
    public class Cadastrar_PessoaJuridica
    {
        public static void CadastarPessoaJuridica()
        {
            var sessionFactory = Conexao.ConexaoBD.CriarSessionFactory();
            using (var session = sessionFactory.OpenSession())
            {
                using (var transacao = session.BeginTransaction())
                {
                    PessoaJuridica obj = new PessoaJuridica();

                    obj.Nome = "a";
                    obj.Endereco = "rua";
                    obj.Cep = "78";
                    obj.Email = "@";
                    obj.DataCadastro = DateTime.Now;
                    obj.Cnpj = "111";
                    obj.WebSite = "www";

                    obj.Departamento = session.Get<Departamento>(2);
                    obj.Status = Status.Inativo;

                    session.SaveOrUpdate(obj);

                    transacao.Commit();

                }
            }
        }
    }
}
