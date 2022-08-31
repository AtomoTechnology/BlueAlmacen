using DataModel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Configuration
{
    public class BusinessConfiguration
    {
        public BusinessConfiguration(EntityTypeBuilder<Business> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.BusinessName).IsRequired().HasMaxLength(250);
            entityBuilder.Property(u => u.Cuit_Cuil).HasMaxLength(20);
            entityBuilder.Property(u => u.Address).HasMaxLength(250);
            entityBuilder.Property(u => u.Phone).HasMaxLength(250);

            entityBuilder.HasMany(e => e.Users).WithOne(e => e.Business).HasForeignKey(e => e.BusinessId).IsRequired();
        }
    }
}
