using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class TripTableRemoveCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tripes_Companies_CompanyId",
                table: "Tripes");

            migrationBuilder.DropIndex(
                name: "IX_Tripes_CompanyId",
                table: "Tripes");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Tripes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Tripes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "CompanyId associated with the trip.");

            migrationBuilder.CreateIndex(
                name: "IX_Tripes_CompanyId",
                table: "Tripes",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tripes_Companies_CompanyId",
                table: "Tripes",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
