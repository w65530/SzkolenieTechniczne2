using AnimalsStorage.Dtos;
using AnimalsStorage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStorage.Services
{
    public class AppService : IAppService
    {
        private readonly AppDbContext _context;
        public AppService(AppDbContext context) {
            _context = context;
            DbInitializer.Initialize(_context);
        }
        public void Create(AnimalsDto animal)
        {
            var model = new Animals
            {
                Id = animal.Id,
                CageName = animal.CageName,
                AnimalName = animal.AnimalName,
                Guardian = animal.Guardian,
                NumberOfAnimals = animal.NumberOfAnimals,
                VetDate = animal.VetDate,
                AnimalTypeId = animal.AnimalTypeId,
                ChildrenInCage = animal.ChildrenInCage,
                NumberOfChildren = animal.NumberOfChildren,
                ChildrenAge = animal.ChildrenAge
            };
            _context.Set<Animals>().Add(model);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var animal = _context.Animals.FirstOrDefault(animal => animal.Id == id);
            if (animal != null)
            {
                _context.Animals.Remove(animal);
                _context.SaveChanges();
            }
        }

        public List<AnimalsDto> Read()
        {
            var animals = _context.Animals.Select(animal => new AnimalsDto
            {
                Id = animal.Id,
                CageName = animal.CageName,
                AnimalName = animal.AnimalName,
                Guardian = animal.Guardian,
                NumberOfAnimals = animal.NumberOfAnimals,
                VetDate = animal.VetDate,
                AnimalTypeName = animal.AnimalType.Name,
                ChildrenInCage = animal.ChildrenInCage,
                NumberOfChildren = animal.NumberOfChildren,
                ChildrenAge = animal.ChildrenAge
            }).ToList();
            return animals;
        }

        public List<AnimalTypes> ReadTypes()
        {
            return _context.AnimalTypes.ToList();
        }
    }
}
