using OrderDemoWebForms.Data.Repository;
using OrderDemoWebForms.Model.DbSet;
using System.Collections.Generic;

namespace OrderDemoWebForms.Data
{
    public class ProductService
    {
        private ProductRepository _productRepository = new ProductRepository();

        public List<Product> GetProducts()
        {
            return _productRepository.GetAll();
        }

        public void AddProduct(Product product)
        {
            _productRepository.Add(product);
        }

    }
}