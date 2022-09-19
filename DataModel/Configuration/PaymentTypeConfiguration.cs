using DataModel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resolver.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Configuration
{
    public class PaymentTypeConfiguration
    {
        public PaymentTypeConfiguration(EntityTypeBuilder<PaymentType> entityBuilder)
        {           

            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.PaymentName).IsRequired().HasMaxLength(250);
            entityBuilder.Property(u => u.Description).HasMaxLength(250);
            entityBuilder.Property(u => u.AccountId).IsRequired();

            entityBuilder.HasData(
             new PaymentType()
             {
                 Id = "f5f737fd-860c-485b-972a-927d385f4ab5",
                 AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                 CreatedDate = DateTime.Now,
                 Description = "Efectivo",
                 PaymentName = "Efectivo",
                 state = (Int32)StateEnum.Activeted
             },
             new PaymentType()
             {
                 Id = "4c1ffed9-2f0c-4294-8b82-d236da387b39",
                 AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                 CreatedDate = DateTime.Now,
                 Description = "Tarjeta de debito",
                 PaymentName = "Tarjeta de debito",
                 state = (Int32)StateEnum.Activeted
             },
             new PaymentType()
             {
                 Id = "3700a7b3-0e1b-49e2-87ce-490d06d2512c",
                 AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                 CreatedDate = DateTime.Now,
                 Description = "Tarjeta de credito",
                 PaymentName = "Tarjeta de credito",
                 state = (Int32)StateEnum.Activeted
             },
             new PaymentType()
             {
                 Id = "50e82295-a08f-42fa-aae0-26813bc261db",
                 AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                 CreatedDate = DateTime.Now,
                 Description = "Cheques",
                 PaymentName = "Cheques",
                 state = (Int32)StateEnum.Activeted
             },
             new PaymentType()
             {
                 Id = "1535f60d-2db1-4c65-90bc-c1ded55b07aa",
                 AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                 CreatedDate = DateTime.Now,
                 Description = "Mercado pago",
                 PaymentName = "Mercado pago",
                 state = (Int32)StateEnum.Activeted
             },
             new PaymentType()
             {
                 Id = "876d4600-b062-4e84-937d-8a79f88c1e47",
                 AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                 CreatedDate = DateTime.Now,
                 Description = "Transferencia bancaria",
                 PaymentName = "Transferencia bancaria",
                 state = (Int32)StateEnum.Activeted
             },
             new PaymentType()
             {
                 Id = "c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44",
                 AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                 CreatedDate = DateTime.Now,
                 Description = "Especie",
                 PaymentName = "Especie",
                 state = (Int32)StateEnum.Activeted
             }
            );

            entityBuilder.HasMany(e => e.Sale).WithOne(e => e.PaymentType).HasForeignKey(e => e.AccountId).IsRequired();
        }
    }
}
