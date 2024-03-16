using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckManagementWeb.Core.Models.Trip;

namespace TruckManagementWeb.Core.Contracts
{
    public interface ITripService
    {
        Task<int> CreateTripAsync(TripFormModel form);
        Task DeleteGivenTripWithOrders(int tripId);
        Task<IEnumerable<TripViewModel>> GetAllTripAsync();
        Task<TripViewModel> GetViewTripByIdAsync(int id);
        Task SaveOrderToTripAsync(OrderFormModel form);
    }
}
