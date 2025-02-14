using VWForum.Data.Models;
using VWForum.Service.Models;

namespace VWForum.Service.Mappings
{
    public static class RoleMapping
    {
        public static Role ToEntity(this RoleServiceModel model)
        {
            return new Role
            {
                Labele = model.Labele,
                Color = model.Color,
                Authority = model.Authority
            };
        }
        public static RoleServiceModel ToModel(this Role entity)
        {
            return new RoleServiceModel
            {
                Labele = entity.Labele,
                Color = entity.Color,
                Authority = entity.Authority,
                Id = entity.Id,
            };
        }
    }
}
