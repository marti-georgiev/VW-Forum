namespace VWForum.Data.Models
{
    public abstract class MetadataBaseEntity : BaseEntity
    {
        public  User CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; } 

        public  User UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        public  User DeletedBy { get; set; }

        public DateTime DeletedOn { get; set; } 


    }
}
