using System;
using code_refactoring.Data;
using code_refactoring.Data.Models;

namespace code_refactoring.Services
{
    public class AnimalService
    {
        private ApplicationDbContext _db;
        public AnimalService(ApplicationDbContext d) { _db = d; }

        public void DoHeal(int id)
        {
            var x = _db.Animals.Find(id);
            if (x != null)
            {
                x.Heal();
                Console.WriteLine("Healed animal id=" + id);
            }
        }

        public void AddNewAnimal(string n, string o, int a, string t)
        {
            var newAnimal = new Animal();
            newAnimal.id = new Random().Next(1000, 9999);
            newAnimal.Namez = n;
            newAnimal.OwNer = o;
            newAnimal.agee = a;
            newAnimal.typee = t;
            newAnimal.sickOrNot = false;
            _db.Animals.Add(newAnimal);
        }

        public void RandomAgeUp()
        {
            foreach (var x in _db.Animals.ToList())
            {
                x.agee += 7;
            }
        }
    }
}
