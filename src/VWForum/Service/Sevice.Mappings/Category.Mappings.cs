using VWForum.Data.Models;
using VWForum.Service.Models;
using VWForum.Service.Mappings;  

namespace VWForum.Service.Mappings
{
    public static class CategoryMappings
    {
        public static Category ToEntity(this CategoryServiceModel model)
        {
            return new Category
            {
                Name = model.Name,
                Tags = model.Tags?.Select(tag => tag.ToEntity()).ToList() ?? new List<VWTags>(), 
                Description = model.Description,
            };
        }

        public static CategoryServiceModel ToModel(this Category entity)
        {
            return new CategoryServiceModel
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                CreatedOn = entity.CreatedOn,
                Tags = entity.Tags?.Select(tag => tag.ToModel()).ToList() ?? new List<TagsServiceModel>(), 
                UpdatedOn = entity.UpdatedOn,
                DeletedOn = entity.DeletedOn,
                CreatedBy = entity.CreatedBy?.ToModel(),
                UpdatedBy = entity.UpdatedBy?.ToModel(),
                DeletedBy = entity.DeletedBy?.ToModel(),
            };
        }
    }
}
