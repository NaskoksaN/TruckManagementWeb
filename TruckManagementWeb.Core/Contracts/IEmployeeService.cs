using TruckManagementWeb.Core.Models.User;

namespace TruckManagementWeb.Core.Contracts
{
    public interface IEmployeeService
    {
        Task CreateEmployeeAsync(RegisterFormModel model, string userId, string roleId);
    }
}
