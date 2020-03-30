using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.Models
{
    public class User : IdentityUser<int>
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
    }
}
