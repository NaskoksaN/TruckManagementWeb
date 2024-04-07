using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManagementWeb.Core.Models.Reports
{
    public  class ReportRevenueFromCompany
    {
        public int Id { get; set; }

        [DisplayName("Name of the company")]
        public string CompanyName {  get; set; }=string.Empty;
        public string Vat {  get; set; }=string.Empty;

        [DisplayName("Country of the company")]
        public string CompanyCountry { get; set; } = string.Empty;

        [DisplayName("Company revenue")]
        public decimal RevenueFromCompany { get; set;}

        [DisplayName("Company total orders count")]
        public int TotalOrderCount {  get; set; }

    }
}
