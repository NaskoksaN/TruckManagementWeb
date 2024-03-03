namespace TruckManagementWeb.Core.Models.Truck
{
    public class TruckViewModel : TruckIndexViewModel
    {
        public string AddedDate {  get; set; } =string.Empty;
        public string? RemovedDate {  get; set; }
        public bool IsActive { get; set; }
    }
}
