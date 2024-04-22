using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Controllers;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Company;

namespace TruckManagementWeb.Areas.Admin.Controllers
{
    public class AdminCompanyController : AdminBaseController
    {
        private readonly ICompanyService service;
        private readonly ILogger<HomeController> logger;
        public AdminCompanyController(ICompanyService _service,
                        ILogger<HomeController> _logger)
        {
            service = _service;
            logger = _logger;
        }

        [HttpGet]
        public IActionResult AddCompany()
        {
            CompanyFormModel form = new CompanyFormModel();

            return View(form);
        }

        [HttpPost]
        public async Task<IActionResult> AddCompany(CompanyFormModel form)
        {
            if (await service.IsCompanyExistByVat(form.CompanyVat))
            {
                this.ModelState.AddModelError(nameof(form.CompanyVat),
                   "Company with this vat already added");
            }

            if (!ModelState.IsValid)
            {
                return View(form);
            }

            int newCompanyId = await service.CreateAsync(form);

            return RedirectToAction(nameof(CompanyController.CompanyDetails), new { id = newCompanyId });
        }
    }
}
