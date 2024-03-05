using System.ComponentModel.DataAnnotations;

using static TruckManagementWeb.Core.Constants.MessageConstants;
using static TruckManagementWeb.Core.Constants.ValidationConstants;
using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Core.Models.Trip
{
    public class TripFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Truck plate")]
        [StringLength(TruckPlateMaxLength,
            MinimumLength = TruckBrandMinLength,
            ErrorMessage = LengthMessage)]
        [RegularExpression(PlateRegexValidation,
            ErrorMessage = PlateMessage)]
        public string TruckPlate { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Trip total km")]
        [Range(TripMinKm, TripMaxKm, ErrorMessage = MileageMessage)]
        public int TripKm { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Trip total price")]
        [Range(typeof(Decimal), 
            TripMinPrice, 
            TripMaxPrice,
            ErrorMessage = TripPriceMessage)]
        public decimal TripPrice { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Trip start date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Trip end date")]
        public DateTime EndDate { get; set; }

        ICollection<OrderFormModel> Orders { get; set; } = new List<OrderFormModel>();
    }
}
