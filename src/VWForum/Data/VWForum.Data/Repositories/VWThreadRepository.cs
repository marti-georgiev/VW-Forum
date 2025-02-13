using VWForum.Data.Models;  
using Microsoft.AspNetCore.Http;
using VWForum.Web.Data;

namespace VWForum.Data.Repositories
{
    public class VWThread : MetaDataBaseGenericRepository<VWThread>
    {
        public VWThread(VWForumDbContext dbcontext, IHttpContextAccessor? httpContextAccessor) 
            : base(dbcontext, httpContextAccessor)
        {
        }
    }
}
