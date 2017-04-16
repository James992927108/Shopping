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
            var date = new List<ProductCategory>
            {
                new ProductCategory(){Id = 1 , Name = "文具"},
                new ProductCategory(){Id = 2 , Name = "禮品"},
                new ProductCategory(){Id = 3 , Name = "書籍"}
            };
            return View();
        }

        public ActionResult ProductList()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ProductDetail()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}