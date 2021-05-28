namespace OrderDemoWebForms.Migrations
{
    using OrderDemoWebForms.Model.DbSet;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OrderDemoWebForms.Data.SqlDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        //Is run automatically - no need to generate migration (resp. its not seen in migrations..)
        protected override void Seed(OrderDemoWebForms.Data.SqlDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Products.AddOrUpdate(new Product { Id = 1, Code = 111, Name = "Pračka", Price = 7600.5f });
            context.Products.AddOrUpdate(new Product { Id = 2, Code = 112, Name = "Myčka", Price = 9800.6f });
            context.SaveChanges();

        }
    }
}
