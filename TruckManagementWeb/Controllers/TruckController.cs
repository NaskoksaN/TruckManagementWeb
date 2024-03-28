using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Truck;

using static TruckManagementWeb.Constants.WebConstants;

using X.PagedList;

namespace TruckManagementWeb.Controllers
{
    public class TruckController : BaseController
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
            TruckViewModel? viewModel = await service.FindTruckByIdAsyncc(id);
            return View(viewModel);
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
            if(model== null)
            {
                this.ModelState.AddModelError(nameof(model.Id),
                    "Truck with this plate not exist");
            }

            return RedirectToAction(nameof(TruckController.TruckDetails), new { id = model?.Id });
        }
        [HttpGet]
        public IActionResult FindTruck()
        {
            FindTruckFormModel formModel = new();

            return View(formModel);
        }
        [HttpPost]
        public async Task<IActionResult> FindTruck(FindTruckFormModel form)
        {
            TruckViewModel? model = await service.FindTruckByPlateAsync(form.TruckPlate);
            if (model != null)
            {
                return RedirectToAction(nameof(TruckController.TruckDetails), 
                                    new { id = model.Id});
            }
            else
            {
                this.ModelState.AddModelError(nameof(form.TruckPlate),
                    "Truck with this plate was not found");
            }

            return View(form);
        }

        [HttpGet]
        public async Task<IActionResult> TruckIndex(int? page)
        {
            int pageNumber = page ?? TruckPageStartIndex;
            int pageSize = TruckPageEndIndex; 

            IEnumerable<TruckIndexViewModel> trucks = await service.GetAlltruckReadOnlyAsync();

            IPagedList<TruckIndexViewModel> pagedList = trucks.ToPagedList(pageNumber, pageSize);

            return View(pagedList);
        }

        [HttpGet]
        public async Task<IActionResult> EditTruck(int id)
        {
            TruckEditFormModel? form = await service.GetTruckForEditByIdAsync(id);
            if(form == null)
            {
                return BadRequest();
            }

            return View(form);
        }
        [HttpPost]
        public async Task<IActionResult> EditTruck(int id, TruckEditFormModel form)
        {
            if(id != form.Id)
            {
                return BadRequest();
            }
            var existTruck = await service.FindTruckByPlateAsync(form.TruckPlate);

            if (existTruck.Id!= form.Id )
            {
                this.ModelState.AddModelError(nameof(form.TruckPlate),
                    "Truck with this plate already added");
            }

            if (!ModelState.IsValid)
            {
                return View(form);
            }

            await service.EditAsync(id, form);

            return RedirectToAction(nameof(TruckController.TruckDetails), new { id = form.Id });
        }

    }
}
