using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Full name of the company."),
                    CompanyVat = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false, comment: "VAT number of the company."),
                    CompanyCountry = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Country where the company is located."),
                    CompanyTown = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Town or city where the company is located."),
                    CompanyAddress = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Address of the company."),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Company activity"),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of add Company"),
                    RemovedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date when company is removed")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Truck identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TruckPlate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, comment: "Truck plate"),
                    TruckBrand = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, comment: "Truck brand"),
                    TruckModel = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Truck model"),
                    ProductionYear = table.Column<int>(type: "int", nullable: false, comment: "Truck production year"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Truck activity"),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of add truck to Database"),
                    RemovedDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date when truck is removed"),
                    TruckInitialKm = table.Column<int>(type: "int", nullable: false, comment: "Truck initial milleage")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Employee identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Employee e-mail"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Activity of the employee"),
                    EmployeeUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_EmployeeUserId",
                        column: x => x.EmployeeUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoldsOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Order Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false, comment: "CompanyId associated with the order."),
                    OrderGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoadingCompany = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Name of loading company"),
                    LoadingStreet = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Address of loading company"),
                    LoadingTown = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Town of loading company"),
                    DeliveryCompany = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Name of delivery company"),
                    DeliveryStreet = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Address of delivery company"),
                    DeliveryTown = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Town of loading company"),
                    LoadingReference = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Laoding reference"),
                    DeliveryReference = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Delivery reference"),
                    LoadingDateTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Loading date"),
                    DeliveryDateTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Delivery date"),
                    LoadingMeter = table.Column<double>(type: "float", nullable: false, comment: "Length of the load"),
                    Weight = table.Column<double>(type: "float", nullable: false, comment: "Weight of the load"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "price of the load")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoldsOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoldsOrders_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tripes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Trip identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TruckId = table.Column<int>(type: "int", nullable: false, comment: "TruckId associated with the trip."),
                    EmployeeId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the employee managing the trip."),
                    TripKm = table.Column<int>(type: "int", nullable: false, comment: "Trip in kilometers."),
                    TripPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Price of the trip."),
                    EuPerKm = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Euro per Km"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Start date of the trip."),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "End date of the trip.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tripes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tripes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tripes_Trucks_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Trucks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TruckExpenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Expense identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TruckId = table.Column<int>(type: "int", nullable: false, comment: "Truck Id"),
                    Type = table.Column<int>(type: "int", nullable: false, comment: "Specify the type of the expense (e.g., maintenance, driver salary, road taxes, fuel)."),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Amount of expense"),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Expense date"),
                    Notes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Notes about the expense."),
                    EmployeeId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the employee managing the trip.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckExpenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TruckExpenses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TruckExpenses_Trucks_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Trucks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Price of the order."),
                    CompanyId = table.Column<int>(type: "int", nullable: false, comment: "CompanyId associated with the order."),
                    TripId = table.Column<int>(type: "int", nullable: false, comment: "TripId associated with the order."),
                    LoadingDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Loading date"),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "DeliveryDate"),
                    LoadingPostCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Loaiding place"),
                    DeliveryPostCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Delivery place")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Tripes_TripId",
                        column: x => x.TripId,
                        principalTable: "Tripes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "adminRoleId", "c4b14cae-c55f-440d-8b0a-eac213b95acd", "IdentityRole", "Admin", "ADMIN" },
                    { "dispatcherRoleId", "de473028-dd30-445d-8f31-9e43181b9148", "IdentityRole", "Dispo", "DISPO" },
                    { "managerRoleId", "b3c05669-4a52-48e4-9833-f6cdc55da528", "IdentityRole", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0261d5ca-050a-423e-90cb-c7e990f67959", 0, "66433d49-aa91-4b96-8e3b-2bcb72e04cff", "manager@truck.com", false, "Chief Chiefov", false, null, "MANAGER@TRUCK.COM", "MANAGER@TRUCK.COM", "AQAAAAEAACcQAAAAENnu0N/Bp01POTw3FkP2RbInHspkFL1CYM07yjBwRn2JBxH47BIty1MDX+LWlYdFsw==", null, false, "b14d8483-8fe3-405a-9b0f-a50dd997124b", false, "manager@truck.com" },
                    { "19918df1-9468-434b-aaf9-a3d22b2d12e2", 0, "0c12d80d-e0a8-4f20-b9b6-301acac66b77", "dispo2@truck.com", false, "Hans Due", false, null, "DISPO2@TRUCK.COM", "DISPO2@TRUCK.COM", "AQAAAAEAACcQAAAAEOkWmX7LXk/X0EtdYLZY0gx+HVHq6JbM+a+E/bGnhZ3CH2JQwbktfpYzPSgWOQ1JSg==", null, false, "ae5cc927-5fb3-40ec-b510-a167638fde1b", false, "dispo2@truck.com" },
                    { "62154153-66df-4b35-91ed-56ac983c9a8e", 0, "6bf88d3b-f1d0-456f-85df-53c21bd7da84", "dispo1@truck.com", false, "Hans Uno", false, null, "DISPO1@TRUCK.COM", "DISPO1@TRUCK.COM", "AQAAAAEAACcQAAAAEL2xLzRPkfxLzO/8xxX2G5sEMjIxx7awqyIlSIkC0Xo3N2TxCVfNjyQwtpP5v5vDqg==", null, false, "3b456cca-c71b-4eb0-b184-4a2423b5e1bc", false, "dispo1@truck.com" },
                    { "d401e5f8-2fe9-45e2-9209-69b7db1c1de9", 0, "77a53efa-830a-41a9-9bab-a2386aab1647", "admin@truck.com", false, "Admin Admin", false, null, "ADMIN@TRUCK.COM", "ADMIN@TRUCK.COM", "AQAAAAEAACcQAAAAEJuEBBdc1MUtN1aknIqTRstaKv5hIYRVgjsTCX5Z1dktl8coHzfJDDA7zGv7JJAWqg==", null, false, "ace63ec0-fee8-41fa-914a-7ff7b97ee237", false, "admin@truck.com" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AddedDate", "CompanyAddress", "CompanyCountry", "CompanyName", "CompanyTown", "CompanyVat", "IsActive", "RemovedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), "17 RUE BOBBY SANDS", "France", "MALHERBE DISTRIBUTION", "44813 ST-HERBLAIN CEDEX", "FR72518435920", true, null },
                    { 2, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), "ROUTE DE SCHWEIGEN BP 10025", "France", "WOEHL & CIE - TPT INTERNATIONAUX", "67160 WISSEMBOURG", "FR37558501144", true, null },
                    { 3, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), "144 ZAE WOLSER", "Luxembourg", "XPO TRS LU", "3225 BETTEMBOURG", "LU17458960", true, null },
                    { 4, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), "2609 AVENUE DE PRADES", "France", "GEFCO FRANCE", "66000 PERPIGNAN", "FR24789791464", true, null },
                    { 5, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), "69 Route de Thionville", "France", "Yusen Logistics (France) SAS", "57280 Maizières-lès-Metz", "FR89432599785", true, null },
                    { 6, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), "JUSTUS LIEBIG STRASSE 14", "Germany", "SCHENKER DEUTSCHLAND AG", "34253 LOHFELDEN/KASSEL", "DE811228366", true, null },
                    { 7, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Brinkhofstraße 41", "Germany", "Winner Spedition GmbH & Co. KG", "58642 Iserlohn", "DE125572634", true, null },
                    { 8, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Genthiner Strasse 34", "Germany", "sennder Technologies GmbH", "10785 Berlin", "DE302502945", true, null },
                    { 9, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Otto-Hahn-Str. 3", "Germany", "Stahl Log", "D-66793 Saarwellingen", "DE813065962", true, null },
                    { 10, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), "RUE DES VERGERS", "France", "GREILSAMMER ABCE", "F - 68600 WOLFGANTZEN", "FR06514447937", true, null }
                });

            migrationBuilder.InsertData(
                table: "Trucks",
                columns: new[] { "Id", "AddedDate", "IsActive", "ProductionYear", "RemovedDate", "TruckBrand", "TruckInitialKm", "TruckModel", "TruckPlate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 195000, "Renault Trucks T High", "B8511TC" },
                    { 2, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 198000, "Renault Trucks T High", "B8514TC" },
                    { 3, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 201500, "Renault Trucks T High", "B8517TC" },
                    { 4, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 205000, "Renault Trucks T High", "B9133TC" },
                    { 5, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 210000, "Renault Trucks T High", "B9134TC" },
                    { 6, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), true, 2019, null, "Renault", 230500, "Renault Trucks T High", "B9135TC" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "user:fullname", "Admin Admin", "d401e5f8-2fe9-45e2-9209-69b7db1c1de9" },
                    { 2, "user:fullname", "Chief Chiefov", "0261d5ca-050a-423e-90cb-c7e990f67959" },
                    { 3, "user:fullname", "Hans Uno", "62154153-66df-4b35-91ed-56ac983c9a8e" },
                    { 4, "user:fullname", "Hans Due", "19918df1-9468-434b-aaf9-a3d22b2d12e2" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "managerRoleId", "0261d5ca-050a-423e-90cb-c7e990f67959" },
                    { "dispatcherRoleId", "19918df1-9468-434b-aaf9-a3d22b2d12e2" },
                    { "dispatcherRoleId", "62154153-66df-4b35-91ed-56ac983c9a8e" },
                    { "adminRoleId", "d401e5f8-2fe9-45e2-9209-69b7db1c1de9" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "EmployeeUserId", "IsActive", "RoleId" },
                values: new object[,]
                {
                    { 1, "admin@truck.com", "d401e5f8-2fe9-45e2-9209-69b7db1c1de9", true, "adminRoleId" },
                    { 2, "manager@truck.com", "0261d5ca-050a-423e-90cb-c7e990f67959", true, "managerRoleId" },
                    { 3, "dispo1@truck.com", "62154153-66df-4b35-91ed-56ac983c9a8e", true, "dispatcherRoleId" },
                    { 4, "dispo2@truck.com", "19918df1-9468-434b-aaf9-a3d22b2d12e2", true, "dispatcherRoleId" }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9460790935150054761904761905m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1008, 953.64772626312552m, 1 },
                    { 2, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6212705335984826254826254826m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 777, 1259.727204606021m, 2 },
                    { 3, 4, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.885212879428326697247706422m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1090, 964.8820385768761m, 3 },
                    { 4, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2456582332505041128084606345m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 851, 1060.055156496179m, 4 },
                    { 5, 4, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0370870990560622377622377622m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1001, 1038.1241861551183m, 5 },
                    { 6, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3801096859966252702702702703m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 740, 1021.2811676375027m, 6 },
                    { 7, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4696669577575846338535414166m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 833, 1224.232575812068m, 1 },
                    { 8, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.176995794877672147001934236m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1034, 1217.013651903513m, 2 },
                    { 9, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0322319301728172541743970315m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1078, 1112.746020726297m, 3 },
                    { 10, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4153681126043060863095238095m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 672, 951.12737167009369m, 4 },
                    { 11, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4581266135723462857142857143m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 875, 1275.860786875803m, 5 },
                    { 12, 3, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4283013610255571260306242638m, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 849, 1212.627855510698m, 6 },
                    { 13, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1855193500354739382239382239m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1036, 1228.198046636751m, 1 },
                    { 14, 3, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5453094085204071782178217822m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 808, 1248.610002084489m, 2 },
                    { 15, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5461500233451098626716604245m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 801, 1238.466168699433m, 3 },
                    { 16, 3, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5299829404189463087248322148m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 745, 1139.837290612115m, 4 },
                    { 17, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3017336995786002304147465438m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 868, 1129.904851234225m, 5 },
                    { 18, 3, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.274825704900173469387755102m, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 882, 1124.396271721953m, 6 },
                    { 19, 4, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6693485487083367875647668394m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 772, 1288.737079602836m, 1 },
                    { 20, 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4173224677871576576576576577m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 888, 1258.582351394996m, 2 },
                    { 21, 4, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3555728626255458563535911602m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 905, 1226.793440676119m, 3 },
                    { 22, 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3294764471826647331786542923m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 862, 1146.008697471457m, 4 },
                    { 23, 4, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3872281785463121516164994426m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 897, 1244.343676156042m, 5 },
                    { 24, 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3860222747308634146341463415m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 820, 1136.538265279308m, 6 },
                    { 25, 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4616273043026831812255541069m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 767, 1121.068142400158m, 1 },
                    { 26, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9600819315762374429223744292m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1095, 1051.28971507598m, 2 },
                    { 27, 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3962049803916891701828410689m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 711, 992.701741058491m, 3 },
                    { 28, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4530656692375680456490727532m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 701, 1018.5990341355352m, 4 },
                    { 29, 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4698113092137447887323943662m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 710, 1043.5660295417588m, 5 },
                    { 30, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1595042123487897959183673469m, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 980, 1136.314128101814m, 6 },
                    { 31, 4, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1188313027200547671840354767m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 902, 1009.1858350534894m, 1 },
                    { 32, 3, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2095069638133204747774480712m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1011, 1222.811540415267m, 2 },
                    { 33, 4, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5988273588722806770098730606m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 709, 1133.568597440447m, 3 },
                    { 34, 3, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1901784483662203548085901027m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1071, 1274.681118200222m, 4 },
                    { 35, 4, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9341596018062167304015296367m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1046, 977.1309434893027m, 5 },
                    { 36, 3, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3722936258985527272727272727m, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 825, 1132.142241366306m, 6 },
                    { 37, 4, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6732015843753732193732193732m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 702, 1174.587512231512m, 1 },
                    { 38, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9833613153618133911368015414m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1038, 1020.7290453455623m, 2 },
                    { 39, 4, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1967838446983375661375661376m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 945, 1130.960733239929m, 3 },
                    { 40, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3883897225117712264150943396m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 848, 1177.354484689982m, 4 },
                    { 41, 4, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9236597599216736213235294118m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1088, 1004.9418187947809m, 5 },
                    { 42, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2670696123425136554621848739m, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 952, 1206.250270950073m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 43, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1655716261092502351834430856m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1063, 1239.002638554133m, 1 },
                    { 44, 3, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1516167146452658285714285714m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 875, 1007.6646253146076m, 2 },
                    { 45, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.261265733205687799043062201m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 836, 1054.418152959955m, 3 },
                    { 46, 3, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1666019586628353080568720379m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 844, 984.612053111433m, 4 },
                    { 47, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.504074691620378561736770692m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 737, 1108.503047724219m, 5 },
                    { 48, 3, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1640931171998692307692307692m, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 858, 998.7918945574878m, 6 },
                    { 49, 4, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3539554236311906519065190652m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 813, 1100.765759412158m, 1 },
                    { 50, 3, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1061117436531381381381381381m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 999, 1105.005631909485m, 2 },
                    { 51, 4, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1544398242314428044280442804m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1084, 1251.412769466884m, 3 },
                    { 52, 3, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.095095737971090169133192389m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 946, 1035.9605681206513m, 4 },
                    { 53, 4, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.519728577639122354694485842m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 671, 1019.7378755958511m, 5 },
                    { 54, 3, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2978617607625017421602787456m, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 861, 1117.458976016514m, 6 },
                    { 55, 4, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5911076586240142045454545455m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 704, 1120.139791671306m, 1 },
                    { 56, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5651913055523466076696165192m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 678, 1061.199705164491m, 2 },
                    { 57, 4, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3646769697791914110429447853m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 815, 1112.211730370041m, 3 },
                    { 58, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1582060247301325678496868476m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 958, 1109.561371691467m, 4 },
                    { 59, 4, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.945370404102055019305019305m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1036, 979.403738649729m, 5 },
                    { 60, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3213802575460622065727699531m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 852, 1125.815979429245m, 6 },
                    { 61, 4, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6855191083850113314447592068m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 706, 1189.976490519818m, 1 },
                    { 62, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.285726379627080188679245283m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 848, 1090.295969923764m, 2 },
                    { 63, 4, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.584395781500215429403202329m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 687, 1088.479901890648m, 3 },
                    { 64, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2961459482108089622641509434m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 848, 1099.131764082766m, 4 },
                    { 65, 4, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1559358116135927687916270219m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1051, 1214.888538005886m, 5 },
                    { 66, 3, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.8827856743480747178538390379m, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1081, 954.29131397026877m, 6 },
                    { 67, 4, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9767744298674573446327683616m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1062, 1037.3344445192397m, 1 },
                    { 68, 3, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1137503691410656716417910448m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1005, 1119.319120986771m, 2 },
                    { 69, 4, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4289940053449802955665024631m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 812, 1160.343132340124m, 3 },
                    { 70, 3, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1202339275431256599788806758m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 947, 1060.86152938334m, 4 },
                    { 71, 4, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6160608287460684410646387833m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 789, 1275.071993880648m, 5 },
                    { 72, 3, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0664034109242770475227502528m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 989, 1054.67297340411m, 6 },
                    { 73, 4, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1276753381342459791863765374m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1057, 1191.952832407898m, 1 },
                    { 74, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2489508281010235546038543897m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 934, 1166.520073446356m, 2 },
                    { 75, 4, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8855208265529864864864864865m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 666, 1255.756870484289m, 3 },
                    { 76, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0168468476728224924012158055m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 987, 1003.6278386530758m, 4 },
                    { 77, 4, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0195634516918029878618113912m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1071, 1091.952456761921m, 5 },
                    { 78, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2068695385970393198724760893m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 941, 1135.664235819814m, 6 },
                    { 79, 4, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7006217848546838440111420613m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 718, 1221.046441525663m, 1 },
                    { 80, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0789088859359923809523809524m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 945, 1019.5688972095128m, 2 },
                    { 81, 4, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0038046660305257560975609756m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1025, 1028.8997826812889m, 3 },
                    { 82, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4508253730611195795006570302m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, 1104.078108899512m, 4 },
                    { 83, 4, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1544604961721908831908831909m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1053, 1215.646902469317m, 5 },
                    { 84, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1869293436088232848232848233m, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 962, 1141.826028551688m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 85, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2777591078091834061135371179m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 916, 1170.427342753212m, 1 },
                    { 86, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4973348653202847283406754772m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 681, 1019.6850432831139m, 2 },
                    { 87, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5784349776392259810554803789m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 739, 1166.463448475388m, 3 },
                    { 88, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9826877341889462153846153846m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 975, 958.12054083422256m, 4 },
                    { 89, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2562028021276875621890547264m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1005, 1262.483816138326m, 5 },
                    { 90, 3, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9671050004747899209486166008m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1012, 978.7102604804874m, 6 },
                    { 91, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0658157363190713577799801784m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1009, 1075.408077945943m, 1 },
                    { 92, 3, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0550394424239363163371488033m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 961, 1013.8929041694028m, 2 },
                    { 93, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0941575053416315789473684211m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1026, 1122.605600480514m, 3 },
                    { 94, 3, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3744852476543058064516129032m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 775, 1065.226066932087m, 4 },
                    { 95, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3169564880804207459207459207m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 858, 1129.948666773001m, 5 },
                    { 96, 3, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4556900946532203369065849923m, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 950.56563180855288m, 6 },
                    { 97, 4, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4417532825848278061224489796m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 784, 1130.334573546505m, 1 },
                    { 98, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4215056073779142857142857143m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 910, 1293.570102713902m, 2 },
                    { 99, 4, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1056812134513364055299539171m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1085, 1199.6641165947m, 3 },
                    { 100, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3036669702131858549931600547m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 731, 952.98055522583886m, 4 },
                    { 101, 4, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1037750058782192902638762511m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1099, 1213.048731460163m, 5 },
                    { 102, 3, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3011529885665071982281284607m, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 903, 1174.941148675556m, 6 },
                    { 103, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1362037248131707798617966436m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1013, 1150.974373235742m, 1 },
                    { 104, 3, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0412418955094209012464046021m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1043, 1086.015297016326m, 2 },
                    { 105, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1460167318969829424307036247m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 938, 1074.96369451937m, 3 },
                    { 106, 3, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0330046343480633836206896552m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 928, 958.62830067500282m, 4 },
                    { 107, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2237085756360938104448742747m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1034, 1265.314667207721m, 5 },
                    { 108, 3, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1510918674702835820895522388m, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1072, 1233.970481928144m, 6 },
                    { 109, 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.101953031767412348401323043m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 907, 999.471399813043m, 1 },
                    { 110, 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0319279852756611489776046738m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1027, 1059.790040878104m, 2 },
                    { 111, 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3849985602007643171806167401m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 908, 1257.578692662294m, 3 },
                    { 112, 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0874477278999031936127744511m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1002, 1089.622623355703m, 4 },
                    { 113, 4, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9717292617459698795180722892m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 996, 967.842344698986m, 5 },
                    { 114, 3, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1550905774490802197802197802m, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 910, 1051.132425478663m, 6 },
                    { 115, 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9099706231061801801801801802m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 666, 1272.040434988716m, 1 },
                    { 116, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1434872195238089990817263545m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1089, 1245.257582061428m, 2 },
                    { 117, 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9098312756657335375191424196m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 1247.119823009724m, 3 },
                    { 118, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5396207805055700808625336927m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 742, 1142.398619135133m, 4 },
                    { 119, 4, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3384471470978540372670807453m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 966, 1292.939944096527m, 5 },
                    { 120, 3, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9609820984269992380952380952m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1050, 1009.0312033483492m, 6 },
                    { 121, 4, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0315919642947520661157024793m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 968, 998.58102143732m, 1 },
                    { 122, 3, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3272226190401194196428571429m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 896, 1189.191466659947m, 2 },
                    { 123, 4, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.286141882770153380423814329m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 991, 1274.566605825222m, 3 },
                    { 124, 3, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2185508787402763157894736842m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1064, 1296.538134979654m, 4 },
                    { 125, 4, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.190913379402494263862332696m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1046, 1245.695394855009m, 5 },
                    { 126, 3, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3904624280422891832229580574m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 906, 1259.758959806314m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 127, 4, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1606182332785091566265060241m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 830, 963.3131336211626m, 1 },
                    { 128, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6082251426649495677233429395m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, 1116.108249009475m, 2 },
                    { 129, 4, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2401332283481251221896383187m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1023, 1268.656292600132m, 3 },
                    { 130, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2740126312310784313725490196m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 969, 1234.518239662915m, 4 },
                    { 131, 4, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2710382751258090196078431373m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 765, 972.3442804712439m, 5 },
                    { 132, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1009635323832795811518324607m, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 955, 1051.420173426032m, 6 },
                    { 133, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9710840318283947169811320755m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1060, 1029.3490737380984m, 1 },
                    { 134, 3, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1056925090192674976030680729m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1043, 1153.237286907096m, 2 },
                    { 135, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2539405979076032887975334018m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 973, 1220.084201764098m, 3 },
                    { 136, 3, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2953818090721814207650273224m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 915, 1185.274355301046m, 4 },
                    { 137, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0165287500314297674418604651m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1075, 1092.768406283787m, 5 },
                    { 138, 3, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9602746190206952143569292124m, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1003, 963.1554428777573m, 6 },
                    { 139, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9802846428624040796019900498m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1005, 985.1860660767161m, 1 },
                    { 140, 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2658552586316665408805031447m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 795, 1006.3549306121749m, 2 },
                    { 141, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4191269746982259675405742821m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 801, 1136.720706733279m, 3 },
                    { 142, 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.769392385021973134328358209m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 670, 1185.492897964722m, 4 },
                    { 143, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6793415392392467700258397933m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 774, 1299.810351371177m, 5 },
                    { 144, 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0414127594531889698231009365m, new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 961, 1000.7976618345146m, 6 },
                    { 145, 4, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5361410028141957142857142857m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 700, 1075.298701969937m, 1 },
                    { 146, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6422517492743233766233766234m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 770, 1264.533846941229m, 2 },
                    { 147, 4, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5996815449698768606224627876m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 739, 1182.164661732739m, 3 },
                    { 148, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5317824093351062271062271062m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 819, 1254.529793245452m, 4 },
                    { 149, 4, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3038310753926748329621380846m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 898, 1170.840305702622m, 5 },
                    { 150, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9147640631303m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1070, 978.797547549421m, 6 },
                    { 151, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3823293368581986827661909989m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 911, 1259.302025877819m, 1 },
                    { 152, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3371232041440302713987473904m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 958, 1280.964029569981m, 2 },
                    { 153, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1475966983925612353567625133m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 939, 1077.593299790615m, 3 },
                    { 154, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0739185569636467842323651452m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 964, 1035.2574889129555m, 4 },
                    { 155, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4887396298881744897959183673m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 686, 1021.2753861032877m, 5 },
                    { 156, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9885972653087981651376146789m, new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1090, 1077.57101918659m, 6 },
                    { 157, 4, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4035181364855498154981549815m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 813, 1141.060244962752m, 1 },
                    { 158, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7758195234415206489675516224m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 678, 1204.005636893351m, 2 },
                    { 159, 4, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1568961578388284080076263108m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1049, 1213.584069572931m, 3 },
                    { 160, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0233444649736581039755351682m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 981, 1003.9009201391586m, 4 },
                    { 161, 4, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4539622514257071524966261808m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 741, 1077.386028306449m, 5 },
                    { 162, 3, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3039991880905384615384615385m, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 819, 1067.975335046151m, 6 },
                    { 163, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.806530566632157973174366617m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 671, 1212.182010210178m, 1 },
                    { 164, 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1195848710032370470588235294m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 850, 951.64714035275149m, 2 },
                    { 165, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.8873628897558958677685950413m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1089, 966.3381869441706m, 3 },
                    { 166, 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3813188907487270788912579957m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 938, 1295.677119522306m, 4 },
                    { 167, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2521511927284493346980552712m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 977, 1223.351715295695m, 5 },
                    { 168, 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4738282684536031537450722733m, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 761, 1121.583312293192m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 169, 4, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0923228424246013651877133106m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 879, 960.1517784912246m, 1 },
                    { 170, 3, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2619673666725562130177514793m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1014, 1279.634909805972m, 2 },
                    { 171, 4, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4318073545518200992555831266m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 806, 1154.036727768767m, 3 },
                    { 172, 3, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2663253739455519911504424779m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 904, 1144.758138046779m, 4 },
                    { 173, 4, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3540766816569572789115646259m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 735, 995.2463610178636m, 5 },
                    { 174, 3, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0295785639881636831275720165m, new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 972, 1000.7503641964951m, 6 },
                    { 175, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4969150366648178191489361702m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 752, 1125.680107571943m, 1 },
                    { 176, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4746940699674457364341085271m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 774, 1141.413210154803m, 2 },
                    { 177, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3710194729812463414634146341m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 820, 1124.235967844622m, 3 },
                    { 178, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4930562798023383333333333333m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 660, 985.4171446695433m, 4 },
                    { 179, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1202858832597510706638115632m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 934, 1046.3470149646075m, 5 },
                    { 180, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2789806218254736275565123789m, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 929, 1188.172997675865m, 6 },
                    { 181, 4, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1577553232741361702127659574m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 940, 1088.290003877688m, 1 },
                    { 182, 3, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2265037635390180995475113122m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 884, 1084.229326968492m, 2 },
                    { 183, 4, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2219824423174328678839957035m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 931, 1137.66565379753m, 3 },
                    { 184, 3, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3375985285080576701268742791m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 867, 1159.697924216486m, 4 },
                    { 185, 4, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6043381374255255754475703325m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 782, 1254.592423466761m, 5 },
                    { 186, 3, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0321013698201625246548323471m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1014, 1046.5507889976448m, 6 },
                    { 187, 4, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2586775559741930635838150289m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 865, 1088.756085917677m, 1 },
                    { 188, 3, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5279400752341430536451169188m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 727, 1110.812434695222m, 2 },
                    { 189, 4, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1691671241989978700745473908m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 939, 1097.847929622859m, 3 },
                    { 190, 3, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9925716336689893175074183976m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1011, 1003.4899216393482m, 4 },
                    { 191, 4, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0906590695354293577981651376m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1090, 1188.818385793618m, 5 },
                    { 192, 3, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6938856027996094364351245085m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 763, 1292.434714936102m, 6 },
                    { 193, 4, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1018683665403169456066945607m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 956, 1053.386158412543m, 1 },
                    { 194, 3, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.59267560009003375m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 800, 1274.140480072027m, 2 },
                    { 195, 4, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2812917612385185995623632385m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 914, 1171.100669772006m, 3 },
                    { 196, 3, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1140168503991776900296150049m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1013, 1128.499069454367m, 4 },
                    { 197, 4, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1671046875477818181818181818m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 990, 1155.433640672304m, 5 },
                    { 198, 3, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9939579188360557984790874525m, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1052, 1045.6437306155307m, 6 },
                    { 199, 4, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8320383382544033742331288344m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 652, 1194.488996541871m, 1 },
                    { 200, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5902526321612233766233766234m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 770, 1224.494526764142m, 2 },
                    { 201, 4, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.315992008482830188679245283m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 848, 1115.96122319344m, 3 },
                    { 202, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.302650014824447427293064877m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 894, 1164.569113253056m, 4 },
                    { 203, 4, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9695515487830828657314629259m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 998, 967.6124456855167m, 5 },
                    { 204, 3, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8157345364479347826086956522m, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 690, 1252.856830149075m, 6 },
                    { 205, 4, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5606262881126975806451612903m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 744, 1161.105958355847m, 1 },
                    { 206, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3574589313021431767337807606m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 894, 1213.568284584116m, 2 },
                    { 207, 4, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4077803731612367583212735166m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 691, 972.7762378544146m, 3 },
                    { 208, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2005479685645245398773006135m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 815, 978.4465943800875m, 4 },
                    { 209, 4, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7997250769850629800307219662m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 1171.621025117276m, 5 },
                    { 210, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2302453645424630170316301703m, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 822, 1011.2616896539046m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 211, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4007627956114163860830527497m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 891, 1248.079650889772m, 1 },
                    { 212, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3716195052265276211950394589m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 887, 1216.62650113593m, 2 },
                    { 213, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1271918328069320388349514563m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1030, 1161.00758779114m, 3 },
                    { 214, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3413447997542210884353741497m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 882, 1183.066113383223m, 4 },
                    { 215, 4, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2365117383186473988439306358m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1038, 1283.499184374756m, 5 },
                    { 216, 3, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1760717015114132231404958678m, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 968, 1138.437407063048m, 6 },
                    { 217, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.045657996329162638469284995m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 993, 1038.3383903548585m, 1 },
                    { 218, 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7164006099101101573676680973m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 699, 1199.764026327167m, 2 },
                    { 219, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.480041069929341743119266055m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 872, 1290.595812978386m, 3 },
                    { 220, 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0473664598416650875386199794m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 971, 1016.9928325062568m, 4 },
                    { 221, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4803714162935501222493887531m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 818, 1210.943818528124m, 5 },
                    { 222, 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0143698133886435331230283912m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 951, 964.6656925326m, 6 },
                    { 223, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3161105888673642533936651584m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 884, 1163.44176055875m, 1 },
                    { 224, 3, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0537814621636567041965199591m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 977, 1029.5444885338926m, 2 },
                    { 225, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4470009117982939814814814815m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 864, 1250.208787793726m, 3 },
                    { 226, 3, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1147177167003645735707591378m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1067, 1189.403803719289m, 4 },
                    { 227, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0515674735559419633225458468m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 927, 974.8030479863582m, 5 },
                    { 228, 3, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4553907617445715962441314554m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 852, 1239.992929006375m, 6 },
                    { 229, 4, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3594412218421553884711779449m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 798, 1084.83409503004m, 1 },
                    { 230, 3, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4537981800996432357043235704m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 717, 1042.3732951314442m, 2 },
                    { 231, 4, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1705201998112263969171483622m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1038, 1214.999967404053m, 3 },
                    { 232, 3, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3167709338451381345926800472m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 847, 1115.304980966832m, 4 },
                    { 233, 4, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.095657877265391566265060241m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 913, 1000.3356419433025m, 5 },
                    { 234, 3, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3796605278684081855388813097m, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 733, 1011.2911669275432m, 6 },
                    { 235, 4, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5031816776983903735632183908m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 696, 1046.2144476780797m, 1 },
                    { 236, 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0511997106955523897058823529m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1088, 1143.705285236761m, 2 },
                    { 237, 4, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3395089041060576086956521739m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 920, 1232.348191777573m, 3 },
                    { 238, 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1072355567334726415094339623m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1060, 1173.669690137481m, 4 },
                    { 239, 4, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0166436085951122942884801549m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1033, 1050.192847678751m, 5 },
                    { 240, 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2360949841798782772020725389m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 772, 954.26532778686603m, 6 },
                    { 241, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2472174912238109107611548556m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 762, 950.379728312543914m, 1 },
                    { 242, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4527299164152130492676431425m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 751, 1091.000167227825m, 2 },
                    { 243, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2603198220151063829787234043m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 940, 1184.7006326942m, 3 },
                    { 244, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2644687370606409185803757829m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 958, 1211.361050104094m, 4 },
                    { 245, 4, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1156354095731024390243902439m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1025, 1143.52629481243m, 5 },
                    { 246, 3, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.304065235307659477866061294m, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 881, 1148.881472306048m, 6 },
                    { 247, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7109777821644861294583883752m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 757, 1295.210181098516m, 1 },
                    { 248, 3, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1334913000788182751540041068m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 974, 1104.020526276769m, 2 },
                    { 249, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9086177191505640148011100833m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1081, 982.2157544017597m, 3 },
                    { 250, 3, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.115778097983851063829787234m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1034, 1153.714553315302m, 4 },
                    { 251, 4, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.538663032544653204172876304m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 671, 1032.4428948374623m, 5 },
                    { 252, 3, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2017935375160886339937434828m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 959, 1152.520002477929m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 253, 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4958947678136020881670533643m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 862, 1289.461289855325m, 1 },
                    { 254, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.188968390550700734394124847m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 817, 971.3871750799225m, 2 },
                    { 255, 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4094981142032371721778791334m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 877, 1236.129846156239m, 3 },
                    { 256, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1925575312014271631982475356m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 913, 1088.805025986903m, 4 },
                    { 257, 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.059158177803710688591983556m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 973, 1030.5609070030105m, 5 },
                    { 258, 3, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6592819061371823204419889503m, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 724, 1201.32010004332m, 6 },
                    { 259, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.293626180253003871829105474m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 749, 968.9260090094999m, 1 },
                    { 260, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5875952238469255874673629243m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 766, 1216.097941466745m, 2 },
                    { 261, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2630817804277067938021454112m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 839, 1059.725613778846m, 3 },
                    { 262, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4129787012911710816777041943m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 906, 1280.158703369801m, 4 },
                    { 263, 4, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3876001194329608516483516484m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 728, 1010.1728869471955m, 5 },
                    { 264, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3405989898320134680134680135m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 891, 1194.473699940324m, 6 },
                    { 265, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1956980777457091932457786116m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1066, 1274.614150876926m, 1 },
                    { 266, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9423276718271056980056980057m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1053, 992.2710384339423m, 2 },
                    { 267, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3061694455183460166468489893m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 841, 1098.488503680929m, 3 },
                    { 268, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.024150495038430784123910939m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1033, 1057.947461374699m, 4 },
                    { 269, 4, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4219617315551995438996579247m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 877, 1247.06043857391m, 5 },
                    { 270, 3, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0166993344750481210855949896m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 958, 973.9979624270961m, 6 },
                    { 271, 4, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6934292372880426997245179063m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 726, 1229.429626271119m, 1 },
                    { 272, 3, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1831939068068807339449541284m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 981, 1160.71322257755m, 2 },
                    { 273, 4, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2192347634033909378292939937m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 949, 1157.053790469818m, 3 },
                    { 274, 3, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2526152696638364055299539171m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 868, 1087.27005406821m, 4 },
                    { 275, 4, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2636449141812122222222222222m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 900, 1137.280422763091m, 5 },
                    { 276, 3, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.487678578068984593837535014m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 714, 1062.202504741255m, 6 },
                    { 277, 4, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2191080794881625282167042889m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 886, 1080.129758426512m, 1 },
                    { 278, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2314365776696523329129886507m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 793, 976.5292060920343m, 2 },
                    { 279, 4, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3547674153000226190476190476m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 840, 1138.004628852019m, 3 },
                    { 280, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6252461259240503048780487805m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 656, 1066.161458606177m, 4 },
                    { 281, 4, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8907009089593847328244274809m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 655, 1238.409095368397m, 5 },
                    { 282, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4156292297980018970189701897m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 738, 1044.7343715909254m, 6 },
                    { 283, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4373574731526208955223880597m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 670, 963.029507012256m, 1 },
                    { 284, 3, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2030428859477034611786716558m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1069, 1286.052845078095m, 2 },
                    { 285, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3969199843979888765294771969m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 899, 1255.831065973792m, 3 },
                    { 286, 3, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0754713381950413978494623656m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 930, 1000.1883445213885m, 4 },
                    { 287, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3101894765168775720164609053m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 972, 1273.504171174405m, 5 },
                    { 288, 3, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3482645212604622741764080765m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 941, 1268.716914506095m, 6 },
                    { 289, 4, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4870108666629662650602409639m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 830, 1234.219019330262m, 1 },
                    { 290, 3, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.481736567395069828722002635m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 759, 1124.638054652858m, 2 },
                    { 291, 4, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0776664283581618852459016393m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 976, 1051.802434077566m, 3 },
                    { 292, 3, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4126973290035922444183313749m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 851, 1202.205426982057m, 4 },
                    { 293, 4, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6190261336594177545691906005m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 766, 1240.174018383114m, 5 },
                    { 294, 3, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3520437558403218785796105384m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 873, 1180.334198848601m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 295, 4, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.139711078385842255125284738m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 878, 1000.6663268227695m, 1 },
                    { 296, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1370552606595827876520112254m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1069, 1215.512073645094m, 2 },
                    { 297, 4, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1500984135641227402473834443m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1051, 1208.753432655893m, 3 },
                    { 298, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6515408644727680555555555556m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 720, 1189.109422420393m, 4 },
                    { 299, 4, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3475711826101678763440860215m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 744, 1002.5929598619649m, 5 },
                    { 300, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2853144406857535753575357536m, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 909, 1168.35082658335m, 6 },
                    { 301, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3531228606172570694087403599m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 778, 1052.729585560226m, 1 },
                    { 302, 3, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.156353646027315063731170336m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 863, 997.9331965215729m, 2 },
                    { 303, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1153356862395762456546929316m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 863, 962.5346972247543m, 3 },
                    { 304, 3, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2348382194601069397042093288m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 879, 1085.422794905434m, 4 },
                    { 305, 4, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0112053109503311808118081181m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1084, 1096.146557070159m, 5 },
                    { 306, 3, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5557164799169872340425531915m, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 705, 1096.780118341476m, 6 },
                    { 307, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.919486775169686586493987049m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1081, 993.9652039584312m, 1 },
                    { 308, 3, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5538824968287442143727161998m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 821, 1275.737529896399m, 2 },
                    { 309, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4078840442620216346153846154m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 832, 1171.359524826002m, 3 },
                    { 310, 3, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7704778996581786786786786787m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 666, 1179.138281172347m, 4 },
                    { 311, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.291295015669023469387755102m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 980, 1265.469115355643m, 5 },
                    { 312, 3, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.264136534206154296875m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1024, 1294.475811027102m, 6 },
                    { 313, 4, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.288953571300828290282902829m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 813, 1047.9192534675734m, 1 },
                    { 314, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3790305535307833523375142531m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 877, 1209.409795446497m, 2 },
                    { 315, 4, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1592498400035643564356435644m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1010, 1170.8423384036m, 3 },
                    { 316, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0050842933816068773234200743m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1076, 1081.470699678609m, 4 },
                    { 317, 4, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5997661457380875957120980092m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 653, 1044.6472931669712m, 5 },
                    { 318, 3, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9157370518678242857142857143m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1050, 961.5239044612155m, 6 },
                    { 319, 4, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0439163103341963775023832221m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1049, 1095.068209540572m, 1 },
                    { 320, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2322883877993993839835728953m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 974, 1200.248889716615m, 2 },
                    { 321, 4, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9345351244234984662576687117m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 652, 1261.316901124121m, 3 },
                    { 322, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9490689886513987192118226601m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1015, 963.3050234811697m, 4 },
                    { 323, 4, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7009803769305271428571428571m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 700, 1190.686263851369m, 5 },
                    { 324, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9607538078977021782178217822m, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1010, 970.3613459766792m, 6 },
                    { 325, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2119104026871913289349670123m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1061, 1285.83693725111m, 1 },
                    { 326, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3198042728003717472118959108m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 807, 1065.0820481499m, 2 },
                    { 327, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9868774420761346863468634686m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1084, 1069.77514721053m, 3 },
                    { 328, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7612514142802072617246596067m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 661, 1164.187184839217m, 4 },
                    { 329, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.063333339242602431289640592m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 946, 1005.9133389235019m, 5 },
                    { 330, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4929476338577097661623108666m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 727, 1085.372929814555m, 6 },
                    { 331, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1102564208805150339476236663m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1031, 1144.674369927811m, 1 },
                    { 332, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3061179997036071794871794872m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 975, 1273.465049711017m, 2 },
                    { 333, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4396148723401314606741573034m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 890, 1281.257236382717m, 3 },
                    { 334, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8860942707859060606060606061m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 660, 1244.822218718698m, 4 },
                    { 335, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0316819678045306971904266389m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 961, 991.446371060154m, 5 },
                    { 336, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6959868270340642857142857143m, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 700, 1187.190778923845m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 337, 4, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3669339035934956195244055069m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 799, 1092.180188971203m, 1 },
                    { 338, 3, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.15776537261883760092272203m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 867, 1003.7825780605322m, 2 },
                    { 339, 4, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4873010521879204389574759945m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 729, 1084.242467044994m, 3 },
                    { 340, 3, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2151516772796464530892448513m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 874, 1062.042565942411m, 4 },
                    { 341, 4, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0869567508477579250720461095m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1041, 1131.521977632516m, 5 },
                    { 342, 3, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9324048075318638576779026217m, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1068, 995.8083344440306m, 6 },
                    { 343, 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1901592765901661409043112513m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 951, 1131.841472037248m, 1 },
                    { 344, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3097901487820532786885245902m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 976, 1278.355185211284m, 2 },
                    { 345, 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.130439920622658804347826087m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 920, 1040.0047269728461m, 3 },
                    { 346, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.995700718716637852593266606m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1099, 1094.275089869585m, 4 },
                    { 347, 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9960703948123155430711610487m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1068, 1063.803181659553m, 5 },
                    { 348, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0028664028938984466019417476m, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1030, 1032.9523949807154m, 6 },
                    { 349, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2571295060367861842105263158m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 912, 1146.502109505549m, 1 },
                    { 350, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7174349363659342465753424658m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 730, 1253.727503547132m, 2 },
                    { 351, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3987400124587772020725388601m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 772, 1079.827289618176m, 3 },
                    { 352, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4684321157317779940119760479m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 668, 980.9126533088277m, 4 },
                    { 353, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5479812479485632352941176471m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 680, 1052.627248605023m, 5 },
                    { 354, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4490006488677452300785634119m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 891, 1291.059578141161m, 6 },
                    { 355, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5157833974193137789904502046m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 733, 1111.069230308357m, 1 },
                    { 356, 3, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3648147233408414634146341463m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 820, 1119.14807313949m, 2 },
                    { 357, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4165243048547257261410788382m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 723, 1024.1470724099667m, 3 },
                    { 358, 3, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1871086731047040714995034757m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1007, 1195.418433816437m, 4 },
                    { 359, 4, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1844453538630356115107913669m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 834, 987.8274251217717m, 5 },
                    { 360, 3, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.266968477887325748502994012m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 835, 1057.918679035917m, 6 },
                    { 361, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5643630181760412782956058589m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 751, 1174.836626650207m, 1 },
                    { 362, 3, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3544757160843848797250859107m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 873, 1182.457300141668m, 2 },
                    { 363, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4146998856411764705882352941m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 748, 1058.1955144596m, 3 },
                    { 364, 3, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0960242560230865037194473964m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 941, 1031.3588249177244m, 4 },
                    { 365, 4, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3181343809236175847457627119m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 944, 1244.318855591895m, 5 },
                    { 366, 3, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0579651606463158110882956879m, new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 974, 1030.4580664695116m, 6 },
                    { 367, 4, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4597268614997787391841779975m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 809, 1180.919030953321m, 1 },
                    { 368, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1962201915343490364025695931m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 934, 1117.269658893082m, 2 },
                    { 369, 4, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6086686966062605905006418485m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 779, 1253.152914656277m, 3 },
                    { 370, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0785597767782454361054766734m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 986, 1063.45993990335m, 4 },
                    { 371, 4, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1794290072687545551982851018m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 933, 1100.407263781748m, 5 },
                    { 372, 3, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2617448532746817155756207675m, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 886, 1117.905940001368m, 6 },
                    { 373, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1835711303370746543778801843m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1085, 1284.174676415726m, 1 },
                    { 374, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9135181609906759225092250923m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1084, 990.2536865138927m, 2 },
                    { 375, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1395638651143181818181818182m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 880, 1002.8162013006m, 3 },
                    { 376, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3975693646129464068209500609m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 821, 1147.404448347229m, 4 },
                    { 377, 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0163245063964018264840182648m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1095, 1112.87533450406m, 5 },
                    { 378, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.173467768492664321608040201m, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 995, 1167.600429650201m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 379, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2931502522481831474597273854m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 807, 1043.5722535642838m, 1 },
                    { 380, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9962906846215263157894736842m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1083, 1078.982811445113m, 2 },
                    { 381, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4912186905498304297328687573m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 861, 1283.939292563404m, 3 },
                    { 382, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5131463874519526542324246772m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 697, 1054.663032054011m, 4 },
                    { 383, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2442205074376151298701298701m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 770, 958.04979072696365m, 5 },
                    { 384, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3919097195614880803011292346m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 797, 1109.352046490506m, 6 },
                    { 385, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7488575203562218978102189781m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 685, 1197.967401444012m, 1 },
                    { 386, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4411962407715775m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 800, 1152.956992617262m, 2 },
                    { 387, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6183730665609739243807040417m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 767, 1241.292142052267m, 3 },
                    { 388, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5630021999728688293370944993m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 709, 1108.168559780764m, 4 },
                    { 389, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.08034495658009m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 920, 993.9173600536828m, 5 },
                    { 390, 3, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3935664442697932379713914174m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 769, 1071.652595643471m, 6 },
                    { 391, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3245087719987733163913595934m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 787, 1042.3884035630346m, 1 },
                    { 392, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2145159959018660531697341513m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 978, 1187.796643992025m, 2 },
                    { 393, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9035267588440515151515151515m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1089, 983.9406403811721m, 3 },
                    { 394, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3590334904949699074074074074m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 864, 1174.204935787654m, 4 },
                    { 395, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2608174850764733796296296296m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 864, 1089.346307106073m, 5 },
                    { 396, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3994413699342983739837398374m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 738, 1032.7877310115122m, 6 },
                    { 397, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7847458058132214182344428365m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 691, 1233.259351816936m, 1 },
                    { 398, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3114206171285600461893764434m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 866, 1135.690254433333m, 2 },
                    { 399, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.38234779555112375m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 800, 1105.878236440899m, 3 },
                    { 400, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.8676328846146602728767123288m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1095, 950.0580086530529988m, 4 },
                    { 401, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2078948527134754098360655738m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 915, 1105.22379023283m, 5 },
                    { 402, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1822974309888939814814814815m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 864, 1021.5049803744044m, 6 },
                    { 403, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5929936170184864479315263909m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 701, 1116.688525529959m, 1 },
                    { 404, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9995802407231024667931688805m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1054, 1053.55757372215m, 2 },
                    { 405, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5259738958181284848484848485m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 825, 1258.928464049956m, 3 },
                    { 406, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6549272489423247753530166881m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 779, 1289.188326926071m, 4 },
                    { 407, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.160505007228031747572815534m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 824, 956.25612595589816m, 5 },
                    { 408, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3800784482437475741239892183m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 742, 1024.0182085968607m, 6 },
                    { 409, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5894181872088147590361445783m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 664, 1055.373676306653m, 1 },
                    { 410, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.081586745494718645948945616m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 901, 974.5096576907415m, 2 },
                    { 411, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3666574859952764857881136951m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 774, 1057.792894160344m, 3 },
                    { 412, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0487584562189256270447110142m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 917, 961.7115043527548m, 4 },
                    { 413, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3456061662901388550548112058m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 821, 1104.742662524204m, 5 },
                    { 414, 3, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2569431646361888772298006296m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 953, 1197.866835898288m, 6 },
                    { 415, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1266513669755355216881594373m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 853, 961.0336160301318m, 1 },
                    { 416, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2781513865554785005512679162m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 907, 1159.283307605819m, 2 },
                    { 417, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4550725944209772727272727273m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 880, 1280.46388309046m, 3 },
                    { 418, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1950978253339136316337148803m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 961, 1148.489010145891m, 4 },
                    { 419, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3203601570450358189081225033m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 751, 991.5904779408219m, 5 },
                    { 420, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2510930382920476190476190476m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1029, 1287.374736402517m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 421, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9641604267341667305751765893m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 991, 955.48298289355923m, 1 },
                    { 422, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2609200977431731374606505771m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 953, 1201.656853149244m, 2 },
                    { 423, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2274032490437524861878453039m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 905, 1110.799940384596m, 3 },
                    { 424, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8310577992843013100436681223m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 687, 1257.936708108315m, 4 },
                    { 425, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.096815759293674972191323693m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 899, 986.0373676050138m, 5 },
                    { 426, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1748449925581485239852398524m, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1084, 1273.531971933033m, 6 },
                    { 427, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1872832792804938820912124583m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 899, 1067.367668073164m, 1 },
                    { 428, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3542547103379350335570469799m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 745, 1008.9197592017616m, 2 },
                    { 429, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1886799837656598890942698706m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1082, 1286.151742434444m, 3 },
                    { 430, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0186284226945482897384305835m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 994, 1012.516652158381m, 4 },
                    { 431, 4, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.579751376196448714069591528m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 661, 1044.2156596658526m, 5 },
                    { 432, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0653597153888398348813209494m, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 969, 1032.3335642117858m, 6 },
                    { 433, 4, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3467508534351089635854341737m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 714, 961.5801093526678m, 1 },
                    { 434, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2098903317204612781954887218m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 798, 965.4924847129281m, 2 },
                    { 435, 4, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4606558102019096181046676096m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 707, 1032.6836578127501m, 3 },
                    { 436, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2706431306095748756218905473m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 1021.5970770100982m, 4 },
                    { 437, 4, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0664847147400547818012999071m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1077, 1148.604037775039m, 5 },
                    { 438, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9926204853394154291224686596m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1037, 1029.3474432969738m, 6 },
                    { 439, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0870813333373862275449101796m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1002, 1089.255496004061m, 1 },
                    { 440, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4274637387535973389355742297m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 714, 1019.2091094700685m, 2 },
                    { 441, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0024576316871532738095238095m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1008, 1010.4772927406505m, 3 },
                    { 442, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9378593645771525092936802974m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1076, 1009.1366762850161m, 4 },
                    { 443, 4, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9847935621888361352657004831m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1035, 1019.2613368654454m, 5 },
                    { 444, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1427996702490085959885386819m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1047, 1196.511254750712m, 6 },
                    { 445, 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9818935642947140221402214022m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1084, 1064.37262369547m, 1 },
                    { 446, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3237202253479288702928870293m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 956, 1265.47653543262m, 2 },
                    { 447, 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0681885051366302605210420842m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 998, 1066.052128126357m, 3 },
                    { 448, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4347435490148840228245363766m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 701, 1005.7552278594337m, 4 },
                    { 449, 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0931968756682164179104477612m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1072, 1171.907050716328m, 5 },
                    { 450, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.321034682696865702479338843m, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 968, 1278.761572850566m, 6 },
                    { 451, 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3581587601782381974248927039m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 932, 1265.803964486118m, 1 },
                    { 452, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.58786059514226953125m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 768, 1219.476937069263m, 2 },
                    { 453, 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9484031642890345437616387337m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1074, 1018.5849984464231m, 3 },
                    { 454, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0880467301229122857142857143m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 875, 952.04088885754825m, 4 },
                    { 455, 4, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4701921788175306818181818182m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 704, 1035.0152938875416m, 5 },
                    { 456, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6320522463128444148936170213m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 752, 1227.303289227259m, 6 },
                    { 457, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1626834353909328277356446371m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 923, 1073.156810865831m, 1 },
                    { 458, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3253455100731801849405548217m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 757, 1003.2865511253974m, 2 },
                    { 459, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.921934015216050381679389313m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 655, 1258.866779966513m, 3 },
                    { 460, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2550106193899035294117647059m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 850, 1066.759026481418m, 4 },
                    { 461, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6183213105090678617157490397m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 781, 1263.908943507582m, 5 },
                    { 462, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0886796164026377245508982036m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1002, 1090.856975635443m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 463, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.062800204317181651376146789m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1090, 1158.452222705728m, 1 },
                    { 464, 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1568978494369951409135082604m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1029, 1190.447887070668m, 2 },
                    { 465, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0661250751552859139784946237m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 930, 991.4963198944159m, 3 },
                    { 466, 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5103774243837779329608938547m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 716, 1081.430235858785m, 4 },
                    { 467, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4836578555682554838709677419m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 775, 1149.834838065398m, 5 },
                    { 468, 3, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1285508648938939670932358318m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1094, 1234.63464619392m, 6 },
                    { 469, 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2307422098908721174004192872m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 954, 1174.128068235892m, 1 },
                    { 470, 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0207497813081312810327706058m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1007, 1027.8950297772882m, 2 },
                    { 471, 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4025936640471220143884892086m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 695, 974.8025965127498m, 3 },
                    { 472, 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.683637198896527007299270073m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 685, 1153.291481244121m, 4 },
                    { 473, 4, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0503563414142735263702171665m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 967, 1015.6945821476025m, 5 },
                    { 474, 3, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9092939449930446494464944649m, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1084, 985.6746363724604m, 6 },
                    { 475, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2808520016022613636363636364m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 880, 1127.14976140999m, 1 },
                    { 476, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2229832053941031122448979592m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 784, 958.81883302897684m, 2 },
                    { 477, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2502203063836945917285259809m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 943, 1178.957748919824m, 3 },
                    { 478, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4468433836450036231884057971m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 828, 1197.986321658063m, 4 },
                    { 479, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7146829344798959459459459459m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 740, 1268.865371515123m, 5 },
                    { 480, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3726917006540638297872340426m, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 893, 1225.813688684079m, 6 },
                    { 481, 4, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0626106048613311132254995243m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1051, 1116.803745709259m, 1 },
                    { 482, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3579105634116758045292014303m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 839, 1139.286962702396m, 2 },
                    { 483, 4, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5323271974166169154228855721m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 1231.99106672296m, 3 },
                    { 484, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3227126019452458333333333333m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 960, 1269.804097867436m, 4 },
                    { 485, 4, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2646965827269182968929804373m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 869, 1099.021330389692m, 5 },
                    { 486, 3, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.227864294669021640903686088m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 841, 1032.6338718166472m, 6 },
                    { 487, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.938189902312936036866359447m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1085, 1017.9360440095356m, 1 },
                    { 488, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.9052097142247058823529411765m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 680, 1295.5426056728m, 2 },
                    { 489, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.394342814981256m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 875, 1220.049963108599m, 3 },
                    { 490, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3274345407213874862788144896m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 911, 1209.292866597184m, 4 },
                    { 491, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3910048767211901041666666667m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 768, 1068.291745321874m, 5 },
                    { 492, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1320984986943363834422657952m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 918, 1039.2664218014008m, 6 },
                    { 493, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4832004616658794901506373117m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 863, 1280.001998417654m, 1 },
                    { 494, 3, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.8946674455403826530612244898m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1078, 964.4515062925325m, 2 },
                    { 495, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2910523050723913533834586466m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 798, 1030.2597394477683m, 3 },
                    { 496, 3, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.453891353068316622691292876m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 758, 1102.049645625784m, 4 },
                    { 497, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.875959150620309471766848816m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1098, 961.8031473810998m, 5 },
                    { 498, 3, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1869270623880608799048751486m, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 841, 998.2056594683592m, 6 },
                    { 499, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4617625984310859375m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 768, 1122.633675595074m, 1 },
                    { 500, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4154847074513346666666666667m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 750, 1061.613530588501m, 2 },
                    { 501, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4936690393322082853855005754m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 869, 1297.998395179689m, 3 },
                    { 502, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1828589187507991021324354658m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 891, 1053.927296606962m, 4 },
                    { 503, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5526634150120843023255813953m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 688, 1068.232429528314m, 5 },
                    { 504, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4139121712348570535714285714m, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 672, 950.14897906982394m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 505, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1453001912397161556603773585m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 848, 971.2145621712793m, 1 },
                    { 506, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9436824251654907649253731343m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1072, 1011.6275597774061m, 2 },
                    { 507, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2405756781862583732057416268m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1045, 1296.40158370464m, 3 },
                    { 508, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.985333220986183752417794971m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1034, 1018.834550499714m, 4 },
                    { 509, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4337039954521529709228824273m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 791, 1134.059860402653m, 5 },
                    { 510, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9973146627532139491046182846m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1061, 1058.15085718116m, 6 },
                    { 511, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4586133547813501470588235294m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 680, 991.8570812513181m, 1 },
                    { 512, 3, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1702032253520604288499025341m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1026, 1200.628509211214m, 2 },
                    { 513, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4527447473160065876152832675m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 759, 1102.633263212849m, 3 },
                    { 514, 3, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4207664277461338616714697406m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, 986.0119008558169m, 4 },
                    { 515, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9696388358831297270955165692m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1026, 994.8494456160911m, 5 },
                    { 516, 3, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4513387158518780160857908847m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 746, 1082.698682025501m, 6 },
                    { 517, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9772132853384030505243088656m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1049, 1025.0967363199848m, 1 },
                    { 518, 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2067413692135660980810234542m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 938, 1131.923404322325m, 2 },
                    { 519, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1306737709531466414380321665m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1057, 1195.122175897476m, 3 },
                    { 520, 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4621720179159656695156695157m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 702, 1026.4447565770079m, 4 },
                    { 521, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7948045462690043227665706052m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 694, 1245.594355110689m, 5 },
                    { 522, 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.500295387804151970802919708m, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 685, 1027.7023406458441m, 6 },
                    { 523, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7565582955234742120343839542m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 698, 1226.077690275385m, 1 },
                    { 524, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3695106590005634423897581792m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 962.7659932773961m, 2 },
                    { 525, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4122415955322891970802919708m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 685, 967.3854929396181m, 3 },
                    { 526, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5797954265560412746585735964m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 659, 1041.0851861004312m, 4 },
                    { 527, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3840019077307810140237324703m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 927, 1282.969768466434m, 5 },
                    { 528, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1411958793240417486338797814m, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 915, 1044.1942295814982m, 6 },
                    { 529, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1239910558891390677025527192m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 901, 1012.7159413561143m, 1 },
                    { 530, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9511490974739147619047619048m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1050, 998.7065523476105m, 2 },
                    { 531, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3374314569405538461538461538m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 845, 1130.129581114768m, 3 },
                    { 532, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1564268687268601921024546425m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 937, 1083.571975997068m, 4 },
                    { 533, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.237406004393m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 860, 1064.16916377798m, 5 },
                    { 534, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4903704804531699507389162562m, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 812, 1210.180830127974m, 6 },
                    { 535, 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1145759041834074074074074074m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 999, 1113.461328279224m, 1 },
                    { 536, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4698507658760011560693641618m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 692, 1017.1367299861928m, 2 },
                    { 537, 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2904928318862717661691542289m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 804, 1037.5562368365625m, 3 },
                    { 538, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6566672433831797432239657632m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 701, 1161.323737611609m, 4 },
                    { 539, 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6683399723944064171122994652m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 748, 1247.918299351016m, 5 },
                    { 540, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5340010877807003072196620584m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 998.6347081452359m, 6 },
                    { 541, 4, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7969180510784076704545454545m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 704, 1265.030307959199m, 1 },
                    { 542, 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.572581599820689873417721519m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 790, 1242.339463858345m, 2 },
                    { 543, 4, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1332445682571325178389398573m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 981, 1111.712921460247m, 3 },
                    { 544, 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3424915450446787292817679558m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 724, 971.9638786123474m, 4 },
                    { 545, 4, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1594481751009037166085946574m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 861, 998.2848787618781m, 5 },
                    { 546, 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9934106026949222846441947566m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1068, 1060.962523678177m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 547, 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0376197596504079457364341085m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1032, 1070.823591959221m, 1 },
                    { 548, 3, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.317457998505214902807775378m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 926, 1219.966106615829m, 2 },
                    { 549, 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5251725073950486153846153846m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 650, 991.3621298067816m, 3 },
                    { 550, 3, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0492813785962889699179580675m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1097, 1151.061672320129m, 4 },
                    { 551, 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6674920486708740399385560676m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 651, 1085.537323684739m, 5 },
                    { 552, 3, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1149352048337447084233261339m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 926, 1032.4299996760476m, 6 },
                    { 553, 4, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1298661824824323756906077348m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 905, 1022.5288951466013m, 1 },
                    { 554, 3, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3757924735525014224751066856m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 703, 967.1821089074085m, 2 },
                    { 555, 4, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5299385758692188059701492537m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 670, 1025.0588458323766m, 3 },
                    { 556, 3, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3707946696638870588235294118m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 850, 1165.175469214304m, 4 },
                    { 557, 4, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9914511834842788617886178862m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 984, 975.5879645485304m, 5 },
                    { 558, 3, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7261828380472732824427480916m, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 655, 1130.649758920964m, 6 },
                    { 559, 4, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1336197015066535648994515539m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1094, 1240.179953448279m, 1 },
                    { 560, 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3416790971056487376509330406m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 911, 1222.269657463246m, 2 },
                    { 561, 4, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7228054747499698630136986301m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 730, 1257.647996567478m, 3 },
                    { 562, 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6110410454331768901569186876m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 701, 1129.339772848657m, 4 },
                    { 563, 4, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3645799297866026785714285714m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 896, 1222.663617088796m, 5 },
                    { 564, 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4141021392357452229299363057m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 785, 1110.07017930006m, 6 },
                    { 565, 4, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2638222378470374609781477627m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 961, 1214.533170571003m, 1 },
                    { 566, 3, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2966617408585496957403651116m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 986, 1278.50847648653m, 2 },
                    { 567, 4, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1336971222690090382387022016m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 863, 978.3806165181548m, 3 },
                    { 568, 3, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3906613028795596133190118153m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 931, 1294.70567298087m, 4 },
                    { 569, 4, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3615830922254507265521796565m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 757, 1030.7184008146662m, 5 },
                    { 570, 3, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9795470593900487329434697856m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1026, 1005.01528293419m, 6 },
                    { 571, 4, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2847130497817179203539823009m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 904, 1161.380597002673m, 1 },
                    { 572, 3, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0494733397603605235602094241m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 955, 1002.2470394711443m, 2 },
                    { 573, 4, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0159094522864632337246531483m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 937, 951.90715679241605m, 3 },
                    { 574, 3, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5871628463248607038123167155m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 682, 1082.445061193555m, 4 },
                    { 575, 4, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3765053488335812917594654788m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 898, 1236.101803252556m, 5 },
                    { 576, 3, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9638219336965905044510385757m, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1011, 974.423974967253m, 6 },
                    { 577, 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.9727243289728550561797752809m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1068, 1038.8695833430092m, 1 },
                    { 578, 3, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2978706964128595438175270108m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 833, 1081.126290111912m, 2 },
                    { 579, 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.318115359554228310502283105m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 876, 1154.669054969504m, 3 },
                    { 580, 3, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2150026120523453510436432638m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1054, 1280.612753103172m, 4 },
                    { 581, 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2026028620294770742358078603m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 916, 1101.584221619001m, 5 },
                    { 582, 3, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4029242932005680575539568345m, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 695, 975.0323837743948m, 6 },
                    { 583, 4, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3460575381817822489391796322m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 707, 951.66267949452005m, 1 },
                    { 584, 3, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3803976729857954815695600476m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 841, 1160.914442981054m, 2 },
                    { 585, 4, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2630809887871343612334801762m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 908, 1146.877537818718m, 3 },
                    { 586, 3, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4082038777100966952264381885m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 817, 1150.502568089149m, 4 },
                    { 587, 4, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4542750549044624641833810888m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 698, 1015.0839883233148m, 5 },
                    { 588, 3, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1519680479266567796610169492m, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 944, 1087.457837242764m, 6 }
                });

            migrationBuilder.InsertData(
                table: "Tripes",
                columns: new[] { "Id", "EmployeeId", "EndDate", "EuPerKm", "StartDate", "TripKm", "TripPrice", "TruckId" },
                values: new object[,]
                {
                    { 589, 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5176513040740627352572145546m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 797, 1209.568089347028m, 1 },
                    { 590, 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.1087146937920280082987551867m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 964, 1068.800964815515m, 2 },
                    { 591, 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.3383119218567275747508305648m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 903, 1208.495665436625m, 3 },
                    { 592, 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.4798084500547516254876462939m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 769, 1137.972698092104m, 4 },
                    { 593, 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.2241960804306545454545454545m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 935, 1144.623335202662m, 5 },
                    { 594, 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0439952175357287086446104589m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 937, 978.2235188309778m, 6 }
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
                    { 1, 7, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 953.64772626312552m, 1 },
                    { 2, 1, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1259.727204606021m, 2 },
                    { 3, 5, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 964.8820385768761m, 3 },
                    { 4, 3, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1060.055156496179m, 4 },
                    { 5, 7, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1038.1241861551183m, 5 },
                    { 6, 1, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1021.2811676375027m, 6 },
                    { 7, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1224.232575812068m, 7 },
                    { 8, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1217.013651903513m, 8 },
                    { 9, 5, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1112.746020726297m, 9 },
                    { 10, 8, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 951.12737167009369m, 10 },
                    { 11, 4, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1275.860786875803m, 11 },
                    { 12, 10, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1212.627855510698m, 12 },
                    { 13, 10, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1228.198046636751m, 13 },
                    { 14, 6, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1248.610002084489m, 14 },
                    { 15, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1238.466168699433m, 15 },
                    { 16, 2, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1139.837290612115m, 16 },
                    { 17, 5, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1129.904851234225m, 17 },
                    { 18, 7, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1124.396271721953m, 18 },
                    { 19, 10, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1288.737079602836m, 19 },
                    { 20, 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1258.582351394996m, 20 },
                    { 21, 2, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1226.793440676119m, 21 },
                    { 22, 4, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1146.008697471457m, 22 },
                    { 23, 2, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1244.343676156042m, 23 },
                    { 24, 5, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1136.538265279308m, 24 },
                    { 25, 4, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1121.068142400158m, 25 },
                    { 26, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1051.28971507598m, 26 },
                    { 27, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 992.701741058491m, 27 },
                    { 28, 5, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1018.5990341355352m, 28 },
                    { 29, 3, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1043.5660295417588m, 29 },
                    { 30, 8, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1136.314128101814m, 30 },
                    { 31, 9, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1009.1858350534894m, 31 },
                    { 32, 9, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1222.811540415267m, 32 },
                    { 33, 4, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1133.568597440447m, 33 },
                    { 34, 7, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1274.681118200222m, 34 },
                    { 35, 7, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 977.1309434893027m, 35 },
                    { 36, 5, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1132.142241366306m, 36 },
                    { 37, 10, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.587512231512m, 37 },
                    { 38, 10, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1020.7290453455623m, 38 },
                    { 39, 6, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1130.960733239929m, 39 },
                    { 40, 3, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1177.354484689982m, 40 },
                    { 41, 8, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1004.9418187947809m, 41 },
                    { 42, 7, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1206.250270950073m, 42 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 43, 6, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1239.002638554133m, 43 },
                    { 44, 2, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1007.6646253146076m, 44 },
                    { 45, 7, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1054.418152959955m, 45 },
                    { 46, 3, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 984.612053111433m, 46 },
                    { 47, 3, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1108.503047724219m, 47 },
                    { 48, 4, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 998.7918945574878m, 48 },
                    { 49, 10, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1100.765759412158m, 49 },
                    { 50, 9, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1105.005631909485m, 50 },
                    { 51, 3, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1251.412769466884m, 51 },
                    { 52, 6, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1035.9605681206513m, 52 },
                    { 53, 10, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1019.7378755958511m, 53 },
                    { 54, 5, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1117.458976016514m, 54 },
                    { 55, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1120.139791671306m, 55 },
                    { 56, 5, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1061.199705164491m, 56 },
                    { 57, 10, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1112.211730370041m, 57 },
                    { 58, 5, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1109.561371691467m, 58 },
                    { 59, 8, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 979.403738649729m, 59 },
                    { 60, 3, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1125.815979429245m, 60 },
                    { 61, 7, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1189.976490519818m, 61 },
                    { 62, 6, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1090.295969923764m, 62 },
                    { 63, 8, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1088.479901890648m, 63 },
                    { 64, 6, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1099.131764082766m, 64 },
                    { 65, 9, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1214.888538005886m, 65 },
                    { 66, 5, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 954.29131397026877m, 66 },
                    { 67, 7, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1037.3344445192397m, 67 },
                    { 68, 10, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1119.319120986771m, 68 },
                    { 69, 10, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1160.343132340124m, 69 },
                    { 70, 4, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1060.86152938334m, 70 },
                    { 71, 8, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1275.071993880648m, 71 },
                    { 72, 9, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1054.67297340411m, 72 },
                    { 73, 10, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1191.952832407898m, 73 },
                    { 74, 1, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1166.520073446356m, 74 },
                    { 75, 10, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1255.756870484289m, 75 },
                    { 76, 3, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1003.6278386530758m, 76 },
                    { 77, 7, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1091.952456761921m, 77 },
                    { 78, 9, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1135.664235819814m, 78 },
                    { 79, 2, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1221.046441525663m, 79 },
                    { 80, 6, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1019.5688972095128m, 80 },
                    { 81, 8, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1028.8997826812889m, 81 },
                    { 82, 1, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1104.078108899512m, 82 },
                    { 83, 10, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1215.646902469317m, 83 },
                    { 84, 8, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1141.826028551688m, 84 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 85, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1170.427342753212m, 85 },
                    { 86, 2, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1019.6850432831139m, 86 },
                    { 87, 4, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1166.463448475388m, 87 },
                    { 88, 9, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 958.12054083422256m, 88 },
                    { 89, 2, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1262.483816138326m, 89 },
                    { 90, 5, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 978.7102604804874m, 90 },
                    { 91, 10, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1075.408077945943m, 91 },
                    { 92, 5, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1013.8929041694028m, 92 },
                    { 93, 4, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1122.605600480514m, 93 },
                    { 94, 2, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1065.226066932087m, 94 },
                    { 95, 1, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1129.948666773001m, 95 },
                    { 96, 5, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 950.56563180855288m, 96 },
                    { 97, 4, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1130.334573546505m, 97 },
                    { 98, 5, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1293.570102713902m, 98 },
                    { 99, 1, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1199.6641165947m, 99 },
                    { 100, 9, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 952.98055522583886m, 100 },
                    { 101, 7, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1213.048731460163m, 101 },
                    { 102, 9, new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.941148675556m, 102 },
                    { 103, 1, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1150.974373235742m, 103 },
                    { 104, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1086.015297016326m, 104 },
                    { 105, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1074.96369451937m, 105 },
                    { 106, 4, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 958.62830067500282m, 106 },
                    { 107, 6, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1265.314667207721m, 107 },
                    { 108, 8, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1233.970481928144m, 108 },
                    { 109, 1, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 999.471399813043m, 109 },
                    { 110, 5, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1059.790040878104m, 110 },
                    { 111, 1, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1257.578692662294m, 111 },
                    { 112, 9, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1089.622623355703m, 112 },
                    { 113, 2, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 967.842344698986m, 113 },
                    { 114, 6, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1051.132425478663m, 114 },
                    { 115, 7, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1272.040434988716m, 115 },
                    { 116, 2, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1245.257582061428m, 116 },
                    { 117, 7, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1247.119823009724m, 117 },
                    { 118, 6, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1142.398619135133m, 118 },
                    { 119, 6, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1292.939944096527m, 119 },
                    { 120, 8, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1009.0312033483492m, 120 },
                    { 121, 5, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 998.58102143732m, 121 },
                    { 122, 6, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1189.191466659947m, 122 },
                    { 123, 7, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1274.566605825222m, 123 },
                    { 124, 9, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1296.538134979654m, 124 },
                    { 125, 4, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1245.695394855009m, 125 },
                    { 126, 10, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1259.758959806314m, 126 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 127, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 963.3131336211626m, 127 },
                    { 128, 7, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1116.108249009475m, 128 },
                    { 129, 2, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1268.656292600132m, 129 },
                    { 130, 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1234.518239662915m, 130 },
                    { 131, 9, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 972.3442804712439m, 131 },
                    { 132, 8, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1051.420173426032m, 132 },
                    { 133, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1029.3490737380984m, 133 },
                    { 134, 2, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1153.237286907096m, 134 },
                    { 135, 6, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1220.084201764098m, 135 },
                    { 136, 6, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1185.274355301046m, 136 },
                    { 137, 1, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1092.768406283787m, 137 },
                    { 138, 4, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 963.1554428777573m, 138 },
                    { 139, 5, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 985.1860660767161m, 139 },
                    { 140, 10, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1006.3549306121749m, 140 },
                    { 141, 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1136.720706733279m, 141 },
                    { 142, 9, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1185.492897964722m, 142 },
                    { 143, 7, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1299.810351371177m, 143 },
                    { 144, 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1000.7976618345146m, 144 },
                    { 145, 9, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1075.298701969937m, 145 },
                    { 146, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1264.533846941229m, 146 },
                    { 147, 3, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1182.164661732739m, 147 },
                    { 148, 4, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1254.529793245452m, 148 },
                    { 149, 8, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1170.840305702622m, 149 },
                    { 150, 7, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 978.797547549421m, 150 },
                    { 151, 4, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1259.302025877819m, 151 },
                    { 152, 6, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1280.964029569981m, 152 },
                    { 153, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1077.593299790615m, 153 },
                    { 154, 3, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1035.2574889129555m, 154 },
                    { 155, 6, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1021.2753861032877m, 155 },
                    { 156, 10, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1077.57101918659m, 156 },
                    { 157, 4, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1141.060244962752m, 157 },
                    { 158, 5, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1204.005636893351m, 158 },
                    { 159, 8, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1213.584069572931m, 159 },
                    { 160, 2, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1003.9009201391586m, 160 },
                    { 161, 2, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1077.386028306449m, 161 },
                    { 162, 5, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1067.975335046151m, 162 },
                    { 163, 1, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1212.182010210178m, 163 },
                    { 164, 7, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 951.64714035275149m, 164 },
                    { 165, 3, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 966.3381869441706m, 165 },
                    { 166, 4, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1295.677119522306m, 166 },
                    { 167, 1, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1223.351715295695m, 167 },
                    { 168, 6, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1121.583312293192m, 168 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 169, 7, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 960.1517784912246m, 169 },
                    { 170, 9, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1279.634909805972m, 170 },
                    { 171, 5, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1154.036727768767m, 171 },
                    { 172, 8, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1144.758138046779m, 172 },
                    { 173, 6, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 995.2463610178636m, 173 },
                    { 174, 8, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1000.7503641964951m, 174 },
                    { 175, 7, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1125.680107571943m, 175 },
                    { 176, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1141.413210154803m, 176 },
                    { 177, 1, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1124.235967844622m, 177 },
                    { 178, 4, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 985.4171446695433m, 178 },
                    { 179, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1046.3470149646075m, 179 },
                    { 180, 10, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1188.172997675865m, 180 },
                    { 181, 6, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1088.290003877688m, 181 },
                    { 182, 10, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1084.229326968492m, 182 },
                    { 183, 1, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1137.66565379753m, 183 },
                    { 184, 4, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1159.697924216486m, 184 },
                    { 185, 9, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1254.592423466761m, 185 },
                    { 186, 7, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1046.5507889976448m, 186 },
                    { 187, 8, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1088.756085917677m, 187 },
                    { 188, 2, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1110.812434695222m, 188 },
                    { 189, 8, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1097.847929622859m, 189 },
                    { 190, 9, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1003.4899216393482m, 190 },
                    { 191, 8, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1188.818385793618m, 191 },
                    { 192, 5, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1292.434714936102m, 192 },
                    { 193, 9, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1053.386158412543m, 193 },
                    { 194, 9, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1274.140480072027m, 194 },
                    { 195, 9, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1171.100669772006m, 195 },
                    { 196, 8, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1128.499069454367m, 196 },
                    { 197, 8, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1155.433640672304m, 197 },
                    { 198, 2, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1045.6437306155307m, 198 },
                    { 199, 5, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1194.488996541871m, 199 },
                    { 200, 8, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1224.494526764142m, 200 },
                    { 201, 2, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1115.96122319344m, 201 },
                    { 202, 8, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1164.569113253056m, 202 },
                    { 203, 4, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 967.6124456855167m, 203 },
                    { 204, 8, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1252.856830149075m, 204 },
                    { 205, 7, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1161.105958355847m, 205 },
                    { 206, 10, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1213.568284584116m, 206 },
                    { 207, 10, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 972.7762378544146m, 207 },
                    { 208, 2, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 978.4465943800875m, 208 },
                    { 209, 7, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1171.621025117276m, 209 },
                    { 210, 3, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1011.2616896539046m, 210 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 211, 6, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1248.079650889772m, 211 },
                    { 212, 7, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1216.62650113593m, 212 },
                    { 213, 2, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1161.00758779114m, 213 },
                    { 214, 10, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1183.066113383223m, 214 },
                    { 215, 2, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1283.499184374756m, 215 },
                    { 216, 5, new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1138.437407063048m, 216 },
                    { 217, 1, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1038.3383903548585m, 217 },
                    { 218, 6, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1199.764026327167m, 218 },
                    { 219, 1, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1290.595812978386m, 219 },
                    { 220, 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1016.9928325062568m, 220 },
                    { 221, 6, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1210.943818528124m, 221 },
                    { 222, 9, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 964.6656925326m, 222 },
                    { 223, 2, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1163.44176055875m, 223 },
                    { 224, 9, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1029.5444885338926m, 224 },
                    { 225, 4, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1250.208787793726m, 225 },
                    { 226, 10, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1189.403803719289m, 226 },
                    { 227, 2, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 974.8030479863582m, 227 },
                    { 228, 2, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1239.992929006375m, 228 },
                    { 229, 10, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1084.83409503004m, 229 },
                    { 230, 10, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1042.3732951314442m, 230 },
                    { 231, 4, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1214.999967404053m, 231 },
                    { 232, 2, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1115.304980966832m, 232 },
                    { 233, 1, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1000.3356419433025m, 233 },
                    { 234, 2, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1011.2911669275432m, 234 },
                    { 235, 10, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1046.2144476780797m, 235 },
                    { 236, 2, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1143.705285236761m, 236 },
                    { 237, 8, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1232.348191777573m, 237 },
                    { 238, 8, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1173.669690137481m, 238 },
                    { 239, 8, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1050.192847678751m, 239 },
                    { 240, 6, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 954.26532778686603m, 240 },
                    { 241, 2, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 950.379728312543914m, 241 },
                    { 242, 5, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1091.000167227825m, 242 },
                    { 243, 1, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1184.7006326942m, 243 },
                    { 244, 8, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1211.361050104094m, 244 },
                    { 245, 6, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1143.52629481243m, 245 },
                    { 246, 5, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1148.881472306048m, 246 },
                    { 247, 8, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1295.210181098516m, 247 },
                    { 248, 3, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1104.020526276769m, 248 },
                    { 249, 8, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 982.2157544017597m, 249 },
                    { 250, 2, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1153.714553315302m, 250 },
                    { 251, 10, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1032.4428948374623m, 251 },
                    { 252, 8, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1152.520002477929m, 252 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 253, 7, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1289.461289855325m, 253 },
                    { 254, 2, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 971.3871750799225m, 254 },
                    { 255, 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1236.129846156239m, 255 },
                    { 256, 5, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1088.805025986903m, 256 },
                    { 257, 8, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1030.5609070030105m, 257 },
                    { 258, 1, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1201.32010004332m, 258 },
                    { 259, 1, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 968.9260090094999m, 259 },
                    { 260, 10, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1216.097941466745m, 260 },
                    { 261, 1, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1059.725613778846m, 261 },
                    { 262, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1280.158703369801m, 262 },
                    { 263, 2, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1010.1728869471955m, 263 },
                    { 264, 2, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1194.473699940324m, 264 },
                    { 265, 10, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1274.614150876926m, 265 },
                    { 266, 6, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 992.2710384339423m, 266 },
                    { 267, 7, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1098.488503680929m, 267 },
                    { 268, 9, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1057.947461374699m, 268 },
                    { 269, 10, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1247.06043857391m, 269 },
                    { 270, 9, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 973.9979624270961m, 270 },
                    { 271, 5, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1229.429626271119m, 271 },
                    { 272, 6, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1160.71322257755m, 272 },
                    { 273, 9, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1157.053790469818m, 273 },
                    { 274, 1, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1087.27005406821m, 274 },
                    { 275, 4, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1137.280422763091m, 275 },
                    { 276, 6, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1062.202504741255m, 276 },
                    { 277, 6, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1080.129758426512m, 277 },
                    { 278, 8, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 976.5292060920343m, 278 },
                    { 279, 1, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1138.004628852019m, 279 },
                    { 280, 2, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1066.161458606177m, 280 },
                    { 281, 6, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1238.409095368397m, 281 },
                    { 282, 9, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1044.7343715909254m, 282 },
                    { 283, 6, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 963.029507012256m, 283 },
                    { 284, 1, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1286.052845078095m, 284 },
                    { 285, 10, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1255.831065973792m, 285 },
                    { 286, 7, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1000.1883445213885m, 286 },
                    { 287, 4, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1273.504171174405m, 287 },
                    { 288, 8, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1268.716914506095m, 288 },
                    { 289, 7, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1234.219019330262m, 289 },
                    { 290, 1, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1124.638054652858m, 290 },
                    { 291, 4, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1051.802434077566m, 291 },
                    { 292, 8, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1202.205426982057m, 292 },
                    { 293, 5, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1240.174018383114m, 293 },
                    { 294, 3, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1180.334198848601m, 294 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 295, 1, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1000.6663268227695m, 295 },
                    { 296, 4, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1215.512073645094m, 296 },
                    { 297, 2, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1208.753432655893m, 297 },
                    { 298, 2, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1189.109422420393m, 298 },
                    { 299, 2, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1002.5929598619649m, 299 },
                    { 300, 3, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1168.35082658335m, 300 },
                    { 301, 10, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1052.729585560226m, 301 },
                    { 302, 1, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 997.9331965215729m, 302 },
                    { 303, 2, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 962.5346972247543m, 303 },
                    { 304, 7, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1085.422794905434m, 304 },
                    { 305, 1, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1096.146557070159m, 305 },
                    { 306, 9, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1096.780118341476m, 306 },
                    { 307, 1, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 993.9652039584312m, 307 },
                    { 308, 4, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1275.737529896399m, 308 },
                    { 309, 5, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1171.359524826002m, 309 },
                    { 310, 1, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1179.138281172347m, 310 },
                    { 311, 8, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1265.469115355643m, 311 },
                    { 312, 8, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1294.475811027102m, 312 },
                    { 313, 9, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1047.9192534675734m, 313 },
                    { 314, 5, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1209.409795446497m, 314 },
                    { 315, 5, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1170.8423384036m, 315 },
                    { 316, 1, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1081.470699678609m, 316 },
                    { 317, 4, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1044.6472931669712m, 317 },
                    { 318, 7, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 961.5239044612155m, 318 },
                    { 319, 2, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1095.068209540572m, 319 },
                    { 320, 1, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1200.248889716615m, 320 },
                    { 321, 6, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1261.316901124121m, 321 },
                    { 322, 10, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 963.3050234811697m, 322 },
                    { 323, 5, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1190.686263851369m, 323 },
                    { 324, 3, new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 970.3613459766792m, 324 },
                    { 325, 1, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1285.83693725111m, 325 },
                    { 326, 7, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1065.0820481499m, 326 },
                    { 327, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1069.77514721053m, 327 },
                    { 328, 10, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1164.187184839217m, 328 },
                    { 329, 4, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1005.9133389235019m, 329 },
                    { 330, 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1085.372929814555m, 330 },
                    { 331, 4, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1144.674369927811m, 331 },
                    { 332, 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1273.465049711017m, 332 },
                    { 333, 8, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1281.257236382717m, 333 },
                    { 334, 1, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1244.822218718698m, 334 },
                    { 335, 10, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 991.446371060154m, 335 },
                    { 336, 10, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1187.190778923845m, 336 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 337, 7, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1092.180188971203m, 337 },
                    { 338, 9, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1003.7825780605322m, 338 },
                    { 339, 3, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1084.242467044994m, 339 },
                    { 340, 6, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1062.042565942411m, 340 },
                    { 341, 7, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1131.521977632516m, 341 },
                    { 342, 8, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 995.8083344440306m, 342 },
                    { 343, 9, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1131.841472037248m, 343 },
                    { 344, 1, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1278.355185211284m, 344 },
                    { 345, 3, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1040.0047269728461m, 345 },
                    { 346, 5, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1094.275089869585m, 346 },
                    { 347, 9, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1063.803181659553m, 347 },
                    { 348, 9, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1032.9523949807154m, 348 },
                    { 349, 4, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1146.502109505549m, 349 },
                    { 350, 9, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1253.727503547132m, 350 },
                    { 351, 7, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1079.827289618176m, 351 },
                    { 352, 2, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 980.9126533088277m, 352 },
                    { 353, 3, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1052.627248605023m, 353 },
                    { 354, 2, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1291.059578141161m, 354 },
                    { 355, 1, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1111.069230308357m, 355 },
                    { 356, 10, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1119.14807313949m, 356 },
                    { 357, 9, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1024.1470724099667m, 357 },
                    { 358, 8, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1195.418433816437m, 358 },
                    { 359, 6, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 987.8274251217717m, 359 },
                    { 360, 2, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1057.918679035917m, 360 },
                    { 361, 8, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.836626650207m, 361 },
                    { 362, 6, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1182.457300141668m, 362 },
                    { 363, 10, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1058.1955144596m, 363 },
                    { 364, 8, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1031.3588249177244m, 364 },
                    { 365, 5, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1244.318855591895m, 365 },
                    { 366, 6, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1030.4580664695116m, 366 },
                    { 367, 9, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1180.919030953321m, 367 },
                    { 368, 1, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1117.269658893082m, 368 },
                    { 369, 6, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1253.152914656277m, 369 },
                    { 370, 6, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1063.45993990335m, 370 },
                    { 371, 9, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1100.407263781748m, 371 },
                    { 372, 4, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1117.905940001368m, 372 },
                    { 373, 5, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1284.174676415726m, 373 },
                    { 374, 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 990.2536865138927m, 374 },
                    { 375, 9, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1002.8162013006m, 375 },
                    { 376, 2, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1147.404448347229m, 376 },
                    { 377, 1, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1112.87533450406m, 377 },
                    { 378, 8, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1167.600429650201m, 378 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 379, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1043.5722535642838m, 379 },
                    { 380, 9, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1078.982811445113m, 380 },
                    { 381, 8, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1283.939292563404m, 381 },
                    { 382, 9, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1054.663032054011m, 382 },
                    { 383, 8, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 958.04979072696365m, 383 },
                    { 384, 10, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1109.352046490506m, 384 },
                    { 385, 2, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1197.967401444012m, 385 },
                    { 386, 2, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1152.956992617262m, 386 },
                    { 387, 2, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1241.292142052267m, 387 },
                    { 388, 10, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1108.168559780764m, 388 },
                    { 389, 7, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 993.9173600536828m, 389 },
                    { 390, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1071.652595643471m, 390 },
                    { 391, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1042.3884035630346m, 391 },
                    { 392, 8, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1187.796643992025m, 392 },
                    { 393, 2, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 983.9406403811721m, 393 },
                    { 394, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.204935787654m, 394 },
                    { 395, 8, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1089.346307106073m, 395 },
                    { 396, 7, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1032.7877310115122m, 396 },
                    { 397, 2, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1233.259351816936m, 397 },
                    { 398, 7, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1135.690254433333m, 398 },
                    { 399, 8, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1105.878236440899m, 399 },
                    { 400, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 950.0580086530529988m, 400 },
                    { 401, 5, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1105.22379023283m, 401 },
                    { 402, 2, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1021.5049803744044m, 402 },
                    { 403, 5, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1116.688525529959m, 403 },
                    { 404, 9, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1053.55757372215m, 404 },
                    { 405, 6, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1258.928464049956m, 405 },
                    { 406, 2, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1289.188326926071m, 406 },
                    { 407, 5, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 956.25612595589816m, 407 },
                    { 408, 2, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1024.0182085968607m, 408 },
                    { 409, 6, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1055.373676306653m, 409 },
                    { 410, 6, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 974.5096576907415m, 410 },
                    { 411, 9, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1057.792894160344m, 411 },
                    { 412, 5, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 961.7115043527548m, 412 },
                    { 413, 9, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1104.742662524204m, 413 },
                    { 414, 6, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1197.866835898288m, 414 },
                    { 415, 10, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 961.0336160301318m, 415 },
                    { 416, 6, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1159.283307605819m, 416 },
                    { 417, 9, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1280.46388309046m, 417 },
                    { 418, 10, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1148.489010145891m, 418 },
                    { 419, 2, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 991.5904779408219m, 419 },
                    { 420, 9, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1287.374736402517m, 420 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 421, 5, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 955.48298289355923m, 421 },
                    { 422, 2, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1201.656853149244m, 422 },
                    { 423, 9, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1110.799940384596m, 423 },
                    { 424, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1257.936708108315m, 424 },
                    { 425, 5, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 986.0373676050138m, 425 },
                    { 426, 1, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1273.531971933033m, 426 },
                    { 427, 8, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1067.367668073164m, 427 },
                    { 428, 6, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1008.9197592017616m, 428 },
                    { 429, 2, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1286.151742434444m, 429 },
                    { 430, 5, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1012.516652158381m, 430 },
                    { 431, 7, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1044.2156596658526m, 431 },
                    { 432, 1, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1032.3335642117858m, 432 },
                    { 433, 6, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 961.5801093526678m, 433 },
                    { 434, 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 965.4924847129281m, 434 },
                    { 435, 9, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1032.6836578127501m, 435 },
                    { 436, 8, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1021.5970770100982m, 436 },
                    { 437, 6, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1148.604037775039m, 437 },
                    { 438, 9, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1029.3474432969738m, 438 },
                    { 439, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1089.255496004061m, 439 },
                    { 440, 8, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1019.2091094700685m, 440 },
                    { 441, 7, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1010.4772927406505m, 441 },
                    { 442, 5, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1009.1366762850161m, 442 },
                    { 443, 8, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1019.2613368654454m, 443 },
                    { 444, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1196.511254750712m, 444 },
                    { 445, 6, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1064.37262369547m, 445 },
                    { 446, 2, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1265.47653543262m, 446 },
                    { 447, 8, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1066.052128126357m, 447 },
                    { 448, 5, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1005.7552278594337m, 448 },
                    { 449, 7, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1171.907050716328m, 449 },
                    { 450, 2, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1278.761572850566m, 450 },
                    { 451, 1, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1265.803964486118m, 451 },
                    { 452, 5, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1219.476937069263m, 452 },
                    { 453, 6, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1018.5849984464231m, 453 },
                    { 454, 3, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 952.04088885754825m, 454 },
                    { 455, 6, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1035.0152938875416m, 455 },
                    { 456, 5, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1227.303289227259m, 456 },
                    { 457, 4, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1073.156810865831m, 457 },
                    { 458, 9, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1003.2865511253974m, 458 },
                    { 459, 7, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1258.866779966513m, 459 },
                    { 460, 6, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1066.759026481418m, 460 },
                    { 461, 3, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1263.908943507582m, 461 },
                    { 462, 10, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1090.856975635443m, 462 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 463, 9, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1158.452222705728m, 463 },
                    { 464, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1190.447887070668m, 464 },
                    { 465, 2, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 991.4963198944159m, 465 },
                    { 466, 9, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1081.430235858785m, 466 },
                    { 467, 10, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1149.834838065398m, 467 },
                    { 468, 4, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1234.63464619392m, 468 },
                    { 469, 1, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1174.128068235892m, 469 },
                    { 470, 7, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1027.8950297772882m, 470 },
                    { 471, 1, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 974.8025965127498m, 471 },
                    { 472, 7, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1153.291481244121m, 472 },
                    { 473, 8, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1015.6945821476025m, 473 },
                    { 474, 5, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 985.6746363724604m, 474 },
                    { 475, 8, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1127.14976140999m, 475 },
                    { 476, 3, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 958.81883302897684m, 476 },
                    { 477, 4, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1178.957748919824m, 477 },
                    { 478, 7, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1197.986321658063m, 478 },
                    { 479, 1, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1268.865371515123m, 479 },
                    { 480, 7, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1225.813688684079m, 480 },
                    { 481, 7, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1116.803745709259m, 481 },
                    { 482, 1, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1139.286962702396m, 482 },
                    { 483, 6, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1231.99106672296m, 483 },
                    { 484, 5, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1269.804097867436m, 484 },
                    { 485, 10, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1099.021330389692m, 485 },
                    { 486, 9, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1032.6338718166472m, 486 },
                    { 487, 6, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1017.9360440095356m, 487 },
                    { 488, 1, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1295.5426056728m, 488 },
                    { 489, 10, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1220.049963108599m, 489 },
                    { 490, 3, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1209.292866597184m, 490 },
                    { 491, 10, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1068.291745321874m, 491 },
                    { 492, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1039.2664218014008m, 492 },
                    { 493, 7, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1280.001998417654m, 493 },
                    { 494, 7, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 964.4515062925325m, 494 },
                    { 495, 5, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1030.2597394477683m, 495 },
                    { 496, 9, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1102.049645625784m, 496 },
                    { 497, 8, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 961.8031473810998m, 497 },
                    { 498, 1, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 998.2056594683592m, 498 },
                    { 499, 1, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1122.633675595074m, 499 },
                    { 500, 2, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1061.613530588501m, 500 },
                    { 501, 2, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1297.998395179689m, 501 },
                    { 502, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1053.927296606962m, 502 },
                    { 503, 6, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1068.232429528314m, 503 },
                    { 504, 3, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 950.14897906982394m, 504 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 505, 7, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 971.2145621712793m, 505 },
                    { 506, 3, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1011.6275597774061m, 506 },
                    { 507, 2, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1296.40158370464m, 507 },
                    { 508, 8, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1018.834550499714m, 508 },
                    { 509, 8, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1134.059860402653m, 509 },
                    { 510, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1058.15085718116m, 510 },
                    { 511, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 991.8570812513181m, 511 },
                    { 512, 6, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1200.628509211214m, 512 },
                    { 513, 1, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1102.633263212849m, 513 },
                    { 514, 10, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 986.0119008558169m, 514 },
                    { 515, 6, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 994.8494456160911m, 515 },
                    { 516, 9, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1082.698682025501m, 516 },
                    { 517, 5, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1025.0967363199848m, 517 },
                    { 518, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1131.923404322325m, 518 },
                    { 519, 7, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1195.122175897476m, 519 },
                    { 520, 5, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1026.4447565770079m, 520 },
                    { 521, 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1245.594355110689m, 521 },
                    { 522, 7, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1027.7023406458441m, 522 },
                    { 523, 9, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1226.077690275385m, 523 },
                    { 524, 5, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 962.7659932773961m, 524 },
                    { 525, 8, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 967.3854929396181m, 525 },
                    { 526, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1041.0851861004312m, 526 },
                    { 527, 8, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1282.969768466434m, 527 },
                    { 528, 6, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1044.1942295814982m, 528 },
                    { 529, 3, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1012.7159413561143m, 529 },
                    { 530, 7, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 998.7065523476105m, 530 },
                    { 531, 6, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1130.129581114768m, 531 },
                    { 532, 10, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1083.571975997068m, 532 },
                    { 533, 9, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1064.16916377798m, 533 },
                    { 534, 10, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1210.180830127974m, 534 },
                    { 535, 1, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1113.461328279224m, 535 },
                    { 536, 5, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1017.1367299861928m, 536 },
                    { 537, 8, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1037.5562368365625m, 537 },
                    { 538, 1, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1161.323737611609m, 538 },
                    { 539, 6, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1247.918299351016m, 539 },
                    { 540, 4, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 998.6347081452359m, 540 },
                    { 541, 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1265.030307959199m, 541 },
                    { 542, 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1242.339463858345m, 542 },
                    { 543, 5, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1111.712921460247m, 543 },
                    { 544, 4, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 971.9638786123474m, 544 },
                    { 545, 7, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 998.2848787618781m, 545 },
                    { 546, 6, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1060.962523678177m, 546 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 547, 1, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1070.823591959221m, 547 },
                    { 548, 1, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1219.966106615829m, 548 },
                    { 549, 6, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 991.3621298067816m, 549 },
                    { 550, 4, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1151.061672320129m, 550 },
                    { 551, 5, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1085.537323684739m, 551 },
                    { 552, 8, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1032.4299996760476m, 552 },
                    { 553, 2, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1022.5288951466013m, 553 },
                    { 554, 1, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 967.1821089074085m, 554 },
                    { 555, 5, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1025.0588458323766m, 555 },
                    { 556, 5, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1165.175469214304m, 556 },
                    { 557, 6, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 975.5879645485304m, 557 },
                    { 558, 1, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1130.649758920964m, 558 },
                    { 559, 1, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1240.179953448279m, 559 },
                    { 560, 1, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1222.269657463246m, 560 },
                    { 561, 3, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1257.647996567478m, 561 },
                    { 562, 10, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1129.339772848657m, 562 },
                    { 563, 1, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1222.663617088796m, 563 },
                    { 564, 1, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1110.07017930006m, 564 },
                    { 565, 3, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1214.533170571003m, 565 },
                    { 566, 9, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1278.50847648653m, 566 },
                    { 567, 9, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 978.3806165181548m, 567 },
                    { 568, 4, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1294.70567298087m, 568 },
                    { 569, 4, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1030.7184008146662m, 569 },
                    { 570, 1, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1005.01528293419m, 570 },
                    { 571, 5, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1161.380597002673m, 571 },
                    { 572, 5, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1002.2470394711443m, 572 },
                    { 573, 4, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 951.90715679241605m, 573 },
                    { 574, 8, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1082.445061193555m, 574 },
                    { 575, 1, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1236.101803252556m, 575 },
                    { 576, 7, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 974.423974967253m, 576 },
                    { 577, 10, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1038.8695833430092m, 577 },
                    { 578, 3, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1081.126290111912m, 578 },
                    { 579, 8, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1154.669054969504m, 579 },
                    { 580, 6, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1280.612753103172m, 580 },
                    { 581, 8, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1101.584221619001m, 581 },
                    { 582, 8, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 975.0323837743948m, 582 },
                    { 583, 1, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 951.66267949452005m, 583 },
                    { 584, 4, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1160.914442981054m, 584 },
                    { 585, 5, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1146.877537818718m, 585 },
                    { 586, 5, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1150.502568089149m, 586 },
                    { 587, 7, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1015.0839883233148m, 587 },
                    { 588, 4, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1087.457837242764m, 588 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompanyId", "DeliveryDate", "DeliveryPostCode", "LoadingDate", "LoadingPostCode", "Price", "TripId" },
                values: new object[,]
                {
                    { 589, 10, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1209.568089347028m, 589 },
                    { 590, 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1068.800964815515m, 590 },
                    { 591, 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1208.495665436625m, 591 },
                    { 592, 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1137.972698092104m, 592 },
                    { 593, 9, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 1144.623335202662m, 593 },
                    { 594, 8, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivery", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loading", 978.2235188309778m, 594 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeUserId",
                table: "Employees",
                column: "EmployeeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleId",
                table: "Employees",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CompanyId",
                table: "Orders",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TripId",
                table: "Orders",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_SoldsOrders_CompanyId",
                table: "SoldsOrders",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tripes_EmployeeId",
                table: "Tripes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tripes_TruckId",
                table: "Tripes",
                column: "TruckId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckExpenses_EmployeeId",
                table: "TruckExpenses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckExpenses_TruckId",
                table: "TruckExpenses",
                column: "TruckId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "SoldsOrders");

            migrationBuilder.DropTable(
                name: "TruckExpenses");

            migrationBuilder.DropTable(
                name: "Tripes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Trucks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
