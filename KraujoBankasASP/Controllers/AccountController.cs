using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KraujoBankasASP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await SignInMgr.PasswordSignInAsync(
                    model.UsernameOrEmail, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await SignInMgr.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Register()
        {
            try
            {
                ViewBag.Message = "User already registered";
                User usr = await UserMgr.FindByNameAsync("TestUser");
                if (usr == null)
                {
                    usr = new User();
                    usr.UserName = "TestUser";
                    usr.Vardas = "Vardenis";
                    usr.Pavarde = "Pavardenis";
                    usr.Email = "testas@testas.lt";

                    IdentityResult result = await UserMgr.CreateAsync(usr,"Test123!");
                    if (result.Succeeded)
                    {
                        ViewBag.Message = "User has been created";
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