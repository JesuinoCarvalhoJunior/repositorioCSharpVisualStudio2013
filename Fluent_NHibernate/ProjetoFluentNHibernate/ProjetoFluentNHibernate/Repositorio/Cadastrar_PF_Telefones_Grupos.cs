using ProjetoFluentNHibernate.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Repositorio
{
    public class Cadastrar_PF_Telefones_Grupos
    {
        public static void CadatrarPF_TelefonesGrupos()
        {
            var sessionFactory = Conexao.ConexaoBD.CriarSessionFactory();

            using (var session = sessionFactory.OpenSession())
            {
                using (var transacao = session.BeginTransaction())
                {
                    PessoaFisica pf = new PessoaFisica();

                    pf.Nome = "sthe";
                    pf.Endereco = "Rua A";
                    pf.Cep = "78000000";
                    pf.Email = "@@";
                    pf.DataCadastro = DateTime.Now;
                    pf.Cpf = "1230";
                    pf.Nacionalidade = "Brasil";

                    pf.Departamento = session.Get<Departamento>(2);

                    pf.Status = Status.Bloqueado;

                    //Criamos uma nova instância da classe Telefone e adicionamos na propriedade Telefones que é uma lista
                    pf.Telefones.Add(new Telefone()
                    {
                        CodigoDdd = 65,
                        Numero = 12345678

                    });

                    pf.Telefones.Add(new Telefone()
                    {
                        CodigoDdd = 00,
                        Numero = 1234
                    });


                    // lista de Grupos
                    pf.Grupos.Add(session.Get<Grupo>(1));
                    pf.Grupos.Add(session.Get<Grupo>(2));

                    session.SaveOrUpdate(pf);
                    transacao.Commit();
                }
            }


        }

    }
}
