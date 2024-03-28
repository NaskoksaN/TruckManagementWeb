using TruckManagementWeb.Core.Models.Truck;

namespace TruckManagementWeb.Core.Contracts
{
    public interface ITruckService
    {
        Task<int> CreateAsync(TruckFormModel form);
        Task<IEnumerable<TruckIndexViewModel>> GetAlltruckReadOnlyAsync();
        Task<TruckViewModel?> FindTruckByIdAsyncc(int id);
        Task<bool> IsTruckExistAsync(string truckPlate);
        Task<TruckViewModel> RemoveTruckAsync(int truckId);
        Task<TruckEditFormModel?> GetTruckForEditByIdAsync(int id);
        Task<TruckViewModel?> FindTruckByPlateAsync(string plate);
        Task EditAsync(int id, TruckEditFormModel form);
        Task<int> GetTruckIdByPlate(string plate);
    }
}
