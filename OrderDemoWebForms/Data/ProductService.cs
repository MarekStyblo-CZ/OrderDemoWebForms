using OrderDemoWebForms.Data.Repository;
using OrderDemoWebForms.Model;
using OrderDemoWebForms.Model.DbSets;
using System.Collections.Generic;

namespace OrderDemoWebForms.Data
{
    public class ProductService
    {
        private ProductRepository _productRepository = new ProductRepository();

        public Product Get(int id)
        {
            return _productRepository.Get(id);
        }

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

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}