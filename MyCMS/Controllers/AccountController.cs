using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DataLayer;
using DataLayer.ViewModels;

namespace MyCMS.Controllers
{
    public class AccountController : Controller
    {
        UnitOfWork db = new UnitOfWork();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel login, string ReturnUrl = "/")
        {
            if (ModelState.IsValid)
            {
                if (db.CustomRepositories.IsExistUser(login.UserName, login.Password))
                {
                    FormsAuthentication.SetAuthCookie(login.UserName, login.RememberMe);
                    return Redirect(ReturnUrl);
                }
                ModelState.AddModelError("UserName","کاربری با این مشخصات یاف نشد.");
            }
            return View();
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/");
        }
    }
}