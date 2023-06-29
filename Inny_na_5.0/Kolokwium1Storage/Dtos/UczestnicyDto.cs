using Kolokwium1Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1Storage.Dtos
{
    public class UczestnicyDto
    {
        public int Id { get; set; }
        [Required]
        public string Imie { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Nazwisko nie może być krósze niż 3 znaków")]
        [MaxLength(125, ErrorMessage = "Nazwisko nie może być dłuższe niż 125 znaków")]
        public string Nazwisko { get; set; }
        [Required]
        public int KonkursId { get; set; }
        public string? KonkursNazwa { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
