using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = new List<ProductCategory>
            {
                new ProductCategory(){Id = 1 , Name = "文具"},
                new ProductCategory(){Id = 2 , Name = "禮品"},
                new ProductCategory(){Id = 3 , Name = "書籍"}
            };
            return View(data);
        }

        public ActionResult ProductList(int id)//ProductList(int id)
        {
            var productCategory = new ProductCategory() { Id = id, Name = "類別" };//Id = 5 -> Id = id
            var data = new List<Product>()
            {
                new Product(){Id = 1,ProductCategory = productCategory,Name = "Blue Pen",Description = "N/A",Color = ConsoleColor.Blue,price = 100,publishOn = DateTime.Now},
                new Product(){Id = 1,ProductCategory = productCategory,Name = "Red Pen",Description = "N/A",Color = ConsoleColor.Red,price = 200,publishOn = DateTime.Now}       
            };

            return View(data);
        }

        public ActionResult ProductDetail(int id)//ProductDetail(int id)
        {
            var productCategory = new ProductCategory() { Id = 1, Name = "文具" };
            var data = new Product() { Id = id, ProductCategory = productCategory, Name = "Product" + 5, Description = "N/A", Color = ConsoleColor.Blue, price = 300, publishOn = DateTime.Now };  

            return View(data);
        }
    }
}