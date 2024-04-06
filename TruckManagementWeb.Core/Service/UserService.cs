using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.User;
using TruckManagementWeb.Core.Models.ApplicationUser;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.Core.Service
{
    public class UserService : IUserService
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IRepository repository;

        public UserService( RoleManager<IdentityRole> _roleManager,
                            IRepository _repository)
        {
            roleManager = _roleManager;
            repository = _repository;
        }

        public async Task<List<UserViewModel>> GetAllUserAync()
        {
            bool activity = true;
            var users = await repository.AllAsync<Employee>()
                    .Where(e=> e.IsActive== activity)
                    .Select(e=> new UserViewModel
                    {
                        Id = e.Id,
                        FullName=e.FullName,
                        Email=e.Email,
                        AccessArea = e.Role.Name
                    })
                    .ToListAsync();

            return users;
        }

        public async Task<IEnumerable<RoleViewModel>> GetRolesAsync()
        {
            IEnumerable<RoleViewModel> result = await roleManager
                .Roles
                .Select(r => new RoleViewModel()
                {
                    Id = r.Id,
                    Name = r.Name
                })
                .ToListAsync();

            return result;
        }
    }
}
