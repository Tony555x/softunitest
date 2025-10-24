using code_refactoring.Data;
using code_refactoring.Data.Models;
using code_refactoring.Services;
using Microsoft.AspNetCore.Mvc;
namespace code_refactoring.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalzController : ControllerBase
    {
        private ApplicationDbContext db;
        private AnimalService servicer;

        public AnimalzController(ApplicationDbContext d, AnimalService s)
        {
            db = d;
            servicer = s;
        }

        [HttpGet("getall")]
        public List<Stoka> GetAllAnimals()
        {

            return db.Stoki.ToList();
        }

        [HttpGet("getone/{x}")]
        public Stoka GetOneAnimal(int x)
        {
            return db.Stoki.Find(x);
        }

        [HttpPost("add")]
        public string AddAnimal([FromQuery] string n, string o, int a, string t)
        {
            servicer.AddNewAnimal(n, o, a, t);
            return "200? most probably.";
        }

        [HttpPost("heal/{id}")]
        public string HealAnimal(int id)
        {
            servicer.DoHeal(id);
            return "Animal is healed... maybe. What status code?";
        }

        [HttpDelete("delete/{id}")]
        public string DeleteAnimal(int id)
        {
            db.Remove(id);
            return "removed i think";
        }

        [HttpPost("ageup")]
        public string AgeUp()
        {
            servicer.RandomAgeUp();
            return "everyone got older";
        }
    }
}
