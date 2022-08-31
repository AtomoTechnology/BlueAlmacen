﻿using DataModel.Configuration;
using DataModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;

namespace DataModel.Context
{
    public partial class DbGestionStockContext : DbContext
    {
        public DbGestionStockContext(DbContextOptions<DbGestionStockContext> options) : base(options)
        {
        }

        #region Dbset
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        #endregion

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.
        //        UseSqlServer("data source=DESKTOP-KOS4DK0\\PRADE;initial catalog=bluedbventa_db;user id=sa;password=516euge94324590;MultipleActiveResultSets=True;")
        //        .EnableSensitiveDataLogging(true);
        //    //var builder = new ConfigurationBuilder()
        //    //                   .SetBasePath(Directory.GetCurrentDirectory())
        //    //                   .AddJsonFile("sppsetting.json");

        //    //var configuration =builder.Build();
        //    //optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
            .SelectMany(t => t.GetForeignKeys())
            .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            ModelConfig(modelBuilder);
        }


        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new AccountConfiguration(modelBuilder.Entity<Account>());
            new BusinessConfiguration(modelBuilder.Entity<Business>());
            new ProviderConfiguration(modelBuilder.Entity<Provider>());
            new UserConfiguration(modelBuilder.Entity<User>());
            new RoleConfiguration(modelBuilder.Entity<Role>());
        }
    }
}
