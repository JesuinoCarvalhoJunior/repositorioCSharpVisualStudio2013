namespace PROJETOMODELODDD.INFRA.DADDOS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Contexto.ProjetoModeloDDDContexto>
    {
        public Configuration()
        {
            // True = reflita as alteracoes no BD
            AutomaticMigrationsEnabled = true;
        }

        // SEED utilizazdo par popular a BD com dados inciais quando precisar.
        protected override void Seed(Contexto.ProjetoModeloDDDContexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
