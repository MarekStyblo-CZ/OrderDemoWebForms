using OrderDemoWebForms.Model.DbSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderDemoWebForms.Data.Repository
{
    //#todo add Dispose()
    public class OrderRepository
    {
        private SqlDbContext _db = new SqlDbContext();

        public Order Get(int id)
        {
            return _db.Orders.FirstOrDefault(p => p.Id == id);
        }

        public List<Order> GetAll()
        {
            return _db.Orders.ToList();
        }

        public List<Order> GetAllWithOrderItems()
        {
            return _db.Orders.Include("OrderItems").ToList();
        }


        public void Add(Order order)
        {
            _db.Orders.Add(order);
            _db.SaveChanges();
        }

        public void Remove(Order order)
        {
            _db.Orders.Remove(order);
            _db.SaveChanges();
        }

        public void Update(Order order)
        {
            throw new NotImplementedException();
            //var actualProduct = _db.Products.FirstOrDefault(p => p.Id == product.Id);

            //actualProduct.Name = product.Name;
            //actualProduct.Code = product.Code;
            //actualProduct.Price = product.Price;

            //_db.SaveChanges();
        }

    }
}