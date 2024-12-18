﻿using FluentValidation.Results;
using KYS.Business.Abstractions;
using KYS.Business.Validators;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using Microsoft.EntityFrameworkCore;
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
            //return _bRepository.GetAll();
            using var context = new ApplicationDBContext();
            return context.BorrowRecords
                .Include(borrow => borrow.Book)       
                .Include(borrow => borrow.User)     
                .ToList();
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
            if (entity != null) 
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
        private const decimal DailyLateFee = 2; 

        public decimal CalculateLateFee(BorrowRecord record)
        {
            // Eğer iade edilmemişse, bugüne kadar olan gecikmeyi hesapla
            DateTime referenceDate = record.ReturnDate ?? DateTime.Now;

            if (record.BorrowDate.HasValue && referenceDate > record.BorrowDate)
            {
                int lateDays = (referenceDate - record.BorrowDate.Value).Days;
                return lateDays * DailyLateFee; // Günlük gecikme çarpanı
            }

            return 0;
        }

        public void CancelExpiredReservations()
        {
            var expiredRecords = _bRepository.GetAll()
                .Where(r => r.Status == BorrowStatus.Ayırtıldı && r.CreatedDate <= DateTime.Now.AddDays(-1))
                .ToList();

            foreach (var record in expiredRecords)
            {
                record.Status = BorrowStatus.İptalEdildi; // Durumu güncelle
                _bRepository.Update(record);   // Her bir kayıt için Update metodunu çağır
            }
        }

    }
}
