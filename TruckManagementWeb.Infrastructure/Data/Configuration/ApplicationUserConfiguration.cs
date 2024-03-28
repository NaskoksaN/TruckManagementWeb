using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruckManagementWeb.Core.Models.ApplicationUser;

namespace TruckManagementWeb.Infrastructure.Data.Configuration
{
    public  class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        private readonly ApplicationUser AdminUser;

        public ApplicationUserConfiguration()
        {
            AdminUser = new ApplicationUser
            {
                Id = "d401e5f8-2fe9-45e2-9209-69b7db1c1de9",
                Email = "admin@truck.com",
                NormalizedEmail = "admin@truck.com",
                UserName = "admin@truck.com",
                NormalizedUserName = "admin@truck.com",
                SecurityStamp = Guid.NewGuid().ToString()
            };
        }

        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(
                AdminUser
            );

            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "a12345");
        }
    }
}
