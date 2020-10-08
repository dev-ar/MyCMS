using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;

namespace MyCMS.Controllers
{
    public class SearchController : Controller
    {
        UnitOfWork db = new UnitOfWork();
        public ActionResult Index(string q)
        {
            ViewBag.searchParameter = q;
            return View(db.CustomRepositories.GetBySearch(q));
        }
    }
}