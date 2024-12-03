using FluentValidation.Results;
using KYS.Business.Abstractions;
using KYS.Business.Validators;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace KYS.Business.Services
{
    public class DuyurularService : IManager<Duyurular>
    {
        private readonly DuyurularRepository _dRepository;

        public DuyurularService(DuyurularRepository duyuruRepo)
        {
            _dRepository = duyuruRepo;
        }
        public void Create(Duyurular entity)
        {
            ValidationControl(entity);
            _dRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {

            _dRepository.Delete(Id);
        }

        public IEnumerable<Duyurular> GetAll()
        {
            return _dRepository.GetAll();
        }

        public Duyurular GetByID(Guid Id)
        {
            return _dRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Duyurular, bool>> filter)
        {
            return _dRepository.IfEntityExists(filter);
        }

        public void Update(Duyurular entity)
        {
            ValidationControl(entity);
            _dRepository.Update(entity);
        }

        public void ValidationControl(Duyurular entity)
        {
            DuyurularValidator dVal = new DuyurularValidator();
            ValidationResult result = dVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }
        }
    }
}
