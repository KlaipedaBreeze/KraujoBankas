
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KraujoBankasASP.Models
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        { }

        public DbSet<Address> Address { get; set; }
        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<HealthCareInstitution> HealthCareInstitutions { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Reception> Receptions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Donor>()
                          .HasOne(d => d.User)
                          .WithOne(u => u.Donor)
                          .HasForeignKey<Donor>(d => d.UserFk);

            modelBuilder.Entity<Donor>()
                        .HasMany(d => d.Donations)
                        .WithOne(d => d.Donor)
                        .HasForeignKey(d => d.DonorFK);



            modelBuilder.Entity<Employee>()
                        .HasOne(e => e.User)
                        .WithOne(u => u.Employee)
                        .HasForeignKey<Employee>(e => e.UserFk);

            modelBuilder.Entity<Employee>()
                       .HasMany(e => e.Donations)
                       .WithOne(d => d.Employee)
                        .HasForeignKey(d => d.EmployeeFK)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                        .HasMany(e => e.Receptions)
                        .WithOne(r => r.Employee)
                        .HasForeignKey(r => r.EmployeeFK);

            modelBuilder.Entity<Employee>()
                        .HasOne(e => e.Institution)
                        .WithMany(i => i.Employees)
                        .HasForeignKey(e => e.InstitutionFK);

            modelBuilder.Entity<Position>()
                        .HasMany(a => a.Employees)
                        .WithOne(e => e.Position)
                        .HasForeignKey(p => p.PositionKF);

            modelBuilder.Entity<Address>()
                        .HasMany(a => a.Institutions)
                        .WithOne(i => i.Address)
                        .HasForeignKey(i => i.AddressFK);

            modelBuilder.Entity<Address>()
                        .HasMany(a => a.Donors)
                        .WithOne(u => u.Address)
                        .HasForeignKey(u => u.AddressFK);

            modelBuilder.Entity<BloodType>()
                        .HasMany(b => b.Donations)
                        .WithOne(d => d.BloodType)
                        .HasForeignKey(d => d.BoodTypeFK);

            modelBuilder.Entity<BloodType>()
                        .HasMany(b => b.Receptions)
                        .WithOne(r => r.BloodType)
                        .HasForeignKey(r => r.BloodTypeFK);

            //modelBuilder.Seed();
        }

    }
}
