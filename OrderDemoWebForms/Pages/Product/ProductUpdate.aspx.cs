using OrderDemoWebForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderDemoWebForms.Pages.Product
{
    public partial class ProductUpdate : System.Web.UI.Page
    {
        private ProductService _productService { get; set; }
        public Model.DbSets.Product Product { get; set; }

        public ProductUpdate()
        {
            _productService = new ProductService();
            this.Product = new Model.DbSets.Product();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Request.QueryString["Id"]); //writes ID to the browser

            //#todo refactor better binding
            if ((Request.QueryString["Id"] != null) && (string.IsNullOrEmpty(txtId.Text)))
            {
                var product = _productService.Get(int.Parse(Request.QueryString["Id"]));
                txtId.Text = product.Id.ToString();
                txtCode.Text = product.Code.ToString();
                txtName.Text = product.Name;
                txtPrice.Text = product.Price.ToString();
            }

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Products.aspx");
        }

        protected void UpdateProduct_Click(object sender, EventArgs e)
        {
            _productService.Update(new Model.DbSets.Product { Id = Int32.Parse(txtId.Text), Code = Int32.Parse(txtCode.Text), Name = txtName.Text, Price = float.Parse(txtPrice.Text) });
            Response.Redirect($"Products.aspx");
        }
    }
}