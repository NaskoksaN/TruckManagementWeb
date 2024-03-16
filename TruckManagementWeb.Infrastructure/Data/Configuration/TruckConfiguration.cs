using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.Infrastructure.Data.Configuration
{
    public  class TruckConfiguration : IEntityTypeConfiguration<Truck>
    {
        public void Configure(EntityTypeBuilder<Truck> builder)
        {
            builder
                .HasData(
                new Truck { Id = 1, TruckPlate = "B8511TC", TruckBrand = "Renault", TruckModel = "Renault Trucks T High", ProductionYear = 2019, IsActive = true, AddedDate = DateTime.UtcNow.Date, TruckInitialKm = 195000 },
                new Truck { Id = 2, TruckPlate = "B8514TC", TruckBrand = "Renault", TruckModel = "Renault Trucks T High", ProductionYear = 2019, IsActive = true, AddedDate = DateTime.UtcNow.Date, TruckInitialKm = 198000 },
                new Truck { Id = 3, TruckPlate = "B8517TC", TruckBrand = "Renault", TruckModel = "Renault Trucks T High", ProductionYear = 2019, IsActive = true, AddedDate = DateTime.UtcNow.Date, TruckInitialKm = 201500 },
                new Truck { Id = 4, TruckPlate = "B9133TC", TruckBrand = "Renault", TruckModel = "Renault Trucks T High", ProductionYear = 2019, IsActive = true, AddedDate = DateTime.UtcNow.Date, TruckInitialKm = 205000 },
                new Truck { Id = 5, TruckPlate = "B9134TC", TruckBrand = "Renault", TruckModel = "Renault Trucks T High", ProductionYear = 2019, IsActive = true, AddedDate = DateTime.UtcNow.Date, TruckInitialKm = 210000 },
                new Truck { Id = 6, TruckPlate = "B9135TC", TruckBrand = "Renault", TruckModel = "Renault Trucks T High", ProductionYear = 2019, IsActive = true, AddedDate = DateTime.UtcNow.Date, TruckInitialKm = 230500 }
            );
        }
    }
}
