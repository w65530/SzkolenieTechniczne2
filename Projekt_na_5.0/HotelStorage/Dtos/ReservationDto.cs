﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStorage.Dtos
{
    public class ReservationDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(128, ErrorMessage = "Imię nie może przekroczyć 128 znaków")]
        public string Name { get; set; }
        [Required]
        [MaxLength(128, ErrorMessage = "Nazwisko nie może przekroczyć 128 znaków")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(128, ErrorMessage = "Email nie może przekroczyć 128 znaków")]
        public string Email { get; set; }
        [Required]
        [MaxLength(12, ErrorMessage = "Telefon nie może przekroczyć 12 znaków")]
        public string Phone { get; set; }
        public int RoomId { get; set; }
        public string? RoomName { get; set; }
        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }
    }
}
