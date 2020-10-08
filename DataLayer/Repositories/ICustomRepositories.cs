using System.Collections.Generic;

namespace DataLayer
{
    public interface ICustomRepositories
    {
        IEnumerable<ShowGroupViewModel> GetGroupsForView();
        IEnumerable<Page> GetTopNews(int take = 4);
        IEnumerable<Page> PagesInSlider();
        IEnumerable<Page> LatestNews(int take = 4);
        IEnumerable<Page> GroupNews(int groupId);
        IEnumerable<PageComment> GetCommentsByPageId(int pageId);
        int GetPageCommentsCount(int pageId);
        IEnumerable<Page> GetBySearch(string q);
        bool IsExistUser(string username, string password);
    }
}