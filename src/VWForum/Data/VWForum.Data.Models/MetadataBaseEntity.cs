namespace VWForum.Data.Models
{
    public abstract class MetadataBaseEntity : BaseEntity
    {
        public  ForumUser CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; } 

        public  ForumUser? UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public  ForumUser? DeletedBy { get; set; }

        public DateTime? DeletedOn { get; set; } 


    }
}
