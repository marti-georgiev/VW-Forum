using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace VWForum.Data.Models
{
    public class VWTags : MetadataBaseEntity
    {
        public string Lable { get; set; }
    }
}
