using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class SeedFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AddedDate", "CompanyAddress", "CompanyCountry", "CompanyName", "CompanyTown", "CompanyVat", "IsActive", "RemovedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), "17 RUE BOBBY SANDS", "France", "MALHERBE DISTRIBUTION", "44813 ST-HERBLAIN CEDEX", "FR72518435920", true, null },
                    { 2, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), "ROUTE DE SCHWEIGEN BP 10025", "France", "WOEHL & CIE - TPT INTERNATIONAUX", "67160 WISSEMBOURG", "FR37558501144", true, null },
                    { 3, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), "144 ZAE WOLSER", "Luxembourg", "XPO TRS LU", "3225 BETTEMBOURG", "LU17458960", true, null },
                    { 4, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), "2609 AVENUE DE PRADES", "France", "GEFCO FRANCE", "66000 PERPIGNAN", "FR24789791464", true, null },
                    { 5, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), "69 Route de Thionville", "France", "Yusen Logistics (France) SAS", "57280 Maizières-lès-Metz", "FR89432599785", true, null },
                    { 6, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), "JUSTUS LIEBIG STRASSE 14", "Germany", "SCHENKER DEUTSCHLAND AG", "34253 LOHFELDEN/KASSEL", "DE811228366", true, null },
                    { 7, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Brinkhofstraße 41", "Germany", "Winner Spedition GmbH & Co. KG", "58642 Iserlohn", "DE125572634", true, null },
                    { 8, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Genthiner Strasse 34", "Germany", "sennder Technologies GmbH", "10785 Berlin", "DE302502945", true, null },
                    { 9, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Otto-Hahn-Str. 3", "Germany", "Stahl Log", "D-66793 Saarwellingen", "DE813065962", true, null },
                    { 10, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), "RUE DES VERGERS", "France", "GREILSAMMER ABCE", "F - 68600 WOLFGANTZEN", "FR06514447937", true, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "EmployeeUserId" },
                values: new object[,]
                {
                    { 1, "admin@truck.com", "05ec77f9-f1a2-44ce-a38e-609329542e7e" },
                    { 2, "manager@truck.com", "0261d5ca-050a-423e-90cb-c7e990f67959" },
                    { 3, "dispo1@truck.com", "62154153-66df-4b35-91ed-56ac983c9a8e" },
                    { 4, "dispo2@truck.com", "19918df1-9468-434b-aaf9-a3d22b2d12e2" }
                });

            migrationBuilder.InsertData(
                table: "Trucks",
                columns: new[] { "Id", "AddedDate", "IsActive", "ProductionYear", "RemovedDate", "TruckBrand", "TruckInitialKm", "TruckModel", "TruckPlate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 195000, "Renault Trucks T High", "B8511TC" },
                    { 2, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 198000, "Renault Trucks T High", "B8514TC" },
                    { 3, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 201500, "Renault Trucks T High", "B8517TC" },
                    { 4, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 205000, "Renault Trucks T High", "B9133TC" },
                    { 5, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 210000, "Renault Trucks T High", "B9134TC" },
                    { 6, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 230500, "Renault Trucks T High", "B9135TC" }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3279877360307965473145780051m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 782, 1038.4864095760829m, 1 },
                    { 2, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1352609636401411549037580202m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1091, 1238.569711331394m, 2 },
                    { 3, 4, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2725450373624517593643586833m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 881, 1121.11217791632m, 3 },
                    { 4, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1382303176337361050328227571m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 914, 1040.3425103172348m, 4 },
                    { 5, 4, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1297609593810776209677419355m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 992, 1120.722871706029m, 5 },
                    { 6, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1089629933601580233793836344m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 941, 1043.5341767519087m, 6 },
                    { 7, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4565844775174023809523809524m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 840, 1223.530961114618m, 1 },
                    { 8, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7984667603978260869565217391m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 1282.30680016365m, 2 },
                    { 9, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2767747117869817351598173516m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 876, 1118.454647525396m, 3 },
                    { 10, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3983885703986087533156498674m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 754, 1054.384982080551m, 4 },
                    { 11, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4901424971678145161290322581m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 868, 1293.443687541663m, 5 },
                    { 12, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0063548231357525653436592449m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1033, 1039.5645322992324m, 6 },
                    { 13, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3491679372968968085106382979m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 940, 1268.217861059083m, 1 },
                    { 14, 3, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2136100523055979924717691343m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 797, 967.2472116875616m, 2 },
                    { 15, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.727617242995255524861878453m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 724, 1250.794883928565m, 3 },
                    { 16, 3, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3384044062692770557029177719m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 754, 1009.1569223270349m, 4 },
                    { 17, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3787143421713939393939393939m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 924, 1273.932052166368m, 5 },
                    { 18, 3, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2067461331955043478260869565m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 920, 1110.206442539864m, 6 },
                    { 19, 4, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3229483836933793103448275862m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 899, 1189.330596940348m, 1 },
                    { 20, 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5818224581899232704402515723m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 795, 1257.548854260989m, 2 },
                    { 21, 4, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1829653100081152073732718894m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1085, 1283.517361358805m, 3 },
                    { 22, 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2773219721248153846153846154m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 910, 1162.362994633582m, 4 },
                    { 23, 4, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3248271285519164859002169197m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 922, 1221.490612524867m, 5 },
                    { 24, 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2543520058833776775648252537m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 887, 1112.610229218556m, 6 },
                    { 25, 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5659753995508759493670886076m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 790, 1237.120565645192m, 1 },
                    { 26, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2984521260104436936936936937m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 888, 1153.025487897274m, 2 },
                    { 27, 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.304592003592643702906350915m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 929, 1211.965971337566m, 3 },
                    { 28, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2005443750176674447174447174m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 814, 977.2431212643813m, 4 },
                    { 29, 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3860204149668685082872928177m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 905, 1254.348475545016m, 5 },
                    { 30, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7438780767163924418604651163m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 688, 1199.788116780878m, 6 },
                    { 31, 4, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5561143259497975206611570248m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 726, 1129.739000639553m, 1 },
                    { 32, 3, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1972904302329155784650630011m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 873, 1045.2345455933353m, 2 },
                    { 33, 4, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2629176099508745980707395498m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 933, 1178.302130084166m, 3 },
                    { 34, 3, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7360768338525309973045822102m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 742, 1288.169010718578m, 4 },
                    { 35, 4, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5896063399850728571428571429m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 700, 1112.724437989551m, 5 },
                    { 36, 3, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.528721906505819047619047619m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 735, 1123.610601281777m, 6 },
                    { 37, 4, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4283641540891785252263906856m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 773, 1104.125491110935m, 1 },
                    { 38, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7911356841859621212121212121m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 660, 1182.149551562735m, 2 },
                    { 39, 4, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3375411097936573875802997859m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 934, 1249.263396547276m, 3 },
                    { 40, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1571077742083253664036076663m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 887, 1026.3545957227846m, 4 },
                    { 41, 4, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3079413984548529411764705882m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 816, 1067.28018113916m, 5 },
                    { 42, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0157505783143582304526748971m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 972, 987.3095621215562m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 43, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2364602412823496115427302997m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 901, 1114.050677395397m, 1 },
                    { 44, 3, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.900096272711486322188449848m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 658, 1250.263347444158m, 2 },
                    { 45, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.081497930150425832492431887m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 991, 1071.764448779072m, 3 },
                    { 46, 3, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0729201774619872262773722628m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1096, 1175.920514498338m, 4 },
                    { 47, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1279736304867407407407407407m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 972, 1096.390368833112m, 5 },
                    { 48, 3, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4645925690976071428571428571m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 756, 1107.231982237791m, 6 },
                    { 49, 4, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7697312489029305135951661631m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 662, 1171.56208677374m, 1 },
                    { 50, 3, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3924333010387182389937106918m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 795, 1106.984474325781m, 2 },
                    { 51, 4, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2305287218819313432835820896m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 989.3450923930728m, 3 },
                    { 52, 3, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1091991339678201219512195122m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 984, 1091.451947824335m, 4 },
                    { 53, 4, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.319447801596587991718426501m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 966, 1274.586576342304m, 5 },
                    { 54, 3, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9792355568158756906077348066m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1086, 1063.449814702041m, 6 },
                    { 55, 4, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1082753033415656670113753878m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 967, 1071.702218331294m, 1 },
                    { 56, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3873774574392841163310961969m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 894, 1240.31544695072m, 2 },
                    { 57, 4, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1408038920687297560975609756m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1025, 1169.323989370448m, 3 },
                    { 58, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2528010844146089646133682831m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 763, 955.88722740834664m, 4 },
                    { 59, 4, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9503493372687701674277016743m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 657, 1281.379514585582m, 5 },
                    { 60, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0121162261879269906928645295m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 967, 978.7163907237254m, 6 },
                    { 61, 4, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2200643977133168604651162791m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1032, 1259.106458440143m, 1 },
                    { 62, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9569198755162579482439926063m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1082, 1035.3873053085911m, 2 },
                    { 63, 4, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2572943018352461695607763023m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 979, 1230.891121496706m, 3 },
                    { 64, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.771629377778660300136425648m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 733, 1298.604333911758m, 4 },
                    { 65, 4, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2669278940653347150259067358m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 965, 1222.585417773048m, 5 },
                    { 66, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0678709104048851196670135276m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 961, 1026.2239448990946m, 6 },
                    { 67, 4, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3391619782064252163164400494m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 809, 1083.382040368998m, 1 },
                    { 68, 3, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9861097112868520547945205479m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1095, 1079.790133859103m, 2 },
                    { 69, 4, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.206692279472250261780104712m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 955, 1152.391126895999m, 3 },
                    { 70, 3, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7037255165124846153846153846m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 650, 1107.421585733115m, 4 },
                    { 71, 4, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8653675174228036529680365297m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 657, 1225.546458946782m, 5 },
                    { 72, 3, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2244467151351348425196850394m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1016, 1244.037862577297m, 6 },
                    { 73, 4, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3548759921207464454976303318m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 844, 1143.51533734991m, 1 },
                    { 74, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5977906096758782608695652174m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 805, 1286.221440789082m, 2 },
                    { 75, 4, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8589022822076253731343283582m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 670, 1245.464529079109m, 3 },
                    { 76, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8254957953129557522123893805m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 678, 1237.686149222184m, 4 },
                    { 77, 4, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1195794174334657687991021324m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 891, 997.545260933218m, 5 },
                    { 78, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6660949232903880389429763561m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 719, 1197.922249845789m, 6 },
                    { 79, 4, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3423212914042092746730083234m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 841, 1128.89220607094m, 1 },
                    { 80, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4436182235155770567786790267m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 863, 1245.842526893943m, 2 },
                    { 81, 4, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.234301534233347027027027027m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 925, 1141.728919165846m, 3 },
                    { 82, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1860870401377292452830188679m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1060, 1257.252262545993m, 4 },
                    { 83, 4, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2341350393166954643628509719m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 926, 1142.80904640726m, 5 },
                    { 84, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2091422470819888268156424581m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1074, 1298.618773366056m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 85, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5796079726347325268817204301m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 744, 1175.228331640241m, 1 },
                    { 86, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9048870429620223214285714286m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 672, 1280.084092870479m, 2 },
                    { 87, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0874713673759595103578154426m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1062, 1154.894592153269m, 3 },
                    { 88, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1097164044398086225026288118m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 951, 1055.340300622258m, 4 },
                    { 89, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.231055891184540650406504065m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 984, 1211.358996925588m, 5 },
                    { 90, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2373747006303471190781049936m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 781, 966.3896411923011m, 6 },
                    { 91, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4136788555884592592592592593m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 810, 1145.079873026652m, 1 },
                    { 92, 3, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2509081053714377171215880893m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 806, 1008.2319329293788m, 2 },
                    { 93, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6251914787697496598639455782m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 735, 1194.515736895766m, 3 },
                    { 94, 3, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0008614078674858490566037736m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1060, 1060.913092339535m, 4 },
                    { 95, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.298256661488547085201793722m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 892, 1158.044942047784m, 5 },
                    { 96, 3, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.184432289019704375667022412m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 937, 1109.813054811463m, 6 },
                    { 97, 4, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4765522534952468193384223919m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 786, 1160.570071247264m, 1 },
                    { 98, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2092568505094966313763233879m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1039, 1256.417867679367m, 2 },
                    { 99, 4, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8170930619460989345509893455m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 657, 1193.830141698587m, 3 },
                    { 100, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.380809604892112565445026178m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 764, 1054.938538137574m, 4 },
                    { 101, 4, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6574103761118135135135135135m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 740, 1226.483678322742m, 5 },
                    { 102, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0902799499570388726919339164m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1029, 1121.898068505793m, 6 },
                    { 103, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1596278632100827147401908802m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 943, 1093.529075007108m, 1 },
                    { 104, 3, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3566812434888144444444444444m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 900, 1221.013119139933m, 2 },
                    { 105, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6196175150298790436005625879m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 711, 1151.548053186244m, 3 },
                    { 106, 3, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3813503528608707213578500707m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 707, 976.6146994726356m, 4 },
                    { 107, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5314888023158669064748201439m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 834, 1277.261661131433m, 5 },
                    { 108, 3, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3683465321804796373779637378m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 717, 981.1044635734039m, 6 },
                    { 109, 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2256427176078243654822335025m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 985, 1207.258076843707m, 1 },
                    { 110, 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2821668410390404564315352697m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 964, 1236.008834761635m, 2 },
                    { 111, 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0433672672185204460966542751m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1076, 1122.663179527128m, 3 },
                    { 112, 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6612469885153473227206946454m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 691, 1147.921669064105m, 4 },
                    { 113, 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7775017863813953147877013177m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 683, 1214.033720098493m, 5 },
                    { 114, 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3708254326112676224611708483m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 837, 1147.380887095631m, 6 },
                    { 115, 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1156407904129451793721973094m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 892, 995.1515850483471m, 1 },
                    { 116, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0179576496365326848249027237m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1028, 1046.4604638263556m, 2 },
                    { 117, 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.184711947003694331983805668m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 988, 1170.49540363965m, 3 },
                    { 118, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2822535986450073606729758149m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 951, 1219.423172311402m, 4 },
                    { 119, 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.291283431795171875m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 960, 1239.632094523365m, 5 },
                    { 120, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2903507603797052280311457175m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 899, 1160.025333581355m, 6 },
                    { 121, 4, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2323055441195136612021857923m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 915, 1127.559572869355m, 1 },
                    { 122, 3, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1506680648958484939759036145m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 830, 955.05449386355425m, 2 },
                    { 123, 4, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5248232699605395778364116095m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 758, 1155.816038630089m, 3 },
                    { 124, 3, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4723852616443110504774897681m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 733, 1079.25839678528m, 4 },
                    { 125, 4, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4584520238303632130384167637m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 859, 1252.810288470282m, 5 },
                    { 126, 3, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3866681892572295755968169761m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 754, 1045.5478146999511m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 127, 4, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.280228456424369047619047619m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 840, 1075.39190339647m, 1 },
                    { 128, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1903077845553879222108495394m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 977, 1162.930705510614m, 2 },
                    { 129, 4, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.473757598831599537037037037m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 864, 1273.326565390502m, 3 },
                    { 130, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1169032581182658590308370044m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 908, 1014.1481583713854m, 4 },
                    { 131, 4, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.766223089100043656207366985m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 733, 1294.641524310332m, 5 },
                    { 132, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.309104516847053974358974359m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 780, 1021.1015231407021m, 6 },
                    { 133, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0725602457585381679389312977m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1048, 1124.043137554948m, 1 },
                    { 134, 3, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1052777483818169683257918552m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 884, 977.0655295695262m, 2 },
                    { 135, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1309860628224558270676691729m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1064, 1203.369170843093m, 3 },
                    { 136, 3, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2707282279053036553524804178m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 766, 973.3778225754626m, 4 },
                    { 137, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3817409125473329694323144105m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 916, 1265.674675893357m, 5 },
                    { 138, 3, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1587325225208096256684491979m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 935, 1083.414908556957m, 6 },
                    { 139, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2521758720866566820276497696m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 868, 1086.888656971218m, 1 },
                    { 140, 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3410481704997161997563946407m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 821, 1101.000547980267m, 2 },
                    { 141, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5763132404591216257668711656m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 652, 1027.7562327793473m, 3 },
                    { 142, 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6689822684791306597671410091m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 773, 1290.123293534368m, 4 },
                    { 143, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.156014063434249m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000, 1156.014063434249m, 5 },
                    { 144, 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.79492691327453003003003003m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 666, 1195.421324240837m, 6 },
                    { 145, 4, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0305204028839120772946859903m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1035, 1066.588616984849m, 1 },
                    { 146, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3179004658992155555555555556m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 900, 1186.110419309294m, 2 },
                    { 147, 4, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1993692770433117506297229219m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 794, 952.29920597238953m, 3 },
                    { 148, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.367743485040736046511627907m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 860, 1176.259397135033m, 4 },
                    { 149, 4, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3125103067553290460878885316m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 933, 1224.572116202722m, 5 },
                    { 150, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4272097032540915750915750916m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 819, 1168.884746965101m, 6 },
                    { 151, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6081374448599870801033591731m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 774, 1244.69838232163m, 1 },
                    { 152, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2011836564800135440180586907m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 886, 1064.248719641292m, 2 },
                    { 153, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9843676752856321285140562249m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 996, 980.4302045844896m, 3 },
                    { 154, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4119951024910834272829763247m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 887, 1252.439655909591m, 4 },
                    { 155, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3235216921768043478260869565m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 828, 1095.875961122394m, 5 },
                    { 156, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1175545363498793590951932139m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1061, 1185.725363067222m, 6 },
                    { 157, 4, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4771075136965949720670391061m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 716, 1057.608979806762m, 1 },
                    { 158, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3281136760824940047961630695m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 834, 1107.6468058528m, 2 },
                    { 159, 4, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.156206281823503448275862069m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1015, 1173.549376050856m, 3 },
                    { 160, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1446631438174067439409905163m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 949, 1086.285323482719m, 4 },
                    { 161, 4, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3737081875002103594080338266m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 946, 1299.527945375199m, 5 },
                    { 162, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6724532869835893648449039882m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 677, 1132.25087528789m, 6 },
                    { 163, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1931549430153086538461538462m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 832, 992.7049125887368m, 1 },
                    { 164, 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1508774069973476953907815631m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 998, 1148.575652183353m, 2 },
                    { 165, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3675655835925188374596340151m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 929, 1270.46842715745m, 3 },
                    { 166, 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5108914337387463672391017173m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 757, 1143.744815340231m, 4 },
                    { 167, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6957339101854375m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 672, 1139.533187644614m, 5 },
                    { 168, 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1453943104299835430784123911m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1033, 1183.192322674173m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 169, 4, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5069038875319174964438122333m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 1059.353432934938m, 1 },
                    { 170, 3, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8260407262198372093023255814m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 688, 1256.316019639248m, 2 },
                    { 171, 4, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.240546590303136969696969697m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 825, 1023.450937000088m, 3 },
                    { 172, 3, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0510880539066407129455909944m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1066, 1120.459865464479m, 4 },
                    { 173, 4, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1636147614456889908256880734m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1090, 1268.340089975801m, 5 },
                    { 174, 3, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0750560835964247982062780269m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 892, 958.95002656801092m, 6 },
                    { 175, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1976460499528869727047146402m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 806, 965.3027162620269m, 1 },
                    { 176, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.221924833698078740157480315m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 889, 1086.291177157592m, 2 },
                    { 177, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3357972569345832471561530507m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 967, 1291.715947455742m, 3 },
                    { 178, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4396778889939505747126436782m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 870, 1252.519763424737m, 4 },
                    { 179, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3385273619110171306209850107m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 934, 1250.18455602489m, 5 },
                    { 180, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3966336956572736842105263158m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 760, 1061.441608699528m, 6 },
                    { 181, 4, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3497900305253314285714285714m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 707, 954.30155158140932m, 1 },
                    { 182, 3, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8059634764648687589158345221m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 701, 1265.980397001873m, 2 },
                    { 183, 4, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5151711629833032012195121951m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 656, 993.9522829170469m, 3 },
                    { 184, 3, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4358927319203342140026420079m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 757, 1086.970798063693m, 4 },
                    { 185, 4, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.340089740385608324439701174m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 937, 1255.664086741315m, 5 },
                    { 186, 3, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2604913365073781609195402299m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 870, 1096.627462761419m, 6 },
                    { 187, 4, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6622023822543110814419225634m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 749, 1244.989584308479m, 1 },
                    { 188, 3, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6984622060304162962962962963m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 675, 1146.461989070531m, 2 },
                    { 189, 4, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9200269691506727443609022556m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1064, 978.9086951763158m, 3 },
                    { 190, 3, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2891836566575504685408299866m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 747, 963.0201915231902m, 4 },
                    { 191, 4, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0140453646072741324921135647m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 951, 964.3571417415177m, 5 },
                    { 192, 3, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2455516102095015706806282723m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 955, 1189.501787750074m, 6 },
                    { 193, 4, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1292780255686397058823529412m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 952, 1075.072680341345m, 1 },
                    { 194, 3, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2436315583642830694275274056m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 821, 1021.0215094170764m, 2 },
                    { 195, 4, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3869061766443807795698924731m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 744, 1031.8581954234193m, 3 },
                    { 196, 3, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6663123543620132450331125828m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 755, 1258.06582754332m, 4 },
                    { 197, 4, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.16957819036707421875m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1024, 1197.648066935884m, 5 },
                    { 198, 3, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3362827520887532327586206897m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 928, 1240.070393938363m, 6 },
                    { 199, 4, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.8853733380367734375m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1088, 963.2861917840095m, 1 },
                    { 200, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2847051949036065934065934066m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 910, 1169.081727362282m, 2 },
                    { 201, 4, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1809025310567115928369462771m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1061, 1252.937585451171m, 3 },
                    { 202, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1698044784334919191919191919m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 990, 1158.106433649157m, 4 },
                    { 203, 4, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8244930121943751846381093058m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 677, 1235.181769255592m, 5 },
                    { 204, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1060386050538977485928705441m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1066, 1179.037152987455m, 6 },
                    { 205, 4, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3650145568015395927601809955m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 884, 1206.672868212561m, 1 },
                    { 206, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1254141188055732484076433121m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1099, 1236.830116567325m, 2 },
                    { 207, 4, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3440066858738592592592592593m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 945, 1270.086318150797m, 3 },
                    { 208, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0746653244554058106841611996m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1067, 1146.667901193918m, 4 },
                    { 209, 4, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0762193874141880717488789238m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 892, 959.98769357345576m, 5 },
                    { 210, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2458156071646734317343173432m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 813, 1012.8480886248795m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 211, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1512552067975768169273229071m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1087, 1251.414409788966m, 1 },
                    { 212, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4146757947241934336525307798m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 731, 1034.1280059433854m, 2 },
                    { 213, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1908523536237669745958429561m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 866, 1031.2781382381822m, 3 },
                    { 214, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4682021543796500747384155456m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 669, 982.2272412799859m, 4 },
                    { 215, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3374303481173579175704989154m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 922, 1233.110780964204m, 5 },
                    { 216, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2122297842905047923322683706m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 939, 1138.283767448784m, 6 },
                    { 217, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3785229506830926143024618992m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 853, 1175.880076932678m, 1 },
                    { 218, 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.662724999648851063829787234m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 658, 1094.073049768944m, 2 },
                    { 219, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2402857619730731707317073171m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1025, 1271.2929060224m, 3 },
                    { 220, 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1168396309612634854771784232m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 964, 1076.633404246658m, 4 },
                    { 221, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4518044280580499359795134443m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 781, 1133.859258313337m, 5 },
                    { 222, 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1544804333005411298315163528m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1009, 1164.870757200246m, 6 },
                    { 223, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4591527436188830811554332875m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 727, 1060.804044610928m, 1 },
                    { 224, 3, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7075699928734979020979020979m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 715, 1220.912544904551m, 2 },
                    { 225, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8098274070505238095238095238m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 672, 1216.204017537952m, 3 },
                    { 226, 3, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2802472340969404494382022472m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 801, 1025.4780345116493m, 4 },
                    { 227, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2179417037025830687830687831m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 945, 1150.954909998941m, 5 },
                    { 228, 3, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.46585722443698531211750306m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 817, 1197.605352365017m, 6 },
                    { 229, 4, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6270812716561861111111111111m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 720, 1171.498515592454m, 1 },
                    { 230, 3, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1336024152469004024144869215m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 994, 1126.800800755419m, 2 },
                    { 231, 4, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3874220745058018648018648019m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 858, 1190.408139925978m, 3 },
                    { 232, 3, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4092149278018159268929503916m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 766, 1079.458634696191m, 4 },
                    { 233, 4, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0856204660273139653414882773m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 981, 1064.993677172795m, 5 },
                    { 234, 3, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5167889393325222772277227723m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 808, 1225.565462980678m, 6 },
                    { 235, 4, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0337171808961161290322580645m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1085, 1121.583141272286m, 1 },
                    { 236, 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7797561463405961272475795297m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 723, 1286.763693804251m, 2 },
                    { 237, 4, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5280530040832958083832335329m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 668, 1020.7394067276416m, 3 },
                    { 238, 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1602612624446866537717601547m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1034, 1199.710145367806m, 4 },
                    { 239, 4, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3291071062671233299075025694m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 973, 1293.221214397911m, 5 },
                    { 240, 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1434825777086857727737973388m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 977, 1117.182478421386m, 6 },
                    { 241, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6413274326276120689655172414m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 696, 1142.363893108818m, 1 },
                    { 242, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3774828495171182108626198083m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 939, 1293.456395696574m, 2 },
                    { 243, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.8982789492929964651162790698m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1075, 965.6498704899712m, 3 },
                    { 244, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3349844425317201540436456996m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 779, 1039.95288073221m, 4 },
                    { 245, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5667014906943416167664670659m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 668, 1046.5565957838202m, 5 },
                    { 246, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4093069320129168490153172867m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 914, 1288.106535859806m, 6 },
                    { 247, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0954326377210783545543584721m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1021, 1118.436723113221m, 1 },
                    { 248, 3, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9830084801909727024567788899m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1099, 1080.326319729879m, 2 },
                    { 249, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3868342325388573085846867749m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 862, 1195.451108448495m, 3 },
                    { 250, 3, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0566724990506284823284823285m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 962, 1016.5189440867046m, 4 },
                    { 251, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.002262203159734761441090555m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1027, 1029.3232826450476m, 5 },
                    { 252, 3, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5204744929142206896551724138m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 667, 1014.1564867737852m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 253, 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4047155650932411260709914321m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 817, 1147.652616681178m, 1 },
                    { 254, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0098396663601200799200799201m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1001, 1010.8495060264802m, 2 },
                    { 255, 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.053154754840539622641509434m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1060, 1116.344040130972m, 3 },
                    { 256, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0537246730184259086672879776m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1073, 1130.646574148771m, 4 },
                    { 257, 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3429007223872969325153374233m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 815, 1094.464088745647m, 5 },
                    { 258, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2325728277811696905016008538m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 937, 1154.920739630956m, 6 },
                    { 259, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.328920313856478488982161595m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 953, 1266.461059105224m, 1 },
                    { 260, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1880232158636920077972709552m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1026, 1218.911819476148m, 2 },
                    { 261, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1291995203482569316081330869m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1082, 1221.793881016814m, 3 },
                    { 262, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3541712715459125799573560768m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 938, 1270.212652710066m, 4 },
                    { 263, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.95307404104448779296875m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1024, 975.9478180295555m, 5 },
                    { 264, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2228884416134470198675496689m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 906, 1107.936928101783m, 6 },
                    { 265, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.266171222381772189349112426m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1014, 1283.897619495117m, 1 },
                    { 266, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0287669259582160611854684512m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1046, 1076.090204552294m, 2 },
                    { 267, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6451900427457879194630872483m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 745, 1225.666581845612m, 3 },
                    { 268, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2463556100230927939317319848m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 791, 985.8672875282664m, 4 },
                    { 269, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2154299806768841477949940405m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 839, 1019.7457537879058m, 5 },
                    { 270, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1348748275091981327800829876m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 964, 1094.019333718867m, 6 },
                    { 271, 4, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3706829380087440543601359003m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 883, 1210.313034261721m, 1 },
                    { 272, 3, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4576150815187827538247566064m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 719, 1048.0252436120048m, 2 },
                    { 273, 4, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1487787565713844714686623012m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1069, 1228.04449077481m, 3 },
                    { 274, 3, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0916178142021449559255631734m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1021, 1114.54178830039m, 4 },
                    { 275, 4, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0322626894822079581151832461m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 955, 985.8108684555086m, 5 },
                    { 276, 3, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1838192747208796095444685466m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 922, 1091.481371292651m, 6 },
                    { 277, 4, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7225873612731837672281776417m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 1124.849546911389m, 1 },
                    { 278, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5091291934882066115702479339m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 847, 1278.232426884511m, 2 },
                    { 279, 4, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7085514487581392757660167131m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 718, 1226.739940208344m, 3 },
                    { 280, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2961029813866997742663656885m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 886, 1148.347241508616m, 4 },
                    { 281, 4, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3798927185126320400500625782m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 1102.534282091593m, 5 },
                    { 282, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8706102157232177068214804064m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 689, 1288.850438633297m, 6 },
                    { 283, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1650791881280189031505250875m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 857, 998.4728642257122m, 1 },
                    { 284, 3, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2853530351530560700876095119m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 1026.9970750872918m, 2 },
                    { 285, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9696657809500443786982248521m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1014, 983.241101883345m, 3 },
                    { 286, 3, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4651812383872310549777117385m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 673, 986.0669734346065m, 4 },
                    { 287, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5115497970511946403385049365m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 709, 1071.688806109297m, 5 },
                    { 288, 3, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.135132330412523444976076555m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1045, 1186.213285281087m, 6 },
                    { 289, 4, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.315758559036269185360094451m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 847, 1114.44749950372m, 1 },
                    { 290, 3, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2609810929494878587196467991m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 906, 1142.448870212236m, 2 },
                    { 291, 4, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3147931495775269582909460834m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 983, 1292.441666034709m, 3 },
                    { 292, 3, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1387558338091736040609137056m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 985, 1121.674496302036m, 4 },
                    { 293, 4, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3029730618731574556830031283m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 959, 1249.551166336358m, 5 },
                    { 294, 3, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6926307091485870206489675516m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 678, 1147.603620802742m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 295, 4, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1468942348350478515625m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1024, 1174.419696471089m, 1 },
                    { 296, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4694585081761698895027624309m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 724, 1063.887959919547m, 2 },
                    { 297, 4, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4554388617130100729927007299m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 685, 996.9756202734119m, 3 },
                    { 298, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3097152546504199759326113117m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 831, 1088.373376614499m, 4 },
                    { 299, 4, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5289692594495724137931034483m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 725, 1108.50271310094m, 5 },
                    { 300, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4089613655614423076923076923m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 884, 1245.521847156315m, 6 },
                    { 301, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.494052529933977135980746089m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 831, 1241.557652375135m, 1 },
                    { 302, 3, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2265211315373850868232890705m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 979, 1200.7641877751m, 2 },
                    { 303, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.982739287192945873320537428m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1042, 1024.0143372550496m, 3 },
                    { 304, 3, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4385442694485458992805755396m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 695, 999.7882672667394m, 4 },
                    { 305, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1185141007635009174311926606m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1090, 1219.180369832216m, 5 },
                    { 306, 3, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2316858940025741728922091782m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 937, 1154.089682680412m, 6 },
                    { 307, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.554506287316617816091954023m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 696, 1081.936375972366m, 1 },
                    { 308, 3, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5350507427730159786950732357m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 751, 1152.823107822535m, 2 },
                    { 309, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2923009073617871657754010695m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 935, 1208.301348383271m, 3 },
                    { 310, 3, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4762552689617409879839786382m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 749, 1105.715196452344m, 4 },
                    { 311, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3971416261429566360052562418m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, 1063.22477749479m, 5 },
                    { 312, 3, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2356010891483231225296442688m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1012, 1250.428302218103m, 6 },
                    { 313, 4, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2414541041254900816802800467m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 857, 1063.926167235545m, 1 },
                    { 314, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0551281579812948717948717949m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1092, 1152.199948515574m, 2 },
                    { 315, 4, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8098796782634925149700598802m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 668, 1208.999625080013m, 3 },
                    { 316, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2169768411340343347639484979m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 932, 1134.22241593692m, 4 },
                    { 317, 4, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.391757751369711283185840708m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 904, 1258.149007238219m, 5 },
                    { 318, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0282192189136951292246520875m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1006, 1034.3885342271773m, 6 },
                    { 319, 4, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6532250416504281391830559758m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 661, 1092.781752530933m, 1 },
                    { 320, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3927914651243218514531754575m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 929, 1293.903271100495m, 2 },
                    { 321, 4, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1474904394977725823591923486m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 941, 1079.788503567404m, 3 },
                    { 322, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2573422932818014101057579318m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 851, 1069.998291582813m, 4 },
                    { 323, 4, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4725510024493807531380753138m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 717, 1055.819068756206m, 5 },
                    { 324, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7066079264572890932982917214m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, 1298.728632033997m, 6 },
                    { 325, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9263633095299365994236311239m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1041, 964.344205220664m, 1 },
                    { 326, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3224012247984645006016847172m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 831, 1098.915417807524m, 2 },
                    { 327, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2866691583336973651191969887m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 797, 1025.4753191919568m, 3 },
                    { 328, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.523289685981607185628742515m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 835, 1271.946887794642m, 4 },
                    { 329, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2011510310789742086752637749m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 853, 1024.581829510365m, 5 },
                    { 330, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1231148884873156312625250501m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 998, 1120.868658710341m, 6 },
                    { 331, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1784565615656096361848574238m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1017, 1198.490323112225m, 1 },
                    { 332, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0730964433277357370095440085m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 943, 1011.9299460580548m, 2 },
                    { 333, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4155362352579732558139534884m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 860, 1217.361162321857m, 3 },
                    { 334, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.508791959509895364238410596m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 755, 1139.137929429971m, 4 },
                    { 335, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0631990521652837338262476895m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1082, 1150.381374442837m, 5 },
                    { 336, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5734544703011480552070263488m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 797, 1254.043212830015m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 337, 4, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7569162609446895565092989986m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 1228.084466400338m, 1 },
                    { 338, 3, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1616839290458226066897347174m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 867, 1007.1799664827282m, 2 },
                    { 339, 4, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.410280135279321826280623608m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 898, 1266.431561480831m, 3 },
                    { 340, 3, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4002781290332650887573964497m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 845, 1183.235019033109m, 4 },
                    { 341, 4, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.74322012698978m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 700, 1220.254088892846m, 5 },
                    { 342, 3, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2004395648284198218262806236m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 898, 1077.994729215921m, 6 },
                    { 343, 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3661821774251766756032171582m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 746, 1019.1719043591818m, 1 },
                    { 344, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1546508405827997342995169082m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 828, 956.05089600255818m, 2 },
                    { 345, 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5995917198013536404160475483m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 673, 1076.525227426311m, 3 },
                    { 346, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1212936362740229545454545455m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 880, 986.7383999211402m, 4 },
                    { 347, 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8428269206131027496382054993m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 691, 1273.393402143654m, 5 },
                    { 348, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0530214475782739981360671016m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1073, 1129.892013251488m, 6 },
                    { 349, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.132017109358140641158221303m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 967, 1094.660544749322m, 1 },
                    { 350, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0447768377628356164383561644m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1022, 1067.761928193618m, 2 },
                    { 351, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0085519774300723562152133581m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1078, 1087.219031669618m, 3 },
                    { 352, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5040031339320671462829736211m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 834, 1254.338613699344m, 4 },
                    { 353, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0680948040104038638454461822m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1087, 1161.019051959309m, 5 },
                    { 354, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0137708121946052785923753666m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1023, 1037.0875408750812m, 6 },
                    { 355, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0853102464459948875255623722m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 978, 1061.433421024183m, 1 },
                    { 356, 3, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1613931890813604531410916581m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 971, 1127.712786598001m, 2 },
                    { 357, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7960165371296002766251728907m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 723, 1298.519956344701m, 3 },
                    { 358, 3, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4173719441516122448979591837m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 686, 972.317153688006m, 4 },
                    { 359, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.741222301739271830985915493m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 710, 1236.267834234883m, 5 },
                    { 360, 3, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5885058416608948106591865358m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 1132.604665104218m, 6 },
                    { 361, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1225397030009643861293345829m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1067, 1197.749863102029m, 1 },
                    { 362, 3, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3000365847274891551071878941m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 793, 1030.9290116888989m, 2 },
                    { 363, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0207340652633123940677966102m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 944, 963.5729576085669m, 3 },
                    { 364, 3, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2195566401725342042755344418m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 842, 1026.8666910252738m, 4 },
                    { 365, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1859721831239905063291139241m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 948, 1124.301629601543m, 5 },
                    { 366, 3, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2674362108748495092693565976m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 917, 1162.239005372237m, 6 },
                    { 367, 4, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3475315644179650423728813559m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 944, 1272.069796810559m, 1 },
                    { 368, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.321071600877090176322418136m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 794, 1048.9308510964096m, 2 },
                    { 369, 4, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0345599992394152734778121775m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 969, 1002.4886392629934m, 3 },
                    { 370, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4548238951511098901098901099m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 819, 1191.500770128759m, 4 },
                    { 371, 4, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1048306986272947173308619092m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1079, 1192.112323818851m, 5 },
                    { 372, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3016781527953153759820426487m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 891, 1159.795234140626m, 6 },
                    { 373, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6378669915206306429548563611m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 731, 1197.280770801581m, 1 },
                    { 374, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6938990647911222056631892697m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 671, 1136.606272474843m, 2 },
                    { 375, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.999886233009583274244004171m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 959, 958.89089745619036m, 3 },
                    { 376, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3251963624002494407158836689m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 894, 1184.725547985823m, 4 },
                    { 377, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7153004788399521674140508221m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 669, 1147.536020343928m, 5 },
                    { 378, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.53016031068968125m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 800, 1224.128248551745m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 379, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2466708253124241706161137441m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 844, 1052.190176563686m, 1 },
                    { 380, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0778374018196274900398406375m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1004, 1082.148751426906m, 2 },
                    { 381, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0371751102962229357798165138m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1090, 1130.520870222883m, 3 },
                    { 382, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2007210022766146881287726358m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 994, 1193.516676262955m, 4 },
                    { 383, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2749064060362358916478555305m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 886, 1129.567075748105m, 5 },
                    { 384, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3486700917857469586374695864m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 822, 1108.606815447884m, 6 },
                    { 385, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0913240756414975141242937853m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 885, 965.8218069427253m, 1 },
                    { 386, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2617050337849621656050955414m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 785, 990.4384515211953m, 2 },
                    { 387, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2085383146243681592039800995m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1005, 1214.58100619749m, 3 },
                    { 388, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1620647299440297448359659781m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 823, 956.37927274393648m, 4 },
                    { 389, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2079128874616168623265741729m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 937, 1131.814375551535m, 5 },
                    { 390, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2599532432509887816646562123m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 829, 1044.5012386550697m, 6 },
                    { 391, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4028022344523099547511312217m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 884, 1240.077175255842m, 1 },
                    { 392, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5030560320794303964757709251m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 681, 1023.5811578460921m, 2 },
                    { 393, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1945488575549686346863468635m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1084, 1294.890961589586m, 3 },
                    { 394, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0319319809111490928495197439m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 937, 966.9202661137467m, 4 },
                    { 395, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.213157016486214859437751004m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 996, 1208.30438842027m, 5 },
                    { 396, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2854718088624312749003984064m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1004, 1290.613696097881m, 6 },
                    { 397, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0619830549819441239316239316m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 936, 994.0161394630997m, 1 },
                    { 398, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2457879669020576735092864125m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1023, 1274.441090140805m, 2 },
                    { 399, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5406039550801921708185053381m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 843, 1298.729134132602m, 3 },
                    { 400, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1987224301050734463276836158m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1062, 1273.043220771588m, 4 },
                    { 401, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4216785805525368495077355837m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 711, 1010.8134707728537m, 5 },
                    { 402, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0816160216813508594539939333m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 989, 1069.718245442856m, 6 },
                    { 403, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3674662002520031746031746032m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 756, 1033.8044473905144m, 1 },
                    { 404, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6127412026115052160953800298m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 671, 1082.14934695232m, 2 },
                    { 405, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2711736738074182194616977226m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 966, 1227.953768897966m, 3 },
                    { 406, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4362365803197554396423248882m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 671, 963.7147453945559m, 4 },
                    { 407, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.92849556908408134810710988m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1083, 1005.5607013180601m, 5 },
                    { 408, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.159114563060150599520383693m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 834, 966.7015455921656m, 6 },
                    { 409, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3265168945914424895688456189m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 719, 953.76564721124715m, 1 },
                    { 410, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5446977972117990811638591118m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 1008.6876615793048m, 2 },
                    { 411, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1955201483301346153846153846m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 884, 1056.839811123839m, 3 },
                    { 412, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1534977954131201117318435754m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1074, 1238.856632273691m, 4 },
                    { 413, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3946453844314771634615384615m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 832, 1160.344959846989m, 5 },
                    { 414, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.188029313165228789323164919m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1049, 1246.242749510325m, 6 },
                    { 415, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4393148144723990182328190743m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 713, 1026.2314627188205m, 1 },
                    { 416, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7524213818730073529411764706m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 680, 1191.646539673645m, 2 },
                    { 417, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0914723653114880838894184938m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1049, 1144.954511211751m, 3 },
                    { 418, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3385734608375640583554376658m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 754, 1009.2843894715233m, 4 },
                    { 419, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.063925376242551410373066424m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1099, 1169.253988490564m, 5 },
                    { 420, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0811109616958521825396825397m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1008, 1089.759849389419m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 421, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0938438015226396648044692737m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1074, 1174.788242835315m, 1 },
                    { 422, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1811557159011996336996336996m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 819, 967.3665313230825m, 2 },
                    { 423, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6997194440923806896551724138m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 725, 1232.296596966976m, 3 },
                    { 424, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0367844444029341983317886932m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1079, 1118.690415510766m, 4 },
                    { 425, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2130883648164253897550111359m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 898, 1089.35335160515m, 5 },
                    { 426, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0353481327811894639556377079m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1082, 1120.246679669247m, 6 },
                    { 427, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1431678620088997799779977998m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 909, 1039.1395865660899m, 1 },
                    { 428, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9553701444234029250457038391m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1094, 1045.1749379992028m, 2 },
                    { 429, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9251224100116983154670750383m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 1257.104933737639m, 3 },
                    { 430, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0980210854371144318181818182m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 880, 966.2585551846607m, 4 },
                    { 431, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3128066011864213483146067416m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 890, 1168.397875055915m, 5 },
                    { 432, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2063526009260157657657657658m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 888, 1071.241109622302m, 6 },
                    { 433, 4, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8592508484814737609329446064m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 686, 1275.446082058291m, 1 },
                    { 434, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9950462601450764948453608247m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 970, 965.1948723407242m, 2 },
                    { 435, 4, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5873253893473955223880597015m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 670, 1063.508010862755m, 3 },
                    { 436, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2868341341223611688311688312m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 770, 990.8622832742181m, 4 },
                    { 437, 4, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5389003285840874471086036671m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 709, 1091.080332966118m, 5 },
                    { 438, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5724101016725333333333333333m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 720, 1132.135273204224m, 6 },
                    { 439, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.414480588140132871012482663m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 721, 1019.8405040490358m, 1 },
                    { 440, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9939643017108046728971962617m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1070, 1063.541802830561m, 2 },
                    { 441, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8103888801437262247838616715m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, 1256.409882819746m, 3 },
                    { 442, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3280216627388485958485958486m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 819, 1087.649741783117m, 4 },
                    { 443, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2124508378452557127312295974m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 919, 1114.24231997979m, 5 },
                    { 444, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7766213366628381240544629349m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 661, 1174.346703534136m, 6 },
                    { 445, 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4703725154182768901569186876m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 701, 1030.7311333082121m, 1 },
                    { 446, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0778888577017349397590361446m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1079, 1163.042077460172m, 2 },
                    { 447, 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0605751933761582452431289641m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 946, 1003.3041329338457m, 3 },
                    { 448, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0405102882440345821325648415m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1041, 1083.17121006204m, 4 },
                    { 449, 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8143869954991253644314868805m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 686, 1244.6694789124m, 5 },
                    { 450, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3999584722519911991199119912m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 909, 1272.56225127706m, 6 },
                    { 451, 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9931178655224542168674698795m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 996, 989.1453940603644m, 1 },
                    { 452, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2378767437465127952755905512m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1016, 1257.682771646457m, 2 },
                    { 453, 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1921835307995686936936936937m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 888, 1058.658975350017m, 3 },
                    { 454, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.175276989586933920704845815m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 908, 1067.151506544936m, 4 },
                    { 455, 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5454152478856927297668038409m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 729, 1126.60771570867m, 5 },
                    { 456, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2742601151765323741007194245m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 834, 1062.732936057228m, 6 },
                    { 457, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5153979827139468599033816425m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 828, 1254.749529687148m, 1 },
                    { 458, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4442736813777223201174743025m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 681, 983.5503770182289m, 2 },
                    { 459, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9075443319469852428964252979m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1091, 990.1308661541609m, 3 },
                    { 460, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0009085632496500461680517082m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1083, 1083.983973999371m, 4 },
                    { 461, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2498407532958178096212896622m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 977, 1221.094415970014m, 5 },
                    { 462, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2472748537463875305623471883m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 818, 1020.270830364545m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 463, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0682210247185764285714285714m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 980, 1046.8566042242049m, 1 },
                    { 464, 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3942130492554112343966712899m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 721, 1005.2276085131515m, 2 },
                    { 465, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5603031882829739368998628258m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 729, 1137.461024258288m, 3 },
                    { 466, 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1944858584552859922178988327m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1028, 1227.931462492034m, 4 },
                    { 467, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6372292925652002861230329041m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 1144.423275503075m, 5 },
                    { 468, 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1215120265126552026286966046m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 913, 1023.9404802060542m, 6 },
                    { 469, 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1631735939735580487804878049m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1025, 1192.252933822897m, 1 },
                    { 470, 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4452697678693685446009389671m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 852, 1231.369842224702m, 2 },
                    { 471, 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4684258089929441277080957811m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 877, 1287.809434486812m, 3 },
                    { 472, 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5298444431718435544430538173m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 1222.345710094303m, 4 },
                    { 473, 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1781076957976466739367502726m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 917, 1080.324757046442m, 5 },
                    { 474, 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0213991664060131086142322097m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1068, 1090.854309721622m, 6 },
                    { 475, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6103014850508823529411764706m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 714, 1149.75526032633m, 1 },
                    { 476, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6283158559474718019257221458m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 727, 1183.785627273812m, 2 },
                    { 477, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6781427496112420749279538905m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, 1164.631068230202m, 3 },
                    { 478, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.110698361004509861932938856m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1014, 1126.248138058573m, 4 },
                    { 479, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1882816694398073770491803279m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 976, 1159.762909373252m, 5 },
                    { 480, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.541688498012924223602484472m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 805, 1241.059240900404m, 6 },
                    { 481, 4, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3683628240591605758582502769m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 903, 1235.631630125422m, 1 },
                    { 482, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4923784224634234354194407457m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 751, 1120.776195270031m, 2 },
                    { 483, 4, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0757959445099036919831223629m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 948, 1019.8545553953887m, 3 },
                    { 484, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4053834057563659400544959128m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 734, 1031.5514198251726m, 4 },
                    { 485, 4, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9895534271428446327683615819m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1062, 1050.905739625701m, 5 },
                    { 486, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.153736351145638971315529179m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1011, 1166.427451008241m, 6 },
                    { 487, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1070254986947706484641638225m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 879, 973.0754133527034m, 1 },
                    { 488, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4413825213546529801324503311m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 755, 1088.243803622763m, 2 },
                    { 489, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9946752827555895795246800731m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1094, 1088.174759334615m, 3 },
                    { 490, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4171640868860807313642756681m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 711, 1007.6036657760034m, 4 },
                    { 491, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0578420150857166513339466421m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1087, 1149.874270398174m, 5 },
                    { 492, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1808895232763651050679851669m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 809, 955.33962433057937m, 6 },
                    { 493, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7165746763847064471879286694m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 729, 1251.382939084451m, 1 },
                    { 494, 3, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.262706484432546681664791901m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 889, 1122.546064660534m, 2 },
                    { 495, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.576722789619660431654676259m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 695, 1095.822338785664m, 3 },
                    { 496, 3, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3049712410028346111719605696m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 913, 1191.438743035588m, 4 },
                    { 497, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2456588477548283767038413879m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 807, 1005.2466901381465m, 5 },
                    { 498, 3, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3752780338334330794341675734m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 919, 1263.880513092925m, 6 },
                    { 499, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0533727794075158806544754572m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1039, 1094.454317804409m, 1 },
                    { 500, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5059541808516077922077922078m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 770, 1159.584719255738m, 2 },
                    { 501, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1659714036561876760563380282m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 852, 993.4076359150719m, 3 },
                    { 502, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1458735077785900104058272633m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 961, 1101.184440975225m, 4 },
                    { 503, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9654126450290510284035259549m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1021, 985.6863105746611m, 5 },
                    { 504, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1787354721188002008032128514m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 996, 1174.020530230325m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 505, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2056567270586392694063926941m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 876, 1056.155292903368m, 1 },
                    { 506, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1196891895498537054860442733m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1039, 1163.357067942298m, 2 },
                    { 507, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1793596487744476730987514188m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 881, 1039.0158505702884m, 3 },
                    { 508, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2396716675567938209331651955m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 793, 983.0596323725375m, 4 },
                    { 509, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2692456102661123304562268804m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 811, 1029.3581899258171m, 5 },
                    { 510, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2229632005672740963855421687m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 996, 1218.071347765005m, 6 },
                    { 511, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.33617087802765633608815427m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 726, 970.0600574480785m, 1 },
                    { 512, 3, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9856316970200803405572755418m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 969, 955.07711441245785m, 2 },
                    { 513, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0500489202020549662487945998m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1037, 1088.900730249531m, 3 },
                    { 514, 3, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0267146664054142857142857143m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1050, 1078.050399725685m, 4 },
                    { 515, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3048428239598452520515826495m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 853, 1113.030928837748m, 5 },
                    { 516, 3, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9346503552884557779799818016m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1099, 1027.1807404620129m, 6 },
                    { 517, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5519511474030058565153733529m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 683, 1059.982633676253m, 1 },
                    { 518, 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1700045478753168361581920904m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 885, 1035.4540248696554m, 2 },
                    { 519, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.227110646833223620522749274m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1033, 1267.60529817872m, 3 },
                    { 520, 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.512772325442120918984280532m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 827, 1251.062713140634m, 4 },
                    { 521, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3678504863926057803468208092m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 865, 1183.190670729604m, 5 },
                    { 522, 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3600834141461580928481806775m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 797, 1083.986481074488m, 6 },
                    { 523, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0975571039786748216106014271m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 981, 1076.70351900308m, 1 },
                    { 524, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4880181536517980295566502463m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 812, 1208.27074076526m, 2 },
                    { 525, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9668712219464877057115198451m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1033, 998.7779722707218m, 3 },
                    { 526, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2146759896044391414141414141m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 792, 962.0233837667158m, 4 },
                    { 527, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6494271281820106544901065449m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 657, 1083.673623215581m, 5 },
                    { 528, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9030556088168781575037147103m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 673, 1280.756424733759m, 6 },
                    { 529, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1707714161269936893203883495m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 824, 964.7156468886428m, 1 },
                    { 530, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8816279441567142857142857143m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 679, 1277.625374082409m, 2 },
                    { 531, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6263525426733924870466321244m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 772, 1255.544162943859m, 3 },
                    { 532, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1314999359600492813141683778m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 974, 1102.080937625088m, 4 },
                    { 533, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4948544921183132694938440492m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 731, 1092.738633738487m, 5 },
                    { 534, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1917311552730275058275058275m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 858, 1022.5053312242576m, 6 },
                    { 535, 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4161718528462642369020501139m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 878, 1243.39888679902m, 1 },
                    { 536, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4071029322349152542372881356m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 826, 1162.26702202604m, 2 },
                    { 537, 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5181264089559734513274336283m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 678, 1029.28970527215m, 3 },
                    { 538, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5659404653130868945868945869m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 702, 1099.290206649787m, 4 },
                    { 539, 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2767242436029950149551345962m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1003, 1280.554416333804m, 5 },
                    { 540, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3543820692160571428571428571m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 840, 1137.680938141488m, 6 }
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
                    { 6, 3100.00m, 3, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Fuel in June 2023", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "TruckExpenses",
                columns: new[] { "Id", "Amount", "EmployeeId", "ExpenseDate", "Notes", "TruckId", "Type" },
                values: new object[,]
                {
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
                    { 36, 2700.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - DriverSalary in July 2023", 3, 3 },
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
                    { 48, 2700.00m, 4, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in July 2023", 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "TruckExpenses",
                columns: new[] { "Id", "Amount", "EmployeeId", "ExpenseDate", "Notes", "TruckId", "Type" },
                values: new object[,]
                {
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
                    { 78, 3100.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Fuel in September 2023", 2, 1 },
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
                    { 90, 3100.00m, 4, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Fuel in September 2023", 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "TruckExpenses",
                columns: new[] { "Id", "Amount", "EmployeeId", "ExpenseDate", "Notes", "TruckId", "Type" },
                values: new object[,]
                {
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
                    { 120, 2700.00m, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in October 2023", 6, 3 },
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
                    { 132, 2700.00m, 4, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - DriverSalary in November 2023", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "TruckExpenses",
                columns: new[] { "Id", "Amount", "EmployeeId", "ExpenseDate", "Notes", "TruckId", "Type" },
                values: new object[,]
                {
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
                    { 162, 3100.00m, 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 5 - Fuel in December 2023", 5, 1 },
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
                    { 174, 3100.00m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 2 - Fuel in January 2024", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "TruckExpenses",
                columns: new[] { "Id", "Amount", "EmployeeId", "ExpenseDate", "Notes", "TruckId", "Type" },
                values: new object[,]
                {
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
                    { 204, 2700.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 3 - DriverSalary in February 2024", 3, 3 },
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
                    { 216, 2700.00m, 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in February 2024", 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "TruckExpenses",
                columns: new[] { "Id", "Amount", "EmployeeId", "ExpenseDate", "Notes", "TruckId", "Type" },
                values: new object[,]
                {
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
                    { 240, 2700.00m, 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expense for truck 6 - DriverSalary in March 2024", 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1038.4864095760829m, 1 },
                    { 2, 10, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1238.569711331394m, 2 },
                    { 3, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1121.11217791632m, 3 },
                    { 4, 7, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1040.3425103172348m, 4 },
                    { 5, 7, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1120.722871706029m, 5 },
                    { 6, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1043.5341767519087m, 6 },
                    { 7, 1, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1223.530961114618m, 7 },
                    { 8, 5, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1282.30680016365m, 8 },
                    { 9, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1118.454647525396m, 9 },
                    { 10, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1054.384982080551m, 10 },
                    { 11, 8, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1293.443687541663m, 11 },
                    { 12, 10, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1039.5645322992324m, 12 },
                    { 13, 10, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1268.217861059083m, 13 },
                    { 14, 6, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 967.2472116875616m, 14 },
                    { 15, 1, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1250.794883928565m, 15 },
                    { 16, 3, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1009.1569223270349m, 16 },
                    { 17, 1, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1273.932052166368m, 17 },
                    { 18, 9, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1110.206442539864m, 18 },
                    { 19, 2, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1189.330596940348m, 19 },
                    { 20, 6, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1257.548854260989m, 20 },
                    { 21, 8, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1283.517361358805m, 21 },
                    { 22, 10, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1162.362994633582m, 22 },
                    { 23, 6, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1221.490612524867m, 23 },
                    { 24, 8, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1112.610229218556m, 24 },
                    { 25, 5, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1237.120565645192m, 25 },
                    { 26, 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1153.025487897274m, 26 },
                    { 27, 9, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1211.965971337566m, 27 },
                    { 28, 10, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 977.2431212643813m, 28 },
                    { 29, 10, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1254.348475545016m, 29 },
                    { 30, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1199.788116780878m, 30 },
                    { 31, 2, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1129.739000639553m, 31 },
                    { 32, 9, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1045.2345455933353m, 32 },
                    { 33, 10, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1178.302130084166m, 33 },
                    { 34, 8, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1288.169010718578m, 34 },
                    { 35, 6, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1112.724437989551m, 35 },
                    { 36, 1, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1123.610601281777m, 36 },
                    { 37, 2, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1104.125491110935m, 37 },
                    { 38, 1, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1182.149551562735m, 38 },
                    { 39, 1, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1249.263396547276m, 39 },
                    { 40, 1, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1026.3545957227846m, 40 },
                    { 41, 6, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1067.28018113916m, 41 },
                    { 42, 9, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 987.3095621215562m, 42 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 43, 8, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1114.050677395397m, 43 },
                    { 44, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1250.263347444158m, 44 },
                    { 45, 5, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1071.764448779072m, 45 },
                    { 46, 1, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1175.920514498338m, 46 },
                    { 47, 7, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1096.390368833112m, 47 },
                    { 48, 5, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1107.231982237791m, 48 },
                    { 49, 2, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1171.56208677374m, 49 },
                    { 50, 9, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1106.984474325781m, 50 },
                    { 51, 3, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 989.3450923930728m, 51 },
                    { 52, 10, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1091.451947824335m, 52 },
                    { 53, 4, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1274.586576342304m, 53 },
                    { 54, 4, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1063.449814702041m, 54 },
                    { 55, 10, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1071.702218331294m, 55 },
                    { 56, 5, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1240.31544695072m, 56 },
                    { 57, 2, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1169.323989370448m, 57 },
                    { 58, 4, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 955.88722740834664m, 58 },
                    { 59, 9, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1281.379514585582m, 59 },
                    { 60, 1, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 978.7163907237254m, 60 },
                    { 61, 9, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1259.106458440143m, 61 },
                    { 62, 7, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1035.3873053085911m, 62 },
                    { 63, 5, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1230.891121496706m, 63 },
                    { 64, 10, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1298.604333911758m, 64 },
                    { 65, 7, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1222.585417773048m, 65 },
                    { 66, 7, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1026.2239448990946m, 66 },
                    { 67, 9, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1083.382040368998m, 67 },
                    { 68, 9, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1079.790133859103m, 68 },
                    { 69, 9, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1152.391126895999m, 69 },
                    { 70, 8, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1107.421585733115m, 70 },
                    { 71, 6, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1225.546458946782m, 71 },
                    { 72, 2, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1244.037862577297m, 72 },
                    { 73, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1143.51533734991m, 73 },
                    { 74, 6, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1286.221440789082m, 74 },
                    { 75, 6, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1245.464529079109m, 75 },
                    { 76, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1237.686149222184m, 76 },
                    { 77, 2, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 997.545260933218m, 77 },
                    { 78, 8, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1197.922249845789m, 78 },
                    { 79, 5, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1128.89220607094m, 79 },
                    { 80, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1245.842526893943m, 80 },
                    { 81, 7, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1141.728919165846m, 81 },
                    { 82, 2, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1257.252262545993m, 82 },
                    { 83, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1142.80904640726m, 83 },
                    { 84, 6, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1298.618773366056m, 84 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 85, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1175.228331640241m, 85 },
                    { 86, 6, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1280.084092870479m, 86 },
                    { 87, 9, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1154.894592153269m, 87 },
                    { 88, 8, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1055.340300622258m, 88 },
                    { 89, 7, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1211.358996925588m, 89 },
                    { 90, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 966.3896411923011m, 90 },
                    { 91, 2, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1145.079873026652m, 91 },
                    { 92, 6, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1008.2319329293788m, 92 },
                    { 93, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1194.515736895766m, 93 },
                    { 94, 7, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1060.913092339535m, 94 },
                    { 95, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1158.044942047784m, 95 },
                    { 96, 5, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1109.813054811463m, 96 },
                    { 97, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1160.570071247264m, 97 },
                    { 98, 6, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1256.417867679367m, 98 },
                    { 99, 8, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1193.830141698587m, 99 },
                    { 100, 9, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1054.938538137574m, 100 },
                    { 101, 8, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1226.483678322742m, 101 },
                    { 102, 7, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1121.898068505793m, 102 },
                    { 103, 8, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1093.529075007108m, 103 },
                    { 104, 7, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1221.013119139933m, 104 },
                    { 105, 5, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1151.548053186244m, 105 },
                    { 106, 8, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 976.6146994726356m, 106 },
                    { 107, 3, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1277.261661131433m, 107 },
                    { 108, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 981.1044635734039m, 108 },
                    { 109, 6, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1207.258076843707m, 109 },
                    { 110, 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1236.008834761635m, 110 },
                    { 111, 1, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1122.663179527128m, 111 },
                    { 112, 2, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1147.921669064105m, 112 },
                    { 113, 1, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1214.033720098493m, 113 },
                    { 114, 7, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1147.380887095631m, 114 },
                    { 115, 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 995.1515850483471m, 115 },
                    { 116, 10, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1046.4604638263556m, 116 },
                    { 117, 6, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1170.49540363965m, 117 },
                    { 118, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1219.423172311402m, 118 },
                    { 119, 10, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1239.632094523365m, 119 },
                    { 120, 7, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1160.025333581355m, 120 },
                    { 121, 6, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1127.559572869355m, 121 },
                    { 122, 3, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 955.05449386355425m, 122 },
                    { 123, 5, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1155.816038630089m, 123 },
                    { 124, 9, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1079.25839678528m, 124 },
                    { 125, 9, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1252.810288470282m, 125 },
                    { 126, 10, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1045.5478146999511m, 126 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 127, 6, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1075.39190339647m, 127 },
                    { 128, 9, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1162.930705510614m, 128 },
                    { 129, 6, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1273.326565390502m, 129 },
                    { 130, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1014.1481583713854m, 130 },
                    { 131, 2, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1294.641524310332m, 131 },
                    { 132, 6, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1021.1015231407021m, 132 },
                    { 133, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1124.043137554948m, 133 },
                    { 134, 5, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 977.0655295695262m, 134 },
                    { 135, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1203.369170843093m, 135 },
                    { 136, 1, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 973.3778225754626m, 136 },
                    { 137, 9, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1265.674675893357m, 137 },
                    { 138, 10, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1083.414908556957m, 138 },
                    { 139, 5, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1086.888656971218m, 139 },
                    { 140, 5, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1101.000547980267m, 140 },
                    { 141, 7, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1027.7562327793473m, 141 },
                    { 142, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1290.123293534368m, 142 },
                    { 143, 2, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1156.014063434249m, 143 },
                    { 144, 5, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1195.421324240837m, 144 },
                    { 145, 7, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1066.588616984849m, 145 },
                    { 146, 1, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1186.110419309294m, 146 },
                    { 147, 5, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 952.29920597238953m, 147 },
                    { 148, 2, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1176.259397135033m, 148 },
                    { 149, 5, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1224.572116202722m, 149 },
                    { 150, 10, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1168.884746965101m, 150 },
                    { 151, 5, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1244.69838232163m, 151 },
                    { 152, 6, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1064.248719641292m, 152 },
                    { 153, 5, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 980.4302045844896m, 153 },
                    { 154, 7, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1252.439655909591m, 154 },
                    { 155, 8, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1095.875961122394m, 155 },
                    { 156, 8, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1185.725363067222m, 156 },
                    { 157, 5, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1057.608979806762m, 157 },
                    { 158, 8, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1107.6468058528m, 158 },
                    { 159, 8, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1173.549376050856m, 159 },
                    { 160, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1086.285323482719m, 160 },
                    { 161, 9, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1299.527945375199m, 161 },
                    { 162, 1, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1132.25087528789m, 162 },
                    { 163, 7, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 992.7049125887368m, 163 },
                    { 164, 8, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1148.575652183353m, 164 },
                    { 165, 5, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1270.46842715745m, 165 },
                    { 166, 5, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1143.744815340231m, 166 },
                    { 167, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1139.533187644614m, 167 },
                    { 168, 6, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1183.192322674173m, 168 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 169, 3, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1059.353432934938m, 169 },
                    { 170, 2, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1256.316019639248m, 170 },
                    { 171, 7, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1023.450937000088m, 171 },
                    { 172, 10, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1120.459865464479m, 172 },
                    { 173, 7, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1268.340089975801m, 173 },
                    { 174, 4, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 958.95002656801092m, 174 },
                    { 175, 6, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 965.3027162620269m, 175 },
                    { 176, 2, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1086.291177157592m, 176 },
                    { 177, 10, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1291.715947455742m, 177 },
                    { 178, 2, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1252.519763424737m, 178 },
                    { 179, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1250.18455602489m, 179 },
                    { 180, 6, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1061.441608699528m, 180 },
                    { 181, 6, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 954.30155158140932m, 181 },
                    { 182, 8, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1265.980397001873m, 182 },
                    { 183, 1, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 993.9522829170469m, 183 },
                    { 184, 9, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1086.970798063693m, 184 },
                    { 185, 9, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1255.664086741315m, 185 },
                    { 186, 2, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1096.627462761419m, 186 },
                    { 187, 8, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1244.989584308479m, 187 },
                    { 188, 9, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1146.461989070531m, 188 },
                    { 189, 7, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 978.9086951763158m, 189 },
                    { 190, 6, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 963.0201915231902m, 190 },
                    { 191, 2, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 964.3571417415177m, 191 },
                    { 192, 7, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1189.501787750074m, 192 },
                    { 193, 7, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1075.072680341345m, 193 },
                    { 194, 4, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1021.0215094170764m, 194 },
                    { 195, 7, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1031.8581954234193m, 195 },
                    { 196, 5, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1258.06582754332m, 196 },
                    { 197, 9, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1197.648066935884m, 197 },
                    { 198, 8, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1240.070393938363m, 198 },
                    { 199, 2, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 963.2861917840095m, 199 },
                    { 200, 10, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1169.081727362282m, 200 },
                    { 201, 7, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1252.937585451171m, 201 },
                    { 202, 10, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1158.106433649157m, 202 },
                    { 203, 8, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1235.181769255592m, 203 },
                    { 204, 6, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1179.037152987455m, 204 },
                    { 205, 4, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1206.672868212561m, 205 },
                    { 206, 6, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1236.830116567325m, 206 },
                    { 207, 5, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1270.086318150797m, 207 },
                    { 208, 2, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1146.667901193918m, 208 },
                    { 209, 8, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 959.98769357345576m, 209 },
                    { 210, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1012.8480886248795m, 210 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 211, 9, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1251.414409788966m, 211 },
                    { 212, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1034.1280059433854m, 212 },
                    { 213, 2, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1031.2781382381822m, 213 },
                    { 214, 7, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 982.2272412799859m, 214 },
                    { 215, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1233.110780964204m, 215 },
                    { 216, 5, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1138.283767448784m, 216 },
                    { 217, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1175.880076932678m, 217 },
                    { 218, 2, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1094.073049768944m, 218 },
                    { 219, 2, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1271.2929060224m, 219 },
                    { 220, 8, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1076.633404246658m, 220 },
                    { 221, 6, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1133.859258313337m, 221 },
                    { 222, 5, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1164.870757200246m, 222 },
                    { 223, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1060.804044610928m, 223 },
                    { 224, 5, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1220.912544904551m, 224 },
                    { 225, 8, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1216.204017537952m, 225 },
                    { 226, 5, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1025.4780345116493m, 226 },
                    { 227, 1, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1150.954909998941m, 227 },
                    { 228, 8, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1197.605352365017m, 228 },
                    { 229, 10, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1171.498515592454m, 229 },
                    { 230, 9, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1126.800800755419m, 230 },
                    { 231, 6, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1190.408139925978m, 231 },
                    { 232, 7, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1079.458634696191m, 232 },
                    { 233, 5, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1064.993677172795m, 233 },
                    { 234, 2, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1225.565462980678m, 234 },
                    { 235, 5, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1121.583141272286m, 235 },
                    { 236, 7, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1286.763693804251m, 236 },
                    { 237, 10, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1020.7394067276416m, 237 },
                    { 238, 9, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1199.710145367806m, 238 },
                    { 239, 1, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1293.221214397911m, 239 },
                    { 240, 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1117.182478421386m, 240 },
                    { 241, 1, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1142.363893108818m, 241 },
                    { 242, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1293.456395696574m, 242 },
                    { 243, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 965.6498704899712m, 243 },
                    { 244, 2, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1039.95288073221m, 244 },
                    { 245, 10, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1046.5565957838202m, 245 },
                    { 246, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1288.106535859806m, 246 },
                    { 247, 6, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1118.436723113221m, 247 },
                    { 248, 3, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1080.326319729879m, 248 },
                    { 249, 5, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1195.451108448495m, 249 },
                    { 250, 7, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1016.5189440867046m, 250 },
                    { 251, 8, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1029.3232826450476m, 251 },
                    { 252, 1, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1014.1564867737852m, 252 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 253, 9, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1147.652616681178m, 253 },
                    { 254, 6, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1010.8495060264802m, 254 },
                    { 255, 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1116.344040130972m, 255 },
                    { 256, 7, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1130.646574148771m, 256 },
                    { 257, 6, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1094.464088745647m, 257 },
                    { 258, 6, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1154.920739630956m, 258 },
                    { 259, 8, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1266.461059105224m, 259 },
                    { 260, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1218.911819476148m, 260 },
                    { 261, 5, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1221.793881016814m, 261 },
                    { 262, 5, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1270.212652710066m, 262 },
                    { 263, 5, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 975.9478180295555m, 263 },
                    { 264, 9, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1107.936928101783m, 264 },
                    { 265, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1283.897619495117m, 265 },
                    { 266, 10, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1076.090204552294m, 266 },
                    { 267, 5, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1225.666581845612m, 267 },
                    { 268, 7, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 985.8672875282664m, 268 },
                    { 269, 8, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1019.7457537879058m, 269 },
                    { 270, 2, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1094.019333718867m, 270 },
                    { 271, 7, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1210.313034261721m, 271 },
                    { 272, 4, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1048.0252436120048m, 272 },
                    { 273, 9, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1228.04449077481m, 273 },
                    { 274, 3, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1114.54178830039m, 274 },
                    { 275, 3, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 985.8108684555086m, 275 },
                    { 276, 5, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1091.481371292651m, 276 },
                    { 277, 6, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1124.849546911389m, 277 },
                    { 278, 6, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1278.232426884511m, 278 },
                    { 279, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1226.739940208344m, 279 },
                    { 280, 9, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1148.347241508616m, 280 },
                    { 281, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1102.534282091593m, 281 },
                    { 282, 10, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1288.850438633297m, 282 },
                    { 283, 10, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 998.4728642257122m, 283 },
                    { 284, 1, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1026.9970750872918m, 284 },
                    { 285, 6, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 983.241101883345m, 285 },
                    { 286, 5, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 986.0669734346065m, 286 },
                    { 287, 9, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1071.688806109297m, 287 },
                    { 288, 10, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1186.213285281087m, 288 },
                    { 289, 6, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1114.44749950372m, 289 },
                    { 290, 1, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1142.448870212236m, 290 },
                    { 291, 4, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1292.441666034709m, 291 },
                    { 292, 5, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1121.674496302036m, 292 },
                    { 293, 9, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1249.551166336358m, 293 },
                    { 294, 10, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1147.603620802742m, 294 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 295, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.419696471089m, 295 },
                    { 296, 1, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1063.887959919547m, 296 },
                    { 297, 5, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 996.9756202734119m, 297 },
                    { 298, 8, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1088.373376614499m, 298 },
                    { 299, 1, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1108.50271310094m, 299 },
                    { 300, 10, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1245.521847156315m, 300 },
                    { 301, 6, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1241.557652375135m, 301 },
                    { 302, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1200.7641877751m, 302 },
                    { 303, 5, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1024.0143372550496m, 303 },
                    { 304, 3, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 999.7882672667394m, 304 },
                    { 305, 5, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1219.180369832216m, 305 },
                    { 306, 5, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1154.089682680412m, 306 },
                    { 307, 6, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1081.936375972366m, 307 },
                    { 308, 10, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1152.823107822535m, 308 },
                    { 309, 9, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1208.301348383271m, 309 },
                    { 310, 6, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1105.715196452344m, 310 },
                    { 311, 2, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1063.22477749479m, 311 },
                    { 312, 8, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1250.428302218103m, 312 },
                    { 313, 5, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1063.926167235545m, 313 },
                    { 314, 9, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1152.199948515574m, 314 },
                    { 315, 7, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1208.999625080013m, 315 },
                    { 316, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1134.22241593692m, 316 },
                    { 317, 9, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1258.149007238219m, 317 },
                    { 318, 9, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1034.3885342271773m, 318 },
                    { 319, 6, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1092.781752530933m, 319 },
                    { 320, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1293.903271100495m, 320 },
                    { 321, 6, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1079.788503567404m, 321 },
                    { 322, 7, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1069.998291582813m, 322 },
                    { 323, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1055.819068756206m, 323 },
                    { 324, 9, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1298.728632033997m, 324 },
                    { 325, 8, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 964.344205220664m, 325 },
                    { 326, 10, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1098.915417807524m, 326 },
                    { 327, 9, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1025.4753191919568m, 327 },
                    { 328, 10, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1271.946887794642m, 328 },
                    { 329, 6, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1024.581829510365m, 329 },
                    { 330, 10, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1120.868658710341m, 330 },
                    { 331, 9, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1198.490323112225m, 331 },
                    { 332, 7, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1011.9299460580548m, 332 },
                    { 333, 6, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1217.361162321857m, 333 },
                    { 334, 9, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1139.137929429971m, 334 },
                    { 335, 5, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1150.381374442837m, 335 },
                    { 336, 10, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1254.043212830015m, 336 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 337, 7, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1228.084466400338m, 337 },
                    { 338, 7, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1007.1799664827282m, 338 },
                    { 339, 6, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1266.431561480831m, 339 },
                    { 340, 4, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1183.235019033109m, 340 },
                    { 341, 9, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1220.254088892846m, 341 },
                    { 342, 7, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1077.994729215921m, 342 },
                    { 343, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1019.1719043591818m, 343 },
                    { 344, 6, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 956.05089600255818m, 344 },
                    { 345, 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1076.525227426311m, 345 },
                    { 346, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 986.7383999211402m, 346 },
                    { 347, 2, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1273.393402143654m, 347 },
                    { 348, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1129.892013251488m, 348 },
                    { 349, 9, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1094.660544749322m, 349 },
                    { 350, 7, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1067.761928193618m, 350 },
                    { 351, 7, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1087.219031669618m, 351 },
                    { 352, 2, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1254.338613699344m, 352 },
                    { 353, 7, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1161.019051959309m, 353 },
                    { 354, 1, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1037.0875408750812m, 354 },
                    { 355, 8, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1061.433421024183m, 355 },
                    { 356, 2, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1127.712786598001m, 356 },
                    { 357, 9, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1298.519956344701m, 357 },
                    { 358, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 972.317153688006m, 358 },
                    { 359, 8, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1236.267834234883m, 359 },
                    { 360, 9, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1132.604665104218m, 360 },
                    { 361, 5, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1197.749863102029m, 361 },
                    { 362, 6, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1030.9290116888989m, 362 },
                    { 363, 7, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 963.5729576085669m, 363 },
                    { 364, 3, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1026.8666910252738m, 364 },
                    { 365, 5, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1124.301629601543m, 365 },
                    { 366, 10, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1162.239005372237m, 366 },
                    { 367, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1272.069796810559m, 367 },
                    { 368, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1048.9308510964096m, 368 },
                    { 369, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1002.4886392629934m, 369 },
                    { 370, 8, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1191.500770128759m, 370 },
                    { 371, 2, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1192.112323818851m, 371 },
                    { 372, 9, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1159.795234140626m, 372 },
                    { 373, 8, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1197.280770801581m, 373 },
                    { 374, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1136.606272474843m, 374 },
                    { 375, 8, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 958.89089745619036m, 375 },
                    { 376, 8, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1184.725547985823m, 376 },
                    { 377, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1147.536020343928m, 377 },
                    { 378, 8, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1224.128248551745m, 378 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 379, 10, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1052.190176563686m, 379 },
                    { 380, 7, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1082.148751426906m, 380 },
                    { 381, 8, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1130.520870222883m, 381 },
                    { 382, 7, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1193.516676262955m, 382 },
                    { 383, 2, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1129.567075748105m, 383 },
                    { 384, 9, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1108.606815447884m, 384 },
                    { 385, 1, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 965.8218069427253m, 385 },
                    { 386, 5, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 990.4384515211953m, 386 },
                    { 387, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1214.58100619749m, 387 },
                    { 388, 8, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 956.37927274393648m, 388 },
                    { 389, 7, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1131.814375551535m, 389 },
                    { 390, 2, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1044.5012386550697m, 390 },
                    { 391, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1240.077175255842m, 391 },
                    { 392, 8, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1023.5811578460921m, 392 },
                    { 393, 8, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1294.890961589586m, 393 },
                    { 394, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 966.9202661137467m, 394 },
                    { 395, 2, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1208.30438842027m, 395 },
                    { 396, 5, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1290.613696097881m, 396 },
                    { 397, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 994.0161394630997m, 397 },
                    { 398, 9, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1274.441090140805m, 398 },
                    { 399, 6, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1298.729134132602m, 399 },
                    { 400, 5, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1273.043220771588m, 400 },
                    { 401, 1, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1010.8134707728537m, 401 },
                    { 402, 5, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1069.718245442856m, 402 },
                    { 403, 7, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1033.8044473905144m, 403 },
                    { 404, 9, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1082.14934695232m, 404 },
                    { 405, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1227.953768897966m, 405 },
                    { 406, 5, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 963.7147453945559m, 406 },
                    { 407, 10, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1005.5607013180601m, 407 },
                    { 408, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 966.7015455921656m, 408 },
                    { 409, 2, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 953.76564721124715m, 409 },
                    { 410, 2, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1008.6876615793048m, 410 },
                    { 411, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1056.839811123839m, 411 },
                    { 412, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1238.856632273691m, 412 },
                    { 413, 10, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1160.344959846989m, 413 },
                    { 414, 5, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1246.242749510325m, 414 },
                    { 415, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1026.2314627188205m, 415 },
                    { 416, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1191.646539673645m, 416 },
                    { 417, 10, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1144.954511211751m, 417 },
                    { 418, 8, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1009.2843894715233m, 418 },
                    { 419, 2, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1169.253988490564m, 419 },
                    { 420, 7, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1089.759849389419m, 420 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 421, 2, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.788242835315m, 421 },
                    { 422, 10, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 967.3665313230825m, 422 },
                    { 423, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1232.296596966976m, 423 },
                    { 424, 10, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1118.690415510766m, 424 },
                    { 425, 5, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1089.35335160515m, 425 },
                    { 426, 1, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1120.246679669247m, 426 },
                    { 427, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1039.1395865660899m, 427 },
                    { 428, 6, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1045.1749379992028m, 428 },
                    { 429, 5, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1257.104933737639m, 429 },
                    { 430, 10, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 966.2585551846607m, 430 },
                    { 431, 2, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1168.397875055915m, 431 },
                    { 432, 8, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1071.241109622302m, 432 },
                    { 433, 2, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1275.446082058291m, 433 },
                    { 434, 4, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 965.1948723407242m, 434 },
                    { 435, 10, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1063.508010862755m, 435 },
                    { 436, 7, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 990.8622832742181m, 436 },
                    { 437, 6, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1091.080332966118m, 437 },
                    { 438, 7, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1132.135273204224m, 438 },
                    { 439, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1019.8405040490358m, 439 },
                    { 440, 10, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1063.541802830561m, 440 },
                    { 441, 2, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1256.409882819746m, 441 },
                    { 442, 1, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1087.649741783117m, 442 },
                    { 443, 5, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1114.24231997979m, 443 },
                    { 444, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.346703534136m, 444 },
                    { 445, 9, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1030.7311333082121m, 445 },
                    { 446, 10, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1163.042077460172m, 446 },
                    { 447, 5, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1003.3041329338457m, 447 },
                    { 448, 7, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1083.17121006204m, 448 },
                    { 449, 2, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1244.6694789124m, 449 },
                    { 450, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1272.56225127706m, 450 },
                    { 451, 10, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 989.1453940603644m, 451 },
                    { 452, 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1257.682771646457m, 452 },
                    { 453, 9, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1058.658975350017m, 453 },
                    { 454, 9, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1067.151506544936m, 454 },
                    { 455, 10, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1126.60771570867m, 455 },
                    { 456, 9, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1062.732936057228m, 456 },
                    { 457, 7, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1254.749529687148m, 457 },
                    { 458, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 983.5503770182289m, 458 },
                    { 459, 6, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 990.1308661541609m, 459 },
                    { 460, 1, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1083.983973999371m, 460 },
                    { 461, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1221.094415970014m, 461 },
                    { 462, 8, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1020.270830364545m, 462 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 463, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1046.8566042242049m, 463 },
                    { 464, 2, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1005.2276085131515m, 464 },
                    { 465, 6, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1137.461024258288m, 465 },
                    { 466, 9, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1227.931462492034m, 466 },
                    { 467, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1144.423275503075m, 467 },
                    { 468, 9, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1023.9404802060542m, 468 },
                    { 469, 1, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1192.252933822897m, 469 },
                    { 470, 8, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1231.369842224702m, 470 },
                    { 471, 9, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1287.809434486812m, 471 },
                    { 472, 7, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1222.345710094303m, 472 },
                    { 473, 8, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1080.324757046442m, 473 },
                    { 474, 8, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1090.854309721622m, 474 },
                    { 475, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1149.75526032633m, 475 },
                    { 476, 8, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1183.785627273812m, 476 },
                    { 477, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1164.631068230202m, 477 },
                    { 478, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1126.248138058573m, 478 },
                    { 479, 2, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1159.762909373252m, 479 },
                    { 480, 7, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1241.059240900404m, 480 },
                    { 481, 6, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1235.631630125422m, 481 },
                    { 482, 6, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1120.776195270031m, 482 },
                    { 483, 2, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1019.8545553953887m, 483 },
                    { 484, 7, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1031.5514198251726m, 484 },
                    { 485, 5, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1050.905739625701m, 485 },
                    { 486, 1, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1166.427451008241m, 486 },
                    { 487, 1, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 973.0754133527034m, 487 },
                    { 488, 5, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1088.243803622763m, 488 },
                    { 489, 2, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1088.174759334615m, 489 },
                    { 490, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1007.6036657760034m, 490 },
                    { 491, 9, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1149.874270398174m, 491 },
                    { 492, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 955.33962433057937m, 492 },
                    { 493, 8, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1251.382939084451m, 493 },
                    { 494, 9, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1122.546064660534m, 494 },
                    { 495, 9, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1095.822338785664m, 495 },
                    { 496, 9, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1191.438743035588m, 496 },
                    { 497, 9, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1005.2466901381465m, 497 },
                    { 498, 1, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1263.880513092925m, 498 },
                    { 499, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1094.454317804409m, 499 },
                    { 500, 8, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1159.584719255738m, 500 },
                    { 501, 6, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 993.4076359150719m, 501 },
                    { 502, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1101.184440975225m, 502 },
                    { 503, 6, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 985.6863105746611m, 503 },
                    { 504, 9, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.020530230325m, 504 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 505, 8, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1056.155292903368m, 505 },
                    { 506, 2, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1163.357067942298m, 506 },
                    { 507, 8, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1039.0158505702884m, 507 },
                    { 508, 7, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 983.0596323725375m, 508 },
                    { 509, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1029.3581899258171m, 509 },
                    { 510, 1, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1218.071347765005m, 510 },
                    { 511, 10, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 970.0600574480785m, 511 },
                    { 512, 1, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 955.07711441245785m, 512 },
                    { 513, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1088.900730249531m, 513 },
                    { 514, 6, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1078.050399725685m, 514 },
                    { 515, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1113.030928837748m, 515 },
                    { 516, 1, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1027.1807404620129m, 516 },
                    { 517, 6, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1059.982633676253m, 517 },
                    { 518, 7, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1035.4540248696554m, 518 },
                    { 519, 9, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1267.60529817872m, 519 },
                    { 520, 10, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1251.062713140634m, 520 },
                    { 521, 9, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1183.190670729604m, 521 },
                    { 522, 7, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1083.986481074488m, 522 },
                    { 523, 9, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1076.70351900308m, 523 },
                    { 524, 10, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1208.27074076526m, 524 },
                    { 525, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 998.7779722707218m, 525 },
                    { 526, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 962.0233837667158m, 526 },
                    { 527, 8, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1083.673623215581m, 527 },
                    { 528, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1280.756424733759m, 528 },
                    { 529, 6, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 964.7156468886428m, 529 },
                    { 530, 1, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1277.625374082409m, 530 },
                    { 531, 8, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1255.544162943859m, 531 },
                    { 532, 5, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1102.080937625088m, 532 },
                    { 533, 2, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1092.738633738487m, 533 },
                    { 534, 10, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1022.5053312242576m, 534 },
                    { 535, 1, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1243.39888679902m, 535 },
                    { 536, 2, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1162.26702202604m, 536 },
                    { 537, 1, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1029.28970527215m, 537 },
                    { 538, 8, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1099.290206649787m, 538 },
                    { 539, 1, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1280.554416333804m, 539 },
                    { 540, 10, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1137.680938141488m, 540 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

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
        }
    }
}
