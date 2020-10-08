using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IUnitOfWork
    {
        GenericRepository<PageGroup> PageGroupRepository { get; }
        GenericRepository<Page> PageRepository { get; }
        GenericRepository<PageComment> PageCommentRepository { get; } 
        CustomRepositories CustomRepositories { get; }
        void Commit();
        void Dispose();
    }
}
