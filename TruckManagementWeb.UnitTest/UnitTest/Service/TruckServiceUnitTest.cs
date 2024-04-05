using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Truck;
using TruckManagementWeb.Core.Service;
using TruckManagementWeb.Data;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.UnitTest.UnitTest.Service
{
    public class TruckServiceUnitTest
    {
        private IEnumerable<Truck> trucks;
        private IRepository repo;
        private TruckDbContext applicationDbContext;
        private ILogger<TruckService> logger;
        private ITruckService truckService;


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
            var loggerMock = new Mock<ILogger<TruckService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            truckService = new TruckService(repo);
            var newTruck = new TruckFormModel()
            {
                TruckPlate = "B1111TC",
                TruckBrand = "Iveco",
                TruckModel = "With Iveco, you dont go too nadaleko",
                TruckMilleage = 5,
                ProductionYear = 2017
            };

            await truckService.CreateAsync(newTruck);

            var result = await repo.GetByIdAsync<Truck>(1);

            Assert.That(result.Id, Is.EqualTo(1));
        }
        [Test]
        public async Task Test_FindTruckByPlateAsync()
        {
            var loggerMock = new Mock<ILogger<TruckService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            truckService = new TruckService(repo);
            var newTruck = new TruckFormModel()
            {
                TruckPlate = "B1111TC",
                TruckBrand = "Iveco",
                TruckModel = "With Iveco, you dont go too nadaleko",
                TruckMilleage = 5,
                ProductionYear = 2017
            };
            await truckService.CreateAsync(newTruck);
            var result = await truckService.FindTruckByPlateAsync("B1111TC");

            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result.TruckPlate, Is.EqualTo("B1111TC"));
        }
        [Test]
        public async Task Test_ReturnNullFindTruckByPlateAsync()
        {
            var loggerMock = new Mock<ILogger<TruckService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            truckService = new TruckService(repo);
            var newTruck = new TruckFormModel()
            {
                TruckPlate = "B1115TC",
                TruckBrand = "Iveco",
                TruckModel = "With Iveco, you dont go too nadaleko",
                TruckMilleage = 5,
                ProductionYear = 2017
            };
            await truckService.CreateAsync(newTruck);
            var result = await truckService.FindTruckByPlateAsync("B1113TC");

            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task Test_GetAlltruckReadOnlyAsync()
        {
            var loggerMock = new Mock<ILogger<TruckService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            truckService = new TruckService(repo);
            var newTruck = new TruckFormModel()
            {
                TruckPlate = "B1115TC",
                TruckBrand = "Iveco",
                TruckModel = "With Iveco, you dont go too nadaleko",
                TruckMilleage = 5,
                ProductionYear = 2017
            };
            await truckService.CreateAsync(newTruck);
            var result = await truckService.GetAlltruckReadOnlyAsync();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public async Task Test_FindTruckByIdAsyncc()
        {
            var loggerMock = new Mock<ILogger<TruckService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            truckService = new TruckService(repo);
            var newTruck = new TruckFormModel()
            {
                TruckPlate = "B1115TC",
                TruckBrand = "Iveco",
                TruckModel = "With Iveco, you dont go too nadaleko",
                TruckMilleage = 5,
                ProductionYear = 2017
            };
            await truckService.CreateAsync(newTruck);
            var result = await truckService.FindTruckByIdAsyncc(1);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result.TruckPlate, Is.EqualTo("B1115TC"));
            Assert.That(result.TruckBrand, Is.EqualTo("Iveco"));
            Assert.That(result.TruckModel, Is.EqualTo("With Iveco, you dont go too nadaleko"));
            Assert.That(result.AddedDate, Is.EqualTo(DateTime.Today.ToString("dd-MM-yyyy")));
            Assert.That(result.IsActive, Is.True);
        }

        [Test]
        public async Task Test_IsTruckByPlateExistAsync()
        {
            var loggerMock = new Mock<ILogger<TruckService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            truckService = new TruckService(repo);
            var newTruck = new TruckFormModel()
            {
                TruckPlate = "B1115TC",
                TruckBrand = "Iveco",
                TruckModel = "With Iveco, you dont go too nadaleko",
                TruckMilleage = 5,
                ProductionYear = 2017
            };
            string plate = "B1115TC";
            await truckService.CreateAsync(newTruck);
            var result = await truckService.IsTruckByPlateExistAsync(plate);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task Test_ReturnFalseIsTruckByPlateExistAsync()
        {
            //var loggerMock = new Mock<ILogger<TruckService>>();
            //logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            truckService = new TruckService(repo);
            var newTruck = new TruckFormModel()
            {
                TruckPlate = "B1115TC",
                TruckBrand = "Iveco",
                TruckModel = "With Iveco, you dont go too nadaleko",
                TruckMilleage = 5,
                ProductionYear = 2017
            };
            string plate = "B1116TC";
            await truckService.CreateAsync(newTruck);
            var result = await truckService.IsTruckByPlateExistAsync(plate);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task Test_RemoveTruckAsync()
        {
            var repo = new Repository(applicationDbContext);
            truckService = new TruckService(repo);
            var newTruck = new TruckFormModel()
            {
                TruckPlate = "B1115TC",
                TruckBrand = "Iveco",
                TruckModel = "With Iveco, you dont go too nadaleko",
                TruckMilleage = 5,
                ProductionYear = 2017
            };
            await truckService.CreateAsync(newTruck);
            var result = await truckService.RemoveTruckAsync(1);

            Assert.That(result.IsActive, Is.False);
            Assert.That(result.RemovedDate, Is.EqualTo(DateTime.Today.ToString("dd-MM-yyyy")));
        }

        [Test]
        public async Task Test_GetTruckForEditByIdAsync()
        {
            var repo = new Repository(applicationDbContext);
            truckService = new TruckService(repo);

            await repo.AddRangeAsync(new List<Truck>()
            {
                new Truck()
                    {
                        Id=1,
                        TruckPlate = "B1115TC",
                        TruckBrand = "Iveco",
                        TruckModel = "With Iveco, you dont go too nadaleko",
                        TruckInitialKm = 5,
                        ProductionYear = 2017
                    },
                new Truck()
                    {
                        Id=2,
                        TruckPlate = "B1119TC",
                        TruckBrand = "Renault",
                        TruckModel = "Renault T",
                        TruckInitialKm = 100,
                        ProductionYear = 2024
                    }
            });
            await repo.SaveChangesAsync();

            var result = await truckService.GetTruckForEditByIdAsync(1);

            Assert.NotNull(result);
            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result.TruckPlate, Is.EqualTo("B1115TC"));
        }

        [Test]
        public async Task Test_EditAsync()
        {
            var repo = new Repository(applicationDbContext);
            truckService = new TruckService(repo);
            await repo.AddAsync(new Truck()
            {
                TruckPlate = "B1115TC",
                TruckBrand = "Iveco",
                TruckModel = "With Iveco, you dont go too nadaleko",
                TruckInitialKm = 5,
                ProductionYear = 2017
            });

            await repo.SaveChangesAsync();

            await truckService.EditAsync(1, new TruckEditFormModel()
            {
                TruckPlate = "EDIT",
                TruckBrand = "Edit",
                TruckModel = "Edit",
                TruckMilleage = 100,
                ProductionYear = 2000
            });

            var truck = await repo.GetByIdAsync<Truck>(1);
            Assert.NotNull(truck);
            Assert.That(truck.TruckPlate, Is.EqualTo("EDIT"));
            Assert.That(truck.TruckBrand, Is.EqualTo("Edit"));
            Assert.That(truck.TruckModel, Is.EqualTo("Edit"));
            Assert.That(truck.TruckInitialKm, Is.EqualTo(100));
            Assert.That(truck.ProductionYear, Is.EqualTo(2000));
        }

        [Test]
        public async Task Test_GetTruckIdByPlate()
        {
            var repo = new Repository(applicationDbContext);
            truckService = new TruckService(repo);

            await repo.AddRangeAsync(new List<Truck>()
            {
                new Truck()
                    {
                        Id=1,
                        TruckPlate = "B1115TC",
                        TruckBrand = "Iveco",
                        TruckModel = "With Iveco, you dont go too nadaleko",
                        TruckInitialKm = 5,
                        ProductionYear = 2017
                    },
                new Truck()
                    {
                        Id=2,
                        TruckPlate = "B1119TC",
                        TruckBrand = "Renault",
                        TruckModel = "Renault T",
                        TruckInitialKm = 100,
                        ProductionYear = 2024
                    }
            });
            await repo.SaveChangesAsync();
            string plate = "B1119TC";
            var result = await truckService.GetTruckIdByPlate(plate);
            int id = 2;
            Assert.That(result, Is.EqualTo(id));

        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }
    }
}
