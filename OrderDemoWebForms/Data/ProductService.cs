using OrderDemoWebForms.Data.Repository;
using OrderDemoWebForms.Model.DbSets;
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

        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public void Delete(Product product)
        {
            _productRepository.Remove(product);
        }

        public void Edit(Product product)
        {
            _productRepository.Edit(product);
        }
    }
}