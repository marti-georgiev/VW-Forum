using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using VWForum.Data.Models;

namespace VWForum.Data.Repositories
{
    public class TagsRepository : MetaDataBaseGenericRepository<VWTags>
    {
        public TagsRepository(VWForumDbContext dbcontext, IHttpContextAccessor? httpContextAccessor) : base(dbcontext, httpContextAccessor)
        {
        }
    }
}
