using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VWForum.Web.Data
{
    public class VWForumDbContext : IdentityDbContext
    {
        public VWForumDbContext(DbContextOptions<VWForumDbContext> options)
            : base(options)
        {
        }
    }
}
