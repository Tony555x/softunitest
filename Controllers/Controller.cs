using code_refactoring.Data;
using code_refactoring.Data.Models;
using code_refactoring.Models;
using code_refactoring.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace code_refactoring.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalsController : ControllerBase
    {
        private ApplicationDbContext _db;
        private AnimalService _service;

        public AnimalsController(ApplicationDbContext dbContext, AnimalService animalService)
        {
            _db = dbContext;
            _service = animalService;
        }

        [HttpGet("getall")]
        public async Task<List<AnimalDetails>> GetAllAnimals()
        {

            return (await _db.Animals.ToListAsync()).Select(a=>new AnimalDetails(a)).ToList();
        }

        [HttpGet("getone/{x}")]
        public async Task<AnimalDetails?> GetAnimal(int x)
        {
            Animal? a = await _db.Animals.FindAsync(x);
            if (a == null) return null;
            return new AnimalDetails(a);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddAnimal([FromQuery] string name, string owner, int age, string type)
        {
            await _service.AddNewAnimal(name, owner, age, type);
            return Ok("Animal Added.");
        }

        [HttpPost("heal/{id}")]
        public async Task<IActionResult> HealAnimal(int id)
        {
            await _service.Heal(id);
            return Ok("Animal Healed.");
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            var a = await _db.Animals.FindAsync(id);
            if (a != null)
            {
                _db.Animals.Remove(a);
                return Ok("Animal Removed.");
            }
            else
            {
                return NotFound("Animal not found.");
            }
        }

        [HttpPost("ageup")]
        public async Task<IActionResult> AgeUp()
        {
            await _service.AllAgeUp();
            return Ok("All animal ages increased.");
        }
    }
}
