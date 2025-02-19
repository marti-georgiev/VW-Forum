namespace VWForum.Data.Models
{
    public class VWThread : MetadataBaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Category Category { get; set; }

        public List<VWTags> Tags { get; set; }

        public List<UserReactionMapping> Reactions { get; set; }

        public List<UserThreadComment> Coment { get; set; }


    }
}
