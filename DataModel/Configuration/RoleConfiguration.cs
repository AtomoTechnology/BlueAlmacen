using DataModel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resolver.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Configuration
{
    public class RoleConfiguration
    {
        public RoleConfiguration(EntityTypeBuilder<Role> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.RoleName).IsRequired().HasMaxLength(250);
            entityBuilder.Property(u => u.Description).HasMaxLength(250);

            entityBuilder.HasData(
                 new Role()
                 {
                     Id = "82a0bec6-8266-443a-84a2-af85ad69348b",
                     RoleName = "Admin",
                     CreatedDate = DateTime.Now,
                     Description = "Tiene acceso en todo",
                     state = (Int32)StateEnum.Activeted
                 },
                new Role()
                {
                    Id = "66e3d763-3f6c-49f1-ad72-3b64051c4879",
                    RoleName = "Empleado(a)",
                    Description = "Tiene acceso para realizar ventas, con limite",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new Role()
                {
                    Id = "0ac46b16-ef03-452c-9586-ba4251496b3f",
                    RoleName = "Almacenero(a)",
                    Description = "Solo puede hacer control de stock",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }
            );

            entityBuilder.HasMany(e => e.Accounts).WithOne(e => e.Role).HasForeignKey(e => e.RoleId).IsRequired();
        }
    }
}
