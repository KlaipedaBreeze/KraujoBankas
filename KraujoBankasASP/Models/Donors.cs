using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.Models
{
    public class Donors
    {
        public int DonorID { get; set; }
        public int HeightInCm { get; set; }
        public bool WeightOv50 { get; set; }
        public User UserIDFk { get; set; }
    }
}