using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2Storage.Entities
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(128)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(128)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(128)]
        public string Address { get; set; }
        [Required]
        public bool isAdult { get; set; }
        [MaxLength(256)]
        public string? guardianName { get; set; }
        [MaxLength(11)]
        public string? guardianPhone { get; set; }
        public DateOnly toTrip { get; set; }
        public DateOnly fromTrip { get; set; }
        public int TypeOfTripId { get; set; }
        public TypeOfTrips? TypeOfTrip { get; set; }
    }
}
