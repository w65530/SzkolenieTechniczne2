using AnimalsStorage.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnimalsService.Models
{
    public class AddAnimalModel : AnimalsDto
    {
        public List<SelectListItem>? AnimalTypes { get; set; }
    }
}
