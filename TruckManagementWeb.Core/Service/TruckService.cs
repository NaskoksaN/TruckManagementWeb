using Microsoft.EntityFrameworkCore;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Truck;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;

using static TruckManagementWeb.Core.Constants.ValidationConstants;

namespace TruckManagementWeb.Core.Service
{
    public class TruckService : ITruckService
    {
        private readonly IRepository repository;
     
        public TruckService(IRepository _repository)
        {
            repository = _repository;
        }

        /// <summary>
        /// Creates a new truck asynchronously based on the provided form data.
        /// </summary>
        /// <param name="form">The form model containing truck details.</param>
        /// <returns>The ID of the newly created truck.</returns>
        /// <remarks>
        /// This method creates a new truck entity with the details provided in the form model.
        /// It then adds the truck to the repository and saves the changes asynchronously.
        /// Finally, it returns the ID of the newly created truck.
        /// </remarks>
        public async Task<int> CreateAsync(TruckFormModel form)
        {
            Truck truck = new Truck()
            {
                ProductionYear = form.ProductionYear,
                TruckBrand = form.TruckBrand.Trim(),
                TruckModel = form.TruckModel.Trim(),
                TruckPlate = form.TruckPlate.Trim(),
                TruckInitialKm = form.TruckMilleage
            };

            await repository.AddAsync(truck);
            await repository.SaveChangesAsync();

            return truck.Id;
        }

        /// <summary>
        /// Finds a truck by its plate asynchronously.
        /// </summary>
        /// <param name="plate">The plate number of the truck to search for.</param>
        /// <returns>
        /// A view model representing the found truck if it is active;
        /// otherwise, returns null.
        /// </returns>
        /// <remarks>
        /// This method retrieves a truck from the repository based on its plate number.
        /// If an active truck with the specified plate number is found, it creates and
        /// returns a view model representing the truck. If no active truck is found,
        /// it returns null.
        /// </remarks>
        public async Task<TruckViewModel?> FindTruckByPlateAsync(string plate)
        {
            bool active = true;
            List<TruckViewModel> models = await repository.AllAsync<Truck>()
                .Where(t => t.TruckPlate == plate && t.IsActive==active)
                .Select(t => new TruckViewModel()
                {
                    Id = t.Id,
                    ProductionYear = t.ProductionYear,
                    TruckBrand = t.TruckBrand,
                    TruckPlate = t.TruckPlate,
                    TruckModel = t.TruckModel,
                    IsActive = t.IsActive,
                    AddedDate = t.AddedDate.ToString(UsedDateFormat),
                    RemovedDate = t.RemovedDate != null ?
                                  t.RemovedDate.Value.ToString(UsedDateFormat)
                                  : null
                })
                .ToListAsync();

            return models.FirstOrDefault(model => model.IsActive) ?? models.FirstOrDefault();

        }

        /// <summary>
        /// Retrieves all trucks in a read-only manner asynchronously.
        /// </summary>
        /// <returns>
        /// A collection of view models representing all active trucks.
        /// </returns>
        /// <remarks>
        /// This method fetches all active trucks from the repository in a read-only manner.
        /// It then maps each truck entity to a view model representing the truck's essential details,
        /// including its plate number, brand, model, and production year.
        /// </remarks>
        public async Task<IEnumerable<TruckIndexViewModel>> GetAlltruckReadOnlyAsync()
        {
            bool active = true;
            IEnumerable<TruckIndexViewModel> result = await repository
                                        .AllReadOnlyAsync<Truck>()
                                        .AsNoTracking()
                                        .Where(t=>t.IsActive== active)
                                        .Select(t => new TruckIndexViewModel()
                                        {
                                            TruckPlate = t.TruckPlate,
                                            TruckBrand = t.TruckBrand,
                                            TruckModel = t.TruckModel,
                                            ProductionYear = t.ProductionYear
                                        })
                                        .ToListAsync();
            return result;
        }

        /// <summary>
        /// Retrieves a truck by its identifier asynchronously.
        /// </summary>
        /// <param name="id">The identifier of the truck to retrieve.</param>
        /// <returns>
        /// A view model representing the truck with the specified identifier if found; otherwise, null.
        /// </returns>
        /// <remarks>
        /// This method queries the repository for a truck with the specified identifier.
        /// If found, it maps the truck entity to a view model containing its details, such as production year,
        /// brand, model, plate number, and status (active or inactive).
        /// </remarks>
        public async Task<TruckViewModel?> FindTruckByIdAsyncc(int id)
        {
            TruckViewModel? model = await repository.AllAsync<Truck>()
                .Where(t => t.Id == id)
                .Select(t => new TruckViewModel()
                {
                    Id = t.Id,
                    ProductionYear = t.ProductionYear,
                    TruckBrand = t.TruckBrand,
                    TruckPlate = t.TruckPlate,
                    TruckModel = t.TruckModel,
                    IsActive = t.IsActive,
                    AddedDate = t.AddedDate.ToString(UsedDateFormat),
                    RemovedDate = t.RemovedDate != null ? 
                                  t.RemovedDate.Value.ToString(UsedDateFormat) 
                                  : null
                })
                .OrderByDescending(t=> t.IsActive)
                .FirstOrDefaultAsync();

            return model;
        }

        /// <summary>
        /// Checks if a truck with the specified plate number exists asynchronously.
        /// </summary>
        /// <param name="truckPlate">The plate number of the truck to check.</param>
        /// <returns>
        /// True if a truck with the specified plate number exists and is active; otherwise, false.
        /// </returns>
        /// <remarks>
        /// This method queries the repository for a truck with the specified plate number.
        /// If found and active, it returns true; otherwise, it returns false.
        /// </remarks>
        public async Task<bool> IsTruckByPlateExistAsync(string truckPlate)
        {
            return await repository.AllReadOnlyAsync<Truck>()
                .AnyAsync(t => t.TruckPlate == truckPlate && t.IsActive==true);
        }

        /// <summary>
        /// Removes a truck asynchronously.
        /// </summary>
        /// <param name="truckId">The ID of the truck to remove.</param>
        /// <returns>
        /// A view model representing the removed truck.
        /// </returns>
        /// <remarks>
        /// This method marks the truck with the specified ID as inactive and sets the removal date.
        /// It then saves the changes to the repository and retrieves the view model of the removed truck.
        /// </remarks>
        public async Task<TruckViewModel> RemoveTruckAsync(int truckId)
        {
            Truck truck = await repository.GetByIdAsync<Truck>(truckId);
               // .FirstOrDefaultAsync(t=> t.Id == truckId);
          
            truck.IsActive = false;
            truck.RemovedDate = DateTime.UtcNow.Date;
            
            await repository.SaveChangesAsync();
           
            TruckViewModel model = await FindTruckByIdAsyncc(truck.Id);

            return model;
        }

        /// <summary>
        /// Retrieves a truck for editing asynchronously.
        /// </summary>
        /// <param name="id">The ID of the truck to retrieve.</param>
        /// <returns>
        /// A truck edit form model representing the truck with the specified ID,
        /// or null if no truck with the specified ID is found.
        /// </returns>
        /// <remarks>
        /// This method queries the repository for a truck with the specified ID.
        /// If found, it maps the truck properties to a truck edit form model and returns it.
        /// If no truck with the specified ID is found, it returns null.
        /// </remarks>
        public async Task<TruckEditFormModel?> GetTruckForEditByIdAsync(int id)
        {
            TruckEditFormModel? form = await repository.AllAsync<Truck>()
                .Where(t => t.Id == id)
                .Select(t => new TruckEditFormModel
                {
                    ProductionYear = t.ProductionYear,
                    TruckPlate = t.TruckPlate,
                    TruckBrand = t.TruckBrand,
                    TruckMilleage = t.TruckInitialKm,
                    TruckModel = t.TruckModel,
                    Id =t.Id
                })
                .FirstOrDefaultAsync();
                    

            return form;
        }

        /// <summary>
        /// Edits a truck asynchronously.
        /// </summary>
        /// <param name="id">The ID of the truck to edit.</param>
        /// <param name="form">The truck edit form model containing the updated information.</param>
        /// <remarks>
        /// This method retrieves the truck with the specified ID from the repository.
        /// It then updates the truck properties with the information provided in the truck edit form model.
        /// Finally, it saves the changes to the repository.
        /// </remarks>
        public async Task EditAsync(int id, TruckEditFormModel form)
        {
            Truck truck = await repository.GetByIdAsync<Truck>(id);

            truck.TruckPlate = form.TruckPlate.Trim();
            truck.TruckBrand = form.TruckBrand.Trim();
            truck.TruckModel = form.TruckModel.Trim();
            truck.TruckInitialKm = form.TruckMilleage;
            truck.ProductionYear = form.ProductionYear;

            await repository.SaveChangesAsync();
        }

        /// <summary>
        /// Retrieves the ID of a truck by its plate asynchronously.
        /// </summary>
        /// <param name="plate">The plate of the truck to retrieve the ID for.</param>
        /// <returns>The ID of the truck with the specified plate, or 0 if no such truck exists.</returns>
        /// <remarks>
        /// This method queries the repository for a truck with the specified plate.
        /// If a matching truck is found and it is active, its ID is returned.
        /// If no matching truck is found or if the matching truck is not active, returns 0.
        /// </remarks>
        public async Task<int> GetTruckIdByPlate(string plate)
        {
            bool active = true;
            var truck = await repository.AllAsync<Truck>()
            .Where(t => t.TruckPlate == plate && t.IsActive == active)
            .FirstOrDefaultAsync();

            //return truck?.Id ?? 0;
            return truck.Id;
        }

    }
}
