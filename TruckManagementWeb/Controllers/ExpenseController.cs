using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Expense;
using TruckManagementWeb.Core.Service;

namespace TruckManagementWeb.Controllers
{
    public class ExpenseController : BaseController
    {
        private readonly IExpenseService service;
        private readonly ITruckService truckerService;
        private readonly IEmployeeService employeeService;
        public ExpenseController(IExpenseService _service, 
            ITruckService _truckerService,
            IEmployeeService _employeeService)
        {
            service = _service;
            this.truckerService = _truckerService;
            this.employeeService = _employeeService;
        }
        [HttpGet]
        public IActionResult AddExpense()
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

            string employeeUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int employeeId = await employeeService.FindEmployeeIdAsync(employeeUserId);
            formModel.EmployeeId = employeeId;

            int newExpenseId = await service.AddExpenseAsync(formModel);

            return RedirectToAction(nameof(ExpenseDetails), new { id = newExpenseId });
        }
        [HttpGet]
        public async Task<IActionResult> ExpenseDetails(int id)
        {
            ExpenseViewModel model = await service.GetExpenseByIdAsync(id);
            
            return View(model);
        }
    }
}
