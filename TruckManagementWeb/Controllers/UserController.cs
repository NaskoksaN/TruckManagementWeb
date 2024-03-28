using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.ApplicationUser;
using TruckManagementWeb.Core.Models.User;

namespace TruckManagementWeb.Controllers
{
    [Authorize(Roles ="Admin")]
    public class UserController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IUserStore<ApplicationUser> userStore;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IUserService service;
        private IEmployeeService employeeService;


        public UserController(UserManager<ApplicationUser> _userManager,
                                SignInManager<ApplicationUser> _signInManager,
                                IUserStore<ApplicationUser> _userStore,
                                RoleManager<IdentityRole> _roleManager,
                                IUserService _service,
                                IEmployeeService _employeeService)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            userStore = _userStore;
            roleManager = _roleManager;
            service = _service;
            employeeService = _employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            IEnumerable<RoleViewModel> roles = await service.GetRolesAsync();
            RegisterFormModel adminModel = new RegisterFormModel();
            adminModel.Roles = roles;
            return View(adminModel);
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormModel model)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<RoleViewModel> roles = await service.GetRolesAsync();
                model.Roles = roles;
                return View(model);
            }

            var role = await roleManager.FindByIdAsync(model.SelectedRole);

            if (role == null)
            {
                ModelState.AddModelError(string.Empty, "Selected role not found.");
                IEnumerable<RoleViewModel> roles = await service.GetRolesAsync();
                model.Roles = roles;
                return View(model);
            }

            var user = new ApplicationUser
            {
                UserEmail = model.Email,
                UserName = model.Email
            };

            await userManager.SetEmailAsync(user, model.Email);
            await userManager.SetUserNameAsync(user, model.Email);

            var result = await userManager.CreateAsync(user, model.Password);
            var roleResult = await userManager.AddToRoleAsync(user, role.Name);

            if (result.Succeeded && roleResult.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);

                string userId = user.Id;
                await employeeService.CreateEmployeeAsync(model, userId, role.Id);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            IEnumerable<RoleViewModel> availableRoles = await service.GetRolesAsync();
            model.Roles = availableRoles;
            return View(model);
        }

        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            LoginFormModel model = new LoginFormModel()
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> VewAllUser(int pageNumber=1)
        {
            int pageSize = 6;
            List<UserViewModel> users = await service.GetAllUserAync();
            int totalCount = users.Count();
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            ViewData["PageNumber"] = pageNumber;
            ViewData["TotalPages"] = totalPages;


            return View(users);
        }

    }
}
