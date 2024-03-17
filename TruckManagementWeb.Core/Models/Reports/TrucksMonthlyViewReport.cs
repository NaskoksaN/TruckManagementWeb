namespace TruckManagementWeb.Core.Models.Reports
{
    public class TrucksMonthlyViewReport
    {
        public int TruckId { get; set; }
        public string PlateNumber { get; set; } = string.Empty;
        public decimal TotalKilometers { get; set; }
        public decimal TotalEuros { get; set; }
        public decimal TotalExpenses { get; set; }
    }
}
