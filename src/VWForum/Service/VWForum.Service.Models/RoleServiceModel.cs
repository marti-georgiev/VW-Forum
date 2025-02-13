using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace VWForum.Service.Models
{
    public class RoleServiceModel : BaseServiceModel
    {
        public const string VWForumDefaultAuthority = "User";
        public string Labele { get; set; }

        public string Color { get; set; }

        public string Authority { get; set; } = VWForumDefaultAuthority;
    }
}
