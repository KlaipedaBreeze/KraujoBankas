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
        public Guid EmployeeId { get; set; }
        public Position Position { get; set; }
        public Guid PositionFk { get; set; }
        public User User { get; set; }
        public Guid UserFk { get; set; }
        public HealthCareInstitution Institution { get; set; }
        public Guid InstitutionFK { get; set; }
        public IEnumerable<Donation> Donations { get; set; }
        public IEnumerable<Reception> Receptions { get; set; }
    }
}
