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
    public partial class OrderDetail : System.Web.UI.Page
    {
        private OrderService _orderService { get; set; }
        public OrdersOverviewVM OrderVM { get; set; }

        public OrderDetail()
        {
            _orderService = new OrderService();
            this.OrderVM = new OrdersOverviewVM();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Request.QueryString["Id"]); //writes ID to the browser

            //#todo refactor better binding
            if ((Request.QueryString["Id"] != null) && (string.IsNullOrEmpty(txtId.Text)))
            {
                var order = _orderService.GetWithOrderItems(int.Parse(Request.QueryString["Id"]));
                txtId.Text = order.Id.ToString();
                txtCustomerName.Text = order.CustomerName;
                txtCustomerAddress.Text = order.CustomerAddress;
                txtPrice.Text = order.OrderItems.Sum(oi => oi.Quantity * oi.Price).ToString();
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Orders.aspx");
        }
    }
}
