using AnimalsStorage.Dtos;
using AnimalsStorage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStorage.Services
{
    public interface IAppService
    {
        void Create(AnimalsDto user);
        List<AnimalsDto> Read();
        List<AnimalTypes> ReadTypes();
        void Delete(int id);
    }
}
