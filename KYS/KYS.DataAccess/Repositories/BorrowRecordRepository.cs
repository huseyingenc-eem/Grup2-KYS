using KYS.DataAccess.Context;
using KYS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYS.DataAccess.Repositories
{
    public class BorrowRecordRepository : GenericRepository<BorrowRecord>
    {
        public BorrowRecordRepository(ApplicationDBContext context) : base(context)
        {

        }
    }
}
