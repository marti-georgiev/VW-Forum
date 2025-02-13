 using Microsoft.AspNetCore.Identity;

namespace VWForum.Service.Models
{
    public class UserServiceModel : IdentityUser
    {
        public  RoleServiceModel ForumRole { get; set; }
    }
}
