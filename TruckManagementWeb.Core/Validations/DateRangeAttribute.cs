using System.ComponentModel.DataAnnotations;

namespace TruckManagementWeb.Core.Validations
{
    public class DateRangeAttribute : ValidationAttribute
    {
        private readonly int _maxDaysDifference;

        public DateRangeAttribute(int maxDaysDifference)
        {
            _maxDaysDifference = maxDaysDifference;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var endDate = (DateTime)value;
            var startDateProperty = validationContext.ObjectType.GetProperty("StartDate");
            var startDate = (DateTime)startDateProperty.GetValue(validationContext.ObjectInstance, null);

            var differenceInDays = (endDate - startDate).Days;

            if (differenceInDays > _maxDaysDifference)
            {
                return new ValidationResult($"The difference between Start Date and End Date cannot exceed {_maxDaysDifference} days.");
            }

            return ValidationResult.Success;
        }
    }
}
