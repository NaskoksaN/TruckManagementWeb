using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Trip;
using TruckManagementWeb.Infrastructure.Data.Common;

namespace TruckManagementWeb.Controllers
{
    public class TripController : Controller
    {
        private readonly ITripService service;
        private readonly ITruckService truckService;
        private readonly ICompanyService companyService;
        public TripController(ITripService _service,
                    ITruckService _truckService, 
                    ICompanyService _companyService)
        {
            service = _service;
            truckService = _truckService;
            companyService = _companyService;
        }

        [HttpGet]
        public IActionResult CreateTrip()
        {
            TripFormModel form = new TripFormModel();
            form.StartDate = DateTime.UtcNow;
            form.EndDate = DateTime.UtcNow;

            return View(form);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTrip(TripFormModel form)
        {
            string plate = form.TruckPlate;
            if(await truckService.IsTruckExistAsync(plate)==false)
            {
                this.ModelState.AddModelError(nameof(form.TruckPlate),
                    "Truck with this plate not exist.");
            }

            if(!ModelState.IsValid)
            {
                form.StartDate = DateTime.UtcNow;
                form.EndDate = DateTime.UtcNow;
                return View(form);
            }

            int newTripId = await service.CreateTripAsync(form);

            return RedirectToAction(nameof(TripController.CreateOrder), new { id = newTripId });
        }

        [HttpGet]
        public IActionResult CreateOrder(int id)
        {
            OrderFormModel form = new OrderFormModel();
            form.LoadingDate = DateTime.UtcNow;
            form.DeliveryDate = DateTime.UtcNow;
            form.TripId = id;

            return View(form);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderFormModel form , string button)
        {
            if (button == "AbortTrip")
            {
                await service.DeleteGivenTripWithOrders(form.TripId);

                return RedirectToAction(nameof(CreateTrip));
            }

            if (await companyService.IsCompanyExistByVat(form.CompanyVat)==false)
            {
                this.ModelState.AddModelError(nameof(form.CompanyVat),
                    "Company with this vat not exist. Without valid Vat abort Trip");
            }
            if(!ModelState.IsValid)
            {
                form.LoadingDate = DateTime.UtcNow;
                form.DeliveryDate = DateTime.UtcNow;

                return View(form);
            }


            if(button== "CreateOrder")
            {
                form.LoadingDate = DateTime.UtcNow;
                form.DeliveryDate = DateTime.UtcNow;
                form.Price = 0M;
                form.CompanyVat = "";
                await service.SaveOrderToTripAsync(form);
                return RedirectToAction(nameof(TripController.CreateOrder), new { id = form.TripId });
            }
             
            if (button == "FinalizeTrip")
            {
                await service.SaveOrderToTripAsync(form);
                form.LoadingDate = DateTime.UtcNow;
                form.DeliveryDate = DateTime.UtcNow;
                form.Price = 0M;
                form.CompanyVat = "";
                return RedirectToAction(nameof(TripController.TripDetails), new { id = form.TripId });
            }

            
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> TripDetails(int id)
        {
            TripViewModel model = await service.GetViewTripByIdAsync(id);

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> TripIndex()
        {
            IEnumerable<TripViewModel> resultView = await service.GetAllTripAsync();
            return View(resultView);
        }

    }
}
