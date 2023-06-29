using HotelStorage.Dtos;
using HotelStorage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStorage.Services
{
    public class ReservationLocalService : IReservationService
    {
        private static List<ReservationDto> _reservations = new List<ReservationDto>
        {
            new ReservationDto
            {
                Id = 1,
                Name = "Jan",
                LastName = "Kowalski",
                Email = "jan.kowalski@gmail.com",
                Phone = "123456789",
                CheckIn = DateTime.Now,
                CheckOut = DateTime.Now.AddDays(5),
                RoomName = "Pokój 1 (2 piętro, 2 osobowy)",
            },
        };
        public void Create(ReservationDto reservation)
        {
            _reservations.Add(reservation);
        }
        public List<ReservationDto> Read()
        {
            return _reservations;
        }
        public List<Room> ReadRooms()
        {
            throw new NotImplementedException();
        }
    }
}
