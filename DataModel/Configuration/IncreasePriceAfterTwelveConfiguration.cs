using DataModel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Configuration
{
    public class IncreasePriceAfterTwelveConfiguration
    {
        public IncreasePriceAfterTwelveConfiguration(EntityTypeBuilder<IncreasePriceAfterTwelve> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.AccountId).IsRequired();
            entityBuilder.Property(u => u.DateFrom).IsRequired();
            entityBuilder.Property(u => u.DateTo).IsRequired();
            entityBuilder.Property(u => u.Porcent).IsRequired();
            entityBuilder.Property(u => u.IsActive).IsRequired();
        }
    }
}
