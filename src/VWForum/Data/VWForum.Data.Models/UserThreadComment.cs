namespace VWForum.Data.Models
{
    public class UserThreadComment : BaseEntity
    {
        public ForumUser User { get; set; }
        public Comments Comment { get; set; }
        public VWThread Thread { get; set; }
    }
}
