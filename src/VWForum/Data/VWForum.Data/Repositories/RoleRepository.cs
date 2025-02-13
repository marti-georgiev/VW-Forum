using VWForum.Data.Models;
using VWForum.Web.Data;
namespace VWForum.Data.Repositories

{
    public class RoleRepository : BaseGenericRepository<Role>
    {
        public RoleRepository(VWForumDbContext dbcontext) : base(dbcontext)
        {
        }
    }
    
}
