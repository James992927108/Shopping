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

        public ActionResult ProductList()
        {
            var productCategory = new ProductCategory(){Id = 5 , Name = "類別"};
            var data = new List<Product>()
            {
                new Product(){Id = 1,ProductCategory = productCategory,Name = "Blue Pen",Description = "N/A",Color = ConsoleColor.Blue,price = 100,publishOn = DateTime.Now},
                new Product(){Id = 1,ProductCategory = productCategory,Name = "Red Pen",Description = "N/A",Color = ConsoleColor.Red,price = 200,publishOn = DateTime.Now}       
            };
            ViewBag.Message = "Your application description page.";

            return View(data);
        }

        public ActionResult ProductDetail()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}