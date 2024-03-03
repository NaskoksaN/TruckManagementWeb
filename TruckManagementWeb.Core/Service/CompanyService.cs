using Microsoft.EntityFrameworkCore;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Company;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Models;

using static TruckManagementWeb.Core.Constants.ValidationConstants;

namespace TruckManagementWeb.Core.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly IRepository repository;
        public CompanyService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<int> CreateAsync(CompanyFormModel form)
        {
            Company company = new()
            {
                CompanyVat = form.CompanyVat.ToUpper(),
                CompanyAddress = form.Address,
                CompanyCountry = form.Country,
                CompanyName = form.Name,
                CompanyTown = form.Town,
            };

            await repository.AddAsync(company);
            await repository.SaveChangesAsync();

            return company.Id;
        }

        public async Task<CompanyViewModel?> FindCompanyByIdAsync(int id)
        {
            CompanyViewModel? model = await repository.AllAsync<Company>()
                .Where(c => c.Id == id)
                .Select(c => new CompanyViewModel()
                {
                    Id = c.Id,
                    Active = c.IsActive,
                    Name = c.CompanyName,
                    Vat = c.CompanyVat,
                    Country = c.CompanyCountry,
                    AddedOnDate = c.AddedDate.ToString(UsedDateFormat),
                    RemovedOnDate = c.RemovedDate != null ?
                                    c.RemovedDate.Value.ToString(UsedDateFormat) : null
                })
                .FirstOrDefaultAsync();

            return model;
        }

        public async Task<bool> IsCompanyExistByVat(string companyVat)
        => await repository.AllReadOnlyAsync<Company>()
            .AnyAsync(c=> c.CompanyVat == companyVat.ToUpper());
    }
}
