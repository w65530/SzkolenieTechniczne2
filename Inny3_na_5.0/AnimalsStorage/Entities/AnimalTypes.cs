using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsStorage.Entities
{
    public class AnimalTypes
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
