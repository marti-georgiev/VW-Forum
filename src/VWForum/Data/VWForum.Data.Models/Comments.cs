namespace VWForum.Data.Models
{
    public class Comments : MetadataBaseEntity
    {
        public string Content { get; set; }

        public List<Attachment> Attachments { get; set; }   
        
        public List<Comment> Reactions { get; set; }    

        public List<Comments> Replies { get; set; }
    }
}
