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
                    new Employee { Id = 1, Email = "admin@truck.com", EmployeeUserId = "d401e5f8-2fe9-45e2-9209-69b7db1c1de9", RoleId= "adminRoleId"},
                    new Employee { Id = 2, Email = "manager@truck.com", EmployeeUserId = "0261d5ca-050a-423e-90cb-c7e990f67959", RoleId= "managerRoleId" },
                    new Employee { Id = 3, Email = "dispo1@truck.com", EmployeeUserId = "62154153-66df-4b35-91ed-56ac983c9a8e", RoleId= "dispatcherRoleId" },
                    new Employee { Id = 4, Email = "dispo2@truck.com", EmployeeUserId = "19918df1-9468-434b-aaf9-a3d22b2d12e2", RoleId= "dispatcherRoleId"}
                );
        }
    }
}
