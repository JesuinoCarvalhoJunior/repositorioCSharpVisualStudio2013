using System.Data.Entity;
using Repositorio.Configuracao;
using Repositorio.Dominio;

namespace Repositorio.Contexto
{
    //Classe de contexto é nela que adicionaremos todas as entidades que desejamos manipular em nosso projeto

    public class Contexto : DbContext
    {
        static Contexto()
        {
            Database.SetInitializer<Contexto>(null);
        }

        public Contexto()
            : base("Name=EstudoContext")
        {

        }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteConfiguracao());
        }
    }
}
