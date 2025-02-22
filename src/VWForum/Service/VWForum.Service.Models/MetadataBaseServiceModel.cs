namespace VWForum.Service.Models
{
    public abstract class MetadataBaseServiceModel : BaseServiceModel
    {
        public  UserServiceModel CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; } 

        public  UserServiceModel? UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public  UserServiceModel? DeletedBy { get; set; }

        public DateTime? DeletedOn { get; set; } 


    }
}
