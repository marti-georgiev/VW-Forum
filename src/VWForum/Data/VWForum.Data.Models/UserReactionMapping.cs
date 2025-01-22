namespace VWForum.Data.Models
{
    public class UserReactionMapping : BaseEntity
    {
        public User User { get; set; }

        public Reactions Reactions { get; set; }

        public Thread Thread { get; set; }  

    }   
}
