using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class addtableLots : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncreasePriceAfterTwelve_Accounts_AccountId",
                table: "IncreasePriceAfterTwelve");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_PaymentTypes_PaymentTypeId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleDetail_Sale_SaleId",
                table: "SaleDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleDetail_Products_productId",
                table: "SaleDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleDetail",
                table: "SaleDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncreasePriceAfterTwelve",
                table: "IncreasePriceAfterTwelve");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "SaleDetail",
                newName: "SaleDetails");

            migrationBuilder.RenameTable(
                name: "Sale",
                newName: "Sales");

            migrationBuilder.RenameTable(
                name: "IncreasePriceAfterTwelve",
                newName: "IncreasePriceAfterTwelves");

            migrationBuilder.RenameIndex(
                name: "IX_SaleDetail_productId",
                table: "SaleDetails",
                newName: "IX_SaleDetails_productId");

            migrationBuilder.RenameIndex(
                name: "IX_SaleDetail_SaleId",
                table: "SaleDetails",
                newName: "IX_SaleDetails_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_PaymentTypeId",
                table: "Sales",
                newName: "IX_Sales_PaymentTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_IncreasePriceAfterTwelve_AccountId",
                table: "IncreasePriceAfterTwelves",
                newName: "IX_IncreasePriceAfterTwelves_AccountId");

            migrationBuilder.AddColumn<long>(
                name: "InvoiceCode",
                table: "Sales",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleDetails",
                table: "SaleDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncreasePriceAfterTwelves",
                table: "IncreasePriceAfterTwelves",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Lots",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FinalDate = table.Column<DateTime>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    ProductId = table.Column<string>(nullable: true),
                    LotCode = table.Column<string>(nullable: true),
                    ExpiredDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lots_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 22, 31, 58, 29, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: "de07358c-3a51-42fb-8690-c383b91b5844",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 22, 31, 58, 82, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4444da14-84ac-48de-a7da-a4f4ddd28858",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 22, 31, 58, 102, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "1535f60d-2db1-4c65-90bc-c1ded55b07aa",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 22, 31, 58, 98, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "3700a7b3-0e1b-49e2-87ce-490d06d2512c",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 22, 31, 58, 98, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "4c1ffed9-2f0c-4294-8b82-d236da387b39",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 22, 31, 58, 98, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "50e82295-a08f-42fa-aae0-26813bc261db",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 22, 31, 58, 98, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "876d4600-b062-4e84-937d-8a79f88c1e47",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 22, 31, 58, 98, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 22, 31, 58, 98, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "f5f737fd-860c-485b-972a-927d385f4ab5",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 22, 31, 58, 98, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0ac46b16-ef03-452c-9586-ba4251496b3f",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 22, 31, 58, 94, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "66e3d763-3f6c-49f1-ad72-3b64051c4879",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 22, 31, 58, 94, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "82a0bec6-8266-443a-84a2-af85ad69348b",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 22, 31, 58, 94, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "362c2637-2ad9-449a-9498-dbd74be87ee8",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 25, 22, 31, 58, 89, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.CreateIndex(
                name: "IX_Lots_ProductId",
                table: "Lots",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_IncreasePriceAfterTwelves_Accounts_AccountId",
                table: "IncreasePriceAfterTwelves",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDetails_Sales_SaleId",
                table: "SaleDetails",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDetails_Products_productId",
                table: "SaleDetails",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_PaymentTypes_PaymentTypeId",
                table: "Sales",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncreasePriceAfterTwelves_Accounts_AccountId",
                table: "IncreasePriceAfterTwelves");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleDetails_Sales_SaleId",
                table: "SaleDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleDetails_Products_productId",
                table: "SaleDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_PaymentTypes_PaymentTypeId",
                table: "Sales");

            migrationBuilder.DropTable(
                name: "Lots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleDetails",
                table: "SaleDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncreasePriceAfterTwelves",
                table: "IncreasePriceAfterTwelves");

            migrationBuilder.DropColumn(
                name: "InvoiceCode",
                table: "Sales");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "Sale");

            migrationBuilder.RenameTable(
                name: "SaleDetails",
                newName: "SaleDetail");

            migrationBuilder.RenameTable(
                name: "IncreasePriceAfterTwelves",
                newName: "IncreasePriceAfterTwelve");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_PaymentTypeId",
                table: "Sale",
                newName: "IX_Sale_PaymentTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_SaleDetails_productId",
                table: "SaleDetail",
                newName: "IX_SaleDetail_productId");

            migrationBuilder.RenameIndex(
                name: "IX_SaleDetails_SaleId",
                table: "SaleDetail",
                newName: "IX_SaleDetail_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_IncreasePriceAfterTwelves_AccountId",
                table: "IncreasePriceAfterTwelve",
                newName: "IX_IncreasePriceAfterTwelve_AccountId");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleDetail",
                table: "SaleDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncreasePriceAfterTwelve",
                table: "IncreasePriceAfterTwelve",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 13, 5, 8, 232, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: "de07358c-3a51-42fb-8690-c383b91b5844",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 13, 5, 8, 280, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4444da14-84ac-48de-a7da-a4f4ddd28858",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 13, 5, 8, 305, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "1535f60d-2db1-4c65-90bc-c1ded55b07aa",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 13, 5, 8, 300, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "3700a7b3-0e1b-49e2-87ce-490d06d2512c",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 13, 5, 8, 300, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "4c1ffed9-2f0c-4294-8b82-d236da387b39",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 13, 5, 8, 300, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "50e82295-a08f-42fa-aae0-26813bc261db",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 13, 5, 8, 300, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "876d4600-b062-4e84-937d-8a79f88c1e47",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 13, 5, 8, 300, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 13, 5, 8, 300, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "f5f737fd-860c-485b-972a-927d385f4ab5",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 13, 5, 8, 299, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0ac46b16-ef03-452c-9586-ba4251496b3f",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 13, 5, 8, 295, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "66e3d763-3f6c-49f1-ad72-3b64051c4879",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 13, 5, 8, 295, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "82a0bec6-8266-443a-84a2-af85ad69348b",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 13, 5, 8, 295, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "362c2637-2ad9-449a-9498-dbd74be87ee8",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 13, 5, 8, 290, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.AddForeignKey(
                name: "FK_IncreasePriceAfterTwelve_Accounts_AccountId",
                table: "IncreasePriceAfterTwelve",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_PaymentTypes_PaymentTypeId",
                table: "Sale",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDetail_Sale_SaleId",
                table: "SaleDetail",
                column: "SaleId",
                principalTable: "Sale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDetail_Products_productId",
                table: "SaleDetail",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
