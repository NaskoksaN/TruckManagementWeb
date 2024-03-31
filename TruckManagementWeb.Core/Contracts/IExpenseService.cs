using TruckManagementWeb.Core.Models.Expense;

namespace TruckManagementWeb.Core.Contracts
{
    public interface IExpenseService
    {
        Task<int> AddExpenseAsync(ExpenseFormModel formModel);
        Task<ExpenseViewModel> GetExpenseByIdAsync(int id);
        List<string> GetExpenseTypesAsync();
    }
}
