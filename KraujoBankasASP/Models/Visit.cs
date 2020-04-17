using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.Models
{
    public class Visit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid VisitId { get; set; }
        public DateTime DonationDateTime { get; set; }
        public Donor Donor { get; set; }
        public Guid DonorFK { get; set; }
        public Donation Donation { get; set; }
        public HealthCareInstitution Institution { get; set; }
        public Guid InstitutionFK { get; set; }
    }
}
