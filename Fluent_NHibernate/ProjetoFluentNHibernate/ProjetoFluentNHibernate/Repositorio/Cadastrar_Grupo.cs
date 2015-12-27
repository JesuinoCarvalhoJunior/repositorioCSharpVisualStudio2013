using ProjetoFluentNHibernate.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Repositorio
{
    public class Cadastrar_Grupo
    {

        public static void CadastrarGrupo()
        {
            var sessionFactory = Conexao.ConexaoBD.CriarSessionFactory();

            using (var session = sessionFactory.OpenSession())
            {
                using (var transacao = session.BeginTransaction())
                {
                    Grupo obj = new Grupo();

                    obj.Nome = "Grupo3";
                    obj.Descricao = "Descricao Grupo 3";
                    obj.DataCadastro = DateTime.Now;

                    session.Save(obj);

                    Grupo obj2 = new Grupo();

                    obj2.Nome = "Grupo4";
                    obj2.Descricao = "Descricao Grupo 4";
                    obj2.DataCadastro = DateTime.Now;

                    session.Save(obj2);

                    transacao.Commit();
                }
            }
        }
    }
}

