using Kolokwium2Storage.Dtos;
using Kolokwium2Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2Storage.Services
{
    public interface IAppService
    {
        void Create(UsersDto user);
        List<UsersDto> Read();
        List<TypeOfTrips> ReadTrips();
        void Delete(int id);
    }
}
