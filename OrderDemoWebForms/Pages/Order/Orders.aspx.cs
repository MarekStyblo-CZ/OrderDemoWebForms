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
    public partial class Orders : Page
    {
        private OrderService _orderService { get; set; }

        public Orders()
        {
            _orderService = new OrderService();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        protected void OrdersGridView_SelectedIndexChanging(Object sender, GridViewSelectEventArgs e)
        {
            var orderVM = ((List<OrdersOverviewVM>)OrdersGrid.DataSource)[e.NewSelectedIndex];
            Response.Redirect($"OrderDetail.aspx?Id={orderVM.Id}");
        }


        protected void OrdersGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            _orderService.Delete(((List<OrdersOverviewVM>)OrdersGrid.DataSource)[e.RowIndex]);
            BindData();
        }

        protected void OrdersGridView_RowUpdating(Object sender, GridViewUpdateEventArgs e)
        {
            throw new NotImplementedException();
            //var product = ((List<Model.DbSets.Product>)ProductsGrid.DataSource)[e.RowIndex];
            //Response.Redirect($"ProductUpdate.aspx?Id={product.Id}");
        }

        protected void OrdersGridView_RowEditing(Object sender, GridViewEditEventArgs e)
        {
            throw new NotImplementedException();
            //var product = ((List<Model.DbSets.Product>)ProductsGrid.DataSource)[e.NewEditIndex];
            //Response.Redirect($"ProductUpdate.aspx?Id={product.Id}");
        }


        protected void BindData()
        {
            OrdersGrid.DataSource = _orderService.GetOrdersWithCalculatedPrice();
            OrdersGrid.DataBind();
        }

        protected void CreateOrderBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect($"OrderCreate.aspx");
        }
    }
}