using Microsoft.AspNetCore.Mvc;

namespace TruckManagementWeb.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public IActionResult AdminHomeIndex()
        {
            return View();
        }

        public IActionResult QuitArea()
        {
            return RedirectToAction("HomeUserIndex", "Home", new { area = "" });
        }
    }
}
