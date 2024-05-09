using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TruckManagementWeb.Controllers
{
    public class EPodController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index(Guid token)
        {
            return RedirectToAction("ConfirmOrder", "SellOrder", new { area = "Spedition", token });
        }
    }
}
