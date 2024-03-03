using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class UpdateTruckTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Trucks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date of add truck to Database");

            migrationBuilder.AddColumn<DateTime>(
                name: "RemovedDate",
                table: "Trucks",
                type: "datetime2",
                nullable: true,
                comment: "Date when truck is removed");

            migrationBuilder.AddColumn<int>(
                name: "TruckInitialKm",
                table: "Trucks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Truck initial milleage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "RemovedDate",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "TruckInitialKm",
                table: "Trucks");
        }
    }
}
