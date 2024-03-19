using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManagementWeb.Core.Models.Reports
{
    public  class ReportRevenueFromCompany
    {
        public string CompanyName {  get; set; }=string.Empty;
        public string Vat {  get; set; }=string.Empty;
        public string CompanyCountry { get; set; } = string.Empty;
        public decimal RevenueFromCompany { get; set;}
        public int TotalOrderCount {  get; set; }
    }
}
