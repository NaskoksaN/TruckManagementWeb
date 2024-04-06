using Microsoft.EntityFrameworkCore;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.User;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.Core.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository repository;
        public EmployeeService(IRepository _repository)
        {
            repository = _repository;
        }

        /// <summary>
        /// Asynchronously creates a new employee with the provided details.
        /// </summary>
        /// <param name="model">The model containing the details of the employee to create.</param>
        /// <param name="userId">The ID of the user associated with the employee.</param>
        /// <param name="roleId">The ID of the role assigned to the employee.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task CreateEmployeeAsync(RegisterFormModel model, string userId, string roleId)
        {

            Employee employee = new Employee()
            {
                Email = model.Email,
                FullName = model.FullName,
                EmployeeUserId = userId,
                RoleId = roleId,
            };

            await repository.AddAsync(employee);
            await repository.SaveChangesAsync();
        }



        /// <summary>
        /// Asynchronously finds the ID of the employee associated with the provided user ID.
        /// </summary>
        /// <param name="employeeUserId">The ID of the user associated with the employee.</param>
        /// <returns>The ID of the employee if found, otherwise 0.</returns>
        /// <remarks>If no employee is found with the given user ID, returns 0.</remarks>
        public async Task<int> FindEmployeeIdAsync(string employeeUserId)
        {
            var employee = await repository.AllAsync<Employee>()
                                            .Where(e => e.EmployeeUserId == employeeUserId)
                                            .FirstOrDefaultAsync();
            return employee.Id;
        }


        /// <summary>
        /// Retrieves a list of all active users along with their details.
        /// </summary>
        /// <returns>A list of <see cref="UserViewModel"/> objects representing active users.</returns>
        /// <remarks>Only users marked as active are included in the result.</remarks>
        public async Task<List<UserViewModel>> GetAllUserAsync()
        {
            bool activity = true;
            var users = await repository.AllReadOnlyAsync<Employee>()
                    .Where(e => e.IsActive == activity)
                    .Select(e => new UserViewModel
                    {
                        Id = e.Id,
                        FullName = e.FullName,
                        Email = e.Email,
                        AccessArea = e.Role.Name
                    })
                    .ToListAsync();

            return users;
        }
    }
}
