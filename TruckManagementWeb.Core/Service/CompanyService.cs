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
                CompanyVat = form.CompanyVat.Trim(),
                CompanyAddress = form.Address.Trim(),
                CompanyCountry = form.Country.Trim(),
                CompanyName = form.Name.Trim(),
                CompanyTown = form.Town.Trim()
            };

            await repository.AddAsync(company);
            await repository.SaveChangesAsync();

            return company.Id;
        }

        public async Task EditAsync(int id, CompanyEditFormModel form)
        {
            Company company = await repository.GetByIdAsync<Company>(id);

            company.CompanyVat = form.CompanyVat.ToUpper().Trim();
            company.CompanyAddress = form.Address.Trim();
            company.CompanyName = form.Name.Trim();
            company.CompanyTown = form.Town.Trim();
            company.CompanyCountry = form.Country.Trim();

            await repository.SaveChangesAsync();
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

        public async Task<CompanyViewModel?> FindCompanyByVatAsync(string companyVat)
        {
            return await repository.AllAsync<Company>()
                .Where(c => c.CompanyVat.ToUpper() == companyVat.ToUpper())
                .Select(c => new CompanyViewModel()
                {
                    Id = c.Id,
                    Active = c.IsActive,
                    Name = c.CompanyName,
                    Vat = c.CompanyVat,
                    Country = c.CompanyCountry,
                })
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CompanyIndexViewModel>> GetAllCompanyReadOnlyOrderByNameAsync()
        => await repository.AllReadOnlyAsync<Company>()
            .Select(c => new CompanyIndexViewModel()
            {
                Id = c.Id,
                Name = c.CompanyName,
                Country = c.CompanyCountry,
                Vat = c.CompanyVat,
            })
            .OrderBy(c => c.Name)
            .ToListAsync();

        public async Task<HashSet<CompanyCountryViewModel>> GetAllUniqueCountryAsync()
        {
            List<string> allCountry = await repository
                            .AllReadOnlyAsync<Company>()
                            .Select(c => c.CompanyCountry.ToUpper())
                            .Distinct()
                            .ToListAsync();

            HashSet<CompanyCountryViewModel> result = allCountry
                            .Select(country => new CompanyCountryViewModel { Country = country })
                            .ToHashSet();

            return result;
        }

        public async Task<CompanyEditFormModel?> GetCompanyForEditByIdAsync(int id)
        {
            CompanyEditFormModel? form = await repository.AllAsync<Company>()
                .Where(c => c.Id == id)
                .Select(c => new CompanyEditFormModel()
                {
                    Id=c.Id,
                    Name = c.CompanyName,
                    CompanyVat = c.CompanyVat.ToUpper(),
                    Country = c.CompanyCountry,
                    Town = c.CompanyTown,
                    Address = c.CompanyAddress
                })
                .FirstOrDefaultAsync();

            return form;
        }

        public async Task<IEnumerable<CompanyIndexViewModel>> GetCompanyFromCountryAsync(string selectedCountry)
        {
            var normalizedSelectedCountry = selectedCountry.ToUpperInvariant();
            var result = await repository
            .AllReadOnlyAsync<Company>()
            .Where(c => c.CompanyCountry.ToUpper().Trim() == normalizedSelectedCountry.Trim())
            .Select(c => new CompanyIndexViewModel()
            {
                Id = c.Id,
                Name = c.CompanyName,
                Country = c.CompanyCountry,
                Vat = c.CompanyVat,
            })
            .OrderBy(c => c.Name)
            .ToListAsync();

            return result;
        }

        public async Task<bool> IsCompanyExistByVat(string companyVat)
        => await repository.AllReadOnlyAsync<Company>()
            .AnyAsync(c=> c.CompanyVat.ToUpper() == companyVat.ToUpper() && c.IsActive==true);

        public async Task<CompanyViewModel?> RemoveCompanyByIdAsync(int id)
        {
            Company company = await repository.GetByIdAsync<Company>(id);
            company.IsActive = false;
            company.RemovedDate=DateTime.UtcNow.Date;

            await repository.SaveChangesAsync();

            return await FindCompanyByIdAsync(id);
        }
    }
}
