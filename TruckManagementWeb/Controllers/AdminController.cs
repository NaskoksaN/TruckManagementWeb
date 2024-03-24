using Microsoft.AspNetCore.Mvc;

namespace TruckManagementWeb.Controllers
{
    public class AdminController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
