using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TruckManagementWeb.Core.Models.ApplicationUser;
using TruckManagementWeb.Infrastructure.Data.Configuration;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.Data
{
    public class TruckDbContext : IdentityDbContext
    {
        public TruckDbContext(DbContextOptions<TruckDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Trip)
                .WithMany(t => t.Orders)
                .HasForeignKey(o => o.TripId)
                .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<ApplicationUser>()
            //        .HasKey(u => u.Id);


           // modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());

            modelBuilder.ApplyConfiguration(new TruckConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new TruckExpenseConfiguration());

            TripSeeder.SeedData(modelBuilder);

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
