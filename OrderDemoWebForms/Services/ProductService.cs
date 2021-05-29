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

        //#todo - nice to have -- better aler msg..
        /// <summary>
        /// Deletes product with check for OrderItem existence
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Returns error msg in case of error / empty string when all ok</returns>
        public string Delete(Product product)
        {
            var productWithOrderItems = _productRepository.GetWithOrderItems(product.Id);
            if (productWithOrderItems.OrderItems.Count() > 0)
                return "<script>alert(\"Produkt nelze smazat. Existuje záznam v objednávkách\")</script>";
            else
            {
                _productRepository.Remove(product);
                return string.Empty;
            }
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}