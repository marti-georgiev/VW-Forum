using VWForum.Data.Models;  
using Microsoft.AspNetCore.Http;
using VWForum.Web.Data;

namespace VWForum.Data.Repositories
{
    public class VWThreadRepository : MetaDataBaseGenericRepository<VWThread>
    {
        public VWThreadRepository(VWForumDbContext dbcontext, IHttpContextAccessor? httpContextAccessor) 
            : base(dbcontext, httpContextAccessor)
        {
        }
    }
}
