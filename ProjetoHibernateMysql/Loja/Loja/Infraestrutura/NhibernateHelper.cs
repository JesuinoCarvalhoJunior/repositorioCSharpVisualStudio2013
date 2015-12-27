using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Loja.Infraestrutura
{
    public class NhibernateHelper
    {
        public static Configuration RecuperarConfiguracao()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());

            return cfg;
        }
        // cria tabela no bd
        public static void GeraSchema()
        {
            Configuration cfg = RecuperarConfiguracao();
            new SchemaExport(cfg).Create(true, true);
        }

        // cria session
        public static ISessionFactory CriaSessionaFactory()
        {
            Configuration cfg = RecuperarConfiguracao();
            return cfg.BuildSessionFactory();
        }

        // inicializa a fabrica
        public static ISessionFactory fabrica = CriaSessionaFactory();

        // abre somente uma sessa para toda aplicacao
        public static ISession AbreSession()
        {
            return fabrica.OpenSession();
        }

    }
}
