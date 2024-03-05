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
    }
}
