using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Service;
using TruckManagementWeb.Data;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;
using TruckManagementWeb.Infrastructure.Migrations;

namespace TruckManagementWeb.UnitTest.UnitTest.Service
{
    public class EmployeeServiceUnitTest
    {
        private IEnumerable<Employee> employees;
        private IRepository repo;
        private TruckDbContext applicationDbContext;
        private ILogger<EmployeeService> logger;
        private IEmployeeService employeeService;

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
        public async Task Test_CreateEmployeeAsync()
        {

            var repo = new Repository(applicationDbContext);
            employeeService = new EmployeeService(repo);

            Employee employee = new Employee()
            {
                Email = "admin@truck.com",
                FullName = "FullName",
                EmployeeUserId = "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                RoleId = "adminRoleId",
            };

            await repo.AddAsync(employee);
            await repo.SaveChangesAsync();

            var result = await repo.GetByIdAsync<Employee>(1);

            Assert.IsNotNull(result);
            Assert.That(result.Email, Is.EqualTo("admin@truck.com"));
            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result.RoleId, Is.EqualTo("adminRoleId"));
            Assert.That(result.EmployeeUserId, Is.EqualTo("d401e5f8-2fe9-45e2-9209-69b7db1c1de9"));
        }

        [Test]
        public async Task Test_FindEmployeeIdAsync()
        {

            var repo = new Repository(applicationDbContext);
            employeeService = new EmployeeService(repo);

            Employee employee = new Employee()
            {
                Email = "admin@truck.com",
                FullName = "FullName",
                EmployeeUserId = "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                RoleId = "adminRoleId",
            };

            await repo.AddAsync(employee);
            await repo.SaveChangesAsync();

            var id = await employeeService.FindEmployeeIdAsync("d401e5f8-2fe9-45e2-9209-69b7db1c1de9");
            var result = await repo.GetByIdAsync<Employee>(id);

            Assert.IsNotNull(result);
            Assert.That(result.Email, Is.EqualTo("admin@truck.com"));
            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result.RoleId, Is.EqualTo("adminRoleId"));
            Assert.That(result.EmployeeUserId, Is.EqualTo("d401e5f8-2fe9-45e2-9209-69b7db1c1de9"));
        }
    }
}
