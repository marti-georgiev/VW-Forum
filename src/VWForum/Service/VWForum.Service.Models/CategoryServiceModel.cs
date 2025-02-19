namespace VWForum.Service.Models
{
    public class CategoryServiceModel : MetadataBaseServiceModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<TagsServiceModel> Tags { get; set; }
    }
}
