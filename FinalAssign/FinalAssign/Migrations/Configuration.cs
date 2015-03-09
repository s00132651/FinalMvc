namespace FinalAssign.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FinalAssign.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<FinalAssign.Models.FinalAssignContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinalAssign.Models.FinalAssignContext context)
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

            context.Cities.AddOrUpdate(
              c => c.Id,
              new City(){ Id=1, Name = "Los Angeles",Country="USA",Population= 3792621},
              new City() { Id=2, Name = "London", Country = "UK", Population = 8416535 },
              new City(){ Id=3, Name = "Tokyo",Country="Japan",Population=  	36923000},
              new City() { Id=4, Name = "Shanghai",Country="China",Population= 24750000},
              new City() { Id=5, Name = "Sao Paulo",Country="Brazil",Population= 20935204},
              new City() { Id=6, Name = "Cairo",Country="Egypt",Population= 16292269}
            );
            
        }
    }
}
