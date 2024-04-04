using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Reports;
using TruckManagementWeb.Core.Models.Truck;

namespace TruckManagementWeb.Controllers
{
    public class ReportsController : BaseController
    {
        private readonly ITruckService truckService;
        private readonly IReports reportService;
        

        public ReportsController(ITruckService _truckService
                            , IReports _reportService)

        {
            this.truckService = _truckService;
            this.reportService = _reportService;
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
            DateTime today = DateTime.Today;
            DateTime firstDayOfLastMonth = new DateTime(today.Year, today.Month - 1, 1);
            DateTime lastDayOfLastMonth = firstDayOfLastMonth.AddMonths(1).AddDays(-1);

            List<TruckMonthSimpleViewModel> monthlyResult = await reportService
                .GetTrucksMonthlyResultAsync(firstDayOfLastMonth, lastDayOfLastMonth);

            decimal profit = monthlyResult.Sum(t => t.TotalEuros) - monthlyResult.Sum(t => t.TotalExpenses);
            string profitLabel = profit >= 0 ? "Profit" : "Loss";
            string period = $"{firstDayOfLastMonth.ToString("dd/MM/yyyy")} - {lastDayOfLastMonth.ToString("dd/MM/yyyy")}";
            ViewBag.Title = $"Trucks last month ({period}) Result: {profitLabel} {Math.Abs(profit)} euro";

            return View(monthlyResult);
        }
        [HttpGet]
        public async Task<IActionResult> YearlyTrucksResult()
        {
            List<TruckMonthSimpleViewModel> yearResult = await reportService
                .GetTrucksYearResultAsync();

            decimal profit = yearResult.Sum(t => t.TotalEuros) - yearResult.Sum(t => t.TotalExpenses);
            string profitLabel = profit >= 0 ? "Profit" : "Loss";

            DateTime lastFullMonthStart = DateTime.Today.AddMonths(-1).AddDays(1 - DateTime.Today.Day);
            DateTime lastFullMonthEnd = lastFullMonthStart.AddMonths(1).AddDays(-1);
            DateTime startOfLast12Months = lastFullMonthStart.AddYears(-1).AddMonths(1);

            ViewBag.Title = $"Trucks last year ({startOfLast12Months.ToString("dd/MM/yyyy")} - {lastFullMonthEnd.ToString("dd/MM/yyyy")}) Result: {profitLabel} {Math.Abs(profit)} euro";
            return View(yearResult);
        }
        [HttpGet]
        public async Task<IActionResult> YearlyRevenueFromCompanies(int page =1)
        {
            List<ReportRevenueFromCompany> companiesRevenue = await reportService.YearlyCompanyRevenueAsync();
            DateTime lastFullMonthStart = DateTime.Today.AddMonths(-1).AddDays(1 - DateTime.Today.Day);
            DateTime lastFullMonthEnd = lastFullMonthStart.AddMonths(1).AddDays(-1);
            DateTime startOfLast12Months = lastFullMonthStart.AddYears(-1).AddMonths(1);

            ViewBag.Title = $"Income from Companies for last year ({startOfLast12Months.ToString("dd/MM/yyyy")} - {lastFullMonthEnd.ToString("dd/MM/yyyy")})";

            int itemsPerPage = 6;
            int totalCompanies = companiesRevenue.Count;
            int totalPages = (int)Math.Ceiling((double)totalCompanies / itemsPerPage);

            page = Math.Max(1, Math.Min(page, totalPages));

            int startIndex = (page - 1) * itemsPerPage;
            int endIndex = Math.Min(startIndex + itemsPerPage, totalCompanies);

            List<ReportRevenueFromCompany> companiesForPage = companiesRevenue.GetRange(startIndex, endIndex - startIndex);

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(companiesForPage);
        }
    }

    
}
