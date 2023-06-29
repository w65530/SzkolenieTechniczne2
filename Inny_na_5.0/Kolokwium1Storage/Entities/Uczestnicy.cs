using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1Storage.Entities
{
    public class Uczestnicy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Imie { get; set; }
        [Required]
        [MinLength (3)]
        [MaxLength (125)]
        public string Nazwisko { get; set; }
        [Required]
        public int KonkursId { get; set; }
        public Konkursy Konkurs { get; set; }  
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
