using Microsoft.AspNetCore.Mvc;

namespace TruckManagementWeb.Areas.Spedition.Controllers
{
    public class HomeController : SpeditionBaseController
    {
        public IActionResult SpeditionHomeIndex()
        {
            return View();
        }

        public IActionResult QuitArea()
        {
            return RedirectToAction("HomeUserIndex", "Home", new { area = "" });
        }
    }
}
