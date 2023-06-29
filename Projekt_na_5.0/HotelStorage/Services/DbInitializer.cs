using HotelStorage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStorage.Services
{
    public static class DbInitializer
    {
        public static void Init(ReservationDbContext context)
        {
            if (!context.Rooms.Any())
            {
                var entity1 = new Room
                {
                    Id = 1,
                    Name = "Pokój 1",
                    NumberOfBeds = 2,
                };
                var entity2 = new Room
                {
                    Id = 2,
                    Name = "Pokój 2",
                    NumberOfBeds = 3,
                };
                context.Rooms.AddRange(entity1, entity2);
                context.SaveChanges();
            }
        }
    }
}
