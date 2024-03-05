using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Infrastructure.Data.Models
{
    public class Order
    {
        /// <summary>
        /// Unique identifier of the order.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Price of the order.
        /// </summary>
        [Required]
        [Comment("Price of the order.")]
        [Column(TypeName = DecimalColumnType)]
        public decimal Price { get; set; }

        /// <summary>
        /// The identifier of the company associated with the order.
        /// </summary>
        [Required]
        [Comment("CompanyId associated with the order.")]
        public int CompanyId { get; set; }

        /// <summary>
        /// The identifier of the trip associated with the order.
        /// </summary>
        [Required]
        [Comment("TripId associated with the order.")]
        public int TripId { get; set; }

        /// <summary>
        /// The date when the order is scheduled for loading.
        /// </summary>
        [Required]
        [Comment("Loading date")]
        public DateTime LoadingDate { get; set; }

        /// <summary>
        /// The date when the order is scheduled for delivery.
        /// </summary>
        [Required]
        [Comment("DeliveryDate")]
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Postal code for the location where the order will be loaded.
        /// </summary>
        [Required]
        [Comment("Loaiding place")]
        [MaxLength(PostCodeMaxLength)]
        public string LoadingPostCode { get; set; } = string.Empty;

        /// <summary>
        /// The postal code for the delivery location of the order.
        /// </summary>
        [Required]
        [Comment("Delivery place")]
        [MaxLength(PostCodeMaxLength)]
        public string DeliveryPostCode { get; set; } = string.Empty;

        
        [ForeignKey(nameof(TripId))]
        public Trip Trip { get; set; } = null!;


        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; } = null!;

    }

}
