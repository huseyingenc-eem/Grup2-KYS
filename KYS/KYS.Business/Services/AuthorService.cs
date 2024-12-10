using FluentValidation.Results;
using KYS.Business.Abstractions;
using KYS.Business.Validators;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace KYS.Business.Services
{
    public class AuthorService : IManager<Author>
    {
        private readonly AuthorRepository _authorRepository;
        public AuthorService(AuthorRepository aRepo)
        {
            _authorRepository = aRepo;
        }
        public void Create(Author entity)
        {
            ValidationControl(entity);

            _authorRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var aut = _authorRepository.GetByID(Id);

            if (aut != null)
            {
                _authorRepository.Delete(Id);
            }
        }

        public IEnumerable<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author GetByID(Guid Id)
        {
            return _authorRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Author, bool>> filter)
        {
            return _authorRepository.IfEntityExists(filter);
        }

        public void Update(Author entity)
        {
            ValidationControl(entity);

            _authorRepository.Update(entity);
        }

        public void ValidationControl(Author entity)
        {
            AuthorValidator aVal = new AuthorValidator();
            ValidationResult result = aVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }
        }
    }
}
