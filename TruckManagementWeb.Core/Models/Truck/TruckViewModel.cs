namespace TruckManagementWeb.Core.Models.Truck
{
    public class TruckViewModel
    {
        public int Id { get; set; }
        public string TruckPlate { get; set; } = string.Empty;
        public string TruckBrand { get; set; } = string.Empty;
        public string TruckModel { get; set; } = string.Empty;
        public int ProductionYear { get; set; }

        public bool IsActive { get; set; }
    }
}
