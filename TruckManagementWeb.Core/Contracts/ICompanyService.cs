using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckManagementWeb.Core.Models.Company;

namespace TruckManagementWeb.Core.Contracts
{
    public interface ICompanyService
    {
        Task<int> CreateAsync(CompanyFormModel form);
        Task EditAsync(int id, CompanyEditFormModel form);
        Task<CompanyViewModel?> FindCompanyByIdAsync(int id);
        Task<CompanyViewModel> FindCompanyByVatAsync(string companyVat);
        Task<IEnumerable<CompanyIndexViewModel>> GetAllCompanyReadOnlyOrderByNameAsync();
        Task<CompanyEditFormModel> GetCompanyForEditByIdAsync(int id);
        Task<bool> IsCompanyExistByVat(string companyVat);
        Task<CompanyViewModel> RemoveCompanyByIdAsync(int id);
    }
}
