using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruckManagementWeb.Core.Models.ApplicationUser;

namespace TruckManagementWeb.Infrastructure.Data.Configuration
{
    public  class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            string defaultPassword = "a12345";
            builder.HasData(
                new ApplicationUser
                {
                    Id = "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                    Email = "admin@truck.com",
                    NormalizedEmail = "admin@truck.com".ToUpper(),
                    UserName = "admin@truck.com",
                    NormalizedUserName = "admin@truck.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, defaultPassword),
                    SecurityStamp = Guid.NewGuid().ToString()
                },
                new ApplicationUser
                {
                    Id = "0261d5ca-050a-423e-90cb-c7e990f67959",
                    Email = "manager@truck.com",
                    NormalizedEmail = "manager@truck.com".ToUpper(),
                    UserName = "manager@truck.com",
                    NormalizedUserName = "manager@truck.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, defaultPassword),
                    SecurityStamp = Guid.NewGuid().ToString()
                },
                new ApplicationUser
                {
                    Id = "62154153-66df-4b35-91ed-56ac983c9a8e",
                    Email = "dispo1@truck.com",
                    NormalizedEmail = "dispo1@truck.com".ToUpper(),
                    UserName = "dispo1@truck.com",
                    NormalizedUserName = "dispo1@truck.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, defaultPassword),
                    SecurityStamp = Guid.NewGuid().ToString()
                },
                new ApplicationUser
                {
                    Id = "19918df1-9468-434b-aaf9-a3d22b2d12e2",
                    Email = "dispo2@truck.com",
                    NormalizedEmail = "dispo2@truck.com".ToUpper(),
                    UserName = "dispo2@truck.com",
                    NormalizedUserName = "dispo2@truck.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, defaultPassword),
                    SecurityStamp = Guid.NewGuid().ToString()
                }
            );
        }
        
    }
}
