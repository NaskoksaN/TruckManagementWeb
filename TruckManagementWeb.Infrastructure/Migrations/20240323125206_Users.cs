using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserEmail", "UserName" },
                values: new object[] { "d401e5f8-2fe9-45e2-9209-69b7db1c1de9", 0, "ec6cebf3-e713-40cc-9d9c-3c031e132745", "admin@truck.com", false, false, null, "admin@truck.com", "admin@truck.com", "AQAAAAEAACcQAAAAEOOwaHOpfmCdDzYL8YqzublEJd/vNvU7m/Lm+F/V2YS3F8tqKwypLBIoDdwsBk+qNg==", null, false, "555405d0-2eee-4795-a7e3-ae6f7c6781db", false, "", "admin@truck.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "AspNetUsers");
        }
    }
}
