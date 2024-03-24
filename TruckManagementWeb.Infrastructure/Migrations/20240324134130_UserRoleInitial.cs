using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class UserRoleInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "adminRoleId", "8523dd05-a589-4ba8-9882-e8c018b51cf5", "Admin", "ADMIN" },
                    { "dispatcherRoleId", "bb23cbaa-5697-4f83-a82c-240c4388bca2", "Dispo", "DISPO" },
                    { "managerRoleId", "1cb5bd1f-027f-4cac-a6b4-75f726810738", "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a930659-5e41-4e2b-9bae-b9cec7c9dea8", "AQAAAAEAACcQAAAAEL5thcJYo4TAj8VdIRq/g0NY210VIoxrOfJ9/pi/SwnnrA9e8qP46sYlaHaCIZBKbQ==", null });

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec6cebf3-e713-40cc-9d9c-3c031e132745", "AQAAAAEAACcQAAAAEOOwaHOpfmCdDzYL8YqzublEJd/vNvU7m/Lm+F/V2YS3F8tqKwypLBIoDdwsBk+qNg==", "555405d0-2eee-4795-a7e3-ae6f7c6781db" });
        }
    }
}
