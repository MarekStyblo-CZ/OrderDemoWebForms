using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OrderDemoWebForms.Model.DbSet
{
    public class Product
    {
        //PK
        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //Relations
        //public List<OrderItem> OrderItems { get; set; }

        //Attr

        public int Code { get; set; }
        [Required]
        public string Name { get; set; }
        public float Price { get; set; }
    }
}