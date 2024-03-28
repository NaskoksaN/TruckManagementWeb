using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class AppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "adminRoleId", "90cc7c4c-3f58-465e-8fe1-de48115f2cfb", "IdentityRole", "Admin", "ADMIN" },
                    { "dispatcherRoleId", "e304cc35-7d18-45ae-a07b-f9fc6c355731", "IdentityRole", "Dispo", "DISPO" },
                    { "managerRoleId", "9795d0b0-ec4d-4818-a4c4-36504a220f80", "IdentityRole", "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec6c8f3b-ea10-4aa4-811a-3984e1809c5f", "AQAAAAEAACcQAAAAEExZERaTavJV/RK7WzbCjil6sRUOBBJ0wsYIvIv4jhHzhpJPdd/W21bWESBvR8yyfA==", "f298ef26-fc4b-4468-ba3a-12923f6f072e" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "EmployeeUserId" },
                values: new object[] { 1, "admin@truck.com", "d401e5f8-2fe9-45e2-9209-69b7db1c1de9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "adminRoleId", "d401e5f8-2fe9-45e2-9209-69b7db1c1de9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dispatcherRoleId");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "managerRoleId");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "adminRoleId", "d401e5f8-2fe9-45e2-9209-69b7db1c1de9" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec6cebf3-e713-40cc-9d9c-3c031e132745", "AQAAAAEAACcQAAAAEOOwaHOpfmCdDzYL8YqzublEJd/vNvU7m/Lm+F/V2YS3F8tqKwypLBIoDdwsBk+qNg==", "555405d0-2eee-4795-a7e3-ae6f7c6781db" });
        }
    }
}
