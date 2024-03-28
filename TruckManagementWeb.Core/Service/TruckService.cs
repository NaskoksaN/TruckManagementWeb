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

        public async Task<TruckViewModel?> FindTruckByPlateAsync(string plate)
        {
            List<TruckViewModel> models = await repository.AllAsync<Truck>()
                .Where(t => t.TruckPlate == plate)
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
                .AnyAsync(t => t.TruckPlate == truckPlate && t.IsActive==true);
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

        public async Task<int> GetTruckIdByPlate(string plate)
        {
            var truck = await repository.AllAsync<Truck>()
            .Where(t => t.TruckPlate == plate && t.IsActive == true)
            .FirstOrDefaultAsync();

            return truck?.Id ?? 0;
        }

    }
}
