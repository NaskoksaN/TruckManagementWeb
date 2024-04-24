using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.ApplicationUser;
using TruckManagementWeb.Core.Service;
using TruckManagementWeb.Data;
using TruckManagementWeb.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApllicationServices(this IServiceCollection services)
        {
            services.AddScoped<ITruckService, TruckService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<ITripService, TripService>();
            services.AddScoped<IReports, ReportService>();
            services.AddScoped<IExpenseService, ExpenseService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IMyEmailService, MyEmailService>();
            services.AddScoped<ISellOrder, SellOrder>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services,
                            IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<TruckDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services,
                            IConfiguration config)
        {
            services
                .AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<TruckDbContext>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly", policy =>
                {
                    policy.RequireRole("Admin");
                    policy.RequireRole("Manager");
                    policy.RequireRole("Dispo");
                });
            });

            services.ConfigureApplicationCookie(options=>
            {
                options.LoginPath = $"/User/Login";
                options.LogoutPath = $"/User/Logout";
            });


            return services;
        }
    }
}
