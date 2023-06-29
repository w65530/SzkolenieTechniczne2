using HotelStorage.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelService.Models
{
    public class ReservationAddModel : ReservationDto
    {
        public List<SelectListItem> Rooms { get; set; }
    }
}
