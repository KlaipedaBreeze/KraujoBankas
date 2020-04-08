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

                var result = await SignInMgr.PasswordSignInAsync(model.Email, model.Password, false, false);


                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                    //return View("Login");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await SignInMgr.SignOutAsync();
            return RedirectToAction("Index", "Home");
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
                    usr = new User();
                    usr.UserName = model.Email;
                    usr.Email = model.Email;

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