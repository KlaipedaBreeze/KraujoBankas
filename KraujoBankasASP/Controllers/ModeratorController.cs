using KraujoBankasASP.Models;
using KraujoBankasASP.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.Controllers
{
    public class ModeratorController : Controller
    {
        private UserManager<User> UserMgr { get; set; }
        private AppDbContext _context;

        public ModeratorController(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            UserMgr = userManager;
        }

        public async Task<IActionResult> Index()
        {
            User CurrentUser = await UserMgr.GetUserAsync(HttpContext.User);

            var emp = _context.Employees.ToList();

            List<Employee> employees = new List<Employee>()
            {
                    new Employee{PositionFk=emp[0].PositionFk}
            };
            return View("Index");
        }

        [HttpGet]
        public IActionResult CreateEmployee()
        {
            List<SelectListItem> Options = _context.Positions.Select(a =>
                              new SelectListItem
                              {
                                  Value= a.PositionId.ToString(),
                                  Text = a.Type
                              }).ToList();


            //var model = new AddEmployeeViewModel
            //{
            //    PositionsList = Options
            //};

            return View("AddEmployee");
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(AddEmployeeViewModel model)
        {
            var user = new User
            {
                UserName = model.Email,
                FName = model.FName,
                LName = model.LName
            };

            var result = await UserMgr.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                User Currentuser = await UserMgr.GetUserAsync(HttpContext.User);

                var epmloyee = new Employee
                {
                    //PositionFk = model.PositionFk,
                    InstitutionFK = Currentuser.Employee.InstitutionFK,
                    UserFk = user.Id
                };

                _context.Employees.Add(epmloyee);
                _context.SaveChanges();
            }



            return View("AddEmployee", model);
        }
    }
}