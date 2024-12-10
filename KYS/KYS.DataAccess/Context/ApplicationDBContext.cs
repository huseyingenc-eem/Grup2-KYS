using KYS.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace KYS.DataAccess.Context
{
    public class ApplicationDBContext : DbContext
    {

        // buraya aşağıdaki yorum satırı gibi entity eklemeleri yapılacak.
        public DbSet<Duyurular> Duyurular { get; set; }         // Duyurular
        public DbSet<BookType> BookTypes { get; set; }          // Türler
        public DbSet<Author> Authors { get; set; }              // Yazarlar
        public DbSet<Book> Books { get; set; }                  // Kitaplar
        public DbSet<User> Users { get; set; }                  // Kullanıcılar
        public DbSet<BorrowRecord> BorrowRecords { get; set; }  // Ödünç Alma 
        public DbSet<Comment> Comments { get; set; }            //Yorumlar
        public DbSet<Publisher> Publishers { get; set; }        //Yayıncı



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["HUSEYIN"]?.ConnectionString);
        }

        
            

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //OrderDetail tablosunun ID alınını iptal edeceğiz:
            modelBuilder.Entity<BorrowRecord>().Ignore(x => x.Id);

            //Bunun yerine ProductID ve OrderID alanlarını Composite Key yapacağız:
            modelBuilder.Entity<BorrowRecord>().HasKey(b => new
            {
                b.BookID,
                b.UserID
            });

            modelBuilder.Entity<Comment>().Ignore(x => x.Id);

            //Bunun yerine ProductID ve OrderID alanlarını Composite Key yapacağız:
            modelBuilder.Entity<Comment>().HasKey(b => new
            {
                b.BookID,
                b.UserID
            });
        }

    }
}
