using VWForum.Data.Models;
using Microsoft.AspNetCore.Http;
using VWForum.Web.Data;
namespace VWForum.Data.Repositories
{
    public class ReactionRepository : MetaDataBaseGenericRepository<Reactions>
    {
        public ReactionRepository(VWForumDbContext dbcontext, IHttpContextAccessor? httpContextAccessor) : base(dbcontext, httpContextAccessor)
        {
        }
    }
}
