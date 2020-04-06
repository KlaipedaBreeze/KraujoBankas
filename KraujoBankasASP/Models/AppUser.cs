using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.Models
{
    public class AppUser : IdentityUser
    {
        public Donor Donor { get; set; }

        public Employee Employee { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public string phones { get; set; }
    }
}
