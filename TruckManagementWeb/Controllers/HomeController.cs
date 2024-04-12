using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Security.Claims;

using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Reports;
using static TruckManagementWeb.Constants.WebConstants;
using static TruckManagementWeb.Core.Constants.CustomClaims;

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
                cache.Set("OveralTrucksInfoCacheKey", result, TimeSpan.FromHours(ChacheHomeIndexTime));
                return View(result);
            }
            ViewBag.CompanyInformation = CompanyInfo;
            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }

        public async Task<IActionResult> HomeUserIndex()
        {
            string userName = User.FindFirstValue(UserFullNameClaims) ?? string.Empty;
            return View(nameof(HomeUserIndex), userName);
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error404");
            }
            if (statusCode == 401)
            {
                return View("Error500");
            }
            return View();
        }


    }
}
