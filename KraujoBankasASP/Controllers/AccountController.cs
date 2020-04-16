using KraujoBankasASP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace KraujoBankasASP.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> UserMgr { get; }
        private SignInManager<User> SignInMgr { get; }

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            UserMgr = userManager;
            SignInMgr = signInManager;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

                var result = await SignInMgr.PasswordSignInAsync(model.Email, model.Password, false, false);
                
                var user = await UserMgr.FindByEmailAsync(model.Email);
                var roles = await UserMgr.GetRolesAsync(user);

                if (result.Succeeded)
                {


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

                }

                ModelState.AddModelError(string.Empty, "Slaptažodis arba prisijungimo vardas netinkamas");

            }

            return View("IncorectLoging");
        }


        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await SignInMgr.SignOutAsync();
            return RedirectToAction("index", "home");
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            try
            {
                ViewBag.Message = "Toks vartotojo vardas jau registruotas";
                User usr = await UserMgr.FindByNameAsync(model.Email);
                if (usr == null)
                {
                    usr = new User
                    {
                        UserName = model.Email,
                        Email = model.Email
                    };

                    IdentityResult result = await UserMgr.CreateAsync(usr, model.Password);
                    if (result.Succeeded)
                    {
                        ViewBag.Message = "Vartotojas sukurtas";
                    }
                    else
                    {
                        ViewBag.Message = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }
            return View();
        }

    }
}
