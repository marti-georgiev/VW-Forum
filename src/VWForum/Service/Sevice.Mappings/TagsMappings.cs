using VWForum.Data.Models;
using VWForum.Service.Models;

namespace VWForum.Service.Mappings
{
    public static class TagsMappings
    {
        public static VWTags ToEntity(this TagsServiceModel model)
        {
            return new VWTags
            {
                Lable = model.Lable
            };
        }

        public static TagsServiceModel ToModel(this VWTags entity)
        {
            return new TagsServiceModel
            {
                Id = entity.Id,
                Lable = entity.Lable,
                CreatedOn = entity.CreatedOn,
                UpdatedOn = entity.UpdatedOn,
                DeletedOn = entity.DeletedOn,
                CreatedBy = entity.CreatedBy?.ToModel(),  
                UpdatedBy = entity.UpdatedBy?.ToModel(),
                DeletedBy = entity.DeletedBy?.ToModel()
            };
        }
    }
}
