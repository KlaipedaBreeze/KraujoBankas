using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.Models
{
    public class Reception
    {
        public int ReceptionId { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeFK { get; set; }

        public DateTime DonationDate { get; set; }

        public int BloodQnt { get; set; }

        public BloodType BloodType { get; set; }
        public int BloodTypeFK { get; set; }
    }
}
