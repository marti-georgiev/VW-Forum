namespace VWForum.Data.Models
{
    public class UserThreadComment : BaseEntity
    {
        public User User { get; set; }
        public Comments Comment { get; set; }
        public Thread Thread { get; set; }
    }
}
