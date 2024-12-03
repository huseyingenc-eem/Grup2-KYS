using KYS.DataAccess.Abstractions;
using KYS.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KYS.Business.Abstractions
{
    public interface IManager<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid Id);
        IEnumerable<T> GetAll();
        T GetByID(Guid Id);
        void ValidationControl(T entity);
        bool IfEntityExists(Expression<Func<T, bool>> filter);
    }
}
