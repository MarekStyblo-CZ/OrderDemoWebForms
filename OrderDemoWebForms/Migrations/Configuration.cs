namespace OrderDemoWebForms.Migrations
{
    using OrderDemoWebForms.Model.DbSets;
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

        ////  This method will be called after migrating to the latest version.
        // Is run automatically - no need to generate migration (resp. its not seen in migrations..)
        protected override void Seed(OrderDemoWebForms.Data.SqlDbContext context)
        {
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method to avoid creating duplicate seed data.
            context.Products.AddOrUpdate(new Product { Id = 1, Code = 111, Name = "Pračka", Price = 7600.5f });
            context.Products.AddOrUpdate(new Product { Id = 2, Code = 112, Name = "Myčka", Price = 9800.6f });

            context.Orders.AddOrUpdate(new Order { Id = 1, CustomerName = "Aleš Vopěnka", CustomerAddress = "Uliční 22, Těškov", Created = new DateTime(2020, 05, 20) });
            context.Orders.AddOrUpdate(new Order { Id = 2, CustomerName = "Jan Novák", CustomerAddress = "Testovací 11, Zadov", Created = new DateTime(2020, 05, 21) });

            context.OrderItems.AddOrUpdate(new OrderItem { Id = 1, OrderId = 1, ProductId = 1, Price = 7600.5f, Quantity = 1 });
            context.OrderItems.AddOrUpdate(new OrderItem { Id = 2, OrderId = 2, ProductId = 2, Price = 9800.6f, Quantity = 1 });

            context.SaveChanges();
        }


    }
}
