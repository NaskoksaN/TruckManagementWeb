using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruckManagementWeb.Infrastructure.Data.Enum;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.Infrastructure.Data.Configuration
{
    public class TruckExpenseConfiguration : IEntityTypeConfiguration<TruckExpense>
    {
        public void Configure(EntityTypeBuilder<TruckExpense> builder)
        {

            int numberOfTrucks = 6; 

            DateTime startDate = new DateTime(2023, 6, 1);

            DateTime endDate = DateTime.UtcNow.Date;

            int months = (endDate.Year - startDate.Year) * 12 + endDate.Month - startDate.Month;

            Dictionary<ExpenseType, decimal> expenseDistribution = new Dictionary<ExpenseType, decimal>
            {
                { ExpenseType.Maintenance, 3000 },
                { ExpenseType.DriverSalary, 2700 },
                { ExpenseType.RoadTaxes, 1200 },
                { ExpenseType.Fuel, 3100 }
            };

            for (int i = 0; i <= months; i++)
            {
                DateTime currentDate = startDate.AddMonths(i);

                decimal totalExpense = 10000;

                for (int truckId = 1; truckId <= numberOfTrucks; truckId++)
                {
                    decimal truckExpense = totalExpense;

                    foreach (var expenseType in expenseDistribution)
                    {
                        builder.HasData(
                            new TruckExpense
                            {
                                Id = ((i * numberOfTrucks * 4) + ((truckId - 1) * 4) + (int)expenseType.Key) + 1,
                                TruckId = truckId,
                                Type = expenseType.Key,
                                Amount = truckExpense * (expenseType.Value / totalExpense),
                                ExpenseDate = currentDate,
                                Notes = $"Expense for truck {truckId} - {expenseType.Key} in {currentDate:MMMM yyyy}",
                                EmployeeId = i % 2 == 0 ? 3 : 4
                            }
                        );
                    }
                }
            }
        }
    }
}
