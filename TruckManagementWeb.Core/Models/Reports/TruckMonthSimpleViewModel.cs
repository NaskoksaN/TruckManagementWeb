using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManagementWeb.Core.Models.Reports
{
    public  class TruckMonthSimpleViewModel
    {
        public string PlateNumber { get; set; } = string.Empty;
        public decimal TotalKilometers { get; set; }
        public decimal TotalEuros { get; set; }
        public decimal TotalExpenses { get; set; }

        public string EuroPerKm { get; set; } = string.Empty;
        public DateTime Month {  get; set; }
      
    }
}
