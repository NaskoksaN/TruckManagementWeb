using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TruckManagementWeb.Core.Models.ApplicationUser;
using TruckManagementWeb.Infrastructure.Data.Configuration;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.Data
{
    public class TruckDbContext : IdentityDbContext<ApplicationUser, IdentityRole<string>,string>
    {
        private bool seedDb;
        public TruckDbContext(DbContextOptions<TruckDbContext> options , bool _seedDb = true)
            : base(options)
        {
            if(Database.IsRelational())
            {
                Database.Migrate();
            }
            else
            {
                Database.EnsureCreated();
            }

            seedDb = _seedDb;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Trip)
                .WithMany(t => t.Orders)
                .HasForeignKey(o => o.TripId)
                .OnDelete(DeleteBehavior.Restrict);

            if (seedDb == true)
            {

                modelBuilder.ApplyConfiguration(new IdentityRoleConfiguration());
                modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
                modelBuilder.ApplyConfiguration(new IdentityUserRoleConfiguration());

                modelBuilder.ApplyConfiguration(new TruckConfiguration());
                modelBuilder.ApplyConfiguration(new CompanyConfiguration());
                modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
                modelBuilder.ApplyConfiguration(new TruckExpenseConfiguration());

                TripSeeder.SeedData(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Truck> Trucks { get; set; } 
        public DbSet<TruckExpense> TruckExpenses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Trip> Tripes { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
