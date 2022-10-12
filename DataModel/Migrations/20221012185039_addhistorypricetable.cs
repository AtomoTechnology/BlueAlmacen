using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class addhistorypricetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoryPrices",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FinalDate = table.Column<DateTime>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    ProductId = table.Column<string>(nullable: true),
                    AccountId = table.Column<string>(nullable: false),
                    PriceSale = table.Column<decimal>(nullable: false),
                    PricePurchase = table.Column<decimal>(nullable: false),
                    typeUpdate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryPrices_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryPrices_Products_ProductId",
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
                value: new DateTime(2022, 10, 12, 15, 50, 38, 719, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ed456bd3-2578-45a8-81f6-938c6a4cf9b3",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 745, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: "de07358c-3a51-42fb-8690-c383b91b5844",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 758, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4444da14-84ac-48de-a7da-a4f4ddd28858",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 771, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "1535f60d-2db1-4c65-90bc-c1ded55b07aa",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 769, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "3700a7b3-0e1b-49e2-87ce-490d06d2512c",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 769, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "4c1ffed9-2f0c-4294-8b82-d236da387b39",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 769, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "50e82295-a08f-42fa-aae0-26813bc261db",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 769, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "876d4600-b062-4e84-937d-8a79f88c1e47",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 769, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 769, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "da40a532-f06a-4fff-8f66-a7563fef8941",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 769, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "f5f737fd-860c-485b-972a-927d385f4ab5",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 769, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0ac46b16-ef03-452c-9586-ba4251496b3f",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 766, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "66e3d763-3f6c-49f1-ad72-3b64051c4879",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 766, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "82a0bec6-8266-443a-84a2-af85ad69348b",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 766, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "362c2637-2ad9-449a-9498-dbd74be87ee8",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 12, 15, 50, 38, 764, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPrices_AccountId",
                table: "HistoryPrices",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPrices_ProductId",
                table: "HistoryPrices",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryPrices");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 51, 972, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ed456bd3-2578-45a8-81f6-938c6a4cf9b3",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 3, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: "de07358c-3a51-42fb-8690-c383b91b5844",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 35, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4444da14-84ac-48de-a7da-a4f4ddd28858",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 50, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "1535f60d-2db1-4c65-90bc-c1ded55b07aa",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 47, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "3700a7b3-0e1b-49e2-87ce-490d06d2512c",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 47, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "4c1ffed9-2f0c-4294-8b82-d236da387b39",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 47, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "50e82295-a08f-42fa-aae0-26813bc261db",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 47, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "876d4600-b062-4e84-937d-8a79f88c1e47",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 47, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 47, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "da40a532-f06a-4fff-8f66-a7563fef8941",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 47, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "f5f737fd-860c-485b-972a-927d385f4ab5",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 46, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0ac46b16-ef03-452c-9586-ba4251496b3f",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 44, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "66e3d763-3f6c-49f1-ad72-3b64051c4879",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 44, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "82a0bec6-8266-443a-84a2-af85ad69348b",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 44, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "362c2637-2ad9-449a-9498-dbd74be87ee8",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 10, 15, 48, 52, 40, DateTimeKind.Local).AddTicks(9982));
        }
    }
}
