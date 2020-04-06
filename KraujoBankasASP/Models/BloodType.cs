﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.Models
{
    public class BloodType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BloodId { get; set; }
        public string Type { get; set; }

        public ICollection<Reception> Receptions { get; set; }
        public ICollection<Donation> Donations { get; set; }

    }
}
