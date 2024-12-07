using FluentValidation.Results;
using KYS.Business.Abstractions;
using KYS.Business.Validators;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KYS.Business.Services
{
    public class UserService : IManager<User>
    {
        private readonly UserRepository _uRepository;

        public UserService(UserRepository userRepo)
        {
            _uRepository = userRepo;
        }
        public void Create(User entity)
        {
            ValidationControl(entity);

           _uRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            _uRepository.Delete(Id);
        }

        public IEnumerable<User> GetAll()
        {

            return _uRepository.GetAll();
        }

        public User GetByID(Guid Id)
        {

            return _uRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<User, bool>> filter)
        {

            return _uRepository.IfEntityExists(filter);
        }

        public void Update(User entity)
        {
            ValidationControl(entity);

            _uRepository.Update(entity);
        }

        public void ValidationControl(User entity)
        {
            UserValidator uVal = new UserValidator();
            ValidationResult result = uVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }
        }
        public User Authenticate(string username, string password)
        {
            // Veritabanında kullanıcı sorgulama
            var user = _uRepository.GetAll().FirstOrDefault(u => u.Username == username && u.Password == password);

            // Kullanıcı yoksa hata fırlat
            if (user == null)
                throw new Exception("Kullanıcı adı veya şifre yanlış.");

            return user;
        }
    }
}
