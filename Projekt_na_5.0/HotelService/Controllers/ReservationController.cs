using HotelService.Models;
using HotelStorage.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelService.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        public IActionResult Index()
        {
            var result = _reservationService.Read();
            return View(result);
        }
        public IActionResult Add()
        {
            var model = new ReservationAddModel();
            model.Rooms = _reservationService.ReadRooms()
                .Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(ReservationAddModel model)
        {
            if (ModelState.IsValid)
            {
                _reservationService.Create(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
