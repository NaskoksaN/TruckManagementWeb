using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using TruckManagementWeb.Core.Contracts;

using static TruckManagementWeb.Constants.WebConstants;
using TruckManagementWeb.Core.Models.Reports;

namespace TruckManagementWeb.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IReports reportService;
        private readonly IMemoryCache cache;

        public HomeController(ILogger<HomeController> logger, 
                        IReports _reportService,
                        IMemoryCache _cache)
        {
            _logger = logger;
            reportService= _reportService;
            cache= _cache;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (!cache.TryGetValue("OveralTrucksInfoCacheKey", out OveralTrucksInfoViewModel model))
            {

                var result = await reportService.OveralInfo();
                cache.Set("OveralTrucksInfoCacheKey", result, TimeSpan.FromHours(1));
                return View(result);
            }
            ViewBag.CompanyInformation = CompanyInfo;
            return View(model);
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error400");
            }
            if (statusCode == 401)
            {
                return View("Error401");
            }
            return View();
        }

    }
}
