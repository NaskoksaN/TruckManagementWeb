using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class CorectionInClaimValueSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "a5494dc9-4497-4c51-b72c-d8c2c0005f1b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dispatcherRoleId",
                column: "ConcurrencyStamp",
                value: "fe72f7e6-9902-4339-bc12-424c3c3fdc3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "managerRoleId",
                column: "ConcurrencyStamp",
                value: "39d18a45-4811-4d29-b9cd-a21efa61110a");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "ClaimValue",
                value: "Hans Due");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0261d5ca-050a-423e-90cb-c7e990f67959",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d475c26-2d9f-4b3f-9d12-ffc769668760", "AQAAAAEAACcQAAAAECH62iu6zCYbknqa2Tv6vTVQBVieJpYab1PnJrLG0461WJLTESvXsZVTzl/2jeWxHA==", "fc6c681a-dfb6-43a1-b446-4c620fdee3d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19918df1-9468-434b-aaf9-a3d22b2d12e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82d2c9f5-17e9-4649-a3f2-6e8cb573fe2a", "AQAAAAEAACcQAAAAEFbiBLrj5a9rMb8AMZivwp08FXZm4FQbTMMXt/+iCX9eZcRVAqZpFIiALXNdfklmKw==", "36008698-7405-4a16-b463-33ed54c0e90c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62154153-66df-4b35-91ed-56ac983c9a8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "174b7cb9-dac3-4c8b-b092-a83aa0ed2805", "AQAAAAEAACcQAAAAEPkiOm+DkSsVLLgsvA8+nIG9j9otOQRYjPfEUvWzgLaGmLMvPWfCgsv30gsaJK6aRw==", "8bb7b791-e8df-46c4-875b-cc99b1ccbecf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c07f81b-2381-4050-86fd-efce27368e43", "AQAAAAEAACcQAAAAEI7pUU0nfqiCi0H95Dak52E3TRV8tfyBP4sJ3UfegYq9qEUz/yJsvkJuGLnbo7Z7vg==", "6e48306f-ee0e-425d-8bf9-83606da6e581" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1064.940282345365m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1005.6259903641013m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1056.455747272772m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 986.886049624684m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 1070.529954760856m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1101.041562973054m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1032.7759795821714m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1178.31852132748m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1172.22863235148m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 1153.514011502714m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1173.975390133094m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1275.126875550906m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1124.891459299495m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1107.998738434606m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1088.108815435229m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 957.55713261915583m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1113.56486858869m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1054.693469831891m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1192.729390641674m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1097.370601701999m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1269.641281026383m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1082.738907644552m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1091.94565924299m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1106.924873139954m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 1025.7492039833393m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1014.1274579123512m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 950.800979855112227m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                column: "Price",
                value: 1265.596282424874m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1090.406928840325m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1278.968424785359m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1190.060601469992m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32,
                column: "Price",
                value: 1149.197857033568m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1168.931355198937m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1279.320430996072m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35,
                column: "Price",
                value: 1256.366875456942m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1202.370082340404m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37,
                column: "Price",
                value: 965.5753430474688m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1011.5058942624993m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1278.637637103999m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1239.840122682277m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1121.158366018364m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42,
                column: "Price",
                value: 1089.544634367344m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1089.155446142892m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 984.2568038609968m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 966.1061692709164m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1132.018105552994m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 954.76883532692245m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1059.489517741078m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1088.910426063092m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 989.9538563783275m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 985.3192366676694m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1200.268601033763m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1038.0732373344073m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1150.287081428637m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1135.651276515247m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1023.1109917971632m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1101.642824246901m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1095.289831897991m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 998.2920261837027m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1263.000233051316m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1115.442887979042m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1147.346172020731m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 981.7881912220334m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1280.78194508489m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1059.184229466237m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1238.682234019424m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 975.7689347698785m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 68,
                column: "Price",
                value: 1110.394997214556m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1059.001793552695m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1291.801024891387m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 977.9819007066569m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 72,
                column: "Price",
                value: 998.3381861990559m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1180.607908472622m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1158.904790865393m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 75,
                column: "Price",
                value: 1202.591098629518m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1260.72154773378m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1114.714479610902m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 955.12417804712265m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 79,
                column: "Price",
                value: 1217.732955950137m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 992.8557945317356m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1170.424465605517m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1202.679981423445m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1242.495901225817m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1045.368523357846m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1045.9754302433474m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1015.0217996784647m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 87,
                column: "Price",
                value: 1128.434349614396m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1053.29424617581m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1216.037375966936m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1004.3656420007331m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 91,
                column: "Price",
                value: 969.3667500357825m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1266.874549916773m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1154.9531859561m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1063.375490460654m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1159.331149033684m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 96,
                column: "Price",
                value: 1081.373533684985m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1125.001280594713m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1159.355594677889m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1087.660653955386m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1000.8471720760972m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 101,
                column: "Price",
                value: 965.2719483346171m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1076.688729476052m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 983.8748469503407m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1277.205442170482m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1232.724865147692m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1090.571771415915m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 958.86577773436846m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1287.719225974069m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1085.76131085023m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 972.1329348148342m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1249.326710336542m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1299.734008645347m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1012.8734386873475m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1174.546115147372m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 115,
                column: "Price",
                value: 1105.43081195646m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1194.521970644139m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1257.752726665096m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1115.105872920468m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 960.8930861483817m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1149.09707948807m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1267.201059834893m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1048.3093928020951m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1016.1358076258682m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 124,
                column: "Price",
                value: 1010.5738287114071m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1104.258210625238m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1028.542362046412m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 127,
                column: "Price",
                value: 1199.087256466742m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1274.030872837814m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1261.467337471947m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1012.4319909417597m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1021.9112766697677m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1109.005242291533m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1125.402824799249m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 134,
                column: "Price",
                value: 995.5090181894438m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 979.4240787068306m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 953.92162464278528m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 977.9283520432628m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1133.96725759186m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1022.9272814239286m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 140,
                column: "Price",
                value: 1126.349901533419m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1150.620344417628m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1121.696129089297m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1165.031666890076m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1171.90806654019m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1276.743798303433m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1040.100422366232m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1051.653247929805m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1093.493707995315m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1033.414142570126m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1015.9266991201713m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1296.132310184326m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 152,
                column: "Price",
                value: 1290.647624224101m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1233.439610801366m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1111.711735058417m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 976.7608591362325m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1293.072829944656m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1164.233810280137m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1224.0200867359m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1102.21372333382m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1192.907808457068m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1202.015368306762m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 981.3809722916524m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 992.8683821078053m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1133.428254708434m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1166.089581960425m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1140.974340476355m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1097.384213882863m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1173.584406633721m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 959.8935349414835m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1097.083619362m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 992.2420943544349m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1136.456514788527m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1203.574329621596m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1129.72955300505m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1135.963183139814m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1033.7462267975225m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1125.942056745043m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1284.770424645605m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1065.34926878495m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1040.5646986787375m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1161.25376820705m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 974.8544941715391m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1100.015565544148m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1036.6926099996341m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1086.683658325842m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1136.811419186536m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1002.8278019404752m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1243.472859622122m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1148.825931868221m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1151.044412768652m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1066.083166151251m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1018.4093721036972m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1075.795994104265m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1009.013811671352m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1078.96704009457m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1141.041680148782m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1164.397234035764m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 198,
                column: "Price",
                value: 1277.352165018376m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1274.131678728197m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1079.878587092519m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1080.997062424182m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 202,
                column: "Price",
                value: 1014.9572838287776m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 952.56450426929641m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 204,
                column: "Price",
                value: 972.8830837974378m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1261.011979342679m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1093.781813779443m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1196.475382780693m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1174.01207831734m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 209,
                column: "Price",
                value: 1273.342397323563m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 210,
                column: "Price",
                value: 1273.858193716739m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1000.6742849070704m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1120.565229611535m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1136.2186086072m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 214,
                column: "Price",
                value: 1113.32204352387m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1119.156719804637m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1216.869982882493m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 997.435568865517m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1050.09744066757m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1081.747134609606m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1141.388828554865m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 221,
                column: "Price",
                value: 1161.479669838805m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1147.857917259304m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1040.9790743879243m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1288.379162410111m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 985.2525964868549m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 226,
                column: "Price",
                value: 1158.33158272323m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1299.046460379213m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1209.63458704756m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1205.231783566459m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1208.014865398107m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1212.938012376925m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1232.91791148714m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1115.631639234949m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1052.575016731826m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 978.4395525974502m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1276.338881918066m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1185.365738399083m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 238,
                column: "Price",
                value: 1031.0098679972066m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1070.74353402883m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1153.812790138281m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1190.166522594362m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 242,
                column: "Price",
                value: 1257.416936484982m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 989.8742282192887m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1215.696228867399m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 999.9193478301788m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1110.562178835645m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1156.429224210716m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 978.8422197877376m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1162.691366560759m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1259.991089934738m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1063.423773103515m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1254.654296734153m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1262.997011430556m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1014.2642118193044m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1208.94301624541m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1254.632547595909m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1234.211085127627m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1169.371006324676m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1239.784270782295m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1196.062722562834m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1113.509489657076m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1042.6024023383227m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1053.157962904856m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1071.353431887973m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 996.4981996659223m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 983.7190440429752m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1228.96675013256m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1149.450386271148m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 984.4113024825855m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1124.132421193403m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 271,
                column: "Price",
                value: 1039.2008737978416m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 986.9436765509293m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 273,
                column: "Price",
                value: 1128.117884659205m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1160.3049619942m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1049.455543943512m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 276,
                column: "Price",
                value: 1284.401653650525m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 994.5599360870867m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 964.0622242904784m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1288.845342445362m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1007.7193540761659m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1131.580405439509m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 282,
                column: "Price",
                value: 1102.123504293876m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1144.1746933394m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1248.160659082232m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 285,
                column: "Price",
                value: 1092.236387449751m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 950.978141883388867m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1050.110721320763m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 288,
                column: "Price",
                value: 1263.4966856081m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 289,
                column: "Price",
                value: 954.42158545036483m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1125.580993077754m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1126.588803499576m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1007.776086415856m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1242.40496489618m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1051.620952663501m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1085.714755444826m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1064.068079452565m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1047.728882674802m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1133.756141875169m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 981.7951766039952m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1285.254673758026m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1155.100994235392m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1069.891085502091m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 303,
                column: "Price",
                value: 1154.107887531364m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1245.753712521198m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 956.11629659824699m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1011.9849318624871m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1298.525883881611m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1236.885136944439m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1010.0895724999927m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1002.0213926777166m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1290.091203817827m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1283.997616085521m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1032.8526128242268m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1298.237709461684m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1073.782240517244m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1245.261750762088m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1139.069976244342m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1199.689070888248m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1005.9936889283757m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 974.0530171605859m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1223.471297166959m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1113.495178947093m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1245.109214005558m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1010.6637687845539m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1271.296881668137m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1082.937392401912m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1042.3464957474454m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 328,
                column: "Price",
                value: 1039.6559737090103m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1193.660711065477m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1237.213231244045m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1014.5194686573284m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 332,
                column: "Price",
                value: 1234.20854178921m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 998.7587082954125m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1026.2288248538219m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1014.3272421799152m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1268.928656635673m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 981.9639702300132m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1266.266735284879m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 964.037838638251m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1088.790373985916m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1260.244084659747m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 962.6171124175079m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1191.74848420203m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 957.80804969841363m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1138.080156843168m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1046.8222036343204m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 980.2446487032164m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1189.294522244567m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 972.4121854584614m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 970.6877464224279m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 953.93033757752441m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 960.2213771358697m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1033.7946482699931m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 354,
                column: "Price",
                value: 1134.246124189753m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 995.9168246474915m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1003.5894060478119m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 975.3361759321138m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1123.29245541483m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1004.3175314567552m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1110.731203623712m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1178.221683110271m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1162.236912457221m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1065.310384543604m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 980.5151703576714m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1091.987798430556m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1158.414495384166m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1124.61669924772m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1145.671970694973m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1200.708747479408m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 952.42698644321877m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1253.094594341285m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1061.400853626556m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1070.929153045352m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1004.94472453275m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 959.48985654452995m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1228.83927952326m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 377,
                column: "Price",
                value: 1050.163916623189m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1273.925136815615m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 958.06644438837318m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1286.985087030881m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1047.5042778222312m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1124.999669106222m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1215.759456616685m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1154.707309397285m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1026.5498780724016m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1192.956392020175m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1257.663039233438m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1176.30218877756m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1271.36494282474m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1270.089432641844m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 959.56095836929546m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1203.15206222125m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1180.543876832105m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1201.877810828222m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1196.86079395453m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1288.688823809366m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 971.4301758490519m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1081.564519148663m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 993.5194213779752m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1137.320372573m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1176.190947774314m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1226.389175879548m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 403,
                column: "Price",
                value: 1017.4784718052745m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1221.75461384369m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1195.415192892663m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1083.089318425562m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1078.543712785579m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1166.118566785026m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 409,
                column: "Price",
                value: 1264.549736700785m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1151.400345637279m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 411,
                column: "Price",
                value: 1181.626926403524m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1179.710118782733m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1270.226278243278m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1214.525092270636m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1236.44592788643m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 957.13097772562651m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1203.235640969243m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 954.67860872897528m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 982.5993168555625m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 972.145283519312m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1153.856628412817m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1033.2610109223141m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1260.884537051629m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1036.0087118101308m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1144.386838540941m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1155.493782319282m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 427,
                column: "Price",
                value: 1229.971498175992m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1283.480047432677m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 966.8513804946414m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1202.468617513089m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1000.7879521132002m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1262.349389592073m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1111.173370298832m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1229.753662849896m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 435,
                column: "Price",
                value: 1199.32473160355m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1195.036281497179m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1205.623498930834m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1015.3403609815611m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1039.442043116983m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1207.824143988009m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1264.485741027964m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 981.6301586467745m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1186.734908114416m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1179.867653879391m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1129.25883959874m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1125.02053271598m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1028.5740469975433m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1007.8614016895612m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1004.6963161273177m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1135.043891038177m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1084.325512656611m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1049.8818169861231m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1068.108953273723m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1264.995356283473m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1031.6713824519982m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 456,
                column: "Price",
                value: 1082.152311775849m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1135.607012153463m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1022.9402108273835m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1251.437774756252m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1169.582855394556m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1010.0739778850067m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 965.215657121513m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1028.4584720746792m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 976.9278400671916m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1085.203766193731m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1015.2935116905939m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1221.129017497363m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1138.858420752175m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1246.091309717973m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1290.757491665962m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1122.575304553644m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1081.11912195991m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1041.3630135886469m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1132.132790199964m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1005.1303225880759m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1001.2849273819149m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1090.08108999695m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1290.065797071725m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1142.908045268469m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1034.1162827882011m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1276.525117804425m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1174.694565306268m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1185.753376207393m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1065.043733797907m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 988.0191053255012m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1072.619821501132m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1052.630238792418m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1096.41693297255m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1139.681042557769m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1233.274939193732m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1124.854842413282m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1248.158669814271m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1255.350006438092m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1178.68617328292m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1104.291317478116m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1204.337633204504m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 963.750638284239m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1085.554749970946m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1287.241117287641m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1218.937808503649m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1052.908507193807m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1091.056700820533m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1045.425124278677m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1285.194056823489m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1095.495157881284m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1272.022796453025m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1139.922310763128m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1072.981390196031m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1288.355880795508m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1195.163097422044m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1073.617307265484m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1275.713849514127m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1164.108952493349m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1072.838209699709m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1242.619954679709m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 516,
                column: "Price",
                value: 1266.166271515584m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1164.235977271599m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1224.793637721508m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1159.517752128696m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 520,
                column: "Price",
                value: 1232.435626322321m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1233.865937041049m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1276.811148447712m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1197.598153786667m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 957.81892044245119m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1242.460334860807m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 526,
                column: "Price",
                value: 1002.5754519248557m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1255.102917982639m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1175.117925385008m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 994.3192915327925m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1093.665774605277m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1273.102572082142m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1139.52291194906m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1055.64869316798m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1284.41267430876m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 958.27670934886426m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 969.1046708578633m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1203.107583229666m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1173.873778839608m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 968.2048570667737m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 993.8016198397031m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 541,
                column: "Price",
                value: 1070.014862799954m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1247.362423879215m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 979.6638385862618m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1233.947043659875m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1271.792714930155m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1146.607822227482m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1134.380141583239m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 985.6228494766874m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1282.526585380366m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1114.997304925833m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1235.224573907548m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1082.138426256758m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1234.270114800672m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1106.253489292504m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1289.500039184243m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1083.247052454577m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1293.077688362687m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1165.718781175674m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1254.666046720875m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1173.057188277284m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1106.103069669118m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1088.295168024589m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1038.8590745339736m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1261.786087281886m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1129.190299028849m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1074.744284700781m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 567,
                column: "Price",
                value: 1224.366838763256m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1199.971771392059m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1036.6205181099684m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1216.793226106826m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1219.697946928565m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1002.4305995969344m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 966.8554685525427m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1046.842698181754m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1039.7803239704294m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1073.443505045899m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 986.4630402160119m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1105.951338599005m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1034.6613683549661m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1009.986834509479m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1075.648604328558m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1220.599044782326m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 991.9413826086435m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1175.915872899056m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1173.258888480741m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1037.0835996853099m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1037.1986903166633m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1014.9296973707866m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 965.9022258890806m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1049.2512007816613m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1106.049225288273m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 975.8580465073204m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1271.45867180475m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 967.9188124074266m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1257296853545084566596194503m, 946, 1064.940282345365m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1186051060779769744160177976m, 899, 1005.6259903641013m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0398186488905236220472440945m, 1016, 1056.455747272772m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4449283303436076134699853587m, 683, 986.886049624684m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0547093150353261083743842365m, 1015, 1070.529954760856m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0773400811869412915851272016m, 1022, 1101.041562973054m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.334335890933037984496124031m, 774, 1032.7759795821714m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7853310929204242424242424242m, 660, 1178.31852132748m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3097526618452290502793296089m, 895, 1172.22863235148m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4509610207581308176100628931m, 795, 1153.514011502714m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7138326863256846715328467153m, 685, 1173.975390133094m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2738530225283776223776223776m, 1001, 1275.126875550906m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3156625254964853801169590643m, 855, 1124.891459299495m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1837593359344081196581196581m, 936, 1107.998738434606m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2010031075444028697571743929m, 906, 1088.108815435229m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4574689994203285083713850837m, 657, 957.55713261915583m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2948428704519651162790697674m, 860, 1113.56486858869m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3283293070930617128463476071m, 794, 1054.693469831891m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2950373405447057546145494028m, 921, 1192.729390641674m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3890767110151886075949367089m, 790, 1097.370601701999m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3170552707742562240663900415m, 964, 1269.641281026383m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1196886325176339193381592554m, 967, 1082.738907644552m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3414565838365970515970515971m, 814, 1091.94565924299m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EuPerKm", "TripPrice" },
                values: new object[] { 1.1124873096883959798994974874m, 1106.924873139954m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0877510116472314952279957582m, 943, 1025.7492039833393m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0285268335825062880324543611m, 986, 1014.1274579123512m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.937673550152970638067061144m, 1014, 950.800979855112227m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4077822941322291434927697442m, 899, 1265.596282424874m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5019379185128443526170798898m, 726, 1090.406928840325m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2726053977963771144278606965m, 1005, 1278.968424785359m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8252463212729938650306748466m, 652, 1190.060601469992m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0710138462568201304753028891m, 1073, 1149.197857033568m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6100982853979848484848484848m, 726, 1168.931355198937m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.535798836729978391356542617m, 833, 1279.320430996072m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4868247046827715976331360947m, 845, 1256.366875456942m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2524688357712541666666666667m, 960, 1202.370082340404m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0740548865934024471635150167m, 899, 965.5753430474688m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0558516641570973903966597077m, 958, 1011.5058942624993m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6868570410342994722955145119m, 758, 1278.637637103999m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.275555681771889917695473251m, 972, 1239.840122682277m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4049603584190025062656641604m, 798, 1121.158366018364m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2552357538794285714285714286m, 868, 1089.544634367344m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2576852726823233256351039261m, 866, 1089.155446142892m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0997282724703874860335195531m, 895, 984.2568038609968m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0084615545625432150313152401m, 958, 966.1061692709164m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2251278198625476190476190476m, 924, 1132.018105552994m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.116688696288798187134502924m, 855, 954.76883532692245m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5092443272664928774928774929m, 702, 1059.489517741078m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4308941209764678055190538765m, 761, 1088.910426063092m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1841553305960855263157894737m, 836, 989.9538563783275m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0538173654199672727272727273m, 935, 985.3192366676694m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6419543105797031463748290014m, 731, 1200.268601033763m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.320703864293139058524173028m, 786, 1038.0732373344073m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1560674185212432160804020101m, 995, 1150.287081428637m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5346638871827662162162162162m, 740, 1135.651276515247m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1547528124121480812641083521m, 886, 1023.1109917971632m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4552745366537661822985468956m, 757, 1101.642824246901m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3228138066400857487922705314m, 828, 1095.289831897991m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3807635216925348547717842324m, 723, 998.2920261837027m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7044537558047449392712550607m, 741, 1263.000233051316m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0694562684362818791946308725m, 1043, 1115.442887979042m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7331513172518595166163141994m, 662, 1147.346172020731m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3693001272273827057182705718m, 717, 981.7881912220334m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2117142337605392620624408704m, 1057, 1280.78194508489m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3737798047551712062256809339m, 771, 1059.184229466237m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5759315954445597964376590331m, 786, 1238.682234019424m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1870668306202901459854014599m, 822, 975.7689347698785m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.273388758273573394495412844m, 872, 1110.394997214556m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0962751486052743271221532091m, 966, 1059.001793552695m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5526454626098401442307692308m, 832, 1291.801024891387m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1532805432861520047169811321m, 848, 977.9819007066569m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2219561642583303549571603427m, 817, 998.3381861990559m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4397657420397829268292682927m, 820, 1180.607908472622m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3214421788658985176738882554m, 877, 1158.904790865393m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5844415001706429512516469038m, 759, 1202.591098629518m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EuPerKm", "TripPrice" },
                values: new object[] { 1.5680616265345522388059701493m, 1260.72154773378m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2916737886568968713789107764m, 863, 1114.714479610902m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9541700080390835664335664336m, 1001, 955.12417804712265m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6704155774350301783264746228m, 729, 1217.732955950137m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1193413692578755355129650507m, 887, 992.8557945317356m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2041403967134948559670781893m, 972, 1170.424465605517m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7843916638330044510385756677m, 674, 1202.679981423445m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5929434631100217948717948718m, 780, 1242.495901225817m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2625223712051280193236714976m, 828, 1045.368523357846m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0174858270849682879377431907m, 1028, 1045.9754302433474m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5425863216997943768996960486m, 658, 1015.0217996784647m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2238984269136616052060737527m, 922, 1128.434349614396m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1651485024068694690265486726m, 904, 1053.29424617581m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1614492607134059216809933142m, 1047, 1216.037375966936m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.935163540037926536312849162m, 1074, 1004.3656420007331m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9448019006196710526315789474m, 1026, 969.3667500357825m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1828894023499281045751633987m, 1071, 1266.874549916773m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6266946281071830985915492958m, 710, 1154.9531859561m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3810071304683818181818181818m, 770, 1063.375490460654m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2439175418816351931330472103m, 932, 1159.331149033684m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6359660116263010590015128593m, 661, 1081.373533684985m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2555817863780279017857142857m, 896, 1125.001280594713m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1422222607663931034482758621m, 1015, 1159.355594677889m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5022937209328535911602209945m, 724, 1087.660653955386m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0535233390274707368421052632m, 950, 1000.8471720760972m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9371572313928321359223300971m, 1030, 965.2719483346171m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0853717031008588709677419355m, 992, 1076.688729476052m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9406069282508037284894837476m, 1046, 983.8748469503407m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2927180588770060728744939271m, 988, 1277.205442170482m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6933033861918846153846153846m, 728, 1232.724865147692m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3076400136881474820143884892m, 834, 1090.571771415915m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3796629895458538992805755396m, 695, 958.86577773436846m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4420148107212418812989921613m, 893, 1287.719225974069m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.166231268367593984962406015m, 931, 1085.76131085023m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8984592743205491682070240296m, 1082, 972.1329348148342m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4697961298076964705882352941m, 850, 1249.326710336542m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7902672295390454545454545455m, 726, 1299.734008645347m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3761867373469395380434782609m, 736, 1012.8734386873475m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1768999149773266533066132265m, 998, 1174.546115147372m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5122172530184131326949384405m, 731, 1105.43081195646m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8349031807129631336405529954m, 651, 1194.521970644139m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5026914297074026284348864994m, 837, 1257.752726665096m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3149833407080990566037735849m, 848, 1115.105872920468m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9090757674062267738883632923m, 1057, 960.8930861483817m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4600979408997077509529860229m, 787, 1149.09707948807m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6372106716213087855297157623m, 774, 1267.201059834893m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0369034547993027695351137488m, 1011, 1048.3093928020951m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.098525197433371027027027027m, 925, 1016.1358076258682m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1917144206502442216981132075m, 848, 1010.5738287114071m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0224613061344796296296296296m, 1080, 1104.258210625238m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9558943885189702602230483271m, 1076, 1028.542362046412m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2635271406393487881981032666m, 949, 1199.087256466742m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4494094116471149032992036405m, 879, 1274.030872837814m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8072597958050816618911174785m, 698, 1261.467337471947m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9444328273710444962686567164m, 1072, 1012.4319909417597m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1665653843262188356164383562m, 876, 1021.9112766697677m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6119262242609491279069767442m, 688, 1109.005242291533m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.40675353099906125m, 800, 1125.402824799249m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2585449028943663716814159292m, 791, 995.5090181894438m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2752917691495190104166666667m, 768, 979.4240787068306m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3103319019818479120879120879m, 728, 953.92162464278528m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2103073663901767326732673267m, 808, 977.9283520432628m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0903531322998653846153846154m, 1040, 1133.96725759186m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1391172398930162583518930958m, 898, 1022.9272814239286m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4167923289728540880503144654m, 795, 1126.349901533419m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0693497624699144981412639405m, 1076, 1150.620344417628m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4995937554669745989304812834m, 748, 1121.696129089297m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5829234604484728260869565217m, 736, 1165.031666890076m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4239466179103159173754556501m, 823, 1171.90806654019m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6977976041269055851063829787m, 752, 1276.743798303433m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2265335169413113207547169811m, 848, 1040.100422366232m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3587251265242958656330749354m, 774, 1051.653247929805m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1355074849380218068535825545m, 963, 1093.493707995315m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1005475426731906283280085197m, 939, 1033.414142570126m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0593604787488751824817518248m, 959, 1015.9266991201713m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7491664105051632928475033738m, 741, 1296.132310184326m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8127073373934002808988764045m, 712, 1290.647624224101m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5853979573282339331619537275m, 778, 1233.439610801366m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4161932930680471337579617834m, 785, 1111.711735058417m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3093309103702848525469168901m, 746, 976.7608591362325m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.316774775911054989816700611m, 982, 1293.072829944656m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7801740218350718654434250765m, 654, 1164.233810280137m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.711916205225034965034965035m, 715, 1224.0200867359m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3458043019948962148962148962m, 819, 1102.21372333382m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5969314704913895582329317269m, 747, 1192.907808457068m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3864075759016862745098039216m, 867, 1202.015368306762m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2646662014067685567010309278m, 776, 981.3809722916524m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0028973556644497979797979798m, 990, 992.8683821078053m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6791529699384207407407407407m, 675, 1133.428254708434m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.072759505023390064397424103m, 1087, 1166.089581960425m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1738419140703240740740740741m, 972, 1140.974340476355m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4496488954859484808454425363m, 757, 1097.384213882863m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0756960647421824014665444546m, 1091, 1173.584406633721m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2531247192447565274151436031m, 766, 959.8935349414835m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.157261201858649789029535865m, 948, 1097.083619362m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2372095939581482543640897756m, 802, 992.2420943544349m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4259178353682898368883312422m, 797, 1136.456514788527m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.252418657254522372528616025m, 961, 1203.574329621596m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5328759199525780189959294437m, 737, 1129.72955300505m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3286119101050456140350877193m, 855, 1135.963183139814m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3270169792009274711168164313m, 779, 1033.7462267975225m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.206797488472714898177920686m, 933, 1125.942056745043m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8095358093600070422535211268m, 710, 1284.770424645605m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1956781916778338945005611672m, 891, 1065.34926878495m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9724903725969509345794392523m, 1070, 1040.5646986787375m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0852838955206074766355140187m, 1070, 1161.25376820705m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1932123551671225214198286414m, 817, 974.8544941715391m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3269186556624221954161640531m, 829, 1100.015565544148m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4279512534430221763085399449m, 726, 1036.6926099996341m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2447693680708384879725085911m, 873, 1086.683658325842m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1300312317957614314115308151m, 1006, 1136.811419186536m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.969852806518834816247582205m, 1034, 1002.8278019404752m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2993446809008589341692789969m, 957, 1243.472859622122m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1110502242439274661508704062m, 1034, 1148.825931868221m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1121202055735768115942028986m, 1035, 1151.044412768652m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1613106385089880174291938998m, 918, 1066.083166151251m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1081712427678968443960826986m, 919, 1018.4093721036972m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2611910833578722157092614302m, 853, 1075.795994104265m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2644283354277593984962406015m, 798, 1009.013811671352m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5196718874571408450704225352m, 710, 1078.96704009457m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2308971738390312837108953614m, 927, 1141.041680148782m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6973720612766239067055393586m, 686, 1164.397234035764m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3944892631204978165938864629m, 916, 1277.352165018376m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7870009519329551192145862553m, 713, 1274.131678728197m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3566313908197474874371859296m, 796, 1079.878587092519m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1944718921814165745856353591m, 905, 1080.997062424182m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3062513305389673101673101673m, 777, 1014.9572838287776m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4345850967911090512048192771m, 664, 952.56450426929641m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0506296801268226781857451404m, 926, 972.8830837974378m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9340674529795690184049079755m, 652, 1261.011979342679m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3052288947248723150357995227m, 838, 1093.781813779443m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3033500901750468409586056645m, 918, 1196.475382780693m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3699090762162660443407234539m, 857, 1174.01207831734m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4892893535948105263157894737m, 855, 1273.342397323563m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9597818364872907692307692308m, 650, 1273.858193716739m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.350437631453536302294197031m, 741, 1000.6742849070704m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6503169802820839469808541973m, 679, 1120.565229611535m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1922545735647429171038824764m, 953, 1136.2186086072m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4236854776520076726342710997m, 782, 1113.32204352387m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0498655908111041275797373358m, 1066, 1119.156719804637m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1153712033753373052245646196m, 1091, 1216.869982882493m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1803971229177715976331360947m, 845, 997.435568865517m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.586249910373972809667673716m, 662, 1050.09744066757m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0185942887096101694915254237m, 1062, 1081.747134609606m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6098573040266078984485190409m, 709, 1141.388828554865m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6335860335285583684950773558m, 711, 1161.479669838805m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6189815476153794076163610719m, 709, 1147.857917259304m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4538813888099501396648044693m, 716, 1040.9790743879243m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7746269454684724517906336088m, 726, 1288.379162410111m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.033843228212859286463798531m, 953, 985.2525964868549m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3888867898360071942446043165m, 834, 1158.33158272323m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8143106988536494413407821229m, 716, 1299.046460379213m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3321966817704405286343612335m, 908, 1209.63458704756m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4279997435621552132701421801m, 844, 1205.231783566459m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5291327410102620253164556962m, 790, 1208.014865398107m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1389089318093192488262910798m, 1065, 1212.938012376925m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3533676306115697036223929748m, 911, 1232.91791148714m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5691021648874106891701828411m, 711, 1115.631639234949m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3831471967566701708278580815m, 761, 1052.575016731826m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1118631279516479545454545455m, 880, 978.4395525974502m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8632684407563007299270072993m, 685, 1276.338881918066m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8124858385307079510703363914m, 654, 1185.365738399083m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5388206985032934328358208955m, 670, 1031.0098679972066m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6223386879224696969696969697m, 660, 1070.74353402883m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1894977217920422680412371134m, 970, 1153.812790138281m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2206836129172943589743589744m, 975, 1190.166522594362m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7343681882551475862068965517m, 725, 1257.416936484982m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2220669484188749382716049383m, 810, 989.8742282192887m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5605856596500629011553273427m, 779, 1215.696228867399m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0821637963530073593073593074m, 924, 999.9193478301788m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3626529801664355828220858896m, 815, 1110.562178835645m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6380017340095127478753541076m, 706, 1156.429224210716m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2099409391690205191594561187m, 809, 978.8422197877376m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6375934740292380281690140845m, 710, 1162.691366560759m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1634266758400166204986149584m, 1083, 1259.991089934738m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.995715143355351123595505618m, 1068, 1063.423773103515m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8104679606553434343434343434m, 693, 1254.654296734153m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2285963146211634241245136187m, 1028, 1262.997011430556m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1525729679764822727272727273m, 880, 1014.2642118193044m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7148127890005815602836879433m, 705, 1208.94301624541m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.213377705605327852998065764m, 1034, 1254.632547595909m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.211198317102676153091265947m, 1019, 1234.211085127627m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2993011181385288888888888889m, 900, 1169.371006324676m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2702707692441547131147540984m, 976, 1239.784270782295m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.320157530422554083885209713m, 906, 1196.062722562834m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6644386990389775784753363229m, 669, 1113.509489657076m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4380722790873416551724137931m, 725, 1042.6024023383227m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3677376141621506493506493506m, 770, 1053.157962904856m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1421678378336599147121535181m, 938, 1071.353431887973m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4400263000952634393063583815m, 692, 996.4981996659223m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0751027803748362841530054645m, 915, 983.7190440429752m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7407461050036260623229461756m, 706, 1228.96675013256m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2453416969351549295774647887m, 923, 1149.450386271148m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2508402826970590851334180432m, 787, 984.4113024825855m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1984354170505362473347547974m, 938, 1124.132421193403m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3104676844865593947036569987m, 793, 1039.2008737978416m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5137172953235111963190184049m, 652, 986.9436765509293m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6812487103713934426229508197m, 671, 1128.117884659205m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1912781950659137577002053388m, 974, 1160.3049619942m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5478695338399882005899705015m, 678, 1049.455543943512m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5759529492644478527607361963m, 815, 1284.401653650525m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2899610065980372243839169909m, 771, 994.5599360870867m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2328161435939621483375959079m, 782, 964.0622242904784m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5679383728045766423357664234m, 822, 1288.845342445362m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9245131688772164220183486239m, 1090, 1007.7193540761659m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2858868243630784090909090909m, 880, 1131.580405439509m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2084687547081973684210526316m, 912, 1102.123504293876m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2423177994998914223669923996m, 921, 1144.1746933394m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6958704607095543478260869565m, 736, 1248.160659082232m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1413128395504190177638453501m, 957, 1092.236387449751m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8732581651821752681359044995m, 1089, 950.978141883388867m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1183287766994281150159744409m, 939, 1050.110721320763m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5113596717800239234449760766m, 836, 1263.4966856081m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9221464593723331690821256039m, 1035, 954.42158545036483m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1111362221892931885488647581m, 1013, 1125.580993077754m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0874409300188957528957528958m, 1036, 1126.588803499576m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2025967618327637231503579952m, 838, 1007.776086415856m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1600419840300466853408029879m, 1071, 1242.40496489618m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3947227488905848806366047745m, 754, 1051.620952663501m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5227415924892370266479663394m, 713, 1085.714755444826m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2758610065378477218225419664m, 834, 1064.068079452565m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0435546640187270916334661355m, 1004, 1047.728882674802m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5901208160942061711079943899m, 713, 1133.756141875169m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4786071936807156626506024096m, 664, 981.7951766039952m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.645652591239469910371318822m, 781, 1285.254673758026m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0785256715549878618113912232m, 1071, 1155.100994235392m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0055367344944464285714285714m, 1064, 1069.891085502091m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2436507408743146551724137931m, 928, 1154.107887531364m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6995275750630259208731241473m, 733, 1245.753712521198m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1745900449609913882063882064m, 814, 956.11629659824699m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1383407557508291338582677165m, 889, 1011.9849318624871m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6211309411755443196004993758m, 801, 1298.525883881611m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1768650208795803996194100856m, 1051, 1236.885136944439m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0141461571285067269076305221m, 996, 1010.0895724999927m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1610908374017573580533024334m, 863, 1002.0213926777166m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2978784746658219315895372233m, 994, 1290.091203817827m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9603017039473603053435114504m, 655, 1283.997616085521m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.125111778675628322440087146m, 918, 1032.8526128242268m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9972887837872061538461538462m, 650, 1298.237709461684m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6050556659450582959641255605m, 669, 1073.782240517244m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7514229968524444444444444444m, 711, 1245.261750762088m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0973699193105414258188824663m, 1038, 1139.069976244342m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.54798589792032m, 775, 1199.689070888248m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1054875702509623076923076923m, 910, 1005.9936889283757m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4430415069045717037037037037m, 675, 974.0530171605859m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1265849881832034990791896869m, 1086, 1223.471297166959m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1068540546193767395626242545m, 1006, 1113.495178947093m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3147932566056578669482576558m, 947, 1245.109214005558m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.076319242582059531416400426m, 939, 1010.6637687845539m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.855907856449835036496350365m, 685, 1271.296881668137m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0679855940847258382642998028m, 1014, 1082.937392401912m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0779177825723323681489141675m, 967, 1042.3464957474454m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.493758582915244683908045977m, 696, 1039.6559737090103m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.664798760202896792189679219m, 717, 1193.660711065477m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8356279395312240356083086053m, 674, 1237.213231244045m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4703180705178672463768115942m, 690, 1014.5194686573284m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5427606772365125m, 800, 1234.20854178921m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4580419099203102189781021898m, 685, 998.7587082954125m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.076840319888585414480587618m, 953, 1026.2288248538219m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9857407601359720116618075802m, 1029, 1014.3272421799152m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6268316110713756410256410256m, 780, 1268.928656635673m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1774148324100877697841726619m, 834, 981.9639702300132m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8037987682120783475783475783m, 702, 1266.266735284879m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.185778399309041820418204182m, 813, 964.037838638251m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6372787578735578947368421053m, 665, 1088.790373985916m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6984421626142142857142857143m, 742, 1260.244084659747m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3222762533207526098901098901m, 728, 962.6171124175079m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2025716288617860746720484359m, 991, 1191.74848420203m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2471458980448094140625m, 768, 957.80804969841363m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2859662789188338983050847458m, 885, 1138.080156843168m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0133806424339984511132623427m, 1033, 1046.8222036343204m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.895200592423028675799086758m, 1095, 980.2446487032164m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4664544047405265104808877928m, 811, 1189.294522244567m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0889274193263845464725643897m, 893, 972.4121854584614m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4380559206258191111111111111m, 675, 970.6877464224279m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2804434061443280671140939597m, 745, 953.93033757752441m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1568932254649032530120481928m, 830, 960.2213771358697m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1056627254224525133689839572m, 935, 1033.7946482699931m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0502278927682898148148148148m, 1080, 1134.246124189753m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1984558660017948255114320096m, 831, 995.9168246474915m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3507259839136095558546433378m, 743, 1003.5894060478119m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.8997566198635736162361623616m, 1084, 975.3361759321138m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1056028104476673228346456693m, 1016, 1123.29245541483m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3929508064587450762829403606m, 721, 1004.3175314567552m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5981743937031827338129496403m, 695, 1110.731203623712m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1746975903392532402791625125m, 1003, 1178.221683110271m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4919600930131206675224646983m, 779, 1162.236912457221m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3657825442866717948717948718m, 780, 1065.310384543604m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9232722884723836158192090395m, 1062, 980.5151703576714m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2408952254892681818181818182m, 880, 1091.987798430556m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2206685936608703898840885142m, 949, 1158.414495384166m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.315341168710783625730994152m, 855, 1124.61669924772m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0727265643211357677902621723m, 1068, 1145.671970694973m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6225793884856864864864864865m, 740, 1200.708747479408m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0897333940997926430205949657m, 874, 952.42698644321877m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9102051743007393292682926829m, 656, 1253.094594341285m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4076934398230185676392572944m, 754, 1061.400853626556m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4260041984625193075898801598m, 751, 1070.929153045352m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0645600895474046610169491525m, 944, 1004.94472453275m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.904325972238011262959472196m, 1061, 959.48985654452995m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.515214894603279901356350185m, 811, 1228.83927952326m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.542090920151525697503671072m, 681, 1050.163916623189m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1591675494227616014558689718m, 1099, 1273.925136815615m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4649334012054635779816513761m, 654, 958.06644438837318m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6436591149819680715197956577m, 783, 1286.985087030881m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1312141229181762419006479482m, 926, 1047.5042778222312m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4367811865979846743295019157m, 783, 1124.999669106222m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3831165604285381114903299204m, 879, 1215.759456616685m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5667670412446200814111261872m, 737, 1154.707309397285m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4964283936915475218658892128m, 686, 1026.5498780724016m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1025474972460027726432532348m, 1082, 1192.956392020175m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3032777608636663212435233161m, 965, 1257.663039233438m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7688754718459548872180451128m, 665, 1176.30218877756m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9175941822394268476621417798m, 663, 1271.36494282474m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1970682682769500471253534402m, 1061, 1270.089432641844m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9692534933023186464646464646m, 990, 959.56095836929546m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5133988204040880503144654088m, 795, 1203.15206222125m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7779275253495557228915662651m, 664, 1180.543876832105m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4710866717603696450428396573m, 817, 1201.877810828222m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8328649218292955589586523737m, 653, 1196.86079395453m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4223938452642008830022075055m, 906, 1288.688823809366m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0582028059357863834422657952m, 918, 971.4301758490519m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6264128107498691729323308271m, 665, 1081.564519148663m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0580611516272366347177848775m, 939, 993.5194213779752m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4075747185309405940594059406m, 808, 1137.320372573m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4647458876392453300124533001m, 803, 1176.190947774314m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.145087932660642390289449113m, 1071, 1226.389175879548m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0699037558415084121976866456m, 951, 1017.4784718052745m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6333617832134893048128342246m, 748, 1221.75461384369m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.087729929838637852593266606m, 1099, 1195.415192892663m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1142894222485205761316872428m, 972, 1083.089318425562m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.069983842049185515873015873m, 1008, 1078.543712785579m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3403661687184206896551724138m, 870, 1166.118566785026m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2470904701191173570019723866m, 1014, 1264.549736700785m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4914512249187551813471502591m, 772, 1151.400345637279m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4642217179721486988847583643m, 807, 1181.626926403524m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0862892438146712707182320442m, 1086, 1179.710118782733m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4566815117468784403669724771m, 872, 1270.226278243278m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2852117378525248677248677249m, 945, 1214.525092270636m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4580730281679599056603773585m, 848, 1236.44592788643m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0182244443889643723404255319m, 940, 957.13097772562651m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1481256116118730916030534351m, 1048, 1203.235640969243m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0631164907895047661469933185m, 898, 954.67860872897528m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0785942007196075740944017563m, 911, 982.5993168555625m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0601366232489770992366412214m, 917, 972.145283519312m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4405201353468377028714107366m, 801, 1153.856628412817m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0796875767213313479623824451m, 957, 1033.2610109223141m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6375123857813363636363636364m, 770, 1260.884537051629m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2680645187394501835985312118m, 817, 1036.0087118101308m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0705208966706651075771749298m, 1069, 1144.386838540941m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3871473977422352941176470588m, 833, 1155.493782319282m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2349111427469799196787148594m, 996, 1229.971498175992m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8764328178840307017543859649m, 684, 1283.480047432677m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3391293358651542936288088643m, 722, 966.8513804946414m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8442770207255966257668711656m, 652, 1202.468617513089m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3326071266487352862849533955m, 751, 1000.7879521132002m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8954195038920015015015015015m, 666, 1262.349389592073m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2699124231986651428571428571m, 875, 1111.173370298832m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5507612394071828499369482976m, 793, 1229.753662849896m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0992893965202108157653528873m, 1091, 1199.32473160355m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4415395434224113389626055489m, 829, 1195.036281497179m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1152853829147400555041628122m, 1081, 1205.623498930834m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1145338759402427003293084523m, 911, 1015.3403609815611m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2330273346583428232502965599m, 843, 1039.442043116983m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2794747288008569915254237288m, 944, 1207.824143988009m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4876302835623105882352941176m, 850, 1264.485741027964m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1454260894361429404900816803m, 857, 981.6301586467745m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1749850575390257425742574257m, 1010, 1186.734908114416m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1590055539090284872298624754m, 1018, 1179.867653879391m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1594033260767351129363449692m, 974, 1129.25883959874m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4098001663107518796992481203m, 798, 1125.02053271598m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0736681075130932150313152401m, 958, 1028.5740469975433m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1651576898145216184971098266m, 865, 1007.8614016895612m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0057020181454631631631631632m, 999, 1004.6963161273177m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7462213708279646153846153846m, 650, 1135.043891038177m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4554704867873973154362416107m, 745, 1084.325512656611m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0572827965620575025176233635m, 993, 1049.8818169861231m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2580788613353627797408716137m, 849, 1068.108953273723m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2389768425891018609206660137m, 1021, 1264.995356283473m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1565822673228679372197309417m, 892, 1031.6713824519982m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3022290153740661853188929001m, 831, 1082.152311775849m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0929807624191174205967276227m, 1039, 1135.607012153463m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3621041422468488681757656458m, 751, 1022.9402108273835m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6316007493562607561929595828m, 767, 1251.437774756252m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.133316720343562015503875969m, 1032, 1169.582855394556m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0955249217841721258134490239m, 922, 1010.0739778850067m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.895376305307525974025974026m, 1078, 965.215657121513m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.501399229306101021897810219m, 685, 1028.4584720746792m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9079255019211817843866171004m, 1076, 976.9278400671916m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1668857701007860215053763441m, 930, 1085.203766193731m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0349577081453556574923547401m, 981, 1015.2935116905939m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7296445007044801699716713881m, 706, 1221.129017497363m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4828885686877278645833333333m, 768, 1138.858420752175m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6861858047604506089309878214m, 739, 1246.091309717973m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2754520668635988142292490119m, 1012, 1290.757491665962m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3876085346769394313967861557m, 809, 1122.575304553644m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0122838220598408239700374532m, 1068, 1081.11912195991m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0139854075838820837390457644m, 1027, 1041.3630135886469m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2056792227901640042598509052m, 939, 1132.132790199964m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0535957259833080712788259958m, 954, 1005.1303225880759m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0290698123144038026721479959m, 973, 1001.2849273819149m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5550372182552781740370898716m, 701, 1090.08108999695m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3313372518800051599587203302m, 969, 1290.065797071725m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1327136226644886025768087215m, 1009, 1142.908045268469m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3123303081068541878172588832m, 788, 1034.1162827882011m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1830631304952965708989805375m, 1079, 1276.525117804425m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4888397532398833967046894804m, 789, 1174.694565306268m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4390210876303313106796116505m, 824, 1185.753376207393m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2116538495994391353811149033m, 879, 1065.043733797907m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9463784533769168582375478927m, 1044, 988.0191053255012m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1161496581697523413111342352m, 961, 1072.619821501132m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4519037776447144827586206897m, 725, 1052.630238792418m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3637026529509328358208955224m, 804, 1096.41693297255m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0711287993963994360902255639m, 1064, 1139.681042557769m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7977768792911545189504373178m, 686, 1233.274939193732m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3125494077167817969661610268m, 857, 1124.854842413282m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1440501098205967002749770852m, 1091, 1248.158669814271m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2392398878954511352418558736m, 1013, 1255.350006438092m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0843479055040662373505059798m, 1087, 1178.68617328292m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3385349302765042424242424242m, 825, 1104.291317478116m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5784241588525609436435124509m, 763, 1204.337633204504m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.320206353814026027397260274m, 730, 963.750638284239m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0154862020308194574368568756m, 1069, 1085.554749970946m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.673915627162081924577373212m, 769, 1287.241117287641m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1121695333062490875912408759m, 1096, 1218.937808503649m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4076316941093676470588235294m, 748, 1052.908507193807m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0000519714212034830430797434m, 1091, 1091.056700820533m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4807721307063413597733711048m, 706, 1045.425124278677m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6561779082776920103092783505m, 776, 1285.194056823489m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1604821587725466101694915254m, 944, 1095.495157881284m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2495312342367632612966601179m, 1018, 1272.022796453025m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7039197470300866965620328849m, 669, 1139.922310763128m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1366328285974904661016949153m, 944, 1072.981390196031m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4877088692788775981524249423m, 866, 1288.355880795508m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4828326270744962779156327543m, 806, 1195.163097422044m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2312125083319770642201834862m, 872, 1073.617307265484m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.275713849514127m, 1000, 1275.713849514127m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7195110081142525849335302806m, 677, 1164.108952493349m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3969247522131627604166666667m, 768, 1072.838209699709m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3610295231979288061336254107m, 913, 1242.619954679709m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8218219734037179856115107914m, 695, 1266.166271515584m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.199007185655611740473738414m, 971, 1164.235977271599m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1478853212010384254920337395m, 1067, 1224.793637721508m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3297221928081376146788990826m, 872, 1159.517752128696m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2000346897004099318403115871m, 1027, 1232.435626322321m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2216494426149m, 1010, 1233.865937041049m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7347977560430869565217391304m, 736, 1276.811148447712m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2540294804048869109947643979m, 955, 1197.598153786667m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9559071062299912075848303393m, 1002, 957.81892044245119m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1568531981944199255121042831m, 1074, 1242.460334860807m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1302992693628587373167981962m, 887, 1002.5754519248557m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.7053028776938029891304347826m, 736, 1255.102917982639m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2786919753917388465723612622m, 919, 1175.117925385008m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9953146061389314314314314314m, 999, 994.3192915327925m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1182676631955797546012269939m, 978, 1093.665774605277m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8265460144650530846484935438m, 697, 1273.102572082142m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0368725313458234758871701547m, 1099, 1139.52291194906m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4826526589437921348314606742m, 712, 1055.64869316798m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4935031096613488372093023256m, 860, 1284.41267430876m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2238527577890986717752234994m, 783, 958.27670934886426m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.021185111546747418335089568m, 949, 969.1046708578633m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3177520079185826944140197152m, 913, 1203.107583229666m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2801240772514809160305343511m, 917, 1173.873778839608m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9151274641462889413988657845m, 1058, 968.2048570667737m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9583429313786915139826422372m, 1037, 993.8016198397031m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2677901218008933649289099526m, 844, 1070.014862799954m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2663577907403197969543147208m, 985, 1247.362423879215m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4665626326141643712574850299m, 668, 979.6638385862618m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.331118709449703344120819849m, 927, 1233.947043659875m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4753975811254698375870069606m, 862, 1271.792714930155m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3164268911911389207807118255m, 871, 1146.607822227482m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.5689905139463886583679114799m, 723, 1134.380141583239m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.998604710715995339412360689m, 987, 985.6228494766874m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4982787212387453271028037383m, 856, 1282.526585380366m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0295450645667894736842105263m, 1083, 1114.997304925833m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6828672669040163487738419619m, 734, 1235.224573907548m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9864525307718851412944393801m, 1097, 1082.138426256758m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1439018672851455050973123262m, 1079, 1234.270114800672m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6032659265108753623188405797m, 690, 1106.253489292504m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.9687023498996076335877862595m, 655, 1289.500039184243m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6412834128099651515151515152m, 660, 1083.247052454577m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8932323402089121522693997072m, 683, 1293.077688362687m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3039359968407986577181208054m, 894, 1165.718781175674m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1489615812462225274725274725m, 1092, 1254.666046720875m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1580031473615834155972359329m, 1013, 1173.057188277284m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1792143599883987206823027719m, 938, 1106.103069669118m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1893936262563814207650273224m, 915, 1088.295168024589m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4798562315298769230769230769m, 702, 1038.8590745339736m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.3611500402177842502696871629m, 927, 1261.786087281886m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1360063370511559356136820926m, 994, 1129.190299028849m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4783277643752145804676753783m, 727, 1074.744284700781m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1294897036561402214022140221m, 1084, 1224.366838763256m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2512740056225849843587069864m, 959, 1199.971771392059m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2734895799876761670761670762m, 814, 1036.6205181099684m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.8053311960041928783382789318m, 674, 1216.793226106826m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4910732847537469437652811736m, 818, 1219.697946928565m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0014291704265078921078921079m, 1001, 1002.4305995969344m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0274765871971760892667375133m, 941, 966.8554685525427m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2315796449197105882352941176m, 850, 1046.842698181754m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9969130622918786193672099712m, 1043, 1039.7803239704294m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6413509251466345565749235474m, 654, 1073.443505045899m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0096858139365526100307062436m, 977, 986.4630402160119m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.4288776984483268733850129199m, 774, 1105.951338599005m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2836989681823400744416873449m, 806, 1034.6613683549661m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9591517896576248812915479582m, 1053, 1009.986834509479m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6150879944873243243243243243m, 666, 1075.648604328558m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1838982005648166828322017459m, 1031, 1220.599044782326m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1046117846421419821826280624m, 898, 991.9413826086435m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.6332164901375777777777777778m, 720, 1175.915872899056m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2132977130100734229576008273m, 967, 1173.258888480741m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.020751574493415255905511811m, 1016, 1037.0835996853099m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2789133049527290998766954377m, 811, 1037.1986903166633m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2213353758974567990373044525m, 831, 1014.9296973707866m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.2431174078366545688545688546m, 777, 965.9022258890806m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 0.9733313550850290352504638219m, 1078, 1049.2512007816613m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.1957288922035383783783783784m, 925, 1106.049225288273m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0070774473759756449948400413m, 969, 975.8580465073204m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.611481206343155893536121673m, 789, 1271.45867180475m });

            migrationBuilder.UpdateData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "EuPerKm", "TripKm", "TripPrice" },
                values: new object[] { 1.0790622211899962095875139353m, 897, 967.9188124074266m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 4,
                column: "ClaimValue",
                value: "Admin Admin");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0261d5ca-050a-423e-90cb-c7e990f67959",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d588985d-0bc0-4478-9f1d-09e16f2b054a", "AQAAAAEAACcQAAAAECMnD+k1WraKHg87UzCG//7UcICMAIIEEtYfz77JHGJdspl40Alb/pAzoqRDzdKLfQ==", "1716167d-d011-4797-8e08-cdfc40240d4f" });

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
                column: "Price",
                value: 957.55742606456028m);

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
                column: "Price",
                value: 1279.899257971681m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1200.970185564297m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1011.8646634545983m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1156.788376030194m });

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
                column: "Price",
                value: 1167.095655570293m);

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
                column: "Price",
                value: 1106.076340886329m);

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
                column: "Price",
                value: 1125.624572417809m);

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
                column: "Price",
                value: 1085.983523240347m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1168.399953179402m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1236.616619509779m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1063.802205961234m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1252.909049691525m });

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
                column: "Price",
                value: 1113.668239889585m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1213.152101595968m });

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
                column: "Price",
                value: 1250.628068480336m);

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
                column: "Price",
                value: 1138.61333629047m);

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
                column: "Price",
                value: 1191.929115286823m);

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
                column: "Price",
                value: 1111.832550828044m);

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
                column: "Price",
                value: 1221.368014383631m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1285.471824622142m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1193.759539835669m });

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
                column: "Price",
                value: 1109.182266680406m);

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
                column: "Price",
                value: 1074.544848649968m);

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
                column: "Price",
                value: 1264.180817039698m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1126.219222636789m });

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
                column: "Price",
                value: 1111.108383215473m);

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
                column: "Price",
                value: 1107.638648306752m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1176.215679448751m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 6, 1036.0506202258038m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 956.05282400079228m });

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
                column: "Price",
                value: 1061.208520385773m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1099.216780816466m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1060.616692141994m });

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
                column: "Price",
                value: 1294.931400494929m);

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
                column: "Price",
                value: 1073.861262390596m);

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
                column: "Price",
                value: 1167.787473159599m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 210,
                column: "Price",
                value: 1298.317318817622m);

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
                column: "Price",
                value: 1246.914354350012m);

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
                column: "Price",
                value: 1253.95519816666m);

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
                column: "Price",
                value: 1108.287216451925m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1239.141045347272m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1280.748182803942m });

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
                column: "Price",
                value: 1059.310521107043m);

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
                column: "Price",
                value: 1270.278120893341m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 960.7190818708087m });

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
                column: "Price",
                value: 1262.757835330602m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 4, 1267.109384569519m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 273,
                column: "Price",
                value: 1052.231735880632m);

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
                column: "Price",
                value: 1280.203205340605m);

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
                column: "Price",
                value: 1017.5009850924103m);

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
                column: "Price",
                value: 1236.716141003015m);

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
                column: "Price",
                value: 1059.781154335465m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 289,
                column: "Price",
                value: 1049.1082078980986m);

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
                column: "Price",
                value: 1277.247765896234m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1267.591520396234m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1038.7542532689953m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1249.999024521232m });

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
                column: "Price",
                value: 1233.728588395462m);

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
                column: "Price",
                value: 997.1107767089846m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1259.440032649652m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1118.918832906113m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1069.960685509868m });

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
                column: "Price",
                value: 1199.08241265109m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1267.970679443197m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1177.527430907917m });

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
                column: "Price",
                value: 1132.378631365415m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1063.278264349562m });

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
                column: "Price",
                value: 1289.91160330185m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1172.361822058872m });

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
                column: "Price",
                value: 1190.841716063837m);

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
                column: "Price",
                value: 1131.550245615456m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1075.53500795307m });

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
                column: "Price",
                value: 1042.5703880000276m);

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
                column: "Price",
                value: 1170.727853617873m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1010.9991618227945m });

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
                column: "Price",
                value: 980.8930603053683m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1179.139451205521m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1229.563616131916m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1123.230189428845m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 1230.631262474508m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 995.9400913178437m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1086.923042867253m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 1, 1002.4128810896375m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1178.88784223764m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 516,
                column: "Price",
                value: 1183.538759758386m);

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
                column: "Price",
                value: 1036.4947143872879m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 8, 1296.345049486251m });

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
                column: "Price",
                value: 1248.884310992507m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 2, 1168.428494513661m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 1091.608237547006m });

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
                column: "Price",
                value: 1273.957789763545m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 987.3154684410437m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 9, 960.4668328651034m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1229.523769382855m });

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
                column: "Price",
                value: 1051.700095257034m);

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 3, 1173.210423365663m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 5, 1288.311391397394m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 10, 989.8081786686585m });

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
                columns: new[] { "CompanyId", "Price" },
                values: new object[] { 7, 1108.996036261048m });

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
                columns: new[] { "EuPerKm", "TripPrice" },
                values: new object[] { 1.303241539048485427135678392m, 1296.725331353243m });

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
                columns: new[] { "EuPerKm", "TripPrice" },
                values: new object[] { 1.3241702950602947761194029851m, 1064.632917228477m });

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
    }
}
