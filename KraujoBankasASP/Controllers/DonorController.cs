using KraujoBankasASP.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace KraujoBankasASP.Controllers
{
    public class DonorController : Controller
    {
        private AppDbContext _context;

        public DonorController(AppDbContext context)
        {
            _context = context;
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
        public IActionResult Create(DonorDetailsViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View("DonorDetails", model);
            }

            var adressFk = _context.Address.Add(model.Address).Entity.Id;

            _context.SaveChanges();

            var donor = new Donor
            {
                HeightInCM = model.Donor.HeightInCM,
                Weight = model.Donor.Weight,
                Gender = model.Donor.Gender,
                BirthDate = model.Donor.BirthDate,
                AddressFK = adressFk,
                UserFk = "19d8723f-2734-4e87-bfd5-7e0c43933f47"
            };

            _context.Donors.Add(donor);

            _context.SaveChanges();

            return RedirectToAction("Update", "Account", model.User);
        }
    }
}