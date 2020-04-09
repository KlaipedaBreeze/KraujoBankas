using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.Models
{
    public class Donor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DonorId { get; set; }
        public int HeightInCM { get; set; }
        public bool WeightOver50 { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
        public Guid AddressFK { get; set; }
        public IEnumerable<Donation> Donations { get; set; }
        public IEnumerable<Visit> Visits { get; set; }
        public User User { get; set; }
        public Guid UserFk { get; set; }
    }
}
