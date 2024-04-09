using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Mail;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.ApplicationUser;
using TruckManagementWeb.Core.Models.User;
using static TruckManagementWeb.Core.Constants.CustomClaims;

namespace TruckManagementWeb.Controllers
{
    [Authorize(Roles ="Admin")]
    public class UserController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private IEmployeeService employeeService;


        public UserController(UserManager<ApplicationUser> _userManager,
                                SignInManager<ApplicationUser> _signInManager,
                                RoleManager<IdentityRole> _roleManager,
                                IEmployeeService _employeeService)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
            employeeService = _employeeService;
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
                await signInManager.SignInAsync(user, isPersistent: false);

                string userId = user.Id;
                await employeeService.CreateEmployeeAsync(model, userId, role.Id);

                await userManager.AddClaimAsync(user,
                                        new System.Security
                                        .Claims
                                        .Claim(UserFullNameClaims, $"{user.FullName}"));

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
        public async Task <IActionResult> Login(LoginFormModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            Microsoft.AspNetCore.Identity.SignInResult? result =
                await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

            if(!result.Succeeded)
            {
                this.ModelState.AddModelError(string.Empty,
                   "Error while in login in. Contact administrator");
                TempData["ErrorMessage"] = "Error while in login in. Contact administrator";
                return View(model);
            }

            return Redirect(model.ReturnUrl ?? "~/Home/HomeUserIndex");
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

        private void SendRegistrationEmail(string email, string password)
        {
            string smtpServer = "smtp.abv.bg";
            int smtpPort = 465;
            string smtpUsername = "webtruckfounder@abv.bg";
            string smtpPassword = "Aa@123456";

            using (var client = new SmtpClient(smtpServer, smtpPort))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);

                var message = new MailMessage
                {
                    From = new MailAddress(smtpUsername),
                    Subject = "Registration Details",
                    Body = $"Hello,\n\nThank you for registering on our website. Your registration details are:\nEmail: {email}\nPassword: {password}"
                };
                message.To.Add(email);

                client.Send(message);
            }
        }
    }
}
