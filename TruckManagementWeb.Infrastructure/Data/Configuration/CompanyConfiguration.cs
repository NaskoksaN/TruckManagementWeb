using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.Infrastructure.Data.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder
                .HasData(
                new Company { Id = 1, CompanyName = "MALHERBE DISTRIBUTION", CompanyVat = "FR72518435920", CompanyCountry = "France", CompanyTown = "44813 ST-HERBLAIN CEDEX", CompanyAddress = "17 RUE BOBBY SANDS", IsActive = true, AddedDate = DateTime.UtcNow.Date },
                new Company { Id = 2, CompanyName = "WOEHL & CIE - TPT INTERNATIONAUX", CompanyVat = "FR37558501144", CompanyCountry = "France", CompanyTown = "67160 WISSEMBOURG", CompanyAddress = "ROUTE DE SCHWEIGEN BP 10025", IsActive = true, AddedDate = DateTime.UtcNow.Date },
                new Company { Id = 3, CompanyName = "XPO TRS LU", CompanyVat = "LU17458960", CompanyCountry = "Luxembourg", CompanyTown = "3225 BETTEMBOURG", CompanyAddress = "144 ZAE WOLSER", IsActive = true, AddedDate = DateTime.UtcNow.Date },
                new Company { Id = 4, CompanyName = "GEFCO FRANCE", CompanyVat = "FR24789791464", CompanyCountry = "France", CompanyTown = "66000 PERPIGNAN", CompanyAddress = "2609 AVENUE DE PRADES", IsActive = true, AddedDate = DateTime.UtcNow.Date },
                new Company { Id = 5, CompanyName = "Yusen Logistics (France) SAS", CompanyVat = "FR89432599785", CompanyCountry = "France", CompanyTown = "57280 Maizières-lès-Metz", CompanyAddress = "69 Route de Thionville", IsActive = true, AddedDate = DateTime.UtcNow.Date },
                new Company { Id = 6, CompanyName = "SCHENKER DEUTSCHLAND AG", CompanyVat = "DE811228366", CompanyCountry = "Germany", CompanyTown = "34253 LOHFELDEN/KASSEL", CompanyAddress = "JUSTUS LIEBIG STRASSE 14", IsActive = true, AddedDate = DateTime.UtcNow.Date },
                new Company { Id = 7, CompanyName = "Winner Spedition GmbH & Co. KG", CompanyVat = "DE125572634", CompanyCountry = "Germany", CompanyTown = "58642 Iserlohn", CompanyAddress = "Brinkhofstraße 41", IsActive = true, AddedDate = DateTime.UtcNow.Date },
                new Company { Id = 8, CompanyName = "sennder Technologies GmbH", CompanyVat = "DE302502945", CompanyCountry = "Germany", CompanyTown = "10785 Berlin", CompanyAddress = "Genthiner Strasse 34", IsActive = true, AddedDate = DateTime.UtcNow.Date },
                new Company { Id = 9, CompanyName = "Stahl Log", CompanyVat = "DE813065962", CompanyCountry = "Germany", CompanyTown = "D-66793 Saarwellingen", CompanyAddress = "Otto-Hahn-Str. 3", IsActive = true, AddedDate = DateTime.UtcNow.Date },
                new Company { Id = 10, CompanyName = "GREILSAMMER ABCE", CompanyVat = "FR06514447937", CompanyCountry = "France", CompanyTown = "F - 68600 WOLFGANTZEN", CompanyAddress = "RUE DES VERGERS", IsActive = true, AddedDate = DateTime.UtcNow.Date }
            );
        }
    }
}
