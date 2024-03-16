using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Infrastructure.Data.Models
{
    public class Trip
    {
        /// <summary>
        /// Unique identifier of the trip.
        /// </summary>
        [Key]
        [Comment("Trip identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Identifier of the truck associated with the trip.
        /// </summary>
        [Required]
        [Comment("TruckId associated with the trip.")]
        public int TruckId { get; set; }

        [Required]
        [Comment("Identifier of the employee managing the trip.")]
        public int EmployeeId { get; set; }

        /// <summary>
        /// Distance traveled during the trip in kilometers.
        /// </summary>
        [Required]
        [Comment("Trip in kilometers.")]
        public int TripKm { get; set; }

        /// <summary>
        /// Get sum of each order /FTL - 1 order or LTL - many orders/ included in trip.
        /// </summary>
        [Required]
        [Comment("Price of the trip.")]
        [Column(TypeName = DecimalColumnType)]
        public decimal TripPrice { get; set; }

        /// <summary>
        /// Represent Price / Km in euro
        /// </summary>
        [Required]
        [Comment("Euro per Km")]
        [Column(TypeName = DecimalColumnType)]
        public decimal EuPerKm { get; set; }

        /// <summary>
        /// The start date of the trip.
        /// </summary>
        [Required]
        [Comment("Start date of the trip.")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// End date of the trip.
        /// </summary>
        [Required]
        [Comment("End date of the trip.")]
        public DateTime EndDate { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; } = null!;

        [ForeignKey(nameof(TruckId))]
        public Truck Truck { get; set; } = null!;

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}
