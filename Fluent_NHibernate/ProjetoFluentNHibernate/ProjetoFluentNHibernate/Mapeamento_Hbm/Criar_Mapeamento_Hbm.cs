using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoFluentNHibernate.Entidades;
using NHibernate;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;

namespace ProjetoFluentNHibernate.Mapeamento_Hbm
{
    class Criar_Mapeamento_Hbm
    {
        /// <summary>
        /// Para aqueles que gostam de usar os mapeamentos via XML,
        /// o fluent tem a opção de gerar esses arquivos automaticamente, 
        /// veja abaixo o código
        /// </summary>
        public static void CriarMapeamentoHbm()
        {

            FluentConfiguration config = Fluently.Configure()
           .Database(MsSqlConfiguration.MsSql2008.ConnectionString(
           x => x.FromConnectionStringWithKey("ConexaoBanco")).ShowSql())
                //.ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
           .Mappings(x => x.FluentMappings.AddFromAssemblyOf<Pessoa>
               ().ExportTo("C:\\Aprendendo_C#\\Fluent_NHibernate\\ProjetoFluentNHibernate\\ProjetoFluentNHibernate\\Mapeamento_Hbm"));

            config.BuildSessionFactory();


        }
    }
}
