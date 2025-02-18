using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace VWForum.Data.Models
{
    public class Role : MetadataBaseEntity
    {
        public const string VWForumDefaultAuthority = "User";
        public string Labele { get; set; }

        public string Color { get; set; }

        public string Authority { get; set; } = VWForumDefaultAuthority;
    }
}
