using VWForum.Data.Models;
using VWForum.Service.Models;

namespace VWForum.Service.Mappings
{
    public static class AttachmentMapping
    {
        public static Attachment ToEntity(this AttachmentServiceModel model)
        {
            return new Attachment
            {
                CloudURL = model.CloudURL
            };

        }

        public static AttachmentServiceModel ToModel(this Attachment entity)
        {
            return new AttachmentServiceModel
            {
                Id = entity.Id,
                CloudURL = entity.CloudURL,
            };
        }
    }
}
