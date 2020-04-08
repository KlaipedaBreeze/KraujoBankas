using Microsoft.AspNetCore.Identity;

namespace KraujoBankasASP.Models
{
    public static class ApplicationDbInitializer
    {
        
        public static void SeedUsers(UserManager<AppUser> userManager)
        {


            //asign Admin

            if (userManager.FindByEmailAsync("admin@admin.com").Result == null)
            {
                AppUser user = new AppUser
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

            if (userManager.FindByEmailAsync("Iadmin@admin.com").Result == null)
            {
                AppUser user = new AppUser
                {
                    UserName = "Iadmin@admin.com",
                    Email = "Iadmin@admin.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "Iadmin123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Institution admin").Wait();
                }
            }


            //asign Donor

            if (userManager.FindByEmailAsync("donor@donor.com").Result == null)
            {
                AppUser user = new AppUser
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
                AppUser user = new AppUser
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
