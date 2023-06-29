using Kolokwium2Storage.Dtos;
using Kolokwium2Storage.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kolokwium2MVC.Models
{
    public class AddUserModel : UsersDto
    {
        public List<SelectListItem>? TypeOfTrips { get; set; }
    }
}
