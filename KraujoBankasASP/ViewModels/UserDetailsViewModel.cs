 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.Models
{
    public class UserDetailsViewModel
    {
        public User User { get; set; }
        public Donor Donor { get; set; }
        public Address Address { get; set; }
    
    }
}
