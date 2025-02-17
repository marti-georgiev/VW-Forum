namespace VWForum.Data.Models
{
    public class UserReactionMapping : BaseEntity
    {
        public ForumUser User { get; set; }

        public Reactions Reactions { get; set; }

        public VWThread Thread { get; set; }  

    }   
}
