using DataModel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resolver.Enums;
using Resolver.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Configuration
{
    public class AccountConfiguration
    {
        public AccountConfiguration(EntityTypeBuilder<Account> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.UserId).IsRequired();
            entityBuilder.Property(u => u.RoleId).IsRequired();
            entityBuilder.Property(u => u.UserName).IsRequired().HasMaxLength(50);
            entityBuilder.Property(u => u.UserPass).IsRequired().HasMaxLength(50);
            var contra = "sanlorenzo";
           
            entityBuilder.HasData(                
                new Account() {
                    Id  ="3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate=(DateTime)DateTime.Now,
                    state = (Int32)StateEnum.Activeted,
                    Confirm = true,
                    RoleId = "82a0bec6-8266-443a-84a2-af85ad69348b",
                    UserId = "362c2637-2ad9-449a-9498-dbd74be87ee8",
                    UserName = "almacen",
                    UserPass = PassValidation.GetInstance().Encypt(contra)
                }
            );
            
            entityBuilder.HasMany(e => e.Providers).WithOne(e => e.Account).HasForeignKey(e => e.AccountId).IsRequired();
            entityBuilder.HasMany(e => e.Categories).WithOne(e => e.Account).HasForeignKey(e => e.AccountId).IsRequired();
            entityBuilder.HasMany(e => e.IncreasePriceAfterTwelve).WithOne(e => e.Account).HasForeignKey(e => e.AccountId).IsRequired();
        }
    }
}
