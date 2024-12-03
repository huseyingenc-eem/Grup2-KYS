using FluentValidation.Results;
using KYS.Business.Abstractions;
using KYS.Business.Validators;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace KYS.Business.Services
{
    public class BorrowRecordService : IManager<BorrowRecord>
    {
        private readonly BorrowRecordRepository _bRepository;

        public BorrowRecordService(BorrowRecordRepository borrowRepo)
        {
            _bRepository = borrowRepo;
        }

        public void Create(BorrowRecord entity)
        {
            // validation control eklencek

            _bRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            

            _bRepository.Delete(Id);
        }

        public IEnumerable<BorrowRecord> GetAll()
        {
            return _bRepository.GetAll();
        }

        public BorrowRecord GetByID(Guid Id)
        {
            return _bRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<BorrowRecord, bool>> filter)
        {
            return _bRepository.IfEntityExists(filter);
        }

        public void Update(BorrowRecord entity)
        {
            //

            if (entity == null) 
                _bRepository.Update(entity);

        }

        public void ValidationControl(BorrowRecord entity)
        {
            BorrowRecordValidator bVal = new BorrowRecordValidator();
            ValidationResult result = bVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }

        }
    }
}
