using KYS.DataAccess.Context;
using KYS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYS.DataAccess.Repositories
{
    public class CommentRepository : GenericRepository<Comment>
    {
        public CommentRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
