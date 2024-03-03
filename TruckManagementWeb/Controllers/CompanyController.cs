using Microsoft.AspNetCore.Mvc;

namespace TruckManagementWeb.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
