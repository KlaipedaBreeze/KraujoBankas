using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        public Position Position { get; set; }
        public int PositionKF { get; set; }

        public AppUser User { get; set; }
        public string UserFk { get; set; }

        public HealthCareInstitution Institution { get; set; }
        public int InstitutionFK { get; set; }


        public IEnumerable<Donation> Donations { get; set; }
        public IEnumerable<Reception> Receptions { get; set; }


    }
}
