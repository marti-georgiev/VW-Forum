using Microsoft.AspNetCore.Http;
using VWForum.Data.Models;
using VWForum.Web.Data;

namespace VWForum.Data.Repositories
{
    public class CategoryRepository : MetaDataBaseGenericRepository<Category>
    {
        public CategoryRepository(VWForumDbContext dbContext, IHttpContextAccessor httpContextAccessor) : base(dbContext, httpContextAccessor)
        {

        }
    }
}
