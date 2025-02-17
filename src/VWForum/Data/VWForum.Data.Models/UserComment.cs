namespace VWForum.Data.Models
{
    public class 
        Comment : BaseEntity
    {
        public ForumUser User { get; set; }

        public Comments Comments { get; set; }

        public VWThread Thread { get; set; }
    }
}
