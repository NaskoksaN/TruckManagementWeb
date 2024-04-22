using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Reports;
using TruckManagementWeb.Core.Models.Truck;

namespace TruckManagementWeb.Controllers
{
    [Authorize(Roles = "Manager")]
    public class ReportsController : BaseController
    {
        private readonly ITruckService truckService;
        private readonly IReports reportService;
        private readonly ICompanyService companyService;

        public ReportsController(ITruckService _truckService, 
                    IReports _reportService,
                    ICompanyService _companyService)

        {
            this.truckService = _truckService;
            this.reportService = _reportService;
            companyService = _companyService;
            }

        [HttpGet]
        public ActionResult TruckReport()
        {
            FindTruckFormModel form = new FindTruckFormModel();
            return View("FindTruck", form);
        }
        [HttpPost]
        public async Task<IActionResult> TruckReport(FindTruckFormModel form)
        {
            if (form == null)
            {
                return BadRequest();
            }
            if (await truckService.IsTruckByPlateExistAsync(form.TruckPlate) == false)
            {
                this.ModelState.AddModelError(nameof(form.TruckPlate),
                    "Truck not exist");
            }

            if (!ModelState.IsValid)
            {
                return View("FindTruck", form);
            }

            return View(nameof(TruckReport), form);
        }

        [HttpGet]
        public async Task<IActionResult> TruckLastMonth(string truckPlate)
        {
            if (string.IsNullOrEmpty(truckPlate))
            {
                return BadRequest("Truck plate is required.");
            }
            var truck = await truckService.FindTruckByPlateAsync(truckPlate);
            if (truck == null)
            {
                return BadRequest();
            }

            TruckMonthReportViewModel truckReport = await reportService.TruckLastMonthAsync(truckPlate);

            if (truckReport == null)
            {
                return BadRequest();
            }

            return View(truckReport);
        }

        [HttpGet]
        public async Task<IActionResult> TruckCurrentMonth(string truckPlate)
        {
            if (string.IsNullOrEmpty(truckPlate))
            {
                return BadRequest("Truck plate is required.");
            }
            var truck = await truckService.FindTruckByPlateAsync(truckPlate);
            if (truck == null)
            {
                return BadRequest();
            }

            TruckMonthReportViewModel truckReport = await reportService.TruckCurrentMonthAsync(truckPlate);

            if (truckReport == null)
            {
                return BadRequest();
            }

            return View(truckReport);
        }

        [HttpGet]
        public async Task<IActionResult> TruckLastQuarter(string truckPlate, int page = 1)
        {
            if (string.IsNullOrEmpty(truckPlate))
            {
                return BadRequest("Truck plate is required.");
            }

            var truck = await truckService.FindTruckByPlateAsync(truckPlate);
            if (truck == null)
            {
                return BadRequest();
            }

            List<TruckMonthReportViewModel> truckReport = await reportService.TruckLastQuarterAsync(truckPlate);

            if (truckReport == null)
            {
                return BadRequest();
            }

            ViewBag.TruckPlate = truckPlate;
            return View(truckReport);
        }

        [HttpGet]
        public async Task<IActionResult> TruckLastYear(string truckPlate)
        {
            if (string.IsNullOrEmpty(truckPlate))
            {
                return BadRequest("Truck plate is required.");
            }

            var truck = await truckService.FindTruckByPlateAsync(truckPlate);
            if (truck == null)
            {
                return BadRequest();
            }

            IEnumerable<TruckMonthSimpleViewModel> truckYearReport
                                     = await reportService.GetTruckYearReport(truckPlate);

            return View(truckYearReport);
        }

        [HttpGet]
        public IActionResult AllTrucksReport()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ResultOfTrucksLastMonth()
        {
            var( title,monthlyResult) = await reportService.GetMonthlyTrucksResultAsync();

            ViewBag.Title = title;
            return View(monthlyResult);
        }
        [HttpGet]
        public async Task<IActionResult> YearlyTrucksResult()
        {
            var (title, monthlyResult) = await reportService.GetTrucksYearResultAsync();

            ViewBag.Title = title;
            return View(monthlyResult);
        }

        [HttpGet]
        public async Task<IActionResult> FilteredCompanyRevenue([FromQuery] CompanyQueryModel query)
        {
            var model = await reportService
                            .FilteredCompanyRevenue(query.Country,
                                                    query.SearchTerm,
                                                    query.Sorting,
                                                    query.CurrentPage,
                                                    query.PerPage);

            query.TotalCompanyCount = model.TotalCompanyCount;
            query.RevenueReports = model.RevenueReports;

            query.Countries = await companyService.UniqueCountryAsync();


            return View(query);
        }
    }
    
}
