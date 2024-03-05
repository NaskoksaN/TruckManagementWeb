using System.ComponentModel.DataAnnotations;

using static TruckManagementWeb.Core.Constants.MessageConstants;
using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Core.Models.Trip
{
    public class OrderFormModel
    {

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Order price")]
        [Range(typeof(Decimal),
            OrderMinPrice,
            orderMaxPrice,
            ErrorMessage = TripPriceMessage)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        public DateTime LoadingDate { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        public DateTime DeliveryDate { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PostCodeMaxLength,
            MinimumLength = PostCodeMinLength,
            ErrorMessage = LengthMessage)]
        public string LoadingPostCode { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PostCodeMaxLength,
            MinimumLength = PostCodeMinLength,
            ErrorMessage = LengthMessage)]
        public string DeliveryPostCode { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int TripId { get; set; }
    }
}
