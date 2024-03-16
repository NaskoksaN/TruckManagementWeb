using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Reports;
using TruckManagementWeb.Core.Models.Truck;

namespace TruckManagementWeb.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ITruckService truckService;
        private readonly IReports service;
        public ReportsController(
            ITruckService _truckService,
            IReports _service)
        {
            truckService = _truckService;
            service = _service;
        }
        [HttpGet]
        public IActionResult TruckReportLastMonth()
        {
            FindTruckFormModel formModel = new();

            return View("FindTruck", formModel);
        }
        [HttpPost]
        public async Task<IActionResult> TruckReportLastMonth(FindTruckFormModel formModel)
        {
            var truck = await truckService.FindTruckByPlateAsync(formModel.TruckPlate);
            if(truck == null)
            {
                this.ModelState.AddModelError(nameof(formModel.TruckPlate),
                    "Truck with this plate was not found");
                return View("FindTruck", formModel);
            }

            TruckMonthReportsViewModel truckReport = await service
                        .GetTruckAndLastMonthResultAsync(formModel.TruckPlate);
            
            
            return View(truckReport);
        }
    }
}
