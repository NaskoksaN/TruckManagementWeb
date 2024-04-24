using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TruckManagementWeb.Infrastructure.Data.Enum;
using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Infrastructure.Data.Models
{
    public class SoldOrder
    {
        [Key]
        [Comment("Order Id")]
        public int Id { get; set; }

        [Required]
        [Comment("CompanyId associated with the order.")]
        public int CompanyId { get; set; }

        [Required]
        public Guid OrderGuid { get; set; } 

        [Required]
        [MaxLength(CompanyNameMaxLength)]
        [Comment("Name of loading company")]
        public string LoadingCompany { get; set; }=string.Empty;

        [Required]
        [Comment("Address of loading company")]
        [MaxLength(CompanyAddressMaxLength)]
        public string LoadingStreet { get; set; }= string.Empty;

        [Required]
        [MaxLength(CompanyTownMaxLength)]
        [Comment("Town of loading company")]
        public string LoadingTown { get; set; } = string.Empty;

        [Required]
        [Comment("Name of delivery company")]
        [MaxLength(CompanyNameMaxLength)]
        public string DeliveryCompany { get; set; } = string.Empty;

        [Required]
        [Comment("Address of delivery company")]
        [MaxLength(CompanyAddressMaxLength)]
        public string DeliveryStreet { get; set; } = string.Empty;

        [Required]
        [Comment("Town of loading company")]
        [MaxLength(CompanyTownMaxLength)]
        public string DeliveryTown { get; set; } = string.Empty;

        [Required]
        [Comment("Laoding reference")]
        [MaxLength(RefMaxLength)]
        public string LoadingReference { get; set; } = string.Empty;

        [Required]
        [Comment("Delivery reference")]
        [MaxLength(RefMaxLength)]
        public string DeliveryReference { get; set; } = string.Empty;

        [Comment("Loading date")]
        public DateTime? LoadingDateTime { get; set; }

        [Comment("Delivery date")]
        public DateTime? DeliveryDateTime { get; set; }


        [Comment("Length of the load")]
        public double LoadingMeter { get; set; }

        [Comment("Weight of the load")]
        public double Weight { get; set; }

        [Comment("price of the load")]
        [Column(TypeName = DecimalColumnType)]
        public decimal Price {  get; set; }


        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; } = null!;
    }
}
