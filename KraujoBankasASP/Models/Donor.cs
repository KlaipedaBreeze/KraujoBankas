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
        public int DonorId { get; set; }
        public int WeightInKg { get; set; }
        public int HeightInCM { get; set; }
        public DateTime BirthDate { get; set; }

        public Address Address { get; set; }
        public int AddressFK { get; set; }

        public IEnumerable<Donation> Donations { get; set; }

        public AppUser User { get; set; }
        public string UserFk { get; set; }
    }
}
