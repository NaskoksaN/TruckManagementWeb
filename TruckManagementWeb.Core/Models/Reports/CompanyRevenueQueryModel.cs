namespace TruckManagementWeb.Core.Models.Reports
{
    public class CompanyRevenueQueryModel
    {
        public int TotalCompanyCount {  get; set; }

        public IEnumerable<ReportRevenueFromCompany> RevenueReports 
                        = new List<ReportRevenueFromCompany>();
    }
}
