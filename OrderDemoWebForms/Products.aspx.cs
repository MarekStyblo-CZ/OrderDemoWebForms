using OrderDemoWebForms.Data;
using OrderDemoWebForms.Model.DbSet;
using System;
using System.Web.UI;
using System.Linq;

namespace OrderDemoWebForms
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
            _productService.AddProduct(new Product { Code = Int32.Parse(txtCode.Text), Name = txtName.Text, Price = float.Parse(txtPrice.Text) });
            BindData();
        }

        protected void BindData()
        {
            ProductsGrid.DataSource = _productService.GetProducts();
            ProductsGrid.DataBind();
        }
    }
}