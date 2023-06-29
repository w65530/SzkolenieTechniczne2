using Kolokwium2MVC.Models;
using Kolokwium2Storage.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kolokwium2MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly IAppService _appService;
        public UsersController(IAppService appService)
        {
            _appService = appService;
        }
        public IActionResult Index()
        {
            var users = _appService.Read();
            return View(users);
        }
        public IActionResult Create()
        {
            var model = new AddUserModel();
            model.TypeOfTrips = _appService.ReadTrips().Select(trip => new SelectListItem()
            {
                Value = trip.Id.ToString(),
                Text = trip.Name
            }).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(AddUserModel user)
        {
            if(ModelState.IsValid)
            {
                _appService.Create(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var user = _appService.Read().FirstOrDefault(user => user.Id == id);
            // convert System.DateTime.Now to DateOnly
            if (!user.fromTrip < System.DateTime.Now)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            _appService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
