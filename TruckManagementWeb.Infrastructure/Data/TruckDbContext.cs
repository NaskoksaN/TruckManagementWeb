using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TruckManagementWeb.Core.Models.ApplicationUser;
using TruckManagementWeb.Infrastructure.Data.Configuration;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.Data
{
    public class TruckDbContext : IdentityDbContext<ApplicationUser, IdentityRole<string>,string>
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


            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());

            // Seed roles
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "adminRoleId", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "managerRoleId", Name = "Manager", NormalizedName = "MANAGER" },
                new IdentityRole { Id = "dispatcherRoleId", Name = "Dispo", NormalizedName = "DISPO" }
            );

            // Seed employee and assign admin role
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Email = "admin@truck.com",
                    EmployeeUserId = "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                    RoleId = "adminRoleId"
                }
            );

            
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "d401e5f8-2fe9-45e2-9209-69b7db1c1de9", 
                    RoleId = "adminRoleId" 
                }
            );

            //modelBuilder.ApplyConfiguration(new TruckConfiguration());
            //modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            //modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            //modelBuilder.ApplyConfiguration(new TruckExpenseConfiguration());

            //TripSeeder.SeedData(modelBuilder);

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
