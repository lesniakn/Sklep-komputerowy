namespace Sklep.Migrations
{
    using Sklep.DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Sklep.DAL.PrzedmiotContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Sklep.DAL.PrzedmiotContext";
        }

        protected override void Seed(Sklep.DAL.PrzedmiotContext context)
        {
            PrzedmiotInitializer.SeedPrzedmiotData(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
