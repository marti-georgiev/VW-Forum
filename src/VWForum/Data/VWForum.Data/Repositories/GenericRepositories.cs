namespace VWForum.Data.Repositories
{
    public interface IGenericRepositories<Tkey, TEnity>
    {
        Task<TEnity> CreateAsyn(TEnity enity);

        IQueryable<TEnity> GetAll();

        IQueryable<TEnity> GetAllAsNoTracking();

        Task<TEnity> EdditAsync(TEnity enity);

        Task<TEnity> DelliteAsync(TEnity enity);
    }
}
    