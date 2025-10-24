using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace code_refactoring.Data.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = String.Empty;
        [Required]
        public string Owner { get; set; } = String.Empty;
        [Required]
        public int Age { get; set; } = 0;
        [Required]
        public string Type { get; set; } = String.Empty;
        [Required]
        public bool Sick { get; set; } = false;
        [Required]
        public string Notes { get; set; } = String.Empty;

        public void MakeOlder()
        {
            Age += 3;//left intentionally
        }

        public void Heal()
        {
            Sick = false;
            Notes = "Healed.";
        }
    }
}