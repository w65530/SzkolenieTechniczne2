using AnimalsStorage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStorage.Services
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.AnimalTypes.Any())
            {
                var type1 = new AnimalTypes()
                {
                    Id = 1,
                    Name = "Ssaki"
                };
                var type2 = new AnimalTypes()
                {
                    Id = 2,
                    Name = "Ptaki"
                };
                var type3 = new AnimalTypes()
                {
                    Id = 3,
                    Name = "Ryby"
                };
                context.AnimalTypes.AddRange(type1, type2, type3);
            }
            if (!context.Animals.Any())
            {
                var animal1 = new Animals()
                {
                    Id = 1,
                    CageName = "Klatka 1",
                    AnimalName = "Kot",
                    Guardian = "Jan Kowalski",
                    NumberOfAnimals = 1,
                    VetDate = DateTime.Now,
                    AnimalTypeId = 1,
                    ChildrenInCage = false,
                };
                context.Animals.AddRange(animal1);
                context.SaveChanges();
            }
        }
    }
}
