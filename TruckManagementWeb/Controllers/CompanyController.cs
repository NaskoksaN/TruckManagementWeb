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
        [Authorize(Roles = "Admin, Dispo, Manager")]
        public async Task<IActionResult> CompanyDetails(int id)
        {
            CompanyViewModel? viewModel = await service.FindCompanyByIdAsync(id);

            return View(viewModel);
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Dispo, Manager")]
        public async Task<IActionResult> FindCompany()
        {
            FindCompanyFormModel form = new();
            return View(form);
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Dispo, Manager")]
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
        [Authorize(Roles = "Admin, Dispo, Manager")]
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
        [Authorize(Roles = "Admin, Dispo, Manager")]
        public async Task<IActionResult> SelectedCountry()
        {
            HashSet<CompanyCountryViewModel> countries = await service.GetAllUniqueCountryAsync();
            return View(countries);
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Dispo, Manager")]
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
