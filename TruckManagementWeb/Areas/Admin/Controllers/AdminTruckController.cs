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
            
            return RedirectToAction("TruckDetails", "Truck", new { area = "", id = newTruckId });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteTruck(int id)
        {
            TruckViewModel? model = await service.FindTruckByIdAsyncc(id);
            if (model == null)
            {
                this.ModelState.AddModelError(nameof(model.Id),
                    "Truck with this plate not exist");
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            TruckViewModel model = await service.RemoveTruckAsync(id);
            if (model == null)
            {
                this.ModelState.AddModelError(nameof(model.Id),
                    "Truck with this plate not exist");
            }

            return RedirectToAction("TruckDetails", "Truck", new { area = "", id = model?.Id });
        }

        [HttpGet]
        public async Task<IActionResult> EditTruck(int id)
        {
            TruckEditFormModel? form = await service.GetTruckForEditByIdAsync(id);
            if (form == null)
            {
                return BadRequest();
            }

            return View(form);
        }
        [HttpPost]
        public async Task<IActionResult> EditTruck(int id, TruckEditFormModel form)
        {
            if (id != form.Id)
            {
                return BadRequest();
            }
            var existTruck = await service.FindTruckByPlateAsync(form.TruckPlate);

            if (existTruck.Id != form.Id)
            {
                this.ModelState.AddModelError(nameof(form.TruckPlate),
                    "Truck with this plate already added");
            }

            if (!ModelState.IsValid)
            {
                return View(form);
            }

            await service.EditAsync(id, form);

            return RedirectToAction("TruckDetails", "Truck", new { area = "", id = form.Id});
        }
    }
}
