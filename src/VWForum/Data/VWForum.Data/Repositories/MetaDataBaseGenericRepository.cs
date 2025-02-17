using System.Collections;
using VWForum.Data.Models;
using VWForum.Web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace VWForum.Data.Repositories
{
    public abstract class MetaDataBaseGenericRepository<TEntity> : BaseGenericRepository<TEntity> where TEntity : MetadataBaseEntity
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        protected MetaDataBaseGenericRepository(VWForumDbContext dbcontext, IHttpContextAccessor? httpContextAccessor) : base(dbcontext)
        {
            this._httpContextAccessor = httpContextAccessor;
        }

        public override async Task<TEntity> CreateAsync(TEntity entity)
        {

            entity.CreatedOn = DateTime.UtcNow;
            entity.CreatedBy = await GetUser();
            return await base.CreateAsync(entity);

        }
        public override async Task<TEntity> UpdateAsync(TEntity entity)
        {
            entity.UpdatedOn = DateTime.UtcNow;
            entity.UpdatedBy = await GetUser();
            return await base.UpdateAsync(entity);
        }

        public override async Task<TEntity> DeleteAsync(TEntity entity)
        {
            entity.DeletedOn = DateTime.UtcNow;
            entity.DeletedBy = await GetUser();
            return await base.UpdateAsync(entity);
        }


        private async Task<ForumUser> GetUser()
        {
            string userId = this._httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await this._dbContext.Users.SingleOrDefaultAsync(user => user.Id == userId);
        }
    }
}
