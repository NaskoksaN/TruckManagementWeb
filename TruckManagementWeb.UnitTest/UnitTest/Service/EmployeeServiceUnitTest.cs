using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.User;
using TruckManagementWeb.Core.Service;
using TruckManagementWeb.Data;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;
using TruckManagementWeb.Infrastructure.Migrations;

namespace TruckManagementWeb.UnitTest.UnitTest.Service
{
    public class EmployeeServiceUnitTest
    {
        private IRepository repo;
        private TruckDbContext applicationDbContext;
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

            RegisterFormModel model = new RegisterFormModel()
            {
                Email = "admin@truck.com",
                Password = "sdf",
                ConfirmPassword = "sdf",
                FullName="hans hansov",
                SelectedRole = "adminRoleId",
               
            };

            await employeeService.CreateEmployeeAsync(model,"d401e5f8-2fe9-45e2-9209-69b7db1c1de9", "adminRoleId");

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

        [Test]
        public async Task Test_GetAllUserAsync()
        {
            var repo = new Repository(applicationDbContext);

            employeeService = new EmployeeService(repo);

            var employees = new List<Employee>
            {
                new Employee { Id = 1,  Email = "john@example.com", IsActive = true, RoleId = "adminRoleId", EmployeeUserId = "d401e5f8-2fe9-45e2-9209-69b7db1c1de9"  },
                new Employee { Id = 2, Email = "jane@example.com", IsActive = false,  RoleId = "managerRoleId", EmployeeUserId = "0261d5ca-050a-423e-90cb-c7e990f67959"  }
            };
            await repo.AddRangeAsync<Employee>(employees);
            await repo.SaveChangesAsync();

            List<UserViewModel> users = await employeeService.GetAllUserAsync();
            List<Employee>t= await repo.AllAsync<Employee>().Where(e=>e.IsActive==true).ToListAsync();

            Assert.IsNotNull(users);
            //Assert.AreEqual(1, result.Count);
            //var user = result.First();
            //Assert.AreEqual(1, user.Id);
            //Assert.AreEqual("John Doe", user.FullName);
            //Assert.AreEqual("john@example.com", user.Email);
            //Assert.AreEqual("Admin", user.AccessArea);
        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }
    }


}
