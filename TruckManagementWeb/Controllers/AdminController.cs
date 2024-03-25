using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TruckManagementWeb.Core.Models.Admin;
using TruckManagementWeb.Core.Models.ApplicationUser;

namespace TruckManagementWeb.Controllers
{
    public class AdminController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IUserStore<ApplicationUser> userStore;
        private readonly RoleManager<IdentityRole> roleManager;

        
        public AdminController(UserManager<ApplicationUser> _userManager,
                                SignInManager<ApplicationUser> _signInManager,
                                IUserStore<ApplicationUser> _userStore,
                                RoleManager<IdentityRole> _roleManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            userStore = _userStore;
            roleManager = _roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            var roles = await roleManager
                .Roles
                .Select(r => new RoleViewModel()
                {
                    Id=r.Id,
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
                var roles = await roleManager
               .Roles
               .Select(r => new RoleViewModel()
               {
                   Id = r.Id,
                   Name = r.Name
               })
               .ToListAsync();
                model.Roles= roles;
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

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                var roles = await roleManager
               .Roles
               .Select(r => new RoleViewModel()
               {
                   Id = r.Id,
                   Name = r.Name
               })
               .ToListAsync();
                model.Roles = roles;
                return View(model);
            }

            await signInManager.SignInAsync(user, isPersistent: false);
            return RedirectToAction("Index", "Home");
        }
        
    }
}
