using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.Models
{
    public class HealthCareInstitution
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

       // public string Title { get; set; }
        public string Type { get; set; }
        public Address Address { get; set; }
        public Guid AddressFK { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Visit> Visits{ get; set; }
    }
}
