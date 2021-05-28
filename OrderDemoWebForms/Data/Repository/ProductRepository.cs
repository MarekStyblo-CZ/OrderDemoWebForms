using OrderDemoWebForms.Model.DbSet;
using System.Collections.Generic;
using System.Linq;

namespace OrderDemoWebForms.Data.Repository
{
    public class ProductRepository
    {
        private SqlDbContext _db = new SqlDbContext();

        public List<Product> GetAll()
        {
            return _db.Products.ToList();
        }

        public List<Product> GetDummyProducts()
        {
            var listProducts = new List<Product>();
            listProducts.Add(new Product { Id = 1, Code = 11, Name = "Pračka", Price = 55 });
            listProducts.Add(new Product { Id = 2, Code = 22, Name = "Myčka", Price = 66 });
            return listProducts;
        }

        public void Add(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }

    }
}