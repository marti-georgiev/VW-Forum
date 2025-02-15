using Microsoft.AspNetCore.Identity;

namespace VWForum.Data.Models
{
    public class User : IdentityUser
    {
        public  Role? ForumRole { get; set; }
    }
}
