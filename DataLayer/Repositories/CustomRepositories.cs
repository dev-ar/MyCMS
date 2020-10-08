using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class CustomRepositories : ICustomRepositories
    {
        private MyCmsContext db;

        public CustomRepositories(MyCmsContext context)
        {
            db = context;
        }

        public IEnumerable<ShowGroupViewModel> GetGroupsForView()
        {
            return db.PageGroups.Select(g => new ShowGroupViewModel()
            {
                GroupID = g.GroupID,
                PageCount = g.Page.Count,
                Title = g.Title
            });
        }

        public IEnumerable<Page> GetTopNews(int take = 4)
        {
            return db.Pages.OrderByDescending(p => p.Visit).Take(take);
        }

        public IEnumerable<Page> PagesInSlider()
        {
            return db.Pages.Where(p => p.ShowInSlider);
        }

        public IEnumerable<Page> LatestNews(int take = 4)
        {
            return db.Pages.OrderByDescending(p => p.CreateDate).Take(take);
        }

        public IEnumerable<Page> GroupNews(int groupId)
        {
            return db.Pages.Where(p => p.GroupID == groupId);
        }

        public IEnumerable<PageComment> GetCommentsByPageId(int pageId)
        {
            return db.PageComments.Where(p => p.PageID == pageId);
        }

        public int GetPageCommentsCount(int pageId)
        {
            return db.PageComments.Count(p => p.PageID == pageId);
        }

        public IEnumerable<Page> GetBySearch(string q)
        {
            return db.Pages.Where(p => p.Tags.Contains(q) || p.Title.Contains(q) || p.ShortDescription.Contains(q)).Distinct();
        }

        public bool IsExistUser(string username, string password)
        {
            return db.AdminLogins.Any(a => a.UserName == username && a.Password == password);
        }
    }
}
