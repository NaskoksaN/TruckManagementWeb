using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TruckManagementWeb.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
      
    }
}
