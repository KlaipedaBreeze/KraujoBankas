using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KraujoBankasASP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace KraujoBankasASP.Data
{
    public class KraujoBankasASPContext : IdentityDbContext
    {
        public KraujoBankasASPContext (DbContextOptions<KraujoBankasASPContext> options)
            : base(options)
        {
        }

        public DbSet<KraujoBankasASP.Models.Donor> Donor { get; set; }
    }
}
