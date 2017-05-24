using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace Shopping.Controllers
{
    public class CartController : Controller
    {
         // GET: Car
        public ActionResult Index()
        {
            var productest = new Product() 
            { 
                Id = 1,
                Name = "test"
            };

            var data = new List<Cart>
            {
                new Cart(){Product = productest , Amount = 10},
            };
            return View(data);
        }
        [HttpPost]
        public ActionResult AddToCart(int ProductId,int amount = 1)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Remove(int ProductId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateAmount(int ProductId, int NewAmoont)
        {
            return View();
        }
    }
}