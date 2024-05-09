using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Security.Claims;

using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.Reports;
using TruckManagementWeb.Extensions;
using static TruckManagementWeb.Constants.WebConstants;
using static TruckManagementWeb.Core.Constants.CustomClaims;

namespace TruckManagementWeb.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IReports reportService;
        private readonly IMemoryCache cache;
        private readonly IHttpContextAccessor httpContextAccessor;

        public HomeController(ILogger<HomeController> logger, 
                        IReports _reportService,
                        IMemoryCache _cache,
                        IHttpContextAccessor _httpContextAccessor)
        {
            _logger = logger;
            reportService = _reportService;
            cache = _cache;
            httpContextAccessor = _httpContextAccessor;
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
        [HttpGet]
        public async Task<IActionResult> HomeUserIndex(List<string> note)
        {
            string userName = User.FindFirstValue(UserFullNameClaims) ?? string.Empty;
            List<string> notes = HttpContext.Session.Get<List<string>>("Notes") ?? new List<string>();
            @ViewBag.Name = userName;

            return View(nameof(HomeUserIndex), notes);
        }
        [HttpGet]
        public IActionResult EnterAdminArea()
        {
            return RedirectToAction("AdminHomeIndex", "Home", new { area = "Admin" });
        }

        [HttpGet]
        public IActionResult EnterSpeditionArea()
        {
            return RedirectToAction("AdminHomeIndex", "Home", new { area = "Spedition" });
        }

        [HttpPost]
        public async Task<IActionResult> AddNotes(string notes)
        {
            List<string> noteList = HttpContext.Session.Get<List<string>>("Notes") ?? new List<string>();

            noteList.Add(notes);

            HttpContext.Session.Set("Notes", noteList);

            return RedirectToAction(nameof(HomeUserIndex), noteList);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteNotes(string task)
        {
            string userName = User.FindFirstValue(UserFullNameClaims) ?? string.Empty;
            List<string> notes = HttpContext.Session.Get<List<string>>("Notes") ?? new List<string>();

            notes.Remove(task);

            HttpContext.Session.Set("Notes", notes);

            return RedirectToAction(nameof(HomeUserIndex));
        }


        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error(int statusCode)
        {
            if (statusCode == 404)
            {
                return View("Error404");
            }
            if (statusCode == 500)
            {
                return View("Error500");
            }


            return View();
        }
    }
}
