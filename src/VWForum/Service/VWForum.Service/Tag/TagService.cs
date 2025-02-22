using VWForum.Data.Models;
using VWForum.Data.Repositories;
using VWForum.Service.Models;
using VWForum.Service.Mappings;

namespace VWForum.Service.Tag
{
    public class TagService : ITagService
    {
        private readonly TagsRepository tagRepository;

        public TagService(TagsRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }

        public async Task<TagsServiceModel> CreateAsync(TagsServiceModel model)
        {
            return (await this.tagRepository.CreateAsync(model.ToEntity())).ToModel();


        }
        public async Task<VWTags> InternalCreateAsync(VWTags entity)
        {
            return await this.tagRepository.CreateAsync(entity);
        }
        public Task<TagsServiceModel> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TagsServiceModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TagsServiceModel> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        

        public Task<TagsServiceModel> UpdateAsync(string id, TagsServiceModel model)
        {
            throw new NotImplementedException();
        }
    }
}
