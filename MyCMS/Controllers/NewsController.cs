using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DataLayer;

namespace MyCMS.Controllers
{
    public class NewsController : Controller
    {
        UnitOfWork db = new UnitOfWork();

        public ActionResult ShowGroups()
        {
            return PartialView(db.CustomRepositories.GetGroupsForView());
        }

        public ActionResult ShowGroupsInMenu()
        {
            return PartialView(db.PageGroupRepository.GetAll());
        }

        public ActionResult ShowTopNews()
        {
            return PartialView(db.CustomRepositories.GetTopNews());
        }

        [Route("GroupNews/{id}/{title}")]
        public ActionResult ShowGroupNews(int id, string title)
        {
            ViewBag.header = title;
            return View(db.CustomRepositories.GroupNews(id));
        }

        [Route("News/{id}")]
        public ActionResult ShowNews(int id)
        {
            var news = db.PageRepository.GetById(id);
            
            if (news == null)
            {
                return HttpNotFound();
            }
            ViewBag.count = db.CustomRepositories.GetPageCommentsCount(id);

            news.Visit += 1;
            db.PageRepository.Update(news);
            db.Commit();

            return View(news);
        }

        public ActionResult AddComment(int id, string name, string email, string comment)
        {
            PageComment Comment = new PageComment()
            {
                Comment = comment,
                Name = name,
                Email = email,
                PageID = id,
                CreateDate = DateTime.Now
            };
            db.PageCommentRepository.Insert(Comment);
            db.Commit();
            return PartialView("ShowComments",db.CustomRepositories.GetCommentsByPageId(id));
        }

        public ActionResult ShowComments(int Id)
        {
            return PartialView(db.CustomRepositories.GetCommentsByPageId(Id));
        }

       
    }
}