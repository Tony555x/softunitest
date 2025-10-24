using System;
using code_refactoring.Data;
using code_refactoring.Data.Models;

namespace code_refactoring.Services
{
    public class AnimalService
    {
        private ApplicationDbContext _db;
        public AnimalService(ApplicationDbContext dbContext) { _db = dbContext; }

        public void Heal(int id)
        {
            var x = _db.Animals.Find(id);
            if (x != null)
            {
                x.Heal();
                Console.WriteLine("Healed animal with id " + id);
            }
        }

        public void AddNewAnimal(string name, string owner, int age, string type)
        {
            var newAnimal = new Animal();
            newAnimal.id = new Random().Next(1000, 9999);
            newAnimal.Name = name;
            newAnimal.Owner = owner;
            newAnimal.Age = age;
            newAnimal.Type = type;
            newAnimal.Sick = false;
            _db.Animals.Add(newAnimal);
        }

        public void AllAgeUp()
        {
            foreach (var x in _db.Animals.ToList())
            {
                x.MakeOlder();
            }
        }
    }
}
