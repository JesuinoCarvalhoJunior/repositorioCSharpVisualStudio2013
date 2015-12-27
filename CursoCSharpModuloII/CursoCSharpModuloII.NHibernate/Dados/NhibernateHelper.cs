using CursoCSharpModuloII.NHibernate.Dados.Mapeamento;
using CursoCSharpModuloII.NHibernate.Properties;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloII.NHibernate.Dados
{
    public static class NhibernateHelper
    {
        private static ISessionFactory sessionFactory;

        public static void Configurar()
        {
            FluentConfiguration configuracao = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(Settings.Default.StringConexao)
                .ShowSql())
                .Mappings(c =>
                    c.FluentMappings.AddFromAssemblyOf<CategoriaMap>())
                    .ExposeConfiguration(c => new SchemaUpdate(c).Execute(true, true));

            sessionFactory = configuracao.BuildSessionFactory();
        }

        public static ISession AbrirSessao()
        {
            return sessionFactory.OpenSession();
        }
    }
}
