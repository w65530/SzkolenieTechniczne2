using Kolokwium1Storage.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;

namespace Kolokwium1Service.Models
{
    public class UczestnicyAddModel : UczestnicyDto
    {
        public List<SelectListItem>? Konkursy { get; set; }
    }
}
