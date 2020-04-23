using KraujoBankasASP.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.ViewModels
{
    public class AddEmployeeViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Pakartokite slaptažodį")]
        [Compare("Password", ErrorMessage = "Slaptažodžiai nesutampa")]
        public string PassConfirm { get; set; }

        [Required]
        public string FName { get; set; }

        [Required]
        public string LName { get; set; }

        [Required]
        List<SelectListItem> PositionsList { get; set; }

    }
}
