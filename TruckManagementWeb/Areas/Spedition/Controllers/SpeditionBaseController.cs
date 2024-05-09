﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static TruckManagementWeb.Core.Constants.RoleConstants;

namespace TruckManagementWeb.Areas.Spedition.Controllers
{
    [Area("Spedition")]
    [Authorize(Roles = ManagerRole)]
    public class SpeditionBaseController : Controller
    {
        
    }
}
