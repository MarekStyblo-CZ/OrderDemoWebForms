using OrderDemoWebForms.Data.Repository;
using OrderDemoWebForms.Model.DbSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderDemoWebForms.Services
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