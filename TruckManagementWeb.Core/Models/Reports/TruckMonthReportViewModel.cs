using TruckManagementWeb.Core.Models.Trip;

namespace TruckManagementWeb.Core.Models.Reports
{
    public  class TruckMonthReportViewModel
    {
        public int Id {  get; set; }
        public string PlateNumber { get; set; } = string.Empty;
        public decimal TotalKilometers { get; set; }
        public decimal TotalEuros { get; set; }
        public decimal TotalExpenses { get; set; }
        public IEnumerable<TripViewModel> Trips { get; set; } = new List<TripViewModel>();
    }
}

