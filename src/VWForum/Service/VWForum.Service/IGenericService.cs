using VWForum.Service.Models;

namespace VWForum.Service
{
    public interface IGenericService<TModel, TEntity>
    {
        IQueryable<TModel> GetAll();

        Task<TModel> GetByIdAsync(string id);

        Task<TModel> CreateAsync(TModel model);    

        Task<TModel> UpdateAsync(TModel model);

        Task<TModel> DeleteAsync(string id);
    }
}
