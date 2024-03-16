using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.Infrastructure.Data.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .HasData(
                    new Employee { Id = 1, Email = "admin@truck.com", EmployeeUserId = "05ec77f9-f1a2-44ce-a38e-609329542e7e" },
                    new Employee { Id = 2, Email = "manager@truck.com", EmployeeUserId = "0261d5ca-050a-423e-90cb-c7e990f67959" },
                    new Employee { Id = 3, Email = "dispo1@truck.com", EmployeeUserId = "62154153-66df-4b35-91ed-56ac983c9a8e" },
                    new Employee { Id = 4, Email = "dispo2@truck.com", EmployeeUserId = "19918df1-9468-434b-aaf9-a3d22b2d12e2" }
                );
        }
    }
}
