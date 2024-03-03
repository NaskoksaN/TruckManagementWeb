using System.ComponentModel.DataAnnotations;

using static TruckManagementWeb.Core.Constants.MessageConstants;
using static TruckManagementWeb.Core.Constants.ValidationConstants;
using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Core.Models.Truck
{
    public class FindTruckFormModel
    {

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Truck plate")]
        [StringLength(TruckPlateMaxLength,
            MinimumLength = TruckBrandMinLength,
            ErrorMessage = LengthMessage)]
        [RegularExpression(PlateRegexValidation,
            ErrorMessage = PlateMessage)]
        public string TruckPlate { get; set; } = string.Empty;
    }
}
