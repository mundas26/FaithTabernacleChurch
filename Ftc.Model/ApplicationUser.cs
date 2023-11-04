using Microsoft.AspNetCore.Identity;

namespace Ftc.Models
{
    public class ApplicationUser : IdentityUser
    {
        public required string Name { get; set; }
        public required string StreetAddress { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string PostalCode { get; set; }
    }
}
