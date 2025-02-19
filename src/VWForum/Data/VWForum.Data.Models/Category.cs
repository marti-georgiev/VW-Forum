namespace VWForum.Data.Models
{
    public class Category : MetadataBaseEntity
    
    {
        public string Name { get; set; }   

        public List<VWTags> Tags { get; set; }
        public string Description { get; set; }

    }
}
