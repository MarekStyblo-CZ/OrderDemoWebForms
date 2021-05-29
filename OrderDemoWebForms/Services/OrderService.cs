using OrderDemoWebForms.Data.Repository;
using OrderDemoWebForms.Model.DbSets;
using OrderDemoWebForms.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderDemoWebForms.Services
{
    public class OrderService
    {
        private OrderRepository _orderRepository = new OrderRepository();

        public Order Get(int id)
        {
            return _orderRepository.Get(id);
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public List<Order> GetAllWithOrderItems()
        {
            return _orderRepository.GetAll();
        }


        public List<OrdersOverviewVM> GetOrdersWithCalculatedPrice()
        {
            var resultList = new List<OrdersOverviewVM>();
            var allDbOrder = _orderRepository.GetAllWithOrderItems();
            foreach (var dbOrder in allDbOrder)
            {
                var newOrder = new OrdersOverviewVM
                {
                    Id = dbOrder.Id,
                    CustomerName = dbOrder.CustomerName,
                    CustomerAddress = dbOrder.CustomerAddress,
                    Created = dbOrder.Created
                };
                newOrder.OderItems = new List<OrderItem>();
                newOrder.OderItems = dbOrder.OrderItems;
                newOrder.TotalPrice = dbOrder.OrderItems.Sum(oi => oi.Quantity * oi.Price);
                resultList.Add(newOrder);
            }
            return resultList;
        }

        public void Add(Order order)
        {
            _orderRepository.Add(order);
        }

        //#todo - nice to have -- better aler msg..
        /// <summary>
        /// Deletes product with check for OrderItem existence
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Returns error msg in case of error / empty string when all ok</returns>
        public string Delete(Order order)
        {
            throw new NotImplementedException();
            //var productWithOrderItems = _orderRepository.GetWithOrderItems(product.Id);
            //if (productWithOrderItems.OrderItems.Count() > 0)
            //    return "<script>alert(\"Produkt nelze smazat. Existuje záznam v objednávkách\")</script>";
            //else
            //{
            //    _orderRepository.Remove(product);
            //    return string.Empty;
            //}
        }

        public void Update(Order order)
        {
            _orderRepository.Update(order);
        }
    }
}