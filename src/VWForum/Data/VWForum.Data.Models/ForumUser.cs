using Microsoft.AspNetCore.Identity;

namespace VWForum.Data.Models
{
    public class ForumUser : IdentityUser
    {
        public  Role? ForumRole { get; set; }
    }
}
