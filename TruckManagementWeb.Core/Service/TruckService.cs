using Microsoft.EntityFrameworkCore;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Truck;
using TruckManagementWeb.Data;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;

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
            };

            await repository.AddAsync(truck);
            await repository.SaveChangesAsync();

            return truck.Id;
        }

        public async Task<TruckViewModel?> GetTruckByIdAsync(int id)
        {
            TruckViewModel? model =  await repository.AllAsync<Truck>()
                .Where(t => t.Id == id)
                .Select(t=> new TruckViewModel()
                {
                    Id= t.Id,
                    ProductionYear=t.ProductionYear,
                    TruckBrand=t.TruckBrand,
                    TruckPlate = t.TruckPlate,
                    TruckModel = t.TruckModel,
                    IsActive=t.IsActive,
                })
                .FirstOrDefaultAsync();

            return model;
        }

        public async Task<bool> IsTruckExistAsync(string truckPlate)
        {
            return await repository.AllReadOnlyAsync<Truck>()
                .AnyAsync(t => t.TruckPlate == truckPlate);
              
        }
    }
}
