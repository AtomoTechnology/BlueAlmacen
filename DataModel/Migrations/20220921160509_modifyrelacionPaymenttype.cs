using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class modifyrelacionPaymenttype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_PaymentTypes_AccountId",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_AccountId",
                table: "Sale");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentTypeId",
                table: "Sale",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Sale",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.CreateIndex(
                name: "IX_Sale_PaymentTypeId",
                table: "Sale",
                column: "PaymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_PaymentTypes_PaymentTypeId",
                table: "Sale",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_PaymentTypes_PaymentTypeId",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_PaymentTypeId",
                table: "Sale");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentTypeId",
                table: "Sale",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Sale",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 12, 10, 26, 548, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: "de07358c-3a51-42fb-8690-c383b91b5844",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 12, 10, 26, 601, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4444da14-84ac-48de-a7da-a4f4ddd28858",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 12, 10, 26, 630, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "1535f60d-2db1-4c65-90bc-c1ded55b07aa",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "3700a7b3-0e1b-49e2-87ce-490d06d2512c",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "4c1ffed9-2f0c-4294-8b82-d236da387b39",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "50e82295-a08f-42fa-aae0-26813bc261db",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "876d4600-b062-4e84-937d-8a79f88c1e47",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "f5f737fd-860c-485b-972a-927d385f4ab5",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 12, 10, 26, 618, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0ac46b16-ef03-452c-9586-ba4251496b3f",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 12, 10, 26, 614, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "66e3d763-3f6c-49f1-ad72-3b64051c4879",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 12, 10, 26, 614, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "82a0bec6-8266-443a-84a2-af85ad69348b",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 12, 10, 26, 614, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "362c2637-2ad9-449a-9498-dbd74be87ee8",
                column: "CreatedDate",
                value: new DateTime(2022, 9, 21, 12, 10, 26, 607, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.CreateIndex(
                name: "IX_Sale_AccountId",
                table: "Sale",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_PaymentTypes_AccountId",
                table: "Sale",
                column: "AccountId",
                principalTable: "PaymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
