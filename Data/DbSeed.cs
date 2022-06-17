using Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DbSeed
    {
        public static void Seed(TheCraftsmanContext context, UserManager<User> userManager)
        {
            if (!context.Roles.Any())
            {
                context.AddRange(
                    new IdentityRole
                    {
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                    new IdentityRole
                    {
                        Name = "User",
                        NormalizedName = "USER"
                    }
                );
            }
            context.SaveChanges();
            if (context.Users.FirstOrDefault(u => u.Email == "admin@abv.bg") == null)
            {
                User admin = new User
                {
                    Email = "admin@abv.bg",
                    UserName = "admin@abv.bg",
                };

                userManager.CreateAsync(admin, "Admin123!").GetAwaiter().GetResult();

                userManager.AddToRoleAsync(admin, "Admin").GetAwaiter().GetResult();

            }
            context.SaveChanges();
        }
    }
}
