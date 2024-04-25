using System.ComponentModel.DataAnnotations;

namespace TruckManagementWeb.Core.Models.SoldOrder
{
    public  class SoldViewFomrModel
    { 
        public int OrderId {  get; set; }
        public string LoadingCompany { get; set; } = string.Empty;

        public string LoadingStreet { get; set; } = string.Empty;

        public string LoadingTown { get; set; } = string.Empty;

        public string DeliveryCompany { get; set; } = string.Empty;

        public string DeliveryStreet { get; set; } = string.Empty;

        public string DeliveryTown { get; set; } = string.Empty;

        public string LoadingReference { get; set; } = string.Empty;

        public string DeliveryReference { get; set; } = string.Empty;

        public double LoadingMeter { get; set; }

        public double Weight { get; set; }

        public decimal Price { get; set; }

        public string ClientEmail { get; set; } = string.Empty;


        [Required]
        public Guid OrderGuid { get; set; }

        [Display(Name = "Loading Date")]
        public DateTime? LoadingDateTime { get; set; }

        [Display(Name = "Delivery Date")]
        public DateTime? DeliveryDateTime { get; set; }

    }
}
