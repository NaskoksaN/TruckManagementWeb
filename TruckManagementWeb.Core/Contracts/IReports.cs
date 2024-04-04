using TruckManagementWeb.Core.Models.Reports;

namespace TruckManagementWeb.Core.Contracts
{
    public interface IReports
    {
        Task<IEnumerable<TrucksMonthlyViewReport>> GetAllTruckMonthlyResult();
        
        Task<List<TruckMonthSimpleViewModel>> GetTrucksMonthlyResultAsync(DateTime firstDay, DateTime lastDay);
        Task<List<TruckMonthSimpleViewModel>> GetTrucksYearResultAsync();
        Task<IEnumerable<TruckMonthSimpleViewModel>> GetTruckYearReport(string truckPlate);
        Task<TruckMonthReportViewModel> TruckCurrentMonthAsync(string truckPlate);
        Task<TruckMonthReportViewModel> TruckLastMonthAsync(string truckPlate);
        Task<List<TruckMonthReportViewModel>> TruckLastQuarterAsync(string truckPlate);
        Task<List<ReportRevenueFromCompany>> YearlyCompanyRevenueAsync();
    }
}
