using DataModel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resolver.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Configuration
{
    public class CategoryConfiguration
    {
        public CategoryConfiguration(EntityTypeBuilder<Category> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.CategoryName).IsRequired().HasMaxLength(250);
            entityBuilder.Property(u => u.Description).HasMaxLength(250);

            entityBuilder.HasData(
                new Category()
                {
                    Id = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    CategoryName = "Perfumeria",
                    Description = "Se encuentra todo sobre perfumeria",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }
            );

        }
    }
}
