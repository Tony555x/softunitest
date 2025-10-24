using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace code_refactoring.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; } = String.Empty;
        [Required]
        public string LastName { get; set; } = String.Empty;
        [Required]
        List<Animal> Animals { get; set; } = new List<Animal>();
    }
}