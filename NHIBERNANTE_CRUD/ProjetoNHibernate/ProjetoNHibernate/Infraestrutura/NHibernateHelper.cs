using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.hbm2ddl;
using System.Reflection;

namespace ProjetoNHibernate.Infraestrutura
{
    class NHibernateHelper
    {
        // isolando class Configuration
        public static Configuration RecuperaCnfiguracao()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());


            return cfg;
        }

        // gerar as tabelas no BD
        public static void GeraSchema()
        {
            Configuration cfg = RecuperaCnfiguracao();
            // true, true = imprimir e executar no BD
            new SchemaExport(cfg).Create(true, true);
        }
    }
}
