using DataModel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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

            entityBuilder.HasMany(e => e.Providers).WithOne(e => e.Account).HasForeignKey(e => e.AccountId).IsRequired();
            entityBuilder.HasMany(e => e.Categories).WithOne(e => e.Account).HasForeignKey(e => e.AccountId).IsRequired();
        }
    }
}
