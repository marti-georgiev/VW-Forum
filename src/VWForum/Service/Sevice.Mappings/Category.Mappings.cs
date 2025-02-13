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
            return null;
        }
    }
}
