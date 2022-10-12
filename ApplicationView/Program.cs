using ApplicationView.Forms.Business;
using ApplicationView.Forms.Category;
using ApplicationView.Forms.Configurations;
using ApplicationView.Forms.Product;
using ApplicationView.Forms.Provider;
using ApplicationView.Forms.Roles;
using ApplicationView.Forms.Sale;
using DataModel.Context;
using DataModel.Repositories.IRepository;
using DataModel.Repositories.Repository;
using DataService.Iservice;
using DataService.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

            //var builder = WebApplication;

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            //UpdateDataBase(ServiceProvider);

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
                    services.AddScoped<frmcategory>(); 
                    services.AddScoped<frmprovider>();
                    services.AddScoped<frmProduct>();
                    services.AddScoped<frmIncreasePriceAfterTwelve>();
                    
                        //services.AddEntityFrameworkS<DbGestionStockContext>();

                    services.AddScoped<IRoleRepository, RoleRepository>();
                    services.AddScoped<IBusinessRepository, BusinessRepository>();
                    services.AddScoped<IAccountRepository, AccountRepository>();
                    services.AddScoped<ICategoryRepository, CategoryRepository>();
                    services.AddScoped<IProviderRepository, ProviderRepository>();
                    services.AddScoped<IProductRepository, ProductRepository>();
                    services.AddScoped<ISaleRepository, SaleRepository>();
                    services.AddScoped<ISaleDetailRepoository, SaleDetailRepoository>();
                    services.AddScoped<IIncreasePriceAfterTwelveRepository, IncreasePriceAfterTwelveRepository>();

                    services.AddScoped<IRoleService, RoleService>();
                    services.AddScoped<IBusnessService, BusnessService>();
                    services.AddScoped<IAccountService, AccountService>();
                    services.AddScoped<ICategoryService, CategoryService>();
                    services.AddScoped<IProviderService, ProviderService>();
                    services.AddScoped<IProductService, ProductService>();
                    services.AddScoped<ISaleService, SaleService>();
                    services.AddScoped<ISaleDetailService, SaleDetailService>();
                    services.AddScoped<IIncreasePriceAfterTwelveService, IncreasePriceAfterTwelveService>();

                });
        }

        private static void UpdateDataBase(IServiceProvider serviceScopp)
        {
            using (var contex = serviceScopp.GetService<DbGestionStockContext>())
            {
                var builder = new ConfigurationBuilder()
                    .AddJsonFile("appsetting.json", optional: false, reloadOnChange: true);
                var configuration = builder.Build();

                var logFile = configuration["Runtimeenvironment:environment"];
                if (logFile.Equals("dev"))
                    contex.Database.EnsureCreated();
            }
        }
    }
}
