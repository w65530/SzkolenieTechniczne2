using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStorage.Dtos
{
    public class ReservationDto
    {
        [Required]
        [MinLength(128, ErrorMessage = "Imię nie może przekroczyć 128 znaków")]
        public string Name { get; set; }
        [Required]
        [MinLength(128, ErrorMessage = "Nazwisko nie może przekroczyć 128 znaków")]
        public string LastName { get; set; }
        [Required]
        [MinLength(128, ErrorMessage = "Email nie może przekroczyć 128 znaków")]
        public string Email { get; set; }
        [Required]
        [MinLength(12, ErrorMessage = "Telefon nie może przekroczyć 12 znaków")]
        public string Phone { get; set; }
        [Required]
        public int RoomId { get; set; }
        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }
        public string RoomName { get; set; }
        public int Id { get; set; }
    }
}
