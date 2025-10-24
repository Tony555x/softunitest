using Microsoft.AspNetCore.Identity;

namespace code_refactoring.Data.Models
{
    public class Potrebitel : IdentityUser
    {
        public string purvoime { get; set; }
        public string LastName { get; set; }
    }
}