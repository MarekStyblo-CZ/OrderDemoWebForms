using OrderDemoWebForms.Model.DbSets;
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
        private ProductService _productService { get; set; }

        public OrdersOverviewVM OrderVM { get; set; }

        public OrderCreate()
        {
            _orderService = new OrderService();
            _productService = new ProductService();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var products = _productService.GetProducts();

            //#todo better.. ugly workaround how to avoid init on submit + use at least validation for address....
            if (string.IsNullOrEmpty(txtCreateCustomerAddress.Text))
            {
                //#todo refactor with better binding..?
                foreach (var product in products)
                {
                    ProductsDropDownList1.Items.Add(new ListItem { Text = "Code:" + product.Code.ToString() + ";" + "Název:" + product.Name, Value = product.Id.ToString() });
                    ProductsDropDownList2.Items.Add(new ListItem { Text = "Code:" + product.Code.ToString() + ";" + "Název:" + product.Name, Value = product.Id.ToString() });
                    ProductsDropDownList3.Items.Add(new ListItem { Text = "Code:" + product.Code.ToString() + ";" + "Název:" + product.Name, Value = product.Id.ToString() });
                }
                Quantity1.Text = "0";
                Quantity2.Text = "0";
                Quantity3.Text = "0";
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Orders.aspx");
        }

        protected void AddOrder_Click(object sender, EventArgs e)
        {
            var order = new Model.DbSets.Order
            {
                CustomerName = txtCreateCustomerName.Text,
                CustomerAddress = txtCreateCustomerAddress.Text,
                Created = DateTime.Now,
                OrderItems = new List<OrderItem>()
            };

            //#todo refactor with better validation through dynamical length...
            if (Quantity1.Text == "0" && Quantity2.Text == "0" && Quantity3.Text == "0")
            {
                Response.Write("<script>alert(\"Je třeba zadat alespoň 1 nenulové množství\")</script>");
            }
            else if (Int32.Parse(Quantity1.Text) < 0 || Int32.Parse(Quantity2.Text) < 0 || Int32.Parse(Quantity3.Text) < 0)
                Response.Write("<script>alert(\"Je třeba zadat pouze kladná množství\")</script>");
            else
            {
                //#todo refactor with better binding..?
                if (Int32.Parse(Quantity1.Text) > 0)
                {
                    order.OrderItems.Add(CreateOrderItem(order, Int32.Parse(ProductsDropDownList1.SelectedValue), Int32.Parse(Quantity1.Text)));
                }

                if (Int32.Parse(Quantity2.Text) > 0)
                {
                    order.OrderItems.Add(CreateOrderItem(order, Int32.Parse(ProductsDropDownList2.SelectedValue), Int32.Parse(Quantity2.Text)));
                }

                if (Int32.Parse(Quantity3.Text) > 0)
                {
                    order.OrderItems.Add(CreateOrderItem(order, Int32.Parse(ProductsDropDownList3.SelectedValue), Int32.Parse(Quantity3.Text)));
                }

                _orderService.Add(order);
                Response.Redirect($"Orders.aspx");
            }
        }

        private OrderItem CreateOrderItem(Model.DbSets.Order order, int productId, int quantity)
        {
            var product = _productService.Get(productId);
            var orderItem = new Model.DbSets.OrderItem
            {
                Order = order,
                ProductId = product.Id,
                Quantity = quantity,
                Price = product.Price
            };
            return orderItem;
        }

    }
}