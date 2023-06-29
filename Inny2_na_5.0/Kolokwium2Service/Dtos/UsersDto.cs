using Kolokwium2Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2Storage.Dtos
{
    public class UsersDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool isAdult { get; set; }
        public string? guardianName { get; set; }
        public string? guardianPhone { get; set; }
        public DateOnly toTrip { get; set; }
        public DateOnly fromTrip { get; set; }
        public int TypeOfTripId { get; set; }
        public string TypeOfTrip { get; set; }
    }
}
