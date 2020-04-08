using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.Models
{
    public class BloodTest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public Guid BloodTestId { get; set; }
        public bool IsAbleDonate { get; set; }
        public bool Kell { get; set; }
        public double Hemoglobin  { get; set; }
        public double HBV { get; set; }
        public double HCV { get; set; }
        public double HIV { get; set; }
        public double HTLV { get; set; }
        public double ZIKV { get; set; }
        public Donation Donation { get; set; }
        public BloodType BloodType { get; set; }
        public Guid BoodTypeFK { get; set; }
    }
}
