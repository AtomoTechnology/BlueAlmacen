using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FinalDate = table.Column<DateTime>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    BusinessName = table.Column<string>(maxLength: 250, nullable: false),
                    Cuit_Cuil = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 250, nullable: true),
                    Phone = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FinalDate = table.Column<DateTime>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    RoleName = table.Column<string>(maxLength: 250, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FinalDate = table.Column<DateTime>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    BusinessId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 250, nullable: true),
                    LastName = table.Column<string>(maxLength: 250, nullable: true),
                    Email = table.Column<string>(maxLength: 250, nullable: true),
                    Phone = table.Column<string>(maxLength: 250, nullable: true),
                    Address = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Businesses_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Businesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FinalDate = table.Column<DateTime>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    RoleId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    UserPass = table.Column<string>(maxLength: 50, nullable: false),
                    Confirm = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FinalDate = table.Column<DateTime>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    AccountId = table.Column<string>(nullable: false),
                    CategoryName = table.Column<string>(maxLength: 250, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncreasePriceAfterTwelve",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FinalDate = table.Column<DateTime>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    AccountId = table.Column<string>(nullable: false),
                    HourFrom = table.Column<DateTime>(nullable: false),
                    HourTo = table.Column<DateTime>(nullable: false),
                    Porcent = table.Column<decimal>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncreasePriceAfterTwelve", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncreasePriceAfterTwelve_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FinalDate = table.Column<DateTime>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    AccountId = table.Column<string>(nullable: false),
                    PaymentName = table.Column<string>(maxLength: 250, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTypes_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FinalDate = table.Column<DateTime>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    AccountId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Address = table.Column<string>(maxLength: 250, nullable: true),
                    Phone = table.Column<string>(maxLength: 250, nullable: true),
                    Cuit_Cuil = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Providers_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FinalDate = table.Column<DateTime>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    AccountId = table.Column<string>(nullable: false),
                    PaymentTypeId = table.Column<string>(nullable: true),
                    Total = table.Column<decimal>(nullable: false),
                    finalizeSale = table.Column<bool>(nullable: false),
                    SaleType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sale_PaymentTypes_AccountId",
                        column: x => x.AccountId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FinalDate = table.Column<DateTime>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    AccountId = table.Column<string>(nullable: true),
                    ProviderId = table.Column<string>(nullable: true),
                    CategoryId = table.Column<string>(nullable: true),
                    ProductCode = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    PurchasePrice = table.Column<decimal>(nullable: false),
                    SalePrice = table.Column<decimal>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleDetail",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FinalDate = table.Column<DateTime>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    productId = table.Column<string>(nullable: true),
                    SaleId = table.Column<string>(nullable: true),
                    price = table.Column<decimal>(nullable: false),
                    quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleDetail_Sale_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleDetail_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessName", "CreatedDate", "Cuit_Cuil", "FinalDate", "ModifiedDate", "Phone", "state" },
                values: new object[] { "de07358c-3a51-42fb-8690-c383b91b5844", "San Lorenzo", "Almacen", new DateTime(2022, 9, 21, 12, 10, 26, 601, DateTimeKind.Local).AddTicks(5610), "30-45785215-9", null, null, "3419875425", 1 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "Description", "FinalDate", "ModifiedDate", "RoleName", "state" },
                values: new object[,]
                {
                    { "82a0bec6-8266-443a-84a2-af85ad69348b", new DateTime(2022, 9, 21, 12, 10, 26, 614, DateTimeKind.Local).AddTicks(2466), "Tiene acceso en todo", null, null, "Admin", 1 },
                    { "66e3d763-3f6c-49f1-ad72-3b64051c4879", new DateTime(2022, 9, 21, 12, 10, 26, 614, DateTimeKind.Local).AddTicks(3151), "Tiene acceso para realizar ventas, con limite", null, null, "Empleado(a)", 1 },
                    { "0ac46b16-ef03-452c-9586-ba4251496b3f", new DateTime(2022, 9, 21, 12, 10, 26, 614, DateTimeKind.Local).AddTicks(3159), "Solo puede hacer control de stock", null, null, "Almacenero(a)", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BusinessId", "CreatedDate", "Email", "FinalDate", "FirstName", "LastName", "ModifiedDate", "Phone", "state" },
                values: new object[] { "362c2637-2ad9-449a-9498-dbd74be87ee8", "San Lorenzo", "de07358c-3a51-42fb-8690-c383b91b5844", new DateTime(2022, 9, 21, 12, 10, 26, 607, DateTimeKind.Local).AddTicks(5325), "almacensanlorenzo@gmail.com", null, "Almacen", "San Lorenzo", null, "3416987542", 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Confirm", "CreatedDate", "FinalDate", "ModifiedDate", "RoleId", "UserId", "UserName", "UserPass", "state" },
                values: new object[] { "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca", true, new DateTime(2022, 9, 21, 12, 10, 26, 548, DateTimeKind.Local).AddTicks(5619), null, null, "82a0bec6-8266-443a-84a2-af85ad69348b", "362c2637-2ad9-449a-9498-dbd74be87ee8", "almacen", "odeNiMDGrhgpMHmoHQKCQg==", 1 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "AccountId", "CategoryName", "CreatedDate", "Description", "FinalDate", "ModifiedDate", "state" },
                values: new object[] { "4444da14-84ac-48de-a7da-a4f4ddd28858", "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca", "Perfumeria", new DateTime(2022, 9, 21, 12, 10, 26, 630, DateTimeKind.Local).AddTicks(3652), "Se encuentra todo sobre perfumeria", null, null, 1 });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "AccountId", "CreatedDate", "Description", "FinalDate", "ModifiedDate", "PaymentName", "state" },
                values: new object[,]
                {
                    { "f5f737fd-860c-485b-972a-927d385f4ab5", "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca", new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(4267), "Efectivo", null, null, "Efectivo", 1 },
                    { "4c1ffed9-2f0c-4294-8b82-d236da387b39", "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca", new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5311), "Tarjeta de debito", null, null, "Tarjeta de debito", 1 },
                    { "3700a7b3-0e1b-49e2-87ce-490d06d2512c", "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca", new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5370), "Tarjeta de credito", null, null, "Tarjeta de credito", 1 },
                    { "50e82295-a08f-42fa-aae0-26813bc261db", "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca", new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5373), "Cheques", null, null, "Cheques", 1 },
                    { "1535f60d-2db1-4c65-90bc-c1ded55b07aa", "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca", new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5376), "Mercado pago", null, null, "Mercado pago", 1 },
                    { "876d4600-b062-4e84-937d-8a79f88c1e47", "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca", new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5379), "Transferencia bancaria", null, null, "Transferencia bancaria", 1 },
                    { "c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44", "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca", new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5383), "Especie", null, null, "Especie", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_RoleId",
                table: "Accounts",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_AccountId",
                table: "Categories",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_IncreasePriceAfterTwelve_AccountId",
                table: "IncreasePriceAfterTwelve",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_AccountId",
                table: "PaymentTypes",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AccountId",
                table: "Products",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProviderId",
                table: "Products",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_AccountId",
                table: "Providers",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_AccountId",
                table: "Sale",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetail_SaleId",
                table: "SaleDetail",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetail_productId",
                table: "SaleDetail",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BusinessId",
                table: "Users",
                column: "BusinessId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncreasePriceAfterTwelve");

            migrationBuilder.DropTable(
                name: "SaleDetail");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Businesses");
        }
    }
}
