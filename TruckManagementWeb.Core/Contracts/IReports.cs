using TruckManagementWeb.Core.Models.Reports;

namespace TruckManagementWeb.Core.Contracts
{
    public interface IReports
    {
        Task<IEnumerable<TrucksMonthlyViewReport>> GetAllTruckMonthlyResult();
        Task<TruckMonthReportViewModel> GetTruckPeriodResultAsync(string truckPlate
                                , DateTime lastMonthStart
                                , DateTime lastMonthEnd);
        Task<List<TruckMonthSimpleViewModel>> GetTrucksMonthlyResultAsync(DateTime firstDay, DateTime lastDay);
        Task<List<TruckMonthSimpleViewModel>> GetTrucksYearResultAsync();
        Task<IEnumerable<TruckMonthSimpleViewModel>> GetTruckYearReport(string truckPlate);
        Task<List<ReportRevenueFromCompany>> YearlyCompanyRevenueAsync();
    }
}
