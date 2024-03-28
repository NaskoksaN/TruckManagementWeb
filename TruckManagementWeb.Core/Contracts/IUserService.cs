using TruckManagementWeb.Core.Models.User;

namespace TruckManagementWeb.Core.Contracts
{
    public interface IUserService
    {
        Task<List<UserViewModel>> GetAllUserAync();
        Task<IEnumerable<RoleViewModel>> GetRolesAsync();
    }
}
