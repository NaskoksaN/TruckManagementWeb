using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Truck;

using static TruckManagementWeb.Constants.WebConstants;

using X.PagedList;
using Microsoft.AspNetCore.Authorization;

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
        [Authorize(Roles = "Dispo, Manager, Admin")]
        public async Task<IActionResult> TruckDetails(int id)
        {
            TruckViewModel? viewModel = await service.FindTruckByIdAsyncc(id);
           
            return View(viewModel);
        }
        
        [HttpGet]
        [Authorize(Roles = "Admin, Dispo, Manager")]
        public IActionResult FindTruck()
        {
            FindTruckFormModel formModel = new();

            return View(formModel);
        }
        [HttpPost]
        [Authorize(Roles = "Dispo, Manager, Admin")]
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
        [Authorize(Roles = "Dispo, Manager, Admin")]
        public async Task<IActionResult> TruckIndex(int? page)
        {
            int pageNumber = page ?? TruckPageStartIndex;
            int pageSize = TruckPageEndIndex; 

            IEnumerable<TruckIndexViewModel> trucks = await service.GetAlltruckReadOnlyAsync();


            IPagedList<TruckIndexViewModel> pagedList = trucks.ToPagedList(pageNumber, pageSize);

            return View(pagedList);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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
