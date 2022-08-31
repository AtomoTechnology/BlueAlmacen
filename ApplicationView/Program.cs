using ApplicationView.Forms.Business;
using ApplicationView.Forms.Roles;
using DataModel.Context;
using DataModel.Repositories.IRepository;
using DataModel.Repositories.Repository;
using DataService.Iservice;
using DataService.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ApplicationView
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<frmlogin>());

        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddDbContext<DbGestionStockContext>(options => options.UseSqlServer(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString));
                    services.AddScoped<frmrole>();
                    services.AddScoped<frmlogin>();
                    services.AddScoped<frmbusiness>();

                    services.AddScoped<IRoleRepository, RoleRepository>();
                    services.AddScoped<IBusinessRepository, BusinessRepository>();
                    services.AddScoped<IAccountRepository, AccountRepository>();

                    services.AddScoped<IRoleService, RoleService>();
                    services.AddScoped<IBusnessService, BusnessService>();
                    services.AddScoped<IAccountService, AccountService>();
                });
        }
    }
}
