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

        public Order GetWithOrderItems(int id)
        {
            return _orderRepository.GetWithOrderItem(id);
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public List<Order> GetAllWithOrderItems()
        {
            return _orderRepository.GetAllWithOrderItems();
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

        public void Delete(OrdersOverviewVM orderVM)
        {
            _orderRepository.Remove(_orderRepository.Get(orderVM.Id));
        }

        public void Update(Order order)
        {
            _orderRepository.Update(order);
        }

    }
}