using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStorage.Entities
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MinLength(128)]
        public string Name { get; set; }
        [Required]
        [MinLength(128)]
        public string LastName { get; set; }
        [Required]
        [MinLength(128)]
        public string Email { get; set; }
        [Required]
        [MinLength(12)]
        public string Phone { get; set; }
        [Required]
        public int RoomId { get; set; }
        public Room Room { get; set; }
        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }
    }
}
