using System;
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
        public Guid DonationId { get; set; }
        public DateTime DonationDate { get; set; }
        public Donor Donor { get; set; }
        public Guid DonorFK { get; set; }
        public Employee Employee { get; set; }
        public Guid EmployeeFK { get; set; }
        public int BloodQnt { get; set; }
        public BloodTest BloodTest { get; set; }
        public Guid BloodTestFK { get; set; }
        public Visit Visit { get; set; }
        public Guid VisitFK { get; set; }
    }
}
