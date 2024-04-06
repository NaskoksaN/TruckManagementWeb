using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Service;
using TruckManagementWeb.Data;
using TruckManagementWeb.Infrastructure.Data.Common;

namespace TruckManagementWeb.UnitTest.UnitTest.Service
{
    public class UserServiceUnitTest
    {
        private IRepository repo;
        private TruckDbContext applicationDbContext;
        private IUserService userService;


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





        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }
    }
}
