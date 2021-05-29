using OrderDemoWebForms.Model.DbSets;
using System;
using System.Data.Entity;

namespace OrderDemoWebForms.Data
{
    public class SqlDbContext : DbContext, IDisposable
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Prevent deleting Product when relation to OrderItem
            //1:N
            modelBuilder.Entity<Product>()
                .HasMany<OrderItem>(p => p.OrderItems)
                .WithRequired(oi => oi.Product)
                .HasForeignKey(oi => oi.ProductId)
                .WillCascadeOnDelete(false);

            //1:N
            modelBuilder.Entity<Order>()
                .HasMany<OrderItem>(o => o.OderItems)
                .WithRequired(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId)
                .WillCascadeOnDelete(true);
        }
    }
}