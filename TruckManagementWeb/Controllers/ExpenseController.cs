using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Expense;

namespace TruckManagementWeb.Controllers
{
    public class ExpenseController : BaseController
    {
        private readonly IExpenseService service;
        private readonly ITruckService truckerService;
        public ExpenseController(IExpenseService _service
            , ITruckService _truckerService)
        {
            service = _service;
            this.truckerService = _truckerService;

        }
        [HttpGet]
        public async Task<IActionResult> AddExpense()
        {
            ExpenseFormModel formModel = new();
            formModel.ExpenseDate = DateTime.Now;
            formModel.ExpenseTypes = service.GetExpenseTypesAsync();
            return View(formModel);
        }
        [HttpPost]
        public async Task<IActionResult> AddExpense(ExpenseFormModel formModel)
        {
            if(await truckerService.IsTruckExistAsync(formModel.TruckPlate)==false)
            {
                this.ModelState.AddModelError(nameof(formModel.TruckPlate),
                   "Truck with this plate not exist");
            }
            formModel.ExpenseTypes = service.GetExpenseTypesAsync();
            if (!formModel.ExpenseTypes.Contains(formModel.ExpenseType))
            {
                ModelState.AddModelError(nameof(formModel.ExpenseType), "Please select a valid expense type.");
                return View(formModel);
            }
            if(!ModelState.IsValid)
            {
                formModel.ExpenseTypes = service.GetExpenseTypesAsync();
                return View(formModel);
            }

            int newExpenseId = await service.AddExpenseAsync(formModel);

            return View();
        }
    }
}
