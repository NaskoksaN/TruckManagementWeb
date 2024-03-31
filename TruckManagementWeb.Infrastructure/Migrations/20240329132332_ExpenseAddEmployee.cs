using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class ExpenseAddEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "b19f5167-d4c0-48e5-8dc4-9df66bbdfad6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dispatcherRoleId",
                column: "ConcurrencyStamp",
                value: "78ca2928-a9c7-4b81-a6d8-999bec9acf41");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "managerRoleId",
                column: "ConcurrencyStamp",
                value: "121e131b-71f9-41d7-86df-0214e45315aa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0cdad88-d0ca-4b78-88eb-672765f3eb68", "AQAAAAEAACcQAAAAEO2coAmeIdA2qQu0HtNTZaiMKyJ2uAWzhg+P+ovBq7x/fH3kCd2psAMhcq1G1mU0lw==", "e9eb3cbd-1db1-47c2-90c5-85779b5a3718" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "4d0d7f72-0adf-4f3a-89de-16d0cb5e5ec9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dispatcherRoleId",
                column: "ConcurrencyStamp",
                value: "ffd31644-c688-49fa-96b9-6c8842232422");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "managerRoleId",
                column: "ConcurrencyStamp",
                value: "815efcff-3acc-43ad-a399-b585e24bbddb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ed65414-ac0a-486d-8a73-e95a540cf0a2", "AQAAAAEAACcQAAAAEDu/GPX/R8dT2fhCIvk9LJYlfZqBMXawUDO282viL/abLwu9iYmbZiMbrJuy8kc1CQ==", "d1ffee28-0405-457e-9d53-aa5d83c70fa7" });
        }
    }
}
