using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VWForum.Data.Extensions;
using VWForum.Data.Models;

namespace VWForum.Data
{
    public class VWForumDbContext : IdentityDbContext<ForumUser>
    {   
        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<VWThread> Threads { get; set; }

        public DbSet<VWThread> Tags { get; set; }

        public DbSet<Reactions> Reactions { get; set; }

        public DbSet<Comments> Comments { get; set; }

        public DbSet<Role> Roles { get; set; }



        public VWForumDbContext(DbContextOptions<VWForumDbContext> options): base(options)
        {

        }


      
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            builder.Entity<UserReactionMapping>()
                .HasOne(utr => utr.Thread)
                .WithMany(t => t.Reactions)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ForumUser>()
                .HasOne(u => u.ForumRole)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            builder.ConfigureMetadataEntity<Role>();
            builder.ConfigureMetadataEntity<VWTags>();  

            builder.Entity<Category>()
                .HasMany(gc => gc.Tags)
                .WithMany();

            builder.Entity<VWThread>()
                .HasMany(gc => gc.Tags)
                .WithMany();
                
            

            base.OnModelCreating(builder);
        }


    }
}
