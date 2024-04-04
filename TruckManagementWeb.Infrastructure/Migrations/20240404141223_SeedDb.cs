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
                value: "8ca514ae-e677-49b9-8432-5d29f88385a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dispatcherRoleId",
                column: "ConcurrencyStamp",
                value: "e151ef35-5e49-4682-92fb-f4402bad8c9f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "managerRoleId",
                column: "ConcurrencyStamp",
                value: "9d9e60c3-6a10-425f-be94-b2ee0aecc6dc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ea891bd-b9f3-4b2e-9a5e-6395118e3c34", "ADMIN@TRUCK.COM", "ADMIN@TRUCK.COM", "AQAAAAEAACcQAAAAEHoACDXsrvjho3KIJbkQtHcvDPi+G4Ft+5vWIa8etkJ0xPQOWPN1uO9AgDLXzLu6HA==", "45c3bf14-5c8e-4fad-b3a3-1c48d18193ae" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserEmail", "UserName" },
                values: new object[,]
                {
                    { "0261d5ca-050a-423e-90cb-c7e990f67959", 0, "b4926567-d067-4ec0-be22-eabce7538964", "manager@truck.com", false, false, null, "MANAGER@TRUCK.COM", "MANAGER@TRUCK.COM", "AQAAAAEAACcQAAAAECj/p2BcLiN3Hj4aB3Ao4iFMWnb3Fqab2JYt1FAr5Kq9PdFFNswCfOJ77RDTf/RbQw==", null, false, "67fe7052-61f9-4ba8-b64b-8da483541e89", false, "", "manager@truck.com" },
                    { "19918df1-9468-434b-aaf9-a3d22b2d12e2", 0, "0d0b62ac-ebf8-44a2-8ddf-0d2491080299", "dispo2@truck.com", false, false, null, "DISPO2@TRUCK.COM", "DISPO2@TRUCK.COM", "AQAAAAEAACcQAAAAEPHLEomh4CkhMbn78yTvNfh+EkjoYAoG2v0QrSUkbMbLiM7k4RARhc5uKaNrvpNS8A==", null, false, "8b54e4fe-b0a1-4471-aeb4-378910f5c94f", false, "", "dispo2@truck.com" },
                    { "62154153-66df-4b35-91ed-56ac983c9a8e", 0, "b3e727b6-7d77-4ddd-af89-2b531a7ad549", "dispo1@truck.com", false, false, null, "DISPO1@TRUCK.COM", "DISPO1@TRUCK.COM", "AQAAAAEAACcQAAAAELvfGb8ZQZgJBq/Z6pW+pQhs6Z9RuN21B2W/Llj20OBAIoGhgiG3wmRY1S8k5MaTbQ==", null, false, "33d221ab-c196-45df-b45e-b5fdebfd321c", false, "", "dispo1@truck.com" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AddedDate", "CompanyAddress", "CompanyCountry", "CompanyName", "CompanyTown", "CompanyVat", "IsActive", "RemovedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "17 RUE BOBBY SANDS", "France", "MALHERBE DISTRIBUTION", "44813 ST-HERBLAIN CEDEX", "FR72518435920", true, null },
                    { 2, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "ROUTE DE SCHWEIGEN BP 10025", "France", "WOEHL & CIE - TPT INTERNATIONAUX", "67160 WISSEMBOURG", "FR37558501144", true, null },
                    { 3, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "144 ZAE WOLSER", "Luxembourg", "XPO TRS LU", "3225 BETTEMBOURG", "LU17458960", true, null },
                    { 4, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "2609 AVENUE DE PRADES", "France", "GEFCO FRANCE", "66000 PERPIGNAN", "FR24789791464", true, null },
                    { 5, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "69 Route de Thionville", "France", "Yusen Logistics (France) SAS", "57280 Maizières-lès-Metz", "FR89432599785", true, null },
                    { 6, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "JUSTUS LIEBIG STRASSE 14", "Germany", "SCHENKER DEUTSCHLAND AG", "34253 LOHFELDEN/KASSEL", "DE811228366", true, null },
                    { 7, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Brinkhofstraße 41", "Germany", "Winner Spedition GmbH & Co. KG", "58642 Iserlohn", "DE125572634", true, null },
                    { 8, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Genthiner Strasse 34", "Germany", "sennder Technologies GmbH", "10785 Berlin", "DE302502945", true, null },
                    { 9, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Otto-Hahn-Str. 3", "Germany", "Stahl Log", "D-66793 Saarwellingen", "DE813065962", true, null },
                    { 10, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "RUE DES VERGERS", "France", "GREILSAMMER ABCE", "F - 68600 WOLFGANTZEN", "FR06514447937", true, null }
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
                    { 1, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 195000, "Renault Trucks T High", "B8511TC" },
                    { 2, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 198000, "Renault Trucks T High", "B8514TC" },
                    { 3, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 201500, "Renault Trucks T High", "B8517TC" },
                    { 4, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 205000, "Renault Trucks T High", "B9133TC" },
                    { 5, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 210000, "Renault Trucks T High", "B9134TC" },
                    { 6, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 230500, "Renault Trucks T High", "B9135TC" }
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
                    { 1, 4, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7261470277787921686746987952m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 1146.161626445118m, 1 },
                    { 2, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6284870192938487031700288184m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, 1130.169991389931m, 2 },
                    { 3, 4, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9766364494257511442786069652m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1005, 981.5196316728799m, 3 },
                    { 4, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1642903342025915768854064643m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1021, 1188.740431220846m, 4 },
                    { 5, 4, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1869704699539837133550488599m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 921, 1093.199802827619m, 5 },
                    { 6, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1326562009520685959271168274m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 933, 1056.76823548828m, 6 },
                    { 7, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6729513495815837765957446809m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 752, 1258.059414885351m, 1 },
                    { 8, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3652168996100324675324675325m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 770, 1051.217012699725m, 2 },
                    { 9, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0931549437687589641434262948m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1004, 1097.527563543834m, 3 },
                    { 10, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6100749464717841530054644809m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 732, 1178.574860817346m, 4 },
                    { 11, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5003146927919137724550898204m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 835, 1252.762768481248m, 5 },
                    { 12, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1104945857615245901639344262m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 976, 1083.842715703248m, 6 },
                    { 13, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.614997794072529500756429652m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 661, 1067.513541881942m, 1 },
                    { 14, 3, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1429024490783428571428571429m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1050, 1200.04757153226m, 2 },
                    { 15, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9216613526975037147102526003m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 673, 1293.27809036542m, 3 },
                    { 16, 3, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3993744368114348703170028818m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, 971.1658591471358m, 4 },
                    { 17, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3860419545700722433460076046m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 789, 1093.587102155787m, 5 },
                    { 18, 3, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0729997700821498419388830348m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 949, 1018.2767818079602m, 6 },
                    { 19, 4, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5629298526507454764776839566m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 829, 1295.668847847468m, 1 },
                    { 20, 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2251202226662819767441860465m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1032, 1264.324069791603m, 2 },
                    { 21, 4, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1017388060599723643807574207m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 977, 1076.398813520593m, 3 },
                    { 22, 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5699557768553171052631578947m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 760, 1193.166390410041m, 4 },
                    { 23, 4, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1501033991176576834862385321m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 872, 1002.8901640305975m, 5 },
                    { 24, 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3406416208329887741935483871m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 775, 1038.9972561455663m, 6 },
                    { 25, 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3395281474510709046454767726m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 818, 1095.734024614976m, 1 },
                    { 26, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1428544321004045064377682403m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 932, 1065.140330717577m, 2 },
                    { 27, 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4805602418092755798090040928m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 733, 1085.250657246199m, 3 },
                    { 28, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6136568501726524615384615385m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 650, 1048.8769526122241m, 4 },
                    { 29, 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3200759623550954994511525796m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 911, 1202.589201705492m, 5 },
                    { 30, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3312345744824494142705005325m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 939, 1250.02926543902m, 6 },
                    { 31, 4, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1781589793967730358874878758m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1031, 1214.681907758073m, 1 },
                    { 32, 3, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.511948783492532994923857868m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 788, 1191.415641392116m, 2 },
                    { 33, 4, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8518720034330214592274678112m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 1294.458530399682m, 3 },
                    { 34, 3, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2188993848360785634118967452m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 891, 1086.039351888946m, 4 },
                    { 35, 4, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2807137092833325301204819277m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 830, 1062.992378705166m, 5 },
                    { 36, 3, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1585549641490046168051708218m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1083, 1254.715026173372m, 6 },
                    { 37, 4, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0514257815998633966244725738m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 948, 996.7516409566705m, 1 },
                    { 38, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5972745930001884272997032641m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 674, 1076.563075682127m, 2 },
                    { 39, 4, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9151132873092931547619047619m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 672, 1286.956129071845m, 3 },
                    { 40, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4308874322487902578796561605m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 698, 998.7594277096556m, 4 },
                    { 41, 4, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4843556927538619252873563218m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 696, 1033.1115621566879m, 5 },
                    { 42, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.429589701810626882966396292m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 863, 1233.735912662571m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 43, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5728916293888252840909090909m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 704, 1107.315707089733m, 1 },
                    { 44, 3, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4244193157944071847507331378m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 682, 971.4539733717857m, 2 },
                    { 45, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9344863587266520302171860246m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1059, 989.6210538915245m, 3 },
                    { 46, 3, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3306884285038632768361581921m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 885, 1177.659259225919m, 4 },
                    { 47, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1714614050511190253045923149m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1067, 1249.949319189544m, 5 },
                    { 48, 3, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4409333613374651711924439197m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 847, 1220.470557052833m, 6 },
                    { 49, 4, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1892430703462113970588235294m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1088, 1293.896460536678m, 1 },
                    { 50, 3, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9990993021860162537165510406m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1009, 1008.0911959056904m, 2 },
                    { 51, 4, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.220032037516806979280261723m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 917, 1118.769378402912m, 3 },
                    { 52, 3, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5733188183253748473748473748m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 819, 1288.548112208482m, 4 },
                    { 53, 4, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7912116160654516129032258065m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 1166.078762058609m, 5 },
                    { 54, 3, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2953309566152667450058754407m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 851, 1102.326644079592m, 6 },
                    { 55, 4, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9761848908858839779005524862m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1086, 1060.13679150207m, 1 },
                    { 56, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4208842379103235625704622322m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 887, 1260.324319026457m, 2 },
                    { 57, 4, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2800244841782213393870601589m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 881, 1127.701570561013m, 3 },
                    { 58, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1678841846592308670520231214m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 865, 1010.2198197302347m, 4 },
                    { 59, 4, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6801293269527611548556430446m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 762, 1280.258547138004m, 5 },
                    { 60, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2294853760342320388349514563m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 824, 1013.0959498522072m, 6 },
                    { 61, 4, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2721007139307512339585389931m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1013, 1288.638023211851m, 1 },
                    { 62, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9580370621436965853658536585m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1025, 981.987988697289m, 2 },
                    { 63, 4, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0888319349284901222953904045m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1063, 1157.428346828985m, 3 },
                    { 64, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4538172383022157330154946365m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 839, 1219.752662935559m, 4 },
                    { 65, 4, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6085763719111898550724637681m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 690, 1109.917696618721m, 5 },
                    { 66, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0444098508304964656964656965m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 962, 1004.7222764989376m, 6 },
                    { 67, 4, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5761522936486168582375478927m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 783, 1234.127245926867m, 1 },
                    { 68, 3, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2387364725940473309608540925m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 843, 1044.2548463967819m, 2 },
                    { 69, 4, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0645935302529173770491803279m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 915, 974.1030801814194m, 3 },
                    { 70, 3, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0104950422872599814298978644m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1077, 1088.303160543379m, 4 },
                    { 71, 4, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5857206929219229671897289586m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 701, 1111.590205738268m, 5 },
                    { 72, 3, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2484430885143509615384615385m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1040, 1298.380812054925m, 6 },
                    { 73, 4, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3709180996240425174825174825m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 715, 980.2064412311904m, 1 },
                    { 74, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1947488132172164705882352941m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 850, 1015.536491234634m, 2 },
                    { 75, 4, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4195666122645819774718397997m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 1134.233723199401m, 3 },
                    { 76, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4419062355012478314745972739m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 807, 1163.618332049507m, 4 },
                    { 77, 4, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6333821098893795336787564767m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 772, 1260.970988834601m, 5 },
                    { 78, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0709447746454629981024667932m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1054, 1128.775792476318m, 6 },
                    { 79, 4, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3095938082169847238542890717m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 851, 1114.464330792654m, 1 },
                    { 80, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2451739961223017817371937639m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 898, 1118.166248517827m, 2 },
                    { 81, 4, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2581884293356524752475247525m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1010, 1270.770313629009m, 3 },
                    { 82, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.157432398914868252516010979m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1093, 1265.073612013951m, 4 },
                    { 83, 4, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2344887368067373540856031128m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1028, 1269.054421437326m, 5 },
                    { 84, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5468888321395470914127423823m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 722, 1116.853736804753m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 85, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4748069565732032710280373832m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 856, 1262.434754826662m, 1 },
                    { 86, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5171576315673167848699763593m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 846, 1283.51535630595m, 2 },
                    { 87, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4028020799134977728285077951m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 898, 1259.716267762321m, 3 },
                    { 88, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2971820281391905882352941176m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 850, 1102.604723918312m, 4 },
                    { 89, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4331987857509901823281907433m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 1021.870734240456m, 5 },
                    { 90, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5276346902466082758620689655m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 725, 1107.535150428791m, 6 },
                    { 91, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5044969178644893867924528302m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 848, 1275.813386349087m, 1 },
                    { 92, 3, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3513394898723727369542066028m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 939, 1268.907780990158m, 2 },
                    { 93, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2382103895675316455696202532m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 948, 1173.82344931002m, 3 },
                    { 94, 3, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8206400845992231638418079096m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 708, 1289.01317989625m, 4 },
                    { 95, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5101972828831267776096822995m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 661, 998.2404039857468m, 5 },
                    { 96, 3, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1342539785768071794871794872m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 975, 1105.897629112387m, 6 },
                    { 97, 4, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1737432318119321100917431193m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 872, 1023.5040981400048m, 1 },
                    { 98, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6486054561082531806615776081m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 786, 1295.803888501087m, 2 },
                    { 99, 4, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1867844966649301289566236811m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 853, 1012.3271756551854m, 3 },
                    { 100, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3191940149565186915887850467m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 856, 1129.23007680278m, 4 },
                    { 101, 4, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.544281114957101063829787234m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 658, 1016.1369736417725m, 5 },
                    { 102, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.066814272542687538304392237m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 979, 1044.4111728192911m, 6 },
                    { 103, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7550531609033885793871866295m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 718, 1260.128169528633m, 1 },
                    { 104, 3, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4606057138421705882352941176m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 850, 1241.514856765845m, 2 },
                    { 105, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6038763095520080106809078772m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 749, 1201.303355854454m, 3 },
                    { 106, 3, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2599730170980169660678642715m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1002, 1262.492963132213m, 4 },
                    { 107, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6173464954314718397997496871m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 1292.259849849746m, 5 },
                    { 108, 3, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2218463909891221052631578947m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 855, 1044.6786642956994m, 6 },
                    { 109, 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4646738168164120734908136483m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 762, 1116.081448414106m, 1 },
                    { 110, 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5843369605813938506588579795m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 683, 1082.102144077092m, 2 },
                    { 111, 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9747305785858854692230070636m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 991, 965.9580033786125m, 3 },
                    { 112, 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7249101956678785425101214575m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 741, 1278.158454989898m, 4 },
                    { 113, 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4936591714852868217054263566m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 774, 1156.092198729612m, 5 },
                    { 114, 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.741493413239318118948824343m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 723, 1259.099737772027m, 6 },
                    { 115, 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0689735723308303212851405622m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 996, 1064.697678041507m, 1 },
                    { 116, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.395634216933930171277997365m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 759, 1059.286370652853m, 2 },
                    { 117, 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.775286750052217201166180758m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 686, 1217.846710535821m, 3 },
                    { 118, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1217388429321092436974789916m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1071, 1201.382300780289m, 4 },
                    { 119, 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3370096476523248847926267281m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 868, 1160.524374162218m, 5 },
                    { 120, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2839760551597885462555066079m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 908, 1165.850258085088m, 6 },
                    { 121, 4, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0021206845761044176285414481m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 953, 955.02101240102751m, 1 },
                    { 122, 3, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.205322637834369914853358562m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1057, 1274.026028190929m, 2 },
                    { 123, 4, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0640662309934897435897435897m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 936, 995.9659922099064m, 3 },
                    { 124, 3, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4897608583202846251588310038m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 787, 1172.441795498064m, 4 },
                    { 125, 4, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3850007247687143454038997214m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 718, 994.4305203839369m, 5 },
                    { 126, 3, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1837236489052876064333017975m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1057, 1251.195896892889m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 127, 4, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2851790236984320276497695853m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 868, 1115.535392570239m, 1 },
                    { 128, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4790194629062582450832072617m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 661, 977.6318649810367m, 2 },
                    { 129, 4, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0605838122681640081799591002m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 978, 1037.2509683982644m, 3 },
                    { 130, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.368118553234552319309600863m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 927, 1268.24589884843m, 4 },
                    { 131, 4, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6271553995139336801040312094m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 769, 1251.282502226215m, 5 },
                    { 132, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2339652198403295099061522419m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 959, 1183.372645826876m, 6 },
                    { 133, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4017859158170011363636363636m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 880, 1233.571605918961m, 1 },
                    { 134, 3, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.99261457976139753125m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 960, 952.90999657094163m, 2 },
                    { 135, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0896402085494134419551934827m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 982, 1070.026684795524m, 3 },
                    { 136, 3, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0500028921663926125137211855m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 911, 956.55263476358367m, 4 },
                    { 137, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2683832673121838216560509554m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 785, 995.6808648400643m, 5 },
                    { 138, 3, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2607459915621563517915309446m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 921, 1161.147058228746m, 6 },
                    { 139, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1484337458454333333333333333m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 990, 1136.949408386979m, 1 },
                    { 140, 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3018793605723468208092485549m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 865, 1126.12564689508m, 2 },
                    { 141, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2694796500294858437146092865m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 883, 1120.950530976036m, 3 },
                    { 142, 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1169073573967102115915363385m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1087, 1214.078297490224m, 4 },
                    { 143, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2530762645411450676982591876m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1034, 1295.680857535544m, 5 },
                    { 144, 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5028472777344330601092896175m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 732, 1100.084207301605m, 6 },
                    { 145, 4, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3313776045740590200445434298m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 898, 1195.577088907505m, 1 },
                    { 146, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.282264384659645021645021645m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 924, 1184.812291425512m, 2 },
                    { 147, 4, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3111448276826908108108108108m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 925, 1212.808965606489m, 3 },
                    { 148, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0601981461831366666666666667m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 990, 1049.5961647213053m, 4 },
                    { 149, 4, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2146507945436420454545454545m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 880, 1068.892699198405m, 5 },
                    { 150, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2737354860360897867564534231m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 891, 1134.898318058156m, 6 },
                    { 151, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7139861060633975576662143826m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 737, 1263.207760168724m, 1 },
                    { 152, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1258273170996296296296296296m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1080, 1215.8935024676m, 2 },
                    { 153, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2785936277895159914712153518m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 938, 1199.320822866566m, 3 },
                    { 154, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3943201968545645333333333333m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 750, 1045.7401476409234m, 4 },
                    { 155, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2658813670613049645390070922m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 846, 1070.935636533864m, 5 },
                    { 156, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1745907617914247422680412371m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 873, 1025.4177350439138m, 6 },
                    { 157, 4, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2876320051635943204868154158m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 986, 1269.605157091304m, 1 },
                    { 158, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1064922101474629812438302073m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1013, 1120.87660887938m, 2 },
                    { 159, 4, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2190650218602118072289156627m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 830, 1011.8239681439758m, 3 },
                    { 160, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1269625231287541899441340782m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1074, 1210.357749840282m, 4 },
                    { 161, 4, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4613530748929986631016042781m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 748, 1093.092100019963m, 5 },
                    { 162, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4917280347223976331360946746m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 845, 1260.510189340426m, 6 },
                    { 163, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2202793728022118872549019608m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 816, 995.7479682066049m, 1 },
                    { 164, 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6675537211633062937062937063m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 715, 1192.300910631764m, 2 },
                    { 165, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3829748133178531289910600255m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 783, 1082.869278827879m, 3 },
                    { 166, 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0841393404236526418786692759m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1022, 1107.990405912973m, 4 },
                    { 167, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8427462821301698956780923994m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 671, 1236.482755309344m, 5 },
                    { 168, 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0891266931122124248496993988m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 998, 1086.948439725988m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 169, 4, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4413433009503594306049822064m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 843, 1215.052402701153m, 1 },
                    { 170, 3, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2723460196199563968668407311m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 766, 974.6170510288866m, 2 },
                    { 171, 4, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.164811892945418848167539267m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 955, 1112.395357762875m, 3 },
                    { 172, 3, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5454886444767490445859872611m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 785, 1213.208585914248m, 4 },
                    { 173, 4, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0731966396041013513513513514m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1036, 1111.831718629849m, 5 },
                    { 174, 3, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.210939606213133261105092091m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 923, 1117.697256534722m, 6 },
                    { 175, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.675500994716574468085106383m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 752, 1259.976748026864m, 1 },
                    { 176, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4698420126010307328605200946m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 846, 1243.486342660472m, 2 },
                    { 177, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0195084209309465968586387435m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 955, 973.630541989054m, 3 },
                    { 178, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1687463710326808905380333952m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1078, 1259.90858797323m, 4 },
                    { 179, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0216193131013206672845227062m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1079, 1102.327238836325m, 5 },
                    { 180, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1719573279553919213973799127m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 916, 1073.512912407139m, 6 },
                    { 181, 4, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1824754502386309195402298851m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 870, 1028.7536417076089m, 1 },
                    { 182, 3, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0079800912130302213666987488m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1039, 1047.2913147703384m, 2 },
                    { 183, 4, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6290422971304005847953216374m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 684, 1114.264931237194m, 3 },
                    { 184, 3, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2662793539129095115681233933m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 778, 985.1653373442436m, 4 },
                    { 185, 4, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3068409521900518218623481781m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 741, 968.3691455728284m, 5 },
                    { 186, 3, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2894161985738565217391304348m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 920, 1186.262902687948m, 6 },
                    { 187, 4, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2994350284542125714285714286m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 875, 1137.005649897436m, 1 },
                    { 188, 3, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6116131486168108448928121059m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 793, 1278.009226853131m, 2 },
                    { 189, 4, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0698858478465741482965931864m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 998, 1067.746076150881m, 3 },
                    { 190, 3, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1482589983430147523709167545m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 949, 1089.697789427521m, 4 },
                    { 191, 4, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0076789582790930278884462151m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1004, 1011.7096741122094m, 5 },
                    { 192, 3, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.100589405759124m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000, 1100.589405759124m, 6 },
                    { 193, 4, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1006479560409012915129151292m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1084, 1193.102384348337m, 1 },
                    { 194, 3, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1265248669691635555555555556m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 900, 1013.8723802722472m, 2 },
                    { 195, 4, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0710897419447399784482758621m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 928, 993.9712805247187m, 3 },
                    { 196, 3, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1563312821601332195676905575m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 879, 1016.4151970187571m, 4 },
                    { 197, 4, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1602997938044478527607361963m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 978, 1134.77319834075m, 5 },
                    { 198, 3, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4437274053341913439635535308m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 878, 1267.59266188342m, 6 },
                    { 199, 4, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4652067339854835443037974684m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 790, 1157.513319848532m, 1 },
                    { 200, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1243931857293361256544502618m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 955, 1073.795492371516m, 2 },
                    { 201, 4, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5416604713862392156862745098m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 765, 1179.370260610473m, 3 },
                    { 202, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2330784823246384839650145773m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1029, 1268.837758312053m, 4 },
                    { 203, 4, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3927336814549855072463768116m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 759, 1057.084864224334m, 5 },
                    { 204, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.487543641100547680412371134m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 776, 1154.333865494025m, 6 },
                    { 205, 4, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6527274786788375838926174497m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 745, 1231.281971615734m, 1 },
                    { 206, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0803465188372358208955223881m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 938, 1013.3650346693272m, 2 },
                    { 207, 4, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4135798379694454148471615721m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 916, 1294.839131580012m, 3 },
                    { 208, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1316922504338077651515151515m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1056, 1195.067016458101m, 4 },
                    { 209, 4, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1178279907970080135440180587m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 886, 990.3955998461491m, 5 },
                    { 210, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2573659919557853932584269663m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 890, 1119.055732840649m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 211, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3854700445237608409986859396m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, 1054.342703882582m, 1 },
                    { 212, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4995184390536585695006747638m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 741, 1111.143163338761m, 2 },
                    { 213, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3425880399775043668122270742m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 916, 1229.810644619394m, 3 },
                    { 214, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3545536217766377564979480164m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 731, 990.1786975187222m, 4 },
                    { 215, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3923475323295354330708661417m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 762, 1060.968819635106m, 5 },
                    { 216, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4038248509664767184035476718m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 902, 1266.250015571762m, 6 },
                    { 217, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2299859283557599620493358634m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1054, 1296.405168486971m, 1 },
                    { 218, 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6169948464481789473684210526m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 665, 1075.301572888039m, 2 },
                    { 219, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9235232706940153609831029186m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 1252.213649221804m, 3 },
                    { 220, 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9447047894449939577039274924m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 662, 1287.394570612586m, 4 },
                    { 221, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2727377188210055126791620728m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 907, 1154.373110970652m, 5 },
                    { 222, 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3238294384325390539053905391m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 909, 1203.360959535178m, 6 },
                    { 223, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2434186188974665924276169265m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 898, 1116.589919769925m, 1 },
                    { 224, 3, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0225591112579460650577124869m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 953, 974.4988330288226m, 2 },
                    { 225, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5020732598281733431516936672m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 679, 1019.9077434233297m, 3 },
                    { 226, 3, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1721955716804713701431492843m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 978, 1146.407269103501m, 4 },
                    { 227, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1313980477919226467847157502m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1073, 1213.990105280733m, 5 },
                    { 228, 3, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7842904945926708683473389356m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 714, 1273.983413139167m, 6 },
                    { 229, 4, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.780614745002179523141654979m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 1269.578313186554m, 1 },
                    { 230, 3, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3384208057272824025289778714m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 949, 1270.161344635191m, 2 },
                    { 231, 4, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.161700607256208253358925144m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1042, 1210.492032760969m, 3 },
                    { 232, 3, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0353909519329513846153846154m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 975, 1009.5061781346276m, 4 },
                    { 233, 4, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3870340533782053167883211679m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 685, 950.118326564070642m, 5 },
                    { 234, 3, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.432392973211805m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 800, 1145.914378569444m, 6 },
                    { 235, 4, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0158619525294604779411764706m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1088, 1105.257804352053m, 1 },
                    { 236, 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3592634527702483262411347518m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 705, 958.28073420302507m, 2 },
                    { 237, 4, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9531148019205087570621468927m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1062, 1012.2079196395803m, 3 },
                    { 238, 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2542421791372692737430167598m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 895, 1122.546750327856m, 4 },
                    { 239, 4, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.115679422717339906103286385m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1065, 1188.198585193967m, 5 },
                    { 240, 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0171505834265323093220338983m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 944, 960.1901507546465m, 6 },
                    { 241, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2563446159511389830508474576m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 885, 1111.864985116758m, 1 },
                    { 242, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3219142261949245867768595041m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 968, 1279.612970956687m, 2 },
                    { 243, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8169523313332687224669603524m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 681, 1237.344537637956m, 3 },
                    { 244, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.010928831027155045871559633m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1090, 1101.912425819599m, 4 },
                    { 245, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4792423083742586705202312139m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 692, 1023.635677394987m, 5 },
                    { 246, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4087278521533354395604395604m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 728, 1025.5538763676282m, 6 },
                    { 247, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5453602429323374149659863946m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 735, 1135.839778555268m, 1 },
                    { 248, 3, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1115678788765554537121906508m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1091, 1212.720555854322m, 2 },
                    { 249, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0190094190030253164556962025m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1027, 1046.522673316107m, 3 },
                    { 250, 3, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2252292072173706365503080082m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 974, 1193.373247829719m, 4 },
                    { 251, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.564803217255886039886039886m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 702, 1098.491858513632m, 5 },
                    { 252, 3, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3431617641207776548672566372m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 904, 1214.218234765183m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 253, 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7447576676394902777777777778m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 720, 1256.225520700433m, 1 },
                    { 254, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.446161818525776m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 875, 1265.391591210054m, 2 },
                    { 255, 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0508781201756790505675954592m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 969, 1018.300898450233m, 3 },
                    { 256, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1082331347770230681818181818m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 880, 975.2451586037803m, 4 },
                    { 257, 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0202746753733399172699069286m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 967, 986.6056110860197m, 5 },
                    { 258, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4905927871785194647201946472m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 822, 1225.267271060743m, 6 },
                    { 259, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9152864926745978782287822878m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1084, 992.1705580592641m, 1 },
                    { 260, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0302319243002490530303030303m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1056, 1087.924912061063m, 2 },
                    { 261, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1967828862333539094650205761m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 972, 1163.27296541882m, 3 },
                    { 262, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0365550283968013307984790875m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1052, 1090.455889873435m, 4 },
                    { 263, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.239893384344264m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 875, 1084.906711301231m, 5 },
                    { 264, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0161431806129945105215004575m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1093, 1110.644496410003m, 6 },
                    { 265, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2701964720637521160822249093m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 827, 1050.452482396723m, 1 },
                    { 266, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.01425338013429521484375m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1024, 1038.5954612575183m, 2 },
                    { 267, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9752134792726647058823529412m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1020, 994.717748858118m, 3 },
                    { 268, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0993390135630542918454935622m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 932, 1024.5839606407666m, 4 },
                    { 269, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7498159269294435975609756098m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 656, 1147.879248065715m, 5 },
                    { 270, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1935592871779774647887323944m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1065, 1271.140640844546m, 6 },
                    { 271, 4, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3596967032655825358851674641m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 836, 1136.706443930027m, 1 },
                    { 272, 3, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1806646871776770567786790267m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 863, 1018.9136250343353m, 2 },
                    { 273, 4, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2692851547881943539630836048m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 921, 1169.011627559927m, 3 },
                    { 274, 3, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6043899461510337837837837838m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 740, 1187.248560151765m, 4 },
                    { 275, 4, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9042261975352226397800183318m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1091, 986.5107815109279m, 5 },
                    { 276, 3, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9222736896936753527751646284m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1063, 980.3769321443769m, 6 },
                    { 277, 4, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7361533323771847507331378299m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 682, 1184.05657268124m, 1 },
                    { 278, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4588652401042198492462311558m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 796, 1161.256731122959m, 2 },
                    { 279, 4, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4194481381728057553956834532m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 834, 1183.81974723612m, 3 },
                    { 280, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6566790986760282485875706215m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 708, 1172.928801862628m, 4 },
                    { 281, 4, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1140630002691069246435845214m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 982, 1094.009866264263m, 5 },
                    { 282, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.355052908004353584447144593m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 823, 1115.208543287583m, 6 },
                    { 283, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9741551185594790719696969697m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1056, 1028.7078051988099m, 1 },
                    { 284, 3, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4476053437624741144414168937m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 734, 1062.542322321656m, 2 },
                    { 285, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9030061386977593423019431988m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 669, 1273.111106788801m, 3 },
                    { 286, 3, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1740223912995562650602409639m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 830, 974.4385847786317m, 4 },
                    { 287, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1258171474457650273224043716m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 915, 1030.122689912875m, 5 },
                    { 288, 3, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.249827947603189058524173028m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 786, 982.3647668161066m, 6 },
                    { 289, 4, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9251954595425409132420091324m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1095, 1013.0890281990823m, 1 },
                    { 290, 3, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7343050443520013440860215054m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 744, 1290.322952997889m, 2 },
                    { 291, 4, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4986868967906576227390180879m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 774, 1159.983658115969m, 3 },
                    { 292, 3, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5371627946107020506634499397m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 829, 1274.307956732272m, 4 },
                    { 293, 4, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6096995682506517967781908302m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 807, 1299.027551578276m, 5 },
                    { 294, 3, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7084615463760892351274787535m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 706, 1206.173851741519m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 295, 4, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5157467073476644113667117727m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 739, 1120.136816729924m, 1 },
                    { 296, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.318447725000928974358974359m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 780, 1028.3892255007246m, 2 },
                    { 297, 4, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5293998869830936018957345972m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 844, 1290.813504613731m, 3 },
                    { 298, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2809159556108271446862996159m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 781, 1000.395361332056m, 4 },
                    { 299, 4, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0019983123860279611650485437m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1030, 1032.0582617576088m, 5 },
                    { 300, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1601765598847162412993039443m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 862, 1000.0721946206254m, 6 },
                    { 301, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6338161197634257575757575758m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 660, 1078.318639043861m, 1 },
                    { 302, 3, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4695550942898832951945080092m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 874, 1284.391152409358m, 2 },
                    { 303, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2148266492229544319600499376m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 801, 973.0761460275865m, 3 },
                    { 304, 3, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9198986754913189251439539347m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1042, 958.53441986195432m, 4 },
                    { 305, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7070464468083390070921985816m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 705, 1203.467744999879m, 5 },
                    { 306, 3, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1657564253540363288718929254m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1046, 1219.381220920322m, 6 },
                    { 307, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5256818763038666666666666667m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 735, 1121.376179083342m, 1 },
                    { 308, 3, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1625086550881550223214285714m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 896, 1041.6077549589869m, 2 },
                    { 309, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8435837226388549618320610687m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 655, 1207.54733832845m, 3 },
                    { 310, 3, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3921399481474154761904761905m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 840, 1169.397556443829m, 4 },
                    { 311, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9897462083341397949673811743m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1073, 1061.997681542532m, 5 },
                    { 312, 3, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4866100118019365079365079365m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 819, 1217.533599665786m, 6 },
                    { 313, 4, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2950768522532985948477751756m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 854, 1105.995631824317m, 1 },
                    { 314, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.447430206840322m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 700, 1013.2011447882254m, 2 },
                    { 315, 4, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3803509736537305882352941176m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 850, 1173.298327605671m, 3 },
                    { 316, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4782245999074408759124087591m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 685, 1012.583850936597m, 4 },
                    { 317, 4, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1513904387495482866043613707m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 963, 1108.788992515815m, 5 },
                    { 318, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1111233757117848568790397045m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1083, 1203.346615895863m, 6 },
                    { 319, 4, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8639908696777274052478134111m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 686, 1278.697736598921m, 1 },
                    { 320, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6333157300113605263157894737m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 760, 1241.319954808634m, 2 },
                    { 321, 4, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0052249961226729435084241824m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1009, 1014.272021087777m, 3 },
                    { 322, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5054801978978107344632768362m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 708, 1065.87998011165m, 4 },
                    { 323, 4, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2273713269919278388746803069m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 782, 959.80437770768757m, 5 },
                    { 324, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2664570583216567164179104478m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 871, 1103.084097798163m, 6 },
                    { 325, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2126819155629506880733944954m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 872, 1057.458630370893m, 1 },
                    { 326, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.910025252744808890925756187m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1091, 992.8375507445865m, 2 },
                    { 327, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5512124506427382660687593423m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 669, 1037.7611294799919m, 3 },
                    { 328, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.046253668474579870729455217m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1083, 1133.09272295797m, 4 },
                    { 329, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4132683854448257309941520468m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 855, 1208.344469555326m, 5 },
                    { 330, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0410318945533061224489795918m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1078, 1122.232382328464m, 6 },
                    { 331, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1621120672754642857142857143m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 840, 976.17413651139m, 1 },
                    { 332, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4488770794533164861612515042m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 831, 1204.016853025706m, 2 },
                    { 333, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0632043160373501908396946565m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1048, 1114.238123207143m, 3 },
                    { 334, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.266332215819173120728929385m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 878, 1111.839685489234m, 4 },
                    { 335, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0559572284339115834218916047m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 941, 993.6557519563108m, 5 },
                    { 336, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4969313965962907431551499348m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 767, 1148.146381189355m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 337, 4, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4469644304344958871915393655m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 851, 1231.366730299756m, 1 },
                    { 338, 3, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4773833580499775725593667546m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 758, 1119.856585401883m, 2 },
                    { 339, 4, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2708852016978394566623544631m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 773, 982.3942609124299m, 3 },
                    { 340, 3, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1202070372937694524495677233m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1041, 1166.135525822814m, 4 },
                    { 341, 4, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5519315162879729064039408867m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 812, 1260.168391225834m, 5 },
                    { 342, 3, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2475337563761062992125984252m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1016, 1267.494296478124m, 6 },
                    { 343, 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7670460804027276853252647504m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 661, 1168.017459146203m, 1 },
                    { 344, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9470828641657904672897196262m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1070, 1013.3786646573958m, 2 },
                    { 345, 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.464028645279068188302425107m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 701, 1026.2840803406268m, 3 },
                    { 346, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4349799403555848920863309353m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 695, 997.3110585471315m, 4 },
                    { 347, 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2386059867151337974683544304m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 790, 978.4987295049557m, 5 },
                    { 348, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.171941902278672858617131063m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 969, 1135.611703308034m, 6 },
                    { 349, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8139396771871471025260029718m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 673, 1220.78140274695m, 1 },
                    { 350, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5041692103818911392405063291m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 790, 1188.293676201694m, 2 },
                    { 351, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3814306108774729496402877698m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 695, 960.0942745598437m, 3 },
                    { 352, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2168664021703671171171171171m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 888, 1080.577365127286m, 4 },
                    { 353, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2284009383146956947162426614m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1022, 1255.425758957619m, 5 },
                    { 354, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1197384662977211079274116523m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1047, 1172.366174213714m, 6 },
                    { 355, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2632131740511693386773547094m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 998, 1260.686747703067m, 1 },
                    { 356, 3, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6738872759695155367231638418m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 708, 1185.112191386417m, 2 },
                    { 357, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6801941940442073170731707317m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 738, 1239.983315204625m, 3 },
                    { 358, 3, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0698094916929826222684703434m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 961, 1028.0869215169563m, 4 },
                    { 359, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2051379750047693110647181628m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 958, 1154.522180054569m, 5 },
                    { 360, 3, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.070244544926669921875m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1024, 1095.93041400491m, 6 },
                    { 361, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4942390653830297542043984476m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 773, 1155.046797541082m, 1 },
                    { 362, 3, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1902792925622211448598130841m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 856, 1018.8790744332613m, 2 },
                    { 363, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7333924779843204022988505747m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 696, 1206.441164677087m, 3 },
                    { 364, 3, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2713770547607084785133565621m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 861, 1094.65564414897m, 4 },
                    { 365, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1117648782206850421052631579m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 855, 950.558970878685711m, 5 },
                    { 366, 3, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0779851217468517110266159696m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1052, 1134.040348077688m, 6 },
                    { 367, 4, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1294562783400658592848904268m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 867, 979.2385933208371m, 1 },
                    { 368, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3588833657204128738621586476m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 769, 1044.9813082389975m, 2 },
                    { 369, 4, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9717679537138446788111217641m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1043, 1013.55397572354m, 3 },
                    { 370, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5332540305344839948783610755m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 781, 1197.471397847432m, 4 },
                    { 371, 4, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3920851689975652232746955345m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 739, 1028.7509398892007m, 5 },
                    { 372, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.483521551399082514450867052m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 692, 1026.5969135681651m, 6 },
                    { 373, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1897734923399677744209466264m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 993, 1181.445077893588m, 1 },
                    { 374, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7063739800178957746478873239m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 710, 1211.525525812706m, 2 },
                    { 375, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2687577814270696741854636591m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 798, 1012.4687095788016m, 3 },
                    { 376, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4604538591674028436018957346m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 844, 1232.623057137288m, 4 },
                    { 377, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0791398427849475766567754698m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1011, 1091.010381055582m, 5 },
                    { 378, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9400420820550014464802314368m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1037, 974.8236390910365m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 379, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0522583643655437158469945355m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 915, 962.8164033944725m, 1 },
                    { 380, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2542924509844264367816091954m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 870, 1091.234432356451m, 2 },
                    { 381, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1539993244846247637051039698m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1058, 1220.931285304733m, 3 },
                    { 382, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0073158605935950298210735586m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1006, 1013.3597557571566m, 4 },
                    { 383, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3372540828095973303670745273m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 899, 1202.191420445828m, 5 },
                    { 384, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9506170212388905926622765757m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1063, 1010.5058935769407m, 6 },
                    { 385, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4315449277376354792560801144m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 1000.6499044886072m, 1 },
                    { 386, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9115261494010564892623716153m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1071, 976.2445060085315m, 2 },
                    { 387, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1763033506252082551594746717m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1066, 1253.939371766472m, 3 },
                    { 388, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4956986394876591478696741855m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 798, 1193.567514311152m, 4 },
                    { 389, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9751961660733913894324853229m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1022, 996.650481727006m, 5 },
                    { 390, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4716706255136559888579387187m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 718, 1056.659509118805m, 6 },
                    { 391, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7888487411659795620437956204m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 685, 1225.361387698696m, 1 },
                    { 392, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1171305386767274766355140187m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 856, 956.26374110727872m, 2 },
                    { 393, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2212792119248130966952264382m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 817, 997.7851161425723m, 3 },
                    { 394, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0216770998256218951241950322m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1087, 1110.563007510451m, 4 },
                    { 395, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5660540728192884353741496599m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 735, 1151.049743522177m, 5 },
                    { 396, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7009201053092874617737003058m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 654, 1112.401748872274m, 6 },
                    { 397, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3140745997731579514824797844m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 742, 975.0433530316832m, 1 },
                    { 398, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1096850849686383399209486166m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1012, 1123.001305988262m, 2 },
                    { 399, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2200928333465863237139272271m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 797, 972.4139881772293m, 3 },
                    { 400, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0726018801851396484375m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1024, 1098.344325309583m, 4 },
                    { 401, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5604724943667622478386167147m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, 1082.967911090533m, 5 },
                    { 402, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.153252738040285063752276867m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1098, 1266.271506368233m, 6 },
                    { 403, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4038822919038840970350404313m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 742, 1041.680660592682m, 1 },
                    { 404, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3816220354799137535816618911m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 698, 964.3721807649798m, 2 },
                    { 405, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1959334306613836858006042296m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 993, 1187.561896646754m, 3 },
                    { 406, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9591898923564951420714940422m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1091, 1046.4761725609362m, 4 },
                    { 407, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2123176332040666041275797373m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1066, 1292.330596995535m, 5 },
                    { 408, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6780411585981488497970230041m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 739, 1240.072416204032m, 6 },
                    { 409, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4743145444912318435754189944m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 716, 1055.609213855722m, 1 },
                    { 410, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3877757839482905982905982906m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 936, 1298.9581337756m, 2 },
                    { 411, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9543694015890633200795228628m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1006, 960.0956179985977m, 3 },
                    { 412, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4897784231632595108695652174m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 736, 1096.476919448159m, 4 },
                    { 413, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3285640627601736204576043069m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 743, 987.123098630809m, 5 },
                    { 414, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.540268528721439374185136897m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 767, 1181.385961529344m, 6 },
                    { 415, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1514678331111437308868501529m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 981, 1129.589944282032m, 1 },
                    { 416, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.465078104014815m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 800, 1172.062483211852m, 2 },
                    { 417, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0132853318187165128205128205m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 975, 987.9531985232486m, 3 },
                    { 418, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.091063087090533013844515442m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 939, 1024.5082387780105m, 4 },
                    { 419, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0695141686984787430683918669m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1082, 1157.214330531754m, 5 },
                    { 420, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0232320066900240384615384615m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1040, 1064.161286957625m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 421, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2010019389160543071161048689m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1068, 1282.670070762346m, 1 },
                    { 422, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5607652461813333333333333333m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 768, 1198.667709067264m, 2 },
                    { 423, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5170943462236977711738484398m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 673, 1021.0044950085486m, 3 },
                    { 424, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3529202776339541374474053296m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 964.6321579530093m, 4 },
                    { 425, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9885672650993125m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1016, 1004.3843413409015m, 5 },
                    { 426, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4373350199110112640801001252m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 1148.430680908898m, 6 },
                    { 427, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6271523249182489331436699858m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 1143.888084417529m, 1 },
                    { 428, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7959326863590145137880986938m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 689, 1237.397620901361m, 2 },
                    { 429, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4665540058216245353159851301m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 807, 1183.509082698051m, 3 },
                    { 430, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.091566373541678310740354536m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 959, 1046.8121522264695m, 4 },
                    { 431, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0104214572459517681728880157m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1018, 1028.6090434763789m, 5 },
                    { 432, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0849012131295023607176581681m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1059, 1148.910384704143m, 6 },
                    { 433, 4, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3935408593156362625139043382m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 899, 1252.793232524757m, 1 },
                    { 434, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9826061946473860809476801579m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1013, 995.3800751778021m, 2 },
                    { 435, 4, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9770683290488954410307234886m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1009, 985.8619440103355m, 3 },
                    { 436, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5910942680561840978593272171m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 654, 1040.5756513087444m, 4 },
                    { 437, 4, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5815592950382523489932885906m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 745, 1178.261674803498m, 5 },
                    { 438, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4062103911670583058305830583m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 909, 1278.245245570856m, 6 },
                    { 439, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.491881845262731823599523242m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 839, 1251.688868175432m, 1 },
                    { 440, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2514369380281440588853838065m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 951, 1190.116528064765m, 2 },
                    { 441, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1203527547889721669980119284m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1006, 1127.074871317706m, 3 },
                    { 442, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1665564750913747323340471092m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 934, 1089.563747735344m, 4 },
                    { 443, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4552579454151066413373860182m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 658, 957.55972808314017m, 5 },
                    { 444, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5655018119181253561253561254m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 702, 1098.982271966524m, 6 },
                    { 445, 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1238974509358454011741682975m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1022, 1148.623194856434m, 1 },
                    { 446, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2177251609486076023391812865m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 855, 1041.1550126110595m, 2 },
                    { 447, 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1467733029312291457286432161m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 995, 1141.039436416573m, 3 },
                    { 448, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2445137321849347181008902077m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1011, 1258.203383238969m, 4 },
                    { 449, 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2235201734400481335952848723m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1018, 1245.543536561969m, 5 },
                    { 450, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2598260638205207423580786026m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 916, 1154.000674459597m, 6 },
                    { 451, 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5101467183991756756756756757m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 814, 1229.259428776929m, 1 },
                    { 452, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.463218559869937129300118624m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 843, 1233.493245970357m, 2 },
                    { 453, 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7555587451954244186046511628m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 688, 1207.824416694452m, 3 },
                    { 454, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4133752623479198167239404353m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 873, 1233.876604029734m, 4 },
                    { 455, 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.56989372996394051593323217m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 659, 1034.5599680462368m, 5 },
                    { 456, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2261960437183965714285714286m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 875, 1072.921538253597m, 6 },
                    { 457, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1623900023525192439862542955m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 873, 1014.7664720537493m, 1 },
                    { 458, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1099764680930049164208456244m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1017, 1128.846068050586m, 2 },
                    { 459, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1545580580298678212290502793m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 895, 1033.3294619367317m, 3 },
                    { 460, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4244340705699144492131616595m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 995.6794153283702m, 4 },
                    { 461, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4915936806536853932584269663m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 801, 1194.766538203602m, 5 },
                    { 462, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4671034834009692307692307692m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 845, 1239.702443473819m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 463, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4787929570332662420382165605m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 785, 1160.852471271114m, 1 },
                    { 464, 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1359048358728066959385290889m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 911, 1034.8093054801269m, 2 },
                    { 465, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2375726754834724409448818898m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 889, 1100.202108504807m, 3 },
                    { 466, 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2527243550984936948297604035m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 793, 993.4104135931055m, 4 },
                    { 467, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1601303589906821322803553801m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1013, 1175.212053657561m, 5 },
                    { 468, 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0526608372897674203494347379m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 973, 1024.2389946829437m, 6 },
                    { 469, 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.138296891238759696261682243m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 856, 974.3821389003783m, 1 },
                    { 470, 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1803619041782454458293384468m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1043, 1231.11746605791m, 2 },
                    { 471, 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7274762796625195369030390738m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 691, 1193.686109246801m, 3 },
                    { 472, 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1086648372307261567516525024m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1059, 1174.076062627339m, 4 },
                    { 473, 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9677948248413350048216007715m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1037, 1003.6032333604644m, 5 },
                    { 474, 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1480215578301907066795740561m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1033, 1185.906269238587m, 6 },
                    { 475, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4905714846597013142174432497m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 837, 1247.60833266017m, 1 },
                    { 476, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1502238236113624878522837707m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1029, 1183.580314496092m, 2 },
                    { 477, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4292696621763803317535545024m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 844, 1206.303594876865m, 3 },
                    { 478, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.972177818452629478672985782m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1055, 1025.6475984675241m, 4 },
                    { 479, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1331146830410720183486238532m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 872, 988.0760036118148m, 5 },
                    { 480, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4891286417315924528301886792m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 795, 1183.857270176616m, 6 },
                    { 481, 4, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1683290558618843537414965986m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1029, 1202.210598481879m, 1 },
                    { 482, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3424634782324936548223350254m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 788, 1057.861220847205m, 2 },
                    { 483, 4, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9402766511742298195631528965m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1053, 990.111313686464m, 3 },
                    { 484, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0735016233346749178532311062m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 913, 980.1069821045582m, 4 },
                    { 485, 4, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4303961634364422843256379101m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 823, 1177.216042508192m, 5 },
                    { 486, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4627378188988250904704463209m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 829, 1212.609651867126m, 6 },
                    { 487, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6496825128466568047337278107m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 676, 1115.18537868434m, 1 },
                    { 488, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3631632293286226215644820296m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 946, 1289.552414944877m, 2 },
                    { 489, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.583015037190375m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 704, 1114.442586182024m, 3 },
                    { 490, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4426206022077981770833333333m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 768, 1107.932622495589m, 4 },
                    { 491, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6193315930118810457516339869m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 765, 1238.788668654089m, 5 },
                    { 492, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3759662586329934285714285714m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 700, 963.1763810430954m, 6 },
                    { 493, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2171503066982429193899782135m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 918, 1117.343981548987m, 1 },
                    { 494, 3, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3083874180566372239747634069m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 951, 1244.276434571862m, 2 },
                    { 495, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0648312905690605494505494505m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 910, 968.9964744178451m, 3 },
                    { 496, 3, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6015635391269527326440177253m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 677, 1084.258515988947m, 4 },
                    { 497, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.973567802963149158215010142m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 986, 959.93785372166507m, 5 },
                    { 498, 3, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5853265058648648310387984981m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 1266.675878186027m, 6 },
                    { 499, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0385962685395377532228360958m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1086, 1127.915547633938m, 1 },
                    { 500, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1066694829249431328036322361m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 881, 974.9758144568749m, 2 },
                    { 501, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.415884246609172752808988764m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 712, 1008.109583585731m, 3 },
                    { 502, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6877338373388527696793002915m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 686, 1157.785412414453m, 4 },
                    { 503, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3313620373306895306859205776m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 831, 1106.361853021803m, 5 },
                    { 504, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6524061677477830045523520486m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 659, 1088.935664545789m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 505, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0815694394369797160243407708m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 986, 1066.427467284862m, 1 },
                    { 506, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9432342016302218890554722639m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 667, 1296.137212487358m, 2 },
                    { 507, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5683930764217525125628140704m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 796, 1248.440888831715m, 3 },
                    { 508, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6133900495185408163265306122m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 686, 1106.785573969719m, 4 },
                    { 509, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2427021378240730223123732252m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 986, 1225.304307894536m, 5 },
                    { 510, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9639181439964575848303393214m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1002, 965.8459802844505m, 6 },
                    { 511, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0974551866528977732793522267m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 988, 1084.285724413063m, 1 },
                    { 512, 3, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7015490277032232876712328767m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 730, 1242.130790223353m, 2 },
                    { 513, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1513031048425030769230769231m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 910, 1047.6858254066778m, 3 },
                    { 514, 3, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2928238796970399113082039911m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 902, 1166.12713948673m, 4 },
                    { 515, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1584407056812911522633744856m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 972, 1126.004365922215m, 5 },
                    { 516, 3, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6057854638709166666666666667m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 792, 1271.782087385766m, 6 },
                    { 517, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4711575652360807113543091655m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 731, 1075.416180187575m, 1 },
                    { 518, 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.644538507605261038961038961m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 770, 1266.294650856051m, 2 },
                    { 519, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2411447889458526785714285714m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 896, 1112.065730895484m, 3 },
                    { 520, 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4211449486188436123348017621m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 908, 1290.39961334591m, 4 },
                    { 521, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4043646996472257834757834758m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 702, 985.8640191523525m, 5 },
                    { 522, 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3378615310577088305489260143m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 838, 1121.12796302636m, 6 },
                    { 523, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7298974846374472630173564753m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 749, 1295.693215993448m, 1 },
                    { 524, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4156144786637657142857142857m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 875, 1238.662668830795m, 2 },
                    { 525, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6098817010746099865047233468m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 741, 1192.922340496286m, 3 },
                    { 526, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3849048582732084656084656085m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 756, 1046.9880728545456m, 4 },
                    { 527, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0163947706111357798165137615m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1090, 1107.870299966138m, 5 },
                    { 528, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6347079207403361823361823362m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 702, 1147.564960359716m, 6 },
                    { 529, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3860260970301646803900325027m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 923, 1279.302087558842m, 1 },
                    { 530, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0288069508639525114155251142m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1095, 1126.543611196028m, 2 },
                    { 531, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0360140319915635838150289017m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1038, 1075.382565207243m, 3 },
                    { 532, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5350713567116107554417413572m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 781, 1198.890729591768m, 4 },
                    { 533, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5241298822504652492668621701m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 682, 1039.4565796948173m, 5 },
                    { 534, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9042857909428498865784499055m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1058, 956.73436681753518m, 6 },
                    { 535, 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.195510645571731041456016178m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 989, 1182.360028470442m, 1 },
                    { 536, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4367495834842084398976982097m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 782, 1123.538174284651m, 2 },
                    { 537, 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1281238846661722669735327963m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 869, 980.3396557749037m, 3 },
                    { 538, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1565234644347529411764705882m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 850, 983.04494476954m, 4 },
                    { 539, 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5182119285716222509702457956m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 773, 1173.577820785864m, 5 },
                    { 540, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5388069285623099273607748184m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 826, 1271.054522992468m, 6 },
                    { 541, 4, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.354864968123798469387755102m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 784, 1062.214135009058m, 1 },
                    { 542, 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3550333570348210526315789474m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 855, 1158.553520264772m, 2 },
                    { 543, 4, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2070501610506803455723542117m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 926, 1117.72844913293m, 3 },
                    { 544, 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2861455053317052631578947368m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 855, 1099.654407058608m, 4 },
                    { 545, 4, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.554822762771323785803237858m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 803, 1248.522678505373m, 5 },
                    { 546, 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0773646028414097158570119157m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1091, 1175.404781699978m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 547, 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5580080700656483221476510067m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 745, 1160.716012198908m, 1 },
                    { 548, 3, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5271633160822908163265306122m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 784, 1197.296039808516m, 2 },
                    { 549, 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2021277551049739478957915832m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 998, 1199.723499594764m, 3 },
                    { 550, 3, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.120203610839693858845096242m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1091, 1222.142139426106m, 4 },
                    { 551, 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1677549119307072463768115942m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1035, 1208.626333848282m, 5 },
                    { 552, 3, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6126682798186767015706806283m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 764, 1232.078565781469m, 6 },
                    { 553, 4, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2082982712779501625135427952m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 923, 1115.259304389548m, 1 },
                    { 554, 3, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1449815783547178329571106095m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 886, 1014.45367842228m, 2 },
                    { 555, 4, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4203238676655284463894967177m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 914, 1298.176015046293m, 3 },
                    { 556, 3, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8584756275599661764705882353m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 680, 1263.763426740777m, 4 },
                    { 557, 4, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1238941221776211538461538462m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1040, 1168.849887064726m, 5 },
                    { 558, 3, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2627006439664454649827784156m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 871, 1099.812260894774m, 6 },
                    { 559, 4, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0055716125994763780359028511m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 947, 952.27631713170413m, 1 },
                    { 560, 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0233018558145773480662983425m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1086, 1111.305815414631m, 2 },
                    { 561, 4, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0608619645442205607476635514m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 963, 1021.6100718560844m, 3 },
                    { 562, 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4951198674972894424673784104m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 843, 1260.386048300215m, 4 },
                    { 563, 4, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6019089321585705209656925032m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 787, 1260.702329608795m, 5 },
                    { 564, 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9894195858097333948339483395m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1084, 1072.530831017751m, 6 },
                    { 565, 4, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2889799978044642424242424242m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 825, 1063.408498188683m, 1 },
                    { 566, 3, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6032814292171916666666666667m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 720, 1154.362629036378m, 2 },
                    { 567, 4, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9561559891854205748865355522m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 661, 1293.019108851563m, 3 },
                    { 568, 3, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3904824176238027681660899654m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 867, 1205.548256079837m, 4 },
                    { 569, 4, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1286292741379952015355086372m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1042, 1176.031703651791m, 5 },
                    { 570, 3, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2804100327681223814773980154m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 907, 1161.331899720687m, 6 },
                    { 571, 4, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0700911032225018480492813142m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 974, 1042.2687345387168m, 1 },
                    { 572, 3, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6591878761593453237410071942m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 695, 1153.135573930745m, 2 },
                    { 573, 4, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.162671083241676173285198556m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 831, 966.1796701738329m, 3 },
                    { 574, 3, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2639871400421038157894736842m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 760, 960.6302264319989m, 4 },
                    { 575, 4, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1999777239567628755364806867m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 932, 1118.379238727703m, 5 },
                    { 576, 3, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7526460589314670750382848392m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 1144.477876482248m, 6 },
                    { 577, 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3285540910104326315789473684m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 950, 1262.126386459911m, 1 },
                    { 578, 3, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6333863329511347222222222222m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 720, 1176.038159724817m, 2 },
                    { 579, 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.448214244882059973924380704m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 767, 1110.78032582454m, 3 },
                    { 580, 3, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8425650853209800918836140888m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 1203.1950007146m, 4 },
                    { 581, 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4003207638615549389567147614m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 901, 1261.689008239261m, 5 },
                    { 582, 3, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4481305002974717741935483871m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 744, 1077.409092221319m, 6 },
                    { 583, 4, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.240312125865804661487236404m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 901, 1117.52122540509m, 1 },
                    { 584, 3, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4865997777690621403912543153m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 869, 1291.855206881315m, 2 },
                    { 585, 4, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3031130448112860020140986908m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 993, 1293.991253497607m, 3 },
                    { 586, 3, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3363854012240567123287671233m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 730, 975.5613428935614m, 4 },
                    { 587, 4, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1946195510588251986379114642m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 881, 1052.459824482825m, 5 },
                    { 588, 3, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2947902322181255434782608696m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 736, 952.9656109125404m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 589, 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1450695551129639222941720629m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1081, 1237.820189077114m, 1 },
                    { 590, 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5190762508371434659090909091m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 704, 1069.429680589349m, 2 },
                    { 591, 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2516758780638063157894736842m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 950, 1189.092084160616m, 3 },
                    { 592, 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9038200449890724410933081998m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1061, 958.95306773340586m, 4 },
                    { 593, 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.275961946902673202614379085m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 918, 1171.333067256654m, 5 },
                    { 594, 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.8986029696858956124314442413m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1094, 983.0716488363698m, 6 }
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
                    { 1, 10, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1146.161626445118m, 1 },
                    { 2, 7, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1130.169991389931m, 2 },
                    { 3, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 981.5196316728799m, 3 },
                    { 4, 5, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1188.740431220846m, 4 },
                    { 5, 7, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1093.199802827619m, 5 },
                    { 6, 10, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1056.76823548828m, 6 },
                    { 7, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1258.059414885351m, 7 },
                    { 8, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1051.217012699725m, 8 },
                    { 9, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1097.527563543834m, 9 },
                    { 10, 1, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1178.574860817346m, 10 },
                    { 11, 6, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1252.762768481248m, 11 },
                    { 12, 2, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1083.842715703248m, 12 },
                    { 13, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1067.513541881942m, 13 },
                    { 14, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1200.04757153226m, 14 },
                    { 15, 8, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1293.27809036542m, 15 },
                    { 16, 8, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 971.1658591471358m, 16 },
                    { 17, 2, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1093.587102155787m, 17 },
                    { 18, 9, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1018.2767818079602m, 18 },
                    { 19, 2, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1295.668847847468m, 19 },
                    { 20, 5, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1264.324069791603m, 20 },
                    { 21, 8, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1076.398813520593m, 21 },
                    { 22, 4, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1193.166390410041m, 22 },
                    { 23, 9, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1002.8901640305975m, 23 },
                    { 24, 5, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1038.9972561455663m, 24 },
                    { 25, 5, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1095.734024614976m, 25 },
                    { 26, 7, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1065.140330717577m, 26 },
                    { 27, 1, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1085.250657246199m, 27 },
                    { 28, 9, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1048.8769526122241m, 28 },
                    { 29, 1, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1202.589201705492m, 29 },
                    { 30, 6, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1250.02926543902m, 30 },
                    { 31, 1, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1214.681907758073m, 31 },
                    { 32, 10, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1191.415641392116m, 32 },
                    { 33, 7, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1294.458530399682m, 33 },
                    { 34, 5, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1086.039351888946m, 34 },
                    { 35, 6, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1062.992378705166m, 35 },
                    { 36, 9, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1254.715026173372m, 36 },
                    { 37, 1, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 996.7516409566705m, 37 },
                    { 38, 5, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1076.563075682127m, 38 },
                    { 39, 2, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1286.956129071845m, 39 },
                    { 40, 9, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 998.7594277096556m, 40 },
                    { 41, 6, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1033.1115621566879m, 41 },
                    { 42, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1233.735912662571m, 42 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 43, 2, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1107.315707089733m, 43 },
                    { 44, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 971.4539733717857m, 44 },
                    { 45, 10, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 989.6210538915245m, 45 },
                    { 46, 10, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1177.659259225919m, 46 },
                    { 47, 6, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1249.949319189544m, 47 },
                    { 48, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1220.470557052833m, 48 },
                    { 49, 9, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1293.896460536678m, 49 },
                    { 50, 6, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1008.0911959056904m, 50 },
                    { 51, 8, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1118.769378402912m, 51 },
                    { 52, 10, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1288.548112208482m, 52 },
                    { 53, 1, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1166.078762058609m, 53 },
                    { 54, 5, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1102.326644079592m, 54 },
                    { 55, 10, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1060.13679150207m, 55 },
                    { 56, 6, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1260.324319026457m, 56 },
                    { 57, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1127.701570561013m, 57 },
                    { 58, 2, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1010.2198197302347m, 58 },
                    { 59, 8, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1280.258547138004m, 59 },
                    { 60, 10, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1013.0959498522072m, 60 },
                    { 61, 10, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1288.638023211851m, 61 },
                    { 62, 1, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 981.987988697289m, 62 },
                    { 63, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1157.428346828985m, 63 },
                    { 64, 7, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1219.752662935559m, 64 },
                    { 65, 1, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1109.917696618721m, 65 },
                    { 66, 7, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1004.7222764989376m, 66 },
                    { 67, 2, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1234.127245926867m, 67 },
                    { 68, 1, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1044.2548463967819m, 68 },
                    { 69, 2, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 974.1030801814194m, 69 },
                    { 70, 2, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1088.303160543379m, 70 },
                    { 71, 5, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1111.590205738268m, 71 },
                    { 72, 5, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1298.380812054925m, 72 },
                    { 73, 7, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 980.2064412311904m, 73 },
                    { 74, 1, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1015.536491234634m, 74 },
                    { 75, 4, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1134.233723199401m, 75 },
                    { 76, 9, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1163.618332049507m, 76 },
                    { 77, 2, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1260.970988834601m, 77 },
                    { 78, 8, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1128.775792476318m, 78 },
                    { 79, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1114.464330792654m, 79 },
                    { 80, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1118.166248517827m, 80 },
                    { 81, 4, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1270.770313629009m, 81 },
                    { 82, 9, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1265.073612013951m, 82 },
                    { 83, 5, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1269.054421437326m, 83 },
                    { 84, 9, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1116.853736804753m, 84 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 85, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1262.434754826662m, 85 },
                    { 86, 10, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1283.51535630595m, 86 },
                    { 87, 1, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1259.716267762321m, 87 },
                    { 88, 9, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1102.604723918312m, 88 },
                    { 89, 9, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1021.870734240456m, 89 },
                    { 90, 9, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1107.535150428791m, 90 },
                    { 91, 9, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1275.813386349087m, 91 },
                    { 92, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1268.907780990158m, 92 },
                    { 93, 7, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1173.82344931002m, 93 },
                    { 94, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1289.01317989625m, 94 },
                    { 95, 10, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 998.2404039857468m, 95 },
                    { 96, 10, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1105.897629112387m, 96 },
                    { 97, 8, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1023.5040981400048m, 97 },
                    { 98, 9, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1295.803888501087m, 98 },
                    { 99, 9, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1012.3271756551854m, 99 },
                    { 100, 6, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1129.23007680278m, 100 },
                    { 101, 7, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1016.1369736417725m, 101 },
                    { 102, 6, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1044.4111728192911m, 102 },
                    { 103, 2, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1260.128169528633m, 103 },
                    { 104, 9, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1241.514856765845m, 104 },
                    { 105, 2, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1201.303355854454m, 105 },
                    { 106, 10, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1262.492963132213m, 106 },
                    { 107, 10, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1292.259849849746m, 107 },
                    { 108, 7, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1044.6786642956994m, 108 },
                    { 109, 5, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1116.081448414106m, 109 },
                    { 110, 1, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1082.102144077092m, 110 },
                    { 111, 2, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 965.9580033786125m, 111 },
                    { 112, 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1278.158454989898m, 112 },
                    { 113, 8, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1156.092198729612m, 113 },
                    { 114, 1, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1259.099737772027m, 114 },
                    { 115, 6, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1064.697678041507m, 115 },
                    { 116, 5, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1059.286370652853m, 116 },
                    { 117, 6, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1217.846710535821m, 117 },
                    { 118, 8, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1201.382300780289m, 118 },
                    { 119, 6, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1160.524374162218m, 119 },
                    { 120, 10, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1165.850258085088m, 120 },
                    { 121, 7, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 955.02101240102751m, 121 },
                    { 122, 5, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1274.026028190929m, 122 },
                    { 123, 1, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 995.9659922099064m, 123 },
                    { 124, 1, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1172.441795498064m, 124 },
                    { 125, 9, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 994.4305203839369m, 125 },
                    { 126, 7, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1251.195896892889m, 126 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 127, 6, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1115.535392570239m, 127 },
                    { 128, 1, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 977.6318649810367m, 128 },
                    { 129, 6, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1037.2509683982644m, 129 },
                    { 130, 7, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1268.24589884843m, 130 },
                    { 131, 8, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1251.282502226215m, 131 },
                    { 132, 2, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1183.372645826876m, 132 },
                    { 133, 6, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1233.571605918961m, 133 },
                    { 134, 3, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 952.90999657094163m, 134 },
                    { 135, 1, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1070.026684795524m, 135 },
                    { 136, 1, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 956.55263476358367m, 136 },
                    { 137, 10, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 995.6808648400643m, 137 },
                    { 138, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1161.147058228746m, 138 },
                    { 139, 7, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1136.949408386979m, 139 },
                    { 140, 2, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1126.12564689508m, 140 },
                    { 141, 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1120.950530976036m, 141 },
                    { 142, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1214.078297490224m, 142 },
                    { 143, 5, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1295.680857535544m, 143 },
                    { 144, 7, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1100.084207301605m, 144 },
                    { 145, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1195.577088907505m, 145 },
                    { 146, 2, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1184.812291425512m, 146 },
                    { 147, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1212.808965606489m, 147 },
                    { 148, 6, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1049.5961647213053m, 148 },
                    { 149, 6, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1068.892699198405m, 149 },
                    { 150, 1, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1134.898318058156m, 150 },
                    { 151, 1, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1263.207760168724m, 151 },
                    { 152, 10, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1215.8935024676m, 152 },
                    { 153, 7, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1199.320822866566m, 153 },
                    { 154, 8, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1045.7401476409234m, 154 },
                    { 155, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1070.935636533864m, 155 },
                    { 156, 8, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1025.4177350439138m, 156 },
                    { 157, 5, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1269.605157091304m, 157 },
                    { 158, 9, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1120.87660887938m, 158 },
                    { 159, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1011.8239681439758m, 159 },
                    { 160, 6, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1210.357749840282m, 160 },
                    { 161, 1, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1093.092100019963m, 161 },
                    { 162, 10, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1260.510189340426m, 162 },
                    { 163, 10, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 995.7479682066049m, 163 },
                    { 164, 5, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1192.300910631764m, 164 },
                    { 165, 8, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1082.869278827879m, 165 },
                    { 166, 7, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1107.990405912973m, 166 },
                    { 167, 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1236.482755309344m, 167 },
                    { 168, 8, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1086.948439725988m, 168 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 169, 8, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1215.052402701153m, 169 },
                    { 170, 8, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 974.6170510288866m, 170 },
                    { 171, 2, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1112.395357762875m, 171 },
                    { 172, 10, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1213.208585914248m, 172 },
                    { 173, 7, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1111.831718629849m, 173 },
                    { 174, 4, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1117.697256534722m, 174 },
                    { 175, 10, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1259.976748026864m, 175 },
                    { 176, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1243.486342660472m, 176 },
                    { 177, 7, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 973.630541989054m, 177 },
                    { 178, 1, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1259.90858797323m, 178 },
                    { 179, 5, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1102.327238836325m, 179 },
                    { 180, 6, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1073.512912407139m, 180 },
                    { 181, 7, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1028.7536417076089m, 181 },
                    { 182, 7, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1047.2913147703384m, 182 },
                    { 183, 3, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1114.264931237194m, 183 },
                    { 184, 6, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 985.1653373442436m, 184 },
                    { 185, 2, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 968.3691455728284m, 185 },
                    { 186, 1, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1186.262902687948m, 186 },
                    { 187, 5, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1137.005649897436m, 187 },
                    { 188, 9, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1278.009226853131m, 188 },
                    { 189, 6, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1067.746076150881m, 189 },
                    { 190, 10, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1089.697789427521m, 190 },
                    { 191, 1, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1011.7096741122094m, 191 },
                    { 192, 5, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1100.589405759124m, 192 },
                    { 193, 2, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1193.102384348337m, 193 },
                    { 194, 10, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1013.8723802722472m, 194 },
                    { 195, 9, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 993.9712805247187m, 195 },
                    { 196, 5, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1016.4151970187571m, 196 },
                    { 197, 6, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1134.77319834075m, 197 },
                    { 198, 2, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1267.59266188342m, 198 },
                    { 199, 2, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1157.513319848532m, 199 },
                    { 200, 7, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1073.795492371516m, 200 },
                    { 201, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1179.370260610473m, 201 },
                    { 202, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1268.837758312053m, 202 },
                    { 203, 9, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1057.084864224334m, 203 },
                    { 204, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1154.333865494025m, 204 },
                    { 205, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1231.281971615734m, 205 },
                    { 206, 10, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1013.3650346693272m, 206 },
                    { 207, 10, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1294.839131580012m, 207 },
                    { 208, 9, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1195.067016458101m, 208 },
                    { 209, 6, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 990.3955998461491m, 209 },
                    { 210, 10, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1119.055732840649m, 210 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 211, 7, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1054.342703882582m, 211 },
                    { 212, 1, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1111.143163338761m, 212 },
                    { 213, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1229.810644619394m, 213 },
                    { 214, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 990.1786975187222m, 214 },
                    { 215, 6, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1060.968819635106m, 215 },
                    { 216, 9, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1266.250015571762m, 216 },
                    { 217, 8, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1296.405168486971m, 217 },
                    { 218, 1, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1075.301572888039m, 218 },
                    { 219, 7, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1252.213649221804m, 219 },
                    { 220, 8, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1287.394570612586m, 220 },
                    { 221, 9, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1154.373110970652m, 221 },
                    { 222, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1203.360959535178m, 222 },
                    { 223, 3, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1116.589919769925m, 223 },
                    { 224, 10, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 974.4988330288226m, 224 },
                    { 225, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1019.9077434233297m, 225 },
                    { 226, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1146.407269103501m, 226 },
                    { 227, 6, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1213.990105280733m, 227 },
                    { 228, 8, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1273.983413139167m, 228 },
                    { 229, 1, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1269.578313186554m, 229 },
                    { 230, 7, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1270.161344635191m, 230 },
                    { 231, 8, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1210.492032760969m, 231 },
                    { 232, 1, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1009.5061781346276m, 232 },
                    { 233, 7, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 950.118326564070642m, 233 },
                    { 234, 10, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1145.914378569444m, 234 },
                    { 235, 8, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1105.257804352053m, 235 },
                    { 236, 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 958.28073420302507m, 236 },
                    { 237, 7, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1012.2079196395803m, 237 },
                    { 238, 7, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1122.546750327856m, 238 },
                    { 239, 2, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1188.198585193967m, 239 },
                    { 240, 2, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 960.1901507546465m, 240 },
                    { 241, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1111.864985116758m, 241 },
                    { 242, 8, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1279.612970956687m, 242 },
                    { 243, 2, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1237.344537637956m, 243 },
                    { 244, 10, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1101.912425819599m, 244 },
                    { 245, 7, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1023.635677394987m, 245 },
                    { 246, 2, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1025.5538763676282m, 246 },
                    { 247, 6, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1135.839778555268m, 247 },
                    { 248, 7, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1212.720555854322m, 248 },
                    { 249, 6, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1046.522673316107m, 249 },
                    { 250, 7, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1193.373247829719m, 250 },
                    { 251, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1098.491858513632m, 251 },
                    { 252, 9, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1214.218234765183m, 252 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 253, 2, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1256.225520700433m, 253 },
                    { 254, 10, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1265.391591210054m, 254 },
                    { 255, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1018.300898450233m, 255 },
                    { 256, 1, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 975.2451586037803m, 256 },
                    { 257, 10, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 986.6056110860197m, 257 },
                    { 258, 8, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1225.267271060743m, 258 },
                    { 259, 1, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 992.1705580592641m, 259 },
                    { 260, 10, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1087.924912061063m, 260 },
                    { 261, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1163.27296541882m, 261 },
                    { 262, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1090.455889873435m, 262 },
                    { 263, 7, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1084.906711301231m, 263 },
                    { 264, 1, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1110.644496410003m, 264 },
                    { 265, 1, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1050.452482396723m, 265 },
                    { 266, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1038.5954612575183m, 266 },
                    { 267, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 994.717748858118m, 267 },
                    { 268, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1024.5839606407666m, 268 },
                    { 269, 8, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1147.879248065715m, 269 },
                    { 270, 6, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1271.140640844546m, 270 },
                    { 271, 5, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1136.706443930027m, 271 },
                    { 272, 7, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1018.9136250343353m, 272 },
                    { 273, 7, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1169.011627559927m, 273 },
                    { 274, 7, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1187.248560151765m, 274 },
                    { 275, 5, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 986.5107815109279m, 275 },
                    { 276, 10, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 980.3769321443769m, 276 },
                    { 277, 5, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1184.05657268124m, 277 },
                    { 278, 9, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1161.256731122959m, 278 },
                    { 279, 7, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1183.81974723612m, 279 },
                    { 280, 6, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1172.928801862628m, 280 },
                    { 281, 2, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1094.009866264263m, 281 },
                    { 282, 1, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1115.208543287583m, 282 },
                    { 283, 5, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1028.7078051988099m, 283 },
                    { 284, 7, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1062.542322321656m, 284 },
                    { 285, 9, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1273.111106788801m, 285 },
                    { 286, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 974.4385847786317m, 286 },
                    { 287, 1, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1030.122689912875m, 287 },
                    { 288, 5, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 982.3647668161066m, 288 },
                    { 289, 7, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1013.0890281990823m, 289 },
                    { 290, 2, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1290.322952997889m, 290 },
                    { 291, 10, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1159.983658115969m, 291 },
                    { 292, 8, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1274.307956732272m, 292 },
                    { 293, 1, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1299.027551578276m, 293 },
                    { 294, 6, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1206.173851741519m, 294 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 295, 8, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1120.136816729924m, 295 },
                    { 296, 1, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1028.3892255007246m, 296 },
                    { 297, 1, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1290.813504613731m, 297 },
                    { 298, 8, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1000.395361332056m, 298 },
                    { 299, 2, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1032.0582617576088m, 299 },
                    { 300, 7, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1000.0721946206254m, 300 },
                    { 301, 6, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1078.318639043861m, 301 },
                    { 302, 5, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1284.391152409358m, 302 },
                    { 303, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 973.0761460275865m, 303 },
                    { 304, 10, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 958.53441986195432m, 304 },
                    { 305, 8, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1203.467744999879m, 305 },
                    { 306, 10, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1219.381220920322m, 306 },
                    { 307, 5, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1121.376179083342m, 307 },
                    { 308, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1041.6077549589869m, 308 },
                    { 309, 1, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1207.54733832845m, 309 },
                    { 310, 6, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1169.397556443829m, 310 },
                    { 311, 5, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1061.997681542532m, 311 },
                    { 312, 6, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1217.533599665786m, 312 },
                    { 313, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1105.995631824317m, 313 },
                    { 314, 10, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1013.2011447882254m, 314 },
                    { 315, 1, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1173.298327605671m, 315 },
                    { 316, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1012.583850936597m, 316 },
                    { 317, 9, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1108.788992515815m, 317 },
                    { 318, 5, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1203.346615895863m, 318 },
                    { 319, 6, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1278.697736598921m, 319 },
                    { 320, 9, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1241.319954808634m, 320 },
                    { 321, 6, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1014.272021087777m, 321 },
                    { 322, 7, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1065.87998011165m, 322 },
                    { 323, 7, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 959.80437770768757m, 323 },
                    { 324, 4, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1103.084097798163m, 324 },
                    { 325, 6, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1057.458630370893m, 325 },
                    { 326, 10, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 992.8375507445865m, 326 },
                    { 327, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1037.7611294799919m, 327 },
                    { 328, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1133.09272295797m, 328 },
                    { 329, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1208.344469555326m, 329 },
                    { 330, 9, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1122.232382328464m, 330 },
                    { 331, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 976.17413651139m, 331 },
                    { 332, 10, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1204.016853025706m, 332 },
                    { 333, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1114.238123207143m, 333 },
                    { 334, 2, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1111.839685489234m, 334 },
                    { 335, 2, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 993.6557519563108m, 335 },
                    { 336, 10, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1148.146381189355m, 336 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 337, 2, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1231.366730299756m, 337 },
                    { 338, 1, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1119.856585401883m, 338 },
                    { 339, 9, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 982.3942609124299m, 339 },
                    { 340, 7, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1166.135525822814m, 340 },
                    { 341, 2, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1260.168391225834m, 341 },
                    { 342, 6, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1267.494296478124m, 342 },
                    { 343, 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1168.017459146203m, 343 },
                    { 344, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1013.3786646573958m, 344 },
                    { 345, 1, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1026.2840803406268m, 345 },
                    { 346, 1, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 997.3110585471315m, 346 },
                    { 347, 10, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 978.4987295049557m, 347 },
                    { 348, 6, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1135.611703308034m, 348 },
                    { 349, 9, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1220.78140274695m, 349 },
                    { 350, 5, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1188.293676201694m, 350 },
                    { 351, 2, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 960.0942745598437m, 351 },
                    { 352, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1080.577365127286m, 352 },
                    { 353, 7, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1255.425758957619m, 353 },
                    { 354, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1172.366174213714m, 354 },
                    { 355, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1260.686747703067m, 355 },
                    { 356, 6, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1185.112191386417m, 356 },
                    { 357, 1, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1239.983315204625m, 357 },
                    { 358, 10, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1028.0869215169563m, 358 },
                    { 359, 9, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1154.522180054569m, 359 },
                    { 360, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1095.93041400491m, 360 },
                    { 361, 1, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1155.046797541082m, 361 },
                    { 362, 7, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1018.8790744332613m, 362 },
                    { 363, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1206.441164677087m, 363 },
                    { 364, 10, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1094.65564414897m, 364 },
                    { 365, 8, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 950.558970878685711m, 365 },
                    { 366, 1, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1134.040348077688m, 366 },
                    { 367, 6, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 979.2385933208371m, 367 },
                    { 368, 4, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1044.9813082389975m, 368 },
                    { 369, 10, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1013.55397572354m, 369 },
                    { 370, 2, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1197.471397847432m, 370 },
                    { 371, 10, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1028.7509398892007m, 371 },
                    { 372, 6, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1026.5969135681651m, 372 },
                    { 373, 2, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1181.445077893588m, 373 },
                    { 374, 5, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1211.525525812706m, 374 },
                    { 375, 8, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1012.4687095788016m, 375 },
                    { 376, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1232.623057137288m, 376 },
                    { 377, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1091.010381055582m, 377 },
                    { 378, 10, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 974.8236390910365m, 378 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 379, 10, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 962.8164033944725m, 379 },
                    { 380, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1091.234432356451m, 380 },
                    { 381, 5, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1220.931285304733m, 381 },
                    { 382, 2, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1013.3597557571566m, 382 },
                    { 383, 7, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1202.191420445828m, 383 },
                    { 384, 6, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1010.5058935769407m, 384 },
                    { 385, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1000.6499044886072m, 385 },
                    { 386, 7, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 976.2445060085315m, 386 },
                    { 387, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1253.939371766472m, 387 },
                    { 388, 2, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1193.567514311152m, 388 },
                    { 389, 2, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 996.650481727006m, 389 },
                    { 390, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1056.659509118805m, 390 },
                    { 391, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1225.361387698696m, 391 },
                    { 392, 9, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 956.26374110727872m, 392 },
                    { 393, 10, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 997.7851161425723m, 393 },
                    { 394, 9, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1110.563007510451m, 394 },
                    { 395, 2, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1151.049743522177m, 395 },
                    { 396, 2, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1112.401748872274m, 396 },
                    { 397, 8, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 975.0433530316832m, 397 },
                    { 398, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1123.001305988262m, 398 },
                    { 399, 2, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 972.4139881772293m, 399 },
                    { 400, 6, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1098.344325309583m, 400 },
                    { 401, 10, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1082.967911090533m, 401 },
                    { 402, 1, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1266.271506368233m, 402 },
                    { 403, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1041.680660592682m, 403 },
                    { 404, 1, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 964.3721807649798m, 404 },
                    { 405, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1187.561896646754m, 405 },
                    { 406, 2, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1046.4761725609362m, 406 },
                    { 407, 7, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1292.330596995535m, 407 },
                    { 408, 5, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1240.072416204032m, 408 },
                    { 409, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1055.609213855722m, 409 },
                    { 410, 6, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1298.9581337756m, 410 },
                    { 411, 2, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 960.0956179985977m, 411 },
                    { 412, 9, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1096.476919448159m, 412 },
                    { 413, 6, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 987.123098630809m, 413 },
                    { 414, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1181.385961529344m, 414 },
                    { 415, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1129.589944282032m, 415 },
                    { 416, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1172.062483211852m, 416 },
                    { 417, 10, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 987.9531985232486m, 417 },
                    { 418, 8, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1024.5082387780105m, 418 },
                    { 419, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1157.214330531754m, 419 },
                    { 420, 5, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1064.161286957625m, 420 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 421, 5, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1282.670070762346m, 421 },
                    { 422, 1, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1198.667709067264m, 422 },
                    { 423, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1021.0044950085486m, 423 },
                    { 424, 6, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 964.6321579530093m, 424 },
                    { 425, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1004.3843413409015m, 425 },
                    { 426, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1148.430680908898m, 426 },
                    { 427, 8, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1143.888084417529m, 427 },
                    { 428, 10, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1237.397620901361m, 428 },
                    { 429, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1183.509082698051m, 429 },
                    { 430, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1046.8121522264695m, 430 },
                    { 431, 2, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1028.6090434763789m, 431 },
                    { 432, 1, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1148.910384704143m, 432 },
                    { 433, 9, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1252.793232524757m, 433 },
                    { 434, 5, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 995.3800751778021m, 434 },
                    { 435, 6, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 985.8619440103355m, 435 },
                    { 436, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1040.5756513087444m, 436 },
                    { 437, 10, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1178.261674803498m, 437 },
                    { 438, 2, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1278.245245570856m, 438 },
                    { 439, 2, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1251.688868175432m, 439 },
                    { 440, 7, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1190.116528064765m, 440 },
                    { 441, 8, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1127.074871317706m, 441 },
                    { 442, 5, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1089.563747735344m, 442 },
                    { 443, 2, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 957.55972808314017m, 443 },
                    { 444, 9, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1098.982271966524m, 444 },
                    { 445, 10, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1148.623194856434m, 445 },
                    { 446, 10, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1041.1550126110595m, 446 },
                    { 447, 10, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1141.039436416573m, 447 },
                    { 448, 8, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1258.203383238969m, 448 },
                    { 449, 2, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1245.543536561969m, 449 },
                    { 450, 10, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1154.000674459597m, 450 },
                    { 451, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1229.259428776929m, 451 },
                    { 452, 9, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1233.493245970357m, 452 },
                    { 453, 5, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1207.824416694452m, 453 },
                    { 454, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1233.876604029734m, 454 },
                    { 455, 5, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1034.5599680462368m, 455 },
                    { 456, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1072.921538253597m, 456 },
                    { 457, 9, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1014.7664720537493m, 457 },
                    { 458, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1128.846068050586m, 458 },
                    { 459, 6, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1033.3294619367317m, 459 },
                    { 460, 6, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 995.6794153283702m, 460 },
                    { 461, 10, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1194.766538203602m, 461 },
                    { 462, 9, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1239.702443473819m, 462 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 463, 1, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1160.852471271114m, 463 },
                    { 464, 1, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1034.8093054801269m, 464 },
                    { 465, 2, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1100.202108504807m, 465 },
                    { 466, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 993.4104135931055m, 466 },
                    { 467, 5, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1175.212053657561m, 467 },
                    { 468, 5, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1024.2389946829437m, 468 },
                    { 469, 10, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 974.3821389003783m, 469 },
                    { 470, 5, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1231.11746605791m, 470 },
                    { 471, 5, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1193.686109246801m, 471 },
                    { 472, 10, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.076062627339m, 472 },
                    { 473, 7, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1003.6032333604644m, 473 },
                    { 474, 2, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1185.906269238587m, 474 },
                    { 475, 10, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1247.60833266017m, 475 },
                    { 476, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1183.580314496092m, 476 },
                    { 477, 8, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1206.303594876865m, 477 },
                    { 478, 6, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1025.6475984675241m, 478 },
                    { 479, 1, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 988.0760036118148m, 479 },
                    { 480, 7, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1183.857270176616m, 480 },
                    { 481, 9, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1202.210598481879m, 481 },
                    { 482, 7, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1057.861220847205m, 482 },
                    { 483, 9, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 990.111313686464m, 483 },
                    { 484, 9, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 980.1069821045582m, 484 },
                    { 485, 10, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1177.216042508192m, 485 },
                    { 486, 2, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1212.609651867126m, 486 },
                    { 487, 2, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1115.18537868434m, 487 },
                    { 488, 9, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1289.552414944877m, 488 },
                    { 489, 6, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1114.442586182024m, 489 },
                    { 490, 8, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1107.932622495589m, 490 },
                    { 491, 2, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1238.788668654089m, 491 },
                    { 492, 2, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 963.1763810430954m, 492 },
                    { 493, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1117.343981548987m, 493 },
                    { 494, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1244.276434571862m, 494 },
                    { 495, 6, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 968.9964744178451m, 495 },
                    { 496, 10, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1084.258515988947m, 496 },
                    { 497, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 959.93785372166507m, 497 },
                    { 498, 10, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1266.675878186027m, 498 },
                    { 499, 10, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1127.915547633938m, 499 },
                    { 500, 5, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 974.9758144568749m, 500 },
                    { 501, 10, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1008.109583585731m, 501 },
                    { 502, 10, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1157.785412414453m, 502 },
                    { 503, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1106.361853021803m, 503 },
                    { 504, 7, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1088.935664545789m, 504 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 505, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1066.427467284862m, 505 },
                    { 506, 6, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1296.137212487358m, 506 },
                    { 507, 2, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1248.440888831715m, 507 },
                    { 508, 6, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1106.785573969719m, 508 },
                    { 509, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1225.304307894536m, 509 },
                    { 510, 2, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 965.8459802844505m, 510 },
                    { 511, 9, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1084.285724413063m, 511 },
                    { 512, 2, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1242.130790223353m, 512 },
                    { 513, 8, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1047.6858254066778m, 513 },
                    { 514, 2, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1166.12713948673m, 514 },
                    { 515, 1, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1126.004365922215m, 515 },
                    { 516, 8, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1271.782087385766m, 516 },
                    { 517, 6, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1075.416180187575m, 517 },
                    { 518, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1266.294650856051m, 518 },
                    { 519, 1, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1112.065730895484m, 519 },
                    { 520, 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1290.39961334591m, 520 },
                    { 521, 9, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 985.8640191523525m, 521 },
                    { 522, 8, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1121.12796302636m, 522 },
                    { 523, 10, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1295.693215993448m, 523 },
                    { 524, 10, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1238.662668830795m, 524 },
                    { 525, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1192.922340496286m, 525 },
                    { 526, 9, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1046.9880728545456m, 526 },
                    { 527, 10, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1107.870299966138m, 527 },
                    { 528, 7, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1147.564960359716m, 528 },
                    { 529, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1279.302087558842m, 529 },
                    { 530, 6, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1126.543611196028m, 530 },
                    { 531, 6, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1075.382565207243m, 531 },
                    { 532, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1198.890729591768m, 532 },
                    { 533, 7, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1039.4565796948173m, 533 },
                    { 534, 1, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 956.73436681753518m, 534 },
                    { 535, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1182.360028470442m, 535 },
                    { 536, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1123.538174284651m, 536 },
                    { 537, 5, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 980.3396557749037m, 537 },
                    { 538, 6, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 983.04494476954m, 538 },
                    { 539, 8, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1173.577820785864m, 539 },
                    { 540, 8, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1271.054522992468m, 540 },
                    { 541, 5, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1062.214135009058m, 541 },
                    { 542, 9, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1158.553520264772m, 542 },
                    { 543, 6, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1117.72844913293m, 543 },
                    { 544, 8, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1099.654407058608m, 544 },
                    { 545, 8, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1248.522678505373m, 545 },
                    { 546, 6, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1175.404781699978m, 546 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 547, 2, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1160.716012198908m, 547 },
                    { 548, 10, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1197.296039808516m, 548 },
                    { 549, 1, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1199.723499594764m, 549 },
                    { 550, 6, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1222.142139426106m, 550 },
                    { 551, 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1208.626333848282m, 551 },
                    { 552, 2, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1232.078565781469m, 552 },
                    { 553, 9, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1115.259304389548m, 553 },
                    { 554, 8, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1014.45367842228m, 554 },
                    { 555, 2, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1298.176015046293m, 555 },
                    { 556, 2, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1263.763426740777m, 556 },
                    { 557, 2, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1168.849887064726m, 557 },
                    { 558, 10, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1099.812260894774m, 558 },
                    { 559, 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 952.27631713170413m, 559 },
                    { 560, 5, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1111.305815414631m, 560 },
                    { 561, 9, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1021.6100718560844m, 561 },
                    { 562, 7, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1260.386048300215m, 562 },
                    { 563, 10, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1260.702329608795m, 563 },
                    { 564, 2, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1072.530831017751m, 564 },
                    { 565, 10, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1063.408498188683m, 565 },
                    { 566, 2, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1154.362629036378m, 566 },
                    { 567, 1, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1293.019108851563m, 567 },
                    { 568, 3, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1205.548256079837m, 568 },
                    { 569, 1, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1176.031703651791m, 569 },
                    { 570, 10, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1161.331899720687m, 570 },
                    { 571, 4, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1042.2687345387168m, 571 },
                    { 572, 2, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1153.135573930745m, 572 },
                    { 573, 9, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 966.1796701738329m, 573 },
                    { 574, 10, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 960.6302264319989m, 574 },
                    { 575, 2, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1118.379238727703m, 575 },
                    { 576, 2, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1144.477876482248m, 576 },
                    { 577, 6, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1262.126386459911m, 577 },
                    { 578, 5, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1176.038159724817m, 578 },
                    { 579, 10, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1110.78032582454m, 579 },
                    { 580, 5, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1203.1950007146m, 580 },
                    { 581, 5, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1261.689008239261m, 581 },
                    { 582, 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1077.409092221319m, 582 },
                    { 583, 7, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1117.52122540509m, 583 },
                    { 584, 5, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1291.855206881315m, 584 },
                    { 585, 7, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1293.991253497607m, 585 },
                    { 586, 8, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 975.5613428935614m, 586 },
                    { 587, 6, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1052.459824482825m, 587 },
                    { 588, 7, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 952.9656109125404m, 588 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 589, 2, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1237.820189077114m, 589 },
                    { 590, 10, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1069.429680589349m, 590 },
                    { 591, 2, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1189.092084160616m, 591 },
                    { 592, 2, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 958.95306773340586m, 592 },
                    { 593, 10, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1171.333067256654m, 593 },
                    { 594, 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 983.0716488363698m, 594 }
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
