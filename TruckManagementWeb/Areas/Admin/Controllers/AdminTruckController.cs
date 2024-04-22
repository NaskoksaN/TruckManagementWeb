using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Controllers;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Truck;

namespace TruckManagementWeb.Areas.Admin.Controllers
{
    public class AdminTruckController : AdminBaseController
    {
        private readonly ITruckService service;
        private readonly ILogger<HomeController> logger;

        public AdminTruckController(ITruckService _service,
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
            if (await service.IsTruckByPlateExistAsync(form.TruckPlate))
            {
                this.ModelState.AddModelError(nameof(form.TruckPlate),
                    "Truck with this plate already added");
            }

            if (!ModelState.IsValid)
            {
                return View(form);
            }

            int newTruckId = await service.CreateAsync(form);

            return RedirectToAction(nameof(TruckController.TruckDetails), new { id = newTruckId });
        }
    }
}
