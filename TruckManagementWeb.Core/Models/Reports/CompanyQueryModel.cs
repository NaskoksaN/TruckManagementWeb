using System.ComponentModel;
using TruckManagementWeb.Core.Enumeration;
using TruckManagementWeb.Core.Models.Company;

namespace TruckManagementWeb.Core.Models.Reports
{
    public class CompanyQueryModel
    {
        public int PerPage { get; set; } = 6;
        public string Country { get; set; } = null!;

        [DisplayName("Search in company name by text")]
        public string SearchTerm { get; set; } = null!;

        public CompanyRevenueSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public IEnumerable<string> Countries {  get; set; } =null!;

        public int TotalCompanyCount { get; set; }

        public IEnumerable<ReportRevenueFromCompany> RevenueReports 
                                    = new List<ReportRevenueFromCompany>();
    }
}
