using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;

namespace TruckManagementWeb.Controllers
{
    public class TruckController : Controller
    {
        private readonly ITrcukService service;
        public TruckController(ITrcukService _service)
        {
            service = _service;
        }
        public IActionResult AddTruck()
        {
            return View();
        }
    }
}
