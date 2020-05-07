using KraujoBankasASP.Models;
using KraujoBankasASP.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KraujoBankasASP.Controllers
{
    public class AdminController : Controller
    {
        private AppDbContext _context;
        public AdminController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<InstitutionsViewModel> institutions = from i in _context.HealthCareInstitutions
                                                        join a in _context.Address on i.AddressFK equals a.Id
                                                        select
                                                        new InstitutionsViewModel
                                                        {
                                                            Id = i.Id,
                                                            Title = i.Type,
                                                            Type = i.Type,
                                                            Adress = a.AddressLine
                                                        };

            return View("Index", institutions.ToList());
        }


        [HttpGet]
        public IActionResult InstitutionGet(Guid id)
        {
            var model = getInstitution(id);
            return View("InstitutionGet", model);
        }

        [HttpGet]
        public IActionResult InstitutionEdit(Guid id)
        {
            var model = getInstitution(id);
            return View("InstitutionEdit", model);
        }


        [HttpGet]
        public IActionResult InstitutionAdd()
        {
            return View("InstitutionCreate");
        }

        [HttpPost]
        public IActionResult InstitutionCreate()
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult InstitutionUpdate() 
        {
            return RedirectToAction("Index");
        }

        private InstitutionViewModel getInstitution(Guid id) {
            var moderators = from e in _context.Employees
                             join i in _context.HealthCareInstitutions on e.InstitutionFK equals i.Id
                             join u in _context.Users on e.UserFk equals u.Id
                             join ur in _context.UserRoles on u.Id equals ur.UserId
                             join r in _context.Roles on ur.RoleId equals r.Id
                             where i.Id == id
                             select
                             new User
                             {
                                 FName = u.FName,
                                 LName = u.LName,
                                 Phone = u.Phone
                             };

            var institution = _context.HealthCareInstitutions.Join(_context.Address,
                i => i.AddressFK,
                a => a.Id,
                (institution, address) =>
                new
                {
                    Id = institution.Id,
                    Title = institution.Type,
                    Type = institution.Type,
                    Address = address.AddressLine
                })
                .Where(i => i.Id == id).SingleOrDefault();


            InstitutionViewModel model = new InstitutionViewModel
            {
                Id = institution.Id,
                Title = institution.Type,
                Type = institution.Type,
                Address = institution.Address,
                Moderators = moderators.ToList()
            };

            return model;
        }
    }
}