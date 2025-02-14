namespace VWForum.Data.Repositories
{
    public interface IGenericRepositories<TEnity>
    {
        Task<TEnity> CreateAsyn(TEnity enity);

        IQueryable<TEnity> GetAll();

        IQueryable<TEnity> GetAllAsNoTracking();

        Task<TEnity> UpdateAsync(TEnity enity);

        Task<TEnity> DelliteAsync(TEnity enity);
    }
}
    