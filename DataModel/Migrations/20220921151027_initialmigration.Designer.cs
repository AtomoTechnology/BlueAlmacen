﻿// <auto-generated />
using System;
using DataModel.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataModel.Migrations
{
    [DbContext(typeof(DbGestionStockContext))]
    [Migration("20220921151027_initialmigration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataModel.Entities.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Confirm")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("UserPass")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                            Confirm = true,
                            CreatedDate = new DateTime(2022, 9, 21, 12, 10, 26, 548, DateTimeKind.Local).AddTicks(5619),
                            RoleId = "82a0bec6-8266-443a-84a2-af85ad69348b",
                            UserId = "362c2637-2ad9-449a-9498-dbd74be87ee8",
                            UserName = "almacen",
                            UserPass = "odeNiMDGrhgpMHmoHQKCQg==",
                            state = 1
                        });
                });

            modelBuilder.Entity("DataModel.Entities.Business", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("BusinessName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cuit_Cuil")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            Id = "de07358c-3a51-42fb-8690-c383b91b5844",
                            Address = "San Lorenzo",
                            BusinessName = "Almacen",
                            CreatedDate = new DateTime(2022, 9, 21, 12, 10, 26, 601, DateTimeKind.Local).AddTicks(5610),
                            Cuit_Cuil = "30-45785215-9",
                            Phone = "3419875425",
                            state = 1
                        });
                });

            modelBuilder.Entity("DataModel.Entities.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                            AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                            CategoryName = "Perfumeria",
                            CreatedDate = new DateTime(2022, 9, 21, 12, 10, 26, 630, DateTimeKind.Local).AddTicks(3652),
                            Description = "Se encuentra todo sobre perfumeria",
                            state = 1
                        });
                });

            modelBuilder.Entity("DataModel.Entities.IncreasePriceAfterTwelve", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HourFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HourTo")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Porcent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("IncreasePriceAfterTwelve");
                });

            modelBuilder.Entity("DataModel.Entities.PaymentType", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("PaymentTypes");

                    b.HasData(
                        new
                        {
                            Id = "f5f737fd-860c-485b-972a-927d385f4ab5",
                            AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                            CreatedDate = new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(4267),
                            Description = "Efectivo",
                            PaymentName = "Efectivo",
                            state = 1
                        },
                        new
                        {
                            Id = "4c1ffed9-2f0c-4294-8b82-d236da387b39",
                            AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                            CreatedDate = new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5311),
                            Description = "Tarjeta de debito",
                            PaymentName = "Tarjeta de debito",
                            state = 1
                        },
                        new
                        {
                            Id = "3700a7b3-0e1b-49e2-87ce-490d06d2512c",
                            AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                            CreatedDate = new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5370),
                            Description = "Tarjeta de credito",
                            PaymentName = "Tarjeta de credito",
                            state = 1
                        },
                        new
                        {
                            Id = "50e82295-a08f-42fa-aae0-26813bc261db",
                            AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                            CreatedDate = new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5373),
                            Description = "Cheques",
                            PaymentName = "Cheques",
                            state = 1
                        },
                        new
                        {
                            Id = "1535f60d-2db1-4c65-90bc-c1ded55b07aa",
                            AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                            CreatedDate = new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5376),
                            Description = "Mercado pago",
                            PaymentName = "Mercado pago",
                            state = 1
                        },
                        new
                        {
                            Id = "876d4600-b062-4e84-937d-8a79f88c1e47",
                            AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                            CreatedDate = new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5379),
                            Description = "Transferencia bancaria",
                            PaymentName = "Transferencia bancaria",
                            state = 1
                        },
                        new
                        {
                            Id = "c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44",
                            AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                            CreatedDate = new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5383),
                            Description = "Especie",
                            PaymentName = "Especie",
                            state = 1
                        });
                });

            modelBuilder.Entity("DataModel.Entities.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProviderId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DataModel.Entities.Provider", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cuit_Cuil")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("DataModel.Entities.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "82a0bec6-8266-443a-84a2-af85ad69348b",
                            CreatedDate = new DateTime(2022, 9, 21, 12, 10, 26, 614, DateTimeKind.Local).AddTicks(2466),
                            Description = "Tiene acceso en todo",
                            RoleName = "Admin",
                            state = 1
                        },
                        new
                        {
                            Id = "66e3d763-3f6c-49f1-ad72-3b64051c4879",
                            CreatedDate = new DateTime(2022, 9, 21, 12, 10, 26, 614, DateTimeKind.Local).AddTicks(3151),
                            Description = "Tiene acceso para realizar ventas, con limite",
                            RoleName = "Empleado(a)",
                            state = 1
                        },
                        new
                        {
                            Id = "0ac46b16-ef03-452c-9586-ba4251496b3f",
                            CreatedDate = new DateTime(2022, 9, 21, 12, 10, 26, 614, DateTimeKind.Local).AddTicks(3159),
                            Description = "Solo puede hacer control de stock",
                            RoleName = "Almacenero(a)",
                            state = 1
                        });
                });

            modelBuilder.Entity("DataModel.Entities.Sale", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentTypeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaleType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("finalizeSale")
                        .HasColumnType("bit");

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("DataModel.Entities.SaleDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SaleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("productId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SaleId");

                    b.HasIndex("productId");

                    b.ToTable("SaleDetail");
                });

            modelBuilder.Entity("DataModel.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("BusinessId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BusinessId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "362c2637-2ad9-449a-9498-dbd74be87ee8",
                            Address = "San Lorenzo",
                            BusinessId = "de07358c-3a51-42fb-8690-c383b91b5844",
                            CreatedDate = new DateTime(2022, 9, 21, 12, 10, 26, 607, DateTimeKind.Local).AddTicks(5325),
                            Email = "almacensanlorenzo@gmail.com",
                            FirstName = "Almacen",
                            LastName = "San Lorenzo",
                            Phone = "3416987542",
                            state = 1
                        });
                });

            modelBuilder.Entity("DataModel.Entities.Account", b =>
                {
                    b.HasOne("DataModel.Entities.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.Entities.User", "User")
                        .WithMany("Accounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.Entities.Category", b =>
                {
                    b.HasOne("DataModel.Entities.Account", "Account")
                        .WithMany("Categories")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.Entities.IncreasePriceAfterTwelve", b =>
                {
                    b.HasOne("DataModel.Entities.Account", "Account")
                        .WithMany("IncreasePriceAfterTwelve")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.Entities.PaymentType", b =>
                {
                    b.HasOne("DataModel.Entities.Account", "Account")
                        .WithMany("PaymentType")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.Entities.Product", b =>
                {
                    b.HasOne("DataModel.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("DataModel.Entities.Category", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("DataModel.Entities.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId");
                });

            modelBuilder.Entity("DataModel.Entities.Provider", b =>
                {
                    b.HasOne("DataModel.Entities.Account", "Account")
                        .WithMany("Providers")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.Entities.Sale", b =>
                {
                    b.HasOne("DataModel.Entities.PaymentType", "PaymentType")
                        .WithMany("Sale")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.Entities.SaleDetail", b =>
                {
                    b.HasOne("DataModel.Entities.Sale", null)
                        .WithMany("SaleDetail")
                        .HasForeignKey("SaleId");

                    b.HasOne("DataModel.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("productId");
                });

            modelBuilder.Entity("DataModel.Entities.User", b =>
                {
                    b.HasOne("DataModel.Entities.Business", "Business")
                        .WithMany("Users")
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
