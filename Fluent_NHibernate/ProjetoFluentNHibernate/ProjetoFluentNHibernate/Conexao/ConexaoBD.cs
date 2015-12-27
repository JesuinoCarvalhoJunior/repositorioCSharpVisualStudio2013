using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using ProjetoFluentNHibernate.Entidades;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoFluentNHibernate.Conexao;
using ProjetoFluentNHibernate;

namespace ProjetoFluentNHibernate.Conexao
{
    /// <summary>
    /// classe para realizar a conexãoBD com o banco que retorna uma sessão para que possamos realizar as tarefas no banco
    /// </summary>
   public class ConexaoBD
    {
       
       public static ISessionFactory CriarSessionFactory()
       {
           FluentConfiguration configuracao = Fluently.Configure()
               .Database(MsSqlConfiguration.MsSql2008.ConnectionString(
               x => x.FromConnectionStringWithKey("ConexaoBanco")).ShowSql())
               //.ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
               .Mappings(x => x.FluentMappings.AddFromAssemblyOf<Pessoa>());

           return configuracao.BuildSessionFactory();
       }



        // criar sql
        public static void CriarTabelaBD()
        {
            FluentConfiguration configuracao = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(
                 x => x.FromConnectionStringWithKey("ConexaoBanco")).ShowSql())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<Pessoa>());

            configuracao.BuildSessionFactory();

            MessageBox.Show("Todas as tabelas foram cridas com sucesso!");
        }


        public static void CriarScriptsBanco()
        {
            FluentConfiguration configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(
                            x => x.FromConnectionStringWithKey("ConexaoBanco")).ShowSql())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).SetOutputFile("C:\\Aprendendo_C#\\Fluent_NHibernate\\ProjetoFluentNHibernate\\ProjetoFluentNHibernate\\Script_Sql\\scripts.sql").Create(true, false))
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<Pessoa>());

            configuration.BuildSessionFactory();
        }


    }
}


