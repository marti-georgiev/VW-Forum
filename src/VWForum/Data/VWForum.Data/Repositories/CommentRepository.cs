using VWForum.Data.Models;
using Microsoft.AspNetCore.Http;
using VWForum.Web.Data;

namespace VWForum.Data.Repositories
{
    public class CommentRepository : MetaDataBaseGenericRepository<Comments>

    {
        public CommentRepository(VWForumDbContext dbcontext, IHttpContextAccessor? httpContextAccessor) : base(dbcontext, httpContextAccessor)
        {
        }
    }
}
