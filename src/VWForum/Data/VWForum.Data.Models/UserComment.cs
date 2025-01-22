namespace VWForum.Data.Models
{
    public class UserComment : BaseEntity
    {
        public User User { get; set; }

        public Comments Comment { get; set; }

        public Thread Thread { get; set; }
    }
}
