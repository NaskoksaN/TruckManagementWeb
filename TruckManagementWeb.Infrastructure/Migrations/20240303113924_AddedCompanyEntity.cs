using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class AddedCompanyEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date of add Company");

            migrationBuilder.AddColumn<DateTime>(
                name: "RemovedDate",
                table: "Companies",
                type: "datetime2",
                nullable: true,
                comment: "Date when company is removed");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "RemovedDate",
                table: "Companies");
        }
    }
}
