using KYS.DataAccess.Abstractions;
using KYS.DataAccess.Context;
using KYS.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KYS.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDBContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<T>();
        }
        
        public void Create( T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            _dbSet.Remove(GetByID(Id));
            _dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetByID(Guid Id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == Id) ?? throw new Exception("Bulunamadı");
        }

        public bool IfEntityExists(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Any(filter);
        }

        public void Update(T entity)
        {
            //var trackedEntity = _dbSet.Local.FirstOrDefault(e => e.Id == entity.Id);
            //if (trackedEntity != null)
            //{
            //    _dbContext.Entry(trackedEntity).State = EntityState.Detached; // Daha önce izlenen nesneyi ayır
            //}

            //_dbSet.Update(entity); // Yeni nesneyi güncelle
            //_dbContext.SaveChanges(); // Değişiklikleri kaydet
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        
    }
}
