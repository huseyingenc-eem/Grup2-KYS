using FluentValidation.Results;
using KYS.Business.Abstractions;
using KYS.Business.Validators;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace KYS.Business.Services
{
    public class CommentService : IManager<Comment>
    {

        private readonly CommentRepository _cRepository;
        public CommentService(CommentRepository _cRepo)
        {
            _cRepository = _cRepo;
        }

        public void Create(Comment entity)
        {
            ValidationControl(entity);

            _cRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {



            _cRepository.Delete(Id);
        }

        public IEnumerable<Comment> GetAll()
        {
            return _cRepository.GetAll();
        }

        public Comment GetByID(Guid Id)
        {
            return _cRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Comment, bool>> filter)
        {
            return _cRepository.IfEntityExists(filter);
        }

        public void Update(Comment entity)
        {
            ValidationControl(entity);

            _cRepository.Update(entity);
        }

        public void ValidationControl(Comment entity)
        {
            CommentValidator cVal = new CommentValidator();
            ValidationResult result = cVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }
        }
    }
}
