using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Trip;
using TruckManagementWeb.Core.Service;
using TruckManagementWeb.Data;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.UnitTest.UnitTest.Service
{
    public class TripServiceUnitTest
    {
        private IRepository repo;
        private TruckDbContext applicationDbContext;
        private ITripService tripService;
        private ITruckService truckService;
        private ICompanyService companyService;


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
        public async Task Test_CreateAsync()
        {
            var repo = new Repository(applicationDbContext);
            truckService = new TruckService(repo);

            tripService = new TripService(repo, truckService, companyService);
            var newTruck = new Truck()
            {
                Id = 1,
                TruckPlate = "B1111TC",
                TruckBrand = "Iveco",
                TruckModel = "With Iveco, you dont go too nadaleko",
                TruckInitialKm = 5,
                ProductionYear = 2017
            };
            await repo.AddAsync(newTruck);
            await repo.SaveChangesAsync();
            await tripService.CreateTripAsync(new TripFormModel()
            {
                TripKm = 1000,
                TripPrice = 1300,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(2),
                TruckPlate = "B1111TC",
                EmployeeId = 1
            });

            int id = 1;
            var result = await repo.GetByIdAsync<Trip>(id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(1));
        }

        [Test]
        public async Task Test_GetAllTripAsync()
        {
            var repo = new Repository(applicationDbContext);
            tripService = new TripService(repo, truckService, companyService);

            var newTruck = new Truck()
            {
                Id = 1,
                TruckPlate = "B1111TC",
                TruckBrand = "Iveco",
                TruckModel = "With Iveco, you dont go too nadaleko",
                TruckInitialKm = 5,
                ProductionYear = 2017
            };
            var newCompany = new Company()
            {
                Id = 1,
                CompanyAddress = "in the midle os the stree",
                CompanyVat = "BG111111111",
                CompanyName = "Used test",
                CompanyCountry = "CountryTest",
                CompanyTown = "TestTown"
            };
            await repo.AddAsync(newCompany);
            await repo.AddAsync(newTruck);
            await repo.SaveChangesAsync();

            await repo.AddRangeAsync(new List<Trip>
            {
               new Trip
               {
                   Id = 1,
                   StartDate = DateTime.Now,
                   TruckId = 1,
                   TripPrice = 1300,
                   TripKm = 1000,
                   Orders = new List<Order>
                   {
                       new Order
                       {
                           Id=1,
                           LoadingDate = DateTime.Now,
                           CompanyId =1,
                           Price = 500,
                           LoadingPostCode = "12345",
                           DeliveryPostCode = "67890"
                       }
                   }
               }
            });
            await repo.SaveChangesAsync();
            DateTime sixtyDaysAgo = DateTime.Now.AddDays(-60);
            var result = tripService.GetTripsForPeriodAsync(sixtyDaysAgo, DateTime.Now);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task Test_GetViewTripByIdAsync()
        {
            var repo = new Repository(applicationDbContext);
            tripService = new TripService(repo, truckService, companyService);

            var newTruck = new Truck()
            {
                Id = 1,
                TruckPlate = "B1111TC",
                TruckBrand = "Iveco",
                TruckModel = "With Iveco, you dont go too nadaleko",
                TruckInitialKm = 5,
                ProductionYear = 2017
            };
            var newCompany = new Company()
            {
                Id = 1,
                CompanyAddress = "in the midle os the stree",
                CompanyVat = "BG111111111",
                CompanyName = "Used test",
                CompanyCountry = "CountryTest",
                CompanyTown = "TestTown"
            };
            await repo.AddAsync(newCompany);
            await repo.AddAsync(newTruck);
            await repo.SaveChangesAsync();

            await repo.AddRangeAsync(new List<Trip>
            {
               new Trip
               {
                   Id = 1,
                   StartDate = DateTime.Now,
                   TruckId = 1,
                   TripPrice = 1300,
                   TripKm = 1000,
                   Orders = new List<Order>
                   {
                       new Order
                       {
                           Id=1,
                           LoadingDate = DateTime.Now,
                           CompanyId =1,
                           Price = 500,
                           LoadingPostCode = "12345",
                           DeliveryPostCode = "67890"
                       }
                   }
               }
            });
            await repo.SaveChangesAsync();

            var result = await tripService.GetViewTripByIdAsync(1);

            Assert.NotNull(result);
            Assert.That(result.Price, Is.EqualTo(1300));
        }

        [Test]
        public async Task Test_DeleteGivenTripWithOrders()
        {

            var repo = new Repository(applicationDbContext);
            tripService = new TripService(repo, truckService, companyService);

            var newTruck = new Truck()
            {
                Id = 1,
                TruckPlate = "B1111TC",
                TruckBrand = "Iveco",
                TruckModel = "With Iveco, you dont go too nadaleko",
                TruckInitialKm = 5,
                ProductionYear = 2017
            };
            var newCompany = new Company()
            {
                Id = 1,
                CompanyAddress = "in the midle os the stree",
                CompanyVat = "BG111111111",
                CompanyName = "Used test",
                CompanyCountry = "CountryTest",
                CompanyTown = "TestTown"
            };
            await repo.AddAsync(newCompany);
            await repo.AddAsync(newTruck);
            await repo.SaveChangesAsync();

            await repo.AddRangeAsync(new List<Trip>
            {
               new Trip
               {
                   Id = 1,
                   StartDate = DateTime.Now,
                   TruckId = 1,
                   TripPrice = 1300,
                   TripKm = 1000,
                   Orders = new List<Order>
                   {
                       new Order
                       {
                           Id=1,
                           TripId = 1,
                           LoadingDate = DateTime.Now,
                           CompanyId =1,
                           Price = 500,
                           LoadingPostCode = "12345",
                           DeliveryPostCode = "67890"
                       }
                   }
               }
            });
            await repo.SaveChangesAsync();

            await tripService.DeleteGivenTripWithOrders(1);
            var result = await repo.GetByIdAsync<Trip>(1);
            Assert.IsNull(result);

        }

        [Test]
        public async Task Test_SaveOrderToTripAsync()
        {
            var repo = new Repository(applicationDbContext);
            truckService = new TruckService(repo);

            tripService = new TripService(repo, truckService, companyService);

            var trip = new Trip
            {
                Id = 1,
                StartDate = DateTime.Now,
                TruckId = 1,
                TripPrice = 1300,
                TripKm = 1000,
                Orders = new List<Order>()
            };
            await repo.AddAsync(trip);
            await repo.SaveChangesAsync();
            int count = trip.Orders.Count;
            var order = new Order
            {
                Id = 1,
                TripId = 1,
                LoadingDate = DateTime.Now,
                CompanyId = 1,
                Price = 500,
                LoadingPostCode = "12345",
                DeliveryPostCode = "67890"
            };
            await repo.AddAsync(order);
            await repo.SaveChangesAsync();

            var result = await repo.GetByIdAsync<Trip>(1);

            Assert.That(count, Is.EqualTo(0));
            Assert.That(result.Orders.Count, Is.EqualTo(1));
        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }
    }
}
