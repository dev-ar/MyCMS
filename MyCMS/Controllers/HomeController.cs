using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;

namespace MyCMS.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork db = new UnitOfWork();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Slider()
        {
            return PartialView(db.CustomRepositories.PagesInSlider());
        }
        
        public ActionResult LatestNews()
        {
            return PartialView(db.CustomRepositories.LatestNews());
        }

        [Route("Archive")]
        public ActionResult ArchiveNews()
        {
            return View(db.PageRepository.GetAll());
        }
    }
}