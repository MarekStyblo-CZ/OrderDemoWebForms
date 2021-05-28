using OrderDemoWebForms.Model.DbSet;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OrderDemoWebForms.Data
{
    public class SqlDbContext : DbContext, IDisposable
    {
        public DbSet<Product> Products { get; set; }

    }
}