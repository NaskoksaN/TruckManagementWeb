using Microsoft.EntityFrameworkCore;
using TruckManagementWeb.Data;

namespace TruckManagementWeb.UnitTest.Mocks
{
    public static class DatabaseMock
    {
        public static TruckDbContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<TruckDbContext>()
                    .UseInMemoryDatabase("TruckInMemoryDb" + DateTime.Now.Ticks.ToString())
                    .Options;

                return new TruckDbContext(dbContextOptions, false);
            }
        }
    }
}
