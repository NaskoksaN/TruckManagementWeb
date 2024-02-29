using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Infrastructure.Data.Models
{
    public class Company
    {
        /// <summary>
        /// Gets or sets the unique identifier of the company.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the company.
        /// </summary>
        [Required]
        [Comment("Full name of the company.")]
        [MaxLength(CompanyNameMaxLength)]
        public string CompanyName { get; set; } = string.Empty;

        /// <summary>
        /// Represent VAT (Value Added Tax) number of the company.
        /// </summary>
        [Required]
        [Comment("VAT number of the company.")]
        [MaxLength(CompanyVatMaxLength)]
        public string CompanyVat { get; set; } = string.Empty;

        /// <summary>
        /// Country where the company is located.
        /// </summary>
        [Required]
        [Comment("Country where the company is located.")]
        [MaxLength(CompanyCountryMaxLength)]
        public string CompanyCountry { get; set; } = string.Empty;

        /// <summary>
        /// Town or city where the company is located.
        /// </summary>
        [Required]
        [Comment("Town or city where the company is located.")]
        [MaxLength(CompanyTownMaxLength)]
        public string CompanyTown { get; set; } = string.Empty;

        /// <summary>
        /// Address of the company.
        /// </summary>
        [Required]
        [Comment("Address of the company.")]
        [MaxLength(CompanyAddressMaxLength)]
        public string CompanyAddress { get; set; } = string.Empty;

        /// <summary>
        /// Indicating whether the company is active or removed 
        /// </summary>
        [Required]
        [Comment("Company activity")]
        public bool IsActive { get; set; } = true;
    }
}
