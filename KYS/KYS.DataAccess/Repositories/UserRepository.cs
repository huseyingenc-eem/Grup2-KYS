using KYS.DataAccess.Context;
using KYS.Entities.Models;

namespace KYS.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
