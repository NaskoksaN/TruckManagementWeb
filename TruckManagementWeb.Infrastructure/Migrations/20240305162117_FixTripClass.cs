using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class FixTripClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LoadingPostCode",
                table: "Orders",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                comment: "Loaiding place",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldComment: "Loaiding place");

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostCode",
                table: "Orders",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                comment: "Delivery place",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldComment: "Delivery place");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LoadingPostCode",
                table: "Orders",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                comment: "Loaiding place",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldComment: "Loaiding place");

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostCode",
                table: "Orders",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                comment: "Delivery place",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldComment: "Delivery place");
        }
    }
}
