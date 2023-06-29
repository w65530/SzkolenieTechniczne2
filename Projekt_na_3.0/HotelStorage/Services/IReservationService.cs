using HotelStorage.Dtos;
using HotelStorage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStorage.Services
{
    public interface IReservationService
    {
        List<ReservationDto> Read();
        void Create(ReservationDto reservation);
        List<Room> ReadRooms();
    }
}
