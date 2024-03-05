using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Trip;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.Core.Service
{
    public class TripService : ITripService
    {
        private readonly IRepository repository;
        private readonly ITruckService truckService;
        public TripService(IRepository _repository,
            ITruckService _truckService)
        {
            repository = _repository;
            truckService = _truckService;
        }

        public async Task<int> CreateTripAsync(TripFormModel form)
        {
            string plate = form.TruckPlate.Trim();
            int truckId = await truckService.GetTruckIdByPlate(plate);
            Trip trip = new Trip()
            {
                TripKm = form.TripKm,
                TripPrice = form.TripPrice,
                StartDate = form.StartDate,
                EndDate = form.EndDate,
                TruckId = truckId
            };

            await repository.AddAsync(trip);
            return await repository.SaveChangesAsync();
        }
    }
}
