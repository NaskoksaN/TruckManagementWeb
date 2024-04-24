using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class ClientEmailInSoldOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "SoldsOrders",
                type: "decimal(18,2)",
                nullable: false,
                comment: "Price of the load",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "price of the load");

            migrationBuilder.AddColumn<string>(
                name: "ClientEmail",
                table: "SoldsOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Client e-mail");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "7d4e5133-d626-40df-b246-b1d339e28487");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dispatcherRoleId",
                column: "ConcurrencyStamp",
                value: "9303c3df-922a-4ace-ab28-ce58fd910d1b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "managerRoleId",
                column: "ConcurrencyStamp",
                value: "1df10bcb-53f4-4f34-a7b4-859e9d14e017");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0261d5ca-050a-423e-90cb-c7e990f67959",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdd68a20-5d95-4329-8c39-2e48d163b15d", "AQAAAAEAACcQAAAAEEfh6iPneDJjtiwcQyRgLTJEk7+jWJuXe6F2+up1rLO/7K4rMNJSuABtgRJFdclQCQ==", "b5554bd9-943e-4a7a-bb02-73037734be05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19918df1-9468-434b-aaf9-a3d22b2d12e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fa16cbb-b3c4-4db8-b38f-2dee81226e5a", "AQAAAAEAACcQAAAAEP6jbnfss5R77M9l9aUbxhJ0WyGpsXBC/jUmqR/Z0BAEwmmKTxkw5xYgy+e5GQ9A8g==", "dca04673-8a50-4b3e-a96f-91d7d2272cab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62154153-66df-4b35-91ed-56ac983c9a8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e9d0a75-cffe-43e3-b916-6e2e1aac0062", "AQAAAAEAACcQAAAAEPNc7g2GDzol3SgZSBnj3zVOlq1EW0lc+QlhUe+75bF/obSchX54lA+X910KNc4pvg==", "9cd8534f-ffaa-46fa-99f1-63b97d4c0a51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1a37646-0b9d-452f-a369-4b52f6c8f1fd", "AQAAAAEAACcQAAAAEAzZSJOMQlh3LAGyBLKikPOXsnnP0BrO/BFFse0KqZfd/WmFaW75cfRvJLfD+qL3sw==", "904b4e5f-2778-4a55-969e-f3eb162ec8ec" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1248.086184077274m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 1130.866458747221m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1191.524222627233m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 1240.320641594456m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1014.4598658913175m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1274.740376373307m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1139.260902355336m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1145.412106519521m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 1004.9687436539508m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 970.3855138380495m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1207.279631104093m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 969.8362152616859m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1019.6508555988848m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1107.646498723362m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1265.880636536095m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1142.331588011948m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1013.4009570103473m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1145.189507477669m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1077.527815117387m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1229.184402655109m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1292.990281624873m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1235.915081459003m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1237.655013051044m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1186.75406937294m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1006.5307684264284m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1195.056163251872m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                column: "Price",
                value: 1067.92847960165m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1298.528290525364m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1274.378957506761m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1212.933294326281m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1299.668486784452m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1140.115705579478m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1261.787046883548m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1238.196835439065m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1178.125522982472m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1075.60974360233m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1123.219216954588m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38,
                column: "Price",
                value: 1044.2364319925397m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1056.957706558417m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1177.153889610219m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1005.4608569066504m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1232.125156960981m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1054.010711638127m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44,
                column: "Price",
                value: 989.4957877614224m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1256.158812157842m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1073.429095494807m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1027.1319807731444m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1123.280113909845m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1212.859841947972m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1004.4509426536658m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1209.633385481717m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1241.626646542895m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 53,
                column: "Price",
                value: 1261.871683426808m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 990.2270418068428m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1259.060756224537m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1224.442451698663m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1223.842449096465m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1061.346957381805m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 953.46123965132099m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1128.494926937656m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 61,
                column: "Price",
                value: 1180.370538071074m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1080.970073003078m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1074.633849991416m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1110.322390029819m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1139.298109002005m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1260.802122927769m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 979.6173894308837m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1152.689717133757m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1195.501856660066m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 986.8552252856589m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1181.581287621101m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1138.359079658395m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1024.7933253563319m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1128.84861648687m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1068.195032003539m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 76,
                column: "Price",
                value: 1149.467589694661m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1064.623881885423m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1098.966774468147m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1072.55873256906m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 987.1324968186412m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1298.181008735599m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1119.761105952648m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1009.2425343388855m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1246.223914242729m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1068.410525278144m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1141.186859500121m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1115.943677827956m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1158.941910090262m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 89,
                column: "Price",
                value: 1224.69472704827m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1220.920695890404m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1028.9198072232579m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1034.5457841458061m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1198.378874923482m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1296.885832854204m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1066.549618870985m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1027.453124400148m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 97,
                column: "Price",
                value: 1078.817723602357m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1271.108596097944m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1004.6765177554021m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1053.064382807327m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1052.681771337166m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1208.669664602883m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1165.961209756114m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1130.313355780633m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 951.40473988824215m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1002.4762300022097m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1278.018221603464m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 108,
                column: "Price",
                value: 1277.391177257473m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 109,
                column: "Price",
                value: 1021.698017935427m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 968.576002034877m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 111,
                column: "Price",
                value: 1244.5860679514m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1198.185498297128m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1187.627958424894m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1181.897007810678m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 115,
                column: "Price",
                value: 1103.987497305398m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1016.970185433885m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1079.915767833043m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1072.147361404669m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1006.1640763430248m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1174.54874402645m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 121,
                column: "Price",
                value: 1027.8780093189954m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1013.7650047221196m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1238.082199499538m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1273.192009272197m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1284.523565914276m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 126,
                column: "Price",
                value: 1195.143569211265m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 964.4383405550097m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1067.693578881369m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1280.715462168565m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 130,
                column: "Price",
                value: 989.8745252734258m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 131,
                column: "Price",
                value: 1028.4218054821972m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1242.030093321456m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1158.863400434083m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1109.421283594224m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1293.929276332765m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 976.324210730387m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1045.9861114525821m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1279.871191853086m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1102.812881464132m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1002.6642760556865m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1268.717411213808m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1251.972590965253m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1230.026416691553m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1002.7392504672491m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1197.971717603178m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1095.848806229371m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1146.665801987596m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1018.6406059152586m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1235.60987873436m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1233.494612182433m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 151,
                column: "Price",
                value: 1275.177066194769m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 152,
                column: "Price",
                value: 1192.566495960288m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1267.967441524656m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1017.0302599381067m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1006.5368115429885m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1200.926796948186m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1011.0014465766046m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1065.00200647681m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1164.830223123547m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1245.570514534182m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1102.866070937846m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1234.340420925286m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1170.608781888078m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1019.3200585691992m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1120.187252899591m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1218.12267955196m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1221.383298502336m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1294.912859633244m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 169,
                column: "Price",
                value: 1098.594124296074m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1053.782798311175m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 171,
                column: "Price",
                value: 1121.914558132007m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1156.778923469452m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1070.494797777054m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1063.002994658484m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1281.814829506799m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1253.375559501549m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1123.150522595251m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1013.0523174045482m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 179,
                column: "Price",
                value: 1071.540142549587m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 180,
                column: "Price",
                value: 1098.135176423701m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 181,
                column: "Price",
                value: 1074.821358680809m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1268.65529726551m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 183,
                column: "Price",
                value: 1275.471579005395m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1073.951626749052m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1059.292397908268m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1087.653053383711m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 984.4193678752373m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1121.288156879357m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1287.470610217119m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1151.187741147936m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1201.01545826749m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1177.589536470684m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1050.170466429001m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1237.311383815156m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1123.381985552787m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1291.842831169269m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1263.423993492204m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1167.799086456557m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1191.936937850226m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1117.354868061729m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1250.616859502278m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1217.573628275613m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1067.527858237545m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 204,
                column: "Price",
                value: 1075.289708229665m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1260.852794678266m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1132.417549347579m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1273.959302128084m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1085.744957337902m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1063.498987415134m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1271.414846936951m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1102.44541184861m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1083.680494069928m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1162.318166150306m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1008.7417767409981m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1249.765099867404m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1288.402602772487m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1149.775328578172m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 980.5438220861538m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1203.056829279022m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1165.830058832278m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1190.880732996943m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1216.055427357574m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1200.934642082621m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1165.911958118885m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1012.747172267183m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 993.6448992337094m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 972.7723409941524m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1076.446274869648m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1237.797200943412m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1292.542823228286m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1159.823778684128m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1256.013852541204m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1271.292796709612m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1131.1838332035m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 235,
                column: "Price",
                value: 1121.89972003923m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 236,
                column: "Price",
                value: 1004.3377522410028m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1038.9783397980295m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 238,
                column: "Price",
                value: 1051.236320746732m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1269.234228286284m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 240,
                column: "Price",
                value: 1183.103556027105m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1042.9264858809535m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1171.35549068665m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1085.148854259621m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1289.600329575527m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1000.5987502135233m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1137.793469527395m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1165.865840822675m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 248,
                column: "Price",
                value: 1067.962279592895m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1150.748571726917m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 250,
                column: "Price",
                value: 1179.974562587262m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1068.655944554354m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 974.3179280292271m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1152.355248076219m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1132.586218498569m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1273.4845131138m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1000.1580333554877m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1058.868592228104m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 971.2842223810855m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1241.666933698877m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1230.982040703907m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1285.159645655187m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1048.2020390759419m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1039.4014975419217m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1168.264337507284m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1217.240087847015m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 958.26958873934832m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1150.410748745723m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1222.793973974197m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 951.88878590978049m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 958.28754127042517m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 271,
                column: "Price",
                value: 1038.9596638760106m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1198.548426165374m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 273,
                column: "Price",
                value: 1143.43535999657m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1078.175476768725m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1223.035496195621m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1131.250510728826m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1224.768391724127m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1272.640515531974m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 279,
                column: "Price",
                value: 1156.8157793731m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1188.94083862931m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1142.544263608501m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 282,
                column: "Price",
                value: 1014.9149532716178m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1239.337221071617m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1206.16273686898m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1290.067506270303m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1206.982846583775m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 952.28654328371286m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1019.5087081157772m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1057.404187811996m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1051.852183922846m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 957.46462079172094m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1294.240524476932m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1030.3059696027769m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1141.420180828313m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1142.324641901252m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1042.4622318233112m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1256.173102038492m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1214.652640129074m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1170.715126296922m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 992.2743145611124m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1145.072282574186m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1116.095718252715m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1241.746111462327m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 992.9681078500337m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1152.751875901442m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1020.8105345022316m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1258.973463403254m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 955.91089104625054m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1095.083530501112m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1144.969267333362m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1069.996995740235m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1065.084583203494m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1019.2282978634612m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1233.619400774566m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1267.581597292942m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 316,
                column: "Price",
                value: 996.6709954371578m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1122.443408706818m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1157.126120175217m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1299.175385898882m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 320,
                column: "Price",
                value: 1197.476751283249m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 321,
                column: "Price",
                value: 994.4840291958286m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1232.302137884049m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 958.26085148976142m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1295.381631047679m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 953.55902705063563m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1123.714603510736m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1188.33821096461m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1176.337329756222m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 963.3642902503635m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1075.317339109466m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1278.874035611996m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 332,
                column: "Price",
                value: 1084.630797449292m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1129.17181293341m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 961.2357102163232m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 977.1100987120532m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1177.805028045059m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1047.9398872034744m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1033.6799596203944m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1239.04580393683m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1193.755896891469m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1059.148840726723m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1298.721012903024m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1159.826397536257m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 344,
                column: "Price",
                value: 1255.649109229712m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1129.570881200138m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1277.255278244401m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1098.92319247273m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1184.882849140603m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1042.0140721028005m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 350,
                column: "Price",
                value: 1275.691681597826m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 987.572324659651m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 998.6973101041146m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 974.4955682887825m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1174.20689012007m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 972.0111601822319m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1245.557717115411m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1239.09515345997m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1117.828356459787m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1004.4885119100048m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1094.487746416332m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 361,
                column: "Price",
                value: 1014.2240751970404m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 960.8239574478817m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1275.493487675491m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1289.889634608763m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1173.682251045846m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 366,
                column: "Price",
                value: 1270.78887959296m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1139.178830015177m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1236.694148591376m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1176.092864377271m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1032.7678444494183m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1219.28355388234m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 372,
                column: "Price",
                value: 1104.294794214422m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1100.118084831628m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1288.289283429448m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1169.81622123753m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1047.4139458290029m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1180.031956834896m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 378,
                column: "Price",
                value: 1047.6607367871571m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1200.331154383419m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1049.4241897516031m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 977.9177620102792m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1195.324634933198m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1036.9965839937464m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1051.251143244827m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 955.49008994225345m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 386,
                column: "Price",
                value: 1246.190592175428m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1186.89500238113m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 955.86792834535232m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 389,
                column: "Price",
                value: 1060.167007074398m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1229.181266514825m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1121.143792862642m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1139.947888652229m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1157.702832766586m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 394,
                column: "Price",
                value: 1199.961938696801m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1183.154159830435m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1285.119299418985m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1170.036010620947m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1025.816824505603m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1218.548505583952m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1024.314408641423m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1172.848483297774m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1190.575367006244m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1078.372494272337m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1104.843491470143m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 405,
                column: "Price",
                value: 1174.094569035555m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1130.519707238276m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1150.075171473051m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1239.035980709884m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1131.573307242363m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 410,
                column: "Price",
                value: 1139.343449391887m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1115.276687004595m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1012.4428396175925m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 413,
                column: "Price",
                value: 1123.472411613548m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 966.1810777846448m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1222.925088670653m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 990.6865917359154m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1072.974186756365m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1245.692683437062m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 419,
                column: "Price",
                value: 1172.807838429873m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1006.5927704687242m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1000.3052189130539m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1022.079509726023m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1279.918141713713m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1278.932675423446m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1149.348344648577m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 963.4652152735416m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 992.9085442521743m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1174.426467480839m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1078.602516147862m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1007.0858264844009m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1241.146071990203m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1205.807895423408m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1253.800358913661m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1184.577617207258m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1278.037957749756m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1168.109409429179m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1069.554414753165m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1152.472335676399m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1180.969512613998m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1084.350374508834m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1211.182590884958m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1271.435205224943m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1146.501253301576m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1187.80225329387m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1146.568002331536m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1289.085782262871m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1163.620788171062m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1216.830398818814m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1079.67562895645m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1061.492476741993m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1012.4351346228936m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1212.834471693919m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1203.24906880102m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1064.235695286404m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1209.131486668369m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 992.3576596660257m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 976.5366986372166m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 458,
                column: "Price",
                value: 1137.725732570555m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 970.2314666281097m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1081.605599857413m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1004.7058086094167m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 956.23326324059281m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1086.385853020054m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1022.0906656391004m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1043.3644425297201m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1112.798429122003m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 467,
                column: "Price",
                value: 1251.476744567973m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1080.230863099325m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1299.8791323371m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1066.026901150232m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1061.41533754411m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1050.325641814598m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 968.9131094889529m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1147.452093001653m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1089.5069327141m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1239.217612572013m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1041.777636850167m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 989.8411296307815m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1159.25422814424m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1229.618208701704m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1052.823528671969m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1081.593487505556m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1082.211334494112m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 976.2901757937901m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1271.471246477946m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1023.2635841906368m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1090.272570476335m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1223.307710994211m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 972.8443465623231m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1124.480762710836m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1117.280586249697m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1124.26715212475m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1088.145653355142m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 973.903781930485m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1178.8222362397m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1291.085320848315m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1284.3712327836m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1048.3870231321056m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1118.422473270831m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1234.309240848005m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 501,
                column: "Price",
                value: 970.0272355302386m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1196.977205977748m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1003.6934171305006m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 955.27491569308285m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1237.568209952338m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1231.71880186277m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1202.490162268151m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1004.5442057566772m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1167.043492825593m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 992.0376107066851m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1112.186827908587m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 998.2560588397848m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1020.1626832765774m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1219.214355697248m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1181.32714797591m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1098.035983415234m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1052.340122712868m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1240.545750118299m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1135.042565126201m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1185.601200516077m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 521,
                column: "Price",
                value: 1096.65510225163m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1056.12517781718m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1260.751718005879m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1078.32160164716m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1025.1784377752904m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 978.948425029397m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1256.17781681697m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1226.058111326921m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1014.1468872098122m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1032.5331486679891m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 985.319298000762m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1190.487862372753m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 533,
                column: "Price",
                value: 1080.95684143088m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1027.3701493772584m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1219.396424332578m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1116.881009484881m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1150.082148764094m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 992.6444835065348m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1078.604124658581m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1011.382145327462m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1148.69596328998m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1146.220195011149m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1065.838756369417m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1173.650222446033m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1122.789467644834m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1067.875084305199m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1169.064382542563m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 972.1686291136783m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1286.455045516652m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 975.178133129424m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1151.801150329064m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 552,
                column: "Price",
                value: 981.995565412598m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1022.7790914380714m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 959.83344935613261m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1092.150415618663m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1017.3539686294632m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 557,
                column: "Price",
                value: 1227.442845917613m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 998.0318820484727m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1242.359404450961m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1243.079927773769m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1124.873971224037m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1108.533976022987m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 987.7811655426449m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1204.834104816866m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1168.128820382809m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1029.0434695909941m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1070.132714776852m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1266.222313430827m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1288.214949032124m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1047.2854622091986m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1090.706449739766m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1241.96821970163m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 573,
                column: "Price",
                value: 978.2847918568128m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1016.7040013315221m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 979.5999721642691m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1098.917301836253m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 999.9260625104551m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1273.307512201226m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1240.51068468503m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1160.61691903166m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1274.782544161728m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 980.38252525549m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 957.64457695491363m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1269.990049353333m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 989.4655418845735m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1214.895498782262m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1027.5535167810891m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 986.9692387099331m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1262.787687151769m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1299.101571969771m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1176.083129825275m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1052.771465307079m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1286.756154115196m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1044.5549990913213m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2973868857352120582120582121m, 962, 1248.086184077274m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0327547568467771689497716895m, 1095, 1130.866458747221m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2035598208355888888888888889m, 990, 1191.524222627233m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3014907047161133263378803778m, 953, 1240.320641594456m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2048216934576217339667458432m, 842, 1014.4598658913175m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5737535510781567901234567901m, 810, 1274.740376373307m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5169918806329374167776298269m, 751, 1139.260902355336m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4335570794987747183979974969m, 799, 1145.412106519521m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9738069221453011627906976744m, 1032, 1004.9687436539508m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.982171572710576417004048583m, 988, 970.3855138380495m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1541870278241806883365200765m, 1046, 1207.279631104093m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0681015586582443832599118943m, 908, 969.8362152616859m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0341286567940008113590263692m, 986, 1019.6508555988848m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0265491183719759036144578313m, 1079, 1107.646498723362m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7340830637480753424657534247m, 730, 1265.880636536095m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5210806764473342210386151798m, 751, 1142.331588011948m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9229516912662543715846994536m, 1098, 1013.4009570103473m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4296997596475268414481897628m, 801, 1145.189507477669m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4367037534898493333333333333m, 750, 1077.527815117387m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.700116739495309820193637621m, 723, 1229.184402655109m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8314309938029362606232294618m, 706, 1292.990281624873m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7963881997950625m, 688, 1235.915081459003m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4357946787135081206496519722m, 862, 1237.655013051044m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2998401636067250821467688938m, 913, 1186.75406937294m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4651102888303179039301310044m, 687, 1006.5307684264284m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4753779793232987654320987654m, 810, 1195.056163251872m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4832339994467361111111111111m, 720, 1067.92847960165m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5626092545431576413959085439m, 831, 1298.528290525364m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7457245993243301369863013699m, 730, 1274.378957506761m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7035579976492710674157303371m, 712, 1212.933294326281m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2354263182361711026615969582m, 1052, 1299.668486784452m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4616868020249717948717948718m, 780, 1140.115705579478m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4161470784327138047138047138m, 891, 1261.787046883548m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3819161109810993303571428571m, 896, 1238.196835439065m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.369913398816827906976744186m, 860, 1178.125522982472m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2334974123879931192660550459m, 872, 1075.60974360233m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5344524821783989071038251366m, 732, 1123.219216954588m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.509012184960317485549132948m, 692, 1044.2364319925397m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.591803774937375m, 664, 1056.957706558417m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.569538519480292m, 750, 1177.153889610219m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3195024368853679790026246719m, 762, 1005.4608569066504m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4049317639235815279361459521m, 877, 1232.125156960981m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2356514790599378663540445487m, 853, 1054.010711638127m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9672490593953298142717497556m, 1023, 989.4957877614224m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1794918424017295774647887324m, 1065, 1256.158812157842m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4950265953966671309192200557m, 718, 1073.429095494807m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1846966329563372549019607843m, 867, 1027.1319807731444m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5220597749455894308943089431m, 738, 1123.280113909845m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5895935018977352555701179554m, 763, 1212.859841947972m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9584455559672383587786259542m, 1048, 1004.4509426536658m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6707643445880069060773480663m, 724, 1209.633385481717m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3719631453512651933701657459m, 905, 1241.626646542895m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.450427222329664367816091954m, 870, 1261.871683426808m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2300957041078792546583850932m, 805, 990.2270418068428m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8300301689310130813953488372m, 688, 1259.060756224537m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7053516040371350974930362117m, 718, 1224.442451698663m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1227912377031788990825688073m, 1090, 1223.842449096465m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1574121672647818974918211559m, 917, 1061.346957381805m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1814885249706579801734820322m, 807, 953.46123965132099m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2679718280198382022471910112m, 890, 1128.494926937656m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2557133383734829787234042553m, 940, 1180.370538071074m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1402637900876350210970464135m, 948, 1080.970073003078m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.291627223547375m, 832, 1074.633849991416m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1724629250578870116156282999m, 947, 1110.322390029819m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1370240608802445109780439122m, 1002, 1139.298109002005m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8432779574967383040935672515m, 684, 1260.802122927769m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1031727358455897522522522523m, 888, 979.6173894308837m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.14014808816395351137487636m, 1011, 1152.689717133757m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5190620796188894536213468869m, 787, 1195.501856660066m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1528682538383865654205607477m, 856, 986.8552252856589m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.592427611349192722371967655m, 742, 1181.581287621101m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.195755335775625m, 952, 1138.359079658395m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1645378697231044318181818182m, 880, 1024.7933253563319m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2501092098414950166112956811m, 903, 1128.84861648687m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3203894091514697156983930779m, 809, 1068.195032003539m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6756087313333250728862973761m, 686, 1149.467589694661m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3510455353875926395939086294m, 788, 1064.623881885423m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0742588215719912023460410557m, 1023, 1098.966774468147m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.373314638372676056338028169m, 781, 1072.55873256906m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1004821592181061315496098105m, 897, 987.1324968186412m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2591474381528603297769156159m, 1031, 1298.181008735599m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2171316369050521739130434783m, 920, 1119.761105952648m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0319453316348522494887525562m, 978, 1009.2425343388855m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8193049842959547445255474453m, 685, 1246.223914242729m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.094682915244m, 976, 1068.410525278144m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3650560520336375598086124402m, 836, 1141.186859500121m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6933894959453050075872534143m, 659, 1115.943677827956m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7802487098160706605222734255m, 651, 1158.941910090262m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6822729767146565934065934066m, 728, 1224.69472704827m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4114690125900624277456647399m, 865, 1220.920695890404m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1004489916826287700534759358m, 935, 1028.9198072232579m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1703006607984231900452488688m, 884, 1034.5457841458061m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3154543083682568605927552141m, 911, 1198.378874923482m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2981840168710750750750750751m, 999, 1296.885832854204m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.451087916831272108843537415m, 735, 1066.549618870985m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3662940484044521276595744681m, 752, 1027.453124400148m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5259090857176195190947666195m, 707, 1078.817723602357m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6659352504560209698558322412m, 763, 1271.108596097944m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9996781271198030845771144279m, 1005, 1004.6765177554021m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.053064382807327m, 1000, 1053.064382807327m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3093056857427437810945273632m, 804, 1052.681771337166m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1370363730977262464722483537m, 1063, 1208.669664602883m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0836070722640464684014869888m, 1076, 1165.961209756114m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6263501522023496402877697842m, 695, 1130.313355780633m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0089127676439471367974549311m, 943, 951.40473988824215m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2437670347421956575682382134m, 806, 1002.4762300022097m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4231828748368195991091314031m, 898, 1278.018221603464m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7940887321031924157303370787m, 712, 1277.391177257473m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0404256801786425661914460285m, 982, 1021.698017935427m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0304000021647627659574468085m, 940, 968.576002034877m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.339705132348116254036598493m, 929, 1244.5860679514m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5642108332860678851174934726m, 766, 1198.185498297128m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2243587200256639175257731959m, 970, 1187.627958424894m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1139462844586974552309142319m, 1061, 1181.897007810678m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.035635550943150093808630394m, 1066, 1103.987497305398m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4303378135497679324894514768m, 711, 1016.970185433885m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1167691497756390899689762151m, 967, 1079.915767833043m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4587038930675768707482993197m, 735, 1072.147361404669m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9693295533169795761078998073m, 1038, 1006.1640763430248m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4016094797451670644391408115m, 838, 1174.54874402645m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0585767346230642636457260556m, 971, 1027.8780093189954m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9456763103751115671641791045m, 1072, 1013.7650047221196m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3665366440392251655629139073m, 906, 1238.082199499538m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.324861612145886576482830385m, 961, 1273.192009272197m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7381915641600487144790257104m, 739, 1284.523565914276m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4093674165227181603773584906m, 848, 1195.143569211265m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3817168202793835243553008596m, 698, 964.4383405550097m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2010051505977154105736782902m, 889, 1067.693578881369m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8806394451814464023494860499m, 681, 1280.715462168565m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2451251890231771069182389937m, 795, 989.8745252734258m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2511214178615537712895377129m, 822, 1028.4218054821972m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3143175590703238095238095238m, 945, 1242.030093321456m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2367805767706328708644610459m, 937, 1158.863400434083m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2535833712929084745762711864m, 885, 1109.421283594224m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9545759461220015105740181269m, 662, 1293.929276332765m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1432367807147388758782201405m, 854, 976.324210730387m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3817517984842564068692206077m, 757, 1045.9861114525821m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2709743712543058589870903674m, 1007, 1279.871191853086m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0335640875952502343017806935m, 1067, 1102.812881464132m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2502048329871402743142144638m, 802, 1002.6642760556865m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4499627556729234285714285714m, 875, 1268.717411213808m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4373967749314041331802525832m, 871, 1251.972590965253m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8750402693468795731707317073m, 656, 1230.026416691553m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9258903513086325946445060018m, 1083, 1002.7392504672491m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3801517483907580645161290323m, 868, 1197.971717603178m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0318726988977128060263653484m, 1062, 1095.848806229371m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0529529862145050505050505051m, 1089, 1146.665801987596m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.328084231962527509778357236m, 767, 1018.6406059152586m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5330147378838213399503722084m, 806, 1235.60987873436m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3782062705948972067039106145m, 895, 1233.494612182433m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2663128760623326713008937438m, 1007, 1275.177066194769m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2713928528361279317697228145m, 938, 1192.566495960288m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4425113100394266211604095563m, 879, 1267.967441524656m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3089192534595967824967824968m, 777, 1017.0302599381067m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0462960618949984407484407484m, 962, 1006.5368115429885m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1119692564335055555555555556m, 1080, 1200.926796948186m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0642120490280048421052631579m, 950, 1011.0014465766046m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1427060155330579399141630901m, 932, 1065.00200647681m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2758271885252431544359255203m, 913, 1164.830223123547m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.315280374376116156282998944m, 947, 1245.570514534182m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0145962014147617295308187672m, 1087, 1102.866070937846m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3490059245085092896174863388m, 915, 1234.340420925286m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5182993280001011673151750973m, 771, 1170.608781888078m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.122599183446254625550660793m, 908, 1019.3200585691992m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0928656125849668292682926829m, 1025, 1120.187252899591m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.365608385147937219730941704m, 892, 1218.12267955196m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5480143200283092522179974651m, 789, 1221.383298502336m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7151163703751576158940397351m, 755, 1294.912859633244m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2849054085334198830409356725m, 855, 1098.594124296074m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2084665118247419724770642202m, 872, 1053.782798311175m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5140547343211970310391363023m, 741, 1121.914558132007m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1187417054830290135396518375m, 1034, 1156.778923469452m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9884531835429861495844875346m, 1083, 1070.494797777054m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2550212451694025974025974026m, 847, 1063.002994658484m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5785896915108362068965517241m, 812, 1281.814829506799m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8191227278687213352685050798m, 689, 1253.375559501549m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5364576232493173734610123119m, 731, 1123.150522595251m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0040161718578277502477700694m, 1009, 1013.0523174045482m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2232193408100308219178082192m, 876, 1071.540142549587m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2493005420064857792946530148m, 879, 1098.135176423701m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2411332086383475750577367206m, 866, 1074.821358680809m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3052009231126646090534979424m, 972, 1268.65529726551m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3511351472514777542372881356m, 944, 1275.471579005395m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2861696128731161676646706587m, 835, 1073.951626749052m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2203829468989262672811059908m, 868, 1059.292397908268m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2416130746389394977168949772m, 876, 1087.653053383711m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0075940305785438075742067554m, 977, 984.4193678752373m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0875733820362337536372453928m, 1031, 1121.288156879357m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4531270995678544018058690745m, 886, 1287.470610217119m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3448454919952523364485981308m, 856, 1151.187741147936m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2497559399245473465140478668m, 961, 1201.01545826749m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5785382526416675603217158177m, 746, 1177.589536470684m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1578505693814785005512679162m, 907, 1050.170466429001m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1289337443568941605839416058m, 1096, 1237.311383815156m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4958481831595033288948069241m, 751, 1123.381985552787m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5639743718756283292978208232m, 826, 1291.842831169269m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4132259435035838926174496644m, 894, 1263.423993492204m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5205717271569752604166666667m, 768, 1167.799086456557m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6107255916894945945945945946m, 740, 1191.936937850226m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0413372488925712954333643989m, 1073, 1117.354868061729m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1967625449782564593301435407m, 1045, 1250.616859502278m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7774797493074642335766423358m, 685, 1217.573628275613m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9893678018883642261353104727m, 1079, 1067.527858237545m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.139078080751763771186440678m, 944, 1075.289708229665m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3734779898456056644880174292m, 918, 1260.852794678266m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2242351884838691891891891892m, 925, 1132.417549347579m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.36544405372784994640943194m, 933, 1273.959302128084m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2683936417498855140186915888m, 856, 1085.744957337902m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1218343749104789029535864979m, 948, 1063.498987415134m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7732424643472119944211994421m, 717, 1271.414846936951m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0724177158060408560311284047m, 1028, 1102.44541184861m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5030242636198723994452149792m, 721, 1083.680494069928m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6278965912469271708683473389m, 714, 1162.318166150306m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0138108308954754773869346734m, 995, 1008.7417767409981m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.646594334476158102766798419m, 759, 1249.765099867404m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5051432275379521028037383178m, 856, 1288.402602772487m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2789491975285561735261401557m, 899, 1149.775328578172m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1972452040123978021978021978m, 819, 980.5438220861538m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.587146212769158311345646438m, 758, 1203.056829279022m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6513173637850963172804532578m, 706, 1165.830058832278m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3847450383685383720930232558m, 860, 1190.880732996943m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2881943086414978813559322034m, 944, 1216.055427357574m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6843403114763267882187938289m, 713, 1200.934642082621m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4795837031965545685279187817m, 788, 1165.911958118885m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9938637608117595682041216879m, 1019, 1012.747172267183m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0604534676987293489861259338m, 937, 993.6448992337094m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4828846661496225609756097561m, 656, 972.7723409941524m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3472418959570062578222778473m, 799, 1076.446274869648m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3939157668281666666666666667m, 888, 1237.797200943412m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1836472740185769230769230769m, 1092, 1292.542823228286m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0630832068598790100824931256m, 1091, 1159.823778684128m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5335944475472576312576312576m, 819, 1256.013852541204m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.167394670991379247015610652m, 1089, 1271.292796709612m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1578135447323439099283520983m, 977, 1131.1838332035m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1320885166894349142280524723m, 991, 1121.89972003923m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9256569145078366820276497696m, 1085, 1004.3377522410028m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1647739235403918161434977578m, 892, 1038.9783397980295m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2804340082177003654080389769m, 821, 1051.236320746732m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4673228072673803468208092486m, 865, 1269.234228286284m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4624271397121199011124845488m, 809, 1183.103556027105m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4627299942229361851332398317m, 713, 1042.9264858809535m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5172998584023963730569948187m, 772, 1171.35549068665m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6005145343062256637168141593m, 678, 1085.148854259621m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7427031480750364864864864865m, 740, 1289.600329575527m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4132750709230555084745762712m, 708, 1000.5987502135233m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.262811841872802441731409545m, 901, 1137.793469527395m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1705480329544929718875502008m, 996, 1165.865840822675m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2534768539822711267605633803m, 852, 1067.962279592895m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5042464989894339869281045752m, 765, 1150.748571726917m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4567587192435333333333333333m, 810, 1179.974562587262m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4344375094689315436241610738m, 745, 1068.655944554354m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3202139946195489159891598916m, 738, 974.3179280292271m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5807342223267750342935528121m, 729, 1152.355248076219m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0664653658178615819209039548m, 1062, 1132.586218498569m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4570761019608695652173913043m, 874, 1273.4845131138m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.97671682944871845703125m, 1024, 1000.1580333554877m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1964616861334508474576271186m, 885, 1058.868592228104m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0013239405990572164948453608m, 970, 971.2842223810855m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2161282406453251714005876592m, 1021, 1241.666933698877m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.135592288472238929889298893m, 1084, 1230.982040703907m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3848703078180894396551724138m, 928, 1285.159645655187m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5125570549436391053391053391m, 693, 1048.2020390759419m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9927425955510235912129894938m, 1047, 1039.4014975419217m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6858071248301356421356421356m, 693, 1168.264337507284m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1354851565737080223880597015m, 1072, 1217.240087847015m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9469067082404627667984189723m, 1012, 958.26958873934832m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3162594379241681922196796339m, 874, 1150.410748745723m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7149985609736283309957924264m, 713, 1222.793973974197m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1211882048407308480565371025m, 849, 951.88878590978049m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9650428411585349144008056395m, 993, 958.28754127042517m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0890562514423591194968553459m, 954, 1038.9596638760106m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4925883264824084682440846824m, 803, 1198.548426165374m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.042329407471804922515952598m, 1097, 1143.43535999657m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5121675691005960729312762973m, 713, 1078.175476768725m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3977548527949954285714285714m, 875, 1223.035496195621m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0493975053143098330241187384m, 1078, 1131.250510728826m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1340448071519694444444444444m, 1080, 1224.768391724127m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3382129500861976866456361725m, 951, 1272.640515531974m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4022009446946666666666666667m, 825, 1156.8157793731m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5958937431265906040268456376m, 745, 1188.94083862931m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2737394243127101449275362319m, 897, 1142.544263608501m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1416366178533383577052868391m, 889, 1014.9149532716178m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4736471118568573127229488704m, 841, 1239.337221071617m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4691385345541778319123020706m, 821, 1206.16273686898m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3522720191512610062893081761m, 954, 1290.067506270303m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1844777689732826300294406281m, 1019, 1206.982846583775m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1296400276200627046263345196m, 843, 952.28654328371286m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2478686757843050183598531212m, 817, 1019.5087081157772m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2396297629683423212192262603m, 853, 1057.404187811996m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.101415899395650261780104712m, 955, 1051.852183922846m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.300903017380055625m, 736, 957.46462079172094m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2279321864107514231499051233m, 1054, 1294.240524476932m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9701562802286034839924670433m, 1062, 1030.3059696027769m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3637039197470884109916367981m, 837, 1141.420180828313m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5312662760070402144772117962m, 746, 1142.324641901252m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.260534742228913180169286578m, 827, 1042.4622318233112m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6726672463894700399467376831m, 751, 1256.173102038492m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5857084074792088772845953003m, 766, 1214.652640129074m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1683783695578063872255489022m, 1002, 1170.715126296922m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2836666423817754204398447607m, 773, 992.2743145611124m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2405983559850335861321776815m, 923, 1145.072282574186m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0382285751188046511627906977m, 1075, 1116.095718252715m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5502448332863008739076154806m, 801, 1241.746111462327m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.968749373512228m, 1025, 992.9681078500337m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3498265525778009367681498829m, 854, 1152.751875901442m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2696648439082482587064676617m, 804, 1020.8105345022316m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.546650446441343980343980344m, 814, 1258.973463403254m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9307798354880725803310613437m, 1027, 955.91089104625054m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0092935764987207373271889401m, 1085, 1095.083530501112m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7427233901573242009132420091m, 657, 1144.969267333362m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2242528555380263157894736842m, 874, 1069.996995740235m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.05245512174258300395256917m, 1012, 1065.084583203494m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9716189684113071496663489037m, 1049, 1019.2282978634612m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6361000010272758620689655172m, 754, 1233.619400774566m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.903275671611024024024024024m, 666, 1267.581597292942m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.927135809708984m, 1075, 996.6709954371578m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6434017697025153733528550512m, 683, 1122.443408706818m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4163110406061407588739290086m, 817, 1157.126120175217m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7027200339434888597640891219m, 763, 1299.175385898882m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1098023644886459684893419833m, 1079, 1197.476751283249m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.375496582566844536652835408m, 723, 994.4840291958286m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4329094626558709302325581395m, 860, 1232.302137884049m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4629936663965823206106870229m, 655, 958.26085148976142m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2290148302160142314990512334m, 1054, 1295.381631047679m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2663466494696356308100929615m, 753, 953.55902705063563m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.247186019434779134295227525m, 901, 1123.714603510736m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4439103413907776427703523694m, 823, 1188.33821096461m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0963069242835246971109040075m, 1073, 1176.337329756222m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0692167483355865704772475028m, 901, 963.3642902503635m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2261315155182052451539338655m, 877, 1075.317339109466m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1808624520886389658356417359m, 1083, 1278.874035611996m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1600329384484406417112299465m, 935, 1084.630797449292m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4275244158450189633375474083m, 791, 1129.17181293341m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1229389138041158878504672897m, 856, 961.2357102163232m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3533380868587994459833795014m, 722, 977.1100987120532m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1238597595849799618320610687m, 1048, 1177.805028045059m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9914284647147345316934720908m, 1057, 1047.9398872034744m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2047551976927673659673659674m, 858, 1033.6799596203944m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1440866149001200369344413666m, 1083, 1239.04580393683m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8253148270511758409785932722m, 654, 1193.755896891469m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2593922006263055885850178359m, 841, 1059.148840726723m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8037791845875333333333333333m, 720, 1298.721012903024m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6451438262925631205673758865m, 705, 1159.826397536257m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2131875451494801932367149758m, 1035, 1255.649109229712m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2879941632840798175598631699m, 877, 1129.570881200138m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.216433598328000952380952381m, 1050, 1277.255278244401m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0063399198468223443223443223m, 1092, 1098.92319247273m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5508937815976479057591623037m, 764, 1184.882849140603m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5391640651444615952732644018m, 677, 1042.0140721028005m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2361353503854903100775193798m, 1032, 1275.691681597826m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3473019436011609822646657572m, 733, 987.572324659651m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "EuPerKm", "TripPrice" },
                values: new object[] { 1.4950558534492733532934131737m, 998.6973101041146m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1149834877446024027459954233m, 874, 974.4955682887825m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2763118370870326086956521739m, 920, 1174.20689012007m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1435425413908610588235294118m, 850, 972.0111601822319m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3138794484339778481012658228m, 948, 1245.557717115411m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3266543398929014989293361884m, 934, 1239.09515345997m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2447977243427472160356347439m, 898, 1117.828356459787m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9257958635115251612903225806m, 1085, 1004.4885119100048m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4750508711810404312668463612m, 742, 1094.487746416332m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.924543368456736918869644485m, 1097, 1014.2240751970404m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0723481667945108258928571429m, 896, 960.8239574478817m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2678861706515815109343936382m, 1006, 1275.493487675491m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7915133814010597222222222222m, 720, 1289.889634608763m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1242167155611551724137931034m, 1044, 1173.682251045846m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.227815342601893719806763285m, 1035, 1270.78887959296m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3909387423872735042735042735m, 819, 1139.178830015177m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6123782902103989569752281617m, 767, 1236.694148591376m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5393885659388363874345549738m, 764, 1176.092864377271m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.13866355507102348401323043m, 907, 1032.7678444494183m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6085535011640369393139841689m, 758, 1219.28355388234m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1611932641581724500525762355m, 951, 1104.294794214422m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0979222403509261477045908184m, 1002, 1100.118084831628m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1972948730756951672862453532m, 1076, 1288.289283429448m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0663775945647493163172288058m, 1097, 1169.81622123753m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5448583271814202064896755162m, 678, 1047.4139458290029m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1059343550467628865979381443m, 1067, 1180.031956834896m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0734228860524150614754098361m, 976, 1047.6607367871571m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1042604916130809567617295308m, 1087, 1200.331154383419m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.007124942180041362763915547m, 1042, 1049.4241897516031m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9322380953386836987607244995m, 1049, 977.9177620102792m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2098427479080951417004048583m, 988, 1195.324634933198m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4089627499915032608695652174m, 736, 1036.9965839937464m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.124332773523879144385026738m, 935, 1051.251143244827m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4609940213184303516819571865m, 654, 955.49008994225345m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2742235093818282208588957055m, 978, 1246.190592175428m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5354398478410478654592496766m, 773, 1186.89500238113m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2446196983663441666666666667m, 768, 955.86792834535232m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0840153446568486707566462168m, 978, 1060.167007074398m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2764083764432242990654205607m, 963, 1229.181266514825m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0606847614594531693472090823m, 1057, 1121.143792862642m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2024766757934905063291139241m, 948, 1139.947888652229m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5333812354524317880794701987m, 755, 1157.702832766586m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5563708673110259403372243839m, 771, 1199.961938696801m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6387176728953393351800554017m, 722, 1183.154159830435m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3599146025597724867724867725m, 945, 1285.119299418985m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7105789628961213450292397661m, 684, 1170.036010620947m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9551367081057756052141527002m, 1074, 1025.816824505603m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7972691822772153392330383481m, 678, 1218.548505583952m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0202334747424531872509960159m, 1004, 1024.314408641423m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6022520263630792349726775956m, 732, 1172.848483297774m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1649465430589471624266144814m, 1022, 1190.575367006244m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2240323431014040862656072645m, 881, 1078.372494272337m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4750914438853711615487316422m, 749, 1104.843491470143m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2371913266971074815595363541m, 949, 1174.094569035555m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5297966268447577807848443843m, 739, 1130.519707238276m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.444818054614385678391959799m, 796, 1150.075171473051m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6766386748442273342354533153m, 739, 1239.035980709884m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6543469404128114035087719298m, 684, 1131.573307242363m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0698060557670300469483568075m, 1065, 1139.343449391887m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5620121666731022408963585434m, 714, 1115.276687004595m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1718088421499913194444444444m, 864, 1012.4428396175925m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "EuPerKm", "TripPrice" },
                values: new object[] { 1.3684195025743580998781973203m, 1123.472411613548m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2107532303065724310776942356m, 798, 966.1810777846448m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4751810478536224366706875754m, 829, 1222.925088670653m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9390394234463653080568720379m, 1055, 990.6865917359154m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3085051058004451219512195122m, 820, 1072.974186756365m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4689772210342712264150943396m, 848, 1245.692683437062m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.471528028142877038895859473m, 797, 1172.807838429873m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1171950837610701442841287458m, 901, 1006.5927704687242m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.94457527753829452313503305m, 1059, 1000.3052189130539m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0365917948539787018255578093m, 986, 1022.079509726023m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3007298188147489837398373984m, 984, 1279.918141713713m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4516829459971010215664018161m, 881, 1278.932675423446m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0691612508358855813953488372m, 1075, 1149.348344648577m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9167128594419996194100856327m, 1051, 963.4652152735416m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9889527333188987051792828685m, 1004, 992.9085442521743m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0854218738270231053604436229m, 1082, 1174.426467480839m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9823338034133533697632058288m, 1098, 1078.602516147862m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.135384246318377564825253664m, 887, 1007.0858264844009m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1418087138824314627414903404m, 1087, 1241.146071990203m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0981856971069289617486338798m, 1098, 1205.807895423408m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4545247783221125290023201856m, 862, 1253.800358913661m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7948145715261484848484848485m, 660, 1184.577617207258m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7108941870813333333333333333m, 747, 1278.037957749756m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3598479737243061699650756694m, 859, 1168.109409429179m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1152809330064285714285714286m, 959, 1069.554414753165m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3687319901144881235154394299m, 842, 1152.472335676399m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3314199691251386696730552424m, 887, 1180.969512613998m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6064449992723466666666666667m, 675, 1084.350374508834m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2246537824923741152679474216m, 989, 1211.182590884958m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8373341115967384393063583815m, 692, 1271.435205224943m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1453558974041718281718281718m, 1001, 1146.501253301576m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1543267767676093294460641399m, 1029, 1187.80225329387m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3332186073622511627906976744m, 860, 1146.568002331536m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6611930183799884020618556701m, 776, 1289.085782262871m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.61389845793489875173370319m, 721, 1163.620788171062m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6994837972329804469273743017m, 716, 1216.830398818814m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4609954383713802435723951286m, 739, 1079.67562895645m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2651876957592288438617401669m, 839, 1061.492476741993m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1731577457970957126303592121m, 863, 1012.4351346228936m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1517896217416134852801519468m, 1053, 1212.834471693919m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1100083660526014760147601476m, 1084, 1203.24906880102m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4114531767724190981432360743m, 754, 1064.235695286404m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1971598877904643564356435644m, 1010, 1209.131486668369m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.382113732125383983286908078m, 718, 992.3576596660257m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1315604850952683661645422943m, 863, 976.5366986372166m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7343380069673094512195121951m, 656, 1137.725732570555m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0170141159623791404612159329m, 954, 970.2314666281097m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2071491069837198660714285714m, 896, 1081.605599857413m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1820068336581372941176470588m, 850, 1004.7058086094167m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3430242461244281039325842697m, 712, 956.23326324059281m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1991013830243421633554083885m, 906, 1086.385853020054m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2649636950978965346534653465m, 808, 1022.0906656391004m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5503186367454979197622585438m, 673, 1043.3644425297201m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1083649692450229083665338645m, 1004, 1112.798429122003m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.201033344115137236084452975m, 1042, 1251.476744567973m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0528565917147417153996101365m, 1026, 1080.230863099325m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3526317714225806451612903226m, 961, 1299.8791323371m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0019049822840526315789473684m, 1064, 1066.026901150232m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1537123234175108695652173913m, 920, 1061.41533754411m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9899393419553232799245994345m, 1061, 1050.325641814598m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1266431505685498837209302326m, 860, 968.9131094889529m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3858117065237355072463768116m, 828, 1147.452093001653m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2200525562307950727883538634m, 893, 1089.5069327141m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4966396287101606280193236715m, 828, 1239.217612572013m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2372656019598182897862232779m, 842, 1041.777636850167m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3412481431311402439024390244m, 738, 989.8411296307815m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5989713491644689655172413793m, 725, 1159.25422814424m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8658849904426464339908952959m, 659, 1229.618208701704m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.28864568992897062423500612m, 817, 1052.823528671969m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4028449902795797665369649805m, 771, 1081.593487505556m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1879377985665334796926454446m, 911, 1082.211334494112m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9637612791646496544916090819m, 1013, 976.2901757937901m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7958633424829745762711864407m, 708, 1271.471246477946m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.371667002936510455764075067m, 746, 1023.2635841906368m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4086208920882881136950904393m, 774, 1090.272570476335m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5907772574697152145643693108m, 769, 1223.307710994211m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9481913709184435672514619883m, 1026, 972.8443465623231m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3499168820058055222088835534m, 833, 1124.480762710836m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2118010696851377440347071584m, 922, 1117.280586249697m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1760116654024581589958158996m, 956, 1124.26715212475m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.550065033269433048433048433m, 702, 1088.145653355142m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4689348143747888386123680241m, 663, 973.903781930485m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5329287857473342002600780234m, 769, 1178.8222362397m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7832670177462914364640883978m, 724, 1291.085320848315m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7789075246310249307479224377m, 722, 1284.3712327836m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4766014410311346478873239437m, 710, 1048.3870231321056m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0308041228302589861751152074m, 1085, 1118.422473270831m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8989372936123153846153846154m, 650, 1234.309240848005m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4675147284875016641452344932m, 661, 970.0272355302386m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2005789428061664994984954865m, 997, 1196.977205977748m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2514880512849134663341645885m, 802, 1003.6934171305006m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9767637174775898261758691207m, 978, 955.27491569308285m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3781383184324476614699331849m, 898, 1237.568209952338m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4524985871023231132075471698m, 848, 1231.71880186277m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5905954527356494708994708995m, 756, 1202.490162268151m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3704559423692731241473396999m, 733, 1004.5442057566772m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5943217115103729508196721311m, 732, 1167.043492825593m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1481916790586633101851851852m, 864, 992.0376107066851m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3713770997639790382244143033m, 811, 1112.186827908587m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0463899987838415094339622642m, 954, 998.2560588397848m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3231682013963390402075226978m, 771, 1020.1626832765774m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2228830047113821464393179539m, 997, 1219.214355697248m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5772058050412683578104138852m, 749, 1181.32714797591m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5187219687624260027662517289m, 723, 1098.035983415234m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1679690596147258601553829079m, 901, 1052.340122712868m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1444148986331171586715867159m, 1084, 1240.545750118299m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6497711702415712209302325581m, 688, 1135.042565126201m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6285730776319739010989010989m, 728, 1185.601200516077m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0098113280401749539594843462m, 1086, 1096.65510225163m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1223434408259086078639744952m, 941, 1056.12517781718m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2240307941804650485436893204m, 1030, 1260.751718005879m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1772069886977729257641921397m, 916, 1078.32160164716m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2018504546017472450175849941m, 853, 1025.1784377752904m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1422968786807432905484247375m, 857, 978.948425029397m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4323578298939224629418472064m, 877, 1256.17781681697m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3414202530929113785557986871m, 914, 1226.058111326921m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.218926547127178125m, 832, 1014.1468872098122m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0315016470209681318681318681m, 1001, 1032.5331486679891m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9784700079451459781529294935m, 1007, 985.319298000762m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2800944756696268817204301075m, 930, 1190.487862372753m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0670847398133070088845014808m, 1013, 1080.95684143088m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5805694605803975384615384615m, 650, 1027.3701493772584m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6749950883689258241758241758m, 728, 1219.396424332578m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0596594017883121442125237192m, 1054, 1116.881009484881m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6667857228465130434782608696m, 690, 1150.082148764094m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2791810354465654639175257732m, 776, 992.6444835065348m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1660585131444118918918918919m, 925, 1078.604124658581m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3395790004337245033112582781m, 755, 1011.382145327462m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0877802682670265151515151515m, 1056, 1148.69596328998m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1439323303504481037924151697m, 1002, 1146.220195011149m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3824108383520324254215304799m, 771, 1065.838756369417m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.493193667234138676844783715m, 786, 1173.650222446033m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6343369252472110625909752547m, 687, 1122.789467644834m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0963809900464055441478439425m, 974, 1067.875084305199m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6259588074305465924895688456m, 719, 1169.064382542563m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1238943689175471676300578035m, 865, 972.1686291136783m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3020800055836558704453441296m, 988, 1286.455045516652m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4533206156921371087928464978m, 671, 975.178133129424m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2657155498121582417582417582m, 910, 1151.801150329064m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1083471392918713318284424379m, 886, 981.995565412598m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9435231470830916974169741697m, 1084, 1022.7790914380714m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2305557043027341153846153846m, 780, 959.83344935613261m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.446556841879023841059602649m, 755, 1092.150415618663m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9839013236261733075435203095m, 1034, 1017.3539686294632m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4289206588097939464493597206m, 859, 1227.442845917613m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4918264305657289985052316891m, 669, 998.0318820484727m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1687294491542436500470366886m, 1063, 1242.359404450961m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6552329264630745672436750999m, 751, 1243.079927773769m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4421461169538935897435897436m, 780, 1124.873971224037m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5791082279529729344729344729m, 702, 1108.533976022987m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9907534258201052156469408225m, 997, 987.7811655426449m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1239124112097630597014925373m, 1072, 1204.834104816866m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3856806884730830367734282325m, 843, 1168.128820382809m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1345572983362669239250275634m, 907, 1029.0434695909941m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0875332467244430894308943089m, 984, 1070.132714776852m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3217351914726795407098121086m, 958, 1266.222313430827m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6224369635165289672544080605m, 794, 1288.214949032124m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1820377677304724604966139955m, 886, 1047.2854622091986m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9942629441565779398359161349m, 1097, 1090.706449739766m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2457053357087562688064192578m, 997, 1241.96821970163m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0942782906675758389261744966m, 894, 978.2847918568128m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0657274647080944444444444444m, 954, 1016.7040013315221m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3493112564246130853994490358m, 726, 979.5999721642691m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3239967492003048192771084337m, 830, 1098.917301836253m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.298605275987604025974025974m, 770, 999.9260625104551m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9292538063654939393939393939m, 660, 1273.307512201226m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4820916185006332138590203106m, 837, 1240.51068468503m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1312055741049317738791423002m, 1026, 1160.61691903166m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3447073250651139240506329114m, 948, 1274.782544161728m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8953265070826392694063926941m, 1095, 980.38252525549m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0640495299499040333333333333m, 900, 957.64457695491363m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6666536080752401574803149606m, 762, 1269.990049353333m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3210487875628484646194926569m, 749, 989.4655418845735m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5943510482706850393700787402m, 762, 1214.895498782262m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4351306100294540502793296089m, 716, 1027.5535167810891m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9849992402294741516966067864m, 1002, 986.9692387099331m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.715744140151860054347826087m, 736, 1262.787687151769m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8558593885282442857142857143m, 700, 1299.101571969771m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5786350735909731543624161074m, 745, 1176.083129825275m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9756918121474318813716404078m, 1079, 1052.771465307079m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1783481264791172161172161172m, 1092, 1286.756154115196m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5543973200763709821428571429m, 672, 1044.5549990913213m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientEmail",
                table: "SoldsOrders");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "SoldsOrders",
                type: "decimal(18,2)",
                nullable: false,
                comment: "price of the load",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "Price of the load");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "c4b14cae-c55f-440d-8b0a-eac213b95acd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dispatcherRoleId",
                column: "ConcurrencyStamp",
                value: "de473028-dd30-445d-8f31-9e43181b9148");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "managerRoleId",
                column: "ConcurrencyStamp",
                value: "b3c05669-4a52-48e4-9833-f6cdc55da528");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0261d5ca-050a-423e-90cb-c7e990f67959",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66433d49-aa91-4b96-8e3b-2bcb72e04cff", "AQAAAAEAACcQAAAAENnu0N/Bp01POTw3FkP2RbInHspkFL1CYM07yjBwRn2JBxH47BIty1MDX+LWlYdFsw==", "b14d8483-8fe3-405a-9b0f-a50dd997124b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19918df1-9468-434b-aaf9-a3d22b2d12e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c12d80d-e0a8-4f20-b9b6-301acac66b77", "AQAAAAEAACcQAAAAEOkWmX7LXk/X0EtdYLZY0gx+HVHq6JbM+a+E/bGnhZ3CH2JQwbktfpYzPSgWOQ1JSg==", "ae5cc927-5fb3-40ec-b510-a167638fde1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62154153-66df-4b35-91ed-56ac983c9a8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bf88d3b-f1d0-456f-85df-53c21bd7da84", "AQAAAAEAACcQAAAAEL2xLzRPkfxLzO/8xxX2G5sEMjIxx7awqyIlSIkC0Xo3N2TxCVfNjyQwtpP5v5vDqg==", "3b456cca-c71b-4eb0-b184-4a2423b5e1bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77a53efa-830a-41a9-9bab-a2386aab1647", "AQAAAAEAACcQAAAAEJuEBBdc1MUtN1aknIqTRstaKv5hIYRVgjsTCX5Z1dktl8coHzfJDDA7zGv7JJAWqg==", "ace63ec0-fee8-41fa-914a-7ff7b97ee237" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 953.64772626312552m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 1259.727204606021m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 964.8820385768761m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 1060.055156496179m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1038.1241861551183m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1021.2811676375027m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1224.232575812068m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1217.013651903513m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 1112.746020726297m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 951.12737167009369m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1275.860786875803m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 1212.627855510698m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1228.198046636751m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1248.610002084489m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1238.466168699433m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1139.837290612115m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1129.904851234225m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1124.396271721953m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1288.737079602836m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1258.582351394996m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1226.793440676119m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1146.008697471457m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1244.343676156042m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1136.538265279308m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1121.068142400158m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1051.28971507598m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                column: "Price",
                value: 992.701741058491m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1018.5990341355352m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1043.5660295417588m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1136.314128101814m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1009.1858350534894m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1222.811540415267m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1133.568597440447m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1274.681118200222m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 977.1309434893027m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1132.142241366306m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1174.587512231512m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38,
                column: "Price",
                value: 1020.7290453455623m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1130.960733239929m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1177.354484689982m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1004.9418187947809m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1206.250270950073m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1239.002638554133m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44,
                column: "Price",
                value: 1007.6646253146076m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1054.418152959955m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 984.612053111433m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1108.503047724219m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 998.7918945574878m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1100.765759412158m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1105.005631909485m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1251.412769466884m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1035.9605681206513m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 53,
                column: "Price",
                value: 1019.7378755958511m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1117.458976016514m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1120.139791671306m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1061.199705164491m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1112.211730370041m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1109.561371691467m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 979.403738649729m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1125.815979429245m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 61,
                column: "Price",
                value: 1189.976490519818m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1090.295969923764m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1088.479901890648m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1099.131764082766m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1214.888538005886m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 954.29131397026877m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1037.3344445192397m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1119.319120986771m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1160.343132340124m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1060.86152938334m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1275.071993880648m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1054.67297340411m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1191.952832407898m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1166.520073446356m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1255.756870484289m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 76,
                column: "Price",
                value: 1003.6278386530758m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1091.952456761921m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1135.664235819814m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1221.046441525663m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1019.5688972095128m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1028.8997826812889m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1104.078108899512m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1215.646902469317m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1141.826028551688m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1170.427342753212m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1019.6850432831139m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1166.463448475388m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 958.12054083422256m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 89,
                column: "Price",
                value: 1262.483816138326m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 978.7102604804874m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1075.408077945943m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1013.8929041694028m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1122.605600480514m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1065.226066932087m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1129.948666773001m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 950.56563180855288m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 97,
                column: "Price",
                value: 1130.334573546505m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1293.570102713902m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1199.6641165947m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 952.98055522583886m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1213.048731460163m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1174.941148675556m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1150.974373235742m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1086.015297016326m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1074.96369451937m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 958.62830067500282m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1265.314667207721m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 108,
                column: "Price",
                value: 1233.970481928144m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 109,
                column: "Price",
                value: 999.471399813043m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1059.790040878104m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 111,
                column: "Price",
                value: 1257.578692662294m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1089.622623355703m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 967.842344698986m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1051.132425478663m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 115,
                column: "Price",
                value: 1272.040434988716m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1245.257582061428m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1247.119823009724m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1142.398619135133m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1292.939944096527m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1009.0312033483492m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 121,
                column: "Price",
                value: 998.58102143732m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1189.191466659947m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1274.566605825222m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1296.538134979654m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1245.695394855009m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 126,
                column: "Price",
                value: 1259.758959806314m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 963.3131336211626m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1116.108249009475m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1268.656292600132m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 130,
                column: "Price",
                value: 1234.518239662915m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 131,
                column: "Price",
                value: 972.3442804712439m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1051.420173426032m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1029.3490737380984m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1153.237286907096m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1220.084201764098m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1185.274355301046m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1092.768406283787m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 963.1554428777573m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 985.1860660767161m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1006.3549306121749m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1136.720706733279m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1185.492897964722m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1299.810351371177m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1000.7976618345146m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1075.298701969937m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1264.533846941229m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1182.164661732739m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1254.529793245452m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1170.840305702622m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 978.797547549421m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 151,
                column: "Price",
                value: 1259.302025877819m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 152,
                column: "Price",
                value: 1280.964029569981m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1077.593299790615m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1035.2574889129555m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1021.2753861032877m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1077.57101918659m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1141.060244962752m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1204.005636893351m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1213.584069572931m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1003.9009201391586m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1077.386028306449m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1067.975335046151m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1212.182010210178m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 951.64714035275149m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 966.3381869441706m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1295.677119522306m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1223.351715295695m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1121.583312293192m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 169,
                column: "Price",
                value: 960.1517784912246m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1279.634909805972m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 171,
                column: "Price",
                value: 1154.036727768767m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1144.758138046779m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 995.2463610178636m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1000.7503641964951m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1125.680107571943m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1141.413210154803m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1124.235967844622m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 985.4171446695433m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 179,
                column: "Price",
                value: 1046.3470149646075m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 180,
                column: "Price",
                value: 1188.172997675865m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 181,
                column: "Price",
                value: 1088.290003877688m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1084.229326968492m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 183,
                column: "Price",
                value: 1137.66565379753m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1159.697924216486m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1254.592423466761m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1046.5507889976448m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1088.756085917677m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1110.812434695222m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1097.847929622859m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1003.4899216393482m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1188.818385793618m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1292.434714936102m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1053.386158412543m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1274.140480072027m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1171.100669772006m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1128.499069454367m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1155.433640672304m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1045.6437306155307m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1194.488996541871m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1224.494526764142m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1115.96122319344m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1164.569113253056m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 967.6124456855167m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 204,
                column: "Price",
                value: 1252.856830149075m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1161.105958355847m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1213.568284584116m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 972.7762378544146m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 978.4465943800875m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1171.621025117276m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1011.2616896539046m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1248.079650889772m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1216.62650113593m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1161.00758779114m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1183.066113383223m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1283.499184374756m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1138.437407063048m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1038.3383903548585m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1199.764026327167m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1290.595812978386m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1016.9928325062568m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1210.943818528124m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 964.6656925326m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1163.44176055875m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1029.5444885338926m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1250.208787793726m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1189.403803719289m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 974.8030479863582m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1239.992929006375m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1084.83409503004m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1042.3732951314442m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1214.999967404053m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1115.304980966832m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1000.3356419433025m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1011.2911669275432m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 235,
                column: "Price",
                value: 1046.2144476780797m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 236,
                column: "Price",
                value: 1143.705285236761m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1232.348191777573m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 238,
                column: "Price",
                value: 1173.669690137481m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1050.192847678751m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 240,
                column: "Price",
                value: 954.26532778686603m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 950.379728312543914m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1091.000167227825m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1184.7006326942m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1211.361050104094m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1143.52629481243m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1148.881472306048m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1295.210181098516m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 248,
                column: "Price",
                value: 1104.020526276769m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 982.2157544017597m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 250,
                column: "Price",
                value: 1153.714553315302m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1032.4428948374623m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1152.520002477929m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1289.461289855325m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 971.3871750799225m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1236.129846156239m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1088.805025986903m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1030.5609070030105m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1201.32010004332m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 968.9260090094999m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1216.097941466745m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1059.725613778846m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1280.158703369801m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1010.1728869471955m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1194.473699940324m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1274.614150876926m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 992.2710384339423m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1098.488503680929m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1057.947461374699m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1247.06043857391m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 973.9979624270961m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 271,
                column: "Price",
                value: 1229.429626271119m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1160.71322257755m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 273,
                column: "Price",
                value: 1157.053790469818m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1087.27005406821m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1137.280422763091m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1062.202504741255m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1080.129758426512m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 976.5292060920343m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 279,
                column: "Price",
                value: 1138.004628852019m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1066.161458606177m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1238.409095368397m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 282,
                column: "Price",
                value: 1044.7343715909254m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 963.029507012256m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1286.052845078095m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1255.831065973792m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1000.1883445213885m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1273.504171174405m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1268.716914506095m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1234.219019330262m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1124.638054652858m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1051.802434077566m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1202.205426982057m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1240.174018383114m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1180.334198848601m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1000.6663268227695m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1215.512073645094m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1208.753432655893m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1189.109422420393m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1002.5929598619649m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1168.35082658335m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1052.729585560226m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 997.9331965215729m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 962.5346972247543m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1085.422794905434m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1096.146557070159m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1096.780118341476m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 993.9652039584312m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1275.737529896399m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1171.359524826002m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1179.138281172347m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1265.469115355643m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1294.475811027102m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1047.9192534675734m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1209.409795446497m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1170.8423384036m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 316,
                column: "Price",
                value: 1081.470699678609m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1044.6472931669712m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 961.5239044612155m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1095.068209540572m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 320,
                column: "Price",
                value: 1200.248889716615m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 321,
                column: "Price",
                value: 1261.316901124121m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 963.3050234811697m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1190.686263851369m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 970.3613459766792m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1285.83693725111m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1065.0820481499m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1069.77514721053m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1164.187184839217m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1005.9133389235019m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1085.372929814555m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1144.674369927811m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 332,
                column: "Price",
                value: 1273.465049711017m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1281.257236382717m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1244.822218718698m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 991.446371060154m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1187.190778923845m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1092.180188971203m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1003.7825780605322m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1084.242467044994m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1062.042565942411m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1131.521977632516m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 995.8083344440306m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1131.841472037248m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 344,
                column: "Price",
                value: 1278.355185211284m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1040.0047269728461m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1094.275089869585m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1063.803181659553m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1032.9523949807154m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1146.502109505549m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 350,
                column: "Price",
                value: 1253.727503547132m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1079.827289618176m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 980.9126533088277m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1052.627248605023m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1291.059578141161m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1111.069230308357m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1119.14807313949m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1024.1470724099667m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1195.418433816437m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 987.8274251217717m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1057.918679035917m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 361,
                column: "Price",
                value: 1174.836626650207m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1182.457300141668m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1058.1955144596m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1031.3588249177244m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1244.318855591895m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 366,
                column: "Price",
                value: 1030.4580664695116m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1180.919030953321m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1117.269658893082m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1253.152914656277m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1063.45993990335m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1100.407263781748m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 372,
                column: "Price",
                value: 1117.905940001368m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1284.174676415726m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 990.2536865138927m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1002.8162013006m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1147.404448347229m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1112.87533450406m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 378,
                column: "Price",
                value: 1167.600429650201m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1043.5722535642838m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1078.982811445113m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1283.939292563404m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1054.663032054011m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 958.04979072696365m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1109.352046490506m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1197.967401444012m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 386,
                column: "Price",
                value: 1152.956992617262m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1241.292142052267m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1108.168559780764m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 389,
                column: "Price",
                value: 993.9173600536828m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1071.652595643471m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1042.3884035630346m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1187.796643992025m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 983.9406403811721m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 394,
                column: "Price",
                value: 1174.204935787654m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1089.346307106073m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1032.7877310115122m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1233.259351816936m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1135.690254433333m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1105.878236440899m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 950.0580086530529988m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1105.22379023283m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1021.5049803744044m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1116.688525529959m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1053.55757372215m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 405,
                column: "Price",
                value: 1258.928464049956m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1289.188326926071m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 956.25612595589816m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1024.0182085968607m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1055.373676306653m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 410,
                column: "Price",
                value: 974.5096576907415m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1057.792894160344m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 961.7115043527548m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 413,
                column: "Price",
                value: 1104.742662524204m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1197.866835898288m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 961.0336160301318m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1159.283307605819m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1280.46388309046m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1148.489010145891m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 419,
                column: "Price",
                value: 991.5904779408219m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1287.374736402517m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 955.48298289355923m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1201.656853149244m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1110.799940384596m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1257.936708108315m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 986.0373676050138m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1273.531971933033m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1067.367668073164m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1008.9197592017616m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1286.151742434444m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1012.516652158381m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1044.2156596658526m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1032.3335642117858m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 961.5801093526678m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 965.4924847129281m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1032.6836578127501m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1021.5970770100982m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1148.604037775039m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1029.3474432969738m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1089.255496004061m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1019.2091094700685m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1010.4772927406505m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1009.1366762850161m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1019.2613368654454m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1196.511254750712m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1064.37262369547m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1265.47653543262m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1066.052128126357m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1005.7552278594337m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1171.907050716328m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1278.761572850566m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1265.803964486118m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1219.476937069263m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1018.5849984464231m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 952.04088885754825m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1035.0152938875416m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1227.303289227259m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1073.156810865831m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 458,
                column: "Price",
                value: 1003.2865511253974m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1258.866779966513m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1066.759026481418m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1263.908943507582m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1090.856975635443m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1158.452222705728m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1190.447887070668m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 991.4963198944159m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1081.430235858785m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 467,
                column: "Price",
                value: 1149.834838065398m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1234.63464619392m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1174.128068235892m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1027.8950297772882m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 974.8025965127498m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1153.291481244121m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1015.6945821476025m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 985.6746363724604m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1127.14976140999m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 958.81883302897684m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1178.957748919824m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1197.986321658063m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1268.865371515123m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1225.813688684079m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1116.803745709259m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1139.286962702396m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1231.99106672296m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1269.804097867436m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1099.021330389692m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1032.6338718166472m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1017.9360440095356m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1295.5426056728m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1220.049963108599m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1209.292866597184m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1068.291745321874m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1039.2664218014008m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1280.001998417654m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 964.4515062925325m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1030.2597394477683m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1102.049645625784m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 961.8031473810998m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 998.2056594683592m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1122.633675595074m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1061.613530588501m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 501,
                column: "Price",
                value: 1297.998395179689m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1053.927296606962m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1068.232429528314m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 950.14897906982394m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 971.2145621712793m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1011.6275597774061m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1296.40158370464m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1018.834550499714m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1134.059860402653m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1058.15085718116m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 991.8570812513181m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1200.628509211214m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1102.633263212849m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 986.0119008558169m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 994.8494456160911m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1082.698682025501m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1025.0967363199848m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1131.923404322325m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1195.122175897476m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1026.4447565770079m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 521,
                column: "Price",
                value: 1245.594355110689m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1027.7023406458441m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1226.077690275385m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 962.7659932773961m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 967.3854929396181m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1041.0851861004312m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1282.969768466434m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1044.1942295814982m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1012.7159413561143m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 998.7065523476105m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1130.129581114768m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1083.571975997068m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 533,
                column: "Price",
                value: 1064.16916377798m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1210.180830127974m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1113.461328279224m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1017.1367299861928m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1037.5562368365625m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1161.323737611609m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1247.918299351016m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 998.6347081452359m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1265.030307959199m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1242.339463858345m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1111.712921460247m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 971.9638786123474m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 998.2848787618781m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1060.962523678177m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1070.823591959221m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1219.966106615829m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 991.3621298067816m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1151.061672320129m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1085.537323684739m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 552,
                column: "Price",
                value: 1032.4299996760476m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1022.5288951466013m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 967.1821089074085m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1025.0588458323766m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1165.175469214304m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 557,
                column: "Price",
                value: 975.5879645485304m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1130.649758920964m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1240.179953448279m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1222.269657463246m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1257.647996567478m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1129.339772848657m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1222.663617088796m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1110.07017930006m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1214.533170571003m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1278.50847648653m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 978.3806165181548m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1294.70567298087m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1030.7184008146662m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1005.01528293419m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1161.380597002673m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1002.2470394711443m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 573,
                column: "Price",
                value: 951.90715679241605m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1082.445061193555m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1236.101803252556m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 974.423974967253m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1038.8695833430092m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1081.126290111912m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1154.669054969504m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1280.612753103172m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1101.584221619001m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 975.0323837743948m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 951.66267949452005m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1160.914442981054m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1146.877537818718m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1150.502568089149m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1015.0839883233148m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1087.457837242764m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1209.568089347028m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1068.800964815515m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1208.495665436625m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1137.972698092104m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1144.623335202662m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 978.2235188309778m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9460790935150054761904761905m, 1008, 953.64772626312552m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6212705335984826254826254826m, 777, 1259.727204606021m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.885212879428326697247706422m, 1090, 964.8820385768761m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2456582332505041128084606345m, 851, 1060.055156496179m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0370870990560622377622377622m, 1001, 1038.1241861551183m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3801096859966252702702702703m, 740, 1021.2811676375027m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4696669577575846338535414166m, 833, 1224.232575812068m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.176995794877672147001934236m, 1034, 1217.013651903513m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0322319301728172541743970315m, 1078, 1112.746020726297m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4153681126043060863095238095m, 672, 951.12737167009369m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4581266135723462857142857143m, 875, 1275.860786875803m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4283013610255571260306242638m, 849, 1212.627855510698m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1855193500354739382239382239m, 1036, 1228.198046636751m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5453094085204071782178217822m, 808, 1248.610002084489m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5461500233451098626716604245m, 801, 1238.466168699433m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5299829404189463087248322148m, 745, 1139.837290612115m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3017336995786002304147465438m, 868, 1129.904851234225m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.274825704900173469387755102m, 882, 1124.396271721953m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6693485487083367875647668394m, 772, 1288.737079602836m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4173224677871576576576576577m, 888, 1258.582351394996m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3555728626255458563535911602m, 905, 1226.793440676119m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3294764471826647331786542923m, 862, 1146.008697471457m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3872281785463121516164994426m, 897, 1244.343676156042m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3860222747308634146341463415m, 820, 1136.538265279308m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4616273043026831812255541069m, 767, 1121.068142400158m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9600819315762374429223744292m, 1095, 1051.28971507598m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3962049803916891701828410689m, 711, 992.701741058491m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4530656692375680456490727532m, 701, 1018.5990341355352m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4698113092137447887323943662m, 710, 1043.5660295417588m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1595042123487897959183673469m, 980, 1136.314128101814m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1188313027200547671840354767m, 902, 1009.1858350534894m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2095069638133204747774480712m, 1011, 1222.811540415267m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5988273588722806770098730606m, 709, 1133.568597440447m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1901784483662203548085901027m, 1071, 1274.681118200222m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9341596018062167304015296367m, 1046, 977.1309434893027m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3722936258985527272727272727m, 825, 1132.142241366306m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6732015843753732193732193732m, 702, 1174.587512231512m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9833613153618133911368015414m, 1038, 1020.7290453455623m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1967838446983375661375661376m, 945, 1130.960733239929m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3883897225117712264150943396m, 848, 1177.354484689982m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9236597599216736213235294118m, 1088, 1004.9418187947809m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2670696123425136554621848739m, 952, 1206.250270950073m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1655716261092502351834430856m, 1063, 1239.002638554133m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1516167146452658285714285714m, 875, 1007.6646253146076m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.261265733205687799043062201m, 836, 1054.418152959955m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1666019586628353080568720379m, 844, 984.612053111433m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.504074691620378561736770692m, 737, 1108.503047724219m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1640931171998692307692307692m, 858, 998.7918945574878m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3539554236311906519065190652m, 813, 1100.765759412158m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1061117436531381381381381381m, 999, 1105.005631909485m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1544398242314428044280442804m, 1084, 1251.412769466884m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.095095737971090169133192389m, 946, 1035.9605681206513m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.519728577639122354694485842m, 671, 1019.7378755958511m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2978617607625017421602787456m, 861, 1117.458976016514m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5911076586240142045454545455m, 704, 1120.139791671306m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5651913055523466076696165192m, 678, 1061.199705164491m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3646769697791914110429447853m, 815, 1112.211730370041m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1582060247301325678496868476m, 958, 1109.561371691467m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.945370404102055019305019305m, 1036, 979.403738649729m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3213802575460622065727699531m, 852, 1125.815979429245m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6855191083850113314447592068m, 706, 1189.976490519818m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.285726379627080188679245283m, 848, 1090.295969923764m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.584395781500215429403202329m, 687, 1088.479901890648m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2961459482108089622641509434m, 848, 1099.131764082766m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1559358116135927687916270219m, 1051, 1214.888538005886m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8827856743480747178538390379m, 1081, 954.29131397026877m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9767744298674573446327683616m, 1062, 1037.3344445192397m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1137503691410656716417910448m, 1005, 1119.319120986771m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4289940053449802955665024631m, 812, 1160.343132340124m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1202339275431256599788806758m, 947, 1060.86152938334m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6160608287460684410646387833m, 789, 1275.071993880648m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0664034109242770475227502528m, 989, 1054.67297340411m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1276753381342459791863765374m, 1057, 1191.952832407898m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2489508281010235546038543897m, 934, 1166.520073446356m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8855208265529864864864864865m, 666, 1255.756870484289m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0168468476728224924012158055m, 987, 1003.6278386530758m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0195634516918029878618113912m, 1071, 1091.952456761921m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2068695385970393198724760893m, 941, 1135.664235819814m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7006217848546838440111420613m, 718, 1221.046441525663m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0789088859359923809523809524m, 945, 1019.5688972095128m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0038046660305257560975609756m, 1025, 1028.8997826812889m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4508253730611195795006570302m, 761, 1104.078108899512m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1544604961721908831908831909m, 1053, 1215.646902469317m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1869293436088232848232848233m, 962, 1141.826028551688m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2777591078091834061135371179m, 916, 1170.427342753212m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4973348653202847283406754772m, 681, 1019.6850432831139m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5784349776392259810554803789m, 739, 1166.463448475388m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9826877341889462153846153846m, 975, 958.12054083422256m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2562028021276875621890547264m, 1005, 1262.483816138326m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9671050004747899209486166008m, 1012, 978.7102604804874m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0658157363190713577799801784m, 1009, 1075.408077945943m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0550394424239363163371488033m, 961, 1013.8929041694028m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0941575053416315789473684211m, 1026, 1122.605600480514m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3744852476543058064516129032m, 775, 1065.226066932087m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3169564880804207459207459207m, 858, 1129.948666773001m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4556900946532203369065849923m, 653, 950.56563180855288m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4417532825848278061224489796m, 784, 1130.334573546505m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4215056073779142857142857143m, 910, 1293.570102713902m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1056812134513364055299539171m, 1085, 1199.6641165947m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3036669702131858549931600547m, 731, 952.98055522583886m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1037750058782192902638762511m, 1099, 1213.048731460163m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3011529885665071982281284607m, 903, 1174.941148675556m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1362037248131707798617966436m, 1013, 1150.974373235742m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0412418955094209012464046021m, 1043, 1086.015297016326m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1460167318969829424307036247m, 938, 1074.96369451937m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0330046343480633836206896552m, 928, 958.62830067500282m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2237085756360938104448742747m, 1034, 1265.314667207721m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1510918674702835820895522388m, 1072, 1233.970481928144m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.101953031767412348401323043m, 907, 999.471399813043m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0319279852756611489776046738m, 1027, 1059.790040878104m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3849985602007643171806167401m, 908, 1257.578692662294m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0874477278999031936127744511m, 1002, 1089.622623355703m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9717292617459698795180722892m, 996, 967.842344698986m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1550905774490802197802197802m, 910, 1051.132425478663m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9099706231061801801801801802m, 666, 1272.040434988716m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1434872195238089990817263545m, 1089, 1245.257582061428m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9098312756657335375191424196m, 653, 1247.119823009724m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5396207805055700808625336927m, 742, 1142.398619135133m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3384471470978540372670807453m, 966, 1292.939944096527m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9609820984269992380952380952m, 1050, 1009.0312033483492m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0315919642947520661157024793m, 968, 998.58102143732m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3272226190401194196428571429m, 896, 1189.191466659947m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.286141882770153380423814329m, 991, 1274.566605825222m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2185508787402763157894736842m, 1064, 1296.538134979654m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.190913379402494263862332696m, 1046, 1245.695394855009m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3904624280422891832229580574m, 906, 1259.758959806314m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1606182332785091566265060241m, 830, 963.3131336211626m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6082251426649495677233429395m, 694, 1116.108249009475m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2401332283481251221896383187m, 1023, 1268.656292600132m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2740126312310784313725490196m, 969, 1234.518239662915m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2710382751258090196078431373m, 765, 972.3442804712439m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1009635323832795811518324607m, 955, 1051.420173426032m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9710840318283947169811320755m, 1060, 1029.3490737380984m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1056925090192674976030680729m, 1043, 1153.237286907096m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2539405979076032887975334018m, 973, 1220.084201764098m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2953818090721814207650273224m, 915, 1185.274355301046m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0165287500314297674418604651m, 1075, 1092.768406283787m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9602746190206952143569292124m, 1003, 963.1554428777573m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9802846428624040796019900498m, 1005, 985.1860660767161m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2658552586316665408805031447m, 795, 1006.3549306121749m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4191269746982259675405742821m, 801, 1136.720706733279m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.769392385021973134328358209m, 670, 1185.492897964722m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6793415392392467700258397933m, 774, 1299.810351371177m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0414127594531889698231009365m, 961, 1000.7976618345146m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5361410028141957142857142857m, 700, 1075.298701969937m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6422517492743233766233766234m, 770, 1264.533846941229m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5996815449698768606224627876m, 739, 1182.164661732739m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5317824093351062271062271062m, 819, 1254.529793245452m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3038310753926748329621380846m, 898, 1170.840305702622m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9147640631303m, 1070, 978.797547549421m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3823293368581986827661909989m, 911, 1259.302025877819m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3371232041440302713987473904m, 958, 1280.964029569981m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1475966983925612353567625133m, 939, 1077.593299790615m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0739185569636467842323651452m, 964, 1035.2574889129555m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4887396298881744897959183673m, 686, 1021.2753861032877m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9885972653087981651376146789m, 1090, 1077.57101918659m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4035181364855498154981549815m, 813, 1141.060244962752m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7758195234415206489675516224m, 678, 1204.005636893351m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1568961578388284080076263108m, 1049, 1213.584069572931m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0233444649736581039755351682m, 981, 1003.9009201391586m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4539622514257071524966261808m, 741, 1077.386028306449m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3039991880905384615384615385m, 819, 1067.975335046151m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.806530566632157973174366617m, 671, 1212.182010210178m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1195848710032370470588235294m, 850, 951.64714035275149m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8873628897558958677685950413m, 1089, 966.3381869441706m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3813188907487270788912579957m, 938, 1295.677119522306m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2521511927284493346980552712m, 977, 1223.351715295695m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4738282684536031537450722733m, 761, 1121.583312293192m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0923228424246013651877133106m, 879, 960.1517784912246m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2619673666725562130177514793m, 1014, 1279.634909805972m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4318073545518200992555831266m, 806, 1154.036727768767m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2663253739455519911504424779m, 904, 1144.758138046779m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3540766816569572789115646259m, 735, 995.2463610178636m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0295785639881636831275720165m, 972, 1000.7503641964951m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4969150366648178191489361702m, 752, 1125.680107571943m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4746940699674457364341085271m, 774, 1141.413210154803m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3710194729812463414634146341m, 820, 1124.235967844622m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4930562798023383333333333333m, 660, 985.4171446695433m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1202858832597510706638115632m, 934, 1046.3470149646075m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2789806218254736275565123789m, 929, 1188.172997675865m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1577553232741361702127659574m, 940, 1088.290003877688m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2265037635390180995475113122m, 884, 1084.229326968492m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2219824423174328678839957035m, 931, 1137.66565379753m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3375985285080576701268742791m, 867, 1159.697924216486m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6043381374255255754475703325m, 782, 1254.592423466761m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0321013698201625246548323471m, 1014, 1046.5507889976448m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2586775559741930635838150289m, 865, 1088.756085917677m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5279400752341430536451169188m, 727, 1110.812434695222m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1691671241989978700745473908m, 939, 1097.847929622859m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9925716336689893175074183976m, 1011, 1003.4899216393482m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0906590695354293577981651376m, 1090, 1188.818385793618m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6938856027996094364351245085m, 763, 1292.434714936102m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1018683665403169456066945607m, 956, 1053.386158412543m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.59267560009003375m, 800, 1274.140480072027m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2812917612385185995623632385m, 914, 1171.100669772006m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1140168503991776900296150049m, 1013, 1128.499069454367m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1671046875477818181818181818m, 990, 1155.433640672304m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9939579188360557984790874525m, 1052, 1045.6437306155307m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8320383382544033742331288344m, 652, 1194.488996541871m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5902526321612233766233766234m, 770, 1224.494526764142m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.315992008482830188679245283m, 848, 1115.96122319344m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.302650014824447427293064877m, 894, 1164.569113253056m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9695515487830828657314629259m, 998, 967.6124456855167m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8157345364479347826086956522m, 690, 1252.856830149075m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5606262881126975806451612903m, 744, 1161.105958355847m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3574589313021431767337807606m, 894, 1213.568284584116m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4077803731612367583212735166m, 691, 972.7762378544146m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2005479685645245398773006135m, 815, 978.4465943800875m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7997250769850629800307219662m, 651, 1171.621025117276m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2302453645424630170316301703m, 822, 1011.2616896539046m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4007627956114163860830527497m, 891, 1248.079650889772m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3716195052265276211950394589m, 887, 1216.62650113593m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1271918328069320388349514563m, 1030, 1161.00758779114m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3413447997542210884353741497m, 882, 1183.066113383223m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2365117383186473988439306358m, 1038, 1283.499184374756m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1760717015114132231404958678m, 968, 1138.437407063048m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.045657996329162638469284995m, 993, 1038.3383903548585m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7164006099101101573676680973m, 699, 1199.764026327167m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.480041069929341743119266055m, 872, 1290.595812978386m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0473664598416650875386199794m, 971, 1016.9928325062568m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4803714162935501222493887531m, 818, 1210.943818528124m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0143698133886435331230283912m, 951, 964.6656925326m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3161105888673642533936651584m, 884, 1163.44176055875m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0537814621636567041965199591m, 977, 1029.5444885338926m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4470009117982939814814814815m, 864, 1250.208787793726m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1147177167003645735707591378m, 1067, 1189.403803719289m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0515674735559419633225458468m, 927, 974.8030479863582m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4553907617445715962441314554m, 852, 1239.992929006375m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3594412218421553884711779449m, 798, 1084.83409503004m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4537981800996432357043235704m, 717, 1042.3732951314442m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1705201998112263969171483622m, 1038, 1214.999967404053m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3167709338451381345926800472m, 847, 1115.304980966832m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.095657877265391566265060241m, 913, 1000.3356419433025m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3796605278684081855388813097m, 733, 1011.2911669275432m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5031816776983903735632183908m, 696, 1046.2144476780797m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0511997106955523897058823529m, 1088, 1143.705285236761m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3395089041060576086956521739m, 920, 1232.348191777573m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1072355567334726415094339623m, 1060, 1173.669690137481m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0166436085951122942884801549m, 1033, 1050.192847678751m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2360949841798782772020725389m, 772, 954.26532778686603m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2472174912238109107611548556m, 762, 950.379728312543914m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4527299164152130492676431425m, 751, 1091.000167227825m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2603198220151063829787234043m, 940, 1184.7006326942m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2644687370606409185803757829m, 958, 1211.361050104094m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1156354095731024390243902439m, 1025, 1143.52629481243m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.304065235307659477866061294m, 881, 1148.881472306048m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7109777821644861294583883752m, 757, 1295.210181098516m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1334913000788182751540041068m, 974, 1104.020526276769m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9086177191505640148011100833m, 1081, 982.2157544017597m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.115778097983851063829787234m, 1034, 1153.714553315302m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.538663032544653204172876304m, 671, 1032.4428948374623m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2017935375160886339937434828m, 959, 1152.520002477929m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4958947678136020881670533643m, 862, 1289.461289855325m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.188968390550700734394124847m, 817, 971.3871750799225m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4094981142032371721778791334m, 877, 1236.129846156239m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1925575312014271631982475356m, 913, 1088.805025986903m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.059158177803710688591983556m, 973, 1030.5609070030105m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6592819061371823204419889503m, 724, 1201.32010004332m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.293626180253003871829105474m, 749, 968.9260090094999m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5875952238469255874673629243m, 766, 1216.097941466745m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2630817804277067938021454112m, 839, 1059.725613778846m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4129787012911710816777041943m, 906, 1280.158703369801m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3876001194329608516483516484m, 728, 1010.1728869471955m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3405989898320134680134680135m, 891, 1194.473699940324m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1956980777457091932457786116m, 1066, 1274.614150876926m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9423276718271056980056980057m, 1053, 992.2710384339423m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3061694455183460166468489893m, 841, 1098.488503680929m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.024150495038430784123910939m, 1033, 1057.947461374699m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4219617315551995438996579247m, 877, 1247.06043857391m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0166993344750481210855949896m, 958, 973.9979624270961m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6934292372880426997245179063m, 726, 1229.429626271119m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1831939068068807339449541284m, 981, 1160.71322257755m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2192347634033909378292939937m, 949, 1157.053790469818m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2526152696638364055299539171m, 868, 1087.27005406821m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2636449141812122222222222222m, 900, 1137.280422763091m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.487678578068984593837535014m, 714, 1062.202504741255m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2191080794881625282167042889m, 886, 1080.129758426512m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2314365776696523329129886507m, 793, 976.5292060920343m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3547674153000226190476190476m, 840, 1138.004628852019m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6252461259240503048780487805m, 656, 1066.161458606177m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8907009089593847328244274809m, 655, 1238.409095368397m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4156292297980018970189701897m, 738, 1044.7343715909254m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4373574731526208955223880597m, 670, 963.029507012256m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2030428859477034611786716558m, 1069, 1286.052845078095m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3969199843979888765294771969m, 899, 1255.831065973792m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0754713381950413978494623656m, 930, 1000.1883445213885m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3101894765168775720164609053m, 972, 1273.504171174405m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3482645212604622741764080765m, 941, 1268.716914506095m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4870108666629662650602409639m, 830, 1234.219019330262m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.481736567395069828722002635m, 759, 1124.638054652858m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0776664283581618852459016393m, 976, 1051.802434077566m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4126973290035922444183313749m, 851, 1202.205426982057m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6190261336594177545691906005m, 766, 1240.174018383114m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3520437558403218785796105384m, 873, 1180.334198848601m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.139711078385842255125284738m, 878, 1000.6663268227695m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1370552606595827876520112254m, 1069, 1215.512073645094m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1500984135641227402473834443m, 1051, 1208.753432655893m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6515408644727680555555555556m, 720, 1189.109422420393m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3475711826101678763440860215m, 744, 1002.5929598619649m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2853144406857535753575357536m, 909, 1168.35082658335m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3531228606172570694087403599m, 778, 1052.729585560226m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.156353646027315063731170336m, 863, 997.9331965215729m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1153356862395762456546929316m, 863, 962.5346972247543m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2348382194601069397042093288m, 879, 1085.422794905434m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0112053109503311808118081181m, 1084, 1096.146557070159m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5557164799169872340425531915m, 705, 1096.780118341476m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.919486775169686586493987049m, 1081, 993.9652039584312m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5538824968287442143727161998m, 821, 1275.737529896399m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4078840442620216346153846154m, 832, 1171.359524826002m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7704778996581786786786786787m, 666, 1179.138281172347m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.291295015669023469387755102m, 980, 1265.469115355643m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.264136534206154296875m, 1024, 1294.475811027102m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.288953571300828290282902829m, 813, 1047.9192534675734m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3790305535307833523375142531m, 877, 1209.409795446497m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1592498400035643564356435644m, 1010, 1170.8423384036m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0050842933816068773234200743m, 1076, 1081.470699678609m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5997661457380875957120980092m, 653, 1044.6472931669712m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9157370518678242857142857143m, 1050, 961.5239044612155m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0439163103341963775023832221m, 1049, 1095.068209540572m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2322883877993993839835728953m, 974, 1200.248889716615m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9345351244234984662576687117m, 652, 1261.316901124121m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9490689886513987192118226601m, 1015, 963.3050234811697m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7009803769305271428571428571m, 700, 1190.686263851369m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9607538078977021782178217822m, 1010, 970.3613459766792m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2119104026871913289349670123m, 1061, 1285.83693725111m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3198042728003717472118959108m, 807, 1065.0820481499m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9868774420761346863468634686m, 1084, 1069.77514721053m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7612514142802072617246596067m, 661, 1164.187184839217m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.063333339242602431289640592m, 946, 1005.9133389235019m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4929476338577097661623108666m, 727, 1085.372929814555m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1102564208805150339476236663m, 1031, 1144.674369927811m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3061179997036071794871794872m, 975, 1273.465049711017m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4396148723401314606741573034m, 890, 1281.257236382717m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8860942707859060606060606061m, 660, 1244.822218718698m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0316819678045306971904266389m, 961, 991.446371060154m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6959868270340642857142857143m, 700, 1187.190778923845m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3669339035934956195244055069m, 799, 1092.180188971203m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.15776537261883760092272203m, 867, 1003.7825780605322m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4873010521879204389574759945m, 729, 1084.242467044994m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2151516772796464530892448513m, 874, 1062.042565942411m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0869567508477579250720461095m, 1041, 1131.521977632516m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9324048075318638576779026217m, 1068, 995.8083344440306m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1901592765901661409043112513m, 951, 1131.841472037248m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3097901487820532786885245902m, 976, 1278.355185211284m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.130439920622658804347826087m, 920, 1040.0047269728461m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.995700718716637852593266606m, 1099, 1094.275089869585m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9960703948123155430711610487m, 1068, 1063.803181659553m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0028664028938984466019417476m, 1030, 1032.9523949807154m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2571295060367861842105263158m, 912, 1146.502109505549m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7174349363659342465753424658m, 730, 1253.727503547132m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3987400124587772020725388601m, 772, 1079.827289618176m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "EuPerKm", "TripPrice" },
                values: new object[] { 1.4684321157317779940119760479m, 980.9126533088277m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5479812479485632352941176471m, 680, 1052.627248605023m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4490006488677452300785634119m, 891, 1291.059578141161m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5157833974193137789904502046m, 733, 1111.069230308357m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3648147233408414634146341463m, 820, 1119.14807313949m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4165243048547257261410788382m, 723, 1024.1470724099667m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1871086731047040714995034757m, 1007, 1195.418433816437m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1844453538630356115107913669m, 834, 987.8274251217717m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.266968477887325748502994012m, 835, 1057.918679035917m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5643630181760412782956058589m, 751, 1174.836626650207m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3544757160843848797250859107m, 873, 1182.457300141668m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4146998856411764705882352941m, 748, 1058.1955144596m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0960242560230865037194473964m, 941, 1031.3588249177244m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3181343809236175847457627119m, 944, 1244.318855591895m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0579651606463158110882956879m, 974, 1030.4580664695116m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4597268614997787391841779975m, 809, 1180.919030953321m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1962201915343490364025695931m, 934, 1117.269658893082m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6086686966062605905006418485m, 779, 1253.152914656277m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0785597767782454361054766734m, 986, 1063.45993990335m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1794290072687545551982851018m, 933, 1100.407263781748m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2617448532746817155756207675m, 886, 1117.905940001368m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1835711303370746543778801843m, 1085, 1284.174676415726m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9135181609906759225092250923m, 1084, 990.2536865138927m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1395638651143181818181818182m, 880, 1002.8162013006m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3975693646129464068209500609m, 821, 1147.404448347229m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0163245063964018264840182648m, 1095, 1112.87533450406m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.173467768492664321608040201m, 995, 1167.600429650201m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2931502522481831474597273854m, 807, 1043.5722535642838m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9962906846215263157894736842m, 1083, 1078.982811445113m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4912186905498304297328687573m, 861, 1283.939292563404m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5131463874519526542324246772m, 697, 1054.663032054011m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2442205074376151298701298701m, 770, 958.04979072696365m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3919097195614880803011292346m, 797, 1109.352046490506m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7488575203562218978102189781m, 685, 1197.967401444012m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4411962407715775m, 800, 1152.956992617262m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6183730665609739243807040417m, 767, 1241.292142052267m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5630021999728688293370944993m, 709, 1108.168559780764m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.08034495658009m, 920, 993.9173600536828m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3935664442697932379713914174m, 769, 1071.652595643471m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3245087719987733163913595934m, 787, 1042.3884035630346m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2145159959018660531697341513m, 978, 1187.796643992025m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9035267588440515151515151515m, 1089, 983.9406403811721m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3590334904949699074074074074m, 864, 1174.204935787654m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2608174850764733796296296296m, 864, 1089.346307106073m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3994413699342983739837398374m, 738, 1032.7877310115122m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7847458058132214182344428365m, 691, 1233.259351816936m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3114206171285600461893764434m, 866, 1135.690254433333m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.38234779555112375m, 800, 1105.878236440899m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8676328846146602728767123288m, 1095, 950.0580086530529988m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2078948527134754098360655738m, 915, 1105.22379023283m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1822974309888939814814814815m, 864, 1021.5049803744044m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5929936170184864479315263909m, 701, 1116.688525529959m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9995802407231024667931688805m, 1054, 1053.55757372215m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5259738958181284848484848485m, 825, 1258.928464049956m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6549272489423247753530166881m, 779, 1289.188326926071m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.160505007228031747572815534m, 824, 956.25612595589816m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3800784482437475741239892183m, 742, 1024.0182085968607m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5894181872088147590361445783m, 664, 1055.373676306653m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.081586745494718645948945616m, 901, 974.5096576907415m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3666574859952764857881136951m, 774, 1057.792894160344m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0487584562189256270447110142m, 917, 961.7115043527548m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "EuPerKm", "TripPrice" },
                values: new object[] { 1.3456061662901388550548112058m, 1104.742662524204m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2569431646361888772298006296m, 953, 1197.866835898288m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1266513669755355216881594373m, 853, 961.0336160301318m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2781513865554785005512679162m, 907, 1159.283307605819m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4550725944209772727272727273m, 880, 1280.46388309046m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1950978253339136316337148803m, 961, 1148.489010145891m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3203601570450358189081225033m, 751, 991.5904779408219m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2510930382920476190476190476m, 1029, 1287.374736402517m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9641604267341667305751765893m, 991, 955.48298289355923m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2609200977431731374606505771m, 953, 1201.656853149244m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2274032490437524861878453039m, 905, 1110.799940384596m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8310577992843013100436681223m, 687, 1257.936708108315m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.096815759293674972191323693m, 899, 986.0373676050138m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1748449925581485239852398524m, 1084, 1273.531971933033m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1872832792804938820912124583m, 899, 1067.367668073164m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3542547103379350335570469799m, 745, 1008.9197592017616m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1886799837656598890942698706m, 1082, 1286.151742434444m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0186284226945482897384305835m, 994, 1012.516652158381m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.579751376196448714069591528m, 661, 1044.2156596658526m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0653597153888398348813209494m, 969, 1032.3335642117858m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3467508534351089635854341737m, 714, 961.5801093526678m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2098903317204612781954887218m, 798, 965.4924847129281m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4606558102019096181046676096m, 707, 1032.6836578127501m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2706431306095748756218905473m, 804, 1021.5970770100982m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0664847147400547818012999071m, 1077, 1148.604037775039m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9926204853394154291224686596m, 1037, 1029.3474432969738m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0870813333373862275449101796m, 1002, 1089.255496004061m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4274637387535973389355742297m, 714, 1019.2091094700685m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0024576316871532738095238095m, 1008, 1010.4772927406505m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9378593645771525092936802974m, 1076, 1009.1366762850161m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9847935621888361352657004831m, 1035, 1019.2613368654454m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1427996702490085959885386819m, 1047, 1196.511254750712m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9818935642947140221402214022m, 1084, 1064.37262369547m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3237202253479288702928870293m, 956, 1265.47653543262m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0681885051366302605210420842m, 998, 1066.052128126357m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4347435490148840228245363766m, 701, 1005.7552278594337m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0931968756682164179104477612m, 1072, 1171.907050716328m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.321034682696865702479338843m, 968, 1278.761572850566m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3581587601782381974248927039m, 932, 1265.803964486118m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.58786059514226953125m, 768, 1219.476937069263m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9484031642890345437616387337m, 1074, 1018.5849984464231m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0880467301229122857142857143m, 875, 952.04088885754825m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4701921788175306818181818182m, 704, 1035.0152938875416m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6320522463128444148936170213m, 752, 1227.303289227259m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1626834353909328277356446371m, 923, 1073.156810865831m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3253455100731801849405548217m, 757, 1003.2865511253974m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.921934015216050381679389313m, 655, 1258.866779966513m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2550106193899035294117647059m, 850, 1066.759026481418m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6183213105090678617157490397m, 781, 1263.908943507582m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0886796164026377245508982036m, 1002, 1090.856975635443m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.062800204317181651376146789m, 1090, 1158.452222705728m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1568978494369951409135082604m, 1029, 1190.447887070668m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0661250751552859139784946237m, 930, 991.4963198944159m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5103774243837779329608938547m, 716, 1081.430235858785m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4836578555682554838709677419m, 775, 1149.834838065398m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1285508648938939670932358318m, 1094, 1234.63464619392m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2307422098908721174004192872m, 954, 1174.128068235892m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0207497813081312810327706058m, 1007, 1027.8950297772882m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4025936640471220143884892086m, 695, 974.8025965127498m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.683637198896527007299270073m, 685, 1153.291481244121m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0503563414142735263702171665m, 967, 1015.6945821476025m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9092939449930446494464944649m, 1084, 985.6746363724604m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2808520016022613636363636364m, 880, 1127.14976140999m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2229832053941031122448979592m, 784, 958.81883302897684m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2502203063836945917285259809m, 943, 1178.957748919824m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4468433836450036231884057971m, 828, 1197.986321658063m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7146829344798959459459459459m, 740, 1268.865371515123m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3726917006540638297872340426m, 893, 1225.813688684079m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0626106048613311132254995243m, 1051, 1116.803745709259m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3579105634116758045292014303m, 839, 1139.286962702396m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5323271974166169154228855721m, 804, 1231.99106672296m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3227126019452458333333333333m, 960, 1269.804097867436m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2646965827269182968929804373m, 869, 1099.021330389692m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.227864294669021640903686088m, 841, 1032.6338718166472m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.938189902312936036866359447m, 1085, 1017.9360440095356m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9052097142247058823529411765m, 680, 1295.5426056728m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.394342814981256m, 875, 1220.049963108599m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3274345407213874862788144896m, 911, 1209.292866597184m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3910048767211901041666666667m, 768, 1068.291745321874m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1320984986943363834422657952m, 918, 1039.2664218014008m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4832004616658794901506373117m, 863, 1280.001998417654m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8946674455403826530612244898m, 1078, 964.4515062925325m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2910523050723913533834586466m, 798, 1030.2597394477683m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.453891353068316622691292876m, 758, 1102.049645625784m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.875959150620309471766848816m, 1098, 961.8031473810998m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1869270623880608799048751486m, 841, 998.2056594683592m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4617625984310859375m, 768, 1122.633675595074m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4154847074513346666666666667m, 750, 1061.613530588501m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4936690393322082853855005754m, 869, 1297.998395179689m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1828589187507991021324354658m, 891, 1053.927296606962m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5526634150120843023255813953m, 688, 1068.232429528314m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4139121712348570535714285714m, 672, 950.14897906982394m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1453001912397161556603773585m, 848, 971.2145621712793m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9436824251654907649253731343m, 1072, 1011.6275597774061m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2405756781862583732057416268m, 1045, 1296.40158370464m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.985333220986183752417794971m, 1034, 1018.834550499714m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4337039954521529709228824273m, 791, 1134.059860402653m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9973146627532139491046182846m, 1061, 1058.15085718116m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4586133547813501470588235294m, 680, 991.8570812513181m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1702032253520604288499025341m, 1026, 1200.628509211214m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4527447473160065876152832675m, 759, 1102.633263212849m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4207664277461338616714697406m, 694, 986.0119008558169m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9696388358831297270955165692m, 1026, 994.8494456160911m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4513387158518780160857908847m, 746, 1082.698682025501m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9772132853384030505243088656m, 1049, 1025.0967363199848m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2067413692135660980810234542m, 938, 1131.923404322325m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1306737709531466414380321665m, 1057, 1195.122175897476m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4621720179159656695156695157m, 702, 1026.4447565770079m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7948045462690043227665706052m, 694, 1245.594355110689m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.500295387804151970802919708m, 685, 1027.7023406458441m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7565582955234742120343839542m, 698, 1226.077690275385m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3695106590005634423897581792m, 703, 962.7659932773961m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4122415955322891970802919708m, 685, 967.3854929396181m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5797954265560412746585735964m, 659, 1041.0851861004312m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3840019077307810140237324703m, 927, 1282.969768466434m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1411958793240417486338797814m, 915, 1044.1942295814982m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1239910558891390677025527192m, 901, 1012.7159413561143m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9511490974739147619047619048m, 1050, 998.7065523476105m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3374314569405538461538461538m, 845, 1130.129581114768m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1564268687268601921024546425m, 937, 1083.571975997068m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.237406004393m, 860, 1064.16916377798m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4903704804531699507389162562m, 812, 1210.180830127974m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1145759041834074074074074074m, 999, 1113.461328279224m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4698507658760011560693641618m, 692, 1017.1367299861928m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2904928318862717661691542289m, 804, 1037.5562368365625m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6566672433831797432239657632m, 701, 1161.323737611609m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6683399723944064171122994652m, 748, 1247.918299351016m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5340010877807003072196620584m, 651, 998.6347081452359m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7969180510784076704545454545m, 704, 1265.030307959199m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.572581599820689873417721519m, 790, 1242.339463858345m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1332445682571325178389398573m, 981, 1111.712921460247m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3424915450446787292817679558m, 724, 971.9638786123474m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1594481751009037166085946574m, 861, 998.2848787618781m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9934106026949222846441947566m, 1068, 1060.962523678177m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0376197596504079457364341085m, 1032, 1070.823591959221m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.317457998505214902807775378m, 926, 1219.966106615829m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5251725073950486153846153846m, 650, 991.3621298067816m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0492813785962889699179580675m, 1097, 1151.061672320129m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6674920486708740399385560676m, 651, 1085.537323684739m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1149352048337447084233261339m, 926, 1032.4299996760476m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1298661824824323756906077348m, 905, 1022.5288951466013m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3757924735525014224751066856m, 703, 967.1821089074085m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5299385758692188059701492537m, 670, 1025.0588458323766m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3707946696638870588235294118m, 850, 1165.175469214304m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9914511834842788617886178862m, 984, 975.5879645485304m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7261828380472732824427480916m, 655, 1130.649758920964m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1336197015066535648994515539m, 1094, 1240.179953448279m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3416790971056487376509330406m, 911, 1222.269657463246m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7228054747499698630136986301m, 730, 1257.647996567478m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6110410454331768901569186876m, 701, 1129.339772848657m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3645799297866026785714285714m, 896, 1222.663617088796m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4141021392357452229299363057m, 785, 1110.07017930006m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2638222378470374609781477627m, 961, 1214.533170571003m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2966617408585496957403651116m, 986, 1278.50847648653m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1336971222690090382387022016m, 863, 978.3806165181548m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3906613028795596133190118153m, 931, 1294.70567298087m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3615830922254507265521796565m, 757, 1030.7184008146662m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9795470593900487329434697856m, 1026, 1005.01528293419m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2847130497817179203539823009m, 904, 1161.380597002673m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0494733397603605235602094241m, 955, 1002.2470394711443m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0159094522864632337246531483m, 937, 951.90715679241605m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5871628463248607038123167155m, 682, 1082.445061193555m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3765053488335812917594654788m, 898, 1236.101803252556m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9638219336965905044510385757m, 1011, 974.423974967253m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9727243289728550561797752809m, 1068, 1038.8695833430092m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2978706964128595438175270108m, 833, 1081.126290111912m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.318115359554228310502283105m, 876, 1154.669054969504m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2150026120523453510436432638m, 1054, 1280.612753103172m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2026028620294770742358078603m, 916, 1101.584221619001m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4029242932005680575539568345m, 695, 975.0323837743948m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3460575381817822489391796322m, 707, 951.66267949452005m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3803976729857954815695600476m, 841, 1160.914442981054m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2630809887871343612334801762m, 908, 1146.877537818718m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4082038777100966952264381885m, 817, 1150.502568089149m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4542750549044624641833810888m, 698, 1015.0839883233148m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1519680479266567796610169492m, 944, 1087.457837242764m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5176513040740627352572145546m, 797, 1209.568089347028m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1087146937920280082987551867m, 964, 1068.800964815515m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3383119218567275747508305648m, 903, 1208.495665436625m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4798084500547516254876462939m, 769, 1137.972698092104m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2241960804306545454545454545m, 935, 1144.623335202662m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0439952175357287086446104589m, 937, 978.2235188309778m });
        }
    }
}
