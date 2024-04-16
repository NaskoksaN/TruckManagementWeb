using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Reflection;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Expense;
using TruckManagementWeb.Core.Models.Reports;
using TruckManagementWeb.Core.Service;
using TruckManagementWeb.Data;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.UnitTest.UnitTest.Service
{
    public class ReportServiceUnitTest
    {
        private IRepository repo;
        private TruckDbContext applicationDbContext;
        private IReports reportService;


        [SetUp]
        public void SetUp()
        {
            var contextOptions = new DbContextOptionsBuilder<TruckDbContext>()
               .UseInMemoryDatabase("TruckDB")
               .Options;
            applicationDbContext = new TruckDbContext(contextOptions);

            applicationDbContext.Database.EnsureDeleted();
            applicationDbContext.Database.EnsureCreated();
        }

        [Test]
        public async Task Test_YearlyCompanyRevenueAsync()
        {
            DateTime today = DateTime.Today;
            DateTime lastMonthEnd = today.AddDays(-today.Day).AddDays(-1);
            DateTime oneYearAgoStart = today.AddYears(-1).AddDays(1 - today.Day);

            var repo = new Repository(applicationDbContext);
            reportService = new ReportService(repo);

            var newCompany = new Company
            {
                Id = 1,
                CompanyAddress = "in the middle of the street",
                CompanyVat = "BG111111111",
                CompanyName = "Used test",
                CompanyCountry = "CountryTest",
                CompanyTown = "TestTown",
                IsActive = true
            };
            await repo.AddAsync(newCompany);

            Order order = new Order
            {
                Id = 1,
                LoadingDate = oneYearAgoStart.AddDays(1),
                CompanyId = 1,
                Price = 500,
                LoadingPostCode = "12345",
                DeliveryPostCode = "67890"
            };
            await repo.AddAsync(order);
            await repo.SaveChangesAsync();

            var (title, result) = await reportService.YearlyCompanyRevenueAsync();
            string titleTest = $"Income from Companies for last year ({oneYearAgoStart.ToString("dd/MM/yyyy")} - {lastMonthEnd.ToString("dd/MM/yyyy")})";

            Assert.That(titleTest, Is.EqualTo(title));
            Assert.NotNull(result);
            Assert.That(result.Count(r => r.RevenueFromCompany == 500M), Is.EqualTo(1));
        }

        [Test]
        public async Task Test_GetMonthlyTrucksResultAsync()
        {
            var repo = new Repository(applicationDbContext);
            reportService = new ReportService(repo);

            var truckData = new List<Truck>
            {
                new Truck
                {
                    TruckPlate = "B8511TC",
                    TruckBrand = "Iveco",
                    TruckModel = "With Iveco, you don't go too far",
                    TruckInitialKm = 5,
                    ProductionYear = 2017
                },
                new Truck
                {
                    TruckPlate = "B1234AB",
                    TruckBrand = "Volvo",
                    TruckModel = "Volvo Trucks",
                    TruckInitialKm = 10,
                    ProductionYear = 2019
                }
            };

            var tripData = new List<Trip>
            {
                new Trip
                {
                    Id = 1,
                    StartDate = DateTime.Now.AddMonths(-2),
                    TruckId = 1,
                    TripPrice = 1300,
                    TripKm = 1000,
                    Orders = new List<Order>
                    {
                        new Order
                        {
                            Id = 1,
                            LoadingDate = DateTime.Now.AddMonths(-2),
                            CompanyId = 1,
                            Price = 1300,
                            LoadingPostCode = "12345",
                            DeliveryPostCode = "67890"
                        }
                    }
                },
                new Trip
                {
                    Id = 2,
                    StartDate = DateTime.Now.AddMonths(-1),
                    TruckId = 2,
                    TripPrice = 1500,
                    TripKm = 1200,
                    Orders = new List<Order>
                    {
                        new Order
                        {
                            Id = 2,
                            LoadingDate = DateTime.Now.AddMonths(-1),
                            CompanyId = 2,
                            Price = 1500,
                            LoadingPostCode = "54321",
                            DeliveryPostCode = "09876"
                        }
                    }
                }
            };

            var expenseData = new List<TruckExpense>
            {
                new TruckExpense
                {
                    TruckId = 1,
                    Amount = 1000,
                    Notes = "fuel",
                    ExpenseDate = DateTime.Now.AddMonths(-2),
                    EmployeeId = 1
                },
                new TruckExpense
                {
                    TruckId = 2,
                    Amount = 1200,
                    Notes = "maintenance",
                    ExpenseDate = DateTime.Now.AddMonths(-1),
                    EmployeeId = 1
                }
            };

            await repo.AddRangeAsync(truckData);
            await repo.AddRangeAsync(tripData);
            await repo.AddRangeAsync(expenseData);
            await repo.SaveChangesAsync();

            var (title, result) = await reportService.GetTrucksYearResultAsync();

            Assert.IsNotNull(result); 

            Assert.AreEqual("B8511TC", result[0].PlateNumber); 
            Assert.AreEqual(1000, result[0].TotalKilometers); 
            Assert.AreEqual(1300, result[0].TotalEuros); 
            Assert.AreEqual(1000, result[0].TotalExpenses); 

            Assert.AreEqual("B1234AB", result[1].PlateNumber); 
            Assert.AreEqual(1200, result[1].TotalKilometers); 
            Assert.AreEqual(1500, result[1].TotalEuros); 
            Assert.AreEqual(1200, result[1].TotalExpenses); 

            Assert.AreEqual(2, result.Count); 
            
        }

        [Test]
        public async Task Test_GetTrucksYearResultAsync_ReturnsCorrectResults_AndNotCountTripOutsideYear()
        {
            var today = DateTime.Today;
            var period = "year";
            var lastMonthEnd = today.AddDays(-today.Day);
            var oneYearAgoStart = today.AddYears(-1).AddDays(1 - today.Day);
            var repo = new Repository(applicationDbContext);
            var reportService = new ReportService(repo);

            await SeedTruckDataAsync(repo, new DateTime(2024, 1, 1), new DateTime(2023, 1, 1));

            var (title, yearlyResults) = await reportService.GetTrucksYearResultAsync();

            decimal expectedTotalEuros = 1000;
            decimal expectedTotalExpenses = 200;
            decimal expectedProfit = expectedTotalEuros - expectedTotalExpenses;
            string profitLabel = expectedProfit >= 0 ? "Profit" : "Loss";
            string expectedTitle = $"Trucks last {period} ({oneYearAgoStart.ToString("dd/MM/yyyy")} - {lastMonthEnd.ToString("dd/MM/yyyy")}) Result: {profitLabel} {Math.Abs(expectedProfit)} euro";

            Assert.AreEqual(expectedTitle, title);
            Assert.AreEqual(1, yearlyResults.Count);
            Assert.AreEqual("ABC123", yearlyResults[0].PlateNumber);
            Assert.AreEqual(500, yearlyResults[0].TotalKilometers);
            Assert.AreEqual(expectedTotalEuros, yearlyResults[0].TotalEuros);
            Assert.AreEqual(expectedTotalExpenses, yearlyResults[0].TotalExpenses);
        }

        [Test]
        public async Task Test_TruckCurrentMonthAsync_ReturnsCorrectResults()
        {
            var repo = new Repository(applicationDbContext);
            var reportService = new ReportService(repo);

            DateTime start1 = new DateTime(2024, 4, 3);
            DateTime start2 = new DateTime(2024, 3, 10);

            await SeedTruckDataAsync(repo, start1, start2);

            var currentMonth = await reportService.TruckCurrentMonthAsync("ABC123");

            decimal expectedTotalEuros = 1000;
            decimal expectedTotalExpenses = 200;

            Assert.AreEqual("ABC123", currentMonth.PlateNumber);
            Assert.AreEqual(500, currentMonth.TotalKilometers);
            Assert.AreEqual(expectedTotalEuros, currentMonth.TotalEuros);
            Assert.AreEqual(expectedTotalExpenses, currentMonth.TotalExpenses);

        }

        [Test]
        public async Task Test_TruckLastMonthAsync()
        {

            var repo = new Repository(applicationDbContext);
            var reportService = new ReportService(repo);

            DateTime start1 = new DateTime(2024, 3, 3);
            DateTime start2 = new DateTime(2024, 1, 10);

            await SeedTruckDataAsync(repo, start1, start2);

            var lastMonth = await reportService.TruckLastMonthAsync("ABC123");

            decimal expectedTotalEuros = 1000;
            decimal expectedTotalExpenses = 200;

            Assert.AreEqual("ABC123", lastMonth.PlateNumber);
            Assert.AreEqual(500, lastMonth.TotalKilometers);
            Assert.AreEqual(expectedTotalEuros, lastMonth.TotalEuros);
            Assert.AreEqual(expectedTotalExpenses, lastMonth.TotalExpenses);

        }

        [Test]
        public async Task Test_TruckLastQuarterAsync()
        {

            var repo = new Repository(applicationDbContext);
            var reportService = new ReportService(repo);

            DateTime start1 = new DateTime(2024, 3, 3);
            DateTime start2 = new DateTime(2024, 1, 10);

            await SeedTruckDataAsync(repo, start1, start2);

            List<TruckMonthReportViewModel> lastQuarter = 
                            await reportService.TruckLastQuarterAsync("ABC123");

            Assert.AreEqual(3, lastQuarter.Count, "Expected three months of data");

            // Assert for the first month of the last quarter (March)
            Assert.AreEqual("ABC123", lastQuarter[2].PlateNumber, "Plate number should match");
            Assert.AreEqual(500, lastQuarter[2].TotalKilometers, "Total kilometers should match");
            Assert.AreEqual(1000, lastQuarter[2].TotalEuros, "Total euros should match");
            Assert.AreEqual(200, lastQuarter[2].TotalExpenses, "Total expenses should match");

            // Assert for the second month of the last quarter (February)
            Assert.AreEqual("ABC123", lastQuarter[1].PlateNumber, "Plate number should match");
            Assert.AreEqual(0, lastQuarter[1].TotalKilometers, "Total kilometers should be zero for February");
            Assert.AreEqual(0, lastQuarter[1].TotalEuros, "Total euros should be zero for February");
            Assert.AreEqual(0, lastQuarter[1].TotalExpenses, "Total expenses should be zero for February");

            // Assert for the third month of the last quarter (January)
            Assert.AreEqual("ABC123", lastQuarter[0].PlateNumber, "Plate number should match");
            Assert.AreEqual(800, lastQuarter[0].TotalKilometers, "Total kilometers should match");
            Assert.AreEqual(1500, lastQuarter[0].TotalEuros, "Total euros should match");
            Assert.AreEqual(300, lastQuarter[0].TotalExpenses, "Total expenses should match");

        }

        [Test]
        public async Task Test_GetTruckYearReport()
        {
            var repo = new Repository(applicationDbContext);
            var reportService = new ReportService(repo);

            string truckPlate = "B8511TC";
            var truckData = new List<Truck> { new Truck(){
                                            TruckPlate = "B8511TC",
                                            TruckBrand = "Iveco",
                                            TruckModel = "With Iveco, you don't go too far",
                                            TruckInitialKm = 5,
                                            ProductionYear = 2017
                                        }};

            var tripData = new List<Trip> { new Trip(){
                                    Id = 1,
                                    StartDate = DateTime.Now.AddMonths(-2),
                                    TruckId = 1,
                                    TripPrice = 1300,
                                    TripKm = 1000,
                                    Orders = new List<Order>
                                    {
                                        new Order
                                        {
                                            Id=1,
                                            LoadingDate = DateTime.Now.AddMonths(-2),
                                            CompanyId =1,
                                            Price = 500,
                                            LoadingPostCode = "12345",
                                            DeliveryPostCode = "67890"
                                        }
                                    }
                                }};
            var expenseData = new List<TruckExpense> { new TruckExpense()
            {
                TruckId = 1,
                Amount = 1000,
                Notes = "fuel",
                ExpenseDate = DateTime.Now,
                EmployeeId = 1,
            }};

            await repo.AddRangeAsync(truckData);
            await repo.AddRangeAsync(tripData);
            await repo.AddRangeAsync(expenseData);
            await repo.SaveChangesAsync();
            

            var result = await reportService.GetTruckYearReport(truckPlate);

            Assert.IsNotNull(result); 
            Assert.AreEqual(12, result.Count());
            Assert.AreEqual(0, result.First().TotalKilometers); 
            Assert.AreEqual(0, result.First().TotalEuros); 
            Assert.AreEqual(1000, result.Skip(1).First().TotalKilometers); 
            Assert.AreEqual(1300, result.Skip(1).First().TotalEuros);
        }

        [Test]
        public async Task Test_OveralInfo()
        {
            var repo = new Repository(applicationDbContext);
            var reportService = new ReportService(repo);

            var truckData = new List<Truck> { new Truck(){
                                            TruckPlate = "B8511TC",
                                            TruckBrand = "Iveco",
                                            TruckModel = "With Iveco, you don't go too far",
                                            TruckInitialKm = 5,
                                            ProductionYear = 2017
                                            },
                                            new Truck
                                            {
                                                TruckPlate = "B1234AB",
                                                TruckBrand = "Volvo",
                                                TruckModel = "Volvo Trucks",
                                                TruckInitialKm = 10,
                                                ProductionYear = 2019,
                                                IsActive = false // Set one truck as inactive
                                            }};

            var tripData = new List<Trip>
            {
                new Trip
                {
                    Id = 1,
                    StartDate = DateTime.Now.AddMonths(-2),
                    TruckId = 1,
                    TripPrice = 1300,
                    TripKm = 1000,
                    Orders = new List<Order>
                    {
                        new Order
                        {
                            Id = 1,
                            LoadingDate = DateTime.Now.AddMonths(-2),
                            CompanyId = 1,
                            Price = 500,
                            LoadingPostCode = "12345",
                            DeliveryPostCode = "67890"
                        }
                    }
                },
                new Trip
                {
                    Id = 2,
                    StartDate = DateTime.Now.AddYears(-1).AddMonths(-3),
                    TruckId = 1,
                    TripPrice = 1500,
                    TripKm = 1200,
                    Orders = new List<Order>
                    {
                        new Order
                        {
                            Id = 2,
                            LoadingDate = DateTime.Now.AddYears(-1).AddMonths(-3),
                            CompanyId = 2,
                            Price = 600,
                            LoadingPostCode = "54321",
                            DeliveryPostCode = "09876"
                        }
                    }
                }
            };

            await repo.AddRangeAsync(truckData);
            await repo.AddRangeAsync(tripData);
            await repo.SaveChangesAsync();

            
            var result = await reportService.OveralInfo();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TotaltruckCount); 
            Assert.AreEqual(1000, result.TotalTraveledKm); 
            Assert.AreEqual(1, result.TotalOrdersMade); 

        }

        private async Task SeedTruckDataAsync(IRepository repo, DateTime start1, DateTime start2)
        {
            var testData = new List<Truck>
            {
                new Truck
                {
                    TruckPlate = "ABC123",
                    Trips = new List<Trip>
                    {
                        new Trip { TripKm = 500, TripPrice = 1000, StartDate = start1 },
                        new Trip { TripKm = 800, TripPrice = 1500, StartDate = start2 }
                    },
                    Expenses = new List<TruckExpense>
                    {
                        new TruckExpense { Amount = 200, ExpenseDate = start1 },
                        new TruckExpense { Amount = 300, ExpenseDate = start2 }
                    }
                }
            };

            await repo.AddRangeAsync<Truck>(testData);
            await repo.SaveChangesAsync();
        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }
    }
}
