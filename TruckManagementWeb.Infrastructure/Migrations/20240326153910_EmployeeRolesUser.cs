using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class EmployeeRolesUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Employee full name");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Activity of the employee");

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FullName", "IsActive", "RoleId" },
                values: new object[] { "", true, "adminRoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleId",
                table: "Employees",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AspNetRoles_RoleId",
                table: "Employees",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AspNetRoles_RoleId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_RoleId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "90cc7c4c-3f58-465e-8fe1-de48115f2cfb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dispatcherRoleId",
                column: "ConcurrencyStamp",
                value: "e304cc35-7d18-45ae-a07b-f9fc6c355731");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "managerRoleId",
                column: "ConcurrencyStamp",
                value: "9795d0b0-ec4d-4818-a4c4-36504a220f80");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec6c8f3b-ea10-4aa4-811a-3984e1809c5f", "AQAAAAEAACcQAAAAEExZERaTavJV/RK7WzbCjil6sRUOBBJ0wsYIvIv4jhHzhpJPdd/W21bWESBvR8yyfA==", "f298ef26-fc4b-4468-ba3a-12923f6f072e" });
        }
    }
}
