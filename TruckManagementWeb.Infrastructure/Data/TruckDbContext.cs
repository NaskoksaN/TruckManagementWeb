using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TruckManagementWeb.Data
{
    public class TruckDbContext : IdentityDbContext
    {
        public TruckDbContext(DbContextOptions<TruckDbContext> options)
            : base(options)
        {
        }
    }
}
