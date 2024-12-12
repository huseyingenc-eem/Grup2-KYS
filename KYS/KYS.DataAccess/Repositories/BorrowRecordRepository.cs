using KYS.DataAccess.Context;
using KYS.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYS.DataAccess.Repositories
{
    public class BorrowRecordRepository : GenericRepository<BorrowRecord>
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly DbSet<BorrowRecord> _dbSet;
        public BorrowRecordRepository(ApplicationDBContext context) : base(context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<BorrowRecord>();
        }
        public IEnumerable<BorrowRecord> GetByUserId(Guid userId)
        {
            return _dbSet
                .Include(br => br.Book)
                .Include(br => br.User)
                .Where(br => br.UserID == userId)
                .ToList();
        }

        public IEnumerable<BorrowRecord> SearchByBookName(Guid userId, string searchTerm)
        {
            return _dbSet
                .Include(br => br.Book)
                .Include(br => br.User)
                .Where(br => br.UserID == userId && br.Book.Name.Contains(searchTerm))
                .ToList();
        }
    }

}
