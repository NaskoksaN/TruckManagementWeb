using TruckManagementWeb.Core.Enumeration;
using TruckManagementWeb.Core.Models.Reports;

namespace TruckManagementWeb.Core.Contracts
{
    public interface IReports
    {
        Task<CompanyRevenueQueryModel> FilteredCompanyRevenue(string? country, string? searchTerm, CompanyRevenueSorting sorting = CompanyRevenueSorting.None, int currentPgae = 1, int companyPerPage = 6);
        Task<(string title, List<TruckMonthSimpleViewModel> monthlyResult)> GetMonthlyTrucksResultAsync();
        Task<(string title, List<TruckMonthSimpleViewModel> monthlyResult)> GetTrucksYearResultAsync();
        Task<IEnumerable<TruckMonthSimpleViewModel>> GetTruckYearReport(string truckPlate);
        Task<OveralTrucksInfoViewModel> OveralInfo();
        Task<TruckMonthReportViewModel> TruckCurrentMonthAsync(string truckPlate);
        Task<TruckMonthReportViewModel> TruckLastMonthAsync(string truckPlate);
        Task<List<TruckMonthReportViewModel>> TruckLastQuarterAsync(string truckPlate);
        Task<(string title, List<ReportRevenueFromCompany>)> YearlyCompanyRevenueAsync();
    }
}
