
using System.Net.Http.Headers;
using VWForum.Data.Models;
using VWForum.Service.Models;

namespace VWForum.Service.Mappings
{
    public static class UserMapping
    {
        public static User ToEntity(this UserServiceModel model)
        {
            return new User();
        }
        public static UserServiceModel ToModel(this User entity)
        {
            return new UserServiceModel()
            {
                ForumRole = entity.ForumRole.ToModel(),
                Email = entity.Email,
                UserName = entity.UserName,
                Id = entity.Id,            
            };
        }
    }
}
