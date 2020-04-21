using KraujoBankasASP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Index(List<string> roles)
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
                //ViewData["role"] = "Donor";
                return RedirectToAction("Index", "Donor");

            }
            return RedirectToAction("Home", "Index");
        }
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

                var result = await SignInMgr.PasswordSignInAsync(model.Email, model.Password, false, false);

                var user = await UserMgr.FindByEmailAsync(model.Email);
                var roles = await UserMgr.GetRolesAsync(user);

                if (result.Succeeded)
                {
                    TempData["CurrentUser"] = user.Id;
                    RedirectToAction("Index", roles);
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

        public async Task<IActionResult> Update(User model)
        {
            User user = await UserMgr.FindByNameAsync(model.UserName);

            if (user != null)
            {
                if (!string.IsNullOrEmpty(model.FName))
                    user.FName = model.FName;
                else
                    ModelState.AddModelError("", "Vardas negali buti tuščias");

                if (!string.IsNullOrEmpty(model.LName))
                    user.FName = model.LName;
                else
                    ModelState.AddModelError("", "Pavarde negali buti tuščias");

                IdentityResult result = await UserMgr.UpdateAsync(user);
                if (result.Succeeded)
                {
                    var roles = await UserMgr.GetRolesAsync(user);
                    return RedirectToAction("Index", roles);
                }
                else
                    Errors(result);
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View(user);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}
