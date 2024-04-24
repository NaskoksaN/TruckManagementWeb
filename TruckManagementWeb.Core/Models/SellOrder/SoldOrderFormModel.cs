using System.ComponentModel.DataAnnotations;

using static TruckManagementWeb.Core.Constants.MessageConstants;
using static TruckManagementWeb.Core.Constants.ValidationConstants;
using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Core.Models.SoldOrder
{
    public  class SoldOrderFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Client Company Vat")]
        [StringLength(CompanyVatMaxLength,
            MinimumLength = CompanyVatMinLength,
            ErrorMessage = LengthMessage)]
        [RegularExpression(VatRegeValidation, ErrorMessage = VatRegexMessage)]
        public string  ClientCompanyVat { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name ="Loading compnay name")]
        [StringLength(CompanyNameMaxLength,
            MinimumLength = CompanyNameMinLength,
            ErrorMessage = LengthMessage
            )]
        public string LoadingCompany { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Loading street name")]
        [StringLength(CompanyAddressMaxLength,
            MinimumLength = CompanyAddressMinLength,
            ErrorMessage = LengthMessage)]
        public string LoadingStreet { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Loading town name")]
        [StringLength(CompanyTownMaxLength,
            MinimumLength = CompanyTownMinLength,
            ErrorMessage = LengthMessage)]
        public string LoadingTown { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Delivery compnay name")]
        [StringLength(CompanyNameMaxLength,
            MinimumLength = CompanyNameMinLength,
            ErrorMessage = LengthMessage
            )]
        public string DeliveryCompany { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Delivery street name")]
        [StringLength(CompanyAddressMaxLength,
            MinimumLength = CompanyAddressMinLength,
            ErrorMessage = LengthMessage)]
        public string DeliveryStreet { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Delivery town name")]
        [StringLength(CompanyTownMaxLength,
            MinimumLength = CompanyTownMinLength,
            ErrorMessage = LengthMessage)]
        public string DeliveryTown { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Loading reffernce")]
        [StringLength(RefMaxLength,
            MinimumLength = RefMinLength,
            ErrorMessage = LengthMessage)]
        public string LoadingReference { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Delivery reffernce")]
        [StringLength(RefMaxLength,
            MinimumLength = RefMinLength,
            ErrorMessage = LengthMessage)]
        public string DeliveryReference { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Loading Meter")]
        [Range(LoadingMetterMin,
            LoadingMetterMax,
            ErrorMessage = LengthMessage)]
        public double LoadingMeter { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Loading Weight")]
        [Range(LoadingWeightMin,
            LoadingWeightMax,
            ErrorMessage = LengthMessage)]
        public double Weight { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Order total price")]
        [Range(typeof(Decimal),
            TripMinPrice,
            TripMaxPrice,
            ErrorMessage = TripPriceMessage)]
        public decimal Price { get; set; }


        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Client Email to send order")]
        [EmailAddress]
        public string ClientEmail {  get; set; } = string.Empty;

        [Required]
        public Guid OrderGuid { get; set; }

        public DateTime LoadingDateTime { get; set; }
        public DateTime DeliveryDateTime { get; set; }
    }
}
