using Microsoft.AspNetCore.Identity;

namespace CoffeeBuzz.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string StaffID { get; set; }
    }
}
