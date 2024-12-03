using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KYS.DataAccess.Context;
using KYS.Entities.Models;

namespace KYS.DataAccess.Repositories
{
    public class AuthorRepository : GenericRepository<Author>
    {
        public AuthorRepository(ApplicationDBContext context) : base(context)
        {

        }
    }
}
