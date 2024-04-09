using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TruckManagementWeb.Infrastructure.Data.Configuration
{
    public class UserClaimsConfiguration : IEntityTypeConfiguration<IdentityUserClaim<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserClaim<string>> builder)
        {
            builder.ToTable("AspNetUserClaims");
            builder.HasData(
                new IdentityUserClaim<string>
                {
                    Id = 1,
                    UserId = "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                    ClaimType = "user:fullname",
                    ClaimValue = "Admin Admin"
                },
                new IdentityUserClaim<string>
                {
                    Id = 2,
                    UserId = "0261d5ca-050a-423e-90cb-c7e990f67959",
                    ClaimType = "user:fullname",
                    ClaimValue = "Chief Chiefov"
                },
                new IdentityUserClaim<string>
                {
                    Id = 3,
                    UserId = "62154153-66df-4b35-91ed-56ac983c9a8e",
                    ClaimType = "user:fullname",
                    ClaimValue = "Hans Uno"
                },
                 new IdentityUserClaim<string>
                 {
                     Id = 4,
                     UserId = "19918df1-9468-434b-aaf9-a3d22b2d12e2",
                     ClaimType = "user:fullname",
                     ClaimValue = "Admin Admin"
                 }
                );
        }
    }
}
