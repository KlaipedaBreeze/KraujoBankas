using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KraujoBankasASP.Models;

namespace KraujoBankasASP.Data
{
    public class KraujoBankasASPContext : DbContext
    {
        public KraujoBankasASPContext (DbContextOptions<KraujoBankasASPContext> options)
            : base(options)
        {
        }

        public DbSet<KraujoBankasASP.Models.Donor> Donor { get; set; }
    }
}
