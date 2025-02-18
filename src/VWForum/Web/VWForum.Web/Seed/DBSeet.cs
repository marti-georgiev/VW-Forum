using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VWForum.Data;

namespace VWForum.Web.Seed
{
    public static class DBSeet
    {
        public static void UseDatabaseSeed(this WebApplication app)
        {
            SeedRoles(app);
        }
        public static void SeedRoles(WebApplication app)
        {
            using (var serviceScope = app.Services.CreateScope())
            {
                using (var vwforumdbContext = serviceScope.ServiceProvider.GetRequiredService<VWForumDbContext>())
                {
                    vwforumdbContext.Database.Migrate();

                    if (vwforumdbContext.Roles.Count() == 0)
                    {
                        IdentityRole adminRole = new IdentityRole();
                        adminRole.Name = "Administrator";
                        adminRole.NormalizedName = adminRole.Name.ToUpper();

                        IdentityRole userRole = new IdentityRole();
                        userRole.Name = "User";
                        userRole.NormalizedName = userRole.Name.ToUpper();

                        IdentityRole moderatorRole = new IdentityRole();
                        moderatorRole.Name = "Moderator";
                        moderatorRole.NormalizedName = moderatorRole.Name.ToUpper();

                        vwforumdbContext.Add(adminRole);    
                        vwforumdbContext.Add(userRole);
                        vwforumdbContext.Add(moderatorRole);

                        vwforumdbContext.SaveChanges();
                    }

                   
                }

            }
        }
    }
}
