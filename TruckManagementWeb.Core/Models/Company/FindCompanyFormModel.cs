using System.ComponentModel.DataAnnotations;

using static TruckManagementWeb.Core.Constants.MessageConstants;
using static TruckManagementWeb.Core.Constants.ValidationConstants;
using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Core.Models.Company
{
    public  class FindCompanyFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Company Vat")]
        [StringLength(CompanyVatMaxLength,
            MinimumLength = CompanyVatMinLength,
            ErrorMessage = LengthMessage)]
        [RegularExpression(VatRegeValidation, ErrorMessage = VatRegexMessage)]
        public string CompanyVat { get; set; } = string.Empty;
    }
}
