using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace Shopping.Controllers
{
    public class CarController : Controller
    {
         // GET: Car
        public ActionResult Index()
        {
            return View();
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
}