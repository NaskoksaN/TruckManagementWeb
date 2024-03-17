using TruckManagementWeb.Core.Models.Reports;

namespace TruckManagementWeb.Core.Contracts
{
    public interface IReports
    {
        Task<IEnumerable<TrucksMonthlyViewReport>> GetAllTruckMonthlyResult();
        Task<TruckMonthReportViewModel> GetTruckPeriodResultAsync(string truckPlate
                                , DateTime lastMonthStart
                                , DateTime lastMonthEnd);
    }
}
