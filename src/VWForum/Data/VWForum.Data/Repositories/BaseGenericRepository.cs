using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VWForum.Data.Models;
using VWForum.Web.Data;

namespace VWForum.Data.Repositories
{
    public abstract class BaseGenericRepository<TEntity> : IGenericRepositories<TEntity> where TEntity : BaseEntity
    {
        protected readonly VWForumDbContext _dbContext;

        protected BaseGenericRepository(VWForumDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            await this._dbContext.AddAsync(entity);
            await this._dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> DeleteAsync(TEntity entity)
        {
            this._dbContext.Remove(entity);
            await this._dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            this._dbContext.Update(entity);
            await this._dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return this._dbContext.Set<TEntity>().AsQueryable<TEntity>();
        }

        public virtual IQueryable<TEntity> GetAllAsNoTracking()
        {
            return this._dbContext.Set<TEntity>().AsNoTracking();
        }

        public Task<TEntity> CreateAsyn(TEntity enity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> EdditAsync(TEntity enity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> DelliteAsync(TEntity enity)
        {
            throw new NotImplementedException();
        }
    }
}
