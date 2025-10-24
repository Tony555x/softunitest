using System;
using code_refactoring.Data;
using code_refactoring.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace code_refactoring.Services
{
    public class AnimalService
    {
        private ApplicationDbContext _db;
        public AnimalService(ApplicationDbContext dbContext) { _db = dbContext; }

        public async Task Heal(int id)
        {
            var x = await _db.Animals.FindAsync(id);
            if (x != null)
            {
                x.Heal();
                Console.WriteLine("Healed animal with id " + id);
            }
            await _db.SaveChangesAsync();
        }

        public async Task AddNewAnimal(string name, string owner, int age, string type)
        {
            var newAnimal = new Animal();
            newAnimal.Id = new Random().Next(1000, 9999);
            newAnimal.Name = name;
            newAnimal.Owner = owner;
            newAnimal.Age = age;
            newAnimal.Type = type;
            newAnimal.Sick = false;
            await _db.Animals.AddAsync(newAnimal);
            await _db.SaveChangesAsync();
        }

        public async Task AllAgeUp()
        {
            foreach (var x in await _db.Animals.ToListAsync())
            {
                x.MakeOlder();
            }
            await _db.SaveChangesAsync();
        }
    }
}
