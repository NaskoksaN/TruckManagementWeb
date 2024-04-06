using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Reflection;
using TruckManagementWeb.Core.Contracts;
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
            DateTime lastMonthEnd = today.AddDays(-today.Day);
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
            var repoMock = new Mock<Repository>(applicationDbContext);
            var reportService = new ReportService(repoMock.Object);

            DateTime today = new DateTime(2024, 3, 5);
            string period = "month";
            DateTime firstDayOfLastMonth = new DateTime(today.Year, today.Month - 1, 1);
            DateTime lastDayOfLastMonth = firstDayOfLastMonth.AddMonths(1).AddDays(-1);

            var truck1 = new TruckMonthSimpleViewModel { TotalEuros = 1000, TotalExpenses = 500 };
            var truck2 = new TruckMonthSimpleViewModel { TotalEuros = 1500, TotalExpenses = 1000 };
            var truckPeriod = new List<TruckMonthSimpleViewModel> { truck1, truck2 };

            var getTitleMethod = reportService.GetType().GetMethod("GetTitle", BindingFlags.NonPublic | BindingFlags.Instance);
            string title = (string)getTitleMethod.Invoke(reportService, new object[] { truckPeriod, period, firstDayOfLastMonth, lastDayOfLastMonth });

            decimal profit = truckPeriod.Sum(t => t.TotalEuros) - truckPeriod.Sum(t => t.TotalExpenses);
            string profitLabel = profit >= 0 ? "Profit" : "Loss";
            string expectedTitle = $"Trucks last {period} ({firstDayOfLastMonth.ToString("dd/MM/yyyy")} - {lastDayOfLastMonth.ToString("dd/MM/yyyy")}) Result: {profitLabel} {Math.Abs(profit)} euro";

            Assert.AreEqual(expectedTitle, title);
            Assert.AreEqual(2, truckPeriod.Count);
            Assert.AreEqual(1000, truckPeriod[0].TotalEuros);
            Assert.AreEqual(500, truckPeriod[0].TotalExpenses);
            Assert.AreEqual(1500, truckPeriod[1].TotalEuros);
            Assert.AreEqual(1000, truckPeriod[1].TotalExpenses);

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
