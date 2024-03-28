﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TruckManagementWeb.Data;

#nullable disable

namespace TruckManagementWeb.Infrastructure.Migrations
{
    [DbContext(typeof(TruckDbContext))]
    partial class TruckDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<string>", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole<string>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                            RoleId = "adminRoleId"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TruckManagementWeb.Core.Models.ApplicationUser.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4ed65414-ac0a-486d-8a73-e95a540cf0a2",
                            Email = "admin@truck.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@truck.com",
                            NormalizedUserName = "admin@truck.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEDu/GPX/R8dT2fhCIvk9LJYlfZqBMXawUDO282viL/abLwu9iYmbZiMbrJuy8kc1CQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d1ffee28-0405-457e-9d53-aa5d83c70fa7",
                            TwoFactorEnabled = false,
                            UserEmail = "",
                            UserName = "admin@truck.com"
                        });
                });

            modelBuilder.Entity("TruckManagementWeb.Infrastructure.Data.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2")
                        .HasComment("Date of add Company");

                    b.Property<string>("CompanyAddress")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasComment("Address of the company.");

                    b.Property<string>("CompanyCountry")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Country where the company is located.");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Full name of the company.");

                    b.Property<string>("CompanyTown")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Town or city where the company is located.");

                    b.Property<string>("CompanyVat")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)")
                        .HasComment("VAT number of the company.");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("Company activity");

                    b.Property<DateTime?>("RemovedDate")
                        .HasColumnType("datetime2")
                        .HasComment("Date when company is removed");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("TruckManagementWeb.Infrastructure.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Employee identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Employee e-mail");

                    b.Property<string>("EmployeeUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Employee full name");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("Activity of the employee");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeUserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@truck.com",
                            EmployeeUserId = "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                            FullName = "",
                            IsActive = true,
                            RoleId = "adminRoleId"
                        });
                });

            modelBuilder.Entity("TruckManagementWeb.Infrastructure.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int")
                        .HasComment("CompanyId associated with the order.");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2")
                        .HasComment("DeliveryDate");

                    b.Property<string>("DeliveryPostCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("Delivery place");

                    b.Property<DateTime>("LoadingDate")
                        .HasColumnType("datetime2")
                        .HasComment("Loading date");

                    b.Property<string>("LoadingPostCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("Loaiding place");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Price of the order.");

                    b.Property<int>("TripId")
                        .HasColumnType("int")
                        .HasComment("TripId associated with the order.");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("TripId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TruckManagementWeb.Infrastructure.Data.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Trip identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasComment("Identifier of the employee managing the trip.");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasComment("End date of the trip.");

                    b.Property<decimal>("EuPerKm")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Euro per Km");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasComment("Start date of the trip.");

                    b.Property<int>("TripKm")
                        .HasColumnType("int")
                        .HasComment("Trip in kilometers.");

                    b.Property<decimal>("TripPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Price of the trip.");

                    b.Property<int>("TruckId")
                        .HasColumnType("int")
                        .HasComment("TruckId associated with the trip.");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TruckId");

                    b.ToTable("Tripes");
                });

            modelBuilder.Entity("TruckManagementWeb.Infrastructure.Data.Models.Truck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Truck identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2")
                        .HasComment("Date of add truck to Database");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("Truck activity");

                    b.Property<int>("ProductionYear")
                        .HasColumnType("int")
                        .HasComment("Truck production year");

                    b.Property<DateTime?>("RemovedDate")
                        .HasColumnType("datetime2")
                        .HasComment("Date when truck is removed");

                    b.Property<string>("TruckBrand")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasComment("Truck brand");

                    b.Property<int>("TruckInitialKm")
                        .HasColumnType("int")
                        .HasComment("Truck initial milleage");

                    b.Property<string>("TruckModel")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Truck model");

                    b.Property<string>("TruckPlate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasComment("Truck plate");

                    b.HasKey("Id");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("TruckManagementWeb.Infrastructure.Data.Models.TruckExpense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Expense identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Amount of expense");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasComment("Identifier of the employee managing the trip.");

                    b.Property<DateTime>("ExpenseDate")
                        .HasColumnType("datetime2")
                        .HasComment("Expense date");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Notes about the expense.");

                    b.Property<int>("TruckId")
                        .HasColumnType("int")
                        .HasComment("Truck Id");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasComment("Specify the type of the expense (e.g., maintenance, driver salary, road taxes, fuel).");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TruckId");

                    b.ToTable("TruckExpenses");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole<string>");

                    b.HasDiscriminator().HasValue("IdentityRole");

                    b.HasData(
                        new
                        {
                            Id = "adminRoleId",
                            ConcurrencyStamp = "4d0d7f72-0adf-4f3a-89de-16d0cb5e5ec9",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "managerRoleId",
                            ConcurrencyStamp = "815efcff-3acc-43ad-a399-b585e24bbddb",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "dispatcherRoleId",
                            ConcurrencyStamp = "ffd31644-c688-49fa-96b9-6c8842232422",
                            Name = "Dispo",
                            NormalizedName = "DISPO"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<string>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TruckManagementWeb.Core.Models.ApplicationUser.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TruckManagementWeb.Core.Models.ApplicationUser.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<string>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TruckManagementWeb.Core.Models.ApplicationUser.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TruckManagementWeb.Core.Models.ApplicationUser.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TruckManagementWeb.Infrastructure.Data.Models.Employee", b =>
                {
                    b.HasOne("TruckManagementWeb.Core.Models.ApplicationUser.ApplicationUser", "EmployeeUser")
                        .WithMany()
                        .HasForeignKey("EmployeeUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeUser");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("TruckManagementWeb.Infrastructure.Data.Models.Order", b =>
                {
                    b.HasOne("TruckManagementWeb.Infrastructure.Data.Models.Company", "Company")
                        .WithMany("Orders")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TruckManagementWeb.Infrastructure.Data.Models.Trip", "Trip")
                        .WithMany("Orders")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("TruckManagementWeb.Infrastructure.Data.Models.Trip", b =>
                {
                    b.HasOne("TruckManagementWeb.Infrastructure.Data.Models.Employee", "Employee")
                        .WithMany("Trips")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TruckManagementWeb.Infrastructure.Data.Models.Truck", "Truck")
                        .WithMany("Trips")
                        .HasForeignKey("TruckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Truck");
                });

            modelBuilder.Entity("TruckManagementWeb.Infrastructure.Data.Models.TruckExpense", b =>
                {
                    b.HasOne("TruckManagementWeb.Infrastructure.Data.Models.Employee", "Employee")
                        .WithMany("TruckExpenses")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TruckManagementWeb.Infrastructure.Data.Models.Truck", "Truck")
                        .WithMany("Expenses")
                        .HasForeignKey("TruckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Truck");
                });

            modelBuilder.Entity("TruckManagementWeb.Infrastructure.Data.Models.Company", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("TruckManagementWeb.Infrastructure.Data.Models.Employee", b =>
                {
                    b.Navigation("Trips");

                    b.Navigation("TruckExpenses");
                });

            modelBuilder.Entity("TruckManagementWeb.Infrastructure.Data.Models.Trip", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("TruckManagementWeb.Infrastructure.Data.Models.Truck", b =>
                {
                    b.Navigation("Expenses");

                    b.Navigation("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}
