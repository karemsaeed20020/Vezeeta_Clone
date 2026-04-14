

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Vezeeta.Data.Commons;
using Vezeeta.Data.Entities;

namespace Vezeeta.Infrastructure.Seeder
{
    public static class UserSeeder
    {
        public static async Task SeedUsersAsync(UserManager<ApplicationUser> _userManager)
        {
            var usersCount = await _userManager.Users.CountAsync();
            if (usersCount == 0)
            {
                var defaultUserAdmin = new ApplicationUser
                {
                    UserName = "Admin",
                    Email = "Admin@vezeeta.com",
                    FirstName = "Admin",
                    LastName = "Admin",
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow,
                    PhoneNumber = "01000000000",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await _userManager.CreateAsync(defaultUserAdmin, "Admin@123ADM567");
                await _userManager.AddToRoleAsync(defaultUserAdmin, Roles.Admin);
            }
        }
    }
}
