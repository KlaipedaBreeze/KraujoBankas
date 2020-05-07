using KraujoBankasASP.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoBankasASP.ViewModels
{
    public class InstitutionViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public List<User> Moderators { get; set; }
    }
}
