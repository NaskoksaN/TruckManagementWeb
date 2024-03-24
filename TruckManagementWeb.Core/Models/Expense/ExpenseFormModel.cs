using System.ComponentModel.DataAnnotations;

using static TruckManagementWeb.Core.Constants.MessageConstants;
using static TruckManagementWeb.Core.Constants.ValidationConstants;
using static TruckManagementWeb.Infrastructure.Constants.DataConstants;

namespace TruckManagementWeb.Core.Models.Expense
{
    public class ExpenseFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Truck plate")]
        [StringLength(TruckPlateMaxLength,
            MinimumLength = TruckBrandMinLength,
            ErrorMessage = LengthMessage)]
        [RegularExpression(PlateRegexValidation,
            ErrorMessage = PlateMessage)]
        public string TruckPlate {  get; set; }=string.Empty;

        [Required(ErrorMessage = "Please select an expense type.")]
        [Display(Name = "Expense Type")]
        public string ExpenseType { get; set; }  = string.Empty;

        public List<string> ExpenseTypes { get; set; } = new();

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Expense amount")]
        [Range(typeof(Decimal),
            ExpenseMinPrice,
            ExpenseMaxPrice,
            ErrorMessage = ExpensePriceMessage)]
        public decimal Amount {  get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Invoice date")]
        public DateTime ExpenseDate { get; set; }

        [StringLength(ExpenseNotesMaxLength,
            MinimumLength = ExpenseNotesMinLength,
            ErrorMessage = LengthMessage)]
        public string? Notes {  get; set; }
    }
}
