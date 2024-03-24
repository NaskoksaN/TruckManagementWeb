using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TruckManagementWeb.Core.Models.ApplicationUser;
using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Infrastructure.Data.Models
{
    public class Employee
    {
        /// <summary>
        /// Unique identifier of the employee.
        /// </summary>
        [Key]
        [Comment("Employee identifier")]
        public int Id { get; set; }

        /// <summary>
        /// E-mail of the employee.
        /// </summary>
        [Required]
        [MaxLength(EmployeeMailMaxLenght)]
        [Comment("Employee e-mail")]
        public string Email {  get; set; } = string.Empty;


        [Required]
        public string EmployeeUserId { get; set; } = string.Empty;
        [ForeignKey(nameof(EmployeeUserId))]
        public ApplicationUser EmployeeUser { get; set; } = null!;


        public ICollection<Trip> Trips { get; set; } = new List<Trip>();
        public ICollection<TruckExpense> TruckExpenses { get; } = new List<TruckExpense>();
    }
}
