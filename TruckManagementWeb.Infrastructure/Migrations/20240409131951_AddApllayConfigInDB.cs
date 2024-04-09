using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class AddApllayConfigInDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "user:fullname", "admin@truck.com", "d401e5f8-2fe9-45e2-9209-69b7db1c1de9" },
                    { 2, "user:fullname", "manager@truck.com", "0261d5ca-050a-423e-90cb-c7e990f67959" },
                    { 3, "user:fullname", "dispo1@truck.com", "62154153-66df-4b35-91ed-56ac983c9a8e" },
                    { 4, "user:fullname", "dispo2@truck.com", "19918df1-9468-434b-aaf9-a3d22b2d12e2" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0261d5ca-050a-423e-90cb-c7e990f67959",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24a78680-9df7-4cdb-9aab-dfc7ef8fdaaa", "AQAAAAEAACcQAAAAEKUt7RvqiJOUbFUfqtr08x9yWxqP6ULWHUP4gtuCzwh/O3ySSfO79TDihJguuRNFAg==", "37a14e82-6b7a-4b50-98ba-3be776399123" });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1120.735232746609m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1152.984795160404m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1284.608547289091m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1068.20405270032m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1095.800949679294m });

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
                column: "Price",
                value: 1293.819608220286m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                column: "Price",
                value: 1093.057535484672m);

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
                column: "Price",
                value: 1281.278553246676m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47,
                column: "Price",
                value: 1236.392168206777m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1131.058434066147m });

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
                column: "Price",
                value: 1013.1775355304345m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1057.043862800029m });

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
                column: "Price",
                value: 1193.451658694351m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 980.1737331299274m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1183.9638029583m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1015.3065485554498m });

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
                column: "Price",
                value: 1068.750607599102m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 96,
                column: "Price",
                value: 1189.71897600855m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 97,
                column: "Price",
                value: 1285.801435341081m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1271.491176618446m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 102,
                column: "Price",
                value: 1173.858532187692m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1274.945066870476m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1002.3516916021293m });

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
                column: "Price",
                value: 1055.120635201568m);

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
                column: "Price",
                value: 1097.860928844621m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1071.463533451704m });

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
                column: "Price",
                value: 1074.099725146757m);

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
                column: "Price",
                value: 1195.787201615007m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1013.8877573717945m });

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
                column: "Price",
                value: 1146.501179266308m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1233.997158756896m });

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
                column: "Price",
                value: 1048.7502565500707m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1080.69117610787m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 968.3356729195874m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 986.7038204029482m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 201,
                column: "Price",
                value: 1079.142207897944m);

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
                column: "Price",
                value: 1080.568107944881m);

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
                column: "Price",
                value: 1205.92042982591m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1248.278757412071m });

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
                column: "Price",
                value: 1099.39118906234m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1251.300734393153m });

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
                column: "Price",
                value: 1153.594890681952m);

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
                column: "Price",
                value: 1118.098513174156m);

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
                column: "Price",
                value: 1216.488987140232m);

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
                column: "Price",
                value: 1063.088341310572m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1287.342185276096m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 268,
                column: "Price",
                value: 1221.31409840197m);

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
                column: "Price",
                value: 1191.724276680675m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1280.691407193324m });

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
                column: "Price",
                value: 1050.198029020317m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 276,
                column: "Price",
                value: 1217.927193373484m);

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
                column: "Price",
                value: 1128.550968420235m);

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
                column: "Price",
                value: 1255.438495709059m);

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
                column: "Price",
                value: 1056.964644397593m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 989.2265033038633m });

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
                column: "Price",
                value: 954.12575375530318m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1209.417168599135m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1152.244330053576m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 327,
                column: "Price",
                value: 1006.6440925375796m);

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
                column: "Price",
                value: 1264.95776028907m);

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
                column: "Price",
                value: 956.81371765726865m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1089.684059069324m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1195.711577737737m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1204.269833944372m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1270.561274264223m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1185.705763030953m });

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
                column: "Price",
                value: 989.9030714690484m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 438,
                column: "Price",
                value: 1285.585859028484m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1135.925219036551m });

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
                column: "Price",
                value: 1010.7426591017172m);

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
                column: "Price",
                value: 1026.6883846158072m);

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
                column: "Price",
                value: 1041.400920248098m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1048.980847049156m });

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
                column: "Price",
                value: 1227.335399343668m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1017.169751453472m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1274.633758617169m });

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
                column: "Price",
                value: 1240.472037787012m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1283.731989711923m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1247.175420870666m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1137.692918190143m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 505,
                column: "Price",
                value: 1279.50777327207m);

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
                column: "Price",
                value: 1090.626016260397m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1176.814911504229m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1280.539153284325m });

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
                column: "Price",
                value: 1262.135831776762m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1088.84050398074m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1231.948550004874m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1238.856373533626m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1203.215305782022m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 552,
                column: "Price",
                value: 984.8436926590615m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1263.236143577347m });

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
                column: "Price",
                value: 1091.078660037391m);

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
                column: "Price",
                value: 1289.615346377673m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 958.41301650182641m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1115.388345578676m });

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
                column: "Price",
                value: 1185.613644179959m);

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
                column: "Price",
                value: 960.9011056722284m);

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
                column: "Price",
                value: 1069.50077967597m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1103.973196807568m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1251.789375395953m });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9eccfd25-4850-4fc7-98dd-b16f96d26d39", "AQAAAAEAACcQAAAAEEVZjGnOkkSmpejuisFgD/6uw7SzthV1ay+VcypXWwM9OAvS/RPzSgK8e0oLMmi9jg==", "99ce5fa8-1e7a-4bb7-97ca-3b358915c3cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19918df1-9468-434b-aaf9-a3d22b2d12e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d22d16fb-2a00-44d0-8d3b-e6bb5d1628d8", "AQAAAAEAACcQAAAAEJ1tH209U7SCTXC3Plfzj4i20U3JMZgaFujYSpLJEZj5XKIoZvQYsf98atB7rG9nrg==", "9ca6d58e-7f24-497b-823f-2af2ace12bf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62154153-66df-4b35-91ed-56ac983c9a8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb3128a6-f99d-4687-8e79-e2c48362bc7e", "AQAAAAEAACcQAAAAEPlLG3uD2OT1Fx8YpflCTA640AyvFzw8xMXV8fXAw+YcBOVUR0mfePsJpLlCGbjWDQ==", "c518909e-c898-4956-b3fa-4d3336fe47a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e04bd4e6-ee6b-41a8-9e60-7aac744bee57", "AQAAAAEAACcQAAAAEFz3EVaB7Qo0ltUefT9+sDIXrIblPRp4JAqltsL4zBstipAVw2yihYSHscR+GDyRqA==", "a6c25403-723e-4d45-b4ee-993cdbe96b2d" });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1103.046380714053m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1249.523999561687m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1040.3067862044592m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1274.537098854399m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 983.3955686253111m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1121.101488237386m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 973.7259288993845m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40,
                column: "Price",
                value: 1015.4370998603453m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                column: "Price",
                value: 1104.361777275616m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1037.0541028191496m });

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
                column: "Price",
                value: 1022.1819992533566m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47,
                column: "Price",
                value: 1074.554820250459m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1276.385562795444m });

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
                column: "Price",
                value: 1123.521429673409m);

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
                column: "Price",
                value: 1201.474597865334m);

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
                column: "Price",
                value: 1189.851615928373m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1163.63899774016m });

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
                column: "Price",
                value: 994.0740032795972m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 96,
                column: "Price",
                value: 1256.045886872096m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 97,
                column: "Price",
                value: 1015.5280991642277m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1053.475931273718m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1281.071817288352m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 102,
                column: "Price",
                value: 1049.4038444937256m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1103.775957527858m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1122.783031919765m });

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
                column: "Price",
                value: 993.8870614388443m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1128.29524581627m });

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
                column: "Price",
                value: 1079.96679758063m);

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
                column: "Price",
                value: 1055.758113957955m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1094.020121717441m });

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
                column: "Price",
                value: 1102.101742442413m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1233.797089830463m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1056.082167626618m });

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
                column: "Price",
                value: 1201.196471026066m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1295.06942525117m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 954.84528240036248m });

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
                column: "Price",
                value: 1185.843352603629m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1120.870191019035m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1164.88604909618m });

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
                column: "Price",
                value: 1002.6992330054763m);

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
                column: "Price",
                value: 995.7359080249664m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1298.179283759741m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1131.676594154777m });

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
                column: "Price",
                value: 1108.908204255686m);

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
                column: "Price",
                value: 1246.170009954519m);

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
                column: "Price",
                value: 1056.325166213809m);

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
                column: "Price",
                value: 1186.448644200787m);

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
                column: "Price",
                value: 1259.727481350636m);

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
                column: "Price",
                value: 1277.256297004329m);

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
                column: "Price",
                value: 999.5842049722327m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1213.637747580639m });

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
                column: "Price",
                value: 1185.019221569455m);

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
                column: "Price",
                value: 1022.2175315034146m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 276,
                column: "Price",
                value: 1233.024117026009m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1042.4424479287426m });

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
                column: "Price",
                value: 990.9398655758388m);

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
                column: "Price",
                value: 1094.216857364752m);

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
                column: "Price",
                value: 1201.568306503619m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1196.63133384518m });

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
                column: "Price",
                value: 1109.40892844133m);

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
                column: "Price",
                value: 1249.634499558083m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1260.019119096527m });

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
                column: "Price",
                value: 1267.757848523226m);

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
                column: "Price",
                value: 1276.146978792985m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 967.8228128708702m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1017.6944167938952m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 996.5708875642361m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1268.687883919458m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1031.6817165998214m });

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
                column: "Price",
                value: 1192.269243658384m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1146.983563487253m });

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
                column: "Price",
                value: 990.0413509088049m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1092.08676977814m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1200.948084260284m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 980.9004293146635m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1008.195273955224m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1023.2894686753756m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 975.5088040021609m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1095.618498853868m });

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
                column: "Price",
                value: 1019.1730383251805m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 438,
                column: "Price",
                value: 1018.8946810063872m);

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
                column: "Price",
                value: 1001.0576341144756m);

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
                column: "Price",
                value: 1254.858242144829m);

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
                column: "Price",
                value: 1122.199173688286m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1001.4424696753292m });

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
                column: "Price",
                value: 1253.502112395848m);

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
                column: "Price",
                value: 1294.548891482406m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1176.851551947773m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 505,
                column: "Price",
                value: 994.7810917979597m);

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
                column: "Price",
                value: 1096.078425231987m);

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
                column: "Price",
                value: 958.57409373712644m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1173.148749901037m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1255.227220236313m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1094.75620466897m });

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
                column: "Price",
                value: 1071.557915354929m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1155.935239899794m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1089.518364344973m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1222.587966066249m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 552,
                column: "Price",
                value: 1106.25369276218m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 988.7299955407165m });

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
                column: "Price",
                value: 1026.6819543899026m);

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
                column: "Price",
                value: 1093.687884705652m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1119.83278349024m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1119.649747795135m });

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
                column: "Price",
                value: 998.9326167460539m);

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
                column: "Price",
                value: 1207.127314356788m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1210.356226609963m });

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
                column: "Price",
                value: 1261.375915834362m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1111.751015842658m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1198.746117371784m });

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
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3469400544000687772925764192m, 916, 1233.797089830463m });

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
        }
    }
}
