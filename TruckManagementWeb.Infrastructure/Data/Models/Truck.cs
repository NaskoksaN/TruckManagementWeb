using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Infrastructure.Data.Models
{
    [Comment("Truck table")]
    public class Truck
    {
        /// <summary>
        /// Uunique identifier of the truck.
        /// </summary>
        [Key]
        [Comment("Truck identifier")]
        public int Id { get; set; }

        /// <summary>
        /// The license plate number of the truck.
        /// </summary>
        [Required]
        [Comment("Truck plate")]
        [MaxLength(TruckPlateMaxLength)]
        public string TruckPlate { get; set; } = string.Empty;

        /// <summary>
        /// the brand of the truck.
        /// </summary>
        [Required]
        [Comment("Truck brand")]
        [MaxLength(TruckBrandMaxLength)]
        public string TruckBrand { get; set; } = string.Empty;

        /// <summary>
        /// Model of the truck.
        /// </summary>
        [Required]
        [Comment("Truck model")]
        [MaxLength(TruckModelMaxLength)]
        public string TruckModel { get; set; } = string.Empty;

        /// <summary>
        /// Production year of the truck.
        /// </summary>
        [Required]
        [Comment("Truck production year")]
        public int ProductionYear { get; set; }
        /// <summary>
        /// Indicating whether the truck is active or removed from service
        /// </summary>
        [Required]
        [Comment("Truck activity")]
        public bool IsActive { get; set; } = true;
    }
}
