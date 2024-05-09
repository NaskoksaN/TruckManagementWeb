using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static TruckManagementWeb.Core.Constants.RoleConstants;

namespace TruckManagementWeb.Areas.Spedition.Controllers
{
    [Area("Manager")]
    [Authorize(Roles = ManagerRole)]
    public class SpeditionBaseController : Controller
    {
        
    }
}
