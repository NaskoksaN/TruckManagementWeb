using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static TruckManagementWeb.Core.Constants.RoleConstants;

namespace TruckManagementWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = AdminRole)]
    public class AdminBaseController : Controller
    {
       
    }
}
