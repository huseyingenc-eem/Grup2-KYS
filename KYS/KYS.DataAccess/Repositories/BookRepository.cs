using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KYS.DataAccess.Context;
using KYS.Entities.Models;

namespace KYS.DataAccess.Repositories
{
    public class BookRepository : GenericRepository<Book>
    {
        public BookRepository(ApplicationDBContext context) : base(context)
        {

        }
    }
}
