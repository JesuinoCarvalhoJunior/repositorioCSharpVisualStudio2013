using PrimeraAplicacaoNHibernate.Dominio;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace PrimeraAplicacaoNHibernate.Teste
{
    [TestFixture]
    public class TesteQueGeraSchema
    {
        [Test]
        public void GereSchema()
        {
            var cfg = new Configuration();
            cfg.Configure();

            cfg.AddAssembly(typeof(Categoria).Assembly);

            new SchemaExport(cfg).Execute(true, true, false);
        }
    }
}
