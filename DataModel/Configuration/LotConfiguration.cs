using DataModel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Configuration
{
    public class LotConfiguration
    {
        public LotConfiguration(EntityTypeBuilder<Lot> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.ProductId).IsRequired();
            entityBuilder.Property(u => u.LotCode).IsRequired().HasMaxLength(250);
            entityBuilder.Property(u => u.ExpiredDate).IsRequired();
        }
    }
}
