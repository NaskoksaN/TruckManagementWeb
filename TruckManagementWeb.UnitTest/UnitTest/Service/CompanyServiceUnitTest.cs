using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Company;
using TruckManagementWeb.Core.Service;
using TruckManagementWeb.Data;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;


namespace TruckManagementWeb.UnitTest.UnitTest.Service
{
    [TestFixture]
    public class CompanyServiceUnitTest
    {
        private IEnumerable<Company> companies;
        private IRepository repo;
        private TruckDbContext truckDbContext;
        private ILogger<CompanyService> logger;

        private ICompanyService companyService;


        [SetUp]
        public void SetUp()
        {
            var contextOptions = new DbContextOptionsBuilder<TruckDbContext>()
               .UseInMemoryDatabase("TruckDB")
               .Options;
            truckDbContext = new TruckDbContext(contextOptions);

            truckDbContext.Database.EnsureDeleted();
            truckDbContext.Database.EnsureCreated();

        }

        [Test]
        public async Task Test_CreateAsync()
        {
            var loggerMock = new Mock<ILogger<CompanyService>>();
            logger = loggerMock.Object;
            var repo = new Repository(truckDbContext);
            companyService = new CompanyService(repo);
            var newCompany = new CompanyFormModel()
            {
                CompanyVat = "123456789",
                Name = "FRANCE COMPANY",
                Country = "France",
                Town = "Colmar",
                Address = "rue papin 10"
            };

            var result = await companyService.CreateAsync(newCompany);


            Assert.NotNull(result);

        }

        [Test]
        public async Task Test_EditAsync()
        {
            var loggerMock = new Mock<ILogger<CompanyService>>();
            logger = loggerMock.Object;
            var repo = new Repository(truckDbContext);

            companyService = new CompanyService(repo);

            await repo.AddAsync(new Company()
            {
                Id = 1,
                CompanyVat = "123456789",
                CompanyName = "FRANCE COMPANY",
                CompanyCountry = "France",
                CompanyTown = "Colmar",
                CompanyAddress = "rue papin 10"
            });

            await repo.SaveChangesAsync();

            await companyService.EditAsync(1, new CompanyEditFormModel
            {
                CompanyVat = "Edit",
                Name = "Edit",
                Country = "Edit",
                Town = "Edit",
                Address = "Edit"
            });

            var company = await repo.GetByIdAsync<Company>(1);

            //Assert.That(company.Id, Is.EqualTo(1));
            Assert.That(company.CompanyVat, Is.EqualTo("EDIT"));
            Assert.That(company.CompanyName, Is.EqualTo("Edit"));
            Assert.That(company.CompanyCountry, Is.EqualTo("Edit"));
            Assert.That(company.CompanyTown, Is.EqualTo("Edit"));
            Assert.That(company.CompanyAddress, Is.EqualTo("Edit"));
        }

        [Test]
        public async Task Test_FindCompanyByIdAsync()
        {
            var loggerMock = new Mock<ILogger<CompanyService>>();
            logger = loggerMock.Object;
            var repo = new Repository(truckDbContext);

            companyService = new CompanyService(repo);
            await repo.AddRangeAsync(new List<Company>()
                            {
                                new Company (){ Id=1,
                                                CompanyVat = "123456789",
                                                CompanyName = "FRANCE COMPANY",
                                                CompanyCountry="France",
                                                CompanyTown="Colmar",
                                                CompanyAddress="rue papin 10"},
                                new Company() { Id = 2,
                                                CompanyVat = "987654321",
                                                CompanyName = "GERMANY COMPANY",
                                                CompanyCountry = "Germany",
                                                CompanyTown = "Berlin",
                                                CompanyAddress = "Hauptstraße 1" }
                            });
            await repo.SaveChangesAsync();

            var company = await companyService.FindCompanyByIdAsync(1);

            Assert.That(company.Id, Is.EqualTo(1));
            Assert.That(company.Vat, Is.EqualTo("123456789"));
            Assert.That(company.Name, Is.EqualTo("FRANCE COMPANY"));
            Assert.That(company.Country, Is.EqualTo("France"));

        }

        [Test]
        public async Task Test_RetuenNullFindCompanyByIdAsync()
        {
            var loggerMock = new Mock<ILogger<CompanyService>>();
            logger = loggerMock.Object;
            var repo = new Repository(truckDbContext);

            companyService = new CompanyService(repo);
            await repo.AddRangeAsync(new List<Company>()
                            {
                                new Company (){ Id=1,
                                                CompanyVat = "123456789",
                                                CompanyName = "FRANCE COMPANY",
                                                CompanyCountry="France",
                                                CompanyTown="Colmar",
                                                CompanyAddress="rue papin 10"},
                                new Company() { Id = 2,
                                                CompanyVat = "987654321",
                                                CompanyName = "GERMANY COMPANY",
                                                CompanyCountry = "Germany",
                                                CompanyTown = "Berlin",
                                                CompanyAddress = "Hauptstraße 1" }
                            });
            await repo.SaveChangesAsync();

            var company = await companyService.FindCompanyByIdAsync(3);

            Assert.That(company, Is.Null);

        }

        [Test]
        public async Task Test_FindCompanyByVatAsync()
        {
            var loggerMock = new Mock<ILogger<CompanyService>>();
            logger = loggerMock.Object;
            var repo = new Repository(truckDbContext);

            companyService = new CompanyService(repo);
            await repo.AddRangeAsync(new List<Company>()
                            {
                                new Company (){ Id=1,
                                                CompanyVat = "123456789",
                                                CompanyName = "FRANCE COMPANY",
                                                CompanyCountry="France",
                                                CompanyTown="Colmar",
                                                CompanyAddress="rue papin 10"},
                                new Company() { Id = 2,
                                                CompanyVat = "987654321",
                                                CompanyName = "GERMANY COMPANY",
                                                CompanyCountry = "Germany",
                                                CompanyTown = "Berlin",
                                                CompanyAddress = "Hauptstraße 1" }
                            });
            await repo.SaveChangesAsync();

            var company = await companyService.FindCompanyByVatAsync("123456789");

            Assert.That(company.Id, Is.EqualTo(1));
            Assert.That(company.Vat, Is.EqualTo("123456789"));
            Assert.That(company.Name, Is.EqualTo("FRANCE COMPANY"));
            Assert.That(company.Country, Is.EqualTo("France"));
        }
        [Test]
        public async Task Test_RetuenNullFindCompanyByVatAsync()
        {
            var loggerMock = new Mock<ILogger<CompanyService>>();
            logger = loggerMock.Object;
            var repo = new Repository(truckDbContext);

            companyService = new CompanyService(repo);
            await repo.AddRangeAsync(new List<Company>()
                            {
                                new Company (){ Id=1,
                                                CompanyVat = "123456789",
                                                CompanyName = "FRANCE COMPANY",
                                                CompanyCountry="France",
                                                CompanyTown="Colmar",
                                                CompanyAddress="rue papin 10"},
                                new Company() { Id = 2,
                                                CompanyVat = "987654321",
                                                CompanyName = "GERMANY COMPANY",
                                                CompanyCountry = "Germany",
                                                CompanyTown = "Berlin",
                                                CompanyAddress = "Hauptstraße 1" }
                            });
            await repo.SaveChangesAsync();

            var company = await companyService.FindCompanyByVatAsync("000000000");

            Assert.That(company, Is.Null);

        }

        [Test]
        public async Task Test_GetAllCompanyReadOnlyOrderByNameAsync()
        {
            var loggerMock = new Mock<ILogger<CompanyService>>();
            logger = loggerMock.Object;
            var repo = new Repository(truckDbContext);

            companyService = new CompanyService(repo);
            await repo.AddRangeAsync(new List<Company>()
                            {
                                new Company (){ Id=1,
                                                CompanyVat = "123456789",
                                                CompanyName = "AAAAA",
                                                CompanyCountry="France",
                                                CompanyTown="Colmar",
                                                CompanyAddress="rue papin 10"},
                                new Company() { Id = 2,
                                                CompanyVat = "987654321",
                                                CompanyName = "BBBBB",
                                                CompanyCountry = "Germany",
                                                CompanyTown = "Berlin",
                                                CompanyAddress = "Hauptstraße 1" }
                              });
            await repo.SaveChangesAsync();

            var companiesTask = companyService.GetAllCompanyReadOnlyOrderByNameAsync();
            var companies = await companiesTask;
            string[] result = companies.Select(comp => comp.Country).ToArray();

            Assert.That(result[0], Is.EqualTo("France"));
            Assert.That(result[1], Is.EqualTo("Germany"));
            Assert.That(result.Count(), Is.EqualTo(2));
        }

        [Test]
        public async Task Test_GetAllUniqueCountryAsync()
        {
            var loggerMock = new Mock<ILogger<CompanyService>>();
            logger = loggerMock.Object;
            var repo = new Repository(truckDbContext);

            companyService = new CompanyService(repo);
            await repo.AddRangeAsync(new List<Company>()
                            {
                                new Company (){ Id=1,
                                                CompanyVat = "123456789",
                                                CompanyName = "AAAAA",
                                                CompanyCountry="France",
                                                CompanyTown="Colmar",
                                                CompanyAddress="rue papin 10"},
                                new Company() { Id = 2,
                                                CompanyVat = "987654321",
                                                CompanyName = "BBBBB",
                                                CompanyCountry = "Germany",
                                                CompanyTown = "Berlin",
                                                CompanyAddress = "Hauptstraße 1" },
                                new Company() { Id = 3,
                                                CompanyVat = "087654320",
                                                CompanyName = "DDDDDDD",
                                                CompanyCountry = "Germany",
                                                CompanyTown = "Koblenz",
                                                CompanyAddress = "Hauptstraße 11" }
                            });
            await repo.SaveChangesAsync();

            var companiesTask = companyService.GetAllUniqueCountryAsync();
            var companies = await companiesTask;
            string[] result = companies.Select(comp => comp.Country).ToArray();

            Assert.That(result[0], Is.EqualTo("FRANCE"));
            Assert.That(result[1], Is.EqualTo("GERMANY"));
            Assert.That(result.Count(), Is.EqualTo(2));
        }

        [Test]
        public async Task Test_GetCompanyForEditByIdAsync()
        {
            var loggerMock = new Mock<ILogger<CompanyService>>();
            logger = loggerMock.Object;
            var repo = new Repository(truckDbContext);

            companyService = new CompanyService(repo);
            await repo.AddRangeAsync(new List<Company>()
                            {
                                new Company (){ Id=1,
                                                CompanyVat = "123456789",
                                                CompanyName = "FRANCE COMPANY",
                                                CompanyCountry="France",
                                                CompanyTown="Colmar",
                                                CompanyAddress="rue papin 10"},
                                new Company() { Id = 2,
                                                CompanyVat = "987654321",
                                                CompanyName = "GERMANY COMPANY",
                                                CompanyCountry = "Germany",
                                                CompanyTown = "Berlin",
                                                CompanyAddress = "Hauptstraße 1" }
                            });
            await repo.SaveChangesAsync();

            var company = await companyService.GetCompanyForEditByIdAsync(1);

            Assert.That(company.Id, Is.EqualTo(1));
            Assert.That(company.CompanyVat, Is.EqualTo("123456789"));
            Assert.That(company.Name, Is.EqualTo("FRANCE COMPANY"));
            Assert.That(company.Country, Is.EqualTo("France"));
        }

        [Test]
        public async Task Test_GetCompanyFromCountryAsync()
        {
            var loggerMock = new Mock<ILogger<CompanyService>>();
            logger = loggerMock.Object;
            var repo = new Repository(truckDbContext);

            companyService = new CompanyService(repo);
            await repo.AddRangeAsync(new List<Company>()
                            {
                                new Company (){ Id=1,
                                                CompanyVat = "123456789",
                                                CompanyName = "AAAAA",
                                                CompanyCountry="France",
                                                CompanyTown="Colmar",
                                                CompanyAddress="rue papin 10"},
                                new Company() { Id = 2,
                                                CompanyVat = "987654321",
                                                CompanyName = "BBBBB",
                                                CompanyCountry = "Germany",
                                                CompanyTown = "Berlin",
                                                CompanyAddress = "Hauptstraße 1" },
                                new Company() { Id = 3,
                                                CompanyVat = "087654320",
                                                CompanyName = "DDDDDDD",
                                                CompanyCountry = "Germany",
                                                CompanyTown = "Koblenz",
                                                CompanyAddress = "Hauptstraße 11" }
                            });
            await repo.SaveChangesAsync();

            var companiesTask = companyService.GetCompanyFromCountryAsync("Germany");
            var companies = await companiesTask;
            string[] result = companies.Select(comp => comp.Name).ToArray();

            Assert.That(result[0], Is.EqualTo("BBBBB"));
            Assert.That(result[1], Is.EqualTo("DDDDDDD"));
            Assert.That(result.Count(), Is.EqualTo(2));
        }
        [Test]
        public async Task Test_ReturnTrueIsCompanyExistByVat()
        {
            var loggerMock = new Mock<ILogger<CompanyService>>();
            logger = loggerMock.Object;
            var repo = new Repository(truckDbContext);
            companyService = new CompanyService(repo);
            var newCompany = new CompanyFormModel()
            {
                CompanyVat = "123456789",
                Name = "FRANCE COMPANY",
                Country = "France",
                Town = "Colmar",
                Address = "rue papin 10"
            };

            await companyService.CreateAsync(newCompany);

            bool result = await companyService.IsCompanyExistByVat("123456789");


            Assert.That(result, Is.True);
        }
        [Test]
        public async Task Test_ReturnFalseIsCompanyExistByVat()
        {
            var loggerMock = new Mock<ILogger<CompanyService>>();
            logger = loggerMock.Object;
            var repo = new Repository(truckDbContext);
            companyService = new CompanyService(repo);
            var newCompany = new CompanyFormModel()
            {
                CompanyVat = "123456789",
                Name = "FRANCE COMPANY",
                Country = "France",
                Town = "Colmar",
                Address = "rue papin 10"
            };

            await companyService.CreateAsync(newCompany);

            bool result = await companyService.IsCompanyExistByVat("000000000");

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task Test_ReturnNotNullRemoveCompanyByIdAsync()
        {
            var loggerMock = new Mock<ILogger<CompanyService>>();
            logger = loggerMock.Object;
            var repo = new Repository(truckDbContext);
            companyService = new CompanyService(repo);
            var newCompany = new CompanyFormModel()
            {
                CompanyVat = "123456789",
                Name = "FRANCE COMPANY",
                Country = "France",
                Town = "Colmar",
                Address = "rue papin 10"
            };

            int id = await companyService.CreateAsync(newCompany);

            var result = await companyService.RemoveCompanyByIdAsync(id);

            Assert.That(result.Active, Is.False);
            Assert.That(result, Is.Not.Null);
        }


        [TearDown]
        public void TearDown()
        {
            truckDbContext.Dispose();
        }

    }
}
