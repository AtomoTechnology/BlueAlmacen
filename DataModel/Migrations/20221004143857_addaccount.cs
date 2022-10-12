using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class addaccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 4, 11, 38, 56, 988, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Confirm", "CreatedDate", "FinalDate", "ModifiedDate", "RoleId", "UserId", "UserName", "UserPass", "state" },
                values: new object[] { "ed456bd3-2578-45a8-81f6-938c6a4cf9b3", true, new DateTime(2022, 10, 4, 11, 38, 57, 28, DateTimeKind.Local).AddTicks(2749), null, null, "66e3d763-3f6c-49f1-ad72-3b64051c4879", "362c2637-2ad9-449a-9498-dbd74be87ee8", "cajero", "odeNiMDGrhgpMHmoHQKCQg==", 1 });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: "de07358c-3a51-42fb-8690-c383b91b5844",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 4, 11, 38, 57, 41, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "4444da14-84ac-48de-a7da-a4f4ddd28858",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 4, 11, 38, 57, 53, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "1535f60d-2db1-4c65-90bc-c1ded55b07aa",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 4, 11, 38, 57, 49, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "3700a7b3-0e1b-49e2-87ce-490d06d2512c",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 4, 11, 38, 57, 49, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "4c1ffed9-2f0c-4294-8b82-d236da387b39",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 4, 11, 38, 57, 49, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "50e82295-a08f-42fa-aae0-26813bc261db",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 4, 11, 38, 57, 49, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "876d4600-b062-4e84-937d-8a79f88c1e47",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 4, 11, 38, 57, 49, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 4, 11, 38, 57, 49, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: "f5f737fd-860c-485b-972a-927d385f4ab5",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 4, 11, 38, 57, 49, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0ac46b16-ef03-452c-9586-ba4251496b3f",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 4, 11, 38, 57, 46, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "66e3d763-3f6c-49f1-ad72-3b64051c4879",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 4, 11, 38, 57, 46, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "82a0bec6-8266-443a-84a2-af85ad69348b",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 4, 11, 38, 57, 46, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "362c2637-2ad9-449a-9498-dbd74be87ee8",
                column: "CreatedDate",
                value: new DateTime(2022, 10, 4, 11, 38, 57, 44, DateTimeKind.Local).AddTicks(6398));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ed456bd3-2578-45a8-81f6-938c6a4cf9b3");

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
        }
    }
}
