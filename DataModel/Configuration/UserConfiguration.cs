using DataModel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Configuration
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.BusinessId).IsRequired();
            entityBuilder.Property(u => u.FirstName).HasMaxLength(250);
            entityBuilder.Property(u => u.LastName).HasMaxLength(250);
            entityBuilder.Property(u => u.Email).HasMaxLength(250);
            entityBuilder.Property(u => u.Phone).HasMaxLength(250);
            entityBuilder.Property(u => u.Address).HasMaxLength(250);

            entityBuilder.HasMany(e => e.Accounts).WithOne(e => e.User).HasForeignKey(e => e.UserId).IsRequired();

        }
    }
}
