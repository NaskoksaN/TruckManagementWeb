using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Trip)
                .WithMany(t => t.Orders)
                .HasForeignKey(o => o.TripId)
                .OnDelete(DeleteBehavior.Restrict); 
        }

        public DbSet<Truck> Trucks { get; set; } 
        public DbSet<TruckExpense> TruckExpenses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Trip> Tripes { get; set; }
    }
}
