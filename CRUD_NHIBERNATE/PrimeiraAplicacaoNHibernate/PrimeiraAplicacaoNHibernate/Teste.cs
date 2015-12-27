using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using PrimeiraAplicacaoNHibernate.Dominio;
using System.Reflection;

namespace PrimeiraAplicacaoNHibernate
{
    [TestFixture]
    public class Teste
    {
        [Test]
        public void testeIniciacao()
        {
            var cfg = new Configuration();
            cfg.Configure();

            cfg.AddAssembly(typeof(Categoria).Assembly);

            new SchemaExport(cfg).Execute(false, true, false);
        }
    }
}