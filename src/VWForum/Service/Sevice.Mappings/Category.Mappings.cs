using VWForum.Data.Models;
using VWForum.Service.Models;
namespace VWForum.Service.Mappings
{
    public static class CategoryMappings
    {
        public static Category ToEntity(this CategoryServiceModel model)
        {
            return new Category
            {
                Name = model.Name,
                Description = model.Description
            };
        }

        public static CategoryServiceModel ToModel(this Category entity)
        {
            return new CategoryServiceModel
            {
                Name = entity.Name,
                Description = entity.Description,
                CreatedOn =entity.CreatedOn,
                UpdatedOn = entity.UpdatedOn,
                DeletedOn = entity.DeletedOn,
                CreatedBy = entity.CreatedBy.ToModel(),
                UpdatedBy = entity.UpdatedBy.ToModel(),
                DeletedBy = entity.DeletedBy.ToModel(),
            };
        }
    }
}
