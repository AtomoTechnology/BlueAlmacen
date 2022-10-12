using DataModel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Configuration
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.AccountId).IsRequired();
            entityBuilder.Property(u => u.ProductCode).IsRequired().HasMaxLength(250);
            entityBuilder.Property(u => u.ProductName).IsRequired().HasMaxLength(250);
            entityBuilder.Property(u => u.ProviderId).IsRequired();
            entityBuilder.Property(u => u.Stock).IsRequired();
            entityBuilder.Property(u => u.AccountId).IsRequired();
            entityBuilder.Property(u => u.CreatedDate).IsRequired();
            entityBuilder.Property(u => u.PurchasePrice).IsRequired();
            entityBuilder.Property(u => u.SalePrice).IsRequired();

            entityBuilder.HasMany(e => e.Lots).WithOne(e => e.Product).HasForeignKey(e => e.ProductId).IsRequired();
            entityBuilder.HasMany(e => e.HistoryPrice).WithOne(e => e.Product).HasForeignKey(e => e.ProductId).IsRequired();
        }
    }
}
