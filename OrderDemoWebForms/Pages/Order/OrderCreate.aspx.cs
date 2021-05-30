using OrderDemoWebForms.Model.ViewModels;
using OrderDemoWebForms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderDemoWebForms.Pages.Order
{
    public partial class OrderCreate : System.Web.UI.Page
    {
        private OrderService _orderService { get; set; }
        public OrdersOverviewVM OrderVM { get; set; }

        public OrderCreate()
        {
            _orderService = new OrderService();
            this.OrderVM = new OrdersOverviewVM();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Request.QueryString["Id"]); //writes ID to the browser

            //#todo refactor better binding
            if ((Request.QueryString["Id"] != null) && (string.IsNullOrEmpty(txtCreateId.Text)))
            {
                var order = _orderService.GetWithOrderItems(int.Parse(Request.QueryString["Id"]));
                txtCreateId.Text = order.Id.ToString();
                txtCreateCustomerName.Text = order.CustomerName;
                txtCreateCustomerAddress.Text = order.CustomerAddress;
                txtCreatePrice.Text = order.OrderItems.Sum(oi => oi.Quantity * oi.Price).ToString();
            }
        }
    }
}