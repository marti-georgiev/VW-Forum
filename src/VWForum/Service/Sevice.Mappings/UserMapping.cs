
using System.Net.Http.Headers;
using VWForum.Data.Models;
using VWForum.Service.Models;

namespace VWForum.Service.Mappings
{
    public static class UserMapping
    {
        public static ForumUser ToEntity(this UserServiceModel model)
        {
            return new ForumUser();
        }
        public static UserServiceModel ToModel(this ForumUser entity)
        {
            return new UserServiceModel()
            {
                ForumRole = entity.ForumRole?.ToModel(),
                Email = entity.Email,
                UserName = entity.UserName,
                Id = entity.Id,            
            };
        }
    }
}
