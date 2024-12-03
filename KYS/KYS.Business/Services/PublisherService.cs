using FluentValidation.Results;
using KYS.Business.Abstractions;
using KYS.Business.Validators;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace KYS.Business.Services
{
    public class PublisherService : IManager<Publisher>
    {
        private readonly PublisherRepository _pRepository;

        public PublisherService(PublisherRepository pRepo)
        {
            _pRepository = pRepo;
        }

        public void Create(Publisher entity)
        {
            ValidationControl(entity);

            _pRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            _pRepository.Delete(Id);
        }

        public IEnumerable<Publisher> GetAll()
        {
            return _pRepository.GetAll();
        }

        public Publisher GetByID(Guid Id)
        {
            return _pRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Publisher, bool>> filter)
        {
            return _pRepository.IfEntityExists(filter);
        }

        public void Update(Publisher entity)
        {
            ValidationControl(entity);

            _pRepository.Update(entity);
        }

        public void ValidationControl(Publisher entity)
        {
            PublisherValidator uVal = new PublisherValidator();
            ValidationResult result = uVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }
        }
    }
}
