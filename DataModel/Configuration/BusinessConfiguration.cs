using DataModel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resolver.Enums;
using Resolver.Security;
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

            entityBuilder.HasData(
                new Business()
                {
                    Id = "de07358c-3a51-42fb-8690-c383b91b5844",
                    Address = "San Lorenzo",
                    BusinessName = "Almacen",
                    CreatedDate = DateTime.Now,
                    Cuit_Cuil = "30-45785215-9",
                    Phone = "3419875425",
                    state = (Int32)StateEnum.Activeted
                }
            );

            entityBuilder.HasMany(e => e.Users).WithOne(e => e.Business).HasForeignKey(e => e.BusinessId).IsRequired();
        }
    }
}
