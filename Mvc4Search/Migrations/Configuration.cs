namespace Mvc4Search.Migrations
{
    using Mvc4Search.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mvc4Search.Models.LocalPersonModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Mvc4Search.Models.LocalPersonModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            context.Persons.AddOrUpdate(
              new LocalPerson { LocalPersonId = 0, FirstName = "Andrew", LastName = "Peters" },
              new LocalPerson { LocalPersonId = 1, FirstName = "Brice", LastName = "Lambson" },
              new LocalPerson { LocalPersonId = 2, FirstName = "Rowan", LastName = "Miller" }
            );
        }
    }
}
