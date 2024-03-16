using TruckManagementWeb.Core.Models.Reports;

namespace TruckManagementWeb.Core.Contracts
{
    public interface IReports
    {
        Task<TruckMonthReportsViewModel> GetTruckAndLastMonthResultAsync(string truckPlate);
    }
}
