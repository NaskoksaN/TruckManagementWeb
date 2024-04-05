using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Service;
using TruckManagementWeb.Data;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Enum;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.UnitTest.UnitTest.Service
{
    public class ExpenseServiceUnitTest
    {
        private IEnumerable<TruckExpense> expenses;
        private IRepository repo;
        private TruckDbContext applicationDbContext;
        private ILogger<ExpenseService> logger;
        private ICompanyService expenseService;
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
        public async Task Test_AddExpenseAsync()
        {
            var repo = new Repository(applicationDbContext);
            ITruckService truckService = new TruckService(repo);
            var expenseService = new ExpenseService(repo, truckService);

            TruckExpense expense = new()
            {
                TruckId = 1,
                Amount = 1000,
                Notes = "fuel",
                ExpenseDate = DateTime.Now,
                EmployeeId = 1,
            };
            await repo.AddAsync(expense);
            await repo.SaveChangesAsync();

            var tempExpense = await repo.GetByIdAsync<TruckExpense>(1);
            int id = tempExpense.Id;

            Assert.That(id, Is.EqualTo(1));
        }

        [Test]
        public async Task Test_GetExpenseByIdAsync()
        {
            var repo = new Repository(applicationDbContext);
            ITruckService truckService = new TruckService(repo);
            var expenseService = new ExpenseService(repo, truckService);

            TruckExpense expense = new()
            {
                TruckId = 1,
                Amount = 1000,
                Notes = "fuel",
                ExpenseDate = DateTime.Now,
                EmployeeId = 1,
            };
            await repo.AddAsync(expense);
            await repo.SaveChangesAsync();

            var result = await repo.GetByIdAsync<TruckExpense>(1);

            Assert.IsNotNull(result);
            Assert.That(result.Amount, Is.EqualTo(1000));
            Assert.That(result.Notes, Is.EqualTo("fuel"));
        }

        [Test]
        public async Task Test_GetExpenseTypesAsync()
        {
            var repo = new Repository(applicationDbContext);
            ITruckService truckService = new TruckService(repo);
            var expenseService = new ExpenseService(repo, truckService);

            var expectedExpenseTypes = Enum.GetNames(typeof(ExpenseType)).ToList();

            var actualExpenseTypes = expenseService.GetExpenseTypesAsync();

            Assert.AreEqual(expectedExpenseTypes.Count, actualExpenseTypes.Count);
            Assert.IsTrue(expectedExpenseTypes.SequenceEqual(actualExpenseTypes));
        }
    }
}
