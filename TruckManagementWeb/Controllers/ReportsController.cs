using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Reports;
using TruckManagementWeb.Core.Models.Truck;

namespace TruckManagementWeb.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ITruckService truckService;
        private readonly IReports reportService;

        public ReportsController(ITruckService _truckService, IReports _reportService)

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
            if (await truckService.IsTruckExistAsync(form.TruckPlate)==false)
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
        //[HttpGet]
        //public async Task<IActionResult> TruckLastMonth(string truckPlate)
        //{
        //    return await GenerateTruckReportForPeriod(truckPlate, DateTime.Today.AddMonths(-1), "last");
        //}

        //[HttpGet]
        //public async Task<IActionResult> TruckCurrentMonth(string truckPlate)
        //{
        //    return await GenerateTruckReportForPeriod(truckPlate, DateTime.Today, "current");
        //}

        //private async Task<IActionResult> GenerateTruckReportForPeriod(string truckPlate, DateTime startDate, string period)
        //{
        //    if (string.IsNullOrEmpty(truckPlate))
        //    {
        //        return BadRequest("Truck plate is required.");
        //    }

        //    var truck = await truckService.FindTruckByPlateAsync(truckPlate);
        //    if (truck == null)
        //    {
        //        return BadRequest();
        //    }

        //    DateTime firstDayOfMonth = new DateTime(startDate.Year, startDate.Month, 1);
        //    DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

        //    TruckMonthReportViewModel truckReport = await reportService.GetTruckPeriodResultAsync(
        //        truckPlate,
        //        firstDayOfMonth,
        //        lastDayOfMonth
        //    );

        //    if (truckReport == null)
        //    {
        //        return BadRequest();
        //    }

        //    ViewBag.Title = $"Truck {truckReport.PlateNumber} report for {period} month";

        //    return View(truckReport);
        //}

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

            DateTime today = DateTime.Today;
            DateTime firstDayOfLastMonth = new DateTime(today.Year, today.Month - 1, 1);
            DateTime lastDayOfLastMonth = firstDayOfLastMonth.AddMonths(1).AddDays(-1);

            TruckMonthReportViewModel truckReport = await reportService
                        .GetTruckPeriodResultAsync(truckPlate
                                                    , firstDayOfLastMonth
                                                    , lastDayOfLastMonth);

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

            DateTime today = DateTime.Today;
            DateTime firstDayOfCurrentMonth = new DateTime(today.Year, today.Month, 1);
            DateTime lastDayOfCurrentMonth = firstDayOfCurrentMonth.AddMonths(1).AddDays(-1);

            TruckMonthReportViewModel truckReport = await reportService
                        .GetTruckPeriodResultAsync(truckPlate
                                                    , firstDayOfCurrentMonth
                                                    , lastDayOfCurrentMonth);

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

            DateTime today = DateTime.Today;

            List<TruckMonthReportViewModel> truckReport = new List<TruckMonthReportViewModel>();

            DateTime startDate = today.AddMonths(-1).AddDays(1);

            for (int i = 0; i < 3; i++)
            {
                DateTime firstDayOfMonth = new DateTime(startDate.Year, startDate.Month, 1);
                DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                var truckMonthly = await reportService.GetTruckPeriodResultAsync(truckPlate, firstDayOfMonth, lastDayOfMonth);

                truckReport.Insert(0, truckMonthly); 

                startDate = startDate.AddMonths(-1);
            }

            if (truckReport == null)
            {
                return BadRequest();
            }
            ViewBag.TruckPlate = truckPlate;
            return View(truckReport);
        }

    }
}
