using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Complete()
        {
            return View();
        }

        public ActionResult Complete(FormCollection form) 
        {
            return RedirectToAction("Index", "Home");
        }
    }
}