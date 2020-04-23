using Microsoft.AspNetCore.Identity;

namespace KraujoBankasASP.Models
{
    public static class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<User> userManager, AppDbContext context)
        {
            //asign Admin
            if (userManager.FindByEmailAsync("admin@admin.com").Result == null)
            {
                User user = new User
                {
                    UserName = "admin@admin.com",
                    Email = "admin@admin.com"
                };
                IdentityResult result = userManager.CreateAsync(user, "Admin123!").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
            //asign institution Admin

            if (userManager.FindByEmailAsync("mod@mod.com").Result == null)
            {
                User user = new User
                {
                    UserName = "mod@mod.com",
                    Email = "mod@mod.com"
                };
                IdentityResult result = userManager.CreateAsync(user, "Mod123!").Result;

                if (result.Succeeded)
                {
                    Address Address = new Address
                    {
                        AddressLine = " Naikupės g. 28, Klaipėda"
                    };
                    context.Address.Add(Address);

                    HealthCareInstitution Institution = new HealthCareInstitution
                    {
                        Type = "Nacionalinis kraujo centras",
                        AddressFK= Address.Id
                    };
                    context.HealthCareInstitutions.Add(Institution);

                    Position Position = new Position
                    {
                        Type = "Director"
                    };
                    context.Positions.Add(Position);

                    Employee Epmloyee = new Employee
                    {
                        UserFk= user.Id,
                        PositionFk = Position.PositionId,
                        InstitutionFK = Institution.Id
                    };
                    context.Employees.Add(Epmloyee);
                    
                    context.HealthCareInstitutions.Add(Institution);
                    
                    context.SaveChanges();

                    userManager.AddToRoleAsync(user,"Moderator").Wait();
                }
            }
            //asign Donor
            if (userManager.FindByEmailAsync("donor@donor.com").Result == null)
            {
                User user = new User
                {
                    UserName = "donor@donor.com",
                    Email = "donor@donor.com"
                };
                IdentityResult result = userManager.CreateAsync(user, "Donor123!").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Donor").Wait();
                }
            }
            //create Employee
            if (userManager.FindByEmailAsync("emp@emp.com").Result == null)
            {
                User user = new User
                {
                    UserName = "emp@emp.com",
                    Email = "emp@emp.com"
                };
                IdentityResult result = userManager.CreateAsync(user, "Emp123!").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Employee").Wait();
                }
            }
        }
    }
}