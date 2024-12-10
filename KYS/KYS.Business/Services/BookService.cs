using FluentValidation.Results;
using KYS.Business.Abstractions;
using KYS.Business.Validators;
using KYS.DataAccess.Abstractions;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using KYS.DataAccess.Context;
namespace KYS.Business.Services
{
    public class BookService : IManager<Book>
    {
        private readonly BookRepository _bookRepository;
        public BookService(BookRepository bRepo)
        {
            _bookRepository = bRepo;
        }
        public void Create(Book entity)
        {
            ValidationControl(entity);

            _bookRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var book = _bookRepository.GetByID(Id);

            if (book != null)
            {
                _bookRepository.Delete(Id);
            }
        }

        public IEnumerable<Book> GetAll()
        {
            //return _bookRepository.GetAll();
            using var context = new ApplicationDBContext();
            return context.Books
                .Include(b => b.Author)       // Author bilgilerini yükler
                .Include(b => b.BookType)     // BookType bilgilerini yükler
                .Include(b => b.Publisher)    // Publisher bilgilerini yükler
                .ToList();
        }

        public Book GetByID(Guid Id)
        {
            return _bookRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Book, bool>> filter)
        {
            return _bookRepository.IfEntityExists(filter);
        }

        public void Update(Book entity)
        {
            ValidationControl(entity);

            _bookRepository.Update(entity);
        }

        public void ValidationControl(Book entity)
        {
            BookValidator bVal = new BookValidator();
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
