using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "cb03ea83-3c43-4804-bdd7-2723b557a769");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dispatcherRoleId",
                column: "ConcurrencyStamp",
                value: "d3a74def-fd36-4ed6-a439-6e5a538e5b39");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "managerRoleId",
                column: "ConcurrencyStamp",
                value: "1c9edb1d-a3e2-4591-b2e5-59cd422c6f3a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82cc8343-c3d8-4d37-b08a-8a2e234cfc0a", "ADMIN@TRUCK.COM", "ADMIN@TRUCK.COM", "AQAAAAEAACcQAAAAEFlWGIN4ALxLr3AhBToYgEIuoUwUoDsnwMipXnay6LOnIwoqHxJNkgeZ0HEfWDb3nQ==", "96247c24-7d0e-4147-bbaf-8eace89f703f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserEmail", "UserName" },
                values: new object[,]
                {
                    { "0261d5ca-050a-423e-90cb-c7e990f67959", 0, "deaab15d-219b-4f03-bace-12bb02c45e3a", "manager@truck.com", false, false, null, "MANAGER@TRUCK.COM", "MANAGER@TRUCK.COM", "AQAAAAEAACcQAAAAEMfy/UgXc/qQJlGDb7Bqu4az8qv18/iNvYbDG3dIr8A5jkwog9iwc6xDpcxy+Jq8RA==", null, false, "8e35d85a-9a67-4172-911f-6c08bc7627ea", false, "", "manager@truck.com" },
                    { "19918df1-9468-434b-aaf9-a3d22b2d12e2", 0, "abbb094d-c6af-4f3b-8bc6-f86ecc3c99e1", "dispo2@truck.com", false, false, null, "DISPO2@TRUCK.COM", "DISPO2@TRUCK.COM", "AQAAAAEAACcQAAAAEI3BaN8ddpq0JpF4L6dRUpNelOTHXjlVpcybpv/N21+JYT9LDtgEugzbjGL20zEAfg==", null, false, "aa873927-6772-4251-a73e-434db00b4bf4", false, "", "dispo2@truck.com" },
                    { "62154153-66df-4b35-91ed-56ac983c9a8e", 0, "5d95e582-9efb-48da-a919-efb4dff24447", "dispo1@truck.com", false, false, null, "DISPO1@TRUCK.COM", "DISPO1@TRUCK.COM", "AQAAAAEAACcQAAAAENDaoNZguaQEd5h4lo7O9CR2Kr3PGhcXQNbMVNkBieldgU+XM6fjRfCvcvyd+pC6Zw==", null, false, "c562cffe-5c51-42ee-b705-149186d20718", false, "", "dispo1@truck.com" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AddedDate", "CompanyAddress", "CompanyCountry", "CompanyName", "CompanyTown", "CompanyVat", "IsActive", "RemovedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), "17 RUE BOBBY SANDS", "France", "MALHERBE DISTRIBUTION", "44813 ST-HERBLAIN CEDEX", "FR72518435920", true, null },
                    { 2, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), "ROUTE DE SCHWEIGEN BP 10025", "France", "WOEHL & CIE - TPT INTERNATIONAUX", "67160 WISSEMBOURG", "FR37558501144", true, null },
                    { 3, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), "144 ZAE WOLSER", "Luxembourg", "XPO TRS LU", "3225 BETTEMBOURG", "LU17458960", true, null },
                    { 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), "2609 AVENUE DE PRADES", "France", "GEFCO FRANCE", "66000 PERPIGNAN", "FR24789791464", true, null },
                    { 5, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), "69 Route de Thionville", "France", "Yusen Logistics (France) SAS", "57280 Maizières-lès-Metz", "FR89432599785", true, null },
                    { 6, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), "JUSTUS LIEBIG STRASSE 14", "Germany", "SCHENKER DEUTSCHLAND AG", "34253 LOHFELDEN/KASSEL", "DE811228366", true, null },
                    { 7, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Brinkhofstraße 41", "Germany", "Winner Spedition GmbH & Co. KG", "58642 Iserlohn", "DE125572634", true, null },
                    { 8, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Genthiner Strasse 34", "Germany", "sennder Technologies GmbH", "10785 Berlin", "DE302502945", true, null },
                    { 9, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Otto-Hahn-Str. 3", "Germany", "Stahl Log", "D-66793 Saarwellingen", "DE813065962", true, null },
                    { 10, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), "RUE DES VERGERS", "France", "GREILSAMMER ABCE", "F - 68600 WOLFGANTZEN", "FR06514447937", true, null }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "FullName",
                value: "Admin Admin");

            migrationBuilder.InsertData(
                table: "Trucks",
                columns: new[] { "Id", "AddedDate", "IsActive", "ProductionYear", "RemovedDate", "TruckBrand", "TruckInitialKm", "TruckModel", "TruckPlate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 195000, "Renault Trucks T High", "B8511TC" },
                    { 2, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 198000, "Renault Trucks T High", "B8514TC" },
                    { 3, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 201500, "Renault Trucks T High", "B8517TC" },
                    { 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 205000, "Renault Trucks T High", "B9133TC" },
                    { 5, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 210000, "Renault Trucks T High", "B9134TC" },
                    { 6, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 230500, "Renault Trucks T High", "B9135TC" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "managerRoleId", "0261d5ca-050a-423e-90cb-c7e990f67959" },
                    { "dispatcherRoleId", "19918df1-9468-434b-aaf9-a3d22b2d12e2" },
                    { "dispatcherRoleId", "62154153-66df-4b35-91ed-56ac983c9a8e" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "EmployeeUserId", "FullName", "IsActive", "RoleId" },
                values: new object[,]
                {
                    { 2, "manager@truck.com", "0261d5ca-050a-423e-90cb-c7e990f67959", "Chief", true, "managerRoleId" },
                    { 3, "dispo1@truck.com", "62154153-66df-4b35-91ed-56ac983c9a8e", "Hans Uno", true, "dispatcherRoleId" },
                    { 4, "dispo2@truck.com", "19918df1-9468-434b-aaf9-a3d22b2d12e2", "Hans Due", true, "dispatcherRoleId" }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.169900878639901980198019802m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1010, 1181.599887426301m, 1 },
                    { 2, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.578213153859996291718170581m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 809, 1276.774441472737m, 2 },
                    { 3, 4, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4312275560241904761904761905m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 819, 1172.175368383812m, 3 },
                    { 4, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1141717893870907258064516129m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 992, 1105.258415071994m, 4 },
                    { 5, 4, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5367594746861863799283154122m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 837, 1286.267680312338m, 5 },
                    { 6, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.635393993787907967032967033m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 728, 1190.566827477597m, 6 },
                    { 7, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0008915549591994117647058824m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1020, 1020.9093860583834m, 1 },
                    { 8, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.057559824909725912067352666m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1069, 1130.531452828497m, 2 },
                    { 9, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1782583287575985169491525424m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 944, 1112.275862347173m, 3 },
                    { 10, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1693178078762796296296296296m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1080, 1262.863232506382m, 4 },
                    { 11, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6680517239121643258426966292m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 712, 1187.652827425461m, 5 },
                    { 12, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9916268336479037383177570093m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1070, 1061.040712003257m, 6 },
                    { 13, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3391217277887768831168831169m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 770, 1031.1237303973582m, 1 },
                    { 14, 3, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1617392309110124521072796935m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1044, 1212.855757071097m, 2 },
                    { 15, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6921293412534390896921017403m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 747, 1264.020617916319m, 3 },
                    { 16, 3, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1797737308090095419847328244m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1048, 1236.402869887842m, 4 },
                    { 17, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2896385510238895768833849329m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 969, 1249.659755942149m, 5 },
                    { 18, 3, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3313902992075714285714285714m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 805, 1071.769190862095m, 6 },
                    { 19, 4, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4253921202937452513966480447m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 895, 1275.725947662902m, 1 },
                    { 20, 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4598736243712597907324364723m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 669, 976.6554547043728m, 2 },
                    { 21, 4, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1104443435360336134453781513m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 952, 1057.143015046304m, 3 },
                    { 22, 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5022107428751236623067776457m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 841, 1263.359234757979m, 4 },
                    { 23, 4, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.238766024091417940876656473m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 981, 1215.229469633681m, 5 },
                    { 24, 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.047062275621046195652173913m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 920, 963.2972935713625m, 6 },
                    { 25, 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5586255719112007528230865747m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 797, 1242.224580813227m, 1 },
                    { 26, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2298669102535024975024975025m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1001, 1231.096777163756m, 2 },
                    { 27, 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2226038676843896976483762598m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 893, 1091.78525384216m, 3 },
                    { 28, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0514713925616406844106463878m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1052, 1106.147904974846m, 4 },
                    { 29, 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0275427197023680040120361083m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 997, 1024.4600915432609m, 5 },
                    { 30, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0306710820259381443298969072m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1067, 1099.726044521676m, 6 },
                    { 31, 4, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2909887750757431057563587684m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 747, 964.3686149815801m, 1 },
                    { 32, 3, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2297233196717742690058479532m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 855, 1051.413438319367m, 2 },
                    { 33, 4, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2259655525495418875927889714m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 943, 1156.085516054218m, 3 },
                    { 34, 3, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.221943778629598876404494382m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 890, 1087.529962980343m, 4 },
                    { 35, 4, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1357612215221301587301587302m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 945, 1073.294354338413m, 5 },
                    { 36, 3, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5587882199899899713467048711m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 698, 1088.034177553013m, 6 },
                    { 37, 4, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.399749847762299492385786802m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 788, 1103.002880036692m, 1 },
                    { 38, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2300834820380051599587203302m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 969, 1191.950894094827m, 2 },
                    { 39, 4, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1663832420344387133182844244m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 886, 1033.4155524425127m, 3 },
                    { 40, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9669972880894250236966824645m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1055, 1020.1821389343434m, 4 },
                    { 41, 4, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4370033533338299410029498525m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 678, 974.2882735603367m, 5 },
                    { 42, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9797647057181606330365974283m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1011, 990.5421174810604m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 43, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7173947227955373563218390805m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 696, 1195.306727065694m, 1 },
                    { 44, 3, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1117425363029504209541627689m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1069, 1188.452771307854m, 2 },
                    { 45, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3359682810186007025761124122m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 854, 1140.916911989885m, 3 },
                    { 46, 3, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.8861357864948030241187384045m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1078, 955.25437784139766m, 4 },
                    { 47, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1711014928161746031746031746m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 945, 1106.690910711285m, 5 },
                    { 48, 3, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4413926650401723140495867769m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 726, 1046.4510748191651m, 6 },
                    { 49, 4, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2135414481061664853101196953m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 919, 1115.244590809567m, 1 },
                    { 50, 3, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2371469930174399117971334068m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 907, 1122.092322666818m, 2 },
                    { 51, 4, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3288932560282805429864253394m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 884, 1174.741638329m, 3 },
                    { 52, 3, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2689575223860230093209054594m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 751, 952.98709931190328m, 4 },
                    { 53, 4, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2121845916961287469287469287m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 814, 986.7182576406488m, 5 },
                    { 54, 3, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5567269559824124365482233503m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 788, 1226.700841314141m, 6 },
                    { 55, 4, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4250973140506636670416197975m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 889, 1266.91151219104m, 1 },
                    { 56, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0293917582789565217391304348m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1081, 1112.772490699552m, 2 },
                    { 57, 4, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4969264142161019184652278177m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 834, 1248.436629456229m, 3 },
                    { 58, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.923545609242527447216890595m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1042, 962.3345248307136m, 4 },
                    { 59, 4, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1611766230228163452708907254m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1089, 1264.521342471847m, 5 },
                    { 60, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6361562658747520547945205479m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 730, 1194.394074088569m, 6 },
                    { 61, 4, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0183475074038294573643410853m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1032, 1050.934627640752m, 1 },
                    { 62, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4295529700106053221288515406m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 714, 1020.7008205875722m, 2 },
                    { 63, 4, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7125167768461746724890829694m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 687, 1176.499025693322m, 3 },
                    { 64, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4951349064170332446808510638m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 752, 1124.341449625609m, 4 },
                    { 65, 4, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9873003139927139253279515641m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 991, 978.4146111667795m, 5 },
                    { 66, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8891228286706392961876832845m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 682, 1288.381769153376m, 6 },
                    { 67, 4, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0999080435656812865497076023m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1026, 1128.505652698389m, 1 },
                    { 68, 3, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3953782294747238030095759234m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 731, 1020.0214857460231m, 2 },
                    { 69, 4, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1198041789200891647855530474m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 886, 992.146502523199m, 3 },
                    { 70, 3, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1429663778012774813233724653m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 937, 1070.959495999797m, 4 },
                    { 71, 4, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1539438017819240265906932574m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1053, 1215.102823276366m, 5 },
                    { 72, 3, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9600754074829908925318761384m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1098, 1054.162797416324m, 6 },
                    { 73, 4, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5467280307989366515837104072m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 663, 1025.480684419695m, 1 },
                    { 74, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5843159224415609756097560976m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 738, 1169.225150761872m, 2 },
                    { 75, 4, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.711174986796907514450867052m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 692, 1184.13309086346m, 3 },
                    { 76, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6619369933157779237844940867m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, 1264.734051913307m, 4 },
                    { 77, 4, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7221407757459178885630498534m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 682, 1174.500009058716m, 5 },
                    { 78, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2305385421565117224880382775m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 836, 1028.7302212428438m, 6 },
                    { 79, 4, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5231021475568544935805991441m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 701, 1067.694605437355m, 1 },
                    { 80, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9899032233934396378269617706m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 994, 983.963804053079m, 2 },
                    { 81, 4, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6295002831120740740740740741m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 702, 1143.909198744676m, 3 },
                    { 82, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3364338745103116883116883117m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 847, 1131.959491710234m, 4 },
                    { 83, 4, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1437995430913980789754535752m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 937, 1071.74017187664m, 5 },
                    { 84, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0583593235212075854700854701m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 936, 990.6243268158503m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 85, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3272425009046120865139949109m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 786, 1043.2126057110251m, 1 },
                    { 86, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4070923186801611316113161132m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 813, 1143.966055086971m, 2 },
                    { 87, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0534944144028794946550048591m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1029, 1084.045752420563m, 3 },
                    { 88, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2538854276919609756097560976m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1025, 1285.23256338426m, 4 },
                    { 89, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1353039584384043433298862461m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 967, 1097.838927809937m, 5 },
                    { 90, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5140294084593350253807106599m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 788, 1193.055173865956m, 6 },
                    { 91, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2590381526130319905213270142m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 844, 1062.628200805399m, 1 },
                    { 92, 3, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.731173354631673780487804878m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 656, 1135.649720638378m, 2 },
                    { 93, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3467763145294238258877434135m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 873, 1175.735722584187m, 3 },
                    { 94, 3, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5995768808871164658634538153m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 747, 1194.883930022676m, 4 },
                    { 95, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0744031508361548630783758263m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1059, 1137.792936735488m, 5 },
                    { 96, 3, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2785711173008561643835616438m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 876, 1120.02829875555m, 6 },
                    { 97, 4, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.132630506932696813977389517m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 973, 1102.049483245514m, 1 },
                    { 98, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5196371285381770956316410862m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 847, 1287.132647871836m, 2 },
                    { 99, 4, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0681918890367620582120582121m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 962, 1027.6005972533651m, 3 },
                    { 100, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9629313545142463582677165354m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1016, 978.3382561864743m, 4 },
                    { 101, 4, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4531321257755188253012048193m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 964.8797315149445m, 5 },
                    { 102, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1577995112874154589371980676m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1035, 1198.322494182475m, 6 },
                    { 103, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.560444995421151685393258427m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 712, 1111.03683673986m, 1 },
                    { 104, 3, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1449850676611812021857923497m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 915, 1047.6613369099808m, 2 },
                    { 105, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1059623923378009132420091324m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1095, 1211.028819609892m, 3 },
                    { 106, 3, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8014713937625222551928783383m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 674, 1214.19171939594m, 4 },
                    { 107, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4809085506859742897727272727m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 704, 1042.5596196829259m, 5 },
                    { 108, 3, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6250495104833291614518147685m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 1298.41455887618m, 6 },
                    { 109, 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.43745661590193m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 900, 1293.710954311737m, 1 },
                    { 110, 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2648229977573452380952380952m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 840, 1062.45131811617m, 2 },
                    { 111, 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3670651865287394630872483221m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 745, 1018.4635639639109m, 3 },
                    { 112, 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.994843575408750334288443171m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1047, 1041.6012234529616m, 4 },
                    { 113, 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3442298552280836120401337793m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 897, 1205.774180139591m, 5 },
                    { 114, 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4627926783999014598540145985m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 822, 1202.415581644719m, 6 },
                    { 115, 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.961378697854231657355679702m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1074, 1032.5207214954448m, 1 },
                    { 116, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6818301100398070921985815603m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 705, 1185.690227578064m, 2 },
                    { 117, 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2037384752736453089244851259m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 874, 1052.067427389166m, 3 },
                    { 118, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.906137410725304932735426009m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 669, 1275.205927775229m, 4 },
                    { 119, 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0674327765605270403146509341m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1017, 1085.579133762056m, 5 },
                    { 120, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1074295404912663934426229508m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 976, 1080.851231519476m, 6 },
                    { 121, 4, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4140211007604906166219839142m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 746, 1054.859741167326m, 1 },
                    { 122, 3, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3340995587148127777777777778m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 720, 960.5516822746652m, 2 },
                    { 123, 4, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5290210452751978155339805825m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 824, 1259.913341306763m, 3 },
                    { 124, 3, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2533706081280781099324975892m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1037, 1299.745320628817m, 4 },
                    { 125, 4, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9953394590625964766839378238m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 965, 960.5025779954056m, 5 },
                    { 126, 3, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4889952959319726027397260274m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 803, 1195.663222633374m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 127, 4, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3112813204773395465994962217m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 794, 1041.1573684590076m, 1 },
                    { 128, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6743924498873893557422969188m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 714, 1195.516209219596m, 2 },
                    { 129, 4, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7697935595226229508196721311m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 732, 1295.48888557056m, 3 },
                    { 130, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3283344174770755355129650507m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 887, 1178.232628302166m, 4 },
                    { 131, 4, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3607355519149600282485875706m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 708, 963.4007707557917m, 5 },
                    { 132, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2519605061582910112359550562m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 890, 1114.244850480879m, 6 },
                    { 133, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2351279354495356881851400731m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 821, 1014.0400350040688m, 1 },
                    { 134, 3, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4526994177865215189873417722m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 790, 1147.632540051352m, 2 },
                    { 135, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8248292976441640513552068474m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 701, 1279.205337648559m, 3 },
                    { 136, 3, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2535162936874819567979669632m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 787, 986.5173231320483m, 4 },
                    { 137, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.07808151351888m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1075, 1158.937627032796m, 5 },
                    { 138, 3, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1913949148662817972350230415m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 868, 1034.1307861039326m, 6 },
                    { 139, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5897735838457717678100263852m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 758, 1205.048376555095m, 1 },
                    { 140, 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5617413350805751506024096386m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 1036.9962464935019m, 2 },
                    { 141, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1653658058503514117647058824m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 850, 990.5609349727987m, 3 },
                    { 142, 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2119709594761725997842502697m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 927, 1123.497079434412m, 4 },
                    { 143, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2860110826488447276940903824m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 863, 1109.827564325953m, 5 },
                    { 144, 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4318149478138687315634218289m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 678, 970.770534617803m, 6 },
                    { 145, 4, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1742905645039334016393442623m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 976, 1146.107590955839m, 1 },
                    { 146, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1904973822682757936507936508m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1008, 1200.021361326422m, 2 },
                    { 147, 4, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7823776132170797720797720798m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 702, 1251.22908447839m, 3 },
                    { 148, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5167240008015103163686382393m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 727, 1102.658348582698m, 4 },
                    { 149, 4, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5170057013038356164383561644m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 803, 1218.15557814698m, 5 },
                    { 150, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.169015757267743028083028083m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 819, 957.42390520228154m, 6 },
                    { 151, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0754481485333887755102040816m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 980, 1053.939185562721m, 1 },
                    { 152, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5020843353706064593301435407m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 836, 1255.742504369827m, 2 },
                    { 153, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4149119932182793946449359721m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 859, 1215.409402174502m, 3 },
                    { 154, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5513758580052516556291390728m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 755, 1171.288772793965m, 4 },
                    { 155, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4979358757915768292682926829m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 820, 1228.307418149093m, 5 },
                    { 156, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6510206142193710144927536232m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 690, 1139.204223811366m, 6 },
                    { 157, 4, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0701178919895086119554204661m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 987, 1056.206359393645m, 1 },
                    { 158, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0999191861454860853432282004m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1078, 1185.712882664834m, 2 },
                    { 159, 4, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2680908065612944723618090452m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 995, 1261.750352528488m, 3 },
                    { 160, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1447383157333115942028985507m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 966, 1105.817212998379m, 4 },
                    { 161, 4, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6430362624343189655172413793m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 696, 1143.553238654286m, 5 },
                    { 162, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1726764713277794117647058824m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1020, 1196.130000754335m, 6 },
                    { 163, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0733236980889942578548212351m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 923, 990.6777733361417m, 1 },
                    { 164, 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3732204244176336528221512247m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 939, 1289.453978528158m, 2 },
                    { 165, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0096594476325261306532663317m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 995, 1004.6111503943635m, 3 },
                    { 166, 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1944347239533130193905817175m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1083, 1293.572806041438m, 4 },
                    { 167, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3399575308638002103049421661m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 951, 1274.299611851474m, 5 },
                    { 168, 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5561532392424578651685393258m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 712, 1107.98110634063m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 169, 4, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3064088581359026282853566959m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 1043.8206776505862m, 1 },
                    { 170, 3, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0968703553321746931067044381m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1059, 1161.585706296773m, 2 },
                    { 171, 4, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0550666121519786407766990291m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1030, 1086.718610516538m, 3 },
                    { 172, 3, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1579364895790754566210045662m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 876, 1014.3523648712701m, 4 },
                    { 173, 4, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0983995299706132135306553911m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 946, 1039.0859553522001m, 5 },
                    { 174, 3, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3280971568197399193548387097m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 744, 988.1042846738865m, 6 },
                    { 175, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3531011180207092288242730721m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 791, 1070.302984354381m, 1 },
                    { 176, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1267797307450096805421103582m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1033, 1163.963461859595m, 2 },
                    { 177, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0096953899646629405840886203m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 993, 1002.6275222349103m, 3 },
                    { 178, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3064443138845556930693069307m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 808, 1055.607005618721m, 4 },
                    { 179, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2902843999254891758917589176m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 813, 1049.0012171394227m, 5 },
                    { 180, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4080072370716278280542986425m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 884, 1244.678397571319m, 6 },
                    { 181, 4, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3509007257079215017064846416m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 879, 1187.441737897263m, 1 },
                    { 182, 3, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1281585134117941729323308271m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1064, 1200.360658270149m, 2 },
                    { 183, 4, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9295664460408771897810218978m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1096, 1018.8048248608014m, 3 },
                    { 184, 3, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0626470495653004739336492891m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1055, 1121.092637291392m, 4 },
                    { 185, 4, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4011182592237953216374269006m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 855, 1197.956111636345m, 5 },
                    { 186, 3, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4891326241200930232558139535m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 774, 1152.588651068952m, 6 },
                    { 187, 4, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2937849903540082449941107185m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 849, 1098.423456810553m, 1 },
                    { 188, 3, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.136231213103891304347826087m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 966, 1097.599351858359m, 2 },
                    { 189, 4, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3960514398461544715447154472m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 861, 1202.000289707539m, 3 },
                    { 190, 3, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3460650897885474919957310566m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 937, 1261.262989131869m, 4 },
                    { 191, 4, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2067368921457357357357357357m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 999, 1205.53015525359m, 5 },
                    { 192, 3, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.499763037479063448275862069m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 725, 1087.328202172321m, 6 },
                    { 193, 4, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7008436181359097222222222222m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 720, 1224.607405057855m, 1 },
                    { 194, 3, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0965119000675310148232611174m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 877, 961.6409363592247m, 2 },
                    { 195, 4, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2208322099579079079079079079m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 999, 1219.61137774795m, 3 },
                    { 196, 3, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5053668832152154696132596685m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 724, 1089.885623447816m, 4 },
                    { 197, 4, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2995890853547766990291262136m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 927, 1204.719082123878m, 5 },
                    { 198, 3, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7615612384132771084337349398m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 1169.676662306416m, 6 },
                    { 199, 4, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3248745737897355718782791186m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 953, 1262.605468821618m, 1 },
                    { 200, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6292631880737919556171983356m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 721, 1174.698758601204m, 2 },
                    { 201, 4, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7197678324006239554317548747m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 718, 1234.793303663648m, 3 },
                    { 202, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3361268236195497326203208556m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 935, 1249.278580084279m, 4 },
                    { 203, 4, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5811057283647222222222222222m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 702, 1109.936221312035m, 5 },
                    { 204, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9374125840041m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 650, 1259.318179602665m, 6 },
                    { 205, 4, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2002470111445199874529485571m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 797, 956.59686788218243m, 1 },
                    { 206, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3551258951593312101910828025m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 942, 1276.52859324009m, 2 },
                    { 207, 4, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.566155339569858974358974359m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 780, 1221.60116486449m, 3 },
                    { 208, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6569795488378079896907216495m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 1285.816129898139m, 4 },
                    { 209, 4, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5248777864462935393258426966m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 712, 1085.712983949761m, 5 },
                    { 210, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1963513959855092783505154639m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 970, 1160.460854105944m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 211, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8570846473276966463414634146m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 656, 1218.247528646969m, 1 },
                    { 212, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2499101048535739130434782609m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1035, 1293.656958523449m, 2 },
                    { 213, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5868354641337747524752475248m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 808, 1282.16305502009m, 3 },
                    { 214, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2013788420519377828054298643m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 884, 1062.018896373913m, 4 },
                    { 215, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2889796067644563679245283019m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 848, 1093.054706536259m, 5 },
                    { 216, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0941395131681466165413533835m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 931, 1018.6438867595445m, 6 },
                    { 217, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1107612035610724215246636771m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 892, 990.7989935764766m, 1 },
                    { 218, 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5423797396885858208955223881m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 1240.073310709623m, 2 },
                    { 219, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3394936535730327868852459016m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 854, 1143.92758015137m, 3 },
                    { 220, 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0553056297925499505440158259m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1011, 1066.913991720268m, 4 },
                    { 221, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1295776271349810606060606061m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1056, 1192.83397425454m, 5 },
                    { 222, 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3879636620249210084033613445m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 714, 991.0060546857936m, 6 },
                    { 223, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2564471902905237154150197628m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1012, 1271.52455657401m, 1 },
                    { 224, 3, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4661946024065402038505096263m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 883, 1294.649833924975m, 2 },
                    { 225, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0409955799575146994535519126m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 915, 952.51095566112595m, 3 },
                    { 226, 3, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7783939693932085714285714286m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 700, 1244.875778575246m, 4 },
                    { 227, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1899614563331641737032569361m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 829, 986.4780473001931m, 5 },
                    { 228, 3, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3405753513845901234567901235m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 810, 1085.866034621518m, 6 },
                    { 229, 4, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9338309731866383380547686497m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1059, 988.92700060465m, 1 },
                    { 230, 3, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0127780850212479185938945421m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1081, 1094.813109907969m, 2 },
                    { 231, 4, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5702916046199024745269286754m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 687, 1078.790332373873m, 3 },
                    { 232, 3, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0999441159017700091996320147m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1087, 1195.639253985224m, 4 },
                    { 233, 4, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9601442876493690086621751684m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1039, 997.5899148676944m, 5 },
                    { 234, 3, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3480919567450750293083235639m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 853, 1149.922439103549m, 6 },
                    { 235, 4, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4637802453731308962264150943m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 848, 1241.285648076415m, 1 },
                    { 236, 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1936060292587150837988826816m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1074, 1281.93287542386m, 2 },
                    { 237, 4, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9167730444431903846153846154m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1092, 1001.1161645319639m, 3 },
                    { 238, 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3786394016535487179487179487m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 780, 1075.338733289768m, 4 },
                    { 239, 4, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9659423279330287213740458015m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1048, 1012.3075596738141m, 5 },
                    { 240, 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2132974287041646634615384615m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 832, 1009.463460681865m, 6 },
                    { 241, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5264887139137034883720930233m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 688, 1050.224235172628m, 1 },
                    { 242, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3075849617579124m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 750, 980.6887213184343m, 2 },
                    { 243, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2745455192745728444003964321m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1009, 1286.016428948044m, 3 },
                    { 244, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1226051716952438709677419355m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 930, 1044.0228096765768m, 4 },
                    { 245, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1812596334637791537667698658m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 969, 1144.640584826402m, 5 },
                    { 246, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1794116241848782791185729276m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 953, 1123.979277848189m, 6 },
                    { 247, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4640741459049876237623762376m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 808, 1182.97190989123m, 1 },
                    { 248, 3, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0646120030246079331941544885m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 958, 1019.8982988975744m, 2 },
                    { 249, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3607762290917573529411764706m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 952, 1295.458970095353m, 3 },
                    { 250, 3, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2061726779846951923076923077m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1040, 1254.419585104083m, 4 },
                    { 251, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9964960111368705440900562852m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1066, 1062.264747871904m, 5 },
                    { 252, 3, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0129245157802713839750260146m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 961, 973.4204596648408m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 253, 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6531290400683152454780361757m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 774, 1279.521877012876m, 1 },
                    { 254, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.366119658586587962962962963m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 864, 1180.327385018812m, 2 },
                    { 255, 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5716067908238579387186629526m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 718, 1128.41367581153m, 3 },
                    { 256, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5349299026602080536912751678m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 745, 1143.522777481855m, 4 },
                    { 257, 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3204560626029214536928487691m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 853, 1126.349021400292m, 5 },
                    { 258, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2235814583840335570469798658m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1043, 1276.195461094547m, 6 },
                    { 259, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9418583539564481195756991321m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1037, 976.7071130528367m, 1 },
                    { 260, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6222245027090817174515235457m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 722, 1171.246090955957m, 2 },
                    { 261, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4861719423888491547464239272m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 769, 1142.866223697025m, 3 },
                    { 262, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9317198923032389261744966443m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1043, 971.7838476722782m, 4 },
                    { 263, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0477794635734880952380952381m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1092, 1144.175174222249m, 5 },
                    { 264, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.8803134616664659671532846715m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1096, 964.8235539864467m, 6 },
                    { 265, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0793078012161703743315508021m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 935, 1009.1527941371193m, 1 },
                    { 266, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1836230629870651955867602808m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 997, 1180.072193798104m, 2 },
                    { 267, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1325815387744696239151398264m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1037, 1174.487055709125m, 3 },
                    { 268, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3257301371453020214030915577m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 841, 1114.939045339199m, 4 },
                    { 269, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5260682177868373493975903614m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 830, 1266.636620763075m, 5 },
                    { 270, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9150738131555478499542543458m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1093, 1000.1756777790138m, 6 },
                    { 271, 4, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4068219038261479820627802691m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 892, 1254.885138212924m, 1 },
                    { 272, 3, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7297190913763446327683615819m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 708, 1224.641116694452m, 2 },
                    { 273, 4, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.560200015670014367816091954m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 696, 1085.89921090633m, 3 },
                    { 274, 3, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1052757885870131712259371834m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 987, 1090.907203335382m, 4 },
                    { 275, 4, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.600436129283832010582010582m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 756, 1209.929713738577m, 5 },
                    { 276, 3, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1265137705058222095671981777m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 878, 989.0790905041119m, 6 },
                    { 277, 4, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.015513241881680184331797235m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1085, 1101.831867441623m, 1 },
                    { 278, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9562488654041787437185929648m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 995, 951.46762107715785m, 2 },
                    { 279, 4, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4817311108608690614136732329m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 863, 1278.73394867293m, 3 },
                    { 280, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1020727197337037392138063279m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1043, 1149.461846682253m, 4 },
                    { 281, 4, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2369769341946996124031007752m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1032, 1276.56019608893m, 5 },
                    { 282, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0339856750814367816091954023m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1044, 1079.48104478502m, 6 },
                    { 283, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5358554972590750741839762611m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 674, 1035.1666051526166m, 1 },
                    { 284, 3, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9216826122563644362969752521m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1091, 1005.5557299716936m, 2 },
                    { 285, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3132903348516009122006841505m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 877, 1151.755623664854m, 3 },
                    { 286, 3, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3466917421276843373493975904m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 830, 1117.754145965978m, 4 },
                    { 287, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1733936570126681901279707495m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1094, 1283.692660771859m, 5 },
                    { 288, 3, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9850572414585610721649484536m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 970, 955.50552421480424m, 6 },
                    { 289, 4, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5799227265605672937771345876m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 691, 1091.726604053352m, 1 },
                    { 290, 3, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6173972337851354466858789625m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, 1122.473680246884m, 2 },
                    { 291, 4, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.188859472182627431906614786m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1028, 1222.147537403741m, 3 },
                    { 292, 3, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.343554945896433921302578019m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 737, 990.1999951256718m, 4 },
                    { 293, 4, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3297190516772770339855818744m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 971, 1291.157199178636m, 5 },
                    { 294, 3, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0459064693704936831875607386m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1029, 1076.237756982238m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 295, 4, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2606657276365838909541511772m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 807, 1017.3572422027232m, 1 },
                    { 296, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2260597440445362903225806452m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 992, 1216.25126609218m, 2 },
                    { 297, 4, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.739163749434556657223796034m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 706, 1227.849607100797m, 3 },
                    { 298, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4144841219132005277044854881m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 758, 1072.178964410206m, 4 },
                    { 299, 4, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7863311641649617083946980854m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 679, 1212.918860468009m, 5 },
                    { 300, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6154369279688354430379746835m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 711, 1148.575655785842m, 6 },
                    { 301, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1710080965661986501687289089m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 889, 1041.0261978473506m, 1 },
                    { 302, 3, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.139947328904425891181988743m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1066, 1215.183852612118m, 2 },
                    { 303, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1443754078757249162011173184m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 895, 1024.2159900487738m, 3 },
                    { 304, 3, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2237716868769314472252448313m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 919, 1124.6461802399m, 4 },
                    { 305, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4787535163690636604774535809m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 754, 1114.980151342274m, 5 },
                    { 306, 3, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4571696071611547314578005115m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 782, 1139.506632800023m, 6 },
                    { 307, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1860947081860776495278069255m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 953, 1130.348256901332m, 1 },
                    { 308, 3, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2019341193651949317738791423m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1026, 1233.18440646869m, 2 },
                    { 309, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6163805998319935316946959897m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 773, 1249.462203670131m, 3 },
                    { 310, 3, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0617733884077451701931922723m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1087, 1154.147673199219m, 4 },
                    { 311, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1821363183270238870792616721m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 921, 1088.747549179189m, 5 },
                    { 312, 3, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4677464688371624242424242424m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 660, 968.7126694325272m, 6 },
                    { 313, 4, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9277118546902886792452830189m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1060, 983.374565971706m, 1 },
                    { 314, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5191628363295550295857988166m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 676, 1026.9540773587792m, 2 },
                    { 315, 4, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0372579319897668825161887142m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1081, 1121.275824480938m, 3 },
                    { 316, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3435872030988135802469135802m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 810, 1088.305634510039m, 4 },
                    { 317, 4, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4921605488605110497237569061m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 724, 1080.32423737501m, 5 },
                    { 318, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6240208323629575757575757576m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 660, 1071.853749359552m, 6 },
                    { 319, 4, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3330400347059505562422744129m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 809, 1078.429388077114m, 1 },
                    { 320, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0888837061881280547409579668m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1023, 1113.928031430455m, 2 },
                    { 321, 4, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9093018973125311233885819521m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1086, 987.5018604814088m, 3 },
                    { 322, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3263983593266421686746987952m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 830, 1100.910638241113m, 4 },
                    { 323, 4, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.124329653794422507403751234m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1013, 1138.94593929375m, 5 },
                    { 324, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5325123091088732747804265997m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 797, 1221.412310359772m, 6 },
                    { 325, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0654554494525502793296089385m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1074, 1144.299152712039m, 1 },
                    { 326, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1488214774343359073359073359m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1036, 1190.179050621972m, 2 },
                    { 327, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1721534285797256385998107852m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1057, 1238.96617400877m, 3 },
                    { 328, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2932502211581989949748743719m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 995, 1286.783970052408m, 4 },
                    { 329, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.073293326393941972920696325m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1034, 1109.785299491336m, 5 },
                    { 330, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.13690297885425390625m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 896, 1018.6650690534115m, 6 },
                    { 331, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3963381433173856382978723404m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 752, 1050.046283774674m, 1 },
                    { 332, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7200564092434139344262295082m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 732, 1259.081291566179m, 2 },
                    { 333, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1132235934436588785046728972m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1070, 1191.149244984715m, 3 },
                    { 334, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1965994163983215648854961832m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1048, 1254.036188385441m, 4 },
                    { 335, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1140362416454109720885466795m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1039, 1157.483655069582m, 5 },
                    { 336, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1753828814576505154639175258m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 970, 1140.121395013921m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 337, 4, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4118077219064296137339055794m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 986.8535976125943m, 1 },
                    { 338, 3, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9738542200281104662226450999m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1051, 1023.5207852495441m, 2 },
                    { 339, 4, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9806587090111211693548387097m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 992, 972.8134393390322m, 3 },
                    { 340, 3, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9031824196024487629839471199m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1059, 956.47018235899324m, 4 },
                    { 341, 4, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2276421808364417910447761194m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 987.0243133924992m, 5 },
                    { 342, 3, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1552652401487719298245614035m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1026, 1185.30213639264m, 6 },
                    { 343, 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2035997962652432964329643296m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 813, 978.5266343636428m, 1 },
                    { 344, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.955322816157756838905775076m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 658, 1286.602413031804m, 2 },
                    { 345, 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2256208148952661469933184855m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 898, 1100.607491775949m, 3 },
                    { 346, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9093957922954441706161137441m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1055, 959.4125608716936m, 4 },
                    { 347, 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9493633186070661723818350324m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1079, 1024.3630207770244m, 5 },
                    { 348, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2215259090625119418483904465m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 963, 1176.329450427199m, 6 },
                    { 349, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9684095376205124282982791587m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1046, 1012.956376351056m, 1 },
                    { 350, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3790765978069358108108108108m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 888, 1224.620018852559m, 2 },
                    { 351, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0362948634299792452830188679m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1060, 1098.472555235778m, 3 },
                    { 352, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0874234351735329809725158562m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 946, 1028.7025696741622m, 4 },
                    { 353, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3081612435652208020050125313m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 798, 1043.9126723650462m, 5 },
                    { 354, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1911337541013233485193621868m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 878, 1045.8154361009619m, 6 },
                    { 355, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8653229928265393586005830904m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 686, 1279.611573079006m, 1 },
                    { 356, 3, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.165186905020086687306501548m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 969, 1129.066110964464m, 2 },
                    { 357, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0208611458839095149253731343m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1072, 1094.363148387551m, 3 },
                    { 358, 3, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0207465316850916030534351145m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1048, 1069.742365205976m, 4 },
                    { 359, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.95103198959772965m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000, 951.03198959772965m, 5 },
                    { 360, 3, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9200032268217623474178403756m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1065, 979.8034365651769m, 6 },
                    { 361, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2206190188958207452165156093m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 993, 1212.07468576355m, 1 },
                    { 362, 3, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5417255767251730310262529833m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 838, 1291.966033295695m, 2 },
                    { 363, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3356175743299296703296703297m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 910, 1215.411992640236m, 3 },
                    { 364, 3, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2788181443359763513513513514m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 888, 1135.590512170347m, 4 },
                    { 365, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1989521910960084656084656085m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 945, 1133.009820585728m, 5 },
                    { 366, 3, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0124937005995934634146341463m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1025, 1037.8060431145833m, 6 },
                    { 367, 4, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4254410378613664516129032258m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 775, 1104.716804342559m, 1 },
                    { 368, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6031469985599555555555555556m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 765, 1226.407453898366m, 2 },
                    { 369, 4, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0157249287675907752698724239m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1019, 1035.023702414175m, 3 },
                    { 370, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5088997882918764845605700713m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 842, 1270.49362174176m, 4 },
                    { 371, 4, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2283096764307716794731064764m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 911, 1118.990115228433m, 5 },
                    { 372, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0700993807753086785009861933m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1014, 1085.080772106163m, 6 },
                    { 373, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.8752206601196540439158279963m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1093, 956.61618151078187m, 1 },
                    { 374, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3582616361203954802259887006m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 885, 1202.06154796655m, 2 },
                    { 375, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1967724413029963270142180095m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 844, 1010.0759404597289m, 3 },
                    { 376, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1968801626372006578947368421m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 912, 1091.554708325127m, 4 },
                    { 377, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0738485722584858870967741935m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 992, 1065.257783680418m, 5 },
                    { 378, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3193609641219574468085106383m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 846, 1116.179375647176m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 379, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2076605779441452513966480447m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1074, 1297.027460712012m, 1 },
                    { 380, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6568749754109086892488954345m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 679, 1125.018108304007m, 2 },
                    { 381, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9717946938984439703153988868m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1078, 1047.5946800225226m, 3 },
                    { 382, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9444485184551645445641527914m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1021, 964.281937342723m, 4 },
                    { 383, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7958530591771728571428571429m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 700, 1257.097141424021m, 5 },
                    { 384, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.75225031344206158357771261m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 682, 1195.034713767486m, 6 },
                    { 385, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8322561114559242424242424242m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 660, 1209.28903356091m, 1 },
                    { 386, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.335981983796533852140077821m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 771, 1030.0421095071276m, 2 },
                    { 387, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1602690007440342979635584137m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 933, 1082.530977694184m, 3 },
                    { 388, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3528997937627547554347826087m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 736, 995.7342482093875m, 4 },
                    { 389, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2634106837037548682703321879m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 873, 1102.957526873378m, 5 },
                    { 390, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1143816831012654440154440154m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1036, 1154.499423692911m, 6 },
                    { 391, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1102505400434146341463414634m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1025, 1138.0068035445m, 1 },
                    { 392, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4281709457026976744186046512m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 860, 1228.22701330432m, 2 },
                    { 393, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5211575227199385714285714286m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 700, 1064.810265903957m, 3 },
                    { 394, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0561349544726802771855010661m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 938, 990.6545872953741m, 4 },
                    { 395, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3092660841581647597254004577m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 874, 1144.298557554236m, 5 },
                    { 396, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1512148288732378223495702006m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1047, 1205.32192583028m, 6 },
                    { 397, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2623392970207492975734355045m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 783, 988.4116695672467m, 1 },
                    { 398, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2276554467781236611489776047m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1027, 1260.802143841133m, 2 },
                    { 399, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3171745580332255483870967742m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 775, 1020.8102824757498m, 3 },
                    { 400, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5919750368218359635811836115m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 659, 1049.1115492655899m, 4 },
                    { 401, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9678162990539267509727626459m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1028, 994.9151554274367m, 5 },
                    { 402, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2639732267735976520811099253m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 937, 1184.342913486861m, 6 },
                    { 403, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6205760973295426251691474966m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 739, 1197.605735926532m, 1 },
                    { 404, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1541926093101997981836528759m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 991, 1143.804875826408m, 2 },
                    { 405, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4398374150151700680272108844m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 735, 1058.28050003615m, 3 },
                    { 406, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4243602583516953020134228188m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 745, 1061.148392472013m, 4 },
                    { 407, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.265411565045391304347826087m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 874, 1105.969707849672m, 5 },
                    { 408, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2811701764978698845750262329m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 953, 1220.95517820247m, 6 },
                    { 409, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.343743714301224537037037037m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 864, 1160.994569156258m, 1 },
                    { 410, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1326667846856m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 940, 1064.706777604464m, 2 },
                    { 411, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0091277222523734567901234568m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 972, 980.872146029307m, 3 },
                    { 412, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.352699989913752317880794702m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 755, 1021.288492384883m, 4 },
                    { 413, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1710394817426282051282051282m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1092, 1278.77511406295m, 5 },
                    { 414, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.284977996543082579185520362m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 884, 1135.920548944085m, 6 },
                    { 415, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2837416153673045634920634921m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1008, 1294.011548290243m, 1 },
                    { 416, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1562939955618488488488488488m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 999, 1155.137701566287m, 2 },
                    { 417, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0735763853043705140640155189m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1031, 1106.857253248806m, 3 },
                    { 418, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3842550398415096774193548387m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 930, 1287.357187052604m, 4 },
                    { 419, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.297618092163967032967032967m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1001, 1298.915710256131m, 5 },
                    { 420, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4841645728368476977567886659m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 847, 1257.08739319281m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 421, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2640577247681566459627329193m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 805, 1017.5664684383661m, 1 },
                    { 422, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1550774012845059797608095676m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1087, 1255.569135196258m, 2 },
                    { 423, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9887631411822108135942327497m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 971, 960.0890100879267m, 3 },
                    { 424, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3010812179277902439024390244m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 820, 1066.886598700788m, 4 },
                    { 425, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3572738944726543352601156069m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 865, 1174.041918718846m, 5 },
                    { 426, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7446096065593071216617210682m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 674, 1175.866874820973m, 6 },
                    { 427, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2468859087289840764331210191m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 942, 1174.566526022703m, 1 },
                    { 428, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0184337214028808139534883721m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1032, 1051.023600487773m, 2 },
                    { 429, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3135018475348153153153153153m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 888, 1166.389640610916m, 3 },
                    { 430, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5537355327648587412587412587m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 715, 1110.920905926874m, 4 },
                    { 431, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1302495579572094339622641509m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1060, 1198.064531434642m, 5 },
                    { 432, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4381694793392420382165605096m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 785, 1128.963041281305m, 6 },
                    { 433, 4, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2917488517759023109243697479m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 952, 1229.744906890659m, 1 },
                    { 434, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3645132736943622100954979536m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 733, 1000.1882296179675m, 2 },
                    { 435, 4, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6862705665300337941628264209m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 1097.762138811052m, 3 },
                    { 436, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3382155742391165374677002584m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 774, 1035.7788544610762m, 4 },
                    { 437, 4, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9266577257926351351351351351m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1073, 994.3037397754975m, 5 },
                    { 438, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0601027485763333333333333333m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1062, 1125.829118988066m, 6 },
                    { 439, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4475032185597201051248357424m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, 1101.549949323947m, 1 },
                    { 440, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5103856645382316753926701571m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 764, 1153.934647707209m, 2 },
                    { 441, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4902875296531333333333333333m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 855, 1274.195837853429m, 3 },
                    { 442, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1155040091091839323467230444m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 946, 1055.266792617288m, 4 },
                    { 443, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.337779112659724537037037037m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 864, 1155.841153338002m, 5 },
                    { 444, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1152223218953588317757009346m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 856, 954.63030754242716m, 6 },
                    { 445, 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4476631836773382183908045977m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 696, 1007.5735758394274m, 1 },
                    { 446, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0823938495265804469273743017m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 895, 968.7424953262895m, 2 },
                    { 447, 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0377699180856533898305084746m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 944, 979.6548026728568m, 3 },
                    { 448, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0891927829891438848920863309m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 973, 1059.784577848437m, 4 },
                    { 449, 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1182919560608787878787878788m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1089, 1217.819940150297m, 5 },
                    { 450, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1740442722459766355140186916m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1070, 1256.227371303195m, 6 },
                    { 451, 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1775597218407765046296296296m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 864, 1017.4115996704309m, 1 },
                    { 452, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9799011830867667336683417085m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 995, 975.0016771713329m, 2 },
                    { 453, 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1128674917903609706774519717m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 989, 1100.625949380667m, 3 },
                    { 454, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.274529950944724317617866005m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 806, 1027.2711404614478m, 4 },
                    { 455, 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1329640128263070942662779397m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1029, 1165.81996919827m, 5 },
                    { 456, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0619667146512463054187192118m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1015, 1077.896215371015m, 6 },
                    { 457, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0459354496764985862393967955m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1061, 1109.737512106765m, 1 },
                    { 458, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2420361585538095781071835804m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 877, 1089.265711051691m, 2 },
                    { 459, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2656458473981495016611295681m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 903, 1142.878200200529m, 3 },
                    { 460, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4988700233754757396449704142m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 845, 1266.545169752277m, 4 },
                    { 461, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1270104410647962413452027695m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1011, 1139.407555916509m, 5 },
                    { 462, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.078055675210473m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000, 1078.055675210473m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 463, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3274335098847538670284938942m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 737, 978.3184967850636m, 1 },
                    { 464, 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2798574657754565656565656566m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 990, 1267.058891117702m, 2 },
                    { 465, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.106498202967718562874251497m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1002, 1108.711199373654m, 3 },
                    { 466, 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9879552745726471910112359551m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 979, 967.2082138066216m, 4 },
                    { 467, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4365409976992159887798036466m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 1024.253731359541m, 5 },
                    { 468, 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4635986312734066852367688022m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 718, 1050.863817254306m, 6 },
                    { 469, 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1074098760511498297389330306m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 881, 975.628100801063m, 1 },
                    { 470, 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.865497926975197962154294032m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 687, 1281.597075831961m, 2 },
                    { 471, 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.146006312720434402332361516m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1029, 1179.240495789327m, 3 },
                    { 472, 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3780525870659755011135857461m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 898, 1237.491223185246m, 4 },
                    { 473, 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2361111520427370731707317073m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 820, 1013.6111446750444m, 5 },
                    { 474, 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4003085877834898929845422117m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 841, 1177.659522325915m, 6 },
                    { 475, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1411351353639537922987164527m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 857, 977.9528110069084m, 1 },
                    { 476, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7408878522079914772727272727m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 704, 1225.585047954426m, 2 },
                    { 477, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3231787521126426582278481013m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 790, 1045.3112141689877m, 3 },
                    { 478, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.523527064386047361299052774m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 739, 1125.886500581289m, 4 },
                    { 479, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1892380744481241513094083414m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1031, 1226.104454756016m, 5 },
                    { 480, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2614598886971097992916174734m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 847, 1068.456525726452m, 6 },
                    { 481, 4, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3722815098315969162995594714m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 908, 1246.03161092709m, 1 },
                    { 482, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4644831162812481296758104738m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 802, 1174.515459257561m, 2 },
                    { 483, 4, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2023744770018881640260950606m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1073, 1290.147813823026m, 3 },
                    { 484, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2247707119983560714285714286m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 840, 1028.8073980786191m, 4 },
                    { 485, 4, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7957637634681633522727272727m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 704, 1264.217689481587m, 5 },
                    { 486, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3635332848617268817204301075m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 930, 1268.085954921406m, 6 },
                    { 487, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1414999948044518518518518519m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1080, 1232.819994388808m, 1 },
                    { 488, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4010723761569110504774897681m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 733, 1026.9860517230158m, 2 },
                    { 489, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2554999178639572815533980583m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1030, 1293.164915399876m, 3 },
                    { 490, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6338067561389107413010590015m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 661, 1079.94626580782m, 4 },
                    { 491, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6302513383187717948717948718m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 780, 1271.596043888642m, 5 },
                    { 492, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1340644292902286324786324786m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 936, 1061.484305815654m, 6 },
                    { 493, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0936502614602843956043956044m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 910, 995.2217379288588m, 1 },
                    { 494, 3, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4125188124213468468468468468m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 888, 1254.316705430156m, 2 },
                    { 495, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1842787813284222846441947566m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1068, 1264.809738458755m, 3 },
                    { 496, 3, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6352983549555399239543726236m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 789, 1290.250402059921m, 4 },
                    { 497, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2774740472977305194805194805m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 924, 1180.386019703103m, 5 },
                    { 498, 3, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9953310356447943396226415094m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1060, 1055.050897783482m, 6 },
                    { 499, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4059257125376238286479250335m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 747, 1050.226507265605m, 1 },
                    { 500, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3104295175065285388127853881m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 876, 1147.936257335719m, 2 },
                    { 501, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4131285296864266517357222844m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 893, 1261.923777009979m, 3 },
                    { 502, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2160909863329431230610134436m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 967, 1175.959983783956m, 4 },
                    { 503, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1492750785082372340425531915m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 940, 1080.318573797743m, 5 },
                    { 504, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2037511906445912017167381974m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 932, 1121.896109680759m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 505, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5724134617809397417503586801m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 697, 1095.972182861315m, 1 },
                    { 506, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1577806048574348677766895201m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1021, 1182.093997559441m, 2 },
                    { 507, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1255645641816456018518518519m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 864, 972.4877834529418m, 3 },
                    { 508, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1782159281962154306220095694m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 836, 984.9885159720361m, 4 },
                    { 509, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2007288364709421252371916509m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1054, 1265.568193640373m, 5 },
                    { 510, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1483335325212365227537922987m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 857, 984.1218373706997m, 6 },
                    { 511, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9888094054500958731808731809m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 962, 951.23464804299223m, 1 },
                    { 512, 3, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2538326227084334140435835351m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 826, 1035.665746357166m, 2 },
                    { 513, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2323985273583126829268292683m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 820, 1010.5667924338164m, 3 },
                    { 514, 3, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3216061043528193166885676741m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, 1005.7422454124955m, 4 },
                    { 515, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3604984222762476290832455216m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 949, 1291.113002740159m, 5 },
                    { 516, 3, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0176791261634258130081300813m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 984, 1001.396260144811m, 6 },
                    { 517, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2161295298283828571428571429m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1050, 1276.936006319802m, 1 },
                    { 518, 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5187806068178737151248164464m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 681, 1034.289593242972m, 2 },
                    { 519, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2603860807294875373878364905m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1003, 1264.167238971676m, 3 },
                    { 520, 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0321840933909285051067780873m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1077, 1111.66226858203m, 4 },
                    { 521, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2060148728590140318054256314m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1069, 1289.229899086286m, 5 },
                    { 522, 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5079545863121916243654822335m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 788, 1188.268214014007m, 6 },
                    { 523, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3470704987843893499308437068m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 723, 973.9319706211135m, 1 },
                    { 524, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0638259611114376310272536688m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 954, 1014.8899669003115m, 2 },
                    { 525, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4391014186221486310299869622m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 767, 1103.790788083188m, 3 },
                    { 526, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5219388330075900783289817232m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 766, 1165.805146083814m, 4 },
                    { 527, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7151018790891643835616438356m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 657, 1126.821934561581m, 5 },
                    { 528, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.412192571031880225988700565m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 885, 1249.790425363214m, 6 },
                    { 529, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0870249953825938775510204082m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 980, 1065.284495474942m, 1 },
                    { 530, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2132327327216645283018867925m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 795, 964.5200225137233m, 2 },
                    { 531, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.501326918430607185628742515m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 835, 1253.607976889557m, 3 },
                    { 532, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2985608409874104046242774566m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 865, 1123.25512745411m, 4 },
                    { 533, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1552016780287924293785310734m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 885, 1022.3534850554813m, 5 },
                    { 534, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5852721218187064102564102564m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 780, 1236.512255018591m, 6 },
                    { 535, 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1277382334691775431861804223m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1042, 1175.103239274883m, 1 },
                    { 536, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2304355457382384332925336597m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 817, 1005.2658408681408m, 2 },
                    { 537, 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2267382682153620775969962453m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 980.1638763040743m, 3 },
                    { 538, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4993308739250546875m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 768, 1151.486111174442m, 4 },
                    { 539, 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6362939266557655826558265583m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 738, 1207.584917871955m, 5 },
                    { 540, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2123612507047744360902255639m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1064, 1289.95237074988m, 6 },
                    { 541, 4, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2293538153226711538461538462m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1040, 1278.527967935578m, 1 },
                    { 542, 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5260117420333147410358565737m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 753, 1149.086841751086m, 2 },
                    { 543, 4, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0068337601142275174476570289m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1003, 1009.8542613945702m, 3 },
                    { 544, 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5311857701371233373639661427m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 827, 1266.290631903401m, 4 },
                    { 545, 4, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0590397987074821092278719397m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1062, 1124.700266227346m, 5 },
                    { 546, 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5645975049523803763440860215m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 744, 1164.060543684571m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 547, 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4839533758219843184559710495m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 829, 1230.197348556425m, 1 },
                    { 548, 3, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9658289398618858356940509915m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1059, 1022.8128473137371m, 2 },
                    { 549, 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3801304925348677379480840544m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 809, 1116.525568460708m, 3 },
                    { 550, 3, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9181394015655460966542750929m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1076, 987.9179960845276m, 4 },
                    { 551, 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0788944265012286947141316073m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 927, 1000.135133366639m, 5 },
                    { 552, 3, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7443824008968024861878453039m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 724, 1262.932858249285m, 6 },
                    { 553, 4, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4609347655901m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 740, 1081.091726536674m, 1 },
                    { 554, 3, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9751842508323383383383383383m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 999, 974.209066581506m, 2 },
                    { 555, 4, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.94701239215127274490785645m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1031, 976.3697763079622m, 3 },
                    { 556, 3, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3175834716448096304591265398m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 893, 1176.602040178815m, 4 },
                    { 557, 4, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.196357180287824m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000, 1196.357180287824m, 5 },
                    { 558, 3, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.551006006697345578231292517m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 735, 1139.989414922549m, 6 },
                    { 559, 4, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0185902108995444670050761421m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 985, 1003.3113577360513m, 1 },
                    { 560, 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9318498387642989767441860465m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1075, 1001.7385766716214m, 2 },
                    { 561, 4, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1088618957576247563352826511m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1026, 1137.692305047323m, 3 },
                    { 562, 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4601557258774038461538461538m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 832, 1214.84956393m, 4 },
                    { 563, 4, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2407322873641641717791411043m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 815, 1011.1968142017938m, 5 },
                    { 564, 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5646694003118498759305210918m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 806, 1261.123536651351m, 6 },
                    { 565, 4, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3743775266530236051502145923m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 932, 1280.919854840618m, 1 },
                    { 566, 3, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0501829154237494897959183673m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 980, 1029.1792571152745m, 2 },
                    { 567, 4, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2734100310606222455403987408m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 953, 1213.559759600773m, 3 },
                    { 568, 3, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9738975658963248751248751249m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1001, 974.8714634622212m, 4 },
                    { 569, 4, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6677181483155101763907734057m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 737, 1229.108275308531m, 5 },
                    { 570, 3, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8066474375456526946107784431m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 668, 1206.840488280496m, 6 },
                    { 571, 4, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8691366419873497109826589595m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 692, 1293.442556255246m, 1 },
                    { 572, 3, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9110144693880833802816901408m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1065, 970.2304098983088m, 2 },
                    { 573, 4, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5390817902996103225806451613m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 775, 1192.788387482198m, 3 },
                    { 574, 3, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5613818725928381578947368421m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 760, 1186.650223170557m, 4 },
                    { 575, 4, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4934417107328733333333333333m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 750, 1120.081283049655m, 5 },
                    { 576, 3, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6605086095069044943820224719m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 712, 1182.282129968916m, 6 },
                    { 577, 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5114261578669211246200607903m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 658, 994.5184118764341m, 1 },
                    { 578, 3, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2979857688909269311064718163m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 958, 1243.470366597508m, 2 },
                    { 579, 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7138158425853761840324763194m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 739, 1266.509907670593m, 3 },
                    { 580, 3, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6925025910927939042089985486m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 689, 1166.134285262935m, 4 },
                    { 581, 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4281587471562758229284903519m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 881, 1258.207856244679m, 5 },
                    { 582, 3, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.210599364153978494623655914m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 930, 1125.8574086632m, 6 },
                    { 583, 4, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8546642588829728915662650602m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 1231.497067898294m, 1 },
                    { 584, 3, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5341093129256615969581749049m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 789, 1210.412247898347m, 2 },
                    { 585, 4, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.544715149271137905604719764m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 678, 1047.3168712058315m, 3 },
                    { 586, 3, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3393603761563499306518723994m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 721, 965.6788312087283m, 4 },
                    { 587, 4, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4137821451820157273918741809m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 763, 1078.715776773878m, 5 },
                    { 588, 3, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2586061686581985130111524164m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 807, 1015.6951781071662m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 589, 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5018250419101535444947209653m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 663, 995.7100027864318m, 1 },
                    { 590, 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4208051625786145181476846058m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 1135.223324900313m, 2 },
                    { 591, 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1043337889564848484848484848m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 957, 1056.847436031356m, 3 },
                    { 592, 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0763510140987678571428571429m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1064, 1145.237479001089m, 4 },
                    { 593, 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2858312806025918114143920596m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 806, 1036.380012165689m, 5 },
                    { 594, 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.339294191195874787323943662m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 710, 950.898875749071099m, 6 }
                });

            migrationBuilder.InsertData(
                table: "TruckExpenses",
                columns: new[] { "Id", "Amount", "EmployeeId", "ExpenseDate", "Notes", "TruckId", "Type" },
                values: new object[,]
                {
                    { 1, 3000.0m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Maintenance in June 2023", 1, 0 },
                    { 2, 3100.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Fuel in June 2023", 1, 1 },
                    { 3, 1200.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - RoadTaxes in June 2023", 1, 2 },
                    { 4, 2700.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - DriverSalary in June 2023", 1, 3 },
                    { 5, 3000.0m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Maintenance in June 2023", 2, 0 },
                    { 6, 3100.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Fuel in June 2023", 2, 1 },
                    { 7, 1200.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - RoadTaxes in June 2023", 2, 2 },
                    { 8, 2700.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - DriverSalary in June 2023", 2, 3 },
                    { 9, 3000.0m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Maintenance in June 2023", 3, 0 },
                    { 10, 3100.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Fuel in June 2023", 3, 1 },
                    { 11, 1200.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - RoadTaxes in June 2023", 3, 2 },
                    { 12, 2700.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - DriverSalary in June 2023", 3, 3 },
                    { 13, 3000.0m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Maintenance in June 2023", 4, 0 },
                    { 14, 3100.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Fuel in June 2023", 4, 1 },
                    { 15, 1200.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - RoadTaxes in June 2023", 4, 2 },
                    { 16, 2700.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - DriverSalary in June 2023", 4, 3 },
                    { 17, 3000.0m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Maintenance in June 2023", 5, 0 },
                    { 18, 3100.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Fuel in June 2023", 5, 1 },
                    { 19, 1200.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - RoadTaxes in June 2023", 5, 2 },
                    { 20, 2700.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - DriverSalary in June 2023", 5, 3 },
                    { 21, 3000.0m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Maintenance in June 2023", 6, 0 },
                    { 22, 3100.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Fuel in June 2023", 6, 1 },
                    { 23, 1200.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - RoadTaxes in June 2023", 6, 2 },
                    { 24, 2700.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in June 2023", 6, 3 },
                    { 25, 3000.0m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Maintenance in July 2023", 1, 0 },
                    { 26, 3100.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Fuel in July 2023", 1, 1 },
                    { 27, 1200.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - RoadTaxes in July 2023", 1, 2 },
                    { 28, 2700.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - DriverSalary in July 2023", 1, 3 },
                    { 29, 3000.0m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Maintenance in July 2023", 2, 0 },
                    { 30, 3100.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Fuel in July 2023", 2, 1 },
                    { 31, 1200.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - RoadTaxes in July 2023", 2, 2 },
                    { 32, 2700.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - DriverSalary in July 2023", 2, 3 },
                    { 33, 3000.0m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Maintenance in July 2023", 3, 0 },
                    { 34, 3100.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Fuel in July 2023", 3, 1 },
                    { 35, 1200.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - RoadTaxes in July 2023", 3, 2 },
                    { 36, 2700.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - DriverSalary in July 2023", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "TruckExpenses",
                columns: new[] { "Id", "Amount", "EmployeeId", "ExpenseDate", "Notes", "TruckId", "Type" },
                values: new object[,]
                {
                    { 37, 3000.0m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Maintenance in July 2023", 4, 0 },
                    { 38, 3100.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Fuel in July 2023", 4, 1 },
                    { 39, 1200.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - RoadTaxes in July 2023", 4, 2 },
                    { 40, 2700.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - DriverSalary in July 2023", 4, 3 },
                    { 41, 3000.0m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Maintenance in July 2023", 5, 0 },
                    { 42, 3100.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Fuel in July 2023", 5, 1 },
                    { 43, 1200.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - RoadTaxes in July 2023", 5, 2 },
                    { 44, 2700.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - DriverSalary in July 2023", 5, 3 },
                    { 45, 3000.0m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Maintenance in July 2023", 6, 0 },
                    { 46, 3100.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Fuel in July 2023", 6, 1 },
                    { 47, 1200.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - RoadTaxes in July 2023", 6, 2 },
                    { 48, 2700.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in July 2023", 6, 3 },
                    { 49, 3000.0m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Maintenance in August 2023", 1, 0 },
                    { 50, 3100.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Fuel in August 2023", 1, 1 },
                    { 51, 1200.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - RoadTaxes in August 2023", 1, 2 },
                    { 52, 2700.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - DriverSalary in August 2023", 1, 3 },
                    { 53, 3000.0m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Maintenance in August 2023", 2, 0 },
                    { 54, 3100.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Fuel in August 2023", 2, 1 },
                    { 55, 1200.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - RoadTaxes in August 2023", 2, 2 },
                    { 56, 2700.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - DriverSalary in August 2023", 2, 3 },
                    { 57, 3000.0m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Maintenance in August 2023", 3, 0 },
                    { 58, 3100.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Fuel in August 2023", 3, 1 },
                    { 59, 1200.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - RoadTaxes in August 2023", 3, 2 },
                    { 60, 2700.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - DriverSalary in August 2023", 3, 3 },
                    { 61, 3000.0m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Maintenance in August 2023", 4, 0 },
                    { 62, 3100.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Fuel in August 2023", 4, 1 },
                    { 63, 1200.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - RoadTaxes in August 2023", 4, 2 },
                    { 64, 2700.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - DriverSalary in August 2023", 4, 3 },
                    { 65, 3000.0m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Maintenance in August 2023", 5, 0 },
                    { 66, 3100.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Fuel in August 2023", 5, 1 },
                    { 67, 1200.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - RoadTaxes in August 2023", 5, 2 },
                    { 68, 2700.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - DriverSalary in August 2023", 5, 3 },
                    { 69, 3000.0m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Maintenance in August 2023", 6, 0 },
                    { 70, 3100.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Fuel in August 2023", 6, 1 },
                    { 71, 1200.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - RoadTaxes in August 2023", 6, 2 },
                    { 72, 2700.00m, 3, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in August 2023", 6, 3 },
                    { 73, 3000.0m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Maintenance in September 2023", 1, 0 },
                    { 74, 3100.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Fuel in September 2023", 1, 1 },
                    { 75, 1200.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - RoadTaxes in September 2023", 1, 2 },
                    { 76, 2700.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - DriverSalary in September 2023", 1, 3 },
                    { 77, 3000.0m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Maintenance in September 2023", 2, 0 },
                    { 78, 3100.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Fuel in September 2023", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "TruckExpenses",
                columns: new[] { "Id", "Amount", "EmployeeId", "ExpenseDate", "Notes", "TruckId", "Type" },
                values: new object[,]
                {
                    { 79, 1200.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - RoadTaxes in September 2023", 2, 2 },
                    { 80, 2700.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - DriverSalary in September 2023", 2, 3 },
                    { 81, 3000.0m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Maintenance in September 2023", 3, 0 },
                    { 82, 3100.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Fuel in September 2023", 3, 1 },
                    { 83, 1200.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - RoadTaxes in September 2023", 3, 2 },
                    { 84, 2700.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - DriverSalary in September 2023", 3, 3 },
                    { 85, 3000.0m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Maintenance in September 2023", 4, 0 },
                    { 86, 3100.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Fuel in September 2023", 4, 1 },
                    { 87, 1200.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - RoadTaxes in September 2023", 4, 2 },
                    { 88, 2700.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - DriverSalary in September 2023", 4, 3 },
                    { 89, 3000.0m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Maintenance in September 2023", 5, 0 },
                    { 90, 3100.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Fuel in September 2023", 5, 1 },
                    { 91, 1200.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - RoadTaxes in September 2023", 5, 2 },
                    { 92, 2700.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - DriverSalary in September 2023", 5, 3 },
                    { 93, 3000.0m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Maintenance in September 2023", 6, 0 },
                    { 94, 3100.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Fuel in September 2023", 6, 1 },
                    { 95, 1200.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - RoadTaxes in September 2023", 6, 2 },
                    { 96, 2700.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in September 2023", 6, 3 },
                    { 97, 3000.0m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Maintenance in October 2023", 1, 0 },
                    { 98, 3100.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Fuel in October 2023", 1, 1 },
                    { 99, 1200.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - RoadTaxes in October 2023", 1, 2 },
                    { 100, 2700.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - DriverSalary in October 2023", 1, 3 },
                    { 101, 3000.0m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Maintenance in October 2023", 2, 0 },
                    { 102, 3100.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Fuel in October 2023", 2, 1 },
                    { 103, 1200.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - RoadTaxes in October 2023", 2, 2 },
                    { 104, 2700.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - DriverSalary in October 2023", 2, 3 },
                    { 105, 3000.0m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Maintenance in October 2023", 3, 0 },
                    { 106, 3100.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Fuel in October 2023", 3, 1 },
                    { 107, 1200.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - RoadTaxes in October 2023", 3, 2 },
                    { 108, 2700.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - DriverSalary in October 2023", 3, 3 },
                    { 109, 3000.0m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Maintenance in October 2023", 4, 0 },
                    { 110, 3100.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Fuel in October 2023", 4, 1 },
                    { 111, 1200.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - RoadTaxes in October 2023", 4, 2 },
                    { 112, 2700.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - DriverSalary in October 2023", 4, 3 },
                    { 113, 3000.0m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Maintenance in October 2023", 5, 0 },
                    { 114, 3100.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Fuel in October 2023", 5, 1 },
                    { 115, 1200.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - RoadTaxes in October 2023", 5, 2 },
                    { 116, 2700.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - DriverSalary in October 2023", 5, 3 },
                    { 117, 3000.0m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Maintenance in October 2023", 6, 0 },
                    { 118, 3100.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Fuel in October 2023", 6, 1 },
                    { 119, 1200.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - RoadTaxes in October 2023", 6, 2 },
                    { 120, 2700.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in October 2023", 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "TruckExpenses",
                columns: new[] { "Id", "Amount", "EmployeeId", "ExpenseDate", "Notes", "TruckId", "Type" },
                values: new object[,]
                {
                    { 121, 3000.0m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Maintenance in November 2023", 1, 0 },
                    { 122, 3100.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Fuel in November 2023", 1, 1 },
                    { 123, 1200.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - RoadTaxes in November 2023", 1, 2 },
                    { 124, 2700.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - DriverSalary in November 2023", 1, 3 },
                    { 125, 3000.0m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Maintenance in November 2023", 2, 0 },
                    { 126, 3100.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Fuel in November 2023", 2, 1 },
                    { 127, 1200.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - RoadTaxes in November 2023", 2, 2 },
                    { 128, 2700.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - DriverSalary in November 2023", 2, 3 },
                    { 129, 3000.0m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Maintenance in November 2023", 3, 0 },
                    { 130, 3100.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Fuel in November 2023", 3, 1 },
                    { 131, 1200.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - RoadTaxes in November 2023", 3, 2 },
                    { 132, 2700.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - DriverSalary in November 2023", 3, 3 },
                    { 133, 3000.0m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Maintenance in November 2023", 4, 0 },
                    { 134, 3100.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Fuel in November 2023", 4, 1 },
                    { 135, 1200.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - RoadTaxes in November 2023", 4, 2 },
                    { 136, 2700.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - DriverSalary in November 2023", 4, 3 },
                    { 137, 3000.0m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Maintenance in November 2023", 5, 0 },
                    { 138, 3100.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Fuel in November 2023", 5, 1 },
                    { 139, 1200.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - RoadTaxes in November 2023", 5, 2 },
                    { 140, 2700.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - DriverSalary in November 2023", 5, 3 },
                    { 141, 3000.0m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Maintenance in November 2023", 6, 0 },
                    { 142, 3100.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Fuel in November 2023", 6, 1 },
                    { 143, 1200.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - RoadTaxes in November 2023", 6, 2 },
                    { 144, 2700.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in November 2023", 6, 3 },
                    { 145, 3000.0m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Maintenance in December 2023", 1, 0 },
                    { 146, 3100.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Fuel in December 2023", 1, 1 },
                    { 147, 1200.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - RoadTaxes in December 2023", 1, 2 },
                    { 148, 2700.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - DriverSalary in December 2023", 1, 3 },
                    { 149, 3000.0m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Maintenance in December 2023", 2, 0 },
                    { 150, 3100.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Fuel in December 2023", 2, 1 },
                    { 151, 1200.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - RoadTaxes in December 2023", 2, 2 },
                    { 152, 2700.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - DriverSalary in December 2023", 2, 3 },
                    { 153, 3000.0m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Maintenance in December 2023", 3, 0 },
                    { 154, 3100.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Fuel in December 2023", 3, 1 },
                    { 155, 1200.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - RoadTaxes in December 2023", 3, 2 },
                    { 156, 2700.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - DriverSalary in December 2023", 3, 3 },
                    { 157, 3000.0m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Maintenance in December 2023", 4, 0 },
                    { 158, 3100.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Fuel in December 2023", 4, 1 },
                    { 159, 1200.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - RoadTaxes in December 2023", 4, 2 },
                    { 160, 2700.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - DriverSalary in December 2023", 4, 3 },
                    { 161, 3000.0m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Maintenance in December 2023", 5, 0 },
                    { 162, 3100.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Fuel in December 2023", 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "TruckExpenses",
                columns: new[] { "Id", "Amount", "EmployeeId", "ExpenseDate", "Notes", "TruckId", "Type" },
                values: new object[,]
                {
                    { 163, 1200.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - RoadTaxes in December 2023", 5, 2 },
                    { 164, 2700.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - DriverSalary in December 2023", 5, 3 },
                    { 165, 3000.0m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Maintenance in December 2023", 6, 0 },
                    { 166, 3100.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Fuel in December 2023", 6, 1 },
                    { 167, 1200.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - RoadTaxes in December 2023", 6, 2 },
                    { 168, 2700.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in December 2023", 6, 3 },
                    { 169, 3000.0m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Maintenance in January 2024", 1, 0 },
                    { 170, 3100.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Fuel in January 2024", 1, 1 },
                    { 171, 1200.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - RoadTaxes in January 2024", 1, 2 },
                    { 172, 2700.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - DriverSalary in January 2024", 1, 3 },
                    { 173, 3000.0m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Maintenance in January 2024", 2, 0 },
                    { 174, 3100.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Fuel in January 2024", 2, 1 },
                    { 175, 1200.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - RoadTaxes in January 2024", 2, 2 },
                    { 176, 2700.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - DriverSalary in January 2024", 2, 3 },
                    { 177, 3000.0m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Maintenance in January 2024", 3, 0 },
                    { 178, 3100.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Fuel in January 2024", 3, 1 },
                    { 179, 1200.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - RoadTaxes in January 2024", 3, 2 },
                    { 180, 2700.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - DriverSalary in January 2024", 3, 3 },
                    { 181, 3000.0m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Maintenance in January 2024", 4, 0 },
                    { 182, 3100.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Fuel in January 2024", 4, 1 },
                    { 183, 1200.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - RoadTaxes in January 2024", 4, 2 },
                    { 184, 2700.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - DriverSalary in January 2024", 4, 3 },
                    { 185, 3000.0m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Maintenance in January 2024", 5, 0 },
                    { 186, 3100.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Fuel in January 2024", 5, 1 },
                    { 187, 1200.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - RoadTaxes in January 2024", 5, 2 },
                    { 188, 2700.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - DriverSalary in January 2024", 5, 3 },
                    { 189, 3000.0m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Maintenance in January 2024", 6, 0 },
                    { 190, 3100.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Fuel in January 2024", 6, 1 },
                    { 191, 1200.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - RoadTaxes in January 2024", 6, 2 },
                    { 192, 2700.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in January 2024", 6, 3 },
                    { 193, 3000.0m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Maintenance in February 2024", 1, 0 },
                    { 194, 3100.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Fuel in February 2024", 1, 1 },
                    { 195, 1200.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - RoadTaxes in February 2024", 1, 2 },
                    { 196, 2700.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - DriverSalary in February 2024", 1, 3 },
                    { 197, 3000.0m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Maintenance in February 2024", 2, 0 },
                    { 198, 3100.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Fuel in February 2024", 2, 1 },
                    { 199, 1200.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - RoadTaxes in February 2024", 2, 2 },
                    { 200, 2700.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - DriverSalary in February 2024", 2, 3 },
                    { 201, 3000.0m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Maintenance in February 2024", 3, 0 },
                    { 202, 3100.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Fuel in February 2024", 3, 1 },
                    { 203, 1200.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - RoadTaxes in February 2024", 3, 2 },
                    { 204, 2700.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - DriverSalary in February 2024", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "TruckExpenses",
                columns: new[] { "Id", "Amount", "EmployeeId", "ExpenseDate", "Notes", "TruckId", "Type" },
                values: new object[,]
                {
                    { 205, 3000.0m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Maintenance in February 2024", 4, 0 },
                    { 206, 3100.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Fuel in February 2024", 4, 1 },
                    { 207, 1200.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - RoadTaxes in February 2024", 4, 2 },
                    { 208, 2700.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - DriverSalary in February 2024", 4, 3 },
                    { 209, 3000.0m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Maintenance in February 2024", 5, 0 },
                    { 210, 3100.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Fuel in February 2024", 5, 1 },
                    { 211, 1200.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - RoadTaxes in February 2024", 5, 2 },
                    { 212, 2700.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - DriverSalary in February 2024", 5, 3 },
                    { 213, 3000.0m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Maintenance in February 2024", 6, 0 },
                    { 214, 3100.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Fuel in February 2024", 6, 1 },
                    { 215, 1200.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - RoadTaxes in February 2024", 6, 2 },
                    { 216, 2700.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in February 2024", 6, 3 },
                    { 217, 3000.0m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Maintenance in March 2024", 1, 0 },
                    { 218, 3100.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Fuel in March 2024", 1, 1 },
                    { 219, 1200.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - RoadTaxes in March 2024", 1, 2 },
                    { 220, 2700.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - DriverSalary in March 2024", 1, 3 },
                    { 221, 3000.0m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Maintenance in March 2024", 2, 0 },
                    { 222, 3100.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Fuel in March 2024", 2, 1 },
                    { 223, 1200.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - RoadTaxes in March 2024", 2, 2 },
                    { 224, 2700.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - DriverSalary in March 2024", 2, 3 },
                    { 225, 3000.0m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Maintenance in March 2024", 3, 0 },
                    { 226, 3100.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Fuel in March 2024", 3, 1 },
                    { 227, 1200.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - RoadTaxes in March 2024", 3, 2 },
                    { 228, 2700.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - DriverSalary in March 2024", 3, 3 },
                    { 229, 3000.0m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Maintenance in March 2024", 4, 0 },
                    { 230, 3100.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Fuel in March 2024", 4, 1 },
                    { 231, 1200.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - RoadTaxes in March 2024", 4, 2 },
                    { 232, 2700.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - DriverSalary in March 2024", 4, 3 },
                    { 233, 3000.0m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Maintenance in March 2024", 5, 0 },
                    { 234, 3100.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Fuel in March 2024", 5, 1 },
                    { 235, 1200.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - RoadTaxes in March 2024", 5, 2 },
                    { 236, 2700.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - DriverSalary in March 2024", 5, 3 },
                    { 237, 3000.0m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Maintenance in March 2024", 6, 0 },
                    { 238, 3100.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Fuel in March 2024", 6, 1 },
                    { 239, 1200.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - RoadTaxes in March 2024", 6, 2 },
                    { 240, 2700.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in March 2024", 6, 3 },
                    { 241, 3000.0m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Maintenance in April 2024", 1, 0 },
                    { 242, 3100.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - Fuel in April 2024", 1, 1 },
                    { 243, 1200.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - RoadTaxes in April 2024", 1, 2 },
                    { 244, 2700.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 1 - DriverSalary in April 2024", 1, 3 },
                    { 245, 3000.0m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Maintenance in April 2024", 2, 0 },
                    { 246, 3100.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Fuel in April 2024", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "TruckExpenses",
                columns: new[] { "Id", "Amount", "EmployeeId", "ExpenseDate", "Notes", "TruckId", "Type" },
                values: new object[,]
                {
                    { 247, 1200.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - RoadTaxes in April 2024", 2, 2 },
                    { 248, 2700.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - DriverSalary in April 2024", 2, 3 },
                    { 249, 3000.0m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Maintenance in April 2024", 3, 0 },
                    { 250, 3100.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - Fuel in April 2024", 3, 1 },
                    { 251, 1200.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - RoadTaxes in April 2024", 3, 2 },
                    { 252, 2700.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - DriverSalary in April 2024", 3, 3 },
                    { 253, 3000.0m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Maintenance in April 2024", 4, 0 },
                    { 254, 3100.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - Fuel in April 2024", 4, 1 },
                    { 255, 1200.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - RoadTaxes in April 2024", 4, 2 },
                    { 256, 2700.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 4 - DriverSalary in April 2024", 4, 3 },
                    { 257, 3000.0m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Maintenance in April 2024", 5, 0 },
                    { 258, 3100.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Fuel in April 2024", 5, 1 },
                    { 259, 1200.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - RoadTaxes in April 2024", 5, 2 },
                    { 260, 2700.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - DriverSalary in April 2024", 5, 3 },
                    { 261, 3000.0m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Maintenance in April 2024", 6, 0 },
                    { 262, 3100.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - Fuel in April 2024", 6, 1 },
                    { 263, 1200.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - RoadTaxes in April 2024", 6, 2 },
                    { 264, 2700.00m, 3, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in April 2024", 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 1, 7, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1181.599887426301m, 1 },
                    { 2, 6, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1276.774441472737m, 2 },
                    { 3, 2, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1172.175368383812m, 3 },
                    { 4, 7, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1105.258415071994m, 4 },
                    { 5, 10, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1286.267680312338m, 5 },
                    { 6, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1190.566827477597m, 6 },
                    { 7, 5, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1020.9093860583834m, 7 },
                    { 8, 8, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1130.531452828497m, 8 },
                    { 9, 5, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1112.275862347173m, 9 },
                    { 10, 5, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1262.863232506382m, 10 },
                    { 11, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1187.652827425461m, 11 },
                    { 12, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1061.040712003257m, 12 },
                    { 13, 7, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1031.1237303973582m, 13 },
                    { 14, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1212.855757071097m, 14 },
                    { 15, 2, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1264.020617916319m, 15 },
                    { 16, 5, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1236.402869887842m, 16 },
                    { 17, 1, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1249.659755942149m, 17 },
                    { 18, 7, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1071.769190862095m, 18 },
                    { 19, 10, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1275.725947662902m, 19 },
                    { 20, 9, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 976.6554547043728m, 20 },
                    { 21, 2, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1057.143015046304m, 21 },
                    { 22, 2, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1263.359234757979m, 22 },
                    { 23, 5, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1215.229469633681m, 23 },
                    { 24, 1, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 963.2972935713625m, 24 },
                    { 25, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1242.224580813227m, 25 },
                    { 26, 9, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1231.096777163756m, 26 },
                    { 27, 9, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1091.78525384216m, 27 },
                    { 28, 10, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1106.147904974846m, 28 },
                    { 29, 7, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1024.4600915432609m, 29 },
                    { 30, 5, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1099.726044521676m, 30 },
                    { 31, 7, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 964.3686149815801m, 31 },
                    { 32, 6, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1051.413438319367m, 32 },
                    { 33, 7, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1156.085516054218m, 33 },
                    { 34, 5, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1087.529962980343m, 34 },
                    { 35, 2, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1073.294354338413m, 35 },
                    { 36, 9, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1088.034177553013m, 36 },
                    { 37, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1103.002880036692m, 37 },
                    { 38, 6, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1191.950894094827m, 38 },
                    { 39, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1033.4155524425127m, 39 },
                    { 40, 6, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1020.1821389343434m, 40 },
                    { 41, 10, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 974.2882735603367m, 41 },
                    { 42, 9, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 990.5421174810604m, 42 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 43, 9, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1195.306727065694m, 43 },
                    { 44, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1188.452771307854m, 44 },
                    { 45, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1140.916911989885m, 45 },
                    { 46, 10, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 955.25437784139766m, 46 },
                    { 47, 2, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1106.690910711285m, 47 },
                    { 48, 1, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1046.4510748191651m, 48 },
                    { 49, 9, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1115.244590809567m, 49 },
                    { 50, 7, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1122.092322666818m, 50 },
                    { 51, 6, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.741638329m, 51 },
                    { 52, 7, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 952.98709931190328m, 52 },
                    { 53, 1, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 986.7182576406488m, 53 },
                    { 54, 2, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1226.700841314141m, 54 },
                    { 55, 8, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1266.91151219104m, 55 },
                    { 56, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1112.772490699552m, 56 },
                    { 57, 9, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1248.436629456229m, 57 },
                    { 58, 8, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 962.3345248307136m, 58 },
                    { 59, 4, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1264.521342471847m, 59 },
                    { 60, 7, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1194.394074088569m, 60 },
                    { 61, 9, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1050.934627640752m, 61 },
                    { 62, 5, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1020.7008205875722m, 62 },
                    { 63, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1176.499025693322m, 63 },
                    { 64, 8, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1124.341449625609m, 64 },
                    { 65, 2, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 978.4146111667795m, 65 },
                    { 66, 5, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1288.381769153376m, 66 },
                    { 67, 6, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1128.505652698389m, 67 },
                    { 68, 3, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1020.0214857460231m, 68 },
                    { 69, 1, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 992.146502523199m, 69 },
                    { 70, 9, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1070.959495999797m, 70 },
                    { 71, 1, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1215.102823276366m, 71 },
                    { 72, 9, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1054.162797416324m, 72 },
                    { 73, 2, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1025.480684419695m, 73 },
                    { 74, 8, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1169.225150761872m, 74 },
                    { 75, 8, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1184.13309086346m, 75 },
                    { 76, 8, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1264.734051913307m, 76 },
                    { 77, 5, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.500009058716m, 77 },
                    { 78, 2, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1028.7302212428438m, 78 },
                    { 79, 8, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1067.694605437355m, 79 },
                    { 80, 8, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 983.963804053079m, 80 },
                    { 81, 1, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1143.909198744676m, 81 },
                    { 82, 4, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1131.959491710234m, 82 },
                    { 83, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1071.74017187664m, 83 },
                    { 84, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 990.6243268158503m, 84 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 85, 9, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1043.2126057110251m, 85 },
                    { 86, 6, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1143.966055086971m, 86 },
                    { 87, 7, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1084.045752420563m, 87 },
                    { 88, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1285.23256338426m, 88 },
                    { 89, 1, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1097.838927809937m, 89 },
                    { 90, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1193.055173865956m, 90 },
                    { 91, 7, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1062.628200805399m, 91 },
                    { 92, 5, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1135.649720638378m, 92 },
                    { 93, 5, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1175.735722584187m, 93 },
                    { 94, 8, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1194.883930022676m, 94 },
                    { 95, 7, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1137.792936735488m, 95 },
                    { 96, 5, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1120.02829875555m, 96 },
                    { 97, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1102.049483245514m, 97 },
                    { 98, 1, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1287.132647871836m, 98 },
                    { 99, 6, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1027.6005972533651m, 99 },
                    { 100, 8, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 978.3382561864743m, 100 },
                    { 101, 2, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 964.8797315149445m, 101 },
                    { 102, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1198.322494182475m, 102 },
                    { 103, 2, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1111.03683673986m, 103 },
                    { 104, 10, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1047.6613369099808m, 104 },
                    { 105, 5, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1211.028819609892m, 105 },
                    { 106, 6, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1214.19171939594m, 106 },
                    { 107, 6, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1042.5596196829259m, 107 },
                    { 108, 2, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1298.41455887618m, 108 },
                    { 109, 7, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1293.710954311737m, 109 },
                    { 110, 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1062.45131811617m, 110 },
                    { 111, 5, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1018.4635639639109m, 111 },
                    { 112, 9, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1041.6012234529616m, 112 },
                    { 113, 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1205.774180139591m, 113 },
                    { 114, 6, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1202.415581644719m, 114 },
                    { 115, 7, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1032.5207214954448m, 115 },
                    { 116, 7, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1185.690227578064m, 116 },
                    { 117, 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1052.067427389166m, 117 },
                    { 118, 9, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1275.205927775229m, 118 },
                    { 119, 9, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1085.579133762056m, 119 },
                    { 120, 6, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1080.851231519476m, 120 },
                    { 121, 10, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1054.859741167326m, 121 },
                    { 122, 2, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 960.5516822746652m, 122 },
                    { 123, 9, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1259.913341306763m, 123 },
                    { 124, 7, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1299.745320628817m, 124 },
                    { 125, 7, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 960.5025779954056m, 125 },
                    { 126, 7, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1195.663222633374m, 126 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 127, 7, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1041.1573684590076m, 127 },
                    { 128, 5, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1195.516209219596m, 128 },
                    { 129, 1, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1295.48888557056m, 129 },
                    { 130, 1, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1178.232628302166m, 130 },
                    { 131, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 963.4007707557917m, 131 },
                    { 132, 4, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1114.244850480879m, 132 },
                    { 133, 10, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1014.0400350040688m, 133 },
                    { 134, 1, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1147.632540051352m, 134 },
                    { 135, 8, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1279.205337648559m, 135 },
                    { 136, 7, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 986.5173231320483m, 136 },
                    { 137, 9, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1158.937627032796m, 137 },
                    { 138, 8, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1034.1307861039326m, 138 },
                    { 139, 1, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1205.048376555095m, 139 },
                    { 140, 1, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1036.9962464935019m, 140 },
                    { 141, 7, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 990.5609349727987m, 141 },
                    { 142, 2, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1123.497079434412m, 142 },
                    { 143, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1109.827564325953m, 143 },
                    { 144, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 970.770534617803m, 144 },
                    { 145, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1146.107590955839m, 145 },
                    { 146, 1, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1200.021361326422m, 146 },
                    { 147, 2, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1251.22908447839m, 147 },
                    { 148, 10, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1102.658348582698m, 148 },
                    { 149, 8, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1218.15557814698m, 149 },
                    { 150, 2, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 957.42390520228154m, 150 },
                    { 151, 9, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1053.939185562721m, 151 },
                    { 152, 8, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1255.742504369827m, 152 },
                    { 153, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1215.409402174502m, 153 },
                    { 154, 7, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1171.288772793965m, 154 },
                    { 155, 8, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1228.307418149093m, 155 },
                    { 156, 2, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1139.204223811366m, 156 },
                    { 157, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1056.206359393645m, 157 },
                    { 158, 6, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1185.712882664834m, 158 },
                    { 159, 7, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1261.750352528488m, 159 },
                    { 160, 10, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1105.817212998379m, 160 },
                    { 161, 8, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1143.553238654286m, 161 },
                    { 162, 9, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1196.130000754335m, 162 },
                    { 163, 7, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 990.6777733361417m, 163 },
                    { 164, 8, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1289.453978528158m, 164 },
                    { 165, 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1004.6111503943635m, 165 },
                    { 166, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1293.572806041438m, 166 },
                    { 167, 10, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1274.299611851474m, 167 },
                    { 168, 5, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1107.98110634063m, 168 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 169, 9, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1043.8206776505862m, 169 },
                    { 170, 2, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1161.585706296773m, 170 },
                    { 171, 7, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1086.718610516538m, 171 },
                    { 172, 2, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1014.3523648712701m, 172 },
                    { 173, 8, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1039.0859553522001m, 173 },
                    { 174, 6, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 988.1042846738865m, 174 },
                    { 175, 5, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1070.302984354381m, 175 },
                    { 176, 1, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1163.963461859595m, 176 },
                    { 177, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1002.6275222349103m, 177 },
                    { 178, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1055.607005618721m, 178 },
                    { 179, 5, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1049.0012171394227m, 179 },
                    { 180, 7, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1244.678397571319m, 180 },
                    { 181, 1, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1187.441737897263m, 181 },
                    { 182, 5, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1200.360658270149m, 182 },
                    { 183, 9, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1018.8048248608014m, 183 },
                    { 184, 10, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1121.092637291392m, 184 },
                    { 185, 2, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1197.956111636345m, 185 },
                    { 186, 6, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1152.588651068952m, 186 },
                    { 187, 7, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1098.423456810553m, 187 },
                    { 188, 1, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1097.599351858359m, 188 },
                    { 189, 4, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1202.000289707539m, 189 },
                    { 190, 5, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1261.262989131869m, 190 },
                    { 191, 5, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1205.53015525359m, 191 },
                    { 192, 5, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1087.328202172321m, 192 },
                    { 193, 10, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1224.607405057855m, 193 },
                    { 194, 7, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 961.6409363592247m, 194 },
                    { 195, 4, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1219.61137774795m, 195 },
                    { 196, 7, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1089.885623447816m, 196 },
                    { 197, 5, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1204.719082123878m, 197 },
                    { 198, 6, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1169.676662306416m, 198 },
                    { 199, 8, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1262.605468821618m, 199 },
                    { 200, 10, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.698758601204m, 200 },
                    { 201, 1, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1234.793303663648m, 201 },
                    { 202, 4, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1249.278580084279m, 202 },
                    { 203, 6, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1109.936221312035m, 203 },
                    { 204, 1, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1259.318179602665m, 204 },
                    { 205, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 956.59686788218243m, 205 },
                    { 206, 7, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1276.52859324009m, 206 },
                    { 207, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1221.60116486449m, 207 },
                    { 208, 8, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1285.816129898139m, 208 },
                    { 209, 9, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1085.712983949761m, 209 },
                    { 210, 1, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1160.460854105944m, 210 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 211, 1, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1218.247528646969m, 211 },
                    { 212, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1293.656958523449m, 212 },
                    { 213, 8, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1282.16305502009m, 213 },
                    { 214, 6, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1062.018896373913m, 214 },
                    { 215, 10, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1093.054706536259m, 215 },
                    { 216, 6, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1018.6438867595445m, 216 },
                    { 217, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 990.7989935764766m, 217 },
                    { 218, 7, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1240.073310709623m, 218 },
                    { 219, 9, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1143.92758015137m, 219 },
                    { 220, 10, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1066.913991720268m, 220 },
                    { 221, 5, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1192.83397425454m, 221 },
                    { 222, 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 991.0060546857936m, 222 },
                    { 223, 9, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1271.52455657401m, 223 },
                    { 224, 6, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1294.649833924975m, 224 },
                    { 225, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 952.51095566112595m, 225 },
                    { 226, 5, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1244.875778575246m, 226 },
                    { 227, 5, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 986.4780473001931m, 227 },
                    { 228, 7, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1085.866034621518m, 228 },
                    { 229, 1, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 988.92700060465m, 229 },
                    { 230, 2, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1094.813109907969m, 230 },
                    { 231, 10, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1078.790332373873m, 231 },
                    { 232, 2, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1195.639253985224m, 232 },
                    { 233, 4, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 997.5899148676944m, 233 },
                    { 234, 1, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1149.922439103549m, 234 },
                    { 235, 5, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1241.285648076415m, 235 },
                    { 236, 6, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1281.93287542386m, 236 },
                    { 237, 8, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1001.1161645319639m, 237 },
                    { 238, 7, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1075.338733289768m, 238 },
                    { 239, 2, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1012.3075596738141m, 239 },
                    { 240, 9, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1009.463460681865m, 240 },
                    { 241, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1050.224235172628m, 241 },
                    { 242, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 980.6887213184343m, 242 },
                    { 243, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1286.016428948044m, 243 },
                    { 244, 10, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1044.0228096765768m, 244 },
                    { 245, 9, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1144.640584826402m, 245 },
                    { 246, 5, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1123.979277848189m, 246 },
                    { 247, 6, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1182.97190989123m, 247 },
                    { 248, 10, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1019.8982988975744m, 248 },
                    { 249, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1295.458970095353m, 249 },
                    { 250, 10, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1254.419585104083m, 250 },
                    { 251, 10, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1062.264747871904m, 251 },
                    { 252, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 973.4204596648408m, 252 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 253, 10, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1279.521877012876m, 253 },
                    { 254, 8, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1180.327385018812m, 254 },
                    { 255, 2, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1128.41367581153m, 255 },
                    { 256, 1, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1143.522777481855m, 256 },
                    { 257, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1126.349021400292m, 257 },
                    { 258, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1276.195461094547m, 258 },
                    { 259, 5, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 976.7071130528367m, 259 },
                    { 260, 10, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1171.246090955957m, 260 },
                    { 261, 8, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1142.866223697025m, 261 },
                    { 262, 2, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 971.7838476722782m, 262 },
                    { 263, 6, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1144.175174222249m, 263 },
                    { 264, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 964.8235539864467m, 264 },
                    { 265, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1009.1527941371193m, 265 },
                    { 266, 8, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1180.072193798104m, 266 },
                    { 267, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.487055709125m, 267 },
                    { 268, 10, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1114.939045339199m, 268 },
                    { 269, 10, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1266.636620763075m, 269 },
                    { 270, 7, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1000.1756777790138m, 270 },
                    { 271, 1, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1254.885138212924m, 271 },
                    { 272, 2, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1224.641116694452m, 272 },
                    { 273, 5, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1085.89921090633m, 273 },
                    { 274, 9, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1090.907203335382m, 274 },
                    { 275, 8, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1209.929713738577m, 275 },
                    { 276, 9, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 989.0790905041119m, 276 },
                    { 277, 7, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1101.831867441623m, 277 },
                    { 278, 6, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 951.46762107715785m, 278 },
                    { 279, 9, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1278.73394867293m, 279 },
                    { 280, 7, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1149.461846682253m, 280 },
                    { 281, 9, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1276.56019608893m, 281 },
                    { 282, 6, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1079.48104478502m, 282 },
                    { 283, 8, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1035.1666051526166m, 283 },
                    { 284, 3, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1005.5557299716936m, 284 },
                    { 285, 2, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1151.755623664854m, 285 },
                    { 286, 6, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1117.754145965978m, 286 },
                    { 287, 7, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1283.692660771859m, 287 },
                    { 288, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 955.50552421480424m, 288 },
                    { 289, 10, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1091.726604053352m, 289 },
                    { 290, 1, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1122.473680246884m, 290 },
                    { 291, 2, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1222.147537403741m, 291 },
                    { 292, 10, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 990.1999951256718m, 292 },
                    { 293, 3, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1291.157199178636m, 293 },
                    { 294, 7, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1076.237756982238m, 294 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 295, 7, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1017.3572422027232m, 295 },
                    { 296, 4, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1216.25126609218m, 296 },
                    { 297, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1227.849607100797m, 297 },
                    { 298, 8, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1072.178964410206m, 298 },
                    { 299, 7, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1212.918860468009m, 299 },
                    { 300, 1, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1148.575655785842m, 300 },
                    { 301, 5, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1041.0261978473506m, 301 },
                    { 302, 10, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1215.183852612118m, 302 },
                    { 303, 8, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1024.2159900487738m, 303 },
                    { 304, 8, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1124.6461802399m, 304 },
                    { 305, 2, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1114.980151342274m, 305 },
                    { 306, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1139.506632800023m, 306 },
                    { 307, 7, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1130.348256901332m, 307 },
                    { 308, 10, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1233.18440646869m, 308 },
                    { 309, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1249.462203670131m, 309 },
                    { 310, 5, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1154.147673199219m, 310 },
                    { 311, 8, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1088.747549179189m, 311 },
                    { 312, 6, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 968.7126694325272m, 312 },
                    { 313, 9, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 983.374565971706m, 313 },
                    { 314, 8, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1026.9540773587792m, 314 },
                    { 315, 8, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1121.275824480938m, 315 },
                    { 316, 1, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1088.305634510039m, 316 },
                    { 317, 6, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1080.32423737501m, 317 },
                    { 318, 9, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1071.853749359552m, 318 },
                    { 319, 2, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1078.429388077114m, 319 },
                    { 320, 6, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1113.928031430455m, 320 },
                    { 321, 5, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 987.5018604814088m, 321 },
                    { 322, 2, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1100.910638241113m, 322 },
                    { 323, 10, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1138.94593929375m, 323 },
                    { 324, 10, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1221.412310359772m, 324 },
                    { 325, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1144.299152712039m, 325 },
                    { 326, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1190.179050621972m, 326 },
                    { 327, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1238.96617400877m, 327 },
                    { 328, 6, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1286.783970052408m, 328 },
                    { 329, 6, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1109.785299491336m, 329 },
                    { 330, 9, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1018.6650690534115m, 330 },
                    { 331, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1050.046283774674m, 331 },
                    { 332, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1259.081291566179m, 332 },
                    { 333, 7, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1191.149244984715m, 333 },
                    { 334, 2, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1254.036188385441m, 334 },
                    { 335, 8, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1157.483655069582m, 335 },
                    { 336, 10, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1140.121395013921m, 336 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 337, 2, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 986.8535976125943m, 337 },
                    { 338, 9, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1023.5207852495441m, 338 },
                    { 339, 1, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 972.8134393390322m, 339 },
                    { 340, 7, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 956.47018235899324m, 340 },
                    { 341, 9, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 987.0243133924992m, 341 },
                    { 342, 8, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1185.30213639264m, 342 },
                    { 343, 9, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 978.5266343636428m, 343 },
                    { 344, 6, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1286.602413031804m, 344 },
                    { 345, 8, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1100.607491775949m, 345 },
                    { 346, 9, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 959.4125608716936m, 346 },
                    { 347, 5, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1024.3630207770244m, 347 },
                    { 348, 2, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1176.329450427199m, 348 },
                    { 349, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1012.956376351056m, 349 },
                    { 350, 8, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1224.620018852559m, 350 },
                    { 351, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1098.472555235778m, 351 },
                    { 352, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1028.7025696741622m, 352 },
                    { 353, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1043.9126723650462m, 353 },
                    { 354, 10, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1045.8154361009619m, 354 },
                    { 355, 8, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1279.611573079006m, 355 },
                    { 356, 1, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1129.066110964464m, 356 },
                    { 357, 10, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1094.363148387551m, 357 },
                    { 358, 9, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1069.742365205976m, 358 },
                    { 359, 7, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 951.03198959772965m, 359 },
                    { 360, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 979.8034365651769m, 360 },
                    { 361, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1212.07468576355m, 361 },
                    { 362, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1291.966033295695m, 362 },
                    { 363, 3, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1215.411992640236m, 363 },
                    { 364, 6, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1135.590512170347m, 364 },
                    { 365, 9, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1133.009820585728m, 365 },
                    { 366, 1, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1037.8060431145833m, 366 },
                    { 367, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1104.716804342559m, 367 },
                    { 368, 6, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1226.407453898366m, 368 },
                    { 369, 7, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1035.023702414175m, 369 },
                    { 370, 5, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1270.49362174176m, 370 },
                    { 371, 8, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1118.990115228433m, 371 },
                    { 372, 9, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1085.080772106163m, 372 },
                    { 373, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 956.61618151078187m, 373 },
                    { 374, 10, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1202.06154796655m, 374 },
                    { 375, 10, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1010.0759404597289m, 375 },
                    { 376, 2, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1091.554708325127m, 376 },
                    { 377, 9, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1065.257783680418m, 377 },
                    { 378, 9, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1116.179375647176m, 378 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 379, 9, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1297.027460712012m, 379 },
                    { 380, 7, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1125.018108304007m, 380 },
                    { 381, 2, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1047.5946800225226m, 381 },
                    { 382, 8, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 964.281937342723m, 382 },
                    { 383, 7, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1257.097141424021m, 383 },
                    { 384, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1195.034713767486m, 384 },
                    { 385, 5, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1209.28903356091m, 385 },
                    { 386, 10, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1030.0421095071276m, 386 },
                    { 387, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1082.530977694184m, 387 },
                    { 388, 1, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 995.7342482093875m, 388 },
                    { 389, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1102.957526873378m, 389 },
                    { 390, 1, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1154.499423692911m, 390 },
                    { 391, 2, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1138.0068035445m, 391 },
                    { 392, 10, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1228.22701330432m, 392 },
                    { 393, 10, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1064.810265903957m, 393 },
                    { 394, 9, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 990.6545872953741m, 394 },
                    { 395, 10, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1144.298557554236m, 395 },
                    { 396, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1205.32192583028m, 396 },
                    { 397, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 988.4116695672467m, 397 },
                    { 398, 8, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1260.802143841133m, 398 },
                    { 399, 6, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1020.8102824757498m, 399 },
                    { 400, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1049.1115492655899m, 400 },
                    { 401, 1, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 994.9151554274367m, 401 },
                    { 402, 5, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1184.342913486861m, 402 },
                    { 403, 8, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1197.605735926532m, 403 },
                    { 404, 1, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1143.804875826408m, 404 },
                    { 405, 1, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1058.28050003615m, 405 },
                    { 406, 6, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1061.148392472013m, 406 },
                    { 407, 7, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1105.969707849672m, 407 },
                    { 408, 7, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1220.95517820247m, 408 },
                    { 409, 6, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1160.994569156258m, 409 },
                    { 410, 10, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1064.706777604464m, 410 },
                    { 411, 7, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 980.872146029307m, 411 },
                    { 412, 9, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1021.288492384883m, 412 },
                    { 413, 1, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1278.77511406295m, 413 },
                    { 414, 6, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1135.920548944085m, 414 },
                    { 415, 1, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1294.011548290243m, 415 },
                    { 416, 6, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1155.137701566287m, 416 },
                    { 417, 5, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1106.857253248806m, 417 },
                    { 418, 2, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1287.357187052604m, 418 },
                    { 419, 5, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1298.915710256131m, 419 },
                    { 420, 6, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1257.08739319281m, 420 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 421, 2, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1017.5664684383661m, 421 },
                    { 422, 8, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1255.569135196258m, 422 },
                    { 423, 6, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 960.0890100879267m, 423 },
                    { 424, 6, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1066.886598700788m, 424 },
                    { 425, 2, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.041918718846m, 425 },
                    { 426, 10, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1175.866874820973m, 426 },
                    { 427, 6, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.566526022703m, 427 },
                    { 428, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1051.023600487773m, 428 },
                    { 429, 5, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1166.389640610916m, 429 },
                    { 430, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1110.920905926874m, 430 },
                    { 431, 1, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1198.064531434642m, 431 },
                    { 432, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1128.963041281305m, 432 },
                    { 433, 7, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1229.744906890659m, 433 },
                    { 434, 7, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1000.1882296179675m, 434 },
                    { 435, 8, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1097.762138811052m, 435 },
                    { 436, 4, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1035.7788544610762m, 436 },
                    { 437, 1, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 994.3037397754975m, 437 },
                    { 438, 10, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1125.829118988066m, 438 },
                    { 439, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1101.549949323947m, 439 },
                    { 440, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1153.934647707209m, 440 },
                    { 441, 10, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1274.195837853429m, 441 },
                    { 442, 7, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1055.266792617288m, 442 },
                    { 443, 2, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1155.841153338002m, 443 },
                    { 444, 8, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 954.63030754242716m, 444 },
                    { 445, 10, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1007.5735758394274m, 445 },
                    { 446, 1, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 968.7424953262895m, 446 },
                    { 447, 10, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 979.6548026728568m, 447 },
                    { 448, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1059.784577848437m, 448 },
                    { 449, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1217.819940150297m, 449 },
                    { 450, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1256.227371303195m, 450 },
                    { 451, 2, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1017.4115996704309m, 451 },
                    { 452, 1, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 975.0016771713329m, 452 },
                    { 453, 7, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1100.625949380667m, 453 },
                    { 454, 5, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1027.2711404614478m, 454 },
                    { 455, 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1165.81996919827m, 455 },
                    { 456, 7, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1077.896215371015m, 456 },
                    { 457, 8, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1109.737512106765m, 457 },
                    { 458, 10, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1089.265711051691m, 458 },
                    { 459, 9, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1142.878200200529m, 459 },
                    { 460, 5, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1266.545169752277m, 460 },
                    { 461, 6, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1139.407555916509m, 461 },
                    { 462, 2, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1078.055675210473m, 462 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 463, 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 978.3184967850636m, 463 },
                    { 464, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1267.058891117702m, 464 },
                    { 465, 1, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1108.711199373654m, 465 },
                    { 466, 1, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 967.2082138066216m, 466 },
                    { 467, 6, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1024.253731359541m, 467 },
                    { 468, 2, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1050.863817254306m, 468 },
                    { 469, 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 975.628100801063m, 469 },
                    { 470, 10, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1281.597075831961m, 470 },
                    { 471, 1, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1179.240495789327m, 471 },
                    { 472, 8, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1237.491223185246m, 472 },
                    { 473, 1, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1013.6111446750444m, 473 },
                    { 474, 5, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1177.659522325915m, 474 },
                    { 475, 9, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 977.9528110069084m, 475 },
                    { 476, 5, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1225.585047954426m, 476 },
                    { 477, 1, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1045.3112141689877m, 477 },
                    { 478, 5, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1125.886500581289m, 478 },
                    { 479, 1, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1226.104454756016m, 479 },
                    { 480, 9, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1068.456525726452m, 480 },
                    { 481, 1, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1246.03161092709m, 481 },
                    { 482, 1, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.515459257561m, 482 },
                    { 483, 1, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1290.147813823026m, 483 },
                    { 484, 1, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1028.8073980786191m, 484 },
                    { 485, 9, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1264.217689481587m, 485 },
                    { 486, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1268.085954921406m, 486 },
                    { 487, 8, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1232.819994388808m, 487 },
                    { 488, 8, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1026.9860517230158m, 488 },
                    { 489, 9, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1293.164915399876m, 489 },
                    { 490, 5, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1079.94626580782m, 490 },
                    { 491, 5, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1271.596043888642m, 491 },
                    { 492, 9, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1061.484305815654m, 492 },
                    { 493, 8, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 995.2217379288588m, 493 },
                    { 494, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1254.316705430156m, 494 },
                    { 495, 8, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1264.809738458755m, 495 },
                    { 496, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1290.250402059921m, 496 },
                    { 497, 2, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1180.386019703103m, 497 },
                    { 498, 9, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1055.050897783482m, 498 },
                    { 499, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1050.226507265605m, 499 },
                    { 500, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1147.936257335719m, 500 },
                    { 501, 9, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1261.923777009979m, 501 },
                    { 502, 5, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1175.959983783956m, 502 },
                    { 503, 8, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1080.318573797743m, 503 },
                    { 504, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1121.896109680759m, 504 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 505, 8, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1095.972182861315m, 505 },
                    { 506, 5, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1182.093997559441m, 506 },
                    { 507, 1, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 972.4877834529418m, 507 },
                    { 508, 5, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 984.9885159720361m, 508 },
                    { 509, 2, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1265.568193640373m, 509 },
                    { 510, 2, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 984.1218373706997m, 510 },
                    { 511, 3, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 951.23464804299223m, 511 },
                    { 512, 1, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1035.665746357166m, 512 },
                    { 513, 7, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1010.5667924338164m, 513 },
                    { 514, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1005.7422454124955m, 514 },
                    { 515, 9, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1291.113002740159m, 515 },
                    { 516, 10, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1001.396260144811m, 516 },
                    { 517, 6, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1276.936006319802m, 517 },
                    { 518, 6, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1034.289593242972m, 518 },
                    { 519, 10, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1264.167238971676m, 519 },
                    { 520, 9, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1111.66226858203m, 520 },
                    { 521, 8, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1289.229899086286m, 521 },
                    { 522, 1, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1188.268214014007m, 522 },
                    { 523, 5, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 973.9319706211135m, 523 },
                    { 524, 6, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1014.8899669003115m, 524 },
                    { 525, 2, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1103.790788083188m, 525 },
                    { 526, 10, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1165.805146083814m, 526 },
                    { 527, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1126.821934561581m, 527 },
                    { 528, 9, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1249.790425363214m, 528 },
                    { 529, 2, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1065.284495474942m, 529 },
                    { 530, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 964.5200225137233m, 530 },
                    { 531, 2, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1253.607976889557m, 531 },
                    { 532, 1, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1123.25512745411m, 532 },
                    { 533, 7, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1022.3534850554813m, 533 },
                    { 534, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1236.512255018591m, 534 },
                    { 535, 2, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1175.103239274883m, 535 },
                    { 536, 1, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1005.2658408681408m, 536 },
                    { 537, 6, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 980.1638763040743m, 537 },
                    { 538, 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1151.486111174442m, 538 },
                    { 539, 6, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1207.584917871955m, 539 },
                    { 540, 9, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1289.95237074988m, 540 },
                    { 541, 10, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1278.527967935578m, 541 },
                    { 542, 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1149.086841751086m, 542 },
                    { 543, 2, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1009.8542613945702m, 543 },
                    { 544, 5, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1266.290631903401m, 544 },
                    { 545, 5, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1124.700266227346m, 545 },
                    { 546, 1, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1164.060543684571m, 546 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 547, 8, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1230.197348556425m, 547 },
                    { 548, 3, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1022.8128473137371m, 548 },
                    { 549, 10, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1116.525568460708m, 549 },
                    { 550, 10, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 987.9179960845276m, 550 },
                    { 551, 9, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1000.135133366639m, 551 },
                    { 552, 6, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1262.932858249285m, 552 },
                    { 553, 9, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1081.091726536674m, 553 },
                    { 554, 2, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 974.209066581506m, 554 },
                    { 555, 7, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 976.3697763079622m, 555 },
                    { 556, 7, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1176.602040178815m, 556 },
                    { 557, 1, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1196.357180287824m, 557 },
                    { 558, 8, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1139.989414922549m, 558 },
                    { 559, 6, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1003.3113577360513m, 559 },
                    { 560, 5, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1001.7385766716214m, 560 },
                    { 561, 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1137.692305047323m, 561 },
                    { 562, 4, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1214.84956393m, 562 },
                    { 563, 10, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1011.1968142017938m, 563 },
                    { 564, 10, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1261.123536651351m, 564 },
                    { 565, 6, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1280.919854840618m, 565 },
                    { 566, 8, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1029.1792571152745m, 566 },
                    { 567, 10, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1213.559759600773m, 567 },
                    { 568, 1, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 974.8714634622212m, 568 },
                    { 569, 8, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1229.108275308531m, 569 },
                    { 570, 1, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1206.840488280496m, 570 },
                    { 571, 2, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1293.442556255246m, 571 },
                    { 572, 3, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 970.2304098983088m, 572 },
                    { 573, 2, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1192.788387482198m, 573 },
                    { 574, 8, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1186.650223170557m, 574 },
                    { 575, 6, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1120.081283049655m, 575 },
                    { 576, 8, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1182.282129968916m, 576 },
                    { 577, 3, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 994.5184118764341m, 577 },
                    { 578, 1, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1243.470366597508m, 578 },
                    { 579, 7, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1266.509907670593m, 579 },
                    { 580, 1, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1166.134285262935m, 580 },
                    { 581, 10, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1258.207856244679m, 581 },
                    { 582, 6, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1125.8574086632m, 582 },
                    { 583, 3, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1231.497067898294m, 583 },
                    { 584, 1, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1210.412247898347m, 584 },
                    { 585, 5, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1047.3168712058315m, 585 },
                    { 586, 1, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 965.6788312087283m, 586 },
                    { 587, 8, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1078.715776773878m, 587 },
                    { 588, 9, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1015.6951781071662m, 588 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 589, 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 995.7100027864318m, 589 },
                    { 590, 2, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1135.223324900313m, 590 },
                    { 591, 2, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1056.847436031356m, 591 },
                    { 592, 7, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1145.237479001089m, 592 },
                    { 593, 7, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1036.380012165689m, 593 },
                    { 594, 10, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 950.898875749071099m, 594 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "managerRoleId", "0261d5ca-050a-423e-90cb-c7e990f67959" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dispatcherRoleId", "19918df1-9468-434b-aaf9-a3d22b2d12e2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dispatcherRoleId", "62154153-66df-4b35-91ed-56ac983c9a8e" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "TruckExpenses",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0261d5ca-050a-423e-90cb-c7e990f67959");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Tripes",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19918df1-9468-434b-aaf9-a3d22b2d12e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62154153-66df-4b35-91ed-56ac983c9a8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminRoleId",
                column: "ConcurrencyStamp",
                value: "b19f5167-d4c0-48e5-8dc4-9df66bbdfad6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dispatcherRoleId",
                column: "ConcurrencyStamp",
                value: "78ca2928-a9c7-4b81-a6d8-999bec9acf41");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "managerRoleId",
                column: "ConcurrencyStamp",
                value: "121e131b-71f9-41d7-86df-0214e45315aa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0cdad88-d0ca-4b78-88eb-672765f3eb68", "admin@truck.com", "admin@truck.com", "AQAAAAEAACcQAAAAEO2coAmeIdA2qQu0HtNTZaiMKyJ2uAWzhg+P+ovBq7x/fH3kCd2psAMhcq1G1mU0lw==", "e9eb3cbd-1db1-47c2-90c5-85779b5a3718" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "FullName",
                value: "");
        }
    }
}
