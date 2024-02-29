using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Identifier of the company associated with the trip.
        /// </summary>
        [Required]
        [Comment("CompanyId associated with the trip.")]
        public int CompanyId { get; set; }

        /// <summary>
        /// Identifier of the truck associated with the trip.
        /// </summary>
        [Required]
        [Comment("TruckId associated with the trip.")]
        public int TruckId { get; set; }

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
        public decimal TripPrice { get; set; }

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
        
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}
