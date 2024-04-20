using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Company;
using X.PagedList;

using static TruckManagementWeb.Constants.WebConstants;

namespace TruckManagementWeb.Controllers
{
    public class CompanyController : BaseController
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
        [Authorize(Roles = "Admin")]
        public IActionResult AddCompany()
        {
            CompanyFormModel form = new CompanyFormModel();

            return View(form);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddCompany(CompanyFormModel form)
        {
            if (await service.IsCompanyExistByVat(form.CompanyVat))
            {
                this.ModelState.AddModelError(nameof(form.CompanyVat),
                   "Company with this vat already added");
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

            return View(viewModel);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditCompany(int id)
        {
            CompanyEditFormModel form = await service.GetCompanyForEditByIdAsync(id);

            return View(form);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditCompany(int id, CompanyEditFormModel form)
        {
            if (id != form.Id)
            {
                return BadRequest();
            }
            var existingCompany = await service.FindCompanyByVatAsync(form.CompanyVat);
            if (form.Id != existingCompany.Id &&
                form.Name!= existingCompany.Name)
            {
                this.ModelState.AddModelError(nameof(form.CompanyVat),
                    "Company with this Vat already added");
            }

            if (!ModelState.IsValid)
            {
                return View(form);
            }

            await service.EditAsync(id, form);

            return RedirectToAction(nameof(CompanyController.CompanyDetails), new { id = form.Id });
        }

        [HttpGet]
        public async Task<IActionResult> FindCompany()
        {
            FindCompanyFormModel form = new();
            return View(form);
        }

        [HttpPost]
        public async Task<IActionResult> FindCompany(FindCompanyFormModel form)
        {
            CompanyViewModel model = await service.FindCompanyByVatAsync(form.CompanyVat);

            if (model != null)
            {
                return RedirectToAction(nameof(CompanyController.CompanyDetails),
                                                new { id = model.Id });
            }
            else
            {
                this.ModelState.AddModelError(nameof(form.CompanyVat),
                    "Company with ths VAT was not found");
            }

            return View(form);
        }

        [HttpGet]
        public async Task<IActionResult> CompanyIndex (int? page)
        {

            int pageNumber = page ?? CompanyPageStartIndex;
            int pageSize = CompanyPageEndIndex; 

            IEnumerable<CompanyIndexViewModel> company = await service
                                .GetAllCompanyReadOnlyOrderByNameAsync();

            IPagedList<CompanyIndexViewModel> pagedList = company.ToPagedList(pageNumber, pageSize);

            return View(pagedList);
        }

        [HttpGet]
        public async Task<IActionResult> SelectedCountry()
        {
            HashSet<CompanyCountryViewModel> countries = await service.GetAllUniqueCountryAsync();
            return View(countries);
        }

        [HttpGet]
        public async Task<IActionResult> CompanyByCountry(string selectedCountry, int? page)
        {
            int pageNumber = page ?? CompanyPageStartIndex;
            int pageSize = CompanyPageEndIndex;

            IEnumerable<CompanyIndexViewModel> companyByCountry =
                    await service.GetCompanyFromCountryAsync(selectedCountry);

            IPagedList<CompanyIndexViewModel> pagedList = companyByCountry
                                                        .ToPagedList(pageNumber, pageSize);

            return View(nameof(CompanyIndex), pagedList);
        }

    }
}
