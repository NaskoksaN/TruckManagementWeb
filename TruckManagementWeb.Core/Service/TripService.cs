using Microsoft.EntityFrameworkCore;

using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Trip;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;
using static TruckManagementWeb.Core.Constants.ValidationConstants;

namespace TruckManagementWeb.Core.Service
{
    public class TripService : ITripService
    {
        private readonly IRepository repository;
        private readonly ITruckService truckService;
        private readonly ICompanyService companyService;
        public TripService(IRepository _repository,
            ITruckService _truckService,
            ICompanyService _companyService)
        {
            repository = _repository;
            truckService = _truckService;
            companyService = _companyService;
        }

        /// <summary>
        /// Creates a new trip asynchronously.
        /// </summary>
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
                TruckId = truckId,
                EuPerKm = form.TripPrice/form.TripKm,
                EmployeeId= form.EmployeeId,
            };

            await repository.AddAsync(trip);
            await repository.SaveChangesAsync();

            int result = trip.Id;

            return result;
        }

        /// <summary>
        /// Deletes a trip along with its associated orders.
        /// </summary>
        public async Task DeleteGivenTripWithOrders(int tripId)
        {
            Trip? trip = await repository.AllAsync<Trip>()
                .Include(o => o.Orders)
                .Where(t => t.Id == tripId)
                .FirstOrDefaultAsync();
            if(trip != null )
            {
                if (trip.Orders != null)
                {
                    repository.DeleteRange(trip.Orders);
                }
                repository.Delete(trip);

                await repository.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Retrieves all trips with associated orders.
        /// </summary>
        public async Task<IEnumerable<TripViewModel>> GetAllTripAsync()
        {
            var result = await repository.AllReadOnlyAsync<Trip>()
                 .Include(o => o.Orders)
                 .Select(t => new TripViewModel
                 {
                     Id = t.Id,
                     LoadingDate = t.StartDate,
                     TruckPlate = t.Truck.TruckPlate,
                     Price = t.TripPrice,
                     TotalKm = t.TripKm,
                     EuPerKm = t.EuPerKm.ToString("f2"),
                     Orders = t.Orders.Select(o => new OrderViewModel
                     {
                         LoadingDate = o.LoadingDate,
                         CompanyName = o.Company.CompanyName,
                         Price = o.Price,
                         LoadingCode = o.LoadingPostCode,
                         DeliveryCode = o.DeliveryPostCode
                     })
                     .OrderBy(t=> t.LoadingDate)
                    .ToList()
                 })
                 .OrderByDescending(t => t.LoadingDate)
                 .ToListAsync();

            return result;
        }

        /// <summary>
        /// Retrieves a trip with associated orders by its identifier.
        /// </summary>
        public async Task<TripViewModel> GetViewTripByIdAsync(int id)
        {
            TripViewModel? result = await repository.AllAsync<Trip>()
                .Include(t => t.Orders)
                .Where(t => t.Id == id)
                .Select(t => new TripViewModel
                {
                    LoadingDate = t.StartDate,
                    TruckPlate = t.Truck.TruckPlate,
                    Price = t.TripPrice,
                    TotalKm = t.TripKm,
                    EuPerKm = t.EuPerKm.ToString("f2"),
                    Orders = t.Orders.Select(o => new OrderViewModel
                    {
                        LoadingDate = o.LoadingDate,
                        CompanyName = o.Company.CompanyName,
                        Price = o.Price,
                        LoadingCode = o.LoadingPostCode,
                        DeliveryCode = o.DeliveryPostCode
                    })
                    .ToList()
                })
                .FirstOrDefaultAsync();

            return result;
        }

        /// <summary>
        /// Saves an order to a trip asynchronously.
        /// </summary>
        public async Task SaveOrderToTripAsync(OrderFormModel form)
        {
            Trip? trip = await repository.AllAsync<Trip>()
                .Where(t => t.Id == form.TripId)
                .FirstOrDefaultAsync();

            Company? company = await repository.AllAsync<Company>()
                .Where(c => c.IsActive == true
                && c.CompanyVat == form.CompanyVat)
                .FirstOrDefaultAsync();

            Order order = new Order()
            {
                TripId = trip.Id,
                CompanyId = company.Id,
                LoadingDate = form.LoadingDate,
                DeliveryDate = form.DeliveryDate,
                LoadingPostCode = form.LoadingPostCode,
                DeliveryPostCode = form.DeliveryPostCode,
                Price = form.Price,
            };

            trip.Orders.Add(order);
            await repository.AddAsync(order);

            await repository.SaveChangesAsync();
        }
    }
}
