using Microsoft.EntityFrameworkCore;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Expense;
using TruckManagementWeb.Infrastructure.Data.Common;
using TruckManagementWeb.Infrastructure.Data.Enum;
using TruckManagementWeb.Infrastructure.Data.Models;

namespace TruckManagementWeb.Core.Service
{
    public class ExpenseService : IExpenseService
    {
        private readonly IRepository repository;
        private readonly ITruckService truckService;
        public ExpenseService(IRepository _repository
            , ITruckService _truckService)
        {
            repository = _repository;
            truckService = _truckService;
        }

        public async Task<int> AddExpenseAsync(ExpenseFormModel formModel)
        {
            var truckId = await truckService.GetTruckIdByPlate(formModel.TruckPlate);
            TruckExpense expense = new()
            {
                TruckId = truckId,
                Amount = formModel.Amount,
                Notes = formModel.Notes,
                ExpenseDate = formModel.ExpenseDate,
                EmployeeId = formModel.EmployeeId,
            };
            if (Enum.TryParse(formModel.ExpenseType, out ExpenseType expenseTypeEnum))
            {
                expense.Type = expenseTypeEnum;
            }

            await repository.AddAsync(expense);
            await repository.SaveChangesAsync();

            return expense.Id;
        }

        public async Task<ExpenseViewModel> GetExpenseByIdAsync(int id)
        {
            var expense = await repository.AllAsync<TruckExpense>()
                    .Where(e => e.Id == id)
                    .FirstOrDefaultAsync();
            var truck = await truckService.FindTruckByIdAsyncc(expense.TruckId);

            ExpenseViewModel model = new ExpenseViewModel()
            {
                Id=expense.Id,
                Amount = expense.Amount,
                Notes = expense.Notes ?? "n/a",
                TruckPlate=truck.TruckPlate,
                ExpenseDate=expense.ExpenseDate,
                ExpenseType = expense.Type.ToString(),
            };

            return model;
        }

        public List<string> GetExpenseTypesAsync() => Enum
                                                      .GetNames(typeof(ExpenseType))
                                                      .ToList();
        
    }
    
}
