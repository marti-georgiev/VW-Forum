using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using VWForum.Data.Models;
using VWForum.Web.Data;

namespace VWForum.Data.Repositories
{
    public class AttachmentRepository : BaseGenericRepository<Attachment>
    {
      public AttachmentRepository(VWForumDbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
