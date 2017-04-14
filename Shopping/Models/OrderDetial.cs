using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Models
{
    public class OrderDetial
    {
        public int Id { get; set; }
        public OrderHeader OrderHeader { get; set; }
        public Product Product { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
    }
}