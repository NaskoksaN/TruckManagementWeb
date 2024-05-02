using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Company;
using TruckManagementWeb.Core.Models.SellOrder;
using TruckManagementWeb.Core.Service;
using TruckManagementWeb.Data;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.UnitTest.UnitTest.Service
{
    public  class SellOrderUnitTest
    {
        private IRepository repo;
        private TruckDbContext applicationDbContext;
        private ISellOrder sellOrderService;
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
        public async Task AddSoldOrderAsync()
        {
            var repo = new Repository(applicationDbContext);
            companyService = new CompanyService(repo);
            sellOrderService = new SellOrder(repo, companyService);

            var newCompany = new CompanyFormModel()
            {
                CompanyVat = "123456789",
                Name = "FRANCE COMPANY",
                Country = "France",
                Town = "Colmar",
                Address = "rue papin 10"
            };

            int companyID = await companyService.CreateAsync(newCompany);

            SoldOrderFormModel order = new SoldOrderFormModel()
            {
                OrderGuid = Guid.NewGuid(),
                ClientCompanyVat = "123456789",
                LoadingCompany = "Loading Company Inc.",
                LoadingStreet = "123 Loading Street",
                LoadingTown = "Loading Town",
                DeliveryCompany = "Delivery Company Ltd.",
                DeliveryStreet = "456 Delivery Street",
                DeliveryTown = "Delivery Town",
                LoadingMeter = 10.5,
                Weight = 500,
                LoadingReference = "Loading Ref123",
                DeliveryReference = "Delivery Ref456",
                Price = 1000.00M,
                ClientEmail = "client@example.com"
            };

            int orderId = await sellOrderService.AddSoldOrderAsync(order);

            Assert.NotNull(orderId);
            Assert.AreEqual(1, orderId);
        }

        [Test]
        public async Task GetOrderByTokenAsync()
        {
            var repo = new Repository(applicationDbContext);
            companyService = new CompanyService(repo);
            sellOrderService = new SellOrder(repo, companyService);

            var newCompany = new CompanyFormModel()
            {
                CompanyVat = "123456789",
                Name = "FRANCE COMPANY",
                Country = "France",
                Town = "Colmar",
                Address = "rue papin 10"
            };

            int companyID = await companyService.CreateAsync(newCompany);

            SoldOrderFormModel order = new SoldOrderFormModel()
            {
                OrderGuid = Guid.NewGuid(),
                ClientCompanyVat = "123456789",
                LoadingCompany = "Loading Company Inc.",
                LoadingStreet = "123 Loading Street",
                LoadingTown = "Loading Town",
                DeliveryCompany = "Delivery Company Ltd.",
                DeliveryStreet = "456 Delivery Street",
                DeliveryTown = "Delivery Town",
                LoadingMeter = 10.5,
                Weight = 500,
                LoadingReference = "Loading Ref123",
                DeliveryReference = "Delivery Ref456",
                Price = 1000.00M,
                ClientEmail = "client@example.com"
            };

            await sellOrderService.AddSoldOrderAsync(order);

            var result = await sellOrderService.GetOrderByTokenAsync(order.OrderGuid);

            Assert.NotNull(result);
            Assert.AreEqual(result.ClientEmail, order.ClientEmail);
        }

        [Test]
        public async Task GetSoldOrderByIdAsync()
        {
            var repo = new Repository(applicationDbContext);
           
            sellOrderService = new SellOrder(repo, companyService);

            await SeedData();

            var result = await sellOrderService.GetSoldOrderByIdAsync(1);

            Assert.NotNull(result);
            Assert.AreEqual(result.ClientEmail, "client@example.com");
        }

        [Test]
        public async Task AddDateAsync_LoadingDate()
        {
            var repo = new Repository(applicationDbContext);
            companyService = new CompanyService(repo);
            sellOrderService = new SellOrder(repo, companyService);

            var newCompany = new CompanyFormModel()
            {
                CompanyVat = "123456789",
                Name = "FRANCE COMPANY",
                Country = "France",
                Town = "Colmar",
                Address = "rue papin 10"
            };

            int companyID = await companyService.CreateAsync(newCompany);

            SoldOrderFormModel order = new SoldOrderFormModel()
            {
                OrderGuid = Guid.NewGuid(),
                ClientCompanyVat = "123456789",
                LoadingCompany = "Loading Company Inc.",
                LoadingStreet = "123 Loading Street",
                LoadingTown = "Loading Town",
                DeliveryCompany = "Delivery Company Ltd.",
                DeliveryStreet = "456 Delivery Street",
                DeliveryTown = "Delivery Town",
                LoadingMeter = 10.5,
                Weight = 500,
                LoadingReference = "Loading Ref123",
                DeliveryReference = "Delivery Ref456",
                Price = 1000.00M,
                ClientEmail = "client@example.com"
            };

            await sellOrderService.AddSoldOrderAsync(order);
            DateTime testDate= DateTime.Now;
            await sellOrderService.AddDateAsync(order.OrderGuid, testDate, "loaded");
            var result = await sellOrderService.GetOrderByTokenAsync(order.OrderGuid);
            int t = 1;
            Assert.AreEqual(result.LoadingDateTime, testDate);

        }

        [Test]
        public async Task AddDateAsync_DeliveryDate()
        {
            var repo = new Repository(applicationDbContext);
            companyService = new CompanyService(repo);
            sellOrderService = new SellOrder(repo, companyService);

            var newCompany = new CompanyFormModel()
            {
                CompanyVat = "123456789",
                Name = "FRANCE COMPANY",
                Country = "France",
                Town = "Colmar",
                Address = "rue papin 10"
            };

            int companyID = await companyService.CreateAsync(newCompany);

            SoldOrderFormModel order = new SoldOrderFormModel()
            {
                OrderGuid = Guid.NewGuid(),
                ClientCompanyVat = "123456789",
                LoadingCompany = "Loading Company Inc.",
                LoadingStreet = "123 Loading Street",
                LoadingTown = "Loading Town",
                DeliveryCompany = "Delivery Company Ltd.",
                DeliveryStreet = "456 Delivery Street",
                DeliveryTown = "Delivery Town",
                LoadingMeter = 10.5,
                Weight = 500,
                LoadingReference = "Loading Ref123",
                DeliveryReference = "Delivery Ref456",
                Price = 1000.00M,
                ClientEmail = "client@example.com"
            };

            await sellOrderService.AddSoldOrderAsync(order);
            DateTime testDate = DateTime.Now;
            await sellOrderService.AddDateAsync(order.OrderGuid, testDate, "delivered");
            var result = await sellOrderService.GetOrderByTokenAsync(order.OrderGuid);
            int t = 1;
            Assert.AreEqual(result.DeliveryDateTime, testDate);

        }

        private async Task SeedData()
        {
            var repo = new Repository(applicationDbContext);
            companyService = new CompanyService(repo);
            sellOrderService = new SellOrder(repo, companyService);

            var newCompany = new CompanyFormModel()
            {
                CompanyVat = "123456789",
                Name = "FRANCE COMPANY",
                Country = "France",
                Town = "Colmar",
                Address = "rue papin 10"
            };

            int companyId = await companyService.CreateAsync(newCompany);

            SoldOrderFormModel order = new SoldOrderFormModel()
            {
                OrderGuid = Guid.NewGuid(),
                ClientCompanyVat = "123456789",
                LoadingCompany = "Loading Company Inc.",
                LoadingStreet = "123 Loading Street",
                LoadingTown = "Loading Town",
                DeliveryCompany = "Delivery Company Ltd.",
                DeliveryStreet = "456 Delivery Street",
                DeliveryTown = "Delivery Town",
                LoadingMeter = 10.5,
                Weight = 500,
                LoadingReference = "Loading Ref123",
                DeliveryReference = "Delivery Ref456",
                Price = 1000.00M,
                ClientEmail = "client@example.com"
            };

            await sellOrderService.AddSoldOrderAsync(order);
        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }
    }
}
