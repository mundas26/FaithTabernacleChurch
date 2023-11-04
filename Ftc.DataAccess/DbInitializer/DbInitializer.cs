using Ftc.DataAccess.Data;
using Ftc.Models;
using Ftc.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Ftc.DataAccess.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public DbInitializer(ApplicationDbContext db, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // Comment explaining the purpose of the Initializer method
        public void Initializer()
        {
            try
            {
                // Check if there are pending database migrations
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    // Apply pending database migrations
                    _db.Database.Migrate();
                }
            }
            catch (Exception)
            {
                // Handle any exceptions that might occur during migration
            }

            // Create a new Identity role named "Role_Admin"
            _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).GetAwaiter().GetResult();

            // Create a new ApplicationUser and associate it with a user
            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "ftc.placer@gmail.com",
                Email = "ftc.placer@gmail.com",
                Name = "Faith tabernacle church",
                PhoneNumber = "09353376348",
                StreetAddress = "Mapaso, Placer Surigao Del Norte",
                State = "Region 13",
                PostalCode = "8405",
                City = "Surigao Del Norte"
            }, "@Ftc123").GetAwaiter().GetResult();

            // Find the ApplicationUser by email
            ApplicationUser? user = _db.applicationUsers.FirstOrDefault(u => u.Email == "ftc.placer@gmail.com");

            // Add the user to the "Role_Admin" role, but only if 'user' is not null
            if (user != null)
            {
                _userManager.AddToRoleAsync(user, SD.Role_Admin).GetAwaiter().GetResult();
            }

            // Return from the method
            return;
        }
    }
}
