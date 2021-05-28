using OrderDemoWebForms.Model.DbSets;
using System.Collections.Generic;
using System.Linq;

namespace OrderDemoWebForms.Data.Repository
{
    //#todo add Dispose()
    public class ProductRepository
    {
        private SqlDbContext _db = new SqlDbContext();

        public Product Get(int id)
        {
            return _db.Products.FirstOrDefault(p => p.Id == id);
        }

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

        public void Remove(Product product)
        {
            _db.Products.Remove(product);
            _db.SaveChanges();
        }

        public void Update(Product product)
        {
            var actualProduct = _db.Products.FirstOrDefault(p => p.Id == product.Id);

            actualProduct.Name = product.Name;
            actualProduct.Code = product.Code;
            actualProduct.Price = product.Price;

            _db.SaveChanges();
        }

    }
}