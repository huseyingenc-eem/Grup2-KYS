using FluentValidation.Results;
using KYS.Business.Abstractions;
using KYS.Business.Validators;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace KYS.Business.Services
{
    public class BookTypeService : IManager<BookType>
    {
        private readonly BookTypeRepository _typeRepository;
        public BookTypeService(BookTypeRepository tRepo)
        {
            _typeRepository = tRepo;
        }
        public void Create(BookType entity)
        {

            ValidationControl(entity);

            _typeRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var typ = _typeRepository.GetByID(Id);

            if (typ != null)
            {
                _typeRepository.Delete(Id);
            }
        }

        public IEnumerable<BookType> GetAll()
        {
            return _typeRepository.GetAll();
        }

        public BookType GetByID(Guid Id)
        {
            return _typeRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<BookType, bool>> filter)
        {
            return _typeRepository.IfEntityExists(filter);
        }

        public void Update(BookType entity)
        {
            ValidationControl(entity);

            _typeRepository.Update(entity);
        }

        public void ValidationControl(BookType entity)
        {
            BookTypeValidator tVal = new BookTypeValidator();
            ValidationResult result = tVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }
        }
    }
}
