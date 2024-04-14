using Microsoft.EntityFrameworkCore;
using System;
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


        /// <summary>
        /// Asynchronously updates the details of a company identified by its ID using the provided form data.
        /// The method retrieves the company from the repository based on the given ID, updates its properties
        /// with the values from the provided form, and saves the changes asynchronously.
        /// </summary>
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

        /// <summary>
        /// Asynchronously finds a company by its ID and returns a view model representation of the company.
        /// The method queries the repository for a company with the specified ID, maps its properties to a
        /// CompanyViewModel object, and returns the result. If no company is found with the given ID, null is returned.
        /// </summary>
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


        /// <summary>
        /// Asynchronously finds a company by its VAT number and returns a view model representation of the company.
        /// The method queries the repository for companies with the specified VAT number (case-insensitive comparison),
        /// maps their properties to CompanyViewModel objects, and returns the first active company found.
        /// If no active company is found with the given VAT number, the method returns the first company found.
        /// </summary>
        public async Task<CompanyViewModel?> FindCompanyByVatAsync(string companyVat)
        {

            List<CompanyViewModel> companies =  await repository.AllAsync<Company>()
                .Where(c => c.CompanyVat.ToUpper() == companyVat.ToUpper())
                .Select(c => new CompanyViewModel()
                {
                    Id = c.Id,
                    Active = c.IsActive,
                    Name = c.CompanyName,
                    Vat = c.CompanyVat,
                    Country = c.CompanyCountry,
                })
                .ToListAsync();

            return companies.FirstOrDefault(model => model.Active) ?? companies.FirstOrDefault();
        }


        /// <summary>
        /// Asynchronously retrieves all active companies from the repository,
        /// orders them by name, and returns their view model representations.
        /// </summary>
        public async Task<IEnumerable<CompanyIndexViewModel>> GetAllCompanyReadOnlyOrderByNameAsync()
        {
            bool active = true;
            var result =  await repository.AllReadOnlyAsync<Company>()
            .Where(c => c.IsActive == active)
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

        /// <summary>
        /// Asynchronously retrieves all active companies from the repository,
        /// extracts their unique country names, and returns them as a HashSet of CompanyCountryViewModel objects.
        /// </summary>
        public async Task<HashSet<CompanyCountryViewModel>> GetAllUniqueCountryAsync()
        {
            bool active = true;
            List<string> allCountry = await repository
                            .AllReadOnlyAsync<Company>()
                            .Where(c=>c.IsActive==active)
                            .Select(c => c.CompanyCountry.ToUpper())
                            .Distinct()
                            .ToListAsync();

            HashSet<CompanyCountryViewModel> result = allCountry
                            .Select(country => new CompanyCountryViewModel { Country = country })
                            .ToHashSet();

            return result;
        }

        public async Task<List<string>> UniqueCountryAsync() => await repository
                            .AllReadOnlyAsync<Company>()
                            .Where(c => c.IsActive == true)
                            .Select(c => c.CompanyCountry.ToUpper())
                            .Distinct()
                            .ToListAsync();

        /// <summary>
        /// Asynchronously retrieves a company for editing by its ID from the repository.
        /// </summary>
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

        /// <summary>
        /// Asynchronously retrieves companies from a specific country from the repository.
        /// </summary>
        public async Task<IEnumerable<CompanyIndexViewModel>> GetCompanyFromCountryAsync(string selectedCountry)
        {
            var normalizedSelectedCountry = selectedCountry.ToUpperInvariant();
            bool active = true;

            var result = await repository
            .AllReadOnlyAsync<Company>()
            .Where(c => c.CompanyCountry.ToUpper().Trim() == normalizedSelectedCountry.Trim() 
                        && c.IsActive==active)
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

        /// <summary>
        /// Asynchronously checks if a company with the specified VAT exists in the repository.
        /// </summary>
        public async Task<bool> IsCompanyExistByVat(string companyVat)
        => await repository.AllReadOnlyAsync<Company>()
            .AnyAsync(c=> c.CompanyVat.ToUpper() == companyVat.ToUpper() && c.IsActive==true);

        /// <summary>
        /// Asynchronously removes a company with the specified ID from the repository.
        /// </summary>
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
