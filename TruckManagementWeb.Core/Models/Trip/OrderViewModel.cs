namespace TruckManagementWeb.Core.Models.Trip
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public DateTime LoadingDate { get; set; } 
        public string CompanyName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string LoadingCode {  get; set; } = string.Empty;
        public string DeliveryCode {  get; set; } = string.Empty;
    }
}
