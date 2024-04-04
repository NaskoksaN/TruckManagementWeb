using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace TruckManagementWeb.Infrastructure.Data.Configuration
{
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { Id = "adminRoleId", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "managerRoleId", Name = "Manager", NormalizedName = "MANAGER" },
                new IdentityRole { Id = "dispatcherRoleId", Name = "Dispo", NormalizedName = "DISPO" }
            );
        }
    }
}
