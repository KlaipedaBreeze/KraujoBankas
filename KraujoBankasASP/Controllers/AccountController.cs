using KraujoBankasASP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KraujoBankasASP.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;


        public AccountController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public async Task<IActionResult> Logout(RegisterViewModel model)
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");

        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {

                var user = new AppUser
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                var resultCreateUser = await userManager.CreateAsync(user, model.Password);

                var resultAddRole = await userManager.AddToRoleAsync(user, "Donor");

                if (resultCreateUser.Succeeded && resultAddRole.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return View("DonorAcount");
                }

                foreach (var error in resultCreateUser.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

            }

            return RedirectToAction("index", "home");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

               
                if (result.Succeeded)
                {
                    return View("~/Views/Dashboard/Donor/Index.cshtml");
                }

                ModelState.AddModelError(string.Empty, "Blogas prisijungimas");

            }

            return RedirectToAction("index", "home");
        }
    }
}