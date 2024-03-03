using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManagementWeb.Core.Models.Company
{
    public class CompanyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Vat { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

        public bool Active { get; set; }
        public string AddedOnDate {  get; set; } =string.Empty;

        public string? RemovedOnDate {  get; set; }
    }
}
