using VWForum.Service.Models;
using VWForum.Data.Repositories;
using VWForum.Data.Models;
using VWForum.Service.Mappings;
using Microsoft.EntityFrameworkCore;
using VWForum.Service.Tag;


namespace VWForum.Service.Community
{
    public class CategoryService : ICategoryService
    {
        private readonly CategoryRepository categoryRepository;

        private readonly ITagService tagService;

        public CategoryService(CategoryRepository categoryRepository, ITagService tagService)
        {
            this.categoryRepository = categoryRepository;

            this.tagService = tagService;
        }

        public async Task<CategoryServiceModel> CreateAsync(CategoryServiceModel model)
        {
            Category category = model.ToEntity();

            category.Tags = category.Tags.Select(async tag => {
            return (await this.tagService.InternalCreateAsync(tag));
        }).Select(t => t.Result).ToList();

            await categoryRepository.CreateAsync(category);

            return category.ToModel();
        }
        public Task<Category> InternalCreateAsync(Category model)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryServiceModel> DeleteAsync(string id)
        {
            Category category = await categoryRepository.GetAll().SingleOrDefaultAsync(c => c.Id == id);

            if (category == null)
            {
                throw new InvalidOperationException("Category not found");
            }

            await categoryRepository.DeleteAsync(category);

            return category.ToModel();
        }

        public IQueryable<CategoryServiceModel> GetAll()
        {
            return categoryRepository.GetAll()
                .Include(c => c.CreatedBy)
                .Include(c => c.UpdatedBy)
                .Include(c => c.DeletedBy)
                .Select(c => c.ToModel());
        }

        public async Task<CategoryServiceModel> GetByIdAsync(string id)
        {
            return (await categoryRepository.GetAll()
                .Include(c => c.CreatedBy)
                .Include(c => c.UpdatedBy)
                .Include(c => c.DeletedBy)
                .SingleOrDefaultAsync(c => c.Id == id))?.ToModel();
        }

     
        public async Task<CategoryServiceModel> UpdateAsync(string id, CategoryServiceModel model)
        {
            Category category = await categoryRepository.GetAll().SingleOrDefaultAsync(c => c.Id == id);

            if (category == null)
            {
                throw new InvalidOperationException("Category not found");
            }
            category.Name = model.Name;
            category.Description = model.Description;

            await categoryRepository.UpdateAsync(category);

            return category.ToModel();
        }
    }
}
