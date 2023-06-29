using HotelStorage.Dtos;
using HotelStorage.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStorage.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ReservationDbContext _dbContext;
        public ReservationService(ReservationDbContext dbContext)
        {
            _dbContext = dbContext;
            DbInitializer.Init(_dbContext);
        }
        public void Create(ReservationDto reservation)
        {
            var reservationEntity = new Reservation
            {
                Name = reservation.Name,
                LastName = reservation.LastName,
                Email = reservation.Email,
                Phone = reservation.Phone,
                CheckIn = reservation.CheckIn,
                CheckOut = reservation.CheckOut,
                RoomId = reservation.RoomId,
            };
            _dbContext.Set<Reservation>().Add(reservationEntity);
            _dbContext.SaveChanges();
        }
        public List<ReservationDto> Read()
        {
            var result = _dbContext.Reservations.Select(r => new ReservationDto
            {
                Name = r.Name,
                LastName = r.LastName,
                Email = r.Email,
                Phone = r.Phone,
                CheckIn = r.CheckIn,
                CheckOut = r.CheckOut,
                RoomName = r.Room.Name,
            }).ToList();
            return result;
        }
        public List<Room> ReadRooms()
        {
            return _dbContext.Rooms.ToList();
        }
    }
}
