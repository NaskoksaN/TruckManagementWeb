using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class ChangeNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "d7fad50d-ebf8-4366-ab90-54388cf99cef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dispatcherRoleId",
                column: "ConcurrencyStamp",
                value: "b9aca965-41f2-485e-9977-1168f27e2125");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "managerRoleId",
                column: "ConcurrencyStamp",
                value: "29ef0efc-9c68-4d06-99dd-de71c8aea75e");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClaimValue",
                value: "Admin Admin");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimValue",
                value: "Chief Chiefov");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClaimValue",
                value: "Hans Uno");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "ClaimValue",
                value: "Admin Admin");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0261d5ca-050a-423e-90cb-c7e990f67959",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d588985d-0bc0-4478-9f1d-09e16f2b054a", "Chief Chiefov", "AQAAAAEAACcQAAAAECMnD+k1WraKHg87UzCG//7UcICMAIIEEtYfz77JHGJdspl40Alb/pAzoqRDzdKLfQ==", "1716167d-d011-4797-8e08-cdfc40240d4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19918df1-9468-434b-aaf9-a3d22b2d12e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "840b823c-93a6-48d5-b289-c0653406de68", "AQAAAAEAACcQAAAAEOVEABMTpRxO42Em4oasl3/L+DWuzaYnkqGLE0uVUQe4loOWxht6BMD3DYooPnjw3w==", "9ec15704-d893-47af-ab21-d310a932d038" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62154153-66df-4b35-91ed-56ac983c9a8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3264166b-250f-4d92-ab3e-e3cc7e35af71", "AQAAAAEAACcQAAAAEBdU710xQiJjICEEXtVJf437+Rc2XJCxwbcXaMGUg2tvsEzvCDGr5GMoP+qvRMHzAw==", "8e9c45a2-309c-43d5-a801-935b4d877469" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8041fbf-1246-47fd-ae9a-d9eb4f82a925", "AQAAAAEAACcQAAAAEH5th77tuzHP+bGsuiTu9mGL19zl5N4YOCxEToOCOraOJ09L/zIymLT1nryYpHJc5w==", "da5ed0ff-d9bf-45b4-9ec1-146b8bd1fb0a" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1026.62584938136m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1233.322788945354m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1288.289924580188m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1064.184927352476m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 957.55742606456028m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1170.6026700503m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1263.698210739349m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1187.373225140677m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1190.38775095469m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1279.899257971681m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1259.790402064277m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 1200.970185564297m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1236.094630411535m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1155.411260986387m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1223.870121035836m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1169.825895638562m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1250.48525618123m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1186.654275456949m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1254.225540328305m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1138.550043745191m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1273.80098349376m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                column: "Price",
                value: 1011.8646634545983m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 1156.788376030194m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1296.725331353243m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 1264.370517455684m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 960.0469638633832m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1062.077811404838m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                column: "Price",
                value: 1135.280942644212m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 973.8584356881391m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1048.3106629834873m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1177.718515618221m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1167.095655570293m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1205.781604053378m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 966.4045086893468m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1106.076340886329m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1149.165421586637m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1125.624572417809m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1205.054109811173m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1008.3693885127663m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 982.853459628419m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 982.0933670578144m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1085.983523240347m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1046.1265940836628m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1074.64247468768m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 953.60249033559357m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1264.357979453577m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1139.2546002325m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48,
                column: "Price",
                value: 1168.399953179402m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 972.937522075003m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1246.200368476577m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 975.3220829897518m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1052.142948328783m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1001.2426036095333m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1017.4037198191923m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1187.950664552041m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1076.489251546806m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 57,
                column: "Price",
                value: 1236.616619509779m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 58,
                column: "Price",
                value: 1063.802205961234m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1024.174442223399m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1102.761007970415m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1217.3120915575m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1034.5577005084968m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1127.183100451555m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 960.0386333982423m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1218.131832719772m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1114.32180153394m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 962.9769006596615m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 68,
                column: "Price",
                value: 1049.9504513875003m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 69,
                column: "Price",
                value: 1252.909049691525m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 996.1679399491521m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1184.615078428004m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1113.668239889585m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 73,
                column: "Price",
                value: 1213.152101595968m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1173.440404376449m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1250.628068480336m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1064.632917228477m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1106.057929394154m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1186.512559563449m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1138.61333629047m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 977.9203689046818m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1193.58688731028m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1266.293831863806m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 990.8152458932036m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1060.623962266452m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1049.3509988970514m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1262.776059143265m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1191.929115286823m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1183.019024938505m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1283.42258997774m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1056.845774294313m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1111.832550828044m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1012.481029201473m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1073.349172327833m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1299.703130354536m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1084.135212196368m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1221.368014383631m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1009.9511274794337m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 954.87736931598786m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1033.3028299730979m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1132.815988138666m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 101,
                column: "Price",
                value: 1185.545280605044m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1069.227864979915m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1215.933947077809m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 104,
                column: "Price",
                value: 1285.471824622142m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 105,
                column: "Price",
                value: 1193.759539835669m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1298.522118751352m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1069.876887157639m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1200.73643171303m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1158.299979688543m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1021.13029220679m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1206.569220550547m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1163.977442239777m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1247.166327050781m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1192.16646114371m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1109.182266680406m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1126.377528638575m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1249.841098298566m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1241.488796311812m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1059.745901087047m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 963.3519899113168m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1084.539489093131m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1205.106014307608m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1255.528022908514m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1074.544848649968m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1030.2587251492059m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1226.785818402565m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 127,
                column: "Price",
                value: 1069.894587350213m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 992.1120624534141m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 961.1701139544834m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1231.31397744242m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1277.181098845854m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 991.1211017829426m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1152.840190889211m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1264.180817039698m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1276.554719358273m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1152.301295540839m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 137,
                column: "Price",
                value: 1126.219222636789m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 995.5266876363178m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1293.498744044185m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1111.108383215473m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1114.521057335668m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1076.654469032094m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1026.1823860789152m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1299.617995794012m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1216.34303345067m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1118.926385367075m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1026.6053474155957m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1012.118983567963m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 979.4511953686578m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 982.670659748967m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1075.220225220574m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1107.638648306752m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1221.094208833211m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1248.093101551919m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1272.799434706465m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1245.266042420102m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1264.093534228982m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1179.80889161619m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1041.339889922773m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1184.255177682289m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1276.921064566498m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1023.4840731609427m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 163,
                column: "Price",
                value: 1176.215679448751m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1031.8790006009608m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1187.386909311098m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1172.053053434213m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 972.2246370286498m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1030.4649694607124m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1228.362090875635m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 966.4720631583343m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1191.021600816297m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1198.135231061533m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 979.7239061574434m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 985.7669087503289m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1049.0342673609868m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1227.03746570033m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1044.0001474338941m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1121.164994133873m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1201.12584135331m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1084.442364099988m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 181,
                column: "Price",
                value: 1036.0506202258038m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1170.550099825262m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1225.111769049067m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1072.72515271658m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1088.074649828327m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1069.150430086985m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1267.660837011696m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1105.154534764625m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 958.61004426720889m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1126.068717024009m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1143.941012392712m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1125.188041386222m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1205.732164580272m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 194,
                column: "Price",
                value: 956.05282400079228m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1146.525847809912m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1293.208688107426m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1192.423861772155m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1061.208520385773m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 199,
                column: "Price",
                value: 1099.216780816466m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 200,
                column: "Price",
                value: 1060.616692141994m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1207.834686649395m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1294.931400494929m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1030.6998916647351m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1073.861262390596m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1121.917317551021m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1101.188087613946m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1286.190228610127m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1167.567638569884m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1167.787473159599m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1298.317318817622m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1117.263345604011m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1277.585315608451m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1000.9328418588997m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1246.914354350012m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1152.391523571055m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1148.055326189078m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1205.02839234745m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1225.23641358108m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1239.238982055616m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1001.7652065215724m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1253.95519816666m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1207.559850336242m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1294.404699733866m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 990.8031660081931m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1001.7054752086466m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1108.287216451925m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 958.01970622069176m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 228,
                column: "Price",
                value: 1239.141045347272m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1144.812370026189m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1282.408177104074m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1038.4400925936596m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1027.1584796703328m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1034.2759794447878m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1296.547183587309m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 235,
                column: "Price",
                value: 1280.748182803942m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1165.593076642999m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1066.843461772174m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1059.310521107043m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1242.972251166292m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1061.393703382628m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1047.3191362338174m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1270.278120893341m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1209.762675372828m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1073.624633473066m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1110.368015838472m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1046.8325123539972m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 963.2141965489075m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1057.437572566414m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1044.5446707063482m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1087.841964045449m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1157.796094493168m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1144.242005172318m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1040.8453215908239m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1098.537865911649m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 983.9581351561036m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1039.4429478594562m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1201.300440929128m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1138.846824319901m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1063.141487283838m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1262.220312256501m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 962.5150808205888m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1288.764936869344m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1204.36336272945m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1186.520420392324m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1166.704890371437m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1255.156573318871m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 267,
                column: "Price",
                value: 960.7190818708087m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1231.989190604798m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1081.874501511918m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1230.074358706012m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1262.757835330602m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 272,
                column: "Price",
                value: 1267.109384569519m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1052.231735880632m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1287.613708359716m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1129.335096197816m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1280.203205340605m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1070.648029631917m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1211.316384192899m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1241.586296578501m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1285.893581074744m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1244.640852440432m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1017.5009850924103m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 995.422113627917m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1203.145052989478m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1236.716141003015m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1207.170597733751m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 959.57895842215709m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1059.781154335465m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1049.1082078980986m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1078.644288380041m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1016.0336976823744m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 970.8914657962977m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1298.424348351517m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1231.622710777789m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1150.073275377629m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1155.749318106983m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1206.796327628478m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1150.430164155173m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1013.8871304870518m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1260.519260941828m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1181.230151934566m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1139.7425907469m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1277.247765896234m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1209.133755823178m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 305,
                column: "Price",
                value: 1267.591520396234m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1282.101024458263m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1287.31474336726m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1129.542616424237m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1207.931585661307m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1046.0627079328141m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1016.2840268345764m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1233.170128485435m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1057.683544921708m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1241.012894626934m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1196.328077298204m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1253.804819266851m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1061.64125147881m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1157.851535756461m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1037.3724406239807m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 320,
                column: "Price",
                value: 1038.7542532689953m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1171.815292692055m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1153.437961445986m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 963.9669339072167m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1193.716707691921m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1070.734328143948m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 326,
                column: "Price",
                value: 1249.999024521232m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1011.590774217532m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1233.728588395462m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1188.800930718239m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 963.37932622994m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1047.3784768118697m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 997.1107767089846m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1007.998971074398m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 334,
                column: "Price",
                value: 1259.440032649652m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 335,
                column: "Price",
                value: 1118.918832906113m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1019.9358258406669m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1030.6444353317848m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1110.029078868105m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1250.621726081404m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 975.2388181159264m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1078.526742613044m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1204.815115979391m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1217.651711810965m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1172.80523502638m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1148.019507412179m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1145.340729651822m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1013.0385432847959m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1106.993469005068m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1107.012394202323m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1243.501030812097m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1267.803557139317m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 352,
                column: "Price",
                value: 1069.960685509868m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1220.001725039227m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1199.08241265109m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1282.961635733568m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1113.429397565762m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1108.783252092705m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1073.30358535391m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1228.269157318523m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 360,
                column: "Price",
                value: 1267.970679443197m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1042.4191309639436m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1184.799729865522m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1207.488239890872m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1038.2788045062883m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 953.70880614077801m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1128.538681090996m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 996.3388658307127m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1039.9414643723636m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1088.065599744962m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1029.1890597283027m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 994.73996307288m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 996.879346652464m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1137.53528559332m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 374,
                column: "Price",
                value: 1177.527430907917m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 992.2179028433237m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1240.227281262817m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1132.378631365415m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1111.910455517722m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1094.381520628807m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1236.334042642756m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1193.672739044355m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1190.454815443948m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1031.2119009691462m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 982.5186868764557m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1061.813175057271m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1112.464011383525m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 387,
                column: "Price",
                value: 1063.278264349562m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1254.475400252643m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1029.8010022346445m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1223.607333023038m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1098.740646582708m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1255.010824682368m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 957.65216590336768m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1173.279468110945m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1058.352167905438m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1086.742792307244m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1284.745731839266m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1009.9818061239574m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1137.492446284748m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1162.400260776297m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1249.190861950179m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1251.786374484905m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1289.91160330185m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1164.30795115988m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1100.173197276856m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1112.045320868212m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 407,
                column: "Price",
                value: 1172.361822058872m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1140.0415225726m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1190.841716063837m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1148.913945701068m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1131.550245615456m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 959.01392156832503m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 955.34723273676786m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1030.6637165531879m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1137.881416798787m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1030.2403009911593m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1109.871896978094m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1156.872898475132m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 419,
                column: "Price",
                value: 1075.53500795307m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1027.1920033518978m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1014.1903284050271m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1216.983005757314m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 996.2308791854556m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1244.153392972404m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 994.105895585129m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1201.919134300677m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1042.5703880000276m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1114.880219977635m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1139.945550541339m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1044.5920101480866m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1257.980126537491m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1295.072579321332m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1249.120410562678m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1182.491752957608m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1170.727853617873m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1273.174053899555m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 979.2900446294665m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1198.038696800598m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1219.382697239828m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1146.756170397677m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1094.029126468162m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1010.7149334608478m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1013.1909389408238m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1026.5649656624579m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 445,
                column: "Price",
                value: 1010.9991618227945m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1261.82451838834m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1012.2538678193679m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1171.255446131304m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1069.291681757474m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 987.9235364023881m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1100.754300632222m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1294.863896314161m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 960.4949277389442m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1243.534420141873m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1039.0196172223053m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 980.8930603053683m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1246.00154969927m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1231.441336248621m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1228.091411051617m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 460,
                column: "Price",
                value: 1179.139451205521m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1117.066251093711m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1000.7768591855303m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1192.994025826223m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1273.302822655855m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1118.497780642262m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1038.9798770759049m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1266.509949211601m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 968.6201451350853m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1120.6103934399m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1142.08327199222m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1258.039852855693m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1093.426886790717m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1088.535749644661m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 474,
                column: "Price",
                value: 1229.563616131916m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1202.620772677657m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1235.880002791694m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1145.083449592874m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1295.373837842017m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1190.314316098745m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 480,
                column: "Price",
                value: 1123.230189428845m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1075.182778632585m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1199.917968843835m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1287.572778173669m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1060.542429441336m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1217.92531759266m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1013.2075600299065m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1001.5224104255509m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1248.177594601254m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1192.568923770806m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1058.25505066681m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1247.517041561021m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1159.872774612616m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1148.547707503436m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 494,
                column: "Price",
                value: 1230.631262474508m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1050.375347539848m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1150.77368378906m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1268.01678878865m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 498,
                column: "Price",
                value: 995.9400913178437m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 994.4905763136821m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1096.518902148228m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1249.509407537949m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1093.849083784512m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1117.407969322131m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 504,
                column: "Price",
                value: 1086.923042867253m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1148.252762985214m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1008.8332026978725m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1035.4673728743828m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1172.888504179606m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1053.184750657088m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1059.283172922822m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1190.178596859903m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1009.5846206858847m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1066.379221113552m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 514,
                column: "Price",
                value: 1002.4128810896375m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 515,
                column: "Price",
                value: 1178.88784223764m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1183.538759758386m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1191.217549003691m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1086.848909085317m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1164.732519214095m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1036.4947143872879m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 955.7504377053375m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1221.775832922558m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 523,
                column: "Price",
                value: 1296.345049486251m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1066.245752115223m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1145.228550865561m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1248.884310992507m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 988.008145725089m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1025.3007985358881m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1165.948734864764m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 978.1512474312611m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1092.889130154302m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1229.17007561019m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 998.8924141427185m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1108.270313385746m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 535,
                column: "Price",
                value: 1168.428494513661m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1051.658337207817m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 537,
                column: "Price",
                value: 1091.608237547006m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1107.275420401627m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1031.8128905126093m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1246.352553601561m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1273.957789763545m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 970.4564411150859m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1128.084692645668m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1087.346415762942m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1094.987569243125m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 959.33554131004754m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1226.191440439943m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 548,
                column: "Price",
                value: 987.3154684410437m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1209.210510614287m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1136.47868811211m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 551,
                column: "Price",
                value: 960.4668328651034m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1035.4842104864669m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1040.4647863396279m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1112.051704535727m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1148.533749005062m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 973.2452983270446m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 557,
                column: "Price",
                value: 1229.523769382855m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 960.2124791832306m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1184.79052607562m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 983.2655936668417m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1247.817402790665m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1140.433486337486m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1210.953758670425m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1271.869418288796m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1023.696395565939m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1069.618518403721m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1051.700095257034m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1064.804346495533m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 569,
                column: "Price",
                value: 1173.210423365663m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1097.30866741086m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1054.773582038426m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1022.5205243083593m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 958.20182908972775m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1165.128023260247m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 575,
                column: "Price",
                value: 1288.311391397394m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1047.5509837588804m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1073.871296593078m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1214.883510829874m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1004.8811646426948m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1005.8629884774616m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1158.204148689132m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 986.5421833372248m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1229.462205840132m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1278.414911283964m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 995.243551377164m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 988.6745619494494m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1018.5545377862636m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1040.9363296291817m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1255.066180467038m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 590,
                column: "Price",
                value: 989.8081786686585m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1207.615580558645m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 592,
                column: "Price",
                value: 1108.996036261048m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 965.8082679242577m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1081.654336026776m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5391691894773013493253373313m, 667, 1026.62584938136m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7900185616042873730043541364m, 689, 1233.322788945354m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3647139031569788135593220339m, 944, 1288.289924580188m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4800903022982976356050069541m, 719, 1064.184927352476m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1108554826735038051044083527m, 862, 957.55742606456028m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1741250451858575727181544634m, 997, 1170.6026700503m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9175997128062959028831562974m, 659, 1263.698210739349m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1450079316689267116682738669m, 1037, 1187.373225140677m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3825641706790824622531939605m, 861, 1190.38775095469m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1906039609038893023255813953m, 1075, 1279.899257971681m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2907688545740543032786885246m, 976, 1259.790402064277m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4263303866559346793349168646m, 842, 1200.970185564297m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4874784962834356197352587244m, 831, 1236.094630411535m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0513296278311073703366696997m, 1099, 1155.411260986387m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1870709224401901066925315228m, 1031, 1223.870121035836m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2565262036934070891514500537m, 931, 1169.825895638562m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1567856208892044403330249769m, 1081, 1250.48525618123m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3862783591786787383177570093m, 856, 1186.654275456949m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5796291439903085642317380353m, 794, 1254.225540328305m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6126771157863895184135977337m, 706, 1138.550043745191m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8677433775568328445747800587m, 682, 1273.80098349376m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9257682190801448307410795974m, 1093, 1011.8646634545983m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7796744246618369230769230769m, 650, 1156.788376030194m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.303241539048485427135678392m, 995, 1296.725331353243m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2275441917045475728155339806m, 1030, 1264.370517455684m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9948673200656820725388601036m, 965, 960.0469638633832m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1494348608277467532467532468m, 924, 1062.077811404838m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2741649187926060606060606061m, 891, 1135.280942644212m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0631642311005885371179039301m, 916, 973.8584356881391m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4806647782252645480225988701m, 708, 1048.3106629834873m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3888190042667700471698113208m, 848, 1177.718515618221m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2982154122027730812013348165m, 899, 1167.095655570293m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4668875961719927007299270073m, 822, 1205.781604053378m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9091293590680590780809031044m, 1063, 966.4045086893468m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6682901069175399698340874811m, 663, 1106.076340886329m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0996798292695090909090909091m, 1045, 1149.165421586637m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3948259881261573729863692689m, 807, 1125.624572417809m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3931261385100265895953757225m, 865, 1205.054109811173m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0417039137528577479338842975m, 968, 1008.3693885127663m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.346374602230710958904109589m, 730, 982.853459628419m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1211111496093771689497716895m, 876, 982.0933670578144m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1565319736318924387646432375m, 939, 1085.983523240347m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0762619280696119341563786008m, 972, 1046.1265940836628m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3025969390153696969696969697m, 825, 1074.64247468768m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1700644053197467116564417178m, 815, 953.60249033559357m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7415399166027231404958677686m, 726, 1264.357979453577m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1732797118769309989701338826m, 971, 1139.2546002325m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5537233419938856382978723404m, 752, 1168.399953179402m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9482821852582875243664717349m, 1026, 972.937522075003m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2087297463400358874878758487m, 1031, 1246.200368476577m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0202113838804935146443514644m, 956, 975.3220829897518m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4512316528672868965517241379m, 725, 1052.142948328783m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2754682848529086624203821656m, 785, 1001.2426036095333m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1680869343503929965556831228m, 871, 1017.4037198191923m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4942775654742654088050314465m, 795, 1187.950664552041m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2739517769784686390532544379m, 845, 1076.489251546806m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5753077955538585987261146497m, 785, 1236.616619509779m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0532695108527069306930693069m, 1010, 1063.802205961234m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9500690558658617810760667904m, 1078, 1024.174442223399m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3767303470292322097378277154m, 801, 1102.761007970415m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5871083331910039113428943937m, 767, 1217.3120915575m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5349520779057816023738872404m, 674, 1034.5577005084968m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.460081736336211139896373057m, 772, 1127.183100451555m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1622743745741432203389830508m, 826, 960.0386333982423m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2519340521272065775950668037m, 973, 1218.131832719772m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6291254408390935672514619883m, 684, 1114.32180153394m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0020571286781077003121748179m, 961, 962.9769006596615m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3290512042879750632911392405m, 790, 1049.9504513875003m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5720314299768193224592220828m, 797, 1252.909049691525m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0608817251854654952076677316m, 939, 996.1679399491521m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.350758356246298745724059293m, 877, 1184.615078428004m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5214046993027117486338797814m, 732, 1113.668239889585m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3390199796864988962472406181m, 906, 1213.152101595968m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.07952199114668721251149954m, 1087, 1173.440404376449m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5159128102791951515151515152m, 825, 1250.628068480336m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3241702950602947761194029851m, 804, 1064.632917228477m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1918727687437004310344827586m, 928, 1106.057929394154m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1794359439000487077534791252m, 1006, 1186.512559563449m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4922848444173918741808650066m, 763, 1138.61333629047m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9199627176901992474129821261m, 1063, 977.9203689046818m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5788186340083068783068783069m, 756, 1193.58688731028m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6255376532269653401797175866m, 779, 1266.293831863806m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1629286923629150234741784038m, 852, 990.8152458932036m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5023002298391671388101983003m, 706, 1060.623962266452m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0060891648102122722914669223m, 1043, 1049.3509988970514m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.423648319214503945885005637m, 887, 1262.776059143265m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.635019362533364883401920439m, 729, 1191.929115286823m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3188617892291025641025641026m, 897, 1183.019024938505m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3258497830348553719008264463m, 968, 1283.42258997774m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9942105120360423330197554092m, 1063, 1056.845774294313m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2299032641903141592920353982m, 904, 1111.832550828044m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2897847505751248407643312102m, 785, 1012.481029201473m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0863858019512479757085020243m, 988, 1073.349172327833m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2158120957479289055191768007m, 1069, 1299.703130354536m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0535813529605131195335276968m, 1029, 1084.135212196368m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3076745336013179871520342612m, 934, 1221.368014383631m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0379764927846183967112024666m, 973, 1009.9511274794337m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0267498594795568387096774194m, 930, 954.87736931598786m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1158777861480538876889848812m, 926, 1033.3028299730979m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3648385399261036144578313253m, 830, 1132.815988138666m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.411363429291719047619047619m, 840, 1185.545280605044m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0380853058057427184466019417m, 1030, 1069.227864979915m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3288895596478786885245901639m, 915, 1215.933947077809m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2714854842948981206726013848m, 1011, 1285.471824622142m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8225336486040748091603053435m, 655, 1193.759539835669m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4672566313574598870056497175m, 885, 1298.522118751352m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3822698800486291989664082687m, 774, 1069.876887157639m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.537434611668412291933418694m, 781, 1200.73643171303m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5631578673259689608636977058m, 741, 1158.299979688543m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9606117518408184383819379116m, 1063, 1021.13029220679m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1182291200653818350324374421m, 1079, 1206.569220550547m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6675894587962421203438395415m, 698, 1163.977442239777m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5321453649272493857493857494m, 814, 1247.166327050781m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1246853407016132075471698113m, 1060, 1192.16646114371m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5405309259450083333333333333m, 720, 1109.182266680406m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1528940927723387922210849539m, 977, 1126.377528638575m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6753902121964691689008042895m, 746, 1249.841098298566m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3597905764641971522453450164m, 913, 1241.488796311812m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2001652333941642129105322763m, 883, 1059.745901087047m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.152334916161862200956937799m, 836, 963.3519899113168m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.11578136737976440329218107m, 972, 1084.539489093131m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6111042972026844919786096257m, 748, 1205.106014307608m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4548412779936431054461181924m, 863, 1255.528022908514m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9940285371415060129509713228m, 1081, 1074.544848649968m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0788049478002156020942408377m, 955, 1030.2587251492059m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3909136263067630385487528345m, 882, 1226.785818402565m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.984263649816203311867525299m, 1087, 1069.894587350213m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2834567431480130659767141009m, 773, 992.1120624534141m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9368129765638239766081871345m, 1026, 961.1701139544834m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4234843669854566473988439306m, 865, 1231.31397744242m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6024856949132421580928481807m, 797, 1277.181098845854m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3979141068870840620592383639m, 709, 991.1211017829426m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2724505418203211920529801325m, 906, 1152.840190889211m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3307166495154715789473684211m, 950, 1264.180817039698m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3755977579291734913793103448m, 928, 1276.554719358273m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3275360547705518433179723502m, 868, 1152.301295540839m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2827098207708302961275626424m, 878, 1126.219222636789m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9141659206945067033976124885m, 1089, 995.5266876363178m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4715571604598236632536973834m, 879, 1293.498744044185m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2540726672860869074492099323m, 886, 1111.108383215473m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0799622648601434108527131783m, 1032, 1114.521057335668m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2909526007579064748201438849m, 834, 1076.654469032094m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2514419342425795121951219512m, 820, 1026.1823860789152m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3425805741673677685950413223m, 968, 1299.617995794012m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3590424954756089385474860335m, 895, 1216.34303345067m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0181313788599408553230209281m, 1099, 1118.926385367075m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5164037627999936484490398818m, 677, 1026.6053474155957m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.955730862670408876298394712m, 1059, 1012.118983567963m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8936598497889213503649635036m, 1096, 979.4511953686578m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.475481471094545045045045045m, 666, 982.670659748967m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4569379745536233062330623306m, 738, 1075.220225220574m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7040594589334646153846153846m, 650, 1107.638648306752m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5837797779937885862516212711m, 771, 1221.094208833211m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2047230709960608108108108108m, 1036, 1248.093101551919m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2454006210435078277886497065m, 1022, 1272.799434706465m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3744658304857637969094922737m, 906, 1245.266042420102m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7829245898857291960507757405m, 709, 1264.093534228982m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5010291241936259541984732824m, 786, 1179.80889161619m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4584592295837156862745098039m, 714, 1041.339889922773m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4602406629867928483353884094m, 811, 1184.255177682289m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8452616539978294797687861272m, 692, 1276.921064566498m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0163694867536670307845084409m, 1007, 1023.4840731609427m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0972161188887602611940298507m, 1072, 1176.215679448751m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4762217462102443490701001431m, 699, 1031.8790006009608m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7208505932044898550724637681m, 690, 1187.386909311098m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2083021169424876288659793814m, 970, 1172.053053434213m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2826182546552108179419525066m, 758, 972.2246370286498m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5334300140784410714285714286m, 672, 1030.4649694607124m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3483667298305543358946212953m, 911, 1228.362090875635m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0957733142384742630385487528m, 882, 966.4720631583343m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5568909814592117647058823529m, 765, 1191.021600816297m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6780605477052282913165266106m, 714, 1198.135231061533m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4754878104780774096385542169m, 664, 979.7239061574434m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3729344133012937325905292479m, 718, 985.7669087503289m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0048220951733590038314176245m, 1044, 1049.0342673609868m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6785738244874555403556771546m, 731, 1227.03746570033m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0440001474338941m, 1000, 1044.0001474338941m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2916647397855679723502304147m, 868, 1121.164994133873m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6187679802605256064690026954m, 742, 1201.12584135331m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0249927827032022684310018904m, 1058, 1084.442364099988m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5532992806983565217391304348m, 667, 1036.0506202258038m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5381735871554034165571616294m, 761, 1170.550099825262m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2895913358411231578947368421m, 950, 1225.111769049067m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2053091603557078651685393258m, 890, 1072.72515271658m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1750266196850183585313174946m, 926, 1088.074649828327m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.124238096831740273396424816m, 951, 1069.150430086985m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3095669803839834710743801653m, 968, 1267.660837011696m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3188001608169749403341288783m, 838, 1105.154534764625m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0122598144321107602956705385m, 947, 958.61004426720889m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4797223613981721419185282523m, 761, 1126.068717024009m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7022931732034404761904761905m, 672, 1143.941012392712m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1207052205042051792828685259m, 1004, 1125.188041386222m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2585930736746054279749478079m, 958, 1205.732164580272m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3043012605740685948158253752m, 733, 956.05282400079228m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0441947612112131147540983607m, 1098, 1146.525847809912m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8769356866580928882438316401m, 689, 1293.208688107426m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.252546073290078781512605042m, 952, 1192.423861772155m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9709135593648426349496797804m, 1093, 1061.208520385773m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3291617664044328899637243047m, 827, 1099.216780816466m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.423646566633548993288590604m, 745, 1060.616692141994m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8496702705197473200612557427m, 653, 1207.834686649395m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3391224410495646328852119959m, 967, 1294.931400494929m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2343711277421977245508982036m, 835, 1030.6998916647351m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4037402122752888888888888889m, 765, 1073.861262390596m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5202131674133075880758807588m, 738, 1121.917317551021m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2599406036772837528604118993m, 874, 1101.188087613946m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1799910354221348623853211009m, 1090, 1286.190228610127m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0963076418496563380281690141m, 1065, 1167.567638569884m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4452815261876225247524752475m, 808, 1167.787473159599m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.324813590630226530612244898m, 980, 1298.317318817622m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.184796760979863202545068929m, 943, 1117.263345604011m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8678147889012441520467836257m, 684, 1277.585315608451m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9727238502030123420796890185m, 1029, 1000.9328418588997m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6782158201211467025572005384m, 743, 1246.914354350012m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2092251034323767051416579224m, 953, 1152.391523571055m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3949639443366682867557715674m, 823, 1148.055326189078m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.172206607341877431906614786m, 1028, 1205.02839234745m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3735834232971748878923766816m, 892, 1225.23641358108m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8551481767299640718562874251m, 668, 1239.238982055616m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3610940305999625m, 736, 1001.7652065215724m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4981543586220549581839904421m, 837, 1253.95519816666m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1555596653935330143540669856m, 1045, 1207.559850336242m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6489231843743515923566878981m, 785, 1294.404699733866m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3019752509963115637319316689m, 761, 990.8031660081931m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9114699501443554140127388535m, 1099, 1001.7054752086466m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2259814341282356194690265487m, 904, 1108.287216451925m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4559570003353978115501519757m, 658, 958.01970622069176m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1756556407469373814041745731m, 1054, 1239.141045347272m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1851059731119968944099378882m, 966, 1144.812370026189m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5620075238782874543239951279m, 821, 1282.408177104074m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.131198357945162962962962963m, 918, 1038.4400925936596m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1140547501847427331887201735m, 922, 1027.1584796703328m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2768839252404787654320987654m, 810, 1034.2759794447878m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6391241259005170670037926675m, 791, 1296.547183587309m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5228872566039738406658739596m, 841, 1280.748182803942m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5117938737263281452658884565m, 771, 1165.593076642999m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2822637761684783653846153846m, 832, 1066.843461772174m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2809075224994474002418379686m, 827, 1059.310521107043m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1693059747566246472248353716m, 1063, 1242.972251166292m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4519749704276716826265389877m, 731, 1061.393703382628m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2107735679003669364161849711m, 865, 1047.3191362338174m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.321829470232404786680541103m, 961, 1270.278120893341m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1565608751174263862332695985m, 1046, 1209.762675372828m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2645755400153898704358068316m, 849, 1073.624633473066m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2043037048139609544468546638m, 922, 1110.368015838472m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0183195645466898832684824903m, 1028, 1046.8325123539972m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2774724092160576923076923077m, 754, 963.2141965489075m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1154404773907320675105485232m, 948, 1057.437572566414m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1292374818447007567567567568m, 925, 1044.5446707063482m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0301533750430388257575757576m, 1056, 1087.841964045449m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2979776844093811659192825112m, 892, 1157.796094493168m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2396988138378309859154929577m, 923, 1144.242005172318m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3225480579298905972045743329m, 787, 1040.8453215908239m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3495551178275786240786240786m, 814, 1098.537865911649m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2314870277297917396745932416m, 799, 983.9581351561036m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1384917282140812705366922234m, 913, 1039.4429478594562m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7088199728721593172119487909m, 703, 1201.300440929128m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2724545523127385474860335196m, 895, 1138.846824319901m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4308768334910336473755047106m, 743, 1063.141487283838m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1964173575891004739336492891m, 1055, 1262.220312256501m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3480603372837378151260504202m, 714, 962.5150808205888m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3177555591711083844580777096m, 978, 1288.764936869344m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.220226304690425531914893617m, 987, 1204.36336272945m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2717260668728017148981779207m, 933, 1186.520420392324m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3079651237347948430493273543m, 892, 1166.704890371437m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1568263348561023041474654378m, 1085, 1255.156573318871m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9530943272527864087301587302m, 1008, 960.7190818708087m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1492436479522369402985074627m, 1072, 1231.989190604798m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0473131670008886737657308809m, 1033, 1081.874501511918m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5472633442842918238993710692m, 795, 1230.074358706012m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.48559745333012m, 850, 1262.757835330602m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7031040115181706989247311828m, 744, 1267.109384569519m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9788202194238437209302325581m, 1075, 1052.231735880632m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3398685831006409989594172737m, 961, 1287.613708359716m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5794896450319104895104895105m, 715, 1129.335096197816m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2514205330797702834799608993m, 1023, 1280.203205340605m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1377768646460329436769394261m, 941, 1070.648029631917m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4301256011722538370720188902m, 847, 1211.316384192899m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6710448136991938088829071332m, 743, 1241.586296578501m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9395076637628114630467571644m, 663, 1285.893581074744m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3768151022571150442477876106m, 904, 1244.640852440432m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3938369658800141095890410959m, 730, 1017.5009850924103m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0024391879435216515609264854m, 993, 995.422113627917m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2116264380558690835850956697m, 993, 1203.145052989478m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5998915148810025873221216041m, 773, 1236.716141003015m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1562936759901829501915708812m, 1044, 1207.170597733751m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3947368581717399563953488372m, 688, 959.57895842215709m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5841272860021898355754857997m, 669, 1059.781154335465m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0793294319939286008230452675m, 972, 1049.1082078980986m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0906413431547431749241658241m, 989, 1078.644288380041m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4832608725290137226277372263m, 685, 1016.0336976823744m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9344479940291604427333974976m, 1039, 970.8914657962977m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3208792963901495422177009156m, 983, 1298.424348351517m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7953683830580014577259475219m, 686, 1231.622710777789m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4936016563345831168831168831m, 770, 1150.073275377629m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3148456406222787258248009101m, 879, 1155.749318106983m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.423108876920375m, 848, 1206.796327628478m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0873631041164206049149338374m, 1058, 1150.430164155173m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9646880404253585156993339676m, 1051, 1013.8871304870518m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.291515636210889344262295082m, 976, 1260.519260941828m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5009277661176188055908513342m, 787, 1181.230151934566m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.084436337532730732635585157m, 1051, 1139.7425907469m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.463055860133143184421534937m, 873, 1277.247765896234m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1842642074663839373163565132m, 1021, 1209.133755823178m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7364267402688136986301369863m, 730, 1267.591520396234m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9078884292533675595238095238m, 672, 1282.101024458263m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9043117505432840236686390533m, 676, 1287.31474336726m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2251004516531854663774403471m, 922, 1129.542616424237m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1449588489680635071090047393m, 1055, 1207.931585661307m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.110469965958401380042462845m, 942, 1046.0627079328141m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.230368071228300726392251816m, 826, 1016.2840268345764m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7820377579269291907514450867m, 692, 1233.170128485435m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5762795006284769001490312966m, 671, 1057.683544921708m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2807150615345036119711042312m, 969, 1241.012894626934m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5105152491138939393939393939m, 792, 1196.328077298204m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2244187688152841796875m, 1024, 1253.804819266851m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1270076979605201698513800425m, 942, 1061.64125147881m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3734893662591470937129300119m, 843, 1157.851535756461m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0363361045194612387612387612m, 1001, 1037.3724406239807m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3999383467237133423180592992m, 742, 1038.7542532689953m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4758379001159382871536523929m, 794, 1171.815292692055m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.726703535098781437125748503m, 668, 1153.437961445986m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4134412520633675953079178886m, 682, 963.9669339072167m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1533494760308415458937198068m, 1035, 1193.716707691921m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.64728358175992m, 650, 1070.734328143948m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5299865661214589963280293758m, 817, 1249.999024521232m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3120502908139195849546044099m, 771, 1011.590774217532m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1423412855513537037037037037m, 1080, 1233.728588395462m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7930632439189125188536953243m, 663, 1188.800930718239m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1098840163939400921658986175m, 868, 963.37932622994m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4526747251204850208044382802m, 721, 1047.3784768118697m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9766021319382807051909892262m, 1021, 997.1107767089846m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0069919790953026973026973027m, 1001, 1007.998971074398m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5567861961058739184177997528m, 809, 1259.440032649652m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1890742113773783209351753454m, 941, 1118.918832906113m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1038266513427130952380952381m, 924, 1019.9358258406669m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1901205950713450346420323326m, 866, 1030.6444353317848m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5081916832447078804347826087m, 736, 1110.029078868105m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.766414867346615819209039548m, 708, 1250.621726081404m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1392976847148672897196261682m, 856, 975.2388181159264m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1473688751202595744680851064m, 940, 1078.526742613044m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3124347668620816993464052288m, 918, 1204.815115979391m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.55511074305359514687100894m, 783, 1217.651711810965m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3002275332886696230598669623m, 902, 1172.80523502638m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.731552801526665158371040724m, 663, 1148.019507412179m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2840142709101143497757847534m, 892, 1145.340729651822m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9835325662959183495145631068m, 1030, 1013.0385432847959m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3616155830320639606396063961m, 813, 1106.993469005068m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4156168723814872122762148338m, 782, 1107.012394202323m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.152456933097402224281742354m, 1079, 1243.501030812097m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3573913888001252676659528908m, 934, 1267.803557139317m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1030522531029567010309278351m, 970, 1069.960685509868m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5926915470485992167101827676m, 766, 1220.001725039227m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6561911776948756906077348066m, 724, 1199.08241265109m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5858611072108380716934487021m, 809, 1282.961635733568m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1514264711124736297828335057m, 967, 1113.429397565762m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0153692784731730769230769231m, 1092, 1108.783252092705m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4824635156821961325966850829m, 724, 1073.30358535391m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5411156302616348808030112923m, 797, 1228.269157318523m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2075911232792352380952380952m, 1050, 1267.970679443197m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3825187413314901856763925729m, 754, 1042.4191309639436m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2277717407932870466321243523m, 965, 1184.799729865522m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.707904158261487977369165488m, 707, 1207.488239890872m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5851584801622722137404580153m, 655, 1038.2788045062883m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.024391843330588625134264232m, 931, 953.70880614077801m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2525401565937802441731409545m, 901, 1128.538681090996m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1347823073242741457858769932m, 878, 996.3388658307127m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3865886191631514666666666667m, 750, 1039.9414643723636m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1649524622537066381156316916m, 934, 1088.065599744962m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.153799394314240695067264574m, 892, 1029.1890597283027m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5280183764560368663594470046m, 651, 994.73996307288m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4426618620151432706222865412m, 691, 996.879346652464m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5455642467300543478260869565m, 736, 1137.53528559332m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2139458050597082474226804124m, 970, 1177.527430907917m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4699524486567758518518518519m, 675, 992.2179028433237m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5659435369480012626262626263m, 792, 1240.227281262817m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2897250926713154897494305239m, 878, 1132.378631365415m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3526891186346982968369829684m, 822, 1111.910455517722m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5769186176207593659942363112m, 694, 1094.381520628807m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1565332484964976613657623948m, 1069, 1236.334042642756m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7736593447910178306092124814m, 673, 1193.672739044355m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2184798520408884339815762538m, 977, 1190.454815443948m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1112197208719247844827586207m, 928, 1031.2119009691462m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9854751122130949849548645938m, 997, 982.5186868764557m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2839337062361197097944377267m, 827, 1061.813175057271m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2556027216518340857787810384m, 886, 1112.464011383525m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2826034551864439083232810615m, 829, 1063.278264349562m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8180802902212217391304347826m, 690, 1254.475400252643m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3035455724489170886075949367m, 790, 1029.8010022346445m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8709592248058685015290519878m, 654, 1223.607333023038m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6205614256382123893805309735m, 678, 1098.740646582708m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7528084143608491620111731844m, 716, 1255.010824682368m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.207631987267802875157629256m, 793, 957.65216590336768m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3501489851679459148446490219m, 869, 1173.279468110945m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0690425938438767676767676768m, 990, 1058.352167905438m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0071758964849341983317886932m, 1079, 1086.742792307244m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8728071892700670553935860058m, 686, 1284.745731839266m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9465621425716564198687910028m, 1067, 1009.9818061239574m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.135222002280187624750499002m, 1002, 1137.492446284748m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1329437239535058479532163743m, 1026, 1162.400260776297m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2554682029650040201005025126m, 995, 1249.190861950179m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3416788579688156484458735263m, 933, 1251.786374484905m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7841101013856846473029045643m, 723, 1289.91160330185m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2655521208259565217391304348m, 920, 1164.30795115988m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0349700821042859830667920978m, 1063, 1100.173197276856m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0192899366344747937671860678m, 1091, 1112.045320868212m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.115472713662104662226450999m, 1051, 1172.361822058872m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1036219966820909970958373669m, 1033, 1140.0415225726m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4059524392725348288075560803m, 847, 1190.841716063837m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0511564004584336688014638609m, 1093, 1148.913945701068m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0448294050004210526315789474m, 1083, 1131.550245615456m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4508531339914145688350983359m, 661, 959.01392156832503m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9177206846654830547550432277m, 1041, 955.34723273676786m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9723242608992338679245283019m, 1060, 1030.6637165531879m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1828289155912546777546777547m, 962, 1137.881416798787m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0438098287651056737588652482m, 987, 1030.2403009911593m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2090107810218888888888888889m, 918, 1109.871896978094m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3297389637645195402298850575m, 870, 1156.872898475132m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.12976366381625m, 952, 1075.53500795307m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1189455374203679738562091503m, 918, 1027.1920033518978m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2936101127615141581632653061m, 784, 1014.1903284050271m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4987475440361009852216748768m, 812, 1216.983005757314m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4586103648396128843338213763m, 683, 996.2308791854556m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6306073302390615989515072084m, 763, 1244.153392972404m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4683986640843855243722304284m, 677, 994.105895585129m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.299372037081812972972972973m, 925, 1201.919134300677m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.060600598168898880976602238m, 983, 1042.5703880000276m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0845138326630690661478599222m, 1028, 1114.880219977635m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5854597364969944367176634214m, 719, 1139.945550541339m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4774993071401507779349363508m, 707, 1044.5920101480866m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4476180972813475258918296893m, 869, 1257.980126537491m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5041493371908617886178861789m, 861, 1295.072579321332m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2655728577129463019250253293m, 987, 1249.120410562678m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1801314899776526946107784431m, 1002, 1182.491752957608m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7090917571063839416058394161m, 685, 1170.727853617873m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5994648918336118090452261307m, 796, 1273.174053899555m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0702623438573404371584699454m, 915, 979.2900446294665m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1608902100780988372093023256m, 1032, 1198.038696800598m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5960506508374712041884816754m, 764, 1219.382697239828m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2464740982583445652173913043m, 920, 1146.756170397677m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0224571275403383177570093458m, 1070, 1094.029126468162m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0561284571168733542319749216m, 957, 1010.7149334608478m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4921810588230100147275405007m, 679, 1013.1909389408238m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.106212247481096875m, 928, 1026.5649656624579m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9528738565719081055607917059m, 1061, 1010.9991618227945m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4257904162580112994350282486m, 885, 1261.82451838834m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4460769540276684285714285714m, 700, 1012.2538678193679m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4604182620091072319201995012m, 802, 1171.255446131304m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3959421432865195822454308094m, 766, 1069.291681757474m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9364204136515527014218009479m, 1055, 987.9235364023881m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1324632722553724279835390947m, 972, 1100.754300632222m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9413251818803013493253373313m, 667, 1294.863896314161m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9226656366368340057636887608m, 1041, 960.4949277389442m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4510319954981015169194865811m, 857, 1243.534420141873m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.113633030248987459807073955m, 933, 1039.0196172223053m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3473805773425388736263736264m, 728, 980.8930603053683m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1923459805734641148325358852m, 1045, 1246.00154969927m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.175039442985325381679389313m, 1048, 1231.441336248621m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5236866142079615384615384615m, 806, 1228.091411051617m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3189479319972270693512304251m, 894, 1179.139451205521m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1082006459263005952380952381m, 1008, 1117.066251093711m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2880011057728832689832689833m, 777, 1000.7768591855303m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4875237229753403990024937656m, 802, 1192.994025826223m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4007731822396644664466446645m, 909, 1273.302822655855m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2753680509033774230330672748m, 877, 1118.497780642262m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1041231424823643995749202976m, 941, 1038.9798770759049m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1892112199169962441314553991m, 1065, 1266.509949211601m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3434398684259158113730929265m, 721, 968.6201451350853m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5917761270453125m, 704, 1120.6103934399m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6085679887214366197183098592m, 710, 1142.08327199222m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.526747394242345873786407767m, 824, 1258.039852855693m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.338343802681416156670746634m, 817, 1093.426886790717m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1028730999439321175278622087m, 987, 1088.535749644661m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5623425872070088945362134689m, 787, 1229.563616131916m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3303327131390011061946902655m, 904, 1202.620772677657m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2649744143210788126919140225m, 977, 1235.880002791694m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6989368688321572700296735905m, 674, 1145.083449592874m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.411082612028340958605664488m, 918, 1295.373837842017m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1124432860735934579439252336m, 1070, 1190.314316098745m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4075566283569486215538847118m, 798, 1123.230189428845m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4278655758732868525896414343m, 753, 1075.182778632585m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.741535513561444121915820029m, 689, 1199.917968843835m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3741438400999669156883671291m, 937, 1287.572778173669m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9801686039199038817005545287m, 1082, 1060.542429441336m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1722091603394225216554379211m, 1039, 1217.92531759266m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1632692996899041331802525832m, 871, 1013.2075600299065m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4793536343065744460856720827m, 677, 1001.5224104255509m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.421614572438785876993166287m, 878, 1248.177594601254m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4963223635769209535759096612m, 797, 1192.568923770806m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4926023281619322990126939351m, 709, 1058.25505066681m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8372857754948762886597938144m, 679, 1247.517041561021m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1945136710737548918640576725m, 971, 1159.872774612616m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4575478521617208121827411168m, 788, 1148.547707503436m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5099770091711754601226993865m, 815, 1230.631262474508m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0493260215183296703296703297m, 1001, 1050.375347539848m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1962304405291683991683991684m, 962, 1150.77368378906m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8297500559720779220779220779m, 693, 1268.01678878865m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0884591161943646994535519126m, 915, 995.9400913178437m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2202338359677080981595092025m, 815, 994.4905763136821m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2348185835002567567567567568m, 888, 1096.518902148228m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3349459482243044871794871795m, 936, 1249.509407537949m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2140389387175493895671476138m, 901, 1093.849083784512m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.234704938477492817679558011m, 905, 1117.407969322131m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.989911696600412568306010929m, 1098, 1086.923042867253m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1180650077752814021421616358m, 1027, 1148.252762985214m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0641700450399498945147679325m, 948, 1008.8332026978725m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1194241868912246486486486486m, 925, 1035.4673728743828m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5056335098582875481386392811m, 779, 1172.888504179606m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1133031190878308668076109937m, 946, 1053.184750657088m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2491546850504976415094339623m, 848, 1059.283172922822m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2083031440202060913705583756m, 985, 1190.178596859903m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1082158295124969264544456641m, 911, 1009.5846206858847m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3230511428207841191066997519m, 806, 1066.379221113552m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9188019075065421631530705775m, 1091, 1002.4128810896375m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5094594650930089628681177977m, 781, 1178.88784223764m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7277938098662569343065693431m, 685, 1183.538759758386m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1122479449147441643323996265m, 1071, 1191.217549003691m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5264731869175800561797752809m, 712, 1086.848909085317m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4273682833506066176470588235m, 816, 1164.732519214095m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.353126258991237467362924282m, 766, 1036.4947143872879m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9128466453728151862464183381m, 1047, 955.7504377053375m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1418465728248205607476635514m, 1070, 1221.775832922558m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4435913691383641425389755011m, 898, 1296.345049486251m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1913360358829307262569832402m, 895, 1066.245752115223m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.268248672054884828349944629m, 903, 1145.228550865561m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3574829467309858695652173913m, 920, 1248.884310992507m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3244077020443552278820375335m, 746, 988.008145725089m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0602903811126040330920372285m, 967, 1025.3007985358881m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3510414077227856315179606025m, 863, 1165.948734864764m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4753412480109518853695324284m, 663, 978.1512474312611m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3409682578580392638036809816m, 815, 1092.889130154302m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2658806133987538619979402678m, 971, 1229.17007561019m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0089822365077964646464646465m, 990, 998.8924141427185m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6894364533319298780487804878m, 656, 1108.270313385746m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1022910325600575471698113208m, 1060, 1168.428494513661m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3966246178058658698539176627m, 753, 1051.658337207817m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.128860638621516028955532575m, 967, 1091.608237547006m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2980954518190234466588511137m, 853, 1107.275420401627m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4350666071107222531293463143m, 719, 1031.8128905126093m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7653718889540524079320113314m, 706, 1246.352553601561m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7451476572103356164383561644m, 730, 1273.957789763545m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.357281735825294965034965035m, 715, 970.4564411150859m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3978744642449417596034696406m, 807, 1128.084692645668m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4517308621668117489986648865m, 749, 1087.346415762942m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1323552939432523267838676319m, 967, 1094.987569243125m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0565369397687748237885462555m, 908, 959.33554131004754m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1678013718475647619047619048m, 1050, 1226.191440439943m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2990993005803206578947368421m, 760, 987.3154684410437m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.397931226143684393063583815m, 865, 1209.210510614287m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5784426223779305555555555556m, 720, 1136.47868811211m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0877314075482484711211778029m, 883, 960.4668328651034m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.064218099163891983556012333m, 973, 1035.4842104864669m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3104090508055767002518891688m, 794, 1040.4647863396279m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1370671825518680981595092025m, 978, 1112.051704535727m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2649050099174691629955947137m, 908, 1148.533749005062m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2045115078305007425742574257m, 808, 973.2452983270446m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1788339112012032598274209012m, 1043, 1229.523769382855m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0023094772267542797494780793m, 958, 960.2124791832306m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1093544251644382022471910112m, 1068, 1184.79052607562m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1459971954158994172494172494m, 858, 983.2655936668417m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3926533513288671875m, 896, 1247.817402790665m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5495020194802798913043478261m, 736, 1140.433486337486m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7940055684006296296296296296m, 675, 1210.953758670425m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5740958147138564356435643564m, 808, 1271.869418288796m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0960346847601059957173447537m, 934, 1023.696395565939m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3837238271716959896507115136m, 773, 1069.618518403721m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0250488257865828460038986355m, 1026, 1051.700095257034m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2309876838098647398843930636m, 865, 1064.804346495533m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3469694872166050516647531573m, 871, 1173.210423365663m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.476862271077873485868102288m, 743, 1097.30866741086m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3368486464365348542458808619m, 789, 1054.773582038426m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3042353626382133928571428571m, 784, 1022.5205243083593m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3144058012204770233196159122m, 729, 958.20182908972775m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6597265288607507122507122507m, 702, 1165.128023260247m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8807465567845167883211678832m, 685, 1288.311391397394m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1704480265462350837988826816m, 895, 1047.5509837588804m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5319134045550328102710413695m, 701, 1073.871296593078m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6803368061270733056708160443m, 723, 1214.883510829874m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5271750222533355623100303951m, 658, 1004.8811646426948m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4369471263963737142857142857m, 700, 1005.8629884774616m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6381954012576124469589816124m, 707, 1158.204148689132m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2060417889208127139364303178m, 818, 986.5421833372248m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5197307859581359703337453646m, 809, 1229.462205840132m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4126131616397392265193370166m, 905, 1278.414911283964m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0002447752534311557788944724m, 995, 995.243551377164m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0888486365082041850220264317m, 908, 988.6745619494494m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1355123052243741360089186176m, 897, 1018.5545377862636m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0514508380092744444444444444m, 990, 1040.9363296291817m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.257581343153344689378757515m, 998, 1255.066180467038m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.403983232154125531914893617m, 705, 989.8081786686585m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.807807755327312874251497006m, 668, 1207.615580558645m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.093684453906358974358974359m, 1014, 1108.996036261048m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8852504747243425297891842346m, 1091, 965.8082679242577m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.521314115368180028129395218m, 711, 1081.654336026776m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "4278df70-c5bd-4643-b343-5f131a7a34b3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dispatcherRoleId",
                column: "ConcurrencyStamp",
                value: "a6b40199-1830-4922-bb27-e4dde1b0b79e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "managerRoleId",
                column: "ConcurrencyStamp",
                value: "37e0b199-9d85-418a-b9f2-f954d179588c");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClaimValue",
                value: "admin@truck.com");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimValue",
                value: "manager@truck.com");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClaimValue",
                value: "dispo1@truck.com");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "ClaimValue",
                value: "dispo2@truck.com");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0261d5ca-050a-423e-90cb-c7e990f67959",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24a78680-9df7-4cdb-9aab-dfc7ef8fdaaa", "Chief", "AQAAAAEAACcQAAAAEKUt7RvqiJOUbFUfqtr08x9yWxqP6ULWHUP4gtuCzwh/O3ySSfO79TDihJguuRNFAg==", "37a14e82-6b7a-4b50-98ba-3be776399123" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19918df1-9468-434b-aaf9-a3d22b2d12e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e209af01-d5d2-4801-87a1-b0acf77bc1dd", "AQAAAAEAACcQAAAAEGA3dZPCmY7mGBRy9XG7hO9VCCCdamhklDnCATM5RKVci5i28liwDQ5e2yz1gSbhVg==", "aee55223-e386-4b37-b2b4-14f698718652" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62154153-66df-4b35-91ed-56ac983c9a8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98a25738-d7b9-40e7-898e-df432c7fe5eb", "AQAAAAEAACcQAAAAEDp3cue6OkVQ+c1tr/Um2LVyCrYcVu8zDw3jMYhbCTC7XuhaZ7ttXEGp1+chjdJUhQ==", "c4030f75-2c74-40e0-942a-ee4941d4e4b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67fbfc90-0b2e-49b1-bc15-b5ca0c9a7442", "AQAAAAEAACcQAAAAEBJ4tI/H20PAiwKRGeUlvb0K4n0/RKzQ33yMrH1FhaAVqrlJ2cBkkgAiMx42Jf31OQ==", "8e0ddbe6-a303-44b2-887b-05806067e85e" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1078.446345436273m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1143.825659224534m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1241.678757756792m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1056.990500728139m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 977.1503800358797m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1022.6855812310789m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1242.039910106411m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1279.46932630631m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1134.354255175718m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1161.203387032952m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1161.447381793846m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 1120.735232746609m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1239.903652369437m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1101.101830333145m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1224.463684999461m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1147.974851289735m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1100.528631748183m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1211.345690672614m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1224.944497397175m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1289.130766425168m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1060.560613020289m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                column: "Price",
                value: 1152.984795160404m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 1284.608547289091m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1168.456630622596m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 1068.20405270032m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1184.524628851278m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1069.32581975012m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                column: "Price",
                value: 1095.800949679294m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 957.0828466227521m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1218.955968200008m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1193.242496334641m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1122.204365229822m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1023.8403383996812m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1094.145335898455m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1197.432207729403m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 998.4944373576082m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1027.2007897858137m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1161.796021864121m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1113.223959448066m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1293.819608220286m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1093.057535484672m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 972.3470649272733m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1165.428398776446m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1234.012494056442m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 966.0078753974227m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1281.278553246676m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1236.392168206777m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48,
                column: "Price",
                value: 1131.058434066147m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 999.5495930483512m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1111.769360458829m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1167.692405493646m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1268.264288129042m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1290.232121871243m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1039.1317265949221m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1191.115400886603m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1013.1775355304345m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 57,
                column: "Price",
                value: 1057.043862800029m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 58,
                column: "Price",
                value: 1098.088788270309m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1167.231130005691m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 989.4769865953695m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1041.6833747942932m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 971.6073293461018m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1009.9717665739317m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1087.098208227499m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 957.11582604855991m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1193.451658694351m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1035.4930187729926m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 68,
                column: "Price",
                value: 980.1737331299274m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 69,
                column: "Price",
                value: 1183.9638029583m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1097.137637434082m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1134.270128594889m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1197.620930658365m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 73,
                column: "Price",
                value: 1015.3065485554498m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 968.1456856265727m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1078.145308365493m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1187.625687260574m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1239.822106943898m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1109.057427324766m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1154.627251562629m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 994.9899858014139m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1154.994687601263m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1261.698370651341m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 960.0152755842904m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1108.21561651363m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1282.392301847288m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1187.294429114299m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1158.312377254489m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1194.638982678175m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1077.365425412263m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1139.36309301569m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1210.879912235824m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1055.619879334509m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1028.1865076363052m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1225.022562768569m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1068.750607599102m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1189.71897600855m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1285.801435341081m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1219.575194917621m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1037.5199009280679m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 996.2957467612916m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 101,
                column: "Price",
                value: 1271.491176618446m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1173.858532187692m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1007.3244902411768m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 104,
                column: "Price",
                value: 1274.945066870476m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 105,
                column: "Price",
                value: 1002.3516916021293m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1154.580323322214m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1291.873303486497m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 961.9737771022318m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 992.471852883179m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1288.394414781002m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1005.8438661692631m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1142.950235737978m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1118.607627767872m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1116.957647580199m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1030.1826982497748m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1078.083906143335m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 972.9263814316639m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1189.445840032086m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1027.739154195135m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1055.120635201568m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1151.880653497479m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 956.59799764193198m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1236.962488170454m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1086.980435943077m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1225.046464534358m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1023.7182981362839m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 127,
                column: "Price",
                value: 1151.566843422964m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 961.3858384246577m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1247.141333751259m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1097.860928844621m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1250.997105206233m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1202.115574525017m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1159.123254753961m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1109.969775330476m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1086.898036044729m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1228.99579631826m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 137,
                column: "Price",
                value: 1071.463533451704m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1235.040403695289m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1260.52721852772m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1206.351549185371m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1296.430847890931m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1205.284033384216m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1170.650016367299m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1165.639228521485m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1290.450363333923m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1135.244048480546m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1092.034621037771m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1066.215213471952m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1256.046723385165m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1244.267785247458m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1074.099725146757m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1247.835238924495m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 988.7936777338646m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 996.9460588832286m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1267.23888967442m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1195.787201615007m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1188.627394427399m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1002.6615730699009m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1291.352816797847m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 995.1080357494832m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1094.975676505602m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1123.262184899693m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 163,
                column: "Price",
                value: 1013.8877573717945m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1222.473319194194m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1193.82383808689m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1150.411213005577m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 984.7476533215094m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1263.104209645724m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1211.016654705035m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1053.619129454666m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 976.8173361441953m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1146.501179266308m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1063.004548219606m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1092.067597333971m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1254.274547622331m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1084.459048779877m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1129.426515255443m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1274.599993894164m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1034.1317632283506m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1279.056060975087m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 181,
                column: "Price",
                value: 1233.997158756896m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 995.8537488842195m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1144.620428249967m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1158.863718363382m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1029.0731919404256m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1048.7502565500707m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 995.1615749232978m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 975.3525283053674m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1064.482460413487m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1125.324786027222m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1139.98724167272m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1108.092838555826m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 995.3754369124203m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 194,
                column: "Price",
                value: 1080.69117610787m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 981.3551682811043m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1196.501401738184m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 957.97375505745923m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1173.940755717681m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 199,
                column: "Price",
                value: 968.3356729195874m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 200,
                column: "Price",
                value: 986.7038204029482m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1079.142207897944m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 992.9844110361698m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1002.377479654299m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1016.3567552622599m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1069.712658862388m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1182.838370913023m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1175.131721105406m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1048.6872273413445m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 988.765218116788m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1297.142618877366m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1009.7779376534429m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1133.274429508757m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1291.303222572272m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1117.450853266776m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1248.748100872722m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1151.65364675999m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1242.555625126118m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1113.194437017128m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1042.1837535471717m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1189.143522021308m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1081.095334130957m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1264.607899660182m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1080.568107944881m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1216.55965836899m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1205.92042982591m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1084.638408222363m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1195.892503663246m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 228,
                column: "Price",
                value: 1248.278757412071m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1183.776911574749m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1099.39118906234m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1184.04460873908m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 951.90831117425105m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1215.39536270842m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1227.690001996657m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 235,
                column: "Price",
                value: 1251.300734393153m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1096.339165587935m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1161.468371078493m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1013.3875357812625m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1135.836210873308m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1171.034214363752m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1285.845314112747m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1153.594890681952m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 952.2145419341381m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 977.6323482080216m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1176.651554708289m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1056.122031863918m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 980.9596809286392m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1251.988021276407m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1136.999402251221m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1291.859645329156m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1211.906370631199m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1045.9305882913706m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1228.613109177276m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1147.42240146741m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1253.272343398617m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1118.098513174156m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1047.7874107324105m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1168.139928223168m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 986.584547642735m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 966.1331918060514m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1030.2260617446946m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1160.966571582577m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1216.488987140232m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1049.3690066811012m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1063.088341310572m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1216.72063624198m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 267,
                column: "Price",
                value: 1287.342185276096m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1221.31409840197m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1088.731113854867m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1074.954603932754m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1191.724276680675m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 272,
                column: "Price",
                value: 1280.691407193324m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1257.211606321472m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1228.003118547837m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1050.198029020317m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1217.927193373484m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1297.162477363955m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1054.693042942056m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1292.212524195565m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1198.37036997524m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1016.570815362278m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1227.457892616795m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1044.5752617474505m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1188.716297091317m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1056.923696635454m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1129.137293430158m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1040.3172983609612m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1027.5393694407771m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1284.01016125706m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1128.550968420235m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1288.816900851166m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1229.579326512112m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1149.645359563698m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1255.438495709059m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1014.64246169763m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1239.599970376268m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1056.964644397593m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1083.570768403341m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1021.1423904160326m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1014.0823881873722m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1000.5773187996968m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1020.9571121891008m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1161.650174285244m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1045.1763197356076m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 305,
                column: "Price",
                value: 989.2265033038633m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1203.734848740476m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1037.7014234471026m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1247.010954871365m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1036.4135423497459m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1106.617753367702m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1104.006707897637m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1268.927941118819m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1116.356114720643m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1014.3346209567712m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 954.12575375530318m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1239.526441448535m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1223.534967742373m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1013.4228582651175m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1295.172764359335m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 320,
                column: "Price",
                value: 1209.417168599135m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1241.888420317863m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1294.125897220361m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1066.306828329411m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1106.216865642365m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1014.3575867800036m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 326,
                column: "Price",
                value: 1152.244330053576m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1006.6440925375796m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1215.449537829799m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1063.006890872525m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1211.411767538103m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1266.85525831289m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1081.202808396257m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1264.95776028907m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 334,
                column: "Price",
                value: 1133.022722738003m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 335,
                column: "Price",
                value: 1184.039067993537m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1177.134425254365m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 982.2299126745051m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1066.807044565863m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1118.973256629761m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1040.2889255535666m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1083.455999157459m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1061.938695104716m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1143.42144945357m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1035.1306564780535m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1204.974962976879m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1121.402713781365m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1007.8769620997317m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1027.7351184494113m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 992.6919691668706m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1297.759610871059m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 956.81371765726865m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 352,
                column: "Price",
                value: 1089.684059069324m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1212.254238769068m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1176.588021293226m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1163.33559444837m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1053.527488470124m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 963.9460576400105m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1162.516091868261m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 968.2737499501195m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 360,
                column: "Price",
                value: 1195.711577737737m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1232.608928768507m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 956.78820589245228m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1296.479170744138m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1281.546296207584m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1177.534002233347m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1067.023121462883m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1023.4452346202197m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1109.201002056425m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1044.3197509719564m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 959.64005042458261m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1085.58119699428m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 971.8438974090041m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1151.876381401535m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 374,
                column: "Price",
                value: 1046.3741773708746m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1096.982168611971m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1218.907264868532m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1014.3859070117778m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 993.7522956214925m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1105.291830784422m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1139.242761520371m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1159.272041876161m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1140.15031388761m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 976.201021558602m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1201.798364248326m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1030.8637414691091m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1048.0614848520986m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 387,
                column: "Price",
                value: 1204.269833944372m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1011.3506315537354m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1193.0254896162m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1226.813032322282m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1056.538555936553m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1022.4455579976905m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 997.5827659096965m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1094.287451605291m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1118.046421091091m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 967.7012722890027m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1144.78059326741m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1288.62689941702m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1028.2008471215686m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1016.7296256990834m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1111.000233727538m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1048.3118951133151m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1293.689397230955m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1236.236594543356m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1107.015687790166m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1162.792654752335m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 407,
                column: "Price",
                value: 1270.561274264223m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1079.181915396552m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1281.415558135032m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1207.857098823833m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 970.0641617798485m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1211.323007310952m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1256.287723344754m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1132.368527584823m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1158.48642492774m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1148.287674278045m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1284.961919770158m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1122.397172345694m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 419,
                column: "Price",
                value: 1185.705763030953m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1201.56362566908m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1209.571901391962m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1214.567877297081m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1184.250800400959m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1238.033204560986m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1159.316669602769m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1086.09714791088m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1000.3820366674598m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 977.6184837671156m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 962.2546997039848m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1132.517817807211m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1174.762193425006m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1172.403604897722m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1280.617032743712m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 951.80893580852306m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1244.119957121806m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1295.048844031553m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 989.9030714690484m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1285.585859028484m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1010.232969462127m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1001.638936116051m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1058.761246866806m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 979.3004133645941m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1003.4353224832033m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1019.5895217560181m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 445,
                column: "Price",
                value: 1135.925219036551m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1098.682446293168m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 997.2254571424881m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1010.7426591017172m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1195.87253025964m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1092.332243643493m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1026.6883846158072m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1251.62706228752m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1034.5110137776972m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1181.864112362564m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1220.393711260142m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 973.883450420111m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1252.806585257811m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1041.400920248098m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1185.934829199867m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 460,
                column: "Price",
                value: 1048.980847049156m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 994.4766839540531m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1108.866007084362m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 954.37606517401571m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1013.7253822236227m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1299.123119713066m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1145.887357242142m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1169.220973833832m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1227.335399343668m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 991.3996395780469m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1103.695179333132m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 984.5753678707093m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1045.2728583378972m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1286.912373847317m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 474,
                column: "Price",
                value: 1017.169751453472m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1202.019313458741m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1192.942604792298m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 997.1868551118192m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1216.186204460323m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1102.566524809078m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 480,
                column: "Price",
                value: 1274.633758617169m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 965.9304771440067m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1208.932456217558m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 987.2148524697715m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 959.16801449558787m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1048.9288156086728m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1151.78762260244m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 959.9633070710346m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1200.290254929741m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1093.143289926146m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1272.107283805551m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1008.7568337307095m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1240.472037787012m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1282.183478508503m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 494,
                column: "Price",
                value: 1283.731989711923m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1270.542167135442m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1070.044043162905m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1225.808949130856m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 498,
                column: "Price",
                value: 1247.175420870666m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1112.276150112979m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1126.211185521449m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1009.4234921848235m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 960.9984994128591m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1131.93091840454m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 504,
                column: "Price",
                value: 1137.692918190143m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1279.50777327207m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1015.9970740454967m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 959.8150026352293m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 966.7252081836485m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1100.973229120388m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1090.626016260397m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1223.796807850754m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1171.088087704802m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1216.378328279758m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 514,
                column: "Price",
                value: 1176.814911504229m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 515,
                column: "Price",
                value: 1280.539153284325m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1172.608327884254m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1273.103839100072m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1022.1559419986737m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1187.831285718244m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1102.926910895434m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 972.692039138034m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1262.135831776762m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 523,
                column: "Price",
                value: 1088.84050398074m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1287.892843070672m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1040.6399820607079m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1058.083078398397m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1186.969858497865m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1230.093775104499m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 956.21557122457969m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1135.67065416886m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1186.977288361365m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 953.44589442277328m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1146.168574474872m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 953.0764738533093m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 535,
                column: "Price",
                value: 1231.948550004874m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1116.039800071013m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 537,
                column: "Price",
                value: 1056.814497762744m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1241.017392205555m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1195.3719742445m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1241.655826227019m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 952.50868364021049m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1010.0464433152512m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1013.8020851499027m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1196.095098003103m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1193.203486282473m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1101.801893599097m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1212.355253070191m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 548,
                column: "Price",
                value: 1238.856373533626m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1129.551773120752m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1000.338042283464m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 551,
                column: "Price",
                value: 1203.215305782022m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 984.8436926590615m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1165.825646969392m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1151.588570481341m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1104.94522842674m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1117.471273063295m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 557,
                column: "Price",
                value: 1263.236143577347m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1045.8295782538555m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1201.788881771164m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1273.474638476302m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1008.0494747937404m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1094.967528587783m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1091.078660037391m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1024.2073160544688m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1252.99858660753m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1289.615346377673m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1079.743255681052m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1208.369812157934m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 569,
                column: "Price",
                value: 958.41301650182641m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1290.396715315075m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1158.873881522175m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1175.395865087764m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1268.810617307067m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 989.2764980446634m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 575,
                column: "Price",
                value: 1115.388345578676m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1127.45155809969m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1057.249067436354m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1266.170448363219m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1206.821592227118m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1185.613644179959m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1207.954472228457m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1117.253742812516m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1159.422645574224m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1237.922412721871m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 987.2590449607121m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 960.9011056722284m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1252.419336139688m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1097.788316477103m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1069.50077967597m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 590,
                column: "Price",
                value: 1103.973196807568m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1255.107244599323m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 592,
                column: "Price",
                value: 1251.789375395953m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1050.767653632788m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1193.175768048286m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1546534747711702355460385439m, 934, 1078.446345436273m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6201496589582634560906515581m, 706, 1143.825659224534m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7221619386363273231622746186m, 721, 1241.678757756792m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1997622028696242905788876277m, 881, 1056.990500728139m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4827775114353257966616084977m, 659, 977.1503800358797m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9675360276547577105014191107m, 1057, 1022.6855812310789m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4178537786602865296803652968m, 876, 1242.039910106411m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8955101130463851851851851852m, 675, 1279.46932630631m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4524382268575134443021766965m, 781, 1134.354255175718m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0832121147695447761194029851m, 1072, 1161.203387032952m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4129530192139245742092457421m, 822, 1161.447381793846m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6219033758995788712011577424m, 691, 1120.735232746609m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3433409018087074756229685807m, 923, 1239.903652369437m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1676583566629321314952279958m, 943, 1101.101830333145m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3882808219948537414965986395m, 882, 1224.463684999461m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1156218185517346938775510204m, 1029, 1147.974851289735m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0199523927230611677479147359m, 1079, 1100.528631748183m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4936445014458865598027127004m, 811, 1211.345690672614m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5330969929877033792240300375m, 799, 1224.944497397175m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.72805732764767828418230563m, 746, 1289.130766425168m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0800006242569134419551934827m, 982, 1060.560613020289m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5686867961366040816326530612m, 735, 1152.984795160404m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6178948958300894206549118388m, 794, 1284.608547289091m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2523650917712711682743837085m, 933, 1168.456630622596m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1303746589421375661375661376m, 945, 1068.20405270032m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4480741184000953545232273839m, 818, 1184.524628851278m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2993023326246901579586877278m, 823, 1069.32581975012m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2395938344788393665158371041m, 884, 1095.800949679294m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9310144422400312256809338521m, 1028, 957.0828466227521m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1974027192534459724950884086m, 1018, 1218.955968200008m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2416675300048293444328824142m, 961, 1193.242496334641m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.315597145638712778429073857m, 853, 1122.204365229822m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9577552276891311506080449018m, 1069, 1023.8403383996812m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1233525009224383983572895277m, 974, 1094.145335898455m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1762595360799636542239685658m, 1018, 1197.432207729403m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1886838539971526190476190476m, 840, 998.4944373576082m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5331355071430055223880597015m, 670, 1027.2007897858137m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1664618693414869477911646586m, 996, 1161.796021864121m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1143382977458118118118118118m, 999, 1113.223959448066m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7579070763862581521739130435m, 736, 1293.819608220286m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.182962700740987012987012987m, 924, 1093.057535484672m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.948631282855876390243902439m, 1025, 972.3470649272733m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.192864277150917093142272262m, 977, 1165.428398776446m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2266525785849324055666003976m, 1006, 1234.012494056442m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.947066544507277156862745098m, 1020, 966.0078753974227m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4761273654915622119815668203m, 868, 1281.278553246676m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.784115682838062049062049062m, 693, 1236.392168206777m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.233433406833311886586695747m, 917, 1131.058434066147m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3673729043069099863201094391m, 731, 999.5495930483512m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4419836063019831387808041505m, 771, 1111.769360458829m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2775628068858271334792122538m, 914, 1167.692405493646m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.249521466136987192118226601m, 1015, 1268.264288129042m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5928791628040037037037037037m, 810, 1290.232121871243m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5673178380013907993966817496m, 663, 1039.1317265949221m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.219155988624977482088024565m, 977, 1191.115400886603m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2061637327743267857142857143m, 840, 1013.1775355304345m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4559832820937038567493112948m, 726, 1057.043862800029m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4205547066886274256144890039m, 773, 1098.088788270309m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5080505555629082687338501292m, 774, 1167.231130005691m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9247448472853920560747663551m, 1070, 989.4769865953695m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3742524733433947229551451187m, 758, 1041.6833747942932m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8954906261254394470046082949m, 1085, 971.6073293461018m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.523335997849067420814479638m, 663, 1009.9717665739317m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5529974403249985714285714286m, 700, 1087.098208227499m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2527694058227223952879581152m, 764, 957.11582604855991m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2103972197711470588235294118m, 986, 1193.451658694351m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2927503355468072409488139825m, 801, 1035.4930187729926m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3482444747316745529573590096m, 727, 980.1737331299274m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3082472960865193370165745856m, 905, 1183.9638029583m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0399408885631109004739336493m, 1055, 1097.137637434082m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2131231321870470588235294118m, 935, 1134.270128594889m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0977277091277406049495875344m, 1091, 1197.620930658365m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3185799331888958441558441558m, 770, 1015.3065485554498m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3502729227706732217573221757m, 717, 968.1456856265727m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1301313504879381551362683438m, 954, 1078.145308365493m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.594128439275938255033557047m, 745, 1187.625687260574m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7364455279326302521008403361m, 714, 1239.822106943898m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.186157676283172192513368984m, 935, 1109.057427324766m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5212480257742147562582345191m, 759, 1154.627251562629m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3373521314535133064516129032m, 744, 994.9899858014139m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0896176298125122641509433962m, 1060, 1154.994687601263m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2887623806448835546475995914m, 979, 1261.698370651341m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0738425901390272930648769575m, 894, 960.0152755842904m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1764496990590552016985138004m, 942, 1108.21561651363m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9459670741233505311077389985m, 659, 1282.392301847288m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2290832599526904761904761905m, 966, 1187.294429114299m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.414300826928557997557997558m, 819, 1158.312377254489m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2366863174722308488612836439m, 966, 1194.638982678175m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9994113408277022263450834879m, 1078, 1077.365425412263m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4532692512955229591836734694m, 784, 1139.36309301569m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1676759037953944069431051109m, 1037, 1210.879912235824m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9819719807762874418604651163m, 1075, 1055.619879334509m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0438441701891423350253807107m, 985, 1028.1865076363052m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7253838912233366197183098592m, 710, 1225.022562768569m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4099612237455171503957783641m, 758, 1068.750607599102m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1573141789966439688715953307m, 1028, 1189.71897600855m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3160710699499293756397134084m, 977, 1285.801435341081m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.455340328063986873508353222m, 838, 1219.575194917621m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0303077467011597815292949355m, 1007, 1037.5199009280679m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2563628584631672131147540984m, 793, 996.2957467612916m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2740392551287034068136272545m, 998, 1271.491176618446m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6674126877666079545454545455m, 704, 1173.858532187692m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1906908868099016548463356974m, 846, 1007.3244902411768m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6158999580107427122940430925m, 789, 1274.945066870476m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4177534534683582743988684583m, 707, 1002.3516916021293m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0534492001115091240875912409m, 1096, 1154.580323322214m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.197287584324835032437442076m, 1079, 1291.873303486497m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1095429955043042675893886967m, 867, 961.9737771022318m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1801092186482508917954815696m, 841, 992.471852883179m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4758240719140916380297823597m, 873, 1288.394414781002m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0643850435653577777777777778m, 945, 1005.8438661692631m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.559277265672548431105047749m, 733, 1142.950235737978m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5323392161203726027397260274m, 730, 1118.607627767872m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6141006467921950867052023121m, 692, 1116.957647580199m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0642383246381971074380165289m, 968, 1030.1826982497748m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3293266413604623921085080148m, 811, 1078.083906143335m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0750567750626120441988950276m, 905, 972.9263814316639m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3911647251837263157894736842m, 855, 1189.445840032086m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4394105801052310924369747899m, 714, 1027.739154195135m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5608293420141538461538461538m, 676, 1055.120635201568m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1838444537486937307297019527m, 973, 1151.880653497479m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1162170334211575029171528588m, 857, 956.59799764193198m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5520231972025771643663739021m, 797, 1236.962488170454m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2522816082293513824884792627m, 868, 1086.980435943077m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5180253587786344485749690211m, 807, 1225.046464534358m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9987495591573501463414634146m, 1025, 1023.7182981362839m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5457273066080053691275167785m, 745, 1151.566843422964m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3813014919894507183908045977m, 696, 961.3858384246577m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1968726811432428023032629559m, 1042, 1247.141333751259m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1318153905614649484536082474m, 970, 1097.860928844621m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3140725895023455882352941176m, 952, 1250.997105206233m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7498043297307379912663755459m, 687, 1202.115574525017m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3898360368752529976019184652m, 834, 1159.123254753961m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4566532484651916010498687664m, 762, 1109.969775330476m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5308423042883507042253521127m, 710, 1086.898036044729m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3871284382824604966139954853m, 886, 1228.99579631826m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0693248836843353293413173653m, 1002, 1071.463533451704m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3152719954156432374866879659m, 939, 1235.040403695289m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1682365324631325301204819277m, 1079, 1260.52721852772m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3478788259054424581005586592m, 895, 1206.351549185371m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5676310131692031438935912938m, 827, 1296.430847890931m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2502946404400580912863070539m, 964, 1205.284033384216m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.099201893302628169014084507m, 1065, 1170.650016367299m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2851590171129933847850055127m, 907, 1165.639228521485m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6780888990038010403120936281m, 769, 1290.450363333923m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2530287510822803532008830022m, 906, 1135.244048480546m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0351039061969393364928909953m, 1055, 1092.034621037771m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3018500774993308913308913309m, 819, 1066.215213471952m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2254114374489414634146341463m, 1025, 1256.046723385165m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5229715853702056303549571603m, 817, 1244.267785247458m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1524675162518851931330472103m, 932, 1074.099725146757m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4715038194864327830188679245m, 848, 1247.835238924495m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4456047920085739766081871345m, 684, 988.7936777338646m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.912954266376582967032967033m, 1092, 996.9460588832286m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2826304551360526315789473684m, 988, 1267.23888967442m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2707621696227492029755579171m, 941, 1195.787201615007m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2203566677899373716632443532m, 974, 1188.627394427399m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.371630058919153077975376197m, 731, 1002.6615730699009m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4946213157382488425925925926m, 864, 1291.352816797847m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0301325421837300207039337474m, 966, 995.1080357494832m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5250357611498635097493036212m, 718, 1094.975676505602m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3388107090580369487485101311m, 839, 1123.262184899693m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9989041944549699507389162562m, 1015, 1013.8877573717945m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5148368267586047087980173482m, 807, 1222.473319194194m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7054626258384142857142857143m, 700, 1193.82383808689m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7617323323209448698315467075m, 653, 1150.411213005577m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3200370687955890080428954424m, 746, 984.7476533215094m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8768264630694264487369985141m, 673, 1263.104209645724m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8602406370277035330261136713m, 651, 1211.016654705035m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0259193081350204479065238559m, 1027, 1053.619129454666m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0492130356006394199785177229m, 931, 976.8173361441953m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0775387023179586466165413534m, 1064, 1146.501179266308m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0143173170034408396946564885m, 1048, 1063.004548219606m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9991469326019862763037511436m, 1093, 1092.067597333971m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.222489812497398635477582846m, 1026, 1254.274547622331m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.082294459860156686626746507m, 1002, 1084.459048779877m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6512083556366125730994152047m, 684, 1129.426515255443m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7508241674370384615384615385m, 728, 1274.599993894164m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9811496804823060721062618596m, 1054, 1034.1317632283506m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3309636430542008324661810614m, 961, 1279.056060975087m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7858135437871143270622286541m, 691, 1233.997158756896m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4287715192026104734576757532m, 697, 995.8537488842195m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4027211130514301470588235294m, 816, 1144.620428249967m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3412774518094699074074074074m, 864, 1158.863718363382m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2050037376351587822014051522m, 854, 1029.0731919404256m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0191936409621678328474246842m, 1029, 1048.7502565500707m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0206785383828695384615384615m, 975, 995.1615749232978m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0521602247091341963322545847m, 927, 975.3525283053674m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5316294394438661870503597122m, 695, 1064.482460413487m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4748686579649043250327653997m, 763, 1125.324786027222m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.13998724167272m, 1000, 1139.98724167272m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.467672633848776158940397351m, 755, 1108.092838555826m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9617153979830147826086956522m, 1035, 995.3754369124203m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1447999746905402542372881356m, 944, 1080.69117610787m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1292924836376344073647871116m, 869, 981.3551682811043m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2634650493539429778247096093m, 947, 1196.501401738184m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9715758164882953651115618661m, 986, 957.97375505745923m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2152595814882826086956521739m, 966, 1173.940755717681m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4345713672882776296296296296m, 675, 968.3356729195874m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3406301907648752717391304348m, 736, 986.7038204029482m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3306315757064660912453760789m, 811, 1079.142207897944m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0828619531474043620501635769m, 917, 992.9844110361698m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4381312477106154949784791966m, 697, 1002.377479654299m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0789349843548406581740976645m, 942, 1016.3567552622599m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3239018055227574257425742574m, 808, 1069.712658862388m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1384392405322646775745909528m, 1039, 1182.838370913023m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2164924649124285714285714286m, 966, 1175.131721105406m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9577052304487164383561643836m, 1095, 1048.6872273413445m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.062046421178075187969924812m, 931, 988.765218116788m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2318543389148774928774928775m, 1053, 1297.142618877366m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1182479929716975636766334441m, 903, 1009.7779376534429m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6259317496538837876614060258m, 697, 1133.274429508757m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3203509433254314928425357873m, 978, 1291.303222572272m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1824876754145777777777777778m, 945, 1117.450853266776m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5668106660887352572145545797m, 797, 1248.748100872722m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1691915195532893401015228426m, 985, 1151.65364675999m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7904259728042046109510086455m, 694, 1242.555625126118m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3428159674513003618817852835m, 829, 1113.194437017128m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9758274845947300561797752809m, 1068, 1042.1837535471717m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6222967558271596180081855389m, 733, 1189.143522021308m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9936537997527178308823529412m, 1088, 1081.095334130957m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3641940665158381877022653722m, 927, 1264.607899660182m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6176169280611991017964071856m, 668, 1080.568107944881m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5380020965473957016434892541m, 791, 1216.55965836899m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2267756152857680569684638861m, 983, 1205.92042982591m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1650251430959860365198711063m, 931, 1084.638408222363m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6495069016044772413793103448m, 725, 1195.892503663246m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4616847276487950819672131148m, 854, 1248.278757412071m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6418542462895270457697642164m, 721, 1183.776911574749m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0049279607516819012797074954m, 1094, 1099.39118906234m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0943110986497966728280961183m, 1082, 1184.04460873908m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9905393456547877731529656608m, 961, 951.90831117425105m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1880697582682502443792766373m, 1023, 1215.39536270842m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3998745746826191562143671608m, 877, 1227.690001996657m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2054920369876233140655105973m, 1038, 1251.300734393153m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.06751622744686952288218111m, 1027, 1096.339165587935m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4216259131927698898408812729m, 817, 1161.468371078493m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0479705644066830403309203723m, 967, 1013.3875357812625m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2032163250776567796610169492m, 944, 1135.836210873308m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5910790956029239130434782609m, 736, 1171.034214363752m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4645163030896890660592255125m, 878, 1285.845314112747m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3749641128509558998808104887m, 839, 1153.594890681952m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.053334670281126216814159292m, 904, 952.2145419341381m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4880248831172322678843226788m, 657, 977.6323482080216m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6252093297075814917127071823m, 724, 1176.651554708289m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6173384867747595712098009188m, 653, 1056.122031863918m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0282596236149257861635220126m, 954, 980.9596809286392m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.734055431130757617728531856m, 722, 1251.988021276407m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1125238769581418786692759295m, 1022, 1136.999402251221m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.579290519962293398533007335m, 818, 1291.859645329156m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5617350136999987113402061856m, 776, 1211.906370631199m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3618887868377221354166666667m, 768, 1045.9305882913706m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4910353266714514563106796117m, 824, 1228.613109177276m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0594851352422991689750692521m, 1083, 1147.42240146741m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3925248259984633333333333333m, 900, 1253.272343398617m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4967851581983346720214190094m, 747, 1118.098513174156m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1158545375212039403620873269m, 939, 1047.7874107324105m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0846238887865998142989786444m, 1077, 1168.139928223168m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2763060124744307891332470893m, 773, 986.584547642735m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9642047822415682634730538922m, 1002, 966.1331918060514m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0060801384225533203125m, 1024, 1030.2260617446946m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5097094558941183355006501951m, 769, 1160.966571582577m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4603709329414549819927971188m, 833, 1216.488987140232m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4374917899741112328767123288m, 730, 1049.3690066811012m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1971715555299234234234234234m, 888, 1063.088341310572m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1893652358181622678396871945m, 1023, 1216.72063624198m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.707350378350259946949602122m, 754, 1287.342185276096m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2539159121170123203285420945m, 974, 1221.31409840197m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9906561545540191082802547771m, 1099, 1088.731113854867m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0286646927586162679425837321m, 1045, 1074.954603932754m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6620980148963389121338912134m, 717, 1191.724276680675m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1847284062842960222016651249m, 1081, 1280.691407193324m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6455649297401465968586387435m, 764, 1257.211606321472m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8719559733960929878048780488m, 656, 1228.003118547837m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4960085883480299145299145299m, 702, 1050.198029020317m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2956672269930680851063829787m, 940, 1217.927193373484m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5647315770373401688781664656m, 829, 1297.162477363955m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.233559114552112280701754386m, 855, 1054.693042942056m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7206558244947603195739014647m, 751, 1292.212524195565m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2240759652453932584269662921m, 979, 1198.37036997524m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9746604174134976030680728667m, 1043, 1016.570815362278m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6745673841975375170532060027m, 733, 1227.457892616795m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4250685699146664392905866303m, 733, 1044.5752617474505m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1408025883793829174664107486m, 1042, 1188.716297091317m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0281358916687295719844357977m, 1028, 1056.923696635454m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0523180740262423112767940354m, 1073, 1129.137293430158m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4309729000838530949105914718m, 727, 1040.3172983609612m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2990383937304388116308470291m, 791, 1027.5393694407771m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5052874106178898007033997655m, 853, 1284.01016125706m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2347384774838457330415754923m, 914, 1128.550968420235m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1900433064184358264081255771m, 1083, 1288.816900851166m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3738316497342033519553072626m, 895, 1229.579326512112m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6423505136624257142857142857m, 700, 1149.645359563698m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3811204573256974697469746975m, 909, 1255.438495709059m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4092256412467083333333333333m, 720, 1014.64246169763m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6728744539490796221322537112m, 741, 1239.599970376268m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1564164599536028446389496718m, 914, 1056.964644397593m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2808165111150602836879432624m, 846, 1083.570768403341m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0211423904160326m, 1000, 1021.1423904160326m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4123710141885406685236768802m, 718, 1014.0823881873722m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5046275470672132330827067669m, 665, 1000.5773187996968m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.990259080687779631425800194m, 1031, 1020.9571121891008m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3945380243520336134453781513m, 833, 1161.650174285244m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2562215381437591346153846154m, 832, 1045.1763197356076m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4830982058528685157421289355m, 667, 989.2265033038633m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6288698900412395128552097429m, 739, 1203.734848740476m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1581489100972127232142857143m, 896, 1037.7014234471026m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6715964542511595174262734584m, 746, 1247.010954871365m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0416216506027596984924623116m, 995, 1036.4135423497459m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4260538058862139175257731959m, 776, 1106.617753367702m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5312159610230748959778085992m, 721, 1104.006707897637m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4099199345764655555555555556m, 900, 1268.927941118819m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.102029728253349457058242843m, 1013, 1116.356114720643m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1384226946765108866442199776m, 891, 1014.3346209567712m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4283319666995556586826347305m, 668, 954.12575375530318m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3130576710259904661016949153m, 944, 1239.526441448535m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3270444335600574837310195228m, 922, 1223.534967742373m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5080697295611867559523809524m, 672, 1013.4228582651175m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2311528178320674904942965779m, 1052, 1295.172764359335m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5976448726540752972258916777m, 757, 1209.417168599135m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3324983050620847639484978541m, 932, 1241.888420317863m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2060819172603550792171481827m, 1073, 1294.125897220361m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4567033173899057377049180328m, 732, 1066.306828329411m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6837395215256697108066971081m, 657, 1106.216865642365m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0544257658835796257796257796m, 962, 1014.3575867800036m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2363136588557682403433476395m, 932, 1152.244330053576m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1400272848670210645526613817m, 883, 1006.6440925375796m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4840653697555543345543345543m, 819, 1215.449537829799m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.987007326715436397400185701m, 1077, 1063.006890872525m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.180713223721347953216374269m, 1026, 1211.411767538103m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4139009579384933035714285714m, 896, 1266.85525831289m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3447796124331554726368159204m, 804, 1081.202808396257m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7816306482944647887323943662m, 710, 1264.95776028907m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1151798452145698818897637795m, 1016, 1133.022722738003m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1014316911567786046511627907m, 1075, 1184.039067993537m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5188831293604709677419354839m, 775, 1177.134425254365m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1805647988876263221153846154m, 832, 982.2299126745051m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0975381116932746913580246914m, 972, 1066.807044565863m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3497867993121363088057901086m, 829, 1118.973256629761m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1161898342849427038626609442m, 932, 1040.2889255535666m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2065211571909342984409799555m, 898, 1083.455999157459m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0577078636501155378486055777m, 1004, 1061.938695104716m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7510282533745329249617151608m, 653, 1143.42144945357m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4477351838853895104895104895m, 715, 1035.1306564780535m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5528027873413389175257731959m, 776, 1204.974962976879m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4735909510924638633377135348m, 761, 1121.402713781365m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1955835849344385527876631079m, 843, 1007.8769620997317m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9686476139956751178133836004m, 1061, 1027.7351184494113m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4470728413511233236151603499m, 686, 992.6919691668706m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7211665926671870026525198939m, 754, 1297.759610871059m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2982547050980578697421981004m, 737, 956.81371765726865m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0437586772694674329501915709m, 1044, 1089.684059069324m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1545278464467314285714285714m, 1050, 1212.254238769068m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3087742172338442714126807564m, 899, 1176.588021293226m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2080328083576012461059190031m, 963, 1163.33559444837m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4796734388625337078651685393m, 712, 1053.527488470124m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8908928443992703327171903882m, 1082, 963.9460576400105m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0675078896861900826446280992m, 1089, 1162.516091868261m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1003110794887721590909090909m, 880, 968.2737499501195m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4872034548976828358208955224m, 804, 1195.711577737737m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6634398498900229419703103914m, 741, 1232.608928768507m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8818324478271449585253456221m, 1085, 956.78820589245228m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3792331603661042553191489362m, 940, 1296.479170744138m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.60193287025948m, 800, 1281.546296207584m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.403497022924132300357568534m, 839, 1177.534002233347m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6290429335311190839694656489m, 655, 1067.023121462883m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3037518912359486624203821656m, 785, 1023.4452346202197m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2069651817806583242655059848m, 919, 1109.201002056425m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5727707092951150602409638554m, 664, 1044.3197509719564m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0710268419917216629464285714m, 896, 959.64005042458261m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5987941045571134020618556701m, 679, 1085.58119699428m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1666793486302570228091236495m, 833, 971.8438974090041m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4940030887179442282749675746m, 771, 1151.876381401535m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0288831635898471976401179941m, 1017, 1046.3741773708746m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5068436382032568681318681319m, 728, 1096.982168611971m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1880187766749824561403508772m, 1026, 1218.907264868532m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2162900563690381294964028777m, 834, 1014.3859070117778m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0944408542086921806167400881m, 908, 993.7522956214925m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1142054745810705645161290323m, 992, 1105.291830784422m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1472736772611993957703927492m, 993, 1139.242761520371m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7564727907214560606060606061m, 660, 1159.272041876161m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4579927287565345268542199488m, 782, 1140.15031388761m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1775645615905934861278648975m, 829, 976.201021558602m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0935380930376032757051865332m, 1099, 1201.798364248326m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1767850930012660958904109589m, 876, 1030.8637414691091m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2506700296564422434367541766m, 838, 1048.0614848520986m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1546211255458983700862895494m, 1043, 1204.269833944372m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0657014031124714436248682824m, 949, 1011.3506315537354m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5453698052023316062176165803m, 772, 1193.0254896162m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7550973280719341917024320458m, 699, 1226.813032322282m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0715401175827109533468559838m, 986, 1056.538555936553m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.456475153842863960113960114m, 702, 1022.4455579976905m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9077186223018166515013648772m, 1099, 997.5827659096965m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3058322811518985680190930788m, 838, 1094.287451605291m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0173306834313839854413102821m, 1099, 1118.046421091091m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9854391774837094704684317719m, 982, 967.7012722890027m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1082096740245982575024201355m, 1033, 1144.78059326741m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.317614416581820040899795501m, 978, 1288.62689941702m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3970120205456095108695652174m, 736, 1028.2008471215686m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4671423170260943722943722944m, 693, 1016.7296256990834m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3939777085665470514429109159m, 797, 1111.000233727538m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5170939147804849493487698987m, 691, 1048.3118951133151m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.809355800323013986013986014m, 715, 1293.689397230955m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.147851991219457753017641597m, 1077, 1236.236594543356m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0675175388526190935390549662m, 1037, 1107.015687790166m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3380813058139643268124280783m, 869, 1162.792654752335m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2821001758468446014127144299m, 991, 1270.561274264223m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4070168388481773142112125163m, 767, 1079.181915396552m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6428404591474769230769230769m, 780, 1281.415558135032m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6278397558272681940700808625m, 742, 1207.857098823833m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0625018201312688937568455641m, 913, 970.0641617798485m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3038999002270742734122712594m, 929, 1211.323007310952m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3744942268542166301969365427m, 914, 1256.287723344754m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2189112245261819160387513455m, 929, 1132.368527584823m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3581317994463540445486518171m, 853, 1158.48642492774m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1191887663528703703703703704m, 1026, 1148.287674278045m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6306623347337030456852791878m, 788, 1284.961919770158m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5270709827832571428571428571m, 735, 1122.397172345694m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2287106352652362694300518135m, 965, 1185.705763030953m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4152692881850176678445229682m, 849, 1201.56362566908m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2759197272067109704641350211m, 948, 1209.571901391962m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3259474642981233624454148472m, 916, 1214.567877297081m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4131871126503090692124105012m, 838, 1184.250800400959m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.238033204560986m, 1000, 1238.033204560986m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7023739641744038179148311307m, 681, 1159.316669602769m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4253243410903937007874015748m, 762, 1086.09714791088m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3798372919551169655172413793m, 725, 1000.3820366674598m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9785970808479635635635635636m, 999, 977.6184837671156m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9508445649248861660079051383m, 1012, 962.2546997039848m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1797060602158447916666666667m, 960, 1132.517817807211m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5811065860363472409152086137m, 743, 1174.762193425006m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1316637112912374517374517375m, 1036, 1172.403604897722m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2555068948467764705882352941m, 1020, 1280.617032743712m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0599208639293129844097995546m, 898, 951.80893580852306m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7136638527848567493112947658m, 726, 1244.119957121806m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8062048033912873082287308229m, 717, 1295.048844031553m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9676471861867530791788856305m, 1023, 989.9030714690484m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8081376357643938115330520394m, 711, 1285.585859028484m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3578400127179126344086021505m, 744, 1010.232969462127m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4883193701575794947994056464m, 673, 1001.638936116051m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2397672679939180327868852459m, 854, 1058.761246866806m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3144971991471061744966442953m, 745, 979.3004133645941m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0618363200880458201058201058m, 945, 1003.4353224832033m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0414601856547682328907048008m, 979, 1019.5895217560181m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3886616369639987775061124694m, 818, 1135.925219036551m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0646147735398914728682170543m, 1032, 1098.682446293168m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3623298594842733606557377049m, 732, 997.2254571424881m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.35488292104787828418230563m, 746, 1010.7426591017172m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3714134521326146788990825688m, 872, 1195.87253025964m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5830902081789753623188405797m, 690, 1092.332243643493m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9480040485833861495844875346m, 1083, 1026.6883846158072m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6599828412301326259946949602m, 754, 1251.62706228752m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2286354082870513064133016627m, 842, 1034.5110137776972m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1191895003433371212121212121m, 1056, 1181.864112362564m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4141294452608829663962920046m, 863, 1220.393711260142m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1079447672583742889647326507m, 879, 973.883450420111m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1897498435496780626780626781m, 1053, 1252.806585257811m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.392247219583018716577540107m, 748, 1041.400920248098m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6917757905846890156918687589m, 701, 1185.934829199867m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0355190987652082922013820336m, 1013, 1048.980847049156m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1099070133415771205357142857m, 896, 994.4766839540531m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1189364349993562058526740666m, 991, 1108.866007084362m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9728604130214227420998980632m, 981, 954.37606517401571m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.304665871587674002574002574m, 777, 1013.7253822236227m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5766057278071189320388349515m, 824, 1299.123119713066m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0503092183704326306141154904m, 1091, 1145.887357242142m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6945231504838144927536231884m, 690, 1169.220973833832m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8709381087555914634146341463m, 656, 1227.335399343668m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1421654833848466589861751152m, 868, 991.3996395780469m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6351039693824177777777777778m, 675, 1103.695179333132m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0564113389170700643776824034m, 932, 984.5753678707093m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0463191775154126126126126126m, 999, 1045.2728583378972m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2972906994428598790322580645m, 992, 1286.912373847317m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2573173689165290482076637824m, 809, 1017.169751453472m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3784625154343360091743119266m, 872, 1202.019313458741m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6386574241652445054945054945m, 728, 1192.942604792298m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1383411588034465753424657534m, 876, 997.1868551118192m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3438521596246662983425414365m, 905, 1216.186204460323m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4960197080177449118046132972m, 737, 1102.566524809078m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8003301675383742937853107345m, 708, 1274.633758617169m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3323178995089747586206896552m, 725, 965.9304771440067m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2514828739312194616977225673m, 966, 1208.932456217558m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2575985381780528662420382166m, 785, 987.2148524697715m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3761377539391504591104734577m, 697, 959.16801449558787m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2607317495296548076923076923m, 832, 1048.9288156086728m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1193271356680660835762876579m, 1029, 1151.78762260244m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9457766572128419704433497537m, 1015, 959.9633070710346m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8022376200146261261261261261m, 666, 1200.290254929741m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2200259932211450892857142857m, 896, 1093.143289926146m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4740524725440915411355735805m, 863, 1272.107283805551m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0952842928672198697068403909m, 921, 1008.7568337307095m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.734925926974841958041958042m, 715, 1240.472037787012m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4687095973751466208476517755m, 873, 1282.183478508503m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9246356667345172413793103448m, 667, 1283.731989711923m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6394092479166993548387096774m, 775, 1270.542167135442m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1618284942051085776330076004m, 921, 1070.044043162905m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6655012895799673913043478261m, 736, 1225.808949130856m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.630294667804792156862745098m, 765, 1247.175420870666m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5754619689985538243626062323m, 706, 1112.276150112979m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1194942202002475149105367793m, 1006, 1126.211185521449m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4482403044258586800573888092m, 697, 1009.4234921848235m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3968001444954347383720930233m, 688, 960.9984994128591m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6945073628810479041916167665m, 668, 1131.93091840454m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3290805119043726635514018692m, 856, 1137.692918190143m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6013864496521526908635794743m, 799, 1279.50777327207m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9451135572516248372093023256m, 1075, 1015.9970740454967m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9012347442584312676056338028m, 1065, 959.8150026352293m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0208291533090269271383315734m, 947, 966.7252081836485m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0847026887885596059113300493m, 1015, 1100.973229120388m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0033358015275041398344066237m, 1087, 1090.626016260397m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7787744300156308139534883721m, 688, 1223.796807850754m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2869099864887934065934065934m, 910, 1171.088087704802m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4327188790103156654888103651m, 849, 1216.378328279758m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.095730830078425512104283054m, 1074, 1176.814911504229m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4769771087477797001153402537m, 867, 1280.539153284325m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4657604098553175m, 800, 1172.608327884254m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2885666387652550607287449393m, 988, 1273.103839100072m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3449420289456232894736842105m, 760, 1022.1559419986737m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3860341723666791131855309218m, 857, 1187.831285718244m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.077077061421322265625m, 1024, 1102.926910895434m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4760121989954992412746585736m, 659, 972.692039138034m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.611923156803016602809706258m, 783, 1262.135831776762m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1707962408395053763440860215m, 930, 1088.84050398074m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.419948007795669239250275634m, 907, 1287.892843070672m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2831565746741157829839704069m, 811, 1040.6399820607079m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1822157300540748603351955307m, 895, 1058.083078398397m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2124309075565526046986721144m, 979, 1186.969858497865m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4678923330602613365155131265m, 838, 1230.093775104499m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4250604638220263636363636364m, 671, 956.21557122457969m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1756424991396066252587991718m, 966, 1135.67065416886m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.126164410210023719165085389m, 1054, 1186.977288361365m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.990078810407864257528556594m, 963, 953.44589442277328m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1084802461072263056092843327m, 1034, 1146.168574474872m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0917256286979487972508591065m, 873, 953.0764738533093m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.244392474752397979797979798m, 990, 1231.948550004874m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6388249633935580029368575624m, 681, 1116.039800071013m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2872283772993227771010962241m, 821, 1056.814497762744m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3063340970584789473684210526m, 950, 1241.017392205555m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2936926128187229437229437229m, 924, 1195.3719742445m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7763316541159070100143061516m, 699, 1241.655826227019m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2802536070432936693548387097m, 744, 952.50868364021049m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0733756039481946865037194474m, 941, 1010.0464433152512m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1679747524768464285714285714m, 868, 1013.8020851499027m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3795791211108454440599769319m, 867, 1196.095098003103m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2613144675290412262156448203m, 946, 1193.203486282473m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2841513911411386946386946387m, 858, 1101.801893599097m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1967968934552724580454096742m, 1013, 1212.355253070191m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5903162689776970474967907574m, 779, 1238.856373533626m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6417903679080697674418604651m, 688, 1129.551773120752m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4434892385042770562770562771m, 693, 1000.338042283464m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3339415806896031042128603104m, 902, 1203.215305782022m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.102848480021345464725643897m, 893, 984.8436926590615m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3995505966019111644657863145m, 833, 1165.825646969392m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2109238385713364879074658254m, 951, 1151.588570481341m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3590962219271094710947109471m, 813, 1104.94522842674m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3146720859568176470588235294m, 850, 1117.471273063295m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.621612507801472400513478819m, 779, 1263.236143577347m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.180394557848595372460496614m, 886, 1045.8295782538555m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3308846974210011074197120709m, 903, 1201.788881771164m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6889584064672440318302387268m, 754, 1273.474638476302m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3476597256600807486631016043m, 748, 1008.0494747937404m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6221741164263451851851851852m, 675, 1094.967528587783m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5676417529272859195402298851m, 696, 1091.078660037391m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3766227366323505376344086022m, 744, 1024.2073160544688m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3444190843428433476394849785m, 932, 1252.99858660753m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2496272736217761627906976744m, 1032, 1289.615346377673m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0950742958225679513184584178m, 986, 1079.743255681052m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2230463685809048582995951417m, 988, 1208.369812157934m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1105596946718730127462340672m, 863, 958.41301650182641m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8355572052846017069701280228m, 703, 1290.396715315075m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7193974503296364985163204748m, 674, 1158.873881522175m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.092375339300895910780669145m, 1076, 1175.395865087764m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1802889463321553488372093023m, 1075, 1268.810617307067m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.114050110410656981981981982m, 888, 989.2764980446634m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4951586401858927613941018767m, 746, 1115.388345578676m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4093144476246125m, 800, 1127.45155809969m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.024466150616622093023255814m, 1032, 1057.249067436354m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1734665879177191844300278035m, 1079, 1266.170448363219m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3484040136615843575418994413m, 895, 1206.821592227118m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5914277103086697986577181208m, 745, 1185.613644179959m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4128122482204175438596491228m, 855, 1207.954472228457m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1835315072166483050847457627m, 944, 1117.253742812516m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5316019096092787318361955086m, 757, 1159.422645574224m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6683590467949743935309973046m, 742, 1237.922412721871m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9132831128221203515263644773m, 1081, 987.2590449607121m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9168903680078515267175572519m, 1048, 960.9011056722284m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4717030976964606345475910693m, 851, 1252.419336139688m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0879963493331050545094152626m, 1009, 1097.788316477103m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5500011299651739130434782609m, 690, 1069.50077967597m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1781997831457502668089647812m, 937, 1103.973196807568m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3792387303289263736263736264m, 910, 1255.107244599323m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6757555226184109772423025435m, 747, 1251.789375395953m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.997880012946617283950617284m, 1053, 1050.767653632788m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5658474646302965879265091864m, 762, 1193.175768048286m });
        }
    }
}
