using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Company;

namespace TruckManagementWeb.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService service;
        private readonly ILogger<HomeController> logger;
        public CompanyController(ICompanyService _service,
                        ILogger<HomeController> _logger)
        {
            service = _service;
            logger = _logger;
        }
        [HttpGet]
        public IActionResult AddCompany()
        {
            CompanyFormModel form = new();

            return View(form);
        }
        [HttpPost]
        public async Task<IActionResult> AddCompany(CompanyFormModel form)
        {
            if (await service.IsCompanyExistByVat(form.CompanyVat))
            {
                this.ModelState.AddModelError(nameof(form.CompanyVat),
                   "Truck with this plate already added");
            }

            if(!ModelState.IsValid)
            {
                return View(form);
            }

            int newCompanyId = await service.CreateAsync(form);

            return RedirectToAction(nameof(CompanyController.CompanyDetails), new { id = newCompanyId });

        }
        [HttpGet]
        public async Task<IActionResult> CompanyDetails(int id)
        {
            CompanyViewModel? viewModel = await service.FindCompanyByIdAsync(id);

            return View();
        }
    }
}
