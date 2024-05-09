using Microsoft.AspNetCore.Mvc;

namespace TruckManagementWeb.Areas.Spedition.Controllers
{
    public class HomeController : SpeditionBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
