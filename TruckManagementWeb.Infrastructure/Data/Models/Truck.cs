using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Infrastructure.Data.Models
{
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

        /// <summary>
        /// Represents the date when the truck was added to the database.
        /// </summary>
        [Required]
        [Comment("Date of add truck to Database")]
        public DateTime AddedDate { get; set; } = DateTime.UtcNow.Date;

        /// <summary>
        /// Represents the date when the truck was removed from the database.
        /// </summary>
        [Comment("Date when truck is removed")]
        public DateTime? RemovedDate {  get; set; }

        /// <summary>
        /// Represents the initial mileage of the truck.
        /// </summary>
        [Required]
        [Comment("Truck initial milleage")]
        public int TruckInitialKm {  get; set; }

        public ICollection<TruckExpense> Expenses { get; set; } = new List<TruckExpense>();
        public ICollection<Trip> Trips { get; set; } = new List<Trip>();

    }
}
