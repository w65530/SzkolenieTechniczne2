using Kolokwium1Storage.Dtos;
using Kolokwium1Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1Storage.Services
{
    public interface IUczestnicyService
    {
        void Create(UczestnicyDto dto);
        List<UczestnicyDto> Read();
        void Update(UczestnicyDto dto);
        void Delete(int id);
        List<Konkursy> ReadKonkursy();
    }
}
