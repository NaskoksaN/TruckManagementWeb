using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class MoveFullNameToAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "fde43401-40c1-496d-a691-bffbfe8a78e0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dispatcherRoleId",
                column: "ConcurrencyStamp",
                value: "4cefa6b6-361a-4af5-b607-2a2b051d9024");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "managerRoleId",
                column: "ConcurrencyStamp",
                value: "c07c5151-a630-4230-b37c-6b3981f1d21c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0261d5ca-050a-423e-90cb-c7e990f67959",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9eccfd25-4850-4fc7-98dd-b16f96d26d39", "Chief", "AQAAAAEAACcQAAAAEEVZjGnOkkSmpejuisFgD/6uw7SzthV1ay+VcypXWwM9OAvS/RPzSgK8e0oLMmi9jg==", "99ce5fa8-1e7a-4bb7-97ca-3b358915c3cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19918df1-9468-434b-aaf9-a3d22b2d12e2",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d22d16fb-2a00-44d0-8d3b-e6bb5d1628d8", "Hans Due", "AQAAAAEAACcQAAAAEJ1tH209U7SCTXC3Plfzj4i20U3JMZgaFujYSpLJEZj5XKIoZvQYsf98atB7rG9nrg==", "9ca6d58e-7f24-497b-823f-2af2ace12bf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62154153-66df-4b35-91ed-56ac983c9a8e",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb3128a6-f99d-4687-8e79-e2c48362bc7e", "Hans Uno", "AQAAAAEAACcQAAAAEPlLG3uD2OT1Fx8YpflCTA640AyvFzw8xMXV8fXAw+YcBOVUR0mfePsJpLlCGbjWDQ==", "c518909e-c898-4956-b3fa-4d3336fe47a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e04bd4e6-ee6b-41a8-9e60-7aac744bee57", "Admin Admin", "AQAAAAEAACcQAAAAEFz3EVaB7Qo0ltUefT9+sDIXrIblPRp4JAqltsL4zBstipAVw2yihYSHscR+GDyRqA==", "a6c25403-723e-4d45-b4ee-993cdbe96b2d" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1124.988846652187m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1071.58457938861m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1183.262496377156m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1171.237199790598m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1173.129571921541m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1101.193880531931m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1256.817053992392m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 1103.046380714053m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 1249.523999561687m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1160.993810924267m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1150.937471608335m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1220.662436175115m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1103.238528161183m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1089.628717272519m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 986.8890412954832m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1195.993697403414m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 1040.3067862044592m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 1274.537098854399m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1299.69887485842m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1152.958660008182m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1027.578500179929m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1142.629237972806m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 983.3955686253111m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1100.327681522172m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1182.699222214489m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 954.21312294233029m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1055.952467313101m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1203.403527906644m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 989.1469449219948m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1247.954783972469m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1147.685886428435m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 960.591293805879m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1139.30225122352m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34,
                column: "Price",
                value: 1121.101488237386m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 985.4400796352154m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1172.008285296753m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1160.61964117219m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1050.456566755299m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39,
                column: "Price",
                value: 973.7259288993845m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1015.4370998603453m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1104.361777275616m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1034.4909482503409m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43,
                column: "Price",
                value: 1037.0541028191496m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1189.395431122366m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1173.105325096242m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1022.1819992533566m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1074.554820250459m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1175.478458836397m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49,
                column: "Price",
                value: 1276.385562795444m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1102.553253552857m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 954.25484720598127m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1006.8768401764848m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1029.463035982666m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1239.231052595919m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1136.542285557148m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1123.521429673409m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1075.760981131095m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1201.474597865334m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1026.0344216427855m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1129.854452584218m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1006.7614774794994m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1065.717237773292m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 996.045135986112m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1231.883132674041m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1287.133056023221m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1189.851615928373m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 67,
                column: "Price",
                value: 1163.63899774016m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1183.932743912308m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1033.9773981360004m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1144.446832930179m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1199.526499446338m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1186.308213960531m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1083.375522022702m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1026.260768201234m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1235.078640109984m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1296.032166821888m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1096.675285734402m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1115.440948286077m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1120.171120622792m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1008.7922297549381m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1158.990741245318m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1141.736818282464m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1269.403085633842m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1132.016651546024m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1129.949476997991m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1089.193387822058m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1248.514175687876m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1229.731127113917m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1095.436568302166m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1011.8938100167642m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1168.59122968093m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1080.567372474162m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1279.843897030478m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1030.4327021246336m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 994.0740032795972m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1256.045886872096m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1015.5280991642277m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1165.032109129789m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1092.910143927234m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 100,
                column: "Price",
                value: 1053.475931273718m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 101,
                column: "Price",
                value: 1281.071817288352m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1049.4038444937256m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1026.9520044220525m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1007.1934517019338m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1143.04191097535m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1072.810351058026m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 954.17167044110961m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1035.376702551641m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1120.512649131906m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1013.8376184935408m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1060.623922011787m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 112,
                column: "Price",
                value: 1103.775957527858m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 999.249433337801m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1215.192323065323m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 115,
                column: "Price",
                value: 1122.783031919765m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1077.868760573412m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1188.700859060555m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1091.191052401144m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1091.02586601758m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 993.8870614388443m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 121,
                column: "Price",
                value: 1128.29524581627m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1235.810504183967m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1102.907038132422m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1007.6052876597833m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1132.288605381705m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1079.758764541663m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1079.96679758063m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1024.639167418833m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1118.056835569889m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1055.758113957955m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1158.892688397606m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 132,
                column: "Price",
                value: 1094.020121717441m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1172.48933110208m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1055.707503657662m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1226.911770654132m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1268.565748010586m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1028.9707013483226m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1138.478252709792m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1069.221899855223m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1082.853339435987m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1223.839298150774m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1150.10165840927m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1130.430123337245m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 989.1574230538155m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 974.7540967474647m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1293.531865566732m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1042.6978693327786m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1086.056281835077m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1168.100795168783m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1179.665828119764m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1102.101742442413m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 152,
                column: "Price",
                value: 1233.797089830463m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1002.0024465076182m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 154,
                column: "Price",
                value: 1056.082167626618m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1205.828947846031m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1201.196471026066m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1063.226787771968m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1119.501659980052m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1104.126600300912m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 160,
                column: "Price",
                value: 1295.06942525117m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1260.474322080209m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 162,
                column: "Price",
                value: 954.84528240036248m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1107.257239259398m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1138.803960409362m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1225.93950152948m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1059.118353977344m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1135.265911450974m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1247.912453971183m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1066.002386347497m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 995.8286356716942m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1034.3199830447195m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1185.843352603629m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1269.783952171601m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 174,
                column: "Price",
                value: 1120.870191019035m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1082.287119963506m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1144.004772945782m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 177,
                column: "Price",
                value: 1164.88604909618m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1045.8594418850866m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1221.180724297655m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1151.351561813571m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 972.3953854442328m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1146.155988867515m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 984.9088594383527m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1100.48931775815m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 957.91084688890379m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1002.6992330054763m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1089.155792782287m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1230.073580469036m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1285.982835824776m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1173.041880919799m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1218.027457006576m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1056.032068060989m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1047.2469535066581m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1084.119351434516m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1104.571236168042m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1126.780869042512m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1061.576152129245m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1189.685180836064m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1159.880706901961m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1044.3548942790427m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 995.7359080249664m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1217.421208040951m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1186.50795233305m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1043.9495859233946m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 205,
                column: "Price",
                value: 1298.179283759741m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1006.1909659754373m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 207,
                column: "Price",
                value: 1131.676594154777m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1045.8594193179475m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1265.698642438912m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1143.18293685667m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1282.270146056863m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1161.55790011625m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1163.332972415993m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1018.3593665435118m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1263.363392739716m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1179.509890042601m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1158.628086217774m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1182.236580662176m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1011.9787752846265m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1297.02945407498m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1114.43691669141m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1112.675929332685m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1108.908204255686m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 984.8165577040894m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1246.170009954519m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 984.6474297961612m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1244.897242130925m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1237.630388412153m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1248.842784381876m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1056.325166213809m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1111.607779914296m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1259.595396653198m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1074.935450760602m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1227.164234925249m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1170.200760272434m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1295.164111684986m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1073.824921731474m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1099.510575150346m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1137.291554109092m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1034.620523330805m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 996.8300801672732m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1186.448644200787m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1136.17854988133m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 995.6887720332072m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 970.1268595370449m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1057.665072265662m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1165.36441150267m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1212.52966748243m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1251.223394483393m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1188.530329745074m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1083.370093132382m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1208.68885851534m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 975.1072771233092m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1131.130608587442m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1298.825793468574m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1259.727481350636m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1071.332547753117m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 953.5688153652286m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1181.625202258142m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1211.953438974819m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1290.853768838162m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1007.2422585033633m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1277.256297004329m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1024.3690335934431m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 999.5842049722327m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1173.5662378657m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 267,
                column: "Price",
                value: 1213.637747580639m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 268,
                column: "Price",
                value: 1258.612238691502m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1071.747618016724m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 972.3864142573068m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1185.019221569455m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1178.167574600935m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1075.087630087807m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1271.773899115449m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1022.2175315034146m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1233.024117026009m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1011.9701329396051m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1019.4207610270615m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1185.924948276143m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1027.2652235654321m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 958.34116718393728m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 282,
                column: "Price",
                value: 1042.4424479287426m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1034.8631766267486m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1115.541817492402m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1248.748013833966m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1298.817754828404m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1218.668806095692m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1158.030190362522m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1209.721270011343m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 990.9398655758388m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1072.389540490608m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1153.61362206316m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1080.414131249124m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1094.216857364752m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 960.9840219026394m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1257.957167855062m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1201.568306503619m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1024.7936012217328m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1134.667341846741m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1004.9481247540376m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1039.9521812026875m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 302,
                column: "Price",
                value: 1196.63133384518m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1075.999988773628m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1094.996024000757m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1289.015366806586m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1264.14924802904m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1073.144539658049m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1195.506098102463m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1233.750874089354m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1272.804310374777m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1089.710915035338m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1087.746306987315m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1049.6778024155627m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1047.5287588756587m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1109.40892844133m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 977.5484512516414m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1152.482827047976m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 996.9990743041545m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1210.118721922413m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1045.1159198540487m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1034.9813542574569m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 962.6827354407427m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1105.878080973719m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1167.944831341933m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 970.6123431475014m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1249.120966468693m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1249.634499558083m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1172.874076388518m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1147.434435007273m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1020.3867590962847m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 331,
                column: "Price",
                value: 1260.019119096527m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1139.576312053985m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1267.757848523226m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 334,
                column: "Price",
                value: 1283.511941927822m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1276.146978792985m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 336,
                column: "Price",
                value: 967.8228128708702m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1051.972575247797m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1171.288015734572m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 955.45576909603244m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1171.859871230986m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 960.2836965607059m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1273.209473723337m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 343,
                column: "Price",
                value: 1017.6944167938952m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 344,
                column: "Price",
                value: 996.5708875642361m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1246.536475291206m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 346,
                column: "Price",
                value: 1268.687883919458m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 971.646310617053m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 348,
                column: "Price",
                value: 1031.6817165998214m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 960.6469577112516m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1073.075427829554m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1192.269243658384m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1296.140258678033m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 990.4156505501693m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1249.724276284207m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1038.8310356071033m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 356,
                column: "Price",
                value: 1146.983563487253m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1115.587813088539m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1167.752875998645m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1029.2796690523854m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1185.662849460861m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1099.243613347438m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1277.287975677158m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 969.5770631101216m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1224.696838035389m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1145.718770726409m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1020.1991643780593m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1232.748436964453m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1228.171639327616m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1269.89733716947m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1031.4035017982725m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1066.466925575576m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1266.917480528159m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1075.569174010772m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 990.0413509088049m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1030.7565154877824m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 376,
                column: "Price",
                value: 1092.08676977814m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 377,
                column: "Price",
                value: 1200.948084260284m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 991.0151859519396m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1229.298916199858m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1229.833603851774m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1074.142247783556m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1083.334539003094m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1094.404541178512m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1097.982701641578m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1155.136220933653m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 968.5494281087866m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1054.37300582526m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1274.395524467892m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1296.338893231558m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 390,
                column: "Price",
                value: 980.9004293146635m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1283.562514097319m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1243.679251622012m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1026.9233262411323m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1051.977408321465m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1161.087002202589m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1266.722249759524m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 397,
                column: "Price",
                value: 1008.195273955224m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1012.3311673528561m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 984.6678295163562m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1092.128029966738m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 401,
                column: "Price",
                value: 1023.2894686753756m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1298.403154069495m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1091.47526932818m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 404,
                column: "Price",
                value: 975.5088040021609m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1226.949348466621m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1180.696775409517m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 991.0970440100856m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1037.8747220161657m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1217.208280487154m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1084.419480380681m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1084.980300454502m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1276.573405101219m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1205.637812377911m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1061.105791853666m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 415,
                column: "Price",
                value: 1095.618498853868m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1066.9488913064m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1039.2795916672041m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1254.420422768841m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1111.735455844105m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1188.653426433036m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1258.944831286878m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1127.170077353835m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1153.415792388995m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1022.885291716958m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1002.0255456393126m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 958.50319610968246m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 998.6474396121417m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1186.151442398671m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1106.165401104909m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1266.114427254751m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1220.674734290307m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 995.1532534294504m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1184.18982331734m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1234.058343824335m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 981.5758494263939m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1133.103765964693m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1019.1730383251805m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1018.8946810063872m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1213.391650043868m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1229.241588010765m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1257.5076549924m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1116.125601166446m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 979.8847150754349m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1143.590228662893m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1156.154645463648m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1190.582386070041m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1177.209318535363m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1001.0576341144756m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1288.403556028695m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1066.561268304667m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1254.858242144829m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1180.594216402399m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1064.60735165896m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1163.887531031827m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1249.227905606365m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1233.105787033708m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 992.6129666719672m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1122.199173688286m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1237.231350623865m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1157.499412601369m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1131.004052660996m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1064.057119933303m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1294.858631652567m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 464,
                column: "Price",
                value: 1001.4424696753292m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1189.208223785718m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1209.656471355631m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1121.756044546049m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1253.502112395848m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1235.525780028904m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1058.655875816133m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1013.6608299458233m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1111.249942959254m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1156.643474894025m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1257.817603749722m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1047.7456525154677m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1259.970230296607m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1293.151355397344m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 994.2034723881093m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1069.167767071433m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1137.373473967082m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 953.34151889325107m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1193.615915494423m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 950.478626044135344m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1055.053878136723m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1168.814194363113m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1014.2525048374904m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 956.5838845327768m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1136.020515730718m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1103.930111992586m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1205.726395460001m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1068.231525619969m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1294.548891482406m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1087.750721313325m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1229.329816745692m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 961.5602340434418m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1030.5661643021565m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1121.18554483158m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1053.676234623159m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1045.9924608486478m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1237.159861044936m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1013.3942312979884m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1298.416486525364m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1180.517130960088m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 504,
                column: "Price",
                value: 1176.851551947773m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 994.7810917979597m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 967.3556832281281m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1010.4627078992378m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1220.046827309243m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 977.3164663359356m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1096.078425231987m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1177.896062753032m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1036.3431975864976m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1209.535489071898m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1119.0589504026m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1013.9340879262627m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1024.0721348056108m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1223.786870901836m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1136.540079026806m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1174.829850062654m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1053.757622456689m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1127.098697546971m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 958.57409373712644m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1109.661492429461m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1158.711334925358m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 525,
                column: "Price",
                value: 1173.148749901037m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 993.379970792292m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 980.6762174947404m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 528,
                column: "Price",
                value: 1255.227220236313m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 990.0976900344167m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1205.057874859238m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 531,
                column: "Price",
                value: 1094.75620466897m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1130.682279796798m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 985.0373301557363m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1177.694906762066m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 994.7874593005513m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 964.0107787656831m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1071.557915354929m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1248.326390997381m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1285.516155375454m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1147.792736276243m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 541,
                column: "Price",
                value: 1155.935239899794m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 542,
                column: "Price",
                value: 1089.518364344973m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1183.926048494078m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 980.7298673303344m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1160.982639332566m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1063.208332952269m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1091.724213905847m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 968.4460379028165m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 993.2834021101753m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1171.275287235366m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 551,
                column: "Price",
                value: 1222.587966066249m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1106.25369276218m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 553,
                column: "Price",
                value: 988.7299955407165m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1045.9605401599108m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1106.65644296118m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1219.247608032213m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1232.134620657498m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1181.299722528252m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1141.949685242415m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1149.906939228538m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1286.583558731365m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1145.672322607307m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1026.6819543899026m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1015.3827080730449m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1095.13793092776m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1093.687884705652m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1161.224576579491m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1100.298419008777m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1111.542413674852m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 983.7282849331019m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1140.366849057772m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1020.8665446634995m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 573,
                column: "Price",
                value: 1119.83278349024m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1169.805570765092m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1086.335314542377m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1298.205874259568m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 577,
                column: "Price",
                value: 1119.649747795135m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1269.504638009554m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1055.50173813349m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 998.9326167460539m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1283.313284347761m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1029.243640230595m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1059.295313407818m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1061.246535115823m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1221.993205814765m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1207.127314356788m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 587,
                column: "Price",
                value: 1210.356226609963m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1109.943162036282m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1261.375915834362m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1182.778289348063m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1207.417585805306m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 592,
                column: "Price",
                value: 1111.751015842658m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1247.673591890344m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 594,
                column: "Price",
                value: 1198.746117371784m);

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1261149616138008008008008008m, 999, 1124.988846652187m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6260767517277845220030349014m, 659, 1071.58457938861m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.17854830316449800796812749m, 1004, 1183.262496377156m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7908825684871529051987767584m, 654, 1171.237199790598m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6270867849119847434119278779m, 721, 1173.129571921541m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1506728114231253918495297806m, 957, 1101.193880531931m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9013873736647382753403933434m, 661, 1256.817053992392m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.29162339662067096018735363m, 854, 1103.046380714053m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4087080040154306651634723788m, 887, 1249.523999561687m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0840278346631811391223155929m, 1071, 1160.993810924267m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0766487105784237605238540692m, 1069, 1150.937471608335m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1692168928880411877394636015m, 1044, 1220.662436175115m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.220396601948211283185840708m, 904, 1103.238528161183m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2396231140756757679180887372m, 879, 1089.628717272519m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9713474815900425196850393701m, 1016, 986.8890412954832m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.262928930732221752903907075m, 947, 1195.993697403414m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0169176795742514173998044966m, 1023, 1040.3067862044592m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2783722155009017051153460381m, 997, 1274.537098854399m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.624623593573025m, 800, 1299.69887485842m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4743716879900025575447570332m, 782, 1152.958660008182m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9444655332536112132352941176m, 1088, 1027.578500179929m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1279656840797690029615004936m, 1013, 1142.629237972806m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5129162594235555384615384615m, 650, 983.3955686253111m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1755637623100128205128205128m, 936, 1100.327681522172m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1721498733543002973240832507m, 1009, 1182.699222214489m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3161560316445935034482758621m, 725, 954.21312294233029m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2408372118837849588719153937m, 851, 1055.952467313101m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2587903011575774058577405858m, 956, 1203.403527906644m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5032628342279556231003039514m, 658, 989.1469449219948m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2163301988035760233918128655m, 1026, 1247.954783972469m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1408408413801540755467196819m, 1006, 1147.685886428435m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0306773538689688841201716738m, 932, 960.591293805879m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4385129434640404040404040404m, 792, 1139.30225122352m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.305123967680309662398137369m, 859, 1121.101488237386m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3334777802912251691474966171m, 739, 985.4400796352154m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4036027368823389221556886228m, 835, 1172.008285296753m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6894026800177438136826783115m, 687, 1160.61964117219m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1393238251142071583514099783m, 922, 1050.456566755299m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4489969180050364583333333333m, 672, 973.7259288993845m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.946353308350741192917054986m, 1073, 1015.4370998603453m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4863550165216904441453566622m, 743, 1104.361777275616m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3885784540273032214765100671m, 745, 1034.4909482503409m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1678537193909342342342342342m, 888, 1037.0541028191496m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2493649486579474789915966387m, 952, 1189.395431122366m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2258153867254357366771159875m, 957, 1173.105325096242m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2212449214496494623655913978m, 837, 1022.1819992533566m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3365109704607699004975124378m, 804, 1074.554820250459m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3748286068261953216374269006m, 855, 1175.478458836397m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4119309322958451327433628319m, 904, 1276.385562795444m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5165794409255254470426409904m, 727, 1102.553253552857m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4392984120753865309200603318m, 663, 954.25484720598127m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9427685769442741573033707865m, 1068, 1006.8768401764848m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2804266616699825870646766169m, 804, 1029.463035982666m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3282219213246720257234726688m, 933, 1239.231052595919m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4589759763249653401797175866m, 779, 1136.542285557148m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3701480849675719512195121951m, 820, 1123.521429673409m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0999601034060276073619631902m, 978, 1075.760981131095m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.159724515314028957528957529m, 1036, 1201.474597865334m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1554441685166503378378378378m, 888, 1026.0344216427855m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3214671960049333333333333333m, 855, 1129.854452584218m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9764902788355959262851600388m, 1031, 1006.7614774794994m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1546232261899154929577464789m, 923, 1065.717237773292m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1357413181141527936145952109m, 877, 996.045135986112m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3856953123442530933633295838m, 889, 1231.883132674041m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5451777383231944777911164466m, 833, 1287.133056023221m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6571749525464805013927576602m, 718, 1189.851615928373m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.273128006280262582056892779m, 914, 1163.63899774016m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5456041043241618798955613577m, 766, 1183.932743912308m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3860286838284187667560321716m, 746, 1033.9773981360004m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1004296470482490384615384615m, 1040, 1144.446832930179m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7797129071904124629080118694m, 674, 1199.526499446338m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.309390964636347682119205298m, 906, 1186.308213960531m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2172758674412382022471910112m, 890, 1083.375522022702m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2045314180765657276995305164m, 852, 1026.260768201234m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5915961857087422680412371134m, 776, 1235.078640109984m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.975658790887024390243902439m, 656, 1296.032166821888m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4681061388680080321285140562m, 747, 1096.675285734402m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.507352632819022972972972973m, 740, 1115.440948286077m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1235417458603731193580742227m, 997, 1120.171120622792m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1322022780639035914702581369m, 891, 1008.7922297549381m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3383264910454018475750577367m, 866, 1158.990741245318m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2120348389410445859872611465m, 942, 1141.736818282464m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4709189868294808806488991889m, 863, 1269.403085633842m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.067940237307569811320754717m, 1060, 1132.016651546024m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.44865317563845m, 780, 1129.949476997991m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3013063175890776583034647551m, 837, 1089.193387822058m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7912685447458766140602582496m, 697, 1248.514175687876m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4467425024869611764705882353m, 850, 1229.731127113917m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0003986925133936073059360731m, 1095, 1095.436568302166m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.305669432279695741935483871m, 775, 1011.8938100167642m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4045567664434254807692307692m, 832, 1168.59122968093m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0709290113718156590683845391m, 1009, 1080.567372474162m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3732230654833454935622317597m, 932, 1279.843897030478m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2800406237573088198757763975m, 805, 1030.4327021246336m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0508181852849864693446088795m, 946, 994.0740032795972m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6526919564106526315789473684m, 760, 1256.045886872096m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.99172665934006611328125m, 1024, 1015.5280991642277m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.744060043607468562874251497m, 668, 1165.032109129789m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0281374825279717779868297272m, 1063, 1092.910143927234m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2108918750272620689655172414m, 870, 1053.475931273718m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5124814844018323494687131051m, 847, 1281.071817288352m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1570053412279223814773980154m, 907, 1049.4038444937256m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1126240567952898158179848321m, 923, 1026.9520044220525m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9750178622477577928363988383m, 1033, 1007.1934517019338m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1844993896117616580310880829m, 965, 1143.04191097535m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9806310338738811700182815356m, 1094, 1072.810351058026m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8993135442423276248821866164m, 1061, 954.17167044110961m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5407391407018467261904761905m, 672, 1035.376702551641m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4076792074521432160804020101m, 796, 1120.512649131906m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4608611217486178674351585014m, 694, 1013.8376184935408m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5216985968605265423242467719m, 697, 1060.623922011787m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1070972492756850551654964895m, 997, 1103.775957527858m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4295413924718183118741058655m, 699, 999.249433337801m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2249922611545594758064516129m, 992, 1215.192323065323m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0562399171399482596425211665m, 1063, 1122.783031919765m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.416384705089897503285151117m, 761, 1077.868760573412m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2991266219241038251366120219m, 915, 1188.700859060555m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3742960357697027707808564232m, 794, 1091.191052401144m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.31766408939321256038647343m, 828, 1091.02586601758m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0595810889539917910447761194m, 938, 993.8870614388443m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3878170305243173431734317343m, 813, 1128.29524581627m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.137947057259638121546961326m, 1086, 1235.810504183967m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6461299076603313432835820896m, 670, 1102.907038132422m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9996084202974040674603174603m, 1008, 1007.6052876597833m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3609238045453185096153846154m, 832, 1132.288605381705m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5809059510126837481698389458m, 683, 1079.758764541663m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.549450211736915351506456241m, 697, 1079.96679758063m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4055406960477818930041152263m, 729, 1024.639167418833m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0304671295575013824884792627m, 1085, 1118.056835569889m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3131319825347699004975124378m, 804, 1055.758113957955m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4650982154204879898862199747m, 791, 1158.892688397606m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3165103751112406738868832732m, 831, 1094.020121717441m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4898212593419059720457433291m, 787, 1172.48933110208m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.003524243020591254752851711m, 1052, 1055.707503657662m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.152029831600123943661971831m, 1065, 1226.911770654132m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2047158100765299145299145299m, 1053, 1268.565748010586m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.036224271247051963746223565m, 993, 1028.9707013483226m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3833271600361992709599027947m, 823, 1138.478252709792m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1534216826917184466019417476m, 927, 1069.221899855223m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1015802028850325534079348932m, 983, 1082.853339435987m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1448449935928662301216089804m, 1069, 1223.839298150774m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0728560246355130597014925373m, 1072, 1150.10165840927m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1886752085565141955835962145m, 951, 1130.430123337245m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0579223775976636363636363636m, 935, 989.1574230538155m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0090622119538972049689440994m, 966, 974.7540967474647m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2354650100923896848137535817m, 1047, 1293.531865566732m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4727371035773709039548022599m, 708, 1042.6978693327786m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0647610606226245098039215686m, 1020, 1086.056281835077m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1895120113735061099796334012m, 982, 1168.100795168783m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3701112986292264808362369338m, 861, 1179.665828119764m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2638781450027672018348623853m, 872, 1102.101742442413m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "EuPerKm", "TripPrice" },
                values: new object[] { 1.3469400544000687772925764192m, 1233.797089830463m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0224514760281818367346938776m, 980, 1002.0024465076182m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1695262099962547065337763012m, 903, 1056.082167626618m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2010248484522221115537848606m, 1004, 1205.828947846031m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5109389572654918238993710692m, 795, 1201.196471026066m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3683742442367670527670527671m, 777, 1063.226787771968m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7039599086454368340943683409m, 657, 1119.501659980052m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5187436042653535075653370014m, 727, 1104.126600300912m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3733503979333722163308589608m, 943, 1295.06942525117m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4916855882606023668639053254m, 845, 1260.474322080209m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8760048462388646605504587156m, 1090, 954.84528240036248m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0176996684369466911764705882m, 1088, 1107.257239259398m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2970432350903895216400911162m, 878, 1138.803960409362m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3486683185142794279427942794m, 909, 1225.93950152948m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1690048057145077262693156733m, 906, 1059.118353977344m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1703772282999731958762886598m, 970, 1135.265911450974m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7576231746073m, 710, 1247.912453971183m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2690504599374964285714285714m, 840, 1066.002386347497m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.24478579458961775m, 800, 995.8286356716942m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9983783620122775096525096525m, 1036, 1034.3199830447195m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4373858819437927272727272727m, 825, 1185.843352603629m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9065825107681696696696696697m, 666, 1269.783952171601m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1197504405784565434565434565m, 1001, 1120.870191019035m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4166061779627041884816753927m, 764, 1082.287119963506m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1485991696242791164658634538m, 996, 1144.004772945782m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7181210163660471976401179941m, 678, 1164.88604909618m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3374161660934611253196930946m, 782, 1045.8594418850866m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5341466385648932160804020101m, 796, 1221.180724297655m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2638326693892107574094401756m, 911, 1151.351561813571m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.917354137211540377358490566m, 1060, 972.3953854442328m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7339727516906429652042360061m, 661, 1146.155988867515m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0216896882140588174273858921m, 964, 984.9088594383527m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0767997238338062622309197652m, 1022, 1100.48931775815m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3304317317901441527777777778m, 720, 957.91084688890379m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9849697770191319253438113949m, 1018, 1002.6992330054763m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3185905481625750605326876513m, 826, 1089.155792782287m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2024179672229090909090909091m, 1023, 1230.073580469036m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4069834089986608315098468271m, 914, 1285.982835824776m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0973263619455556594948550047m, 1069, 1173.041880919799m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.111338920626437956204379562m, 1096, 1218.027457006576m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3608660670889033505154639175m, 776, 1056.032068060989m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.372538602236773394495412844m, 763, 1047.2469535066581m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.080876721270703888334995015m, 1003, 1084.119351434516m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2164881455595176211453744493m, 908, 1104.571236168042m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2921798956909541284403669725m, 872, 1126.780869042512m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4868013335143487394957983193m, 714, 1061.576152129245m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7677342954473462109955423477m, 673, 1189.685180836064m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1727813012153296258847320526m, 989, 1159.880706901961m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0890040607706388946819603754m, 959, 1044.3548942790427m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9501296832299297709923664122m, 1048, 995.7359080249664m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1220471963511069124423963134m, 1085, 1217.421208040951m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6388231385815607734806629834m, 724, 1186.50795233305m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0555607542198125379170879676m, 989, 1043.9495859233946m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4328689666222306843267108168m, 906, 1298.179283759741m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9628621683975476555023923445m, 1045, 1006.1909659754373m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.449009723629676056338028169m, 781, 1131.676594154777m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0585621653015662955465587045m, 988, 1045.8594193179475m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6480451073423333333333333333m, 768, 1265.698642438912m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2097173934991216931216931217m, 945, 1143.18293685667m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2571275941733950980392156863m, 1020, 1282.270146056863m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0825329917206430568499534017m, 1073, 1161.55790011625m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0604676138705496809480401094m, 1097, 1163.332972415993m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9745065708550352153110047847m, 1045, 1018.3593665435118m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7072478280266432432432432432m, 740, 1263.363392739716m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1418295160141345595353339787m, 1033, 1179.509890042601m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2247654188348562367864693446m, 946, 1158.628086217774m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7994468503229467275494672755m, 657, 1182.236580662176m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2571164910368031055900621118m, 805, 1011.9787752846265m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3035471900251055276381909548m, 995, 1297.02945407498m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1302605645957505070993914807m, 986, 1114.43691669141m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2281191272987693156732891832m, 906, 1112.675929332685m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1303855293126258919469928644m, 981, 1108.908204255686m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2975185213492613965744400527m, 759, 984.8165577040894m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1767422190316515580736543909m, 1059, 1246.170009954519m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4395430260177795321637426901m, 684, 984.6474297961612m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1389727741362534309240622141m, 1093, 1244.897242130925m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2133631258942676470588235294m, 1020, 1237.630388412153m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2148276112664163424124513619m, 1028, 1248.842784381876m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2383647904030586166471277843m, 853, 1056.325166213809m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2351197554603288888888888889m, 900, 1111.607779914296m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4888834475806122931442080378m, 846, 1259.595396653198m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5578774648704376811594202899m, 690, 1074.935450760602m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4454231271204346289752650177m, 849, 1227.164234925249m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1820209699721555555555555556m, 990, 1170.200760272434m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4422762936358418708240534521m, 898, 1295.164111684986m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6172062074269186746987951807m, 664, 1073.824921731474m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3574204631485753086419753086m, 810, 1099.510575150346m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6434849047819248554913294798m, 692, 1137.291554109092m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.120932311300980498374864572m, 923, 1034.620523330805m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0593305846623519659936238045m, 941, 996.8300801672732m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5468691580192790091264667536m, 767, 1186.448644200787m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3771861210682787878787878788m, 825, 1136.17854988133m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9393290302200067924528301887m, 1060, 995.6887720332072m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2485545167786935649935649936m, 777, 970.1268595370449m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2576279099472794292508917955m, 841, 1057.665072265662m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4677133646129345088161209068m, 794, 1165.36441150267m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7675359584291982507288629738m, 686, 1212.52966748243m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3948978756782530657748049052m, 897, 1251.223394483393m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7980791675417155824508320726m, 661, 1188.530329745074m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1203413579445522233712512927m, 967, 1083.370093132382m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3989454380964583333333333333m, 864, 1208.68885851534m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.933117011601252822966507177m, 1045, 975.1072771233092m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1414032377269848637739656912m, 991, 1131.130608587442m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2561177886543268858800773694m, 1034, 1298.825793468574m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8047671652587908309455587393m, 698, 1259.727481350636m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1445860552917916666666666667m, 936, 1071.332547753117m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.949769736419550398406374502m, 1004, 953.5688153652286m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6736900881843371104815864023m, 706, 1181.625202258142m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4308777319655478158205430933m, 847, 1211.953438974819m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3865239192676283566058002148m, 931, 1290.853768838162m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0373246740508375901132852729m, 971, 1007.2422585033633m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4097751622564337748344370861m, 906, 1277.256297004329m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9811963923308841954022988506m, 1044, 1024.3690335934431m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0189441437025817533129459735m, 981, 999.5842049722327m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6575794320137005649717514124m, 708, 1173.5662378657m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1771462149181755577109602328m, 1031, 1213.637747580639m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2842982027464306122448979592m, 980, 1258.612238691502m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5376579885462324246771879484m, 697, 1071.747618016724m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9225677554623404174573055028m, 1054, 972.3864142573068m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2104384285694126659856996936m, 979, 1185.019221569455m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6183620530232623626373626374m, 728, 1178.167574600935m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9809193705180720802919708029m, 1096, 1075.087630087807m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6844687405502635761589403974m, 755, 1271.773899115449m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9716896687294815589353612167m, 1052, 1022.2175315034146m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4982067035552964763061968408m, 823, 1233.024117026009m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1319576431091779642058165548m, 894, 1011.9701329396051m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.992620020474256572541382668m, 1027, 1019.4207610270615m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1011373707299377901578458682m, 1077, 1185.924948276143m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3751877156163749665327978581m, 747, 1027.2652235654321m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3478778722699539803094233474m, 711, 958.34116718393728m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.591515187677469618320610687m, 655, 1042.4424479287426m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1187710017586471351351351351m, 925, 1034.8631766267486m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5054545445241592442645074224m, 741, 1115.541817492402m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.609211358033461340206185567m, 776, 1248.748013833966m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3773252967427401908801696713m, 943, 1298.817754828404m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2322232619774438827098078868m, 989, 1218.668806095692m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7599243014627993920972644377m, 658, 1158.030190362522m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2432901027865806783144912641m, 973, 1209.721270011343m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.074772088477048590021691974m, 922, 990.9398655758388m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5430065330800115107913669065m, 695, 1072.389540490608m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5631620895164769647696476965m, 738, 1153.61362206316m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4234705286549723320158102767m, 759, 1080.414131249124m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2117573171259712070874861573m, 903, 1094.216857364752m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1564187989201436823104693141m, 831, 960.9840219026394m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8310875805750538573508005822m, 687, 1257.957167855062m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2387302128903288659793814433m, 970, 1201.568306503619m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4724045994565126436781609195m, 696, 1024.7936012217328m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.464086892705472258064516129m, 775, 1134.667341846741m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0589548206048868282402528978m, 949, 1004.9481247540376m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.268234367320350609756097561m, 820, 1039.9521812026875m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4773226343767654320987654321m, 810, 1196.63133384518m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9835466076541389396709323583m, 1094, 1075.999988773628m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3808272686012068095838587642m, 793, 1094.996024000757m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6827876851260913838120104439m, 766, 1289.015366806586m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3937698434719294377067254686m, 907, 1264.14924802904m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.195038462870878619153674833m, 898, 1073.144539658049m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2274189918916457905544147844m, 974, 1195.506098102463m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2424480101604773413897280967m, 993, 1233.750874089354m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5791616754029491315136476427m, 806, 1272.804310374777m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2583266917267182448036951501m, 866, 1089.710915035338m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6186700996835044642857142857m, 672, 1087.746306987315m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5713739557119202095808383234m, 668, 1049.6778024155627m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0581098574501603030303030303m, 990, 1047.5287588756587m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0585963057646278625954198473m, 1048, 1109.40892844133m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.89519088942458003663003663m, 1092, 977.5484512516414m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7356669082047831325301204819m, 664, 1152.482827047976m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9468177343819131054131054131m, 1053, 996.9990743041545m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8115549729377440119760479042m, 668, 1210.118721922413m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0763294746179698249227600412m, 971, 1045.1159198540487m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9904127791937386602870813397m, 1045, 1034.9813542574569m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0555731748253757675438596491m, 912, 962.6827354407427m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.076804363168178188899707887m, 1027, 1105.878080973719m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5031465010835688545688545689m, 777, 1167.944831341933m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1105404383838688787185354691m, 874, 970.6123431475014m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5497778740306364764267990074m, 806, 1249.120966468693m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3568235608665396308360477742m, 921, 1249.634499558083m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.277640606087710239651416122m, 918, 1172.874076388518m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6025620600660237430167597765m, 716, 1147.434435007273m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4231335552249437935843793584m, 717, 1020.3867590962847m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2221329962138962172647914646m, 1031, 1260.019119096527m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0512696605664068265682656827m, 1084, 1139.576312053985m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7906184301175508474576271186m, 708, 1267.757848523226m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2341460980075211538461538462m, 1040, 1283.511941927822m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.295580689129934010152284264m, 985, 1276.146978792985m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9252608153641206500956022945m, 1046, 967.8228128708702m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5795384012729684684684684685m, 666, 1051.972575247797m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0775418728008942042318307268m, 1087, 1171.288015734572m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9204776195530177649325626204m, 1038, 955.45576909603244m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5708577362345656836461126005m, 746, 1171.859871230986m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9690047392136285570131180626m, 991, 960.2836965607059m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2385306164623900778210116732m, 1028, 1273.209473723337m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1902858675951990643274853801m, 855, 1017.6944167938952m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4380532288084215007215007215m, 693, 996.5708875642361m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4699722585981202830188679245m, 848, 1246.536475291206m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3627152351444232008592910849m, 931, 1268.687883919458m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.078408779819148723640399556m, 901, 971.646310617053m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.572685543597288719512195122m, 656, 1031.6817165998214m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9501948147490124629080118694m, 1011, 960.6469577112516m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4945340220467325905292479109m, 718, 1073.075427829554m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3203424625231273532668881506m, 903, 1192.269243658384m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4385574458135771365149833518m, 901, 1296.140258678033m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4271118884008203170028818444m, 694, 990.4156505501693m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2560042977730723618090452261m, 995, 1249.724276284207m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1039649687641905419766206164m, 941, 1038.8310356071033m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5211983600626697612732095491m, 754, 1146.983563487253m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5408671451499157458563535912m, 724, 1115.587813088539m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.761316555050746606334841629m, 663, 1167.752875998645m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1067523323143929032258064516m, 930, 1029.2796690523854m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7035385768115818965517241379m, 696, 1185.662849460861m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.427589108243425974025974026m, 770, 1099.243613347438m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5966099695964475m, 800, 1277.287975677158m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4870813851382233128834355828m, 652, 969.5770631101216m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5157139084596398514851485149m, 808, 1224.696838035389m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1232536967905970588235294118m, 1020, 1145.718770726409m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0638156041481327424400417101m, 959, 1020.1991643780593m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2109513133246100196463654224m, 1018, 1232.748436964453m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.174160267043609942638623327m, 1046, 1228.171639327616m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6665319385426115485564304462m, 762, 1269.89733716947m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1272169418560355191256830601m, 915, 1031.4035017982725m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0538210727031383399209486166m, 1012, 1066.466925575576m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5450213177172670731707317073m, 820, 1266.917480528159m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5021915838139273743016759777m, 716, 1075.569174010772m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4910261308867543674698795181m, 664, 990.0413509088049m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.540742175617014050822122571m, 669, 1030.7565154877824m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0244716414429080675422138837m, 1066, 1092.08676977814m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3343867602892044444444444444m, 900, 1200.948084260284m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1550293542563398601398601399m, 858, 991.0151859519396m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5985681615082678803641092328m, 769, 1229.298916199858m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3139247904399294871794871795m, 936, 1229.833603851774m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4535077777855967523680649526m, 739, 1074.142247783556m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6049400577823614814814814815m, 675, 1083.334539003094m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.999456201989508675799086758m, 1095, 1094.404541178512m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5508230249174830508474576271m, 708, 1097.982701641578m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1149963522525608108108108108m, 1036, 1155.136220933653m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2578564001412812987012987013m, 770, 968.5494281087866m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1040555034819476439790575916m, 955, 1054.37300582526m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4239056139306055865921787709m, 895, 1274.395524467892m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3227947890117938775510204082m, 980, 1296.338893231558m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0347050942137800632911392405m, 948, 980.9004293146635m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2547043148556392961876832845m, 1023, 1283.562514097319m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2016224653352772946859903382m, 1035, 1243.679251622012m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0207985350309466202783300199m, 1006, 1026.9233262411323m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9831564563752009345794392523m, 1070, 1051.977408321465m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5039987075163069948186528497m, 772, 1161.087002202589m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3181292921535109261186264308m, 961, 1266.722249759524m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0864173210724396551724137931m, 928, 1008.195273955224m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2863166040061703939008894536m, 787, 1012.3311673528561m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0497524834929170575692963753m, 938, 984.6678295163562m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.134089335375636552440290758m, 963, 1092.128029966738m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1601921413553011337868480726m, 882, 1023.2894686753756m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8469461651059672830725462304m, 703, 1298.403154069495m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1648615467750053361792956243m, 937, 1091.47526932818m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1060190521566450113378684807m, 882, 975.5088040021609m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3150582513039882100750267953m, 933, 1226.949348466621m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6063901706251931972789115646m, 735, 1180.696775409517m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9990897621069411290322580645m, 992, 991.0970440100856m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2641592229185940316686967113m, 821, 1037.8747220161657m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3317377248218315098468271335m, 914, 1217.208280487154m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2818197167620342789598108747m, 846, 1084.419480380681m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1457025347988405491024287223m, 947, 1084.980300454502m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3523023359123082627118644068m, 944, 1276.573405101219m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5842809623888449408672798949m, 761, 1205.637812377911m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0849752472941370143149284254m, 978, 1061.105791853666m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1895966328489337676438653637m, 921, 1095.618498853868m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1522126256008639308855291577m, 926, 1066.9488913064m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0848429975649312108559498956m, 958, 1039.2795916672041m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6815287168483123324396782842m, 746, 1254.420422768841m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2352616176045611111111111111m, 900, 1111.735455844105m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0895081818817928505957836847m, 1091, 1188.653426433036m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6652709408556587301587301587m, 756, 1258.944831286878m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7182470691369435975609756098m, 656, 1127.170077353835m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1709804998873045685279187817m, 985, 1153.415792388995m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0117559759811651829871414441m, 1011, 1022.885291716958m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4396918759185525862068965517m, 696, 1002.0255456393126m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3040859811016087891156462585m, 735, 958.50319610968246m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2641106830533439240506329114m, 790, 998.6474396121417m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1339879946450009560229445507m, 1046, 1186.151442398671m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5690289377374595744680851064m, 705, 1106.165401104909m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6336960351674206451612903226m, 775, 1266.114427254751m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1292088198800249768732654949m, 1081, 1220.674734290307m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.957799088960010009624639076m, 1039, 995.1532534294504m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6941199189089270386266094421m, 699, 1184.18982331734m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3100407046967462845010615711m, 942, 1234.058343824335m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2616656162292980719794344473m, 778, 981.5758494263939m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4416078447387951653944020356m, 786, 1133.103765964693m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3410171556910269736842105263m, 760, 1019.1730383251805m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5344799412746795180722891566m, 664, 1018.8946810063872m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2548000517516732161323681489m, 967, 1213.391650043868m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8882359262838172043010752688m, 651, 1229.241588010765m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7155629672474761255115961801m, 733, 1257.5076549924m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.601327978718m, 697, 1116.125601166446m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1328146995091732947976878613m, 865, 979.8847150754349m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.097495420981663147792706334m, 1042, 1143.590228662893m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0568141183397148080438756856m, 1094, 1156.154645463648m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3941245738525070257611241218m, 854, 1190.582386070041m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3752445309992558411214953271m, 856, 1177.209318535363m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9709579380353788554801163919m, 1031, 1001.0576341144756m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3282510886893762886597938144m, 970, 1288.403556028695m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3183699237387725587144622991m, 809, 1066.561268304667m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4763038142880341176470588235m, 850, 1254.858242144829m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2208833675309193381592554292m, 967, 1180.594216402399m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2293387432551501154734411085m, 866, 1064.60735165896m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7115993103409220588235294118m, 680, 1163.887531031827m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6612073212850598404255319149m, 752, 1249.227905606365m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1524353149847738317757009346m, 1070, 1233.105787033708m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9131674026421041398344066237m, 1087, 992.6129666719672m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1244480698279418837675350701m, 998, 1122.199173688286m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6067939618491753246753246753m, 770, 1237.231350623865m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1715581099204139676113360324m, 988, 1157.499412601369m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3120696666600881670533642691m, 862, 1131.004052660996m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6319894477504647239263803681m, 652, 1064.057119933303m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5074023651368649592549476135m, 859, 1294.858631652567m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9315743903956550697674418605m, 1075, 1001.4424696753292m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2247252562159814624098867147m, 971, 1189.208223785718m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1057188952062440585009140768m, 1094, 1209.656471355631m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0632758716076293838862559242m, 1055, 1121.756044546049m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4375024224723027522935779817m, 872, 1253.502112395848m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2556156301106747967479674797m, 984, 1235.525780028904m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1532199082964411764705882353m, 918, 1058.655875816133m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2702516665987760651629072682m, 798, 1013.6608299458233m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3213435707006587395957193817m, 841, 1111.249942959254m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7498388425023071104387291982m, 661, 1156.643474894025m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4132782064603617977528089888m, 890, 1257.817603749722m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0757142222951413757700205339m, 974, 1047.7456525154677m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1496078743582180656934306569m, 1096, 1259.970230296607m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3526687817963849372384937238m, 956, 1293.151355397344m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1427626119403555172413793103m, 870, 994.2034723881093m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.499534035163300140252454418m, 713, 1069.167767071433m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1897212070785376569037656904m, 956, 1137.373473967082m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3113363396055723108665749656m, 727, 953.34151889325107m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6373332174134746227709190672m, 729, 1193.615915494423m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2123451862807848775510204082m, 784, 950.478626044135344m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2043994042656655251141552511m, 876, 1055.053878136723m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7790170386044337899543378995m, 657, 1168.814194363113m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4406995807350715909090909091m, 704, 1014.2525048374904m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1320519343583157396449704142m, 845, 956.5838845327768m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5647665505932754820936639118m, 726, 1136.020515730718m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2225139667691982281284606866m, 903, 1103.930111992586m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4052755191841503496503496503m, 858, 1205.726395460001m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0431948492382509765625m, 1024, 1068.231525619969m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5806457771457948717948717949m, 819, 1294.548891482406m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1927091242470668859649122807m, 912, 1087.750721313325m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5640328457324325699745547074m, 786, 1229.329816745692m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0877378213161106334841628959m, 884, 961.5602340434418m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3945414943195622462787550744m, 739, 1030.5661643021565m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0607242619031031220435193945m, 1057, 1121.18554483158m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.131768243419075187969924812m, 931, 1053.676234623159m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6092191705363812307692307692m, 650, 1045.9924608486478m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2081639268016953125m, 1024, 1237.159861044936m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4435815260655105413105413105m, 702, 1013.3942312979884m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2779689828005551181102362205m, 1016, 1298.416486525364m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.674492384340550354609929078m, 705, 1180.517130960088m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3589509837734099307159353349m, 866, 1176.851551947773m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3020694918821462041884816754m, 764, 994.7810917979597m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3858963943096391117478510029m, 698, 967.3556832281281m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2444122018463519704433497537m, 812, 1010.4627078992378m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8569966930125464231354642314m, 657, 1220.046827309243m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.090754984749928125m, 896, 977.3164663359356m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1635652072526401273885350318m, 942, 1096.078425231987m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1304184863272859884836852207m, 1042, 1177.896062753032m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9703587992382936329588014981m, 1068, 1036.3431975864976m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6892953757987402234636871508m, 716, 1209.535489071898m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3580812504885922330097087379m, 824, 1119.0589504026m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1762576426058732018561484919m, 862, 1013.9340879262627m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1921677937201522700814901048m, 859, 1024.0721348056108m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4131488116649376443418013857m, 866, 1223.786870901836m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1445519426251822759315206445m, 993, 1136.540079026806m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.359756770905849537037037037m, 864, 1174.829850062654m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2803859325111652490886998785m, 823, 1053.757622456689m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4249035367218343868520859671m, 791, 1127.098697546971m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2180102842911390597204574333m, 787, 958.57409373712644m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3784614812788335403726708075m, 805, 1109.661492429461m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1633647941017650602409638554m, 996, 1158.711334925358m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4738049621872324120603015075m, 796, 1173.148749901037m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9524256671067037392138063279m, 1043, 993.379970792292m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.267023536814910077519379845m, 774, 980.6762174947404m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1654848841562794800371402043m, 1077, 1255.227220236313m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1341325200852424971363115693m, 873, 990.0976900344167m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2423277060404515463917525773m, 970, 1205.057874859238m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0269758017532551594746716698m, 1066, 1094.75620466897m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4258288522027717528373266078m, 793, 1130.682279796798m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3329327877614834912043301759m, 739, 985.0373301557363m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6177127840138269230769230769m, 728, 1177.694906762066m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9456154556088890684410646388m, 1052, 994.7874593005513m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9332146938680378509196515005m, 1033, 964.0107787656831m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2771846428545041716328963051m, 839, 1071.557915354929m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.438164044927858294930875576m, 868, 1248.326390997381m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1958289817446083720930232558m, 1075, 1285.516155375454m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0787525716881983082706766917m, 1064, 1147.792736276243m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4687868359590775095298602287m, 787, 1155.935239899794m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4354655656719011857707509881m, 759, 1089.518364344973m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6865043425841566951566951567m, 702, 1183.926048494078m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1844563615100657004830917874m, 828, 980.7298673303344m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3298770209995028636884306987m, 873, 1160.982639332566m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5635416661062779411764705882m, 680, 1063.208332952269m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0950092416307392176529588766m, 997, 1091.724213905847m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3934475365508151079136690647m, 695, 968.4460379028165m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0208462508840445015416238438m, 973, 993.2834021101753m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0696577965619780821917808219m, 1095, 1171.275287235366m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6171798492939801587301587302m, 756, 1222.587966066249m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5322073306955401662049861496m, 722, 1106.25369276218m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1390898566137286866359447005m, 868, 988.7299955407165m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5115036707513161849710982659m, 692, 1045.9605401599108m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4151616917662148337595907928m, 782, 1106.65644296118m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2687280000335202913631633715m, 961, 1219.247608032213m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2585644746246149131767109295m, 979, 1232.134620657498m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.134773988980069164265129683m, 1041, 1181.299722528252m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2305492297870851293103448276m, 928, 1141.949685242415m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5993142409298164116828929068m, 719, 1149.906939228538m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7246428401224731903485254692m, 746, 1286.583558731365m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.397161369033301219512195122m, 820, 1145.672322607307m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2459732456188138349514563107m, 824, 1026.6819543899026m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1383214216065525784753363229m, 892, 1015.3827080730449m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1061999302300606060606060606m, 990, 1095.13793092776m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5691361330066743185078909613m, 697, 1093.687884705652m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7152504823921580502215657312m, 677, 1161.224576579491m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1521449413704471204188481675m, 955, 1100.298419008777m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.37058250761387422934648582m, 811, 1111.542413674852m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4256931665697128985507246377m, 690, 983.7282849331019m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2698962684384988864142538976m, 898, 1140.366849057772m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4080917857427579310344827586m, 725, 1020.8665446634995m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0436465829359179869524697111m, 1073, 1119.83278349024m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1973444941300839303991811668m, 977, 1169.805570765092m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4407630166344522546419098143m, 754, 1086.335314542377m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5491716876605823389021479714m, 838, 1298.205874259568m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.074519911511645873320537428m, 1042, 1119.649747795135m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6616552853528193717277486911m, 764, 1269.504638009554m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2188241779832448036951501155m, 866, 1055.50173813349m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0080046586741209889001009082m, 991, 998.9326167460539m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8359274454188283261802575107m, 699, 1283.313284347761m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2801537813813370646766169154m, 804, 1029.243640230595m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0040713871164151658767772512m, 1055, 1059.295313407818m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4517736458492790697674418605m, 731, 1061.246535115823m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5646519920803649167733674776m, 781, 1221.993205814765m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1892879944401852216748768473m, 1015, 1207.127314356788m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1134831891535998160073597056m, 1087, 1210.356226609963m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1573964150534744525547445255m, 959, 1109.943162036282m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4382849667438563283922462942m, 877, 1261.375915834362m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.716659345933328011611030479m, 689, 1182.778289348063m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4339876315977505938242280285m, 842, 1207.417585805306m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1286812343580284263959390863m, 985, 1111.751015842658m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2232094038140627450980392157m, 1020, 1247.673591890344m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4708541317445202453987730061m, 815, 1198.746117371784m });

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Employee full name");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "a81da816-32b3-4aab-ae10-a32623a92be9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dispatcherRoleId",
                column: "ConcurrencyStamp",
                value: "90e422d9-3dcf-4e0b-9cb8-438b29499614");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "managerRoleId",
                column: "ConcurrencyStamp",
                value: "0d811678-1f0e-4537-80bd-20261c755ede");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0261d5ca-050a-423e-90cb-c7e990f67959",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserEmail" },
                values: new object[] { "623d7485-415d-4dea-b37a-90e1cca30f7f", "AQAAAAEAACcQAAAAEKzzjG9uyEtz9c0Apf38kXBEK6Wh5bbqbh4ETBTJSYAmczoum7y8VLwvQIfOIGiyMg==", "f357ecb3-b833-40b0-8eda-7ed9a5957b6c", "" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19918df1-9468-434b-aaf9-a3d22b2d12e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserEmail" },
                values: new object[] { "bdca148a-4526-431d-8497-f12ea0493bdc", "AQAAAAEAACcQAAAAEM6TGVGWLcaSkX2bAqrSd6pboJH8sxOjtwgDsE2yw0M7Bjp4sNzeD7H2M4N18tSnig==", "c734bad9-7daf-481a-a451-26a44dc1c9fe", "" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62154153-66df-4b35-91ed-56ac983c9a8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserEmail" },
                values: new object[] { "662e5f14-2f2b-447f-b0bd-e96f74230c5a", "AQAAAAEAACcQAAAAEHWJIs6wETf9s3GxuK2cVperPtcBESF9hDCKi4JMm+aXE03i+wS+gGRDclun1XMZvQ==", "a04cfece-b50e-4615-b973-bd9e7aeb061e", "" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserEmail" },
                values: new object[] { "e57a9df9-bf47-4d3d-81ae-61b46cabfa05", "AQAAAAEAACcQAAAAEETHtgf3yNX0wyy+LuPbEA2Nw12EKwI5t0INiMS30teLB9AFXH9pFdBHD15p7P+y8g==", "57273e59-ad52-428b-a009-d7c59fcf1ebb", "" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "FullName",
                value: "Admin Admin");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "FullName",
                value: "Chief");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "FullName",
                value: "Hans Uno");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "FullName",
                value: "Hans Due");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1190.167425074847m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1181.846049131177m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1149.32829900414m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1125.88241009569m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1104.283373414463m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1118.145926414576m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1053.54295269777m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 1202.182268138724m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 1014.264774649582m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1201.954286140502m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1288.473012886524m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1096.029842819027m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1036.9689125257832m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1263.006561437638m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1027.4859411947654m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1174.232818548375m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 996.6400561021909m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 1042.3010448277404m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1279.4786657111m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1245.101667478168m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1285.272991003225m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1086.487608173778m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 979.031594134181m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1134.720768612596m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1092.882949671926m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1012.128721290247m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1095.582140556218m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1091.383026681201m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1276.369191086432m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1103.951329950725m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1082.8105422986m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1275.438285718505m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1005.4360492067662m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34,
                column: "Price",
                value: 1189.885681283753m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1251.480684265491m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1129.766430247396m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 988.8454039608899m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1196.450512047314m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39,
                column: "Price",
                value: 1187.904914111091m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1178.789047113124m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1127.888456652522m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1033.0244219571519m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43,
                column: "Price",
                value: 1103.270691909123m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1129.150976687625m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1159.030211929375m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 995.6265212729926m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1106.102919880923m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1045.832509798308m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49,
                column: "Price",
                value: 991.9669247685468m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1244.080735220502m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1172.06880429626m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1146.39033790724m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1154.48744797763m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 985.9492186568814m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1253.407500259781m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1273.276805423393m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 954.72211285465707m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 964.7181744118615m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1041.8784134015287m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1147.01581192114m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1140.59289086593m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1283.701577413707m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 952.40963276879807m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1075.282167191278m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1226.842850112645m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 976.1608163121194m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 67,
                column: "Price",
                value: 1166.824680369358m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1098.250543924124m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1031.8767644723053m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1142.46835650714m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1196.353068929923m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1143.644376383252m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1238.021989950462m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1126.657521369424m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1294.318950530437m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1256.655798870197m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1214.097763853371m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1061.519177604589m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1249.965229020979m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1095.252416571327m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1142.807173656094m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 990.2562950903672m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1090.031281023314m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1103.329953566725m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1160.26432971671m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1147.540925848012m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1281.03715865806m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 965.988893890868m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1094.266043498886m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1061.989869881223m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1106.24143408079m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1052.954994591777m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1295.32548990624m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1048.9241712525114m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 993.5126685626837m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 976.1911910740631m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1220.50615757272m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1166.924931200917m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1057.548148096149m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 100,
                column: "Price",
                value: 1161.45315279535m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 101,
                column: "Price",
                value: 1106.955074245073m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1170.782375543425m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1236.635098418081m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1134.223258478419m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1047.9903056970089m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 988.225453939226m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1245.679332690146m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1266.104864858145m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1297.896726231899m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1063.471141748928m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1038.1866025200884m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 112,
                column: "Price",
                value: 1218.231708193789m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1137.892934126119m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1266.072177363793m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 115,
                column: "Price",
                value: 1112.21375187269m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1153.031721562388m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1228.552768955021m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1285.558728660574m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1043.0905363497468m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 979.279803909139m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 121,
                column: "Price",
                value: 1295.253434661864m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1270.484729685972m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1099.851160558376m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1151.117131459338m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1047.7503200675682m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1045.3323603486861m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1055.661682751219m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1189.681706235704m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1229.466540953237m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 969.8296093030604m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1108.4689615192m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 132,
                column: "Price",
                value: 1128.478597983879m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1286.20252964255m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 986.7169029407689m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1186.057160211172m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1215.043654664152m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1052.60955290334m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1178.300535151878m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1032.2539163041098m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1292.978977989201m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1229.351360813127m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1236.074954366022m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1264.984751094873m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1078.073375488114m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1299.964016023679m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 955.36675544105419m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 950.877969561121961m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1182.130901131411m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1186.470047049409m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1196.476293675631m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1016.2275709480602m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 152,
                column: "Price",
                value: 1130.887990749327m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1052.195668203404m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 154,
                column: "Price",
                value: 1156.789450100235m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1129.573417693923m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1101.850915344828m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1243.614018936973m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1018.1062090283645m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1188.234592824658m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 160,
                column: "Price",
                value: 1109.205169000953m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1255.209568313615m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 162,
                column: "Price",
                value: 1070.324412313255m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1091.987599090279m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1000.2260873618945m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1023.8807895303568m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1276.492054543742m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1144.5809187368m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1080.048468647859m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1212.448109850807m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1158.347743031446m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1014.1345222245205m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1021.8375683285253m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1175.137100709515m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 174,
                column: "Price",
                value: 991.9975444346482m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1172.674160327363m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 960.8388389377453m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 177,
                column: "Price",
                value: 1045.3630483038065m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1253.798106813354m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1183.804208345086m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1031.2567960656047m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1265.753174514423m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 995.0961146258857m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 963.5950801279375m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1176.769558069531m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1297.468375569739m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1291.945621557357m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1285.480805093378m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1207.983730418809m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1254.380749618549m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1155.564940687864m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1105.288522907847m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1294.090098439263m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1056.459640826451m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 956.70338889407187m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1031.6710935712458m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1281.857179797446m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1055.238708060883m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1058.145204260332m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1089.620763552418m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1207.603241684008m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1073.324829500353m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 984.284452910079m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1143.056117821696m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1075.905389334297m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 205,
                column: "Price",
                value: 1035.861553149448m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1209.889564444721m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 207,
                column: "Price",
                value: 1043.2349170313097m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1298.835763219011m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1076.868531025296m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1224.080581382013m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1061.28746114138m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1229.800816253815m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1016.1496495846553m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1078.026076853112m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1266.09527901019m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1251.927063102914m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1252.551476477329m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1208.448291351243m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1240.142550374902m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1140.859137856949m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1291.815343157886m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1048.3428331582084m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1244.569082748019m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1041.9674254482463m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1114.339075552906m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1296.872906042023m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 977.5269111662098m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1246.17364819836m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1152.039115869179m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1078.917232961133m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1106.79310141387m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1109.739880797728m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1281.85059111106m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 950.66568586488227m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1068.951256606085m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 960.5816926468078m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1170.568552792825m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1298.365599952399m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1065.534488329911m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1209.259388771034m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1136.615796466644m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 996.8999088430953m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1089.538620126479m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1038.443664535338m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1194.081201098087m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1177.653744083194m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1185.431281802588m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1168.272251885205m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1021.5637085932148m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 970.1177032251259m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1172.099048780883m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1047.8223931539872m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 961.3372957692672m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1233.272723207017m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1066.180180730432m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1276.562743899761m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1161.93001349923m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1176.26229127955m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1185.299776688568m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1206.400674996326m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1132.472900270405m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1256.527915238997m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1162.393018677933m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1237.157602538604m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1223.617733794963m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1277.435687859377m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 267,
                column: "Price",
                value: 1109.481328546991m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 268,
                column: "Price",
                value: 1092.892760575793m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1102.565008320538m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1001.2608362417212m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 950.901825126917682m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1015.7123279265986m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1098.750439838591m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1067.839766637458m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1035.4244862751402m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 966.7203299739708m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1286.294264483129m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1031.9310782068278m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1136.822166108642m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1028.3465206099837m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1018.6407136216067m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 282,
                column: "Price",
                value: 1224.422849026922m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1036.3421477758462m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 958.82358034659039m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1187.091253315296m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1178.923527482776m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1059.660460692386m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1054.96595658074m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1237.212391827272m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1019.8374581996858m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1178.508946459694m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1114.440420264331m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1055.252045378156m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1176.569612840147m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1221.620457052754m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1099.523659216829m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1100.211333275057m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1122.699093439437m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1041.7007349580816m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1106.080176354734m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1014.109543677087m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 302,
                column: "Price",
                value: 1041.5488759207743m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1031.7712739727733m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1152.094883998604m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1074.691710255244m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1233.253105643797m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1059.806216349029m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1053.175270764421m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1100.878384554977m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 965.1731053459599m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1258.888803801877m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1165.039473048681m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1068.380787108488m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 977.6382405867018m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1090.528065392849m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1262.519546029659m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 982.4527305925297m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1195.689375440424m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1188.082396050591m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1005.3590859250592m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1108.369325980076m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1080.532827269098m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 957.51149184914466m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1251.763989878638m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1092.378916327303m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1066.15096541366m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1069.703403371588m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1208.078691593012m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 990.7135216375308m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1179.13454354985m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 331,
                column: "Price",
                value: 1239.58269389926m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1128.095410030975m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1185.023598694684m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 334,
                column: "Price",
                value: 1292.938738744012m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1075.244387555825m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 336,
                column: "Price",
                value: 1033.5509996070228m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 991.1412510311352m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1014.5068996347097m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1211.523896079796m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1081.717633400781m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1051.801627644468m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1079.230560428802m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 343,
                column: "Price",
                value: 1287.450832789209m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 344,
                column: "Price",
                value: 1056.020399517589m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1062.970870108524m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 346,
                column: "Price",
                value: 1205.671877952111m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1058.7104189687m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 348,
                column: "Price",
                value: 952.62251839086866m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1066.46249136451m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1001.3343013280077m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 966.3495954930257m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1195.292764883877m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1218.839034554902m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1247.416894664435m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1025.9306957827196m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 356,
                column: "Price",
                value: 991.87803794722m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1088.549574576936m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 978.17274518101m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1215.039260393063m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1262.215265196799m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1246.753187043858m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1014.1206121402444m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1054.984180687055m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1197.501735250949m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1017.6030649465492m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1141.868691562568m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1148.772447970395m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1164.298122361579m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 958.65711817293493m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1247.862560470366m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1005.1461789292038m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1208.027978833526m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1060.501043232193m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1157.877031873107m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1184.326131435865m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 376,
                column: "Price",
                value: 1123.911754800572m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 377,
                column: "Price",
                value: 1177.587638718617m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1250.453912762845m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1220.981908382753m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1292.786274825293m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1024.2525545737176m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1244.008398926316m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1292.702317172205m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1127.585442226189m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1077.647269192389m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 959.35950160391784m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1203.907787815594m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 971.4748086655843m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1186.197948545813m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 390,
                column: "Price",
                value: 1044.6434715432616m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 991.4386798807874m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1120.924887731675m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1040.5076360313998m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1270.101183845105m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1260.532639073206m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1117.034788532012m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 397,
                column: "Price",
                value: 1134.405067645583m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1189.397145366792m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1226.947171274477m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1034.2747800638309m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 401,
                column: "Price",
                value: 1003.4868208995563m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1041.3516854054218m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1178.006267726946m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 404,
                column: "Price",
                value: 1000.2642025496759m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1140.956054405m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1210.981654232684m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 985.5458854235054m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1244.737423301668m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 959.4045103796986m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 950.246795523752241m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 978.1140893573186m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1030.0952516421746m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1247.756132635307m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1192.446923313658m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 415,
                column: "Price",
                value: 1106.645844670721m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1228.433173394605m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1049.5305207774551m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1017.5533850856115m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1221.105819070285m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1071.130911396834m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 980.6039616066189m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1102.830712895977m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1076.515855560359m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1168.110026247908m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1291.972648783114m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1210.44538301966m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1135.134315040654m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1094.244725046878m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1249.7927150937m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1172.256066427443m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 955.93838577537011m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 970.1811300142578m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1030.6876430011496m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1213.545946158683m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1252.832662716432m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1166.020750799422m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1020.1411500694712m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1288.873606271093m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1000.0690558217934m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1124.212479802639m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 958.87846810158961m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1159.778343074466m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 994.4342905032467m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1210.906810722054m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1296.956526848651m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1015.7769349589078m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1249.51386592897m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 991.1635945959605m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1246.17570213602m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1041.5527766567196m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 999.6830291755739m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1218.814495543651m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1219.199104996449m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1109.252666009602m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 999.2650342506862m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1254.491488792222m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 951.97019359995346m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1172.259608583574m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1288.488725172443m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 978.2825235203815m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 963.2597661019739m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1293.137982548537m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1115.967411128875m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 464,
                column: "Price",
                value: 1180.836429188275m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1240.127005402125m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1101.941481802239m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1055.852034999841m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1136.912516172265m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1121.617642692899m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1201.850301799334m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1111.532377252356m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1029.4452018415652m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1022.0635977569303m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1044.8826992968141m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 967.7921814607676m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1157.356155985074m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1162.878994816274m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1070.972122873159m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1285.291113958114m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1076.914093980486m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 987.353315967575m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1180.174296512504m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1260.887115357866m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1192.498548664324m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1038.6760524436552m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1242.857324360002m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1038.744116709958m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1201.440703970618m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 957.54672723661098m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1132.627215011873m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1150.229136081574m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1104.656436752288m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1025.4179538206294m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1004.807329907904m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1180.256611186225m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1246.225474813353m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1159.242881174106m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1281.378625892435m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1047.656397597924m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1200.043155771302m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 975.0802509908472m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1108.262744151274m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1259.527111802798m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 504,
                column: "Price",
                value: 1237.13440250582m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1143.902073023298m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 955.37823938241614m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1260.461169635856m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 970.390432857836m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1027.5767666510818m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1278.548698529584m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1203.653946918447m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1144.100721805138m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1018.4946133999785m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1148.60707754861m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1000.6290641764697m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1032.4906416585781m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1007.9305827191656m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1109.591399633047m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1272.133964144648m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1060.991959636544m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 957.52084988749378m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 953.65706782134127m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 978.6661146895312m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1185.333046556513m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 525,
                column: "Price",
                value: 998.1102085083464m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1278.717137788683m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1157.613676044258m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 528,
                column: "Price",
                value: 1024.5755439505744m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1015.4420671475765m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 999.0693996145301m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 531,
                column: "Price",
                value: 1186.596522989188m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1025.7501944536872m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1218.965560616334m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1184.501315860721m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1063.770420456151m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1229.779811644706m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1133.843393089071m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 992.1496654493376m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1116.577886115371m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1197.256788439059m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 541,
                column: "Price",
                value: 1159.45874321794m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 542,
                column: "Price",
                value: 1025.8353570919696m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1223.426154187682m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1059.492089179237m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1295.743578479445m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1217.743835954554m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 999.7604354749945m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1150.310100510906m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1070.229240980259m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1031.6435698655042m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 551,
                column: "Price",
                value: 972.2287473174117m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1029.3206974962008m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 553,
                column: "Price",
                value: 1153.658903329748m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1029.3198327716524m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1203.467821722709m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1093.120140559109m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1100.987678590006m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1025.8027781666311m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1114.54291474942m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1201.44074544227m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1009.6138009068226m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1048.2346845911643m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1221.135753793223m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1029.3691080448586m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1136.75712798396m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1088.456826822727m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1076.1216647361m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1215.493740129014m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1275.00094948261m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1035.8137170679134m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1124.564750256045m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1149.490598917185m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 573,
                column: "Price",
                value: 1047.1473953150644m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1013.5544872826033m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1238.4153177338m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1266.15986966106m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 577,
                column: "Price",
                value: 1235.529002966585m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 954.61937148065499m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 976.0239951853334m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1200.807253369366m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1183.689392101947m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1041.3479597875271m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 992.9247140622487m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1266.686238200323m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1138.697742953343m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1170.168228844991m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 587,
                column: "Price",
                value: 1174.878174548921m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1266.337671102769m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1132.890725892931m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1223.945971203506m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1200.866102881764m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 592,
                column: "Price",
                value: 1027.874549952991m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1128.04683434049m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 594,
                column: "Price",
                value: 1266.966618884324m);

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7502462133453632352941176471m, 680, 1190.167425074847m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4069595822990202380952380952m, 840, 1181.846049131177m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5283620997395478723404255319m, 752, 1149.32829900414m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.729466067735314900153609831m, 651, 1125.88241009569m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5231494805716731034482758621m, 725, 1104.283373414463m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5950726482376262482168330956m, 701, 1118.145926414576m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3386822778878907242693773825m, 787, 1053.54295269777m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1395092588992644549763033175m, 1055, 1202.182268138724m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9837679676523588748787584869m, 1031, 1014.264774649582m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3689684352397517084282460137m, 878, 1201.954286140502m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9259686291278385650224215247m, 669, 1288.473012886524m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1537156240200284210526315789m, 950, 1096.029842819027m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0790519381121573361082206035m, 961, 1036.9689125257832m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9401022449118863287250384025m, 651, 1263.006561437638m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2073865348939663924794359577m, 851, 1027.4859411947654m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4844915531585018963337547408m, 791, 1174.232818548375m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1261469560476733333333333333m, 885, 996.6400561021909m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3227170619641375634517766497m, 788, 1042.3010448277404m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1749115387613406795224977043m, 1089, 1279.4786657111m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3037713795582910994764397906m, 955, 1245.101667478168m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7046060888636936339522546419m, 754, 1285.272991003225m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0579236691078656280428432327m, 1027, 1086.487608173778m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9829634479258845381526104418m, 996, 979.031594134181m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7297572692265182926829268293m, 656, 1134.720768612596m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1163257912889948927477017365m, 979, 1092.882949671926m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1687398629217632794457274827m, 866, 1012.128721290247m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5280085642346136680613668061m, 717, 1095.582140556218m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.42851181502775m, 764, 1091.383026681201m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6950454064892855245683930943m, 753, 1276.369191086432m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4171390628379011553273427471m, 779, 1103.951329950725m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2044611149038932146829810901m, 899, 1082.8105422986m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2805605278298242971887550201m, 996, 1275.438285718505m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4261504244067605673758865248m, 705, 1005.4360492067662m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5373200016585956072351421189m, 774, 1189.885681283753m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6553977305099087301587301587m, 756, 1251.480684265491m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.229343232042868335146898803m, 919, 1129.766430247396m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3045453878112003957783641161m, 758, 988.8454039608899m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6525559558664558011049723757m, 724, 1196.450512047314m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2208683598264039054470709147m, 973, 1187.904914111091m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5972751315895989159891598916m, 738, 1178.789047113124m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1603790706301666666666666667m, 972, 1127.888456652522m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2491226384004255139056831923m, 827, 1033.0244219571519m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0858963503042549212598425197m, 1016, 1103.270691909123m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1923452763332893347412882788m, 947, 1129.150976687625m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7587711865392640364188163885m, 659, 1159.030211929375m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2748098863930763124199743918m, 781, 995.6265212729926m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.289164242285458041958041958m, 858, 1106.102919880923m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9746808106228406337371854613m, 1073, 1045.832509798308m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2023841512346021818181818182m, 825, 991.9669247685468m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2503323972065346733668341709m, 995, 1244.080735220502m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0723410835281427264409881061m, 1093, 1172.06880429626m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2234688771688794023479188901m, 937, 1146.39033790724m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5793261942238440492476060192m, 731, 1154.48744797763m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0019809132691884146341463415m, 984, 985.9492186568814m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3419780516700010706638115632m, 934, 1253.407500259781m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8426581844043314037626628075m, 691, 1273.276805423393m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0873828164631629498861047836m, 878, 954.72211285465707m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4398778722565097014925373134m, 670, 964.7181744118615m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0285078118475110562685093781m, 1013, 1041.8784134015287m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0749913888670477975632614808m, 1067, 1147.01581192114m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2645154000730931263858093126m, 902, 1140.59289086593m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.492676252806636046511627907m, 860, 1283.701577413707m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0761690765749130734463276836m, 885, 952.40963276879807m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1488057341787158119658119658m, 936, 1075.282167191278m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8476548947479593373493975904m, 664, 1226.842850112645m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1817927558258104116222760291m, 826, 976.1608163121194m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1306440701253468992248062016m, 1032, 1166.824680369358m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0094214558126139705882352941m, 1088, 1098.250543924124m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9423532095637491324200913242m, 1095, 1031.8767644723053m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3131820189737241379310344828m, 870, 1142.46835650714m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4379243616946189903846153846m, 832, 1196.353068929923m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2089264020964608879492600423m, 946, 1143.644376383252m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1559495704486106442577030812m, 1071, 1238.021989950462m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5890797198440394922425952045m, 709, 1126.657521369424m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4223285170664142857142857143m, 910, 1294.318950530437m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8159765879627124277456647399m, 692, 1256.655798870197m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1833311538531881091617933723m, 1026, 1214.097763853371m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0647133175572607823470411234m, 997, 1061.519177604589m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1649256561239319664492078285m, 1073, 1249.965229020979m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3195812247847313253012048193m, 830, 1095.252416571327m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5784629470388038674033149171m, 724, 1142.807173656094m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0822473170386526775956284153m, 915, 990.2562950903672m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1474013484455936842105263158m, 950, 1090.031281023314m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1011276981703842315369261477m, 1002, 1103.329953566725m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1803299386741709053916581892m, 983, 1160.26432971671m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6900455461679116347569955817m, 679, 1147.540925848012m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3513050196814978902953586498m, 948, 1281.03715865806m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9907578398880697435897435897m, 975, 965.988893890868m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1530727539503540569020021075m, 949, 1094.266043498886m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.093707384017737384140061792m, 971, 1061.989869881223m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3280209292686554621848739496m, 833, 1106.24143408079m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0744438720324255102040816327m, 980, 1052.954994591777m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9304403724385096870342771982m, 671, 1295.32548990624m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4467919603482915862068965517m, 725, 1048.9241712525114m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2175400350032888480392156863m, 816, 993.5126685626837m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1747186414850338146811070999m, 831, 976.1911910740631m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1176796314768498168498168498m, 1092, 1220.50615757272m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3680245383363622508792497069m, 853, 1166.924931200917m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3842253247331793193717277487m, 764, 1057.548148096149m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2833736494976243093922651934m, 905, 1161.45315279535m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2382047810347572706935123043m, 894, 1106.955074245073m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4726822333879559748427672956m, 795, 1170.782375543425m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.389477638672001123595505618m, 890, 1236.635098418081m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6157026474051552706552706553m, 702, 1134.223258478419m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1136985182752485653560042508m, 941, 1047.9903056970089m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0094233441667272727272727273m, 979, 988.225453939226m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1470343763261012891344383057m, 1086, 1245.679332690146m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3526761376689583333333333333m, 936, 1266.104864858145m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3836852092024509594882729211m, 938, 1297.896726231899m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3129273354925037037037037037m, 810, 1063.471141748928m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5002696568209369942196531792m, 692, 1038.1866025200884m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2959911789295627659574468085m, 940, 1218.231708193789m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.33869756956014m, 850, 1137.892934126119m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3928186769678690869086908691m, 909, 1266.072177363793m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5820963753523328591749644381m, 703, 1112.21375187269m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1813849606172008196721311475m, 976, 1153.031721562388m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4302127694470558789289871944m, 859, 1228.552768955021m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.744313064668350067842605156m, 737, 1285.558728660574m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5662020065311513513513513514m, 666, 1043.0905363497468m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9763507516541764705882352941m, 1003, 979.279803909139m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4124901141350752453653217012m, 917, 1295.253434661864m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.693979639581296m, 750, 1270.484729685972m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2126253148383417861080485116m, 907, 1099.851160558376m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1397199321379584158415841584m, 1010, 1151.117131459338m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2935189136636644444444444444m, 810, 1047.7503200675682m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0188424564802008771929824561m, 1026, 1045.3323603486861m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1007942468730125130344108446m, 959, 1055.661682751219m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1686460768523614931237721022m, 1018, 1189.681706235704m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7818355665988942028985507246m, 690, 1229.466540953237m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9836000094351525354969574037m, 986, 969.8296093030604m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0668613681609239653512993263m, 1039, 1108.4689615192m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3183161191400455607476635514m, 856, 1128.478597983879m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6990786388937252311756935271m, 757, 1286.20252964255m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1024769865259987709497206704m, 895, 986.7169029407689m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1448428187366525096525096525m, 1036, 1186.057160211172m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5498005799287653061224489796m, 784, 1215.043654664152m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2621217660711510791366906475m, 834, 1052.60955290334m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5944526862677645466847090663m, 739, 1178.300535151878m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.423798505247048m, 725, 1032.2539163041098m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5845330612612757352941176471m, 816, 1292.978977989201m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.779090247197m, 691, 1229.351360813127m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2035783392074216163583252191m, 1027, 1236.074954366022m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1933818406555405660377358491m, 1060, 1264.984751094873m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3768497771240280970625798212m, 783, 1078.073375488114m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2757252365296162904808635918m, 1019, 1299.964016023679m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3287437488749015159944367177m, 719, 955.36675544105419m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1753744988394585426452410383m, 809, 950.877969561121961m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3541018340565990836197021764m, 873, 1182.130901131411m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0875069175521622364802933089m, 1091, 1186.470047049409m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1130012034191916279069767442m, 1075, 1196.476293675631m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0264924959071315151515151515m, 990, 1016.2275709480602m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "EuPerKm", "TripPrice" },
                values: new object[] { 1.2345938763638941048034934498m, 1130.887990749327m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2990069977819802469135802469m, 810, 1052.195668203404m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5999854081607676348547717842m, 723, 1156.789450100235m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1467750433440842639593908629m, 985, 1129.573417693923m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2752904112787361111111111111m, 864, 1101.850915344828m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3035786362022777777777777778m, 954, 1243.614018936973m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4884593699245095029239766082m, 684, 1018.1062090283645m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0881269165060970695970695971m, 1092, 1188.234592824658m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0949705518271994076999012833m, 1013, 1109.205169000953m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3353293279932074468085106383m, 940, 1255.209568313615m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2989373935840473300970873786m, 824, 1070.324412313255m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0009052237307781851512373969m, 1091, 1091.987599090279m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3023777179191334635416666667m, 768, 1000.2260873618945m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0077566826086188976377952756m, 1016, 1023.8807895303568m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7019894060583226666666666667m, 750, 1276.492054543742m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1491776292538152610441767068m, 996, 1144.5809187368m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1169063791601437435367114788m, 967, 1080.048468647859m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1143824539069917279411764706m, 1088, 1212.448109850807m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.633776788478767277856135402m, 709, 1158.347743031446m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5602069572684930769230769231m, 650, 1014.1345222245205m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3287874750696037711313394018m, 769, 1021.8375683285253m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1669683224523485600794438928m, 1007, 1175.137100709515m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.351495292145297275204359673m, 734, 991.9975444346482m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3479013337096126436781609195m, 870, 1172.674160327363m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1264230233736756154747948417m, 853, 960.8388389377453m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2141266530822375145180023229m, 861, 1045.3630483038065m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4024587324534161073825503356m, 894, 1253.798106813354m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4076149920869036860879904875m, 841, 1183.804208345086m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3137029249243371974522292994m, 785, 1031.2567960656047m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2482772924205355029585798817m, 1014, 1265.753174514423m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9623753526362530947775628627m, 1034, 995.0961146258857m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3309324311159357734806629834m, 724, 963.5950801279375m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1447174689392324902723735409m, 1028, 1176.769558069531m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.243977349539538830297219559m, 1043, 1297.468375569739m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1820179520195397987191216834m, 1093, 1291.945621557357m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6914221119649710526315789474m, 760, 1285.480805093378m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1913054540619418145956607495m, 1014, 1207.983730418809m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.228580557902594515181194907m, 1021, 1254.380749618549m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1164878653989024154589371981m, 1035, 1155.564940687864m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.200096116078009771986970684m, 921, 1105.288522907847m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4127621162000687772925764192m, 916, 1294.090098439263m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4180666319818134228187919463m, 745, 1056.459640826451m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4027908928065569941348973607m, 682, 956.70338889407187m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.121381623447006304347826087m, 920, 1031.6710935712458m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7656434983435895316804407713m, 726, 1281.857179797446m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4758583329522839160839160839m, 715, 1055.238708060883m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3813906060839843342036553525m, 766, 1058.145204260332m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2582225907071801385681293303m, 866, 1089.620763552418m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3314258452965909592061742007m, 907, 1207.603241684008m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3586390246839911392405063291m, 790, 1073.324829500353m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4432323356452771260997067449m, 682, 984.284452910079m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7086040625137458893871449925m, 669, 1143.056117821696m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2978352102946887816646562123m, 829, 1075.905389334297m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3062566874520151324085750315m, 793, 1035.861553149448m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3079887183186172972972972973m, 925, 1209.889564444721m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4882095820703419400855920114m, 701, 1043.2349170313097m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5316459471922299528301886792m, 848, 1298.835763219011m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6217899563633975903614457831m, 664, 1076.868531025296m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7048476063816337047353760446m, 718, 1224.080581382013m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4207328797073360107095046854m, 747, 1061.28746114138m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8833090601130398162327718224m, 653, 1229.800816253815m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1815693599821573255813953488m, 860, 1016.1496495846553m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4278491084147178807947019868m, 755, 1078.026076853112m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2473845113400886699507389163m, 1015, 1266.09527901019m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1957278539664890162368672397m, 1047, 1251.927063102914m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1940433522186167778836987607m, 1049, 1252.551476477329m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4233784350426890459363957597m, 849, 1208.448291351243m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2339726869402009950248756219m, 1005, 1240.142550374902m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5911563986847266387726638773m, 717, 1140.859137856949m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6372818037489049429657794677m, 789, 1291.815343157886m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4034040604527555555555555556m, 747, 1048.3428331582084m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6484358711894291390728476821m, 755, 1244.569082748019m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1061225323229790870488322718m, 942, 1041.9674254482463m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1892626206541152614727854856m, 937, 1114.339075552906m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4670507986900712669683257919m, 884, 1296.872906042023m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9034444650334656192236598891m, 1082, 977.5269111662098m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1527970843648103607770582794m, 1081, 1246.17364819836m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6672056669597380607814761216m, 691, 1152.039115869179m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9971508622561303142329020333m, 1082, 1078.917232961133m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6949358367746860643185298622m, 653, 1106.79310141387m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5876107021426723891273247496m, 699, 1109.739880797728m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4274505468942761692650334076m, 898, 1281.85059111106m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0562952065165358555555555556m, 900, 950.66568586488227m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1469434083756276824034334764m, 932, 1068.951256606085m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3982266268512486171761280932m, 687, 960.5816926468078m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5524781867278846153846153846m, 754, 1170.568552792825m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2556727272266914893617021277m, 1034, 1298.365599952399m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2053557560293110859728506787m, 884, 1065.534488329911m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6059221630425418326693227092m, 753, 1209.259388771034m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0437243310070192837465564738m, 1089, 1136.615796466644m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4574560070805486842105263158m, 684, 996.8999088430953m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0808914882207132936507936508m, 1008, 1089.538620126479m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.136152805837350109409190372m, 914, 1038.443664535338m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5134109012650025348542458809m, 789, 1194.081201098087m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0934575153975803156917363045m, 1077, 1177.653744083194m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2691983745209721627408993576m, 934, 1185.431281802588m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2093915650985559006211180124m, 966, 1168.272251885205m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2263669971107020408163265306m, 833, 1021.5637085932148m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1646070867048330132052821128m, 833, 970.1177032251259m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4207261197344036363636363636m, 825, 1172.099048780883m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.360808302797385974025974026m, 770, 1047.8223931539872m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0850308078659900677200902935m, 886, 961.3372957692672m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4475031962523673708920187793m, 852, 1233.272723207017m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.414032069934259946949602122m, 754, 1066.180180730432m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6953024487380624169986719788m, 753, 1276.562743899761m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6718417460420575539568345324m, 695, 1161.93001349923m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.239475544024815595363540569m, 949, 1176.26229127955m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4490217318931149144254278729m, 818, 1185.299776688568m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1478598239736688867745004757m, 1051, 1206.400674996326m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.419138972769931077694235589m, 798, 1132.472900270405m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.364308268446250814332247557m, 921, 1256.527915238997m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2901143381553085460599334073m, 901, 1162.393018677933m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1616503310221633802816901408m, 1065, 1237.157602538604m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3490823966868390297684674752m, 907, 1223.617733794963m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3446691451151336842105263158m, 950, 1277.435687859377m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3098953111534722550177095632m, 847, 1109.481328546991m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4047464788891940874035989717m, 778, 1092.892760575793m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1401913219447135470527404343m, 967, 1102.565008320538m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0801087769597855447680690399m, 927, 1001.2608362417212m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0105226621965118831030818278m, 941, 950.901825126917682m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9890090826938642648490749757m, 1027, 1015.7123279265986m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0061817214639111721611721612m, 1092, 1098.750439838591m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9743063564210383211678832117m, 1096, 1067.839766637458m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1846962085527919908466819222m, 874, 1035.4244862751402m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0462341233484532467532467532m, 924, 966.7203299739708m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3192761687006451282051282051m, 975, 1286.294264483129m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4637320258252876595744680851m, 705, 1031.9310782068278m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.74895717862868m, 650, 1136.822166108642m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2479933502548345873786407767m, 824, 1028.3465206099837m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9466921130312329925650557621m, 1076, 1018.6407136216067m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3222708952774535637149028078m, 926, 1224.422849026922m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3235531900074664112388250319m, 783, 1036.3421477758462m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1293563961679509893992932862m, 849, 958.82358034659039m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3644727049601103448275862069m, 870, 1187.091253315296m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2293258889288592283628779979m, 959, 1178.923527482776m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4555775558961346153846153846m, 728, 1059.660460692386m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4122703568684605087014725569m, 747, 1054.96595658074m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7088568947890497237569060773m, 724, 1237.212391827272m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5593844926600700305810397554m, 654, 1019.8374581996858m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1880130508666270161290322581m, 992, 1178.508946459694m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2424084952779609810479375697m, 897, 1114.440420264331m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4656278408029944444444444444m, 720, 1055.252045378156m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6736409855478620199146514936m, 703, 1176.569612840147m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1363911228397711627906976744m, 1075, 1221.620457052754m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4640794397028348868175765646m, 751, 1099.523659216829m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0418667928741070075757575758m, 1056, 1100.211333275057m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5212724843352804878048780488m, 738, 1122.699093439437m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5688264080694m, 664, 1041.7007349580816m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3965658792357752525252525253m, 792, 1106.080176354734m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0222878464486764112903225806m, 992, 1014.109543677087m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3051990926325492481203007519m, 798, 1041.5488759207743m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2386209771581912364945978391m, 833, 1031.7712739727733m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2591200918017530054644808743m, 915, 1152.094883998604m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3400146013157655860349127182m, 802, 1074.691710255244m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1242052011338167730173199635m, 1097, 1233.253105643797m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1132418238960388655462184874m, 952, 1059.806216349029m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1820148942361627384960718294m, 891, 1053.175270764421m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.036608648356852165725047081m, 1062, 1100.878384554977m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1784775401049571428571428571m, 819, 965.1731053459599m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4208677243813510158013544018m, 886, 1258.888803801877m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1289142180704273255813953488m, 1032, 1165.039473048681m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.519745074123027027027027027m, 703, 1068.380787108488m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4613426615645766816143497758m, 669, 977.6382405867018m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6473233616206178247734138973m, 662, 1090.528065392849m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.881549248926466467958271237m, 671, 1262.519546029659m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9883830287651204225352112676m, 994, 982.4527305925297m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4475658298310217917675544794m, 826, 1195.689375440424m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6570186834736276150627615063m, 717, 1188.082396050591m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2260476657622673170731707317m, 820, 1005.3590859250592m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6299548911471705882352941176m, 680, 1108.369325980076m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6623581957986123076923076923m, 650, 1080.532827269098m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.246759755011907109375m, 768, 957.51149184914466m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.188759724481137701804368471m, 1053, 1251.763989878638m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0772967616640069033530571992m, 1014, 1092.378916327303m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4705530557429793103448275862m, 725, 1066.15096541366m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4633425490719398084815321477m, 731, 1069.703403371588m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3870019421274535017221584386m, 871, 1208.078691593012m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0119647820608077630234933606m, 979, 990.7135216375308m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1571487179095682041216879293m, 1019, 1179.13454354985m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8391434627585459940652818991m, 674, 1239.58269389926m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3366059360556575829383886256m, 844, 1128.095410030975m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.32257098068603125m, 896, 1185.023598694684m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.365299618525883843717001056m, 947, 1292.938738744012m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0459575754434095330739299611m, 1028, 1075.244387555825m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3250653841115676923076923077m, 780, 1033.5509996070228m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2482887292583566750629722922m, 794, 991.1412510311352m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3728104189914880920162381597m, 739, 1014.5068996347097m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1461910085901570482497634816m, 1057, 1211.523896079796m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1140243392387033985581874356m, 971, 1081.717633400781m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1609289488349536423841059603m, 906, 1051.801627644468m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2085448605025778275475923852m, 893, 1079.230560428802m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4368870901665279017857142857m, 896, 1287.450832789209m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9925003754864558270676691729m, 1064, 1056.020399517589m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5056244619100906515580736544m, 706, 1062.970870108524m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4184375034730717647058823529m, 850, 1205.671877952111m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3821284842933420365535248042m, 766, 1058.7104189687m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9593378835758999597180261833m, 993, 952.62251839086866m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4295743852071179624664879357m, 746, 1066.46249136451m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9600520626347149568552253116m, 1043, 1001.3343013280077m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1685001154691967351874244256m, 827, 966.3495954930257m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3006450107550348204570184984m, 919, 1195.292764883877m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.211569616853779324055666004m, 1006, 1218.839034554902m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6971658430808639455782312925m, 735, 1247.416894664435m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.502094722961522108345534407m, 683, 1025.9306957827196m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0429842670317770767613038906m, 951, 991.87803794722m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3522354963688645962732919255m, 805, 1088.549574576936m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9752470041685044865403788634m, 1003, 978.17274518101m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3652126521270370786516853933m, 890, 1215.039260393063m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2148366363780548604427333975m, 1039, 1262.215265196799m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1427618579687057745187901008m, 1091, 1246.753187043858m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2520007557286967901234567901m, 810, 1014.1206121402444m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2029466142383751425313568985m, 877, 1054.984180687055m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.242221717065299792531120332m, 964, 1197.501735250949m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.934438076167630119375573921m, 1089, 1017.6030649465492m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0937439574354099616858237548m, 1044, 1141.868691562568m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1818646584057561728395061728m, 972, 1148.772447970395m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5905712054119931693989071038m, 732, 1164.298122361579m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8942696997881855690298507463m, 1072, 958.65711817293493m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.476760426592149112426035503m, 845, 1247.862560470366m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2595816778561451127819548872m, 798, 1005.1461789292038m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.311648185486998914223669924m, 921, 1208.027978833526m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3441077860991039290240811153m, 789, 1060.501043232193m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0821280671711280373831775701m, 1070, 1157.877031873107m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6587200720390266106442577031m, 714, 1184.326131435865m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2460219011092815964523281596m, 902, 1123.911754800572m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3098861387303859844271412681m, 899, 1177.587638718617m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8663491235266343283582089552m, 670, 1250.453912762845m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.205312841443981243830207305m, 1013, 1220.981908382753m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4222071230201243124312431243m, 909, 1292.786274825293m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.100163860981436734693877551m, 931, 1024.2525545737176m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3081055719519621451104100946m, 951, 1244.008398926316m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5650149118307566585956416465m, 826, 1292.702317172205m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4587133793353027166882276843m, 773, 1127.585442226189m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2287882202877867730900798176m, 877, 1077.647269192389m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2159182529834193155893536122m, 789, 959.35950160391784m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3451483662744067039106145251m, 895, 1203.907787815594m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0927725631783850393700787402m, 889, 971.4748086655843m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3955269982891917647058823529m, 850, 1186.197948545813m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0015757157653514860977948226m, 1043, 1044.6434715432616m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0811763139376089422028353326m, 917, 991.4386798807874m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6780312690593937125748502994m, 668, 1120.924887731675m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1421598639203071350164654226m, 911, 1040.5076360313998m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3790458022205266015200868621m, 921, 1270.101183845105m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4163288079474224719101123596m, 890, 1260.532639073206m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.477559244089962962962962963m, 756, 1117.034788532012m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0732309060033897824030274361m, 1057, 1134.405067645583m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1706664816602283464566929134m, 1016, 1189.397145366792m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8505990516960437405731523379m, 663, 1226.947171274477m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1970772917405450231481481481m, 864, 1034.2747800638309m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2163476616964318787878787879m, 825, 1003.4868208995563m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0403113740313904095904095904m, 1001, 1041.3516854054218m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3295781802787200902934537246m, 886, 1178.006267726946m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0686583360573460470085470085m, 936, 1000.2642025496759m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4155782312717121588089330025m, 806, 1140.956054405m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3823991486674474885844748858m, 876, 1210.981654232684m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3959573447925005665722379603m, 706, 985.5458854235054m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3185777789212584745762711864m, 944, 1244.737423301668m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9008493055208437558685446009m, 1065, 959.4045103796986m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0859963377414311325714285714m, 875, 950.246795523752241m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4910275752398149390243902439m, 656, 978.1140893573186m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9736250015521499054820415879m, 1058, 1030.0952516421746m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3460152455612804746494066882m, 927, 1247.756132635307m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1972358667807811244979919679m, 996, 1192.446923313658m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1144469734851168177240684794m, 993, 1106.645844670721m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8697612989263394216133942161m, 657, 1228.433173394605m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2925252718934176108374384236m, 812, 1049.5305207774551m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.985046839385877541142303969m, 1033, 1017.5533850856115m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.260171123911542827657378741m, 969, 1221.105819070285m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2527846916922035087719298246m, 855, 1071.130911396834m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9905090521278978787878787879m, 990, 980.6039616066189m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4743726108234986631016042781m, 748, 1102.830712895977m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1701259299569119565217391304m, 920, 1076.515855560359m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5936016729166548431105047749m, 733, 1168.110026247908m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1755893073549717925386715196m, 1099, 1291.972648783114m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4583679313489879518072289157m, 830, 1210.44538301966m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2501479240535837004405286344m, 908, 1135.134315040654m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6356423393824783258594917788m, 669, 1094.244725046878m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3267438589105095541401273885m, 942, 1249.7927150937m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3905765912543807829181494662m, 843, 1172.256066427443m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9069624153466509582542694497m, 1054, 955.93838577537011m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9222254087588001901140684411m, 1052, 970.1811300142578m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3230906842120020539152759949m, 779, 1030.6876430011496m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1299310485648817504655493482m, 1074, 1213.545946158683m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3588206753974316702819956616m, 922, 1252.832662716432m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4891708183900664112388250319m, 783, 1166.020750799422m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.365650803305851673360107095m, 747, 1020.1411500694712m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3397854535042546777546777547m, 962, 1288.873606271093m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1099545569609249722530521643m, 901, 1000.0690558217934m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2575083666696185682326621924m, 894, 1124.212479802639m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8813221214169022150735294118m, 1088, 958.87846810158961m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.113031039418873320537428023m, 1042, 1159.778343074466m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0358690526075486458333333333m, 960, 994.4342905032467m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1848403236027925636007827789m, 1022, 1210.906810722054m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5045899383395023201856148492m, 862, 1296.956526848651m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9910018877647880975609756098m, 1025, 1015.7769349589078m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7282349459598478561549100968m, 723, 1249.51386592897m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.141893542161244815668202765m, 868, 991.1635945959605m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7626247554964922206506364922m, 707, 1246.17570213602m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5453305291642724035608308605m, 674, 1041.5527766567196m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0128500802184132725430597771m, 987, 999.6830291755739m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.819126112751717910447761194m, 670, 1218.814495543651m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1871461587112453748782862707m, 1027, 1219.199104996449m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.320538888106669047619047619m, 840, 1109.252666009602m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0756351283645707212055974166m, 929, 999.2650342506862m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8287047941577580174927113703m, 686, 1254.491488792222m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2283486369031657548387096774m, 775, 951.97019359995346m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1381161248384213592233009709m, 1030, 1172.259608583574m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8071370619529354838709677419m, 713, 1288.488725172443m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1322714392597008101851851852m, 864, 978.2825235203815m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.07506670323881015625m, 896, 963.2597661019739m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9592999735583893939393939394m, 660, 1293.137982548537m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0154389546213603275705186533m, 1099, 1115.967411128875m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0863260618107405703771849126m, 1087, 1180.836429188275m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6447307763953912466843501326m, 754, 1240.127005402125m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1336846520599166666666666667m, 972, 1101.941481802239m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0065319685413164918970448046m, 1049, 1055.852034999841m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3486506716159727164887307236m, 843, 1136.912516172265m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0805564958505770712909441233m, 1038, 1121.617642692899m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7545259880282248175182481752m, 685, 1201.850301799334m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.148277249227640495867768595m, 968, 1111.532377252356m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0547594281163577868852459016m, 976, 1029.4452018415652m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4517948831774578125m, 704, 1022.0635977569303m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1419483052424197814207650273m, 915, 1044.8826992968141m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1253397458846134883720930233m, 860, 967.7921814607676m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0959812083191988636363636364m, 1056, 1157.356155985074m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3139875647641514124293785311m, 885, 1162.878994816274m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2170137759922261363636363636m, 880, 1070.972122873159m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5301084689977547619047619048m, 840, 1285.291113958114m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3344660396288550185873605948m, 807, 1076.914093980486m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0982795505757230255839822024m, 899, 987.353315967575m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.76937675639056071964017991m, 667, 1180.174296512504m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8326847606945726744186046512m, 688, 1260.887115357866m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1281916259832771996215704825m, 1057, 1192.498548664324m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3613054422590500655307994758m, 763, 1038.6760524436552m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2441014257857877877877877878m, 999, 1242.857324360002m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2776680402336506765067650677m, 813, 1038.744116709958m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2822206018896670224119530416m, 937, 1201.440703970618m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0408116600397945434782608696m, 920, 957.54672723661098m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.457692683412963963963963964m, 777, 1132.627215011873m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0729749403746026119402985075m, 1072, 1150.229136081574m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3455011409893885505481120585m, 821, 1104.656436752288m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.166573326303332650739476678m, 879, 1025.4179538206294m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0369528688420061919504643963m, 969, 1004.807329907904m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4288820958671004842615012107m, 826, 1180.256611186225m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5197871644065280487804878049m, 820, 1246.225474813353m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6100595571862583333333333333m, 720, 1159.242881174106m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1986703703390411599625818522m, 1069, 1281.378625892435m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.457102082890019471488178025m, 719, 1047.656397597924m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.115281743281879182156133829m, 1076, 1200.043155771302m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3266397972664587755102040816m, 735, 975.0802509908472m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2286726653561796008869179601m, 902, 1108.262744151274m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4041550856218483835005574136m, 897, 1259.527111802798m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3822730754254972067039106145m, 895, 1237.13440250582m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4798215692410064683053040103m, 773, 1143.902073023298m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0603532068617271254162042175m, 901, 955.37823938241614m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6412254812966875m, 768, 1260.461169635856m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.035635467297583778014941302m, 937, 970.390432857836m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2262252585335105011933174224m, 838, 1027.5767666510818m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2849735663613909547738693467m, 995, 1278.548698529584m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4933671797995620347394540943m, 806, 1203.653946918447m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.485845093253425974025974026m, 770, 1144.100721805138m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1266533334070558628318584071m, 904, 1018.4946133999785m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.123881680575939334637964775m, 1022, 1148.60707754861m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1785972487355355712603062426m, 849, 1000.6290641764697m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3877562387884114247311827957m, 744, 1032.4906416585781m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.001919068309309741550695825m, 1006, 1007.9305827191656m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6536384495276408345752608048m, 671, 1109.591399633047m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3918314706177768052516411379m, 914, 1272.133964144648m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9716043586415238095238095238m, 1092, 1060.991959636544m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9489800296209056293359762141m, 1009, 957.52084988749378m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9196307307823927386692381871m, 1037, 953.65706782134127m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.047822392601211134903640257m, 934, 978.6661146895312m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6440125472351081830790568655m, 721, 1185.333046556513m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.132928727024229738933030647m, 881, 998.1102085083464m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6847393119745494071146245059m, 759, 1278.717137788683m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6680312334931671469740634006m, 694, 1157.613676044258m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9899280617879945893719806763m, 1035, 1024.5755439505744m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1486901212076657239819004525m, 884, 1015.4420671475765m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0505461615294743427970557308m, 951, 999.0693996145301m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4541624056240049019607843137m, 816, 1186.596522989188m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0350657865324795156407669021m, 991, 1025.7501944536872m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1653590445662848948374760994m, 1046, 1218.965560616334m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1195664611159933837429111531m, 1058, 1184.501315860721m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2115836223874157175398633257m, 878, 1063.770420456151m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6800270650883961748633879781m, 732, 1229.779811644706m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6408732172056020260492040521m, 691, 1133.843393089071m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0622587424511109207708779443m, 934, 992.1496654493376m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7046990627715587786259541985m, 655, 1116.577886115371m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8003861480286601503759398496m, 665, 1197.256788439059m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3086441797042212189616252822m, 886, 1159.45874321794m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2419314250508106537530266344m, 826, 1025.8353570919696m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.752759533220174785100286533m, 698, 1223.426154187682m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1429256625450237324703344121m, 927, 1059.492089179237m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9339456395215597014925373134m, 670, 1295.743578479445m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1938665058377980392156862745m, 1020, 1217.743835954554m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2089001638149873035066505441m, 827, 999.7604354749945m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6866717016288944281524926686m, 682, 1150.310100510906m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0513057377016296660117878193m, 1018, 1070.229240980259m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4308509984264968099861303745m, 721, 1031.6435698655042m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0923918509184401123595505618m, 890, 972.2287473174117m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1657086041859578708946772367m, 883, 1029.3206974962008m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4069011016216439024390243902m, 820, 1153.658903329748m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3247359495130661518661518662m, 777, 1029.3198327716524m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3431560510298091517857142857m, 896, 1203.467821722709m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3462070696540751231527093596m, 812, 1093.120140559109m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.369387659937818407960199005m, 804, 1100.987678590006m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1777299404898175660160734788m, 871, 1025.8027781666311m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4781736269886206896551724138m, 754, 1114.54291474942m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2620175897502836134453781513m, 952, 1201.44074544227m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1280601127450531843575418994m, 895, 1009.6138009068226m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3684525908500839425587467363m, 766, 1048.2346845911643m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4133515668903043981481481481m, 864, 1221.135753793223m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1262244070512676148796498906m, 914, 1029.3691080448586m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0846919160152290076335877863m, 1048, 1136.75712798396m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9940244993814858447488584475m, 1095, 1088.456826822727m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.007604554996348314606741573m, 1068, 1076.1216647361m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4644502893120650602409638554m, 830, 1215.493740129014m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2865801710218062563067608476m, 991, 1275.00094948261m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.972595039500388169014084507m, 1065, 1035.8137170679134m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3781430762941727941176470588m, 816, 1124.564750256045m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1437717402161044776119402985m, 1005, 1149.490598917185m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4853154543476090780141843972m, 705, 1047.1473953150644m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9315758155170986213235294118m, 1088, 1013.5544872826033m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1573974932091588785046728972m, 1070, 1238.4153177338m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7488395989793646408839779006m, 724, 1266.15986966106m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1891520721526323387872954764m, 1039, 1235.529002966585m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0467317669744024013157894737m, 912, 954.61937148065499m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0597437515584510314875135722m, 921, 976.0239951853334m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3401866667068816964285714286m, 896, 1200.807253369366m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3196091327780903010033444816m, 897, 1183.689392101947m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0961557471447653684210526316m, 950, 1041.3479597875271m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0353750928699152241918665276m, 959, 992.9247140622487m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9427703039882254601226993865m, 652, 1266.686238200323m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2984010752033557582668187001m, 877, 1138.697742953343m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1155083211105729265967588179m, 1049, 1170.168228844991m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.260598899730601931330472103m, 932, 1174.878174548921m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4845693682330234466588511137m, 853, 1266.337671102769m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5583091140205378266850068776m, 727, 1132.890725892931m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6020235225176780104712041885m, 764, 1223.945971203506m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3724184032934445714285714286m, 875, 1200.866102881764m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1209100871897393675027262814m, 917, 1027.874549952991m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4901543386268031704095112285m, 757, 1128.04683434049m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4715059452779605110336817654m, 861, 1266.966618884324m });

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));
        }
    }
}
