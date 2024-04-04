using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TruckManagementWeb.Infrastructure.Data.Configuration
{
    public  class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                    RoleId = "adminRoleId"
                },
                new IdentityUserRole<string>
                {
                    UserId = "0261d5ca-050a-423e-90cb-c7e990f67959",
                    RoleId = "managerRoleId"
                },
                new IdentityUserRole<string>
                {
                    UserId = "62154153-66df-4b35-91ed-56ac983c9a8e",
                    RoleId = "dispatcherRoleId"
                },
                new IdentityUserRole<string>
                {
                    UserId = "19918df1-9468-434b-aaf9-a3d22b2d12e2",
                    RoleId = "dispatcherRoleId"
                }
        );
    }
}
}
