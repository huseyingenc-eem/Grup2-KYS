using KYS.Entities.Abstractions;
using System.Linq.Expressions;

namespace KYS.DataAccess.Abstractions
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid Id);
        IEnumerable<T> GetAll();
        T GetByID(Guid Id);
        bool IfEntityExists(Expression<Func<T, bool>> filter);
    }
}