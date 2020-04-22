using KraujoBankasASP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace KraujoBankasASP.Controllers
{
    public class DonorController : Controller
    {
        private AppDbContext _context;

        private UserManager<User> UserMgr { get; set; }


        public DonorController(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            UserMgr = userManager;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DonorDetails()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(DonorDetailsViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View("DonorDetails", model);
            }

            if (model.Donor != null) {
            var adressFk = _context.Address.Add(model.Address).Entity.Id;

            User user = await UserMgr.GetUserAsync(HttpContext.User);

            var donor = new Donor
            {
                HeightInCM = model.Donor.HeightInCM,
                Weight = model.Donor.Weight,
                Gender = model.Donor.Gender,
                BirthDate = model.Donor.BirthDate,
                AddressFK = adressFk,
                UserFk = user.Id
            };

            _context.Donors.Add(donor);

            _context.SaveChanges();
            }

            return RedirectToAction("Update", "Account", model.User);
        }
    }
}