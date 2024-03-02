using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckManagementWeb.Core.Models.Truck;

namespace TruckManagementWeb.Core.Contracts
{
    public interface ITruckService
    {
        Task<int> CreateAsync(TruckFormModel form);
        Task<TruckViewModel?> GetTruckByIdAsync(int id);
        Task<bool> IsTruckExistAsync(string truckPlate);
    }
}
