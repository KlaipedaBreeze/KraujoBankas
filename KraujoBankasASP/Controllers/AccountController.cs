using KraujoBankasASP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KraujoBankasASP.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> UserMgr { get; set; }
        private SignInManager<User> SignInMgr { get; set; }

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            UserMgr = userManager;
            SignInMgr = signInManager;
        }

        public async Task<IActionResult> ControlCenter()
        {
            User user = await UserMgr.GetUserAsync(HttpContext.User);
            var roles = await UserMgr.GetRolesAsync(user);
            var IsCompleted = user.RegComplete;
            return Index(roles, IsCompleted);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(IList<string> roles, bool completed)
        {
            if (!completed)
            {
                ViewData["IsShowSideNav"] = false;
                return View("InfoToConfirm");
            }

            if (roles.Contains("Admin"))
            {
                return RedirectToAction("Index", "Admin");
            }

            if (roles.Contains("Institution admin"))
            {
                return RedirectToAction("Index", "Moderator");
            }

            if (roles.Contains("Employee"))
            {
                return RedirectToAction("Index", "Employee");
            }

            if (roles.Contains("Donor"))
            {
                return RedirectToAction("Index", "Donor");
            }
            return RedirectToAction("Home", "Index");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await SignInMgr.PasswordSignInAsync(model.Email, model.Password, false, true);

                if (result.Succeeded)
                {
                    var user = await UserMgr.FindByEmailAsync(model.Email);
                    var roles = await UserMgr.GetRolesAsync(user);

                    return Index(roles, user.RegComplete);
                }

                ModelState.AddModelError(string.Empty, "Slaptažodis arba prisijungimo vardas netinkamas");
            }
            return View("IncorectLogin");
        }


        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await SignInMgr.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                var result = await UserMgr.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await SignInMgr.SignInAsync(user, isPersistent: false);
                    var roles = new List<string> { "Donor" };
                    return Index(roles, false);
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        public async Task<IActionResult> Update(User model)
        {
            User user = await UserMgr.GetUserAsync(HttpContext.User);

            user.FName = model.FName;
            user.FName = model.LName;
            user.RegComplete = true;

            IdentityResult result = await UserMgr.UpdateAsync(user);
            if (result.Succeeded)
            {
                var roles = await UserMgr.GetRolesAsync(user);
                return Index(roles, true);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Atnaujinimas neĮvyko");
                return RedirectToAction("InfoToConfirm", "Account");
            }
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}
