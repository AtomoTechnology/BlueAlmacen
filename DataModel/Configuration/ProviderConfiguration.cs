using DataModel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Configuration
{
    public class ProviderConfiguration
    {
        public ProviderConfiguration(EntityTypeBuilder<Provider> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.AccountId).IsRequired();
            entityBuilder.Property(u => u.Name).IsRequired().HasMaxLength(250);
            entityBuilder.Property(u => u.Address).HasMaxLength(250);
            entityBuilder.Property(u => u.Phone).HasMaxLength(250);
            entityBuilder.Property(u => u.Cuit_Cuil).HasMaxLength(250);
        }
    }
}
