using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace VWForum.Data.Models
{
    public class Reactions : MetadataBaseEntity
    {
        public string Lable { get; set; }

        public Attachment Emote { get; set; }
    }
}
