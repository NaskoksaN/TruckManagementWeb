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

        [HttpGet]
        public async Task<IActionResult> EditCompany(int id)
        {
            CompanyEditFormModel form = await service.GetCompanyForEditByIdAsync(id);
            form.ShowCompanyVatField = false;
            return View(form);
        }

        [HttpPost]
        public async Task<IActionResult> EditCompany(int id, CompanyEditFormModel form)
        {
            if (id != form.Id)
            {
                return BadRequest();
            }
            var existingCompany = await service.GetCompanyForEditByIdAsync(id);
            form.CompanyVat = existingCompany.CompanyVat;
            if (form.Id != existingCompany.Id &&
                form.Name == existingCompany.Name)
            {
                this.ModelState.AddModelError(nameof(form.Name),
                    "Company with this name already added and have VAT");
            }

            if (!ModelState.IsValid)
            {
                form.ShowCompanyVatField = false;
                form.CompanyVat = existingCompany.CompanyVat;
                return View(form);
            }

            await service.EditAsync(id, form);

            return RedirectToAction(nameof(CompanyController.CompanyDetails), new { id = form.Id });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            CompanyViewModel? viewModel = await service.FindCompanyByIdAsync(id);
            if (viewModel == null)
            {
                this.ModelState.AddModelError(nameof(viewModel.Id),
                    "Truck with this plate not exist");
            }
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            CompanyViewModel model = await service.RemoveCompanyByIdAsync(id);
            if (model == null)
            {
                this.ModelState.AddModelError(nameof(model.Id),
                    "Company with this Vat not exist");
            }

            return RedirectToAction(nameof(CompanyController.CompanyDetails), new { id = model?.Id });
        }

    }
}
