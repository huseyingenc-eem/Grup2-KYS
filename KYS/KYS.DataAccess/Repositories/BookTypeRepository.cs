using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KYS.DataAccess.Context;
using KYS.Entities.Models;

namespace KYS.DataAccess.Repositories
{
    public class BookTypeRepository : GenericRepository<BookType>
    {
        public BookTypeRepository(ApplicationDBContext context) : base(context)
        {

        }
    }
}
