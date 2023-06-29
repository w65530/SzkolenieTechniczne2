using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStorage.Entities
{
    public class Animals
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string CageName { get; set; }
        [Required]
        [MaxLength(128)]
        public string AnimalName { get; set; }
        [Required]
        [MaxLength(128)]
        public string Guardian { get; set; }
        [Required]
        public int NumberOfAnimals { get; set; }
        [Required]
        public DateTime VetDate { get; set; }
        public AnimalTypes? AnimalType { get; set; }
        public int AnimalTypeId { get; set; }
        [Required]
        public bool ChildrenInCage { get; set; }
        public int NumberOfChildren { get; set; }
        public int ChildrenAge { get; set; }
    }
}
