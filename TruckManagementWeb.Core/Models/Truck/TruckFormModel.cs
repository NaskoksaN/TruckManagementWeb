using System.ComponentModel.DataAnnotations;

using static TruckManagementWeb.Core.Constants.MessageConstants;
using static TruckManagementWeb.Core.Constants.ValidationConstants;
using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Core.Models.Truck
{
    public class TruckFormModel
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
        [Display(Name = "Truck brand")]
        [StringLength(TruckBrandMaxLength,
            MinimumLength = TruckBrandMinLength,
            ErrorMessage = LengthMessage)]
        public string TruckBrand { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Truck model")]
        [StringLength(TruckModelMaxLength,
            MinimumLength = TruckModelMinLength,
            ErrorMessage = LengthMessage)]
        public string TruckModel { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Year of production")]
        [Range(TruckProductionYearMinYear, 
            TruckProductionYearMaxYear,
            ErrorMessage = ProductionRangeMessage)]
        public int ProductionYear { get; set; } = DateTime.UtcNow.Year;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Truck mileage in km.")]
        [Range(TruckInitialMinMileage,
            TruckInitialMaxMileage
            , ErrorMessage = MileageMessage)]
        public int TruckMilleage { get; set; } = 1;

        public static implicit operator TruckFormModel?(TruckViewModel? v)
        {
            throw new NotImplementedException();
        }
    }
}
