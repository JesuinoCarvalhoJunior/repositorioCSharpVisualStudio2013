using System.Reflection;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace ArqTransfer.Repositorio.Helpers
{
    // Classe responsável por recuperar as sessões do NHibernate
    public class NHibernateHelper
    {

        private static ISessionFactory
       _sessionFactory;

        private static ISessionFactory
        SessionFactory()
        {
            return SessionFactory(false);
        }

        private static ISessionFactory
        SessionFactory(bool createDatabase)
        {
            // Se a sessão já existir, retorná-la
            if (_sessionFactory !=
            null && !createDatabase)
                return _sessionFactory;

            // Aqui o NHibernate vai procurar
            // as configurações no
            // arquivo "NHibernate.config"
            var config = new Configuration();
            config.Configure();
            config.AddAssembly(Assembly.GetExecutingAssembly());
            

            // Criar DataBase
            if (createDatabase)
            {
                var schemaExport =
                new SchemaExport(config);
                
                schemaExport.Drop(true, true);
                schemaExport.Create(true, true);
            }

            _sessionFactory = config.BuildSessionFactory();

            return _sessionFactory;
        }

        public static ISession OpenSession()
        {
            return SessionFactory().OpenSession();
        }

        public static ISession OpenSession
        (bool createDatabase)
        {
            return SessionFactory(createDatabase).
            OpenSession();
        }
    }
}