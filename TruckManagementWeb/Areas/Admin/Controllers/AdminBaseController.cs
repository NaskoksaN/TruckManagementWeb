using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TruckManagementWeb.Areas.Admin.Controllers
{
    [Authorize(Roles ="")]
    public class AdminBaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
