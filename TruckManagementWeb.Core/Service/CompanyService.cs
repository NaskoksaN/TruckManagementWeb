using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Infrastructure.Data.Common;

namespace TruckManagementWeb.Core.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly IRepository repository;
        public CompanyService(IRepository _repository)
        {
            repository = _repository;
        }
    }
}
