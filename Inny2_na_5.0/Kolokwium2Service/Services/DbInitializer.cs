using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kolokwium2Storage.Entities;

namespace Kolokwium2Storage.Services
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.TypeOfTrips.Any())
            {
                var trip1 = new TypeOfTrips()
                {
                    Id = 1,
                    Name = "Zagraniczna"
                };
                var trip2 = new TypeOfTrips()
                {
                    Id = 2,
                    Name = "Jednodniowa"
                };
                var trip3 = new TypeOfTrips()
                {
                    Id = 3,
                    Name = "Z noclegiem"
                };
                context.TypeOfTrips.AddRange(trip1, trip2, trip3);
            }
            if (!context.Users.Any())
            {
                var user1 = new Users()
                {
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    Phone = "123456789",
                    Address = "ul. Kowalska 1",
                    isAdult = true,
                    TypeOfTripId = 1
                };
                var user2 = new Users()
                {
                    FirstName = "Anna",
                    LastName = "Nowak",
                    Phone = "987654321",
                    Address = "ul. Nowakowska 2",
                    isAdult = false,
                    guardianName = "Jan Kowalski",
                    guardianPhone = "123456789",
                    TypeOfTripId = 2
                };
                context.Users.AddRange(user1, user2);
                context.SaveChanges();
            }
        }
    }
}
