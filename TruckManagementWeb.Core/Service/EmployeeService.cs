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

        public async Task<int> FindEmployeeIdAsync(string employeeUserId)
        {
            var employee = await repository.AllAsync<Employee>()
                                            .Where(e => e.EmployeeUserId == employeeUserId)
                                            .FirstOrDefaultAsync();
            return employee.Id;
        }
    }
}
