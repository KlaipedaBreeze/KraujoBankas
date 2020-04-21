using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.Models
{
    public class User : IdentityUser
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }

       // public DateTime BirthDate { get; set; }
        public string PersonalIDNumber { get; set; }
        public bool RegComplete { get; set; }
        public Donor Donor { get; set; }
        public Employee Employee { get; set; }
    }
}
