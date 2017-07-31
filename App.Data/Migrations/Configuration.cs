using App.Entity.Models;

namespace App.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<App.Data.Context.CrmDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(App.Data.Context.CrmDbContext context)
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

            //context.Groups.AddOrUpdate(
            //    new Group
            //    {
            //        Name = "admin", 
            //        Description = "Administrator", 
            //        Crm = "YES",
            //        Billing = "YES",
            //        Accounts = "YES",
            //        Report = "YES",
            //        Hrm = "YES",
            //        Setup = "YES"
            //    }
            //);
        }
    }
}
