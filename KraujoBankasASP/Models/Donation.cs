﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.Models
{
    public class Donation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DonationId { get; set; }

        public DateTime DonationDate { get; set; }

        public Donor Donor { get; set; }
        public int DonorFK { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeFK { get; set; }

        public BloodType BloodType { get; set; }
        public int BoodTypeFK { get; set; }

        public int BloodQnt { get; set; }
    }
}
