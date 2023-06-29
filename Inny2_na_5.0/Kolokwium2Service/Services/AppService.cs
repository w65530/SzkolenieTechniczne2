using Kolokwium2Storage.Dtos;
using Kolokwium2Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2Storage.Services
{
    public class AppService : IAppService
    {
        private readonly AppDbContext _context;
        public AppService(AppDbContext context) {
            _context = context;
            DbInitializer.Initialize(_context);
        }
        public void Create(UsersDto user)
        {
            var model = new Users
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                Address = user.Address,
                isAdult = user.isAdult,
                guardianName = user.guardianName,
                guardianPhone = user.guardianPhone,
                toTrip = user.toTrip,
                fromTrip = user.fromTrip,
                TypeOfTripId = user.TypeOfTripId
            };
            _context.Users.Add(model);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.Users.FirstOrDefault(user => user.Id == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public List<UsersDto> Read()
        {
            var users = _context.Users.Select(user => new UsersDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                Address = user.Address,
                isAdult = user.isAdult,
                guardianName = user.guardianName,
                guardianPhone = user.guardianPhone,
                toTrip = user.toTrip,
                fromTrip = user.fromTrip,
                TypeOfTripId = user.TypeOfTripId,
                TypeOfTrip = user.TypeOfTrip.Name
            }).ToList();
            return users;
        }

        public List<TypeOfTrips> ReadTrips()
        {
            return _context.TypeOfTrips.ToList();
        }
    }
}
