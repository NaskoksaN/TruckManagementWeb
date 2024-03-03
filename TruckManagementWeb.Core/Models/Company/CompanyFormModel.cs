using System.ComponentModel.DataAnnotations;

using static TruckManagementWeb.Core.Constants.MessageConstants;
using static TruckManagementWeb.Core.Constants.ValidationConstants;
using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Core.Models.Company
{
    public class CompanyFormModel
    {

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CompanyNameMaxLength,
            MinimumLength = CompanyNameMinLength,
            ErrorMessage = LengthMessage
            )]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Company Vat")]
        [StringLength(CompanyVatMaxLength,
            MinimumLength = CompanyVatMinLength,
            ErrorMessage = LengthMessage)]
        [RegularExpression(VatRegeValidation, ErrorMessage = VatRegexMessage)]
        public string CompanyVat { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CompanyCountryMaxLength,
            MinimumLength = CompanyCountryMinLength,
            ErrorMessage = LengthMessage)]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CompanyTownMaxLength,
            MinimumLength = CompanyTownMinLength,
            ErrorMessage = LengthMessage)]
        public string Town { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CompanyAddressMaxLength,
            MinimumLength = CompanyAddressMinLength,
            ErrorMessage = LengthMessage)]
        public string Address { get; set; } = string.Empty;
    }
}
