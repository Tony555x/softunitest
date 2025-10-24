using code_refactoring.Data;
using code_refactoring.Data.Models;
using code_refactoring.Services;
using Microsoft.AspNetCore.Mvc;
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
        public List<Animal> GetAllAnimals()
        {

            return _db.Animals.ToList();
        }

        [HttpGet("getone/{x}")]
        public Animal GetOneAnimal(int x)
        {
            return _db.Animals.Find(x);
        }

        [HttpPost("add")]
        public string AddAnimal([FromQuery] string name, string owner, int age, string type)
        {
            _service.AddNewAnimal(name, owner, age, type);
            return "200? most probably.";
        }

        [HttpPost("heal/{id}")]
        public string HealAnimal(int id)
        {
            _service.Heal(id);
            return "Animal is healed... maybe. What status code?";
        }

        [HttpDelete("delete/{id}")]
        public string DeleteAnimal(int id)
        {
            _db.Remove(id);
            return "removed i think";
        }

        [HttpPost("ageup")]
        public string AgeUp()
        {
            _service.AllAgeUp();
            return "everyone got older";
        }
    }
}
