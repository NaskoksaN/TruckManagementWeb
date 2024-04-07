using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckManagementWeb.Core.Models.Company;
using TruckManagementWeb.Core.Models.Reports;

namespace TruckManagementWeb.Core.Contracts
{
    public interface ICompanyService
    {
        /// <summary>
        /// Create company 
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        Task<int> CreateAsync(CompanyFormModel form);
        Task EditAsync(int id, CompanyEditFormModel form);
        Task<CompanyViewModel?> FindCompanyByIdAsync(int id);
        Task<CompanyViewModel> FindCompanyByVatAsync(string companyVat);
        Task<IEnumerable<CompanyIndexViewModel>> GetAllCompanyReadOnlyOrderByNameAsync();
        Task<HashSet<CompanyCountryViewModel>> GetAllUniqueCountryAsync();
        Task<CompanyEditFormModel> GetCompanyForEditByIdAsync(int id);
        Task<IEnumerable<CompanyIndexViewModel>> GetCompanyFromCountryAsync(string selectedCountry);
        Task<bool> IsCompanyExistByVat(string companyVat);
        Task<CompanyViewModel> RemoveCompanyByIdAsync(int id);
        Task<List<string>> UniqueCountryAsync();
    }
}
