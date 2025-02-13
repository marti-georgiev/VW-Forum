using VWForum.Data.Models;
using VWForum.Data.Repositories;
using VWForum.Service.Models;
using VWForum.Service.Mappings;

namespace VWForum.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly CategoryRepository categoryRepository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<CategoryServiceModel> CreateAsync(CategoryServiceModel model)
        {
            Category category = model.ToEntity();
            await this.categoryRepository.CreateAsync(category);
            return category.ToModel();
        }

        public async Task<CategoryServiceModel> UpdateAsync(CategoryServiceModel model)
        {
            throw new System.NotImplementedException();
        }

        public async Task<CategoryServiceModel> DeleteAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<CategoryServiceModel> GetAsync(string id)
        {
            throw new System.NotImplementedException();
        }   

        public IQueryable<CategoryService> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryService> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryService> CreateAsync(CategoryService model)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryService> UpdateAsync(CategoryService model)
        {
            throw new NotImplementedException();
        }

        Task<CategoryService> IGenericService<CategoryService, CategoryServiceModel>.DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
