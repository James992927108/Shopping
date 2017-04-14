using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Shopping.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Member member)
        {
            return View();
        }

        public ActionResult Login(string retrunUrl)
        {
            ViewBag.returnUrl = retrunUrl;
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email,string password,string returnUrl)
        {
            if (ValidateUser(email, password))
            {
                FormsAuthentication.SetAuthCookie(email, false);
                if (String.IsNullOrEmpty(returnUrl))
                {
                    return RedirectToAction("Index", "Home");
                }
                else 
                {
                    return Redirect(returnUrl);
                }
            }
            ModelState.AddModelError("", "輸入的帳號或密碼錯誤");
            return View();
        }

        private bool ValidateUser(string email, string password)
        {
            throw new NotImplementedException();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}