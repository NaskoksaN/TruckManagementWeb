using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class AddTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Full name of the company."),
                    CompanyVat = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false, comment: "VAT number of the company."),
                    CompanyCountry = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Country where the company is located."),
                    CompanyTown = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Town or city where the company is located."),
                    CompanyAddress = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Address of the company."),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Company activity")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Truck identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TruckPlate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, comment: "Truck plate"),
                    TruckBrand = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, comment: "Truck brand"),
                    TruckModel = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Truck model"),
                    ProductionYear = table.Column<int>(type: "int", nullable: false, comment: "Truck production year"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Truck activity")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tripes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Trip identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false, comment: "CompanyId associated with the trip."),
                    TruckId = table.Column<int>(type: "int", nullable: false, comment: "TruckId associated with the trip."),
                    TripKm = table.Column<int>(type: "int", nullable: false, comment: "Trip in kilometers."),
                    TripPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Price of the trip."),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Start date of the trip."),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "End date of the trip.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tripes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tripes_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tripes_Trucks_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Trucks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TruckExpenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Expense identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TruckId = table.Column<int>(type: "int", nullable: false, comment: "Truck Id"),
                    Type = table.Column<int>(type: "int", nullable: false, comment: "Specify the type of the expense (e.g., maintenance, driver salary, road taxes, fuel)."),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Amount of expense"),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Expense date"),
                    Notes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Notes about the expense.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckExpenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TruckExpenses_Trucks_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Trucks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Price of the order."),
                    CompanyId = table.Column<int>(type: "int", nullable: false, comment: "CompanyId associated with the order."),
                    TripId = table.Column<int>(type: "int", nullable: false, comment: "TripId associated with the order."),
                    LoadingDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Loading date"),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "DeliveryDate"),
                    LoadingPostCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, comment: "Loaiding place"),
                    DeliveryPostCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, comment: "Delivery place")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Tripes_TripId",
                        column: x => x.TripId,
                        principalTable: "Tripes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CompanyId",
                table: "Orders",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TripId",
                table: "Orders",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_Tripes_CompanyId",
                table: "Tripes",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tripes_TruckId",
                table: "Tripes",
                column: "TruckId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckExpenses_TruckId",
                table: "TruckExpenses",
                column: "TruckId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "TruckExpenses");

            migrationBuilder.DropTable(
                name: "Tripes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Trucks");
        }
    }
}
