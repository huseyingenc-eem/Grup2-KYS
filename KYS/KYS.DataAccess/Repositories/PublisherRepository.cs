using KYS.DataAccess.Context;
using KYS.Entities.Models;

namespace KYS.DataAccess.Repositories
{
    public class PublisherRepository: GenericRepository<Publisher>
    {
        public PublisherRepository(ApplicationDBContext context) : base(context)
        {

        }
    }
}
