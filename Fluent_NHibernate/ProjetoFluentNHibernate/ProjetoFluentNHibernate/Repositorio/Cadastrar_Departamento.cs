using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoFluentNHibernate.Conexao;
using ProjetoFluentNHibernate.Entidades;


namespace ProjetoFluentNHibernate.Repositorio
{
    public class Cadastrar_Departamento
    {
        public static void CadastrarDepartamento()
        {
            // cria conexao com bd
            var sessionFactory = Conexao.ConexaoBD.CriarSessionFactory();
            // abre a conexao
            using (var session = sessionFactory.OpenSession())
            {
                // abre a transacao
                using (var transaction = session.BeginTransaction())
                {
                    Departamento depto = new Departamento();
                    depto.Nome = "Diretoria";
                    depto.Descricao = "Departamento diretoria";
                    depto.DataCadastro = DateTime.Now;

                    session.Save(depto);


                    Departamento depto2 = new Departamento();
                    depto2.Nome = "Comercial";
                    depto2.Descricao = "Departamento comercial";
                    depto2.DataCadastro = DateTime.Now;

                    //salva o objeto
                    session.Save(depto2);
                    // comita os dados 
                    transaction.Commit();
                }
            }
        }

    }
}
