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
        Task<CompanyViewModel?> FindCompanyByIdAsync(int id);
        Task<bool> IsCompanyExistByVat(string companyVat);
    }
}
