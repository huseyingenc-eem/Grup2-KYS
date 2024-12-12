using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using KYS.UI.Forms.PanelForms;
using KYS.UI.Forms;
using KYS.UI.Forms.UserPanelForms;
using Microsoft.Extensions.DependencyInjection;

namespace KYS.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            // Uygulama baþlatýlmadan önce admin kontrolü
            EnsureAdminExists();

            // Uygulamayý baþlat
            ApplicationConfiguration.Initialize();

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
            //Application.Run(new ProfileForm());
        }

        static void EnsureAdminExists()
        {
            using (var dbContext = new ApplicationDBContext())
            {
                // Eðer admin kullanýcý yoksa, yeni bir admin ekle
                if (!dbContext.Users.Any(u => u.IsAdmin))
                {
                    dbContext.Users.Add(new User
                    {
                        Id = Guid.NewGuid(),
                        Username = "admin",
                        Name = "Admin",
                        Surname = "admin",
                        Password = "admin1",
                        Email = "admin@example.com",
                        IsAdmin = true,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        MaxBorrowLimit = 10
                    });

                    dbContext.SaveChanges();
                }
            }
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            // Baðýmlýlýklarý burada ekliyoruz
            services.AddScoped<ApplicationDBContext>();
            services.AddScoped<UserRepository>();
            services.AddScoped<UserService>();

            // Formlar
            services.AddScoped<Form1>();
            services.AddScoped<UserForm>();
            services.AddScoped<AdminPanel>();
            services.AddScoped<UserPanel>();
        }

    }
}