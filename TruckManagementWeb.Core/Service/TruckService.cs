using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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

        public async Task<int> CreateAsync(TruckFormModel form)
        {
            Truck truck = new Truck()
            {
                ProductionYear = form.ProductionYear,
                TruckBrand = form.TruckBrand,
                TruckModel = form.TruckModel,
                TruckPlate = form.TruckPlate,
                TruckInitialKm = form.TruckMilleage
            };

            await repository.AddAsync(truck);
            await repository.SaveChangesAsync();

            return truck.Id;
        }

        public async Task<TruckViewModel?> FindTruckByPlateAsync(string plate)
        {
            TruckViewModel? model = await repository.AllAsync<Truck>()
                .Where(t=>t.TruckPlate==plate)
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
                .FirstOrDefaultAsync();

            return model;

        }

        public async Task<IEnumerable<TruckIndexViewModel>> GetAlltruckReadOnlyAsync()
        {
            IEnumerable<TruckIndexViewModel> result = await repository
                                        .AllReadOnlyAsync<Truck>()
                                        .AsNoTracking()
                                        .Where(t=>t.IsActive==true)
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
                .FirstOrDefaultAsync();

            return model;
        }

        public async Task<bool> IsTruckExistAsync(string truckPlate)
        {
            return await repository.AllReadOnlyAsync<Truck>()
                .AnyAsync(t => t.TruckPlate == truckPlate);
              
        }

        public async Task<TruckViewModel> RemoveTruckAsync(int truckId)
        {
            Truck truck = await repository.AllAsync<Truck>()
                .FirstOrDefaultAsync(t=> t.Id == truckId);
          
            truck.IsActive = false;
            truck.RemovedDate = DateTime.UtcNow.Date;
            
            await repository.SaveChangesAsync();
           
            TruckViewModel model = await FindTruckByIdAsyncc(truck.Id);

            return model;
        }

        async Task<TruckEditFormModel?> ITruckService.GetTruckForEditById(int id)
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

        public async Task EditAsync(int id, TruckEditFormModel form)
        {
            Truck truck = await repository.GetByIdAsync<Truck>(id);

            truck.TruckPlate = form.TruckPlate;
            truck.TruckBrand = form.TruckBrand;
            truck.TruckModel = form.TruckModel;
            truck.TruckInitialKm = form.TruckMilleage;
            truck.ProductionYear = form.ProductionYear;

            await repository.SaveChangesAsync();
        }
    }
}
