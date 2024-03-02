using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Truck;

namespace TruckManagementWeb.Controllers
{
    public class TruckController : Controller
    {
        private readonly ITruckService service;
        private readonly ILogger<HomeController> logger;

        public TruckController(ITruckService _service,
            ILogger<HomeController> _logger)
        {
            service = _service;
            logger = _logger;
        }

        [HttpGet]
        public IActionResult AddTruck()
        {
            TruckFormModel model = new TruckFormModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddTruck(TruckFormModel form)
        {
            if(await service.IsTruckExistAsync(form.TruckPlate))
            {
                this.ModelState.AddModelError(nameof(form.TruckPlate),
                    "Truck with this plate already added");
            }

            if (!ModelState.IsValid)
            {
                return View(form);
            }

            int newTruckId = await service.CreateAsync(form);

            return RedirectToAction(nameof(TruckController.TruckDetails), new {id=newTruckId});
        }

        [HttpGet]
        public async Task<IActionResult> TruckDetails(int id)
        {
            TruckViewModel? viewModel = await service.GetTruckByIdAsync(id);
            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteTruck(int id)
        {
            TruckViewModel model = await service.GetTruckByIdAsync(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

        }
    }
}
