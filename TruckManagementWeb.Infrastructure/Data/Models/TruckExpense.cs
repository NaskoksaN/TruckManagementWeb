using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TruckManagementWeb.Infrastructure.Data.Enum;
using static TruckManagementWeb.Infrastructure.Constants.DataConstants;


namespace TruckManagementWeb.Infrastructure.Data.Models
{
    public class TruckExpense
    {
        /// <summary>
        /// Unique identifier of the truck expense.
        /// </summary>
        [Key]
        [Comment("Expense identifier")]
        public int Id { get; set; }

        /// <summary>
        /// The identifier of the truck associated with the expense.
        /// </summary>
        [Required]
        [Comment("Truck Id")]
        public int TruckId { get; set; }

        /// <summary>
        /// Gets or sets the type of the expense (e.g., maintenance, driver salary, road taxes, fuel).
        /// </summary>
        [Required]
        [Comment("Specify the type of the expense (e.g., maintenance, driver salary, road taxes, fuel).")]
        public ExpenseType Type { get; set; }

        /// <summary>
        /// Gets or sets the amount of the expense.
        /// </summary>
        [Required]
        [Comment("Amount of expense")]
        [Column(TypeName = DecimalColumnType)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The date of the expense invoicing.
        /// </summary>
        [Required]
        [Comment("Expense date")]
        public DateTime ExpenseDate { get; set; }

        /// <summary>
        /// Additional notes or details about the expense.
        /// </summary>
        [Required]
        [Comment("Notes about the expense.")]
        [MaxLength(ExpenseNotesMaxLength)]
        public string Notes { get; set; } = string.Empty;

        [Required]
        [Comment("Identifier of the employee managing the trip.")]
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; } = null!;


        [ForeignKey(nameof(TruckId))]
        public Truck Truck { get; set; } = null!;

    }
}
