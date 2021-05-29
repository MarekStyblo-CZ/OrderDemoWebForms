using OrderDemoWebForms.Model.DbSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderDemoWebForms.Model.ViewModels
{
    public class OrdersOverviewVM
    {
        public int Id { get; set; }

        //Relations
        public List<OrderItem> OderItems { get; set; }

        //Attr
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime Created { get; set; }
        public double TotalPrice { get; set; }

    }
}