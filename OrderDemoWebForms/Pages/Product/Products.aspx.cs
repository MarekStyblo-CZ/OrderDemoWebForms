using OrderDemoWebForms.Data;
using OrderDemoWebForms.Model;
using System;
using System.Web.UI;
using System.Linq;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Data.Entity;

namespace OrderDemoWebForms.Pages.Product
{
    public partial class Products : Page
    {
        private ProductService _productService { get; set; }

        public Products()
        {
            _productService = new ProductService();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        protected void AddProduct_Click(object sender, EventArgs e)
        {
            _productService.Add(new Model.DbSets.Product { Code = Int32.Parse(txtCode.Text), Name = txtName.Text, Price = float.Parse(txtPrice.Text) });
            BindData();
        }

        protected void ProductsGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            _productService.Delete(((List<Model.DbSets.Product>)ProductsGrid.DataSource)[e.RowIndex]);
            BindData();
        }

        protected void ProductsGridView_RowUpdating(Object sender, GridViewUpdateEventArgs e)
        {
            var product = ((List<Model.DbSets.Product>)ProductsGrid.DataSource)[e.RowIndex];
            Response.Redirect($"ProductUpdate.aspx?Id={product.Id}");
        }

        protected void ProductsGridView_RowEditing(Object sender, GridViewEditEventArgs e)
        {
            var product = ((List<Model.DbSets.Product>)ProductsGrid.DataSource)[e.NewEditIndex];
            Response.Redirect($"ProductUpdate.aspx?Id={product.Id}");
        }


        protected void BindData()
        {
            ProductsGrid.DataSource = _productService.GetProducts();
            ProductsGrid.DataBind();
        }
    }
}