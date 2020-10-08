using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        MyCmsContext db = new MyCmsContext();


        private GenericRepository<PageGroup> _pageGroupRepository;
        public GenericRepository<PageGroup> PageGroupRepository
        {
            get
            {
                if (_pageGroupRepository == null)
                {
                    _pageGroupRepository = new GenericRepository<PageGroup>(db);
                }

                return _pageGroupRepository;
            }
        }


        private GenericRepository<Page> _pageRepository;
        public GenericRepository<Page> PageRepository
        {
            get
            {
                if (_pageRepository == null)
                {
                    _pageRepository = new GenericRepository<Page>(db);
                }

                return _pageRepository;
            }
        }


        private GenericRepository<PageComment> _pageCommentRepository;
        public GenericRepository<PageComment> PageCommentRepository
        {
            get
            {
                if (_pageCommentRepository == null)
                {
                    _pageCommentRepository = new GenericRepository<PageComment>(db);
                }

                return _pageCommentRepository;
            }
        }


        private CustomRepositories _customRepositories;
        public CustomRepositories CustomRepositories
        {
            get
            {
                if (_customRepositories == null)
                {
                    _customRepositories = new CustomRepositories(db);
                }

                return _customRepositories;
            }
        }


        public void Commit()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
