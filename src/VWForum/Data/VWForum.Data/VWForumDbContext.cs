using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VWForum.Data.Models;

namespace VWForum.Web.Data
{
    public class VWForumDbContext : IdentityDbContext<User>
    {   
        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<VWThread> Threads { get; set; }

        public DbSet<Reactions> Reactions { get; set; }

        public DbSet<Comments> Comments { get; set; }

        public DbSet<Role> Roles { get; set; }



        public VWForumDbContext(DbContextOptions<VWForumDbContext> options): base(options)
        {

        }


    }
}
