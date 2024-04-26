using MailKit;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.ApplicationUser;
using TruckManagementWeb.Core.Models.User;
using TruckManagementWeb.Extensions;
using static TruckManagementWeb.Core.Constants.CustomClaims;
using static TruckManagementWeb.Core.Constants.RoleConstants;

namespace TruckManagementWeb.Controllers
{
    [Authorize(Roles ="Admin")]
    public class UserController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IEmployeeService employeeService;
        private readonly IMyEmailService mailService;
        private readonly IHttpContextAccessor httpContextAccessor;


        public UserController(UserManager<ApplicationUser> _userManager,
                                SignInManager<ApplicationUser> _signInManager,
                                RoleManager<IdentityRole> _roleManager,
                                IEmployeeService _employeeService,
                                IMyEmailService _mailService,
                                IHttpContextAccessor _httpContextAccessor)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
            employeeService = _employeeService;
            mailService = _mailService;
            httpContextAccessor = _httpContextAccessor;
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            IEnumerable<RoleViewModel> roles = await roleManager
                .Roles
                .Select(r => new RoleViewModel()
                {
                    Id = r.Id,
                    Name = r.Name
                })
                .ToListAsync();
            RegisterFormModel adminModel = new RegisterFormModel();
            adminModel.Roles = roles;
            return View(adminModel);
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormModel model)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<RoleViewModel> roles = await GetRolesAsync();
                model.Roles = roles;
                return View(model);
            }

            var role = await roleManager.FindByIdAsync(model.SelectedRole);

            if (role == null)
            {
                ModelState.AddModelError(string.Empty, "Selected role not found.");
                IEnumerable<RoleViewModel> roles = await GetRolesAsync();
                model.Roles = roles;
                return View(model);
            }

            var user = new ApplicationUser
            {
                FullName = model.FullName,
                UserName = model.Email
            };

            await userManager.SetEmailAsync(user, model.Email);
            await userManager.SetUserNameAsync(user, model.Email);

            var result = await userManager.CreateAsync(user, model.Password);
            var roleResult = await userManager.AddToRoleAsync(user, role.Name);

            if (result.Succeeded && roleResult.Succeeded)
            {
                //await signInManager.SignInAsync(user, isPersistent: false);

                string userId = user.Id;
                await employeeService.CreateEmployeeAsync(model, userId, role.Id);

                await userManager.AddClaimAsync(user,
                                        new System.Security
                                        .Claims
                                        .Claim(UserFullNameClaims, $"{user.FullName}"));
                string msg = $"login: {model.Email} , pass: {model.Password}";
                string mailSubject = $"{model.FullName}, your work account is created, find login details";
                mailService.SendMail(model.EMail, msg, mailSubject);

                return RedirectToAction("HomeUserIndex", "Home");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            IEnumerable<RoleViewModel> availableRoles = await GetRolesAsync();
            model.Roles = availableRoles;
            return View(model);
        }


        [AllowAnonymous]
        [HttpGet]
       
        public async Task<IActionResult> Login(string? returnUrl = null)
        {
            // from MS =>Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            LoginFormModel model = new LoginFormModel()
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Microsoft.AspNetCore.Identity.SignInResult? result =
                await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

            if (!result.Succeeded)
            {
                this.ModelState.AddModelError(string.Empty,
                   "Error while in login in. Contact administrator");
                TempData["ErrorMessage"] = "Error while in login in. Contact administrator";
                return View(model);
            }

            var user = await userManager.FindByEmailAsync(model.Email);

            var roles = await userManager.GetRolesAsync(user);

            var roleClaims = roles.Select(role => new Claim(ClaimTypes.Role, role));

            var identity = (ClaimsIdentity)User.Identity;
            identity.AddClaims(roleClaims);

            HttpContext.Session.Remove("Notes");

            if (user!=null && User.IsAdmin())
            {
                return RedirectToAction("AdminHomeIndex", "Home", new {area="Admin"});
            }

            HttpContext.Session.Remove("Notes");

            return Redirect(model.ReturnUrl ?? "~/Home/HomeUserIndex");
        }

        [HttpPost("/User/Logout")]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            await signInManager.SignOutAsync();
            HttpContext.Session.Remove("Notes");
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> VewAllUser(int pageNumber=1)
        {
            int pageSize = 6;
            List<UserViewModel> users = await employeeService.GetAllUserAsync();
            int totalCount = users.Count();
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            ViewData["PageNumber"] = pageNumber;
            ViewData["TotalPages"] = totalPages;


            return View(users);
        }
        private async Task<IEnumerable<RoleViewModel>> GetRolesAsync()
            => await roleManager
                .Roles
                .Select(r => new RoleViewModel()
                {
                    Id = r.Id,
                    Name = r.Name
                })
                .ToListAsync();
        
    }
}
